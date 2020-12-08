using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AseguradoraFinal.PaginaMaestra
{
    public partial class AseguradoraPagMaestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///Filtro para verificar el usuario logeado
            if (Convert.ToBoolean(this.Session["usuariologueado"]) != true)
            {
                this.Response.Redirect("~/formularios/frmLogin.aspx");
            }
            else
            {
                this.VerificaPermisosTipoUsuario();
            }
            
        }

        /// <summary>
        /// Verificador de permisos por tipo de usuario
        /// </summary>
        void VerificaPermisosTipoUsuario()
        {
            if (Convert.ToInt16(this.Session["tipousuario"]) == 2)
            {
                this.navbarEmpleado.Visible = true;
                this.navbarCliente.Visible = false;
            }
            else if (Convert.ToInt16(this.Session["tipousuario"]) == 1)
            {
                this.navbarEmpleado.Visible = false;
                this.navbarCliente.Visible = true;
            }
            else
            {
                this.navbarCliente.Visible = false;
                this.navbarEmpleado.Visible = false;
            }
        }
    }
}