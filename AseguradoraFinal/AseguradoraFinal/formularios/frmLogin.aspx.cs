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
        aseguradorarjsEntities modeloBD = new aseguradorarjsEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btAceptar_Click(object sender, EventArgs e)
        {
            ///Validación correcta del formulario
            if (this.Page.IsValid)
            {
                this.RealizarAutenticacion();
            }
        }

        void RealizarAutenticacion()
        {

        }
    }
}