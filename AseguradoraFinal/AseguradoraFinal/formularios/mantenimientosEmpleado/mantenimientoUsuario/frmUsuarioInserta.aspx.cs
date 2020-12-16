using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoUsuario
{
    public partial class frmUsuarioInserta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.cargaListaTipoUsuario();
            }
        }

        protected void btInsertar_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Carga la lista de tipo usuarios
        /// </summary>
        void cargaListaTipoUsuario()
        {
            ///Creación de la instancia de BLUsuario
            blUsuario oUsuario = new blUsuario();
            ///indicarle al dropdownlist la fuente de datos
            this.ddlTipoUsuario.DataSource = oUsuario.retornaTipoUsuario(null);

            ///indicarle al dropdownlist que se muestre
            this.ddlTipoUsuario.DataBind();
        }
    }
}