using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoTipoPoliza
{
    public partial class frmTipoPolizaEliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.cargaDatosRegistro();
            }
        }

        protected void btAceptar_Click(object sender, EventArgs e)
        {
            this.AlmacenarDatos();
        }

        void cargaDatosRegistro()
        {

            ///obtener el parámetro envíado desde el grid
            ///es CASESENSITIVE
            string parametro =
                this.Request.QueryString["idTipoPoliza"];

            //validar si el parametro es correcto
            if (String.IsNullOrEmpty(parametro))
            {
                string mensaje = "El parámetro es nulo";
                ///Mostrar mensaje
                Response.Write("<script>alert('" + mensaje + "')</script>");
            }
            else
            {
                int idTipoPoliza = Convert.ToInt16(parametro);
                BLTipoPoliza oTipoPoliza = new BLTipoPoliza();

                pa_RetornaTipoPolizaID_Result datosTipoPoliza = new pa_RetornaTipoPolizaID_Result();

                ///Invocar el procedimiento almacenado por medio del método
                datosTipoPoliza = oTipoPoliza.retornaTipoPolizaID(idTipoPoliza);

                ///Verificar que el objeto retornado no sea nulo
                if (datosTipoPoliza == null)
                {
                    Response.Redirect("/formularios/mantenimientosEmpleado/mantenimientoTipoPoliza/frmTipoPolizaLista.aspx");
                }
                else
                {
                    ///Asginación de cada una de las etiquetas sus valores respectivos en la invocacion del procedimiento almacenado
                    this.txtNombre.Text = datosTipoPoliza.nombre;
                    this.txtDesc.Text = datosTipoPoliza.detalles;

                    ///Asignar al hidden field el valor de llave primaria
                    this.hdIdTipoPoliza.Value = datosTipoPoliza.idTipoPoliza.ToString();
                }
            }

        }

        /// <summary>
        /// Valida que todas las reglas del formulario se hayan cumplido y procede
        /// a insertar el registro utilizando el procedimiento pa_EliminaTipoPoliza
        /// </summary>
        void AlmacenarDatos()
        {
            if (this.IsValid)
            {
                BLTipoPoliza oTipoPoliza = new BLTipoPoliza();
                bool resultado = false;
                string mensaje = "";
                try
                {
                    ///Obtener el ID del registro a Eliminar
                    int idTipoPoliza = Convert.ToInt16(this.hdIdTipoPoliza.Value);

                    ///Asignar a la variable el resultado de la invocacion del procedimiento almacenado
                    resultado = oTipoPoliza.eliminaTipoPoliza(idTipoPoliza);
                }
                ///catch: se ejecuta en el caso de que haya una excepcion
                ///excepcionCapturada: posee los datos de la excepción
                catch (Exception excepcionCapturada)
                {
                    mensaje += $"Ocurrió un error: {excepcionCapturada.Message}";
                }
                ///finally: siempre se ejecuta (se atrape o no la excepción)
                finally
                {
                    ///si el resultado de la variable es verdadera implica que
                    ///el procedimiento no retornó errores
                    if (resultado)
                    {
                        mensaje += "El registro fue eliminado";

                        ///Redireccionamiento a la lista de Tipo Polizas
                        this.Response.Redirect("/formularios/mantenimientosEmpleado/mantenimientoTipoPoliza/frmTipoPolizaLista.aspx");
                    }
                }
                ///Mostrar mensaje
                Response.Write("<script>alert('" + mensaje + "')</script>");
            }
        }

    }
}