using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Microsoft.Reporting.WebForms;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoPoliza
{
    public partial class frmPolizaClienteReporte : System.Web.UI.Page
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
            string rutaReporte = "~/Reportes/RptPolizaCliente.rdlc";
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
                rpvPolizaClientes.LocalReport.ReportPath = rutaServidor;
                var infoFuenteDatos = this.rpvPolizaClientes.LocalReport.GetDataSourceNames();
                ///limpiar los datos de la fuente de datos
                rpvPolizaClientes.LocalReport.DataSources.Clear();
                ///obtener los datos del reporte
                List< pa_RetornaPoliza_Result > datosReporte = this.retornaDatosReporte(this.txtprimerApellidoCliente.Text, this.txtnumCedulaCliente.Text, this.txtnombreCoberturaPoliza.Text); 
                ///crear la fuente de datos
                ReportDataSource fuenteDatos = new ReportDataSource();
                fuenteDatos.Name = infoFuenteDatos[0];
                fuenteDatos.Value = datosReporte;
                // agregar la fuente de datos al reporte
                this.rpvPolizaClientes.LocalReport.DataSources.Add(fuenteDatos);

                /// mostrar los datos en el reporte
                this.rpvPolizaClientes.LocalReport.Refresh();
            }
        }
        /// <summary>
        /// Función que retorna la fuente de datos a mostrar en el reporte
        /// </summary>
        /// <param name="pPrimerApellido"></param>
        /// <param name="pNombre"></param>
        /// <returns></returns>
        List<pa_RetornaPoliza_Result> retornaDatosReporte(string primerApellidoCliente, string numCedulaCliente, string nombreCoberturaPoliza)
        {
            return
                  this.modeloBD.pa_RetornaPoliza( primerApellidoCliente,  numCedulaCliente, nombreCoberturaPoliza).ToList();
        }
    }

}

