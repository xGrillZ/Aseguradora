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
                string mensaje = "";

                ///mostrar el mensaje
                Response.Write("<script>alert('" + mensaje + "')</script>"); ;
            }
        }
    }
}