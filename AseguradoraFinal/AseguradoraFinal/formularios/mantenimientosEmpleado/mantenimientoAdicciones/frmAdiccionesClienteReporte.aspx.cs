using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoAdicciones
{
    public partial class frmAdiccionesClienteReporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btBuscar_Click(object sender, EventArgs e)
        {
            this.contruirReporte();
        }

        void contruirReporte()
        {

            ///indicar la ruta del reporte
            string rutaReporte = "";
            ///construir la ruta física
            string rutaServidor = "";
            ///Validar que la ruta física exista
            if (!File.Exists(rutaServidor))
            {
                this.lblResultado.Text =
                    "El reporte seleccionado no existe";
                return;
            }
            else
            {
                rpvAdiccionesClientes.LocalReport.ReportPath = rutaServidor;
                var infoFuenteDatos = this.rpvAdiccionesClientes.LocalReport.GetDataSourceNames();
                ///limpiar los datos de la fuente de datos
                rpvAdiccionesClientes.LocalReport.DataSources.Clear();
                ///obtener los datos del reporte
                List<pa_RetornaAdiccionesxCliente_Result> datosReporte =
                    null;
                ///crear la fuente de datos
                ReportDataSource fuenteDatos = new ReportDataSource();
                fuenteDatos.Name = infoFuenteDatos[0];
                fuenteDatos.Value = datosReporte;
                // agregar la fuente de datos al reporte
                this.rpvAdiccionesClientes.LocalReport.DataSources.Add(fuenteDatos);

                /// mostrar los datos en el reporte
                this.rpvAdiccionesClientes.LocalReport.Refresh();
            }
        }
        /// <summary>
        /// Función que retorna la fuente de datos a mostrar en el reporte
        /// </summary>
        /// <param name="pPrimerApellido"></param>
        /// <param name="pNombre"></param>
        /// <returns></returns>
        List<pa_RetornaAdiccionesxCliente_Result> retornaDatosReporte(
            string pPrimerApellido, string pNombre)
        {
            return
                  null;
        }

    }
}
