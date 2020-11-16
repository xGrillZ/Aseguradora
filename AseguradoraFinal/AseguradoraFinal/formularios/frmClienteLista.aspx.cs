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
    public partial class frmClienteLista : System.Web.UI.Page
    {
        ClientesBDEntities modeloBD = new ClientesBDEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(this.Session["usuariologueado"]) != true)

            {
                this.Response.Redirect("~/formularios/frmLoggin.aspx");
            }
            if (!this.IsPostBack)
            {
                this.CargaDatosGrid();
            }
        }

        protected void btnMostrarDatos_Click(object sender, EventArgs e)
        {

            this.CargaDatosGrid();


        }

        void CargaDatosGrid()
        {
            ///crear la instancia ed la clase que retornara los datos
            BLCliente blCliente = new BLCliente();
            ///crea la variable que contiene los datos
            List<sp_RetornaCliente_Result> fuenteDatos = blCliente.RetornaClientes(
           this.txtPrimerApellido.Text, this.txtNombre.Text);

            //Agregar al grid la fuente de datos
            this.grdListaClientes.DataSource = fuenteDatos;

            //indicarle al grid que se muestre
            this.grdListaClientes.DataBind();
        }

        protected void grdListaClientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void grdListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}