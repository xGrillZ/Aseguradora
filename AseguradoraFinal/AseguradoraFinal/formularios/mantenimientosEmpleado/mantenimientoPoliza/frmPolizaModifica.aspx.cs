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
    public partial class frmPolizaModifica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.cargaListaCoberturaPoliza();
                this.cargaDatosRegistro();
                this.cargaDocCoberturaPoliza();
            }
        }

        /// <summary>
        /// Valida que todas las reglas del formulario se hayan cumplido y procede
        /// a insertar el registro utilizando el procedimiento sp_ModificaPoliza
        /// </summary>
        void AlmacenarDatos()
        {
            if (this.IsValid)
            {
                ///Creación instancia de la clase BLPoliza
                BLPoliza oPoliza = new BLPoliza();
                BLCliente oCliente = new BLCliente();

                ///Creación de la variable el cuál verifica el resultado de la accion a realizar
                bool resultado = false;

                ///Creación de la variable el cuál almacenará el mensaje a mostrar
                string mensaje = "";

                ///Creación de una lista el cuál contiene el resultado de datos
                List<pa_RetornaCliente_Result> listaRetornaCliente = oCliente.retornaClientePoliza(null);
                pa_RetornaPolizaID_Result resultadoPolizaID = new pa_RetornaPolizaID_Result();

                int pPolizaID = Convert.ToInt16(hdIdRegistroPoliza.Value);

                resultadoPolizaID = oPoliza.retornaPolizaID(pPolizaID);

                ///Contador para el resultado
                int contadorCobertura = 0;
                try
                {
                    ///Recorrido de la lista que contiene todos los datos de la CoberturaPoliza
                    for (int i = 0; i < listaRetornaCliente.Count; i++)
                    {
                        ///Verificar si el nombre de la cobertura existe o no
                        if (!listaRetornaCliente[i].numCedula.Equals(this.txtCedCliente.Text))
                        {
                            contadorCobertura = 1;
                            ///Generación del mensaje de error
                            mensaje = "El número de cédula no existe, ingrésalo de nuevo";
                            ///Mostrar mensaje
                            Response.Write("<script>alert('" + mensaje + "')</script>");
                        }
                        else
                        {
                            if (DateTime.Now < resultadoPolizaID.fechaRegistro)
                            {
                                ///obtener los valores seleccionados por el usuario
                                ///se toman de la propiedad datavaluefield
                                ///tanto del dropdownlist como del listbox
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
                                //obtener el valor del hidden field 
                                int id_RegistroPoliza = Convert.ToInt16(this.hdIdRegistroPoliza.Value);
                                ///asignar a la variable el resultado de 
                                ///invocar el procedimiento almacenado
                                resultado = oPoliza.modificaPoliza(id_RegistroPoliza, idCoberturaPoliza, idCliente, idEmpleado,
                                                                   montoAsegurado, cantAdicciones, montoAdicciones, primaAntesImpuestos,
                                                                   impuestos, primaFinal, fecha, idSucursal, porcentajePrima);
                            }
                            else
                            {
                                ///Generación del mensaje de error
                                mensaje = "La fecha de la póliza se encuentra vencida, no puede ser modificada.";
                                ///Mostrar mensaje
                                Response.Write("<script>alert('" + mensaje + "')</script>");
                            }
                        }
                    }

                }
                ///catch: se ejecuta en el caso de que haya una excepcion
                ///excepcionCapturada: posee los datos de la excepción
                catch (Exception excepcionCapturada)
                {
                    ///Generación del mensaje
                    mensaje += $"Ocurrió un error: {excepcionCapturada.Message}";
                    ////mostrar el mensaje
                    Response.Write("<script>alert('" + mensaje + "')</script>");
                }
                ///finally: siempre se ejecuta (se atrape o no la excepción)
                finally
                {
                    ///si el resultado de la variable es verdadera implica que
                    ///el procedimiento no retornó errores
                    if (resultado)
                    {
                        ///Generación del mensaje
                        mensaje += "El registro fue modificado";
                        ////mostrar el mensaje
                        Response.Write("<script>alert('" + mensaje + "')</script>");
                    }
                }
            }
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

        void calculoAdicciones()
        {
            float montoAsegurado = float.Parse(this.txtMontoAsegurado.Text);

            if (Convert.ToInt16(this.txtCantidadAdicciones.Text) == 1)
            {
                float cantidadUno = montoAsegurado * (float)0.05;
                this.txtMontoAdicciones.Text = cantidadUno.ToString();

            }
            else if (Convert.ToInt16(this.txtCantidadAdicciones.Text) == 2 || Convert.ToInt16(this.txtCantidadAdicciones.Text) == 3)
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

        protected void btnCalcularDatos_Click(object sender, EventArgs e)
        {
            this.cargaDocCoberturaPoliza();
            this.cargaDocAdicciones();
            this.calculoAdicciones();
            this.calculoDinero();
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
                    this.txtFechaRegistro.Text = datosPoliza.fechaRegistro.ToString();
                    this.txtEmpleado.Text = datosPoliza.nomEmpleado;
                    this.txtSucursal.Text = datosPoliza.nomSucursal;
                    this.txtPorcentajeCobertura.Text = datosPoliza.porcentajePrima.ToString();

                    ///Asignar al hidden field el valor de llave primaria
                    this.hdIdRegistroPoliza.Value = datosPoliza.idRegistroPoliza.ToString();
                }
            }

        }

        protected void btnModificarDatos_Click(object sender, EventArgs e)
        {
            this.AlmacenarDatos();
        }
    }
}