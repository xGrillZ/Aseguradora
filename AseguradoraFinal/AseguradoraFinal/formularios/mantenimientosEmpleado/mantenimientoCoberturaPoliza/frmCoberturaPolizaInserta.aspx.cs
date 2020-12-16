using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoCoberturaPoliza
{
    public partial class frmCoberturaPolizaInserta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            this.cargaListaTipoPoliza();

        }
        /// <summary>
        /// Carga la lista de tipo poliza
        /// </summary>
        void cargaListaTipoPoliza()
        {
            ///Creación de la instancia a la clase BLTipoPoliza
            BLTipoPoliza oTipoPoliza = new BLTipoPoliza();

            ///indicarle al dropdownlist la fuente de datos
            this.ddlTipoPoliza.DataSource = oTipoPoliza.retornaTipoPoliza(null);

            ///indicarle al dropdownlist que se muestre
            this.ddlTipoPoliza.DataBind();
        }

        protected void btAceptar_Click(object sender, EventArgs e)
        {
            this.AlmacenarDatos();
        }
        /// <summary>
        /// Valida que todas las reglas del formulario se hayan cumplido y procede
        /// a insertar el registro utilizando el procedimiento sp_InsertaCliente
        /// </summary>
        void AlmacenarDatos()
        {
            if (this.IsValid)
            {
                ///Variable que contiene el mensaje a visualizar
                string mensaje = "";

                ///Creación de la instancia de la clase BLCoberturaPoliza
                BLCoberturaPoliza oCoberturaPoliza = new BLCoberturaPoliza();
                bool resultado = false;

                if (oCoberturaPoliza.verificaCobertura(this.txtNombreCobertura.Text))
                {
                    try
                    {
                        ///Asignar a la variable el resultado de invocar el procedimiento
                        ///almacenado que se encuentra en el método
                        int idTipoPoliza = Convert.ToInt16(ddlTipoPoliza.SelectedValue);
                        float pPorcentaje = float.Parse(this.txtPorcentaje.Text);

                        resultado = oCoberturaPoliza.insertaCoberturaPoliza(this.txtNombreCobertura.Text, this.txtDescCobertura.Text,
                                                                                 pPorcentaje, idTipoPoliza);
                    }
                    catch (Exception excepcionCapturada)
                    {
                        ///Generación del mensaje de error
                        mensaje += $"Ha ocurrido un error: {excepcionCapturada.Message}";
                        ///Mostrar mensaje
                        Response.Write("<script>alert('" + mensaje + "')</script>");
                    }
                    finally
                    {
                        ///Si el resultado de la variable es verdadero, significa que no dió errores
                        if (resultado)
                        {
                            ///Generación del mensaje de inserción
                            mensaje += "El registro fue insertado";
                            ///Mostrar mensaje
                            Response.Write("<script>alert('" + mensaje + "')</script>");
                        }
                    }
                }
                else
                {
                    ///Generación del mensaje de error
                    mensaje = "Esta cobertura ya se encuentra registrada";
                    ///Mostrar mensaje
                    Response.Write("<script>alert('" + mensaje + "')</script>");
                }
            }
        }
    }
}