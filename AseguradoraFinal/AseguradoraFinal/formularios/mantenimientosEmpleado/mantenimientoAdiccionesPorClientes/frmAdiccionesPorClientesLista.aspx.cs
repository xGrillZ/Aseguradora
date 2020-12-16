using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoAdiccionesPorClientes
{
    public partial class frmAdiccionesPorClientesLista : System.Web.UI.Page
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
            ///Creación de la instancia de la clase BLGastoCategoria
            BLAdiccionCliente oAdiccionCliente = new BLAdiccionCliente();

            ///Creación de la variable, la cuál obtendrá los datos
            List<pa_RetornaAdiccionCliente_Result> fuenteDatos =
                oAdiccionCliente.retornaAdiccionCliente(this.txtCorreoElectrónico.Text, this.txtPriApellido.Text, this.txtNombreCliente.Text,
                                                        this.txtAdiccion.Text, this.txtCategoria.Text);

            ///Agregar al GridView una fuente de datos
            this.grdAdiccionCliente.DataSource = fuenteDatos;

            ///Mostrar el GridView
            this.grdAdiccionCliente.DataBind();
        }
    }
}