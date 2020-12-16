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
    public partial class frmPolizaElimina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.cargaListaCoberturaPoliza();
                this.cargaDatosRegistro();
                this.cargaDocCoberturaPoliza();
                this.cargaDocAdicciones();
            }
        }

        protected void btnEliminarDatos_Click(object sender, EventArgs e)
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

        void cargaDatosRegistro()
        {

            ///obtener el parámetro envíado desde el grid
            ///es CASESENSITIVE
            string parametro =
                this.Request.QueryString["idRegistroPoliza"];

            //validar si el parametro es correcto
            if (String.IsNullOrEmpty(parametro))
            {
                string mensaje = "El parámetro es nulo";
                ///Mostrar mensaje
                Response.Write("<script>alert('" + mensaje + "')</script>");
            }
            else
            {
                int id_Poliza = Convert.ToInt16(parametro);
                BLPoliza oPoliza = new BLPoliza();

                pa_RetornaPolizaID_Result datosPoliza = new pa_RetornaPolizaID_Result();

                ///Invocar el procedimiento almacenado por medio del método
                datosPoliza = oPoliza.retornaPolizaID(id_Poliza);

                ///Verificar que el objeto retornado no sea nulo
                if (datosPoliza == null)
                {
                    Response.Redirect("/formularios/mantenimientosEmpleado/mantenimientoPoliza/frmPolizaLista.aspx");
                }
                else
                {
                    ///Asginación de cada una de las etiquetas sus valores respectivos en la invocacion del procedimiento almacenado
                    this.txtCedCliente.Text = datosPoliza.numCedula;
                    this.ddlCoberturaPoliza.SelectedValue = datosPoliza.idCoberturaPoliza.ToString();
                    this.txtMontoAsegurado.Text = datosPoliza.montoAsegurado.ToString();
                    this.txtCantidadAdicciones.Text = datosPoliza.cantAdicciones.ToString();
                    this.txtMontoAdicciones.Text = datosPoliza.montoAdicciones.ToString();
                    this.txtPrimaAntesImpuestos.Text = datosPoliza.primaAntesImpuestos.ToString();
                    this.txtImpuestos.Text = datosPoliza.impuestos.ToString();
                    this.txtPrimaFinal.Text = datosPoliza.primaFinal.ToString();
                    this.txtFechaRegistro.Text = datosPoliza.fechaRegistro.ToString("yyyy-MM-dd");
                    this.txtEmpleado.Text = datosPoliza.nomEmpleado;
                    this.txtSucursal.Text = datosPoliza.nomSucursal;
                    this.txtPorcentajeCobertura.Text = datosPoliza.porcentajePrima.ToString();

                    this.hdIdEmpleado.Value = datosPoliza.idEmpleado.ToString();
                    this.hdIdSucursal.Value = datosPoliza.idSucursal.ToString();
                    ///Asignar al hidden field el valor de llave primaria
                    this.hdIdRegistroPoliza.Value = datosPoliza.idRegistroPoliza.ToString();
                }
            }

        }

        /// <summary>
        /// Valida que todas las reglas del formulario se hayan cumplido y procede
        /// a insertar el registro utilizando el procedimiento sp_InsertaCliente
        /// </summary>
        void AlmacenarDatos()
        {
            if (this.IsValid)
            {
                BLPoliza oPoliza = new BLPoliza();
                bool resultado = false;
                string mensaje = "";

                pa_RetornaPolizaID_Result resultadoPolizaID = new pa_RetornaPolizaID_Result();

                int pPolizaID = Convert.ToInt16(hdIdRegistroPoliza.Value);

                resultadoPolizaID = oPoliza.retornaPolizaID(pPolizaID);

                try
                {
                    if (DateTime.Now < resultadoPolizaID.fechaRegistro)
                    {
                        ///obtener el valor del hidden field 
                        int id_RegistroPoliza = Convert.ToInt16(this.hdIdRegistroPoliza.Value);
                        ///asignar a la variable el resultado de 
                        ///invocar el procedimiento almacenado
                        resultado = oPoliza.eliminaPoliza(id_RegistroPoliza);
                    }
                    else
                    {
                        ///Generación del mensaje de error
                        mensaje = "La fecha de la póliza se encuentra vencida, no puede ser eliminada.";
                        ///Mostrar mensaje
                        Response.Write("<script>alert('" + mensaje + "')</script>");
                    }
                }
                ///catch: se ejecuta en el caso de que haya una excepcion
                ///excepcionCapturada: posee los datos de la excepción
                catch (Exception excepcionCapturada)
                {
                    mensaje += $"Ocurrió un error: {excepcionCapturada.Message}";
                    ///Mostrar mensaje
                    Response.Write("<script>alert('" + mensaje + "')</script>");
                }
                ///finally: siempre se ejecuta (se atrape o no la excepción)
                finally
                {
                    ///si el resultado de la variable es verdadera implica que
                    ///el procedimiento no retornó errores
                    if (resultado)
                    {
                        mensaje += "El registro fue eliminado";
                        ///Mostrar mensaje
                        Response.Write("<script>alert('" + mensaje + "')</script>");
                    }
                }
            }
        }
    }
}