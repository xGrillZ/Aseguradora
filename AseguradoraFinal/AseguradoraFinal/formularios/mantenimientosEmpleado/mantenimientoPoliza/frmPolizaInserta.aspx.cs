using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoPoliza
{
    public partial class frmPolizaInserta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.cargaListaCoberturaPoliza();
                this.cargaDocCoberturaPoliza();
                this.cargaDocEmpleado();
            }
        }

        protected void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            this.AlmacenarDatos();
        }

        /// <summary>
        /// Carga la lista de cobertura poliza
        /// </summary>
        void cargaListaCoberturaPoliza()
        {
            ///Creación de la instancia a la clase BLCoberturaPoliza
            BLCoberturaPoliza oCoberturaPoliza = new BLCoberturaPoliza();

            ///indicarle al dropdownlist la fuente de datos
            this.ddlCoberturaPoliza.DataSource = oCoberturaPoliza.retornaCoberturaPoliza();

            ///indicarle al dropdownlist que se muestre
            this.ddlCoberturaPoliza.DataBind();
        }

        /// <summary>
        /// Carga la información de cobertura póliza
        /// </summary>
        void cargaDocCoberturaPoliza()
        {
            ///Creación de la instancia a la clase BLCoberturaPoliza
            BLCoberturaPoliza oCoberturaPoliza = new BLCoberturaPoliza();

            pa_RetornaCoberturaPolizaID_Result resultado = oCoberturaPoliza.retornaCoberturaPolizaID(Convert.ToInt16(this.ddlCoberturaPoliza.SelectedValue));

            this.txtPorcentajeCobertura.Text = resultado.porcentaje.ToString();

            /*string registro = DateTime.Now.ToString();
            this.txtFechaRegistro.Text = registro;*/

        }

        /// <summary>
        /// Carga la información de adicciones
        /// </summary>
        void cargaDocAdicciones()
        {
            ///Creación de la instancia a la clase BLPoliza
            BLPoliza oPoliza = new BLPoliza();
            ///Creación de la instancia a la clase BLCliente
            BLCliente oCliente = new BLCliente();

            ///Creación de la variable que almacena el resultado del procedimiento almacenado
            pa_RetornaClienteCed_Result resultadoCliente = oCliente.retornaClienteCedPoliza(this.txtCedCliente.Text);
            ///Creación de la variable que almacena el resultado del procedimiento almacenado
            pa_RetornaAdiccionesCantidad_Result resultadoCantidad = oPoliza.retornaAdiccionesCantidad(resultadoCliente.idCliente);
            ///Inserción del dato obtenido por el procedimiento almacenado
            this.txtCantidadAdicciones.Text = resultadoCantidad.cantAdiccion.ToString();
            this.hdIdCliente.Value = resultadoCliente.idCliente.ToString();

            if (resultadoCliente == null)
            {
                this.txtCantidadAdicciones.Text = "0";
            }
        }

        /// <summary>
        /// Carga la información de cliente
        /// </summary>
        void cargaDocEmpleado()
        {
            ///Creación de la instancia a la clase BLEmpleado
            BLPoliza oEmpleado = new BLPoliza();

            int dataUser = int.Parse(Session["idusuario"].ToString());

            pa_RetornaEmpleadoPoliza_Result resultadoEmpleado = oEmpleado.retornaEmpleadoPoliza(dataUser);

            this.txtEmpleado.Text = resultadoEmpleado.nomEmpleado;
            this.hdIdEmpleado.Value = resultadoEmpleado.idEmpleado.ToString();
            this.txtSucursal.Text = resultadoEmpleado.nomSucursal;
            this.hdIdSucursal.Value = resultadoEmpleado.idSucursal.ToString();


        }

        void calculoAdicciones()
        {
            float montoAsegurado = float.Parse(this.txtMontoAsegurado.Text);

            if (Convert.ToInt16(this.txtCantidadAdicciones.Text) == 1)
            {
                float cantidadUno = montoAsegurado * (float)0.05;
                this.txtMontoAdicciones.Text = cantidadUno.ToString();

            }else if(Convert.ToInt16(this.txtCantidadAdicciones.Text) == 2 || Convert.ToInt16(this.txtCantidadAdicciones.Text) == 3)
            {
                float cantidadDos = montoAsegurado * (float)0.1;
                this.txtMontoAdicciones.Text = cantidadDos.ToString();

            }
            else if (Convert.ToInt16(this.txtCantidadAdicciones.Text) > 3)
            {
                float cantidadTres = montoAsegurado * (float)0.15;
                this.txtMontoAdicciones.Text = cantidadTres.ToString();
            }
        }

        void calculoDinero()
        {
            float montoAsegurado = float.Parse(this.txtMontoAsegurado.Text);
            float montoAdicciones = float.Parse(this.txtMontoAdicciones.Text);
            float primaAntesImpuestos = montoAsegurado + montoAdicciones;
            this.txtPrimaAntesImpuestos.Text = primaAntesImpuestos.ToString();
            float impuestos = primaAntesImpuestos * (float)0.13;
            this.txtImpuestos.Text = impuestos.ToString();
            float primaFinal = primaAntesImpuestos + impuestos;
            this.txtPrimaFinal.Text = primaFinal.ToString();
        }

        protected void btnPruebaDatos_Click(object sender, EventArgs e)
        {
            this.cargaDocCoberturaPoliza();
            this.cargaDocAdicciones();
            this.calculoAdicciones();
            this.calculoDinero();
        }

        /// <summary>
        /// Valida que todas las reglas del formulario se hayan cumplido y procede
        /// a insertar el registro utilizando el procedimiento sp_InsertarPoliza
        /// </summary>
        void AlmacenarDatos()
        {
            if (this.IsValid)
            {
                ///Variable que contiene el mensaje a visualizar
                string mensaje = "";

                ///Creación de la instancia de la clase BLCoberturaPoliza
                BLPoliza oPoliza = new BLPoliza();
                bool resultado = false;

                try
                {
                    int idCoberturaPoliza = Convert.ToInt16(this.ddlCoberturaPoliza.SelectedValue);
                    int idCliente = Convert.ToInt16(this.hdIdCliente.Value);
                    int idEmpleado = Convert.ToInt16(this.hdIdEmpleado.Value);
                    float montoAsegurado = float.Parse(this.txtMontoAsegurado.Text);
                    float primaAntesImpuestos = float.Parse(this.txtPrimaAntesImpuestos.Text);
                    float impuestos = float.Parse(this.txtImpuestos.Text);
                    float primaFinal = float.Parse(this.txtPrimaFinal.Text);
                    DateTime fecha = Convert.ToDateTime(txtFechaRegistro.Text);
                    int idSucursal = Convert.ToInt16(this.hdIdSucursal.Value);
                    float porcentajePrima = float.Parse(this.txtPorcentajeCobertura.Text);
                    int cantAdicciones = Convert.ToInt16(this.txtCantidadAdicciones.Text);
                    float montoAdicciones = float.Parse(this.txtMontoAdicciones.Text);

                    ///Asignar a la variable el resultado de invocar el procedimiento
                    ///almacenado que se encuentra en el método
                    resultado = oPoliza.insertaPoliza(idCoberturaPoliza, idCliente, idEmpleado, montoAsegurado, cantAdicciones,
                                                      montoAdicciones, primaAntesImpuestos, impuestos, primaFinal, fecha, idSucursal, porcentajePrima);

                    ///Generación del mensaje de error
                    mensaje += $"El registro fue insertado";
                    ///Mostrar mensaje
                    Response.Write("<script>alert('" + mensaje + "')</script>");
                }
                catch (Exception excepcionCapturada)
                {
                    ///Generación del mensaje de error
                    mensaje += $"Ha ocurrido un error: {excepcionCapturada.Message}";
                    ///Mostrar mensaje
                    Response.Write("<script>alert('" + mensaje + "')</script>");
                }
                finally
                {
                    ///Si el resultado de la variable es verdadero, significa que no dió errores
                    if (resultado)
                    {
                        ///Mostrar mensaje
                        Response.Write("<script>alert('" + mensaje + "')</script>");

                        ///Redireccionamiento a la lista de Tipo Polizas
                        this.Response.Redirect("/formularios/mantenimientosEmpleado/mantenimientoPoliza/frmPolizaLista.aspx");
                    }
                }
            }
        }
    }
}