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
    public partial class frmPolizaInserta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.cargaListaCoberturaPoliza();
                this.cargaListaAdicciones();
                this.cargaDocCoberturaPoliza();
            }
        }

        protected void btnIngresarDatos_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Carga la lista de cobertura poliza
        /// </summary>
        void cargaListaCoberturaPoliza()
        {
            ///Creación de la instancia a la clase BLCoberturaPoliza
            BLCoberturaPoliza oCoberturaPoliza = new BLCoberturaPoliza();

            ///indicarle al dropdownlist la fuente de datos
            this.ddlCoberturaPoliza.DataSource = oCoberturaPoliza.retornaCoberturaPoliza();

            ///indicarle al dropdownlist que se muestre
            this.ddlCoberturaPoliza.DataBind();
        }

        /// <summary>
        /// Carga la lista de adicciones
        /// </summary>
        void cargaListaAdicciones()
        {
            ///Creación de la instancia a la clase BLEmpleado
            BLEmpleado oAdicciones = new BLEmpleado();

            ///indicarle al dropdownlist la fuente de datos
            this.ddlAdiccion.DataSource = oAdicciones.RetornaAdicciones();

            ///indicarle al dropdownlist que se muestre
            this.ddlAdiccion.DataBind();
        }

        /// <summary>
        /// Carga la información de cobertura póliza
        /// </summary>
        void cargaDocCoberturaPoliza()
        {
            ///Creación de la instancia a la clase BLCoberturaPoliza
            BLCoberturaPoliza oCoberturaPoliza = new BLCoberturaPoliza();

            pa_RetornaCoberturaPolizaID_Result resultado = oCoberturaPoliza.retornaCoberturaPolizaID(Convert.ToInt32(this.ddlCoberturaPoliza.SelectedValue));

            this.txtPorcentajeCobertura.Text = resultado.porcentaje.ToString();

        }

        /// <summary>
        /// Carga la información de adicciones
        /// </summary>
        void cargaDocAdicciones()
        {
            ///Creación de la instancia a la clase BLAdicciones
            BLEmpleado oAdicciones = new BLEmpleado();

            BLCliente oCliente = new BLCliente();




        }

        /// <summary>
        /// Carga la información de cliente
        /// </summary>
        void cargaDocCliente()
        {
            ///Creación de la instancia a la clase BLAdicciones
            BLEmpleado oAdicciones = new BLEmpleado();


        }
    }
}