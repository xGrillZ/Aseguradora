using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.Modelos;
using Microsoft.Reporting.WebForms;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoAdicciones
{
    public partial class frmReporteAdicciones : System.Web.UI.Page
    {
        aseguradorarjsEntities modeloBD = new aseguradorarjsEntities();
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
            string rutaReporte = "/Reportes/RptAdiccionesxCliente.rdlc";
            ///construir la ruta física
            string rutaServidor = Server.MapPath(rutaReporte);
            ///Validar que la ruta física exista
            if (!File.Exists(rutaServidor))
            {
                this.lblResultado.Text =
                    "El reporte seleccionado no existe";
                return;
            }
            else
            {
                rpvClientes.LocalReport.ReportPath = rutaServidor;
                var infoFuenteDatos = this.rpvClientes.LocalReport.GetDataSourceNames();
                ///limpiar los datos de la fuente de datos
                rpvClientes.LocalReport.DataSources.Clear();
                ///obtener los datos del reporte
                List<pa_RetornaAdiccionCliente_Result> datosReporte =
                    this.retornaDatosReporte(this.txtCorreo.Text, this.txtPriApellido.Text, this.txtNombre.Text, this.txtAdiccion.Text, this.txtDescCate.Text);
                ///crear la fuente de datos
                ReportDataSource fuenteDatos = new ReportDataSource();
                fuenteDatos.Name = infoFuenteDatos[0];
                fuenteDatos.Value = datosReporte;
                // agregar la fuente de datos al reporte
                this.rpvClientes.LocalReport.DataSources.Add(fuenteDatos);

                /// mostrar los datos en el reporte
                this.rpvClientes.LocalReport.Refresh();
            }
        }
        /// <summary>
        /// Función que retorna la fuente de datos a mostrar en el reporte
        /// </summary>
        /// <param name="pPrimerApellido"></param>
        /// <param name="pNombre"></param>
        /// <returns></returns>
        List<pa_RetornaAdiccionCliente_Result> retornaDatosReporte(
            string pCorreo, string pPriApe, string pNombre, string pNombreAdiccion, string pDescCategoria)
        {
            return
                  this.modeloBD.pa_RetornaAdiccionCliente(pCorreo, pPriApe, pNombre, pNombreAdiccion, pDescCategoria).ToList();
        }
    }
}