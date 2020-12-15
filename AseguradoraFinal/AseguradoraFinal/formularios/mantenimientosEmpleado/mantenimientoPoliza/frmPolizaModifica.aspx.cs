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
    public partial class frmPolizaModifica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.cargaListaCoberturaPoliza();
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

        protected void btnCalcularDatos_Click(object sender, EventArgs e)
        {

        }

        void cargaDatosRegistro()
        {

            ///obtener el parámetro envíado desde el grid
            ///es CASESENSITIVE
            string parametro =
                this.Request.QueryString["idRegistroPoliza"];

            //validar si el parametro es correcto
            if (String.IsNullOrEmpty(parametro))
            {
                string mensaje = "El parámetro es nulo";
                ///Mostrar mensaje
                Response.Write("<script>alert('" + mensaje + "')</script>");
            }
            else
            {
                int id_Poliza = Convert.ToInt16(parametro);
                BLPoliza oPoliza = new BLPoliza();

                pa_RetornaPolizaID_Result datosPoliza = new pa_RetornaPolizaID_Result();

                ///Invocar el procedimiento almacenado por medio del método
                datosPoliza = oPoliza.retornaPolizaID(id_Poliza);

                ///Verificar que el objeto retornado no sea nulo
                if (datosPoliza == null)
                {
                    Response.Redirect("/formularios/mantenimientosEmpleado/mantenimientoPoliza/frmPolizaLista.aspx");
                }
                else
                {
                    ///Asginación de cada una de las etiquetas sus valores respectivos en la invocacion del procedimiento almacenado
                    this.txtCedCliente.Text = datosPoliza.numCedula;
                    this.ddlCoberturaPoliza.SelectedValue = datosPoliza.idCoberturaPoliza.ToString();
                    this.txtMontoAsegurado.Text = datosPoliza.montoAsegurado.ToString();
                    this.txtCantidadAdicciones.Text = datosPoliza.cantAdicciones.ToString();
                    this.txtMontoAdicciones.Text = datosPoliza.montoAdicciones.ToString();
                    this.txtPrimaAntesImpuestos.Text = datosPoliza.primaAntesImpuestos.ToString();
                    this.txtImpuestos.Text = datosPoliza.impuestos.ToString();
                    this.txtPrimaFinal.Text = datosPoliza.primaFinal.ToString();
                    this.txtFechaRegistro.Text = datosPoliza.fechaRegistro.ToString();
                    this.txtEmpleado.Text = datosPoliza.nomEmpleado;
                    this.txtSucursal.Text = datosPoliza.nomSucursal;
                    this.txtPorcentajeCobertura.Text = datosPoliza.porcentajePrima.ToString();

                    ///Asignar al hidden field el valor de llave primaria
                    this.hdIdRegistroPoliza.Value = datosPoliza.idRegistroPoliza.ToString();
                }
            }

        }
    }
}