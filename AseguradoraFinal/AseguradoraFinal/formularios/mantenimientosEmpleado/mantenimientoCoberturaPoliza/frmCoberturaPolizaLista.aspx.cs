using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoCoberturaPoliza
{
    public partial class frmCoberturaPolizaLista : System.Web.UI.Page
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
            BLCoberturaPoliza oCoberturaPoliza = new BLCoberturaPoliza();

            ///Creacion de la variable que contendrá los datos
            List<pa_RetornaCoberturaPoliza_Result> fuenteDatos = oCoberturaPoliza.retornaCoberturaPoliza(this.txtCobertura.Text,
                                                                                                         this.txtTipoPoliza.Text);

            ///Agregar al grid al fuente de datos
            this.grdListaCoberturaPoliza.DataSource = fuenteDatos;

            ///Mostrar el grid
            this.grdListaCoberturaPoliza.DataBind();
        }

        protected void grdListaCoberturaPoliza_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            ///Indicación al grid la nueva página, utilizando el parámetro e
            this.grdListaCoberturaPoliza.PageIndex = e.NewPageIndex;

            ///Cargar nuevamente el grid e indicar su visualización
            this.cargaDatosGrid();
        }
    }
}