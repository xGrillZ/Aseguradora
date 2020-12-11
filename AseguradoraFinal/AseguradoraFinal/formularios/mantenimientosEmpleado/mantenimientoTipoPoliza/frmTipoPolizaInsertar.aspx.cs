using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoTipoPoliza
{
    public partial class frmTipoPolizaInsertar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btAceptar_Click(object sender, EventArgs e)
        {
            this.AlmacenarDatos();
        }

        /// <summary>
        /// Valida que todas las reglas del formulario se hayan cumplido y procede
        /// a insertar el registro utilizando el procedimiento sp_InsertaTipoPoliza
        /// </summary>
        void AlmacenarDatos()
        {
            if (this.IsValid)
            {
                string mensaje = "";

                ///Creación de la instancia de la clase EstudianteTelefonoBL
                BLTipoPoliza oTipoPoliza = new BLTipoPoliza();
                bool resultado = false;

                try
                {

                    ///Asignar a la variable el resultado de invocar el procedimiento
                    ///almacenado que se encuentra en el método
                    resultado = oTipoPoliza.insertaTipoPoliza(this.txtNombre.Text, this.txtDesc.Text);

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

                        ///Redireccionamiento a la lista de Tipo Polizas
                        this.Response.Redirect("/formularios/mantenimientosEmpleado/mantenimientoTipoPoliza/frmTipoPolizaLista.aspx");
                        
                        ///Mostrar mensaje
                        Response.Write("<script>alert('" + mensaje + "')</script>");
                    }
                }
            }
        }
    }
}