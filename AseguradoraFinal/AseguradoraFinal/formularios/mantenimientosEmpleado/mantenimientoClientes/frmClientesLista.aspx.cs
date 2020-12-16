using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoClientes
{
    public partial class frmClientesLista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrarDatos_Click(object sender, EventArgs e)
        {

        }

        void CargaDatosGrid()
        {
 /*           ///Creación de la instancia de la clase BLCliente
            BLCliente oCliente = new BLCliente();
            ///Creación de la variable, la cuál obtendrá los datos
            List<sp_Retorna_Gasto_Categoria_Result> fuenteDatos =
                blGastoCategoria.RetornaGastoCategoria(this.txtDescGasto.Text, this.txtDescCategoria.Text);

            ///Agregar al GridView una fuente de datos
            this.grdListaGastosCategoria.DataSource = fuenteDatos;

            ///Mostrar el GridView
            this.grdListaGastosCategoria.DataBind();*/
        }
    }
}