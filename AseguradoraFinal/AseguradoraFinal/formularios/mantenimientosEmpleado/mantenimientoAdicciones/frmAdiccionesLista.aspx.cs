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

            //validar que sea la primera vez que se carga la pagina
            //o bien que no es una  "recarga" de pagina
            //if(!this.IsPostBack)
            if (this.IsPostBack == false)
            {
                this.cargaListaAdicciones();
                this.CargaDatosGrid();
            }

        }

        void cargaListaAdicciones()
        {
            BLEmpleado oAdiccion = new BLEmpleado();
            ///indicarle al dropdownlist la fuente de datos
            this.ddlNombre.DataSource = oAdiccion.RetornaAdicciones(null);
            ///indicarle al dropdownlist que se muestre
            this.ddlNombre.DataBind();
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
            List<pa_RetornaAdicciones_Result> fuenteDatos =
                blAddiciones.RetornaAdicciones(
                     this.ddlNombre.Text);

          
           
            ///Agregar al grid la fuente de datos
            this.grdAdicciones.DataSource = fuenteDatos;

            //Indicarle al grid que se muestre
            this.grdAdicciones.DataBind();

        }


        protected void grdAdicciones_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            ///Indicarle al grid la nueva pagina utilizando el parametro e
            this.grdAdicciones.PageIndex = e.NewPageIndex;
            ///Cargar de nuevo el grid e indicarle que se muestre
            this.CargaDatosGrid();
        }

        protected void ddlNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///Obtener el texto seleccionado
            string text = this.ddlNombre.SelectedItem.Text;
            ///Obtener el valor seleccionado, es decir el que sera
            ///utilizando para almacenar en la DB, muchas veces la llave foranea
            string valorIndentificado = this.ddlNombre.SelectedValue;
        }


    }   
}