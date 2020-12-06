using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoAdicciones
{
    public partial class frmAdiccionesLista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            this.CargaDatosGrid();
        }

        void CargaDatosGrid()
        {
            ///Crear instancia de la clas que retornara los datos
            BLEmpleado blAddiciones = new BLEmpleado();
            //crear la variable que contiene los datos
            List<pa_AdiccionesxClienteSelect_Result> fuenteDatos =
                blAddiciones.Retorna_AdiccionesxClienteSelect(
                    this.txtnumCedula.Text,
                    this.txtNombreCliente.Text,
                    this.txtAdiccion.Text,
                    this.txtGenero.Text);




            ///Agregar al grid la fuente de datos
            this.grdListaAdicciones.DataSource = fuenteDatos;

            //Indicarle al grid que se muestre
            this.grdListaAdicciones.DataBind();

        }


        protected void grdListaAdicciones_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            ///Indicarle al grid la nueva pagina utilizando el parametro e
            this.grdListaAdicciones.PageIndex = e.NewPageIndex;
            ///Cargar de nuevo el grid e indicarle que se muestre
            this.CargaDatosGrid();
        }

 
    }   
}