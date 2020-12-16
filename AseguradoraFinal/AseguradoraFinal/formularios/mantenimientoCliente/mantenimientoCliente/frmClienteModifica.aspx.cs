using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.formularios.mantenimientoCliente.mantenimientoCliente
{
    public partial class frmClienteLista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.cargaDatosRegistro();
            }
        }

        protected void btnModificarDatos_Click(object sender, EventArgs e)
        {
            this.AlmacenarDatos();
        }

        void cargaDatosRegistro()
        {

            ///Variable que almacena el IDUsuario a la hora de iniciar sesión
            int dataUser = int.Parse(Session["idusuario"].ToString());
            string mensaje = "";

            //validar si el parametro es correcto
            if (String.IsNullOrEmpty(Convert.ToString(dataUser)))
            {
                ///Generar el mensaje
                mensaje = "El parámetro es nulo";
                ///mostrar el mensaje
                Response.Write("<script>alert('" + mensaje + "')</script>");
            }
            else
            {
                BLCliente oCliente = new BLCliente();

                pa_RetornaUsuarioClienteID_Result resultadoClienteID = new pa_RetornaUsuarioClienteID_Result();

                resultadoClienteID = oCliente.retornaUsuarioClienteID(dataUser);

                this.txtDireccion.Text = resultadoClienteID.direccionFisica;
                this.txtPriTel.Text = resultadoClienteID.pTelefono;
                this.txtSecTel.Text = resultadoClienteID.sTelefono;
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
                BLCliente oCliente = new BLCliente();
                bool resultado = false;
                string mensaje = "";
                try
                {
                    ///obtener los valores seleccionados por el usuario
                    ///se toman de la propiedad datavaluefield del dropdownlist
                    string direccion = this.txtDireccion.Text;
                    string primerTel = this.txtPriTel.Text;
                    string segTel = this.txtSecTel.Text;

                    ///Variable que almacena el IDUsuario a la hora de iniciar sesión
                    int dataUser = int.Parse(Session["idusuario"].ToString());

                    pa_RetornaUsuarioClienteID_Result resultadoClienteID = new pa_RetornaUsuarioClienteID_Result();

                    resultadoClienteID = oCliente.retornaUsuarioClienteID(dataUser);

                    int idCliente = resultadoClienteID.idCliente;

                    ///asignar a la variable el resultado de 
                    ///invocar el procedimiento almacenado
                    resultado = oCliente.modificaClienteUsuario(idCliente, direccion, primerTel, segTel);

                }
                ///catch: se ejecuta en el caso de que haya una excepcion
                ///excepcionCapturada: posee los datos de la excepción
                catch (Exception excepcionCapturada)
                {
                    mensaje += $"Ocurrió un error: {excepcionCapturada.Message}";
                    ///mostrar el mensaje
                    Response.Write("<script>alert('" + mensaje + "')</script>");
                }
                ///finally: siempre se ejecuta (se atrape o no la excepción)
                finally
                {
                    ///si el resultado de la variable es verdadera implica que
                    ///el procedimiento no retornó errores
                    if (resultado)
                    {
                        mensaje += "El registro fue modificado";
                        ///mostrar el mensaje
                        Response.Write("<script>alert('" + mensaje + "')</script>");
                    }
                }
            }
        }
    }
}