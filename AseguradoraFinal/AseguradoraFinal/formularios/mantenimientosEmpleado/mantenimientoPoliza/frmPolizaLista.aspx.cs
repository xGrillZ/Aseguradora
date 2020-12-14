using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoPoliza
{
    public partial class frmPolizaLista : System.Web.UI.Page
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
            ///Creación de la instancia de la clase BLPoliza
            BLPoliza oPoliza = new BLPoliza();
            ///Creación de la variable, la cuál obtendrá los datos
            List<pa_RetornaPoliza_Result> fuenteDatos = oPoliza.retornaPoliza(this.txtPriApeCliente.Text, this.txtNumCedula.Text,
                                                                              this.txtNombreCobertura.Text, Convert.ToInt16(this.txtNumAdicciones.Text));

            ///Agregar al GridView una fuente de datos
            this.grdListaPoliza.DataSource = fuenteDatos;

            ///Mostrar el GridView
            this.grdListaPoliza.DataBind();
        }

        protected void grdListaPoliza_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            ///Indicar al grid la nueva página por medio del parámetro e
            this.grdListaPoliza.PageIndex = e.NewPageIndex;

            ///Cargar el grid con los datos de las nuevas páginas
            this.cargaDatosGrid();
        }
    }
}