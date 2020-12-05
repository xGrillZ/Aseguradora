using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AseguradoraFinal.formularios
{
    public partial class frmSalir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSi_Click(object sender, EventArgs e)
        {
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
    }
}