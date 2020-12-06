using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoAdicciones
{
    public partial class frmAdiccionesInserta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            this.cargaListaPaisProcedencia();
            this.cargaListaTipoCliente();

        }
        /// <summary>
        /// Carga la lista de tipo cliente
        /// </summary>
        void cargaListaTipoCliente()
        {

            ///indicarle al dropdownlist la fuente de datos

            ///indicarle al dropdownlist que se muestre

        }

        /// <summary>
        /// Carga la lista de país de procedencia
        /// </summary>
        void cargaListaPaisProcedencia()
        {

            ///indicarle al dropdownlist la fuente de datos

            ///indicarle al dropdownlist que se muestre

        }

        protected void btInsertar_Click(object sender, EventArgs e)
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