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
                this.cargaDocCoberturaPoliza();
                this.cargaDocEmpleado();
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
        /// Carga la información de cobertura póliza
        /// </summary>
        void cargaDocCoberturaPoliza()
        {
            ///Creación de la instancia a la clase BLCoberturaPoliza
            BLCoberturaPoliza oCoberturaPoliza = new BLCoberturaPoliza();

            pa_RetornaCoberturaPolizaID_Result resultado = oCoberturaPoliza.retornaCoberturaPolizaID(Convert.ToInt16(this.ddlCoberturaPoliza.SelectedValue));

            this.txtPorcentajeCobertura.Text = resultado.porcentaje.ToString();

        }

        /// <summary>
        /// Carga la información de adicciones
        /// </summary>
        void cargaDocAdicciones()
        {
            ///Creación de la instancia a la clase BLPoliza
            BLPoliza oPoliza = new BLPoliza();
            ///Creación de la instancia a la clase BLCliente
            BLCliente oCliente = new BLCliente();

            ///Creación de la variable que almacena el resultado del procedimiento almacenado
            pa_RetornaCliente_Result resultadoCliente = oCliente.retornaClientePoliza(this.txtCedCliente.Text);
            ///Creación de la variable que almacena el resultado del procedimiento almacenado
            pa_RetornaAdiccionesCantidad_Result resultadoCantidad = oPoliza.retornaAdiccionesCantidad(resultadoCliente.idCliente);
            ///Inserción del dato obtenido por el procedimiento almacenado
            this.txtCantidadAdicciones.Text = resultadoCantidad.cantAdiccion.ToString();

            if (resultadoCliente == null)
            {
                this.txtCantidadAdicciones.Text = "0";
            }
        }

        /// <summary>
        /// Carga la información de cliente
        /// </summary>
        void cargaDocEmpleado()
        {
            ///Creación de la instancia a la clase BLEmpleado
            BLPoliza oEmpleado = new BLPoliza();

            int dataUser = int.Parse(Session["idusuario"].ToString());

            pa_RetornaEmpleadoPoliza_Result resultadoEmpleado = oEmpleado.retornaEmpleadoPoliza(dataUser);

            this.txtEmpleado.Text = resultadoEmpleado.nomEmpleado;
            this.txtSucursal.Text = resultadoEmpleado.nomSucursal;
            this.hdIdSucursal.Value = resultadoEmpleado.idSucursal.ToString();


        }

        protected void btnPruebaDatos_Click(object sender, EventArgs e)
        {
            this.cargaDocCoberturaPoliza();
            this.cargaDocAdicciones();
        }
    }
}