using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.formularios
{
    public partial class frmSalir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSi_Click(object sender, EventArgs e)
        {
            this.actualizaUltimaSesion();

            ///Variables de sesión
            this.Session.Add("idusuario", null);
            this.Session.Add("tipousuario", null);
            this.Session.Add("usuariologueado", null);

            ///Redireccionamiento a la página principal
            this.Response.Redirect("~/formularios/frmLogin.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            ///Redireccionamiento a la página principal
            this.Response.Redirect("~/formularios/frmPrincipal.aspx");
        }

        void actualizaUltimaSesion()
        {
            ///Variable que almacena el IDUsuario a la hora de iniciar sesión
            int dataUser = int.Parse(Session["idusuario"].ToString());

            string fechaActual = DateTime.Now.ToString();

            if (this.IsValid)
            {
                BLEmpleado oEmpleado = new BLEmpleado();
                BLCliente oCliente = new BLCliente();
                bool resultado = false;
                string mensaje = "";

                try
                {
                    ///Verificador de tipos de usuarios, el cual enviará el dato según el rol
                    if (Convert.ToInt16(this.Session["tipousuario"]) == 2)
                    {
                        resultado = oEmpleado.ModificaSesionEmpleado(dataUser, DateTime.Parse(fechaActual));
                    }
                    else
                    {
                        resultado = oCliente.ModificaSesionCliente(dataUser, DateTime.Parse(fechaActual));
                    }
                }
                catch (Exception capturaExcepcion)
                {
                    mensaje += $"Ocurrió un error: {capturaExcepcion}";
                    ///Mensaje de excepcion
                    Response.Write("<script>alert('" + mensaje + "')</script>");
                }
                finally
                {

                }
            }
        }
    }
}