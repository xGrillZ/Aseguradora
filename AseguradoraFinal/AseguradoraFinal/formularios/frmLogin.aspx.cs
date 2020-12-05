using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.formularios.Logeo
{
    public partial class frmLogin : System.Web.UI.Page
    {
        /// <summary>
        /// Creación del modeloBD con la entidad de la base de datos
        /// </summary>
        aseguradorarjsEntities modeloBD = new aseguradorarjsEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btAceptar_Click(object sender, EventArgs e)
        {
            ///Validación correcta del formulario
            if (this.Page.IsValid)
            {
                ///Llamado del método
                this.RealizarAutenticacion();
            }
        }

        void RealizarAutenticacion()
        {
            ///Objeto con el procedimiento almacenado retornando valores.
            pa_RetornaUsuarioCorreoPwd_Result resultadoSp = this.modeloBD.pa_RetornaUsuarioCorreoPwd(this.txtContrasena.Text, this.txtCorreo.Text).FirstOrDefault();

            ///Verificación si el objeto es nulo
            if (resultadoSp == null)
            {
                ///Mensaje de error
                this.lblResultado.Text = "Datos inválidos";

                ///Variables de Sesión en nulo
                this.Session.Add("idusuario", null);
                this.Session.Add("tipousuario", null);
                this.Session.Add("usuariologueado", null);
            }
            else
            {
                ///Variables de sesión
                this.Session.Add("idusuario", resultadoSp.idUsuario);
                this.Session.Add("tipousuario", resultadoSp.idTipoUsuario);
                this.Session.Add("usuariologueado", true);

                ///Redireccionamiento a la página principal
                this.Response.Redirect("~/formularios/frmPrincipal.aspx");
            }

        }
    }
}