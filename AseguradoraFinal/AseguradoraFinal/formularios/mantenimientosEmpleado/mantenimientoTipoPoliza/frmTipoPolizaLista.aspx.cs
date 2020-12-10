using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoTipoPoliza
{
    public partial class frmTipoPolizaLista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            this.cargaDatosGrid();
        }

        void cargaDatosGrid()
        {
            ///Creacion de la instancia del objeto BLCoberturaPoliza
            BLTipoPoliza oTipoPoliza = new BLTipoPoliza();

            ///Creacion de la variable que contendrá los datos
            List<pa_RetornaTipoPoliza_Result> fuenteDatos = oTipoPoliza.retornaTipoPoliza(this.txtPoliza.Text);

            ///Agregar al grid al fuente de datos
            this.grdTipoPoliza.DataSource = fuenteDatos;

            ///Mostrar el grid
            this.grdTipoPoliza.DataBind();
        }

        protected void grdTipoPoliza_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            ///Indicación al grid la nueva página, utilizando el parámetro e
            this.grdTipoPoliza.PageIndex = e.NewPageIndex;

            ///Cargar nuevamente el grid e indicar su visualización
            this.cargaDatosGrid();
        }
    }
}