using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoAdicciones
{
    public partial class frmAdiccionesInserta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            this.cargaListaIdAdiccion();
            this.cargaListaNombre();
            this.cargaListaCodigo();
            this.cargaListaIdCategoriaAdiccion();

        }
        /// <summary>
        /// Carga la lista de id Adiccion
        /// </summary>
        void cargaListaIdAdiccion()
        {

            BLEmpleado oAdiccion = new BLEmpleado();
            ///indicarle al dropdownlist la fuente de datos
            this.ddlIdAdiccion.DataSource = oAdiccion.RetornaAdicciones(0,0);


            ///indicarle al dropdownlist que se muestre
            this.ddlIdAdiccion.DataBind();

        }

        /// <summary>
        /// Carga la lista de Nombre de adicción
        /// </summary>
        void cargaListaNombre()
        {

            BLEmpleado oNombreAdiccion = new BLEmpleado();
            ///indicarle al dropdownlist la fuente de datos
            this.ddlNombreAdiccion.DataSource = oNombreAdiccion.RetornaAdicciones(0,0);


            ///indicarle al dropdownlist que se muestre
            this.ddlNombreAdiccion.DataBind();

        }

        void cargaListaCodigo()
        {

            BLEmpleado oCodigoAdiccion = new BLEmpleado();
            ///indicarle al dropdownlist la fuente de datos
            this.ddlCodigoAdiccion.DataSource = oCodigoAdiccion.RetornaAdicciones(0,0);


            ///indicarle al dropdownlist que se muestre
            this.ddlCodigoAdiccion.DataBind();

        }

        void cargaListaIdCategoriaAdiccion()
        {

            BLEmpleado oIdCategoria = new BLEmpleado();
            ///indicarle al dropdownlist la fuente de datos
            this.ddlIdCategoria.DataSource = oIdCategoria.RetornaAdicciones(0,0);


            ///indicarle al dropdownlist que se muestre
            this.ddlIdCategoria.DataBind(); 

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