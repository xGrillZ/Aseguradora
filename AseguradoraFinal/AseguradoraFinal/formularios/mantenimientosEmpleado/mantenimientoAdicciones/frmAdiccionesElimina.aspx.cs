using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoAdicciones
{
    public partial class frmAdiccionesElimina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //validar que sea la primera vez que se carga la pagina
            //o bien que no es una  "recarga" de pagina
            //if(!this.IsPostBack)
            if (this.IsPostBack == false)
            {
                this.cargaListaAdicciones();
                this.cargaDatosRegistro();
            }


        }
        /// <summary>
        /// Carga la lista Adicciones
        /// </summary>
       void cargaListaAdicciones()
        {
            BLEmpleado oAdiccion = new BLEmpleado();
            ///indicarle al dropdownlist la fuente de datos
            this.ddlNombreAdiccion.DataSource = oAdiccion.retornaCategoriaAdicciones(null);


            ///indicarle al dropdownlist que se muestre

            
            this.ddlNombreAdiccion.DataBind();
        }

       

        void cargaDatosRegistro()
        {
            String parametro = this.Request.QueryString["idAdiccion"];

            //validar si el parametro es correcto
            if (String.IsNullOrEmpty(parametro))
            {
                ///Generación mensaje
                string mensaje = "El parámetro es nulo";
                ///mostrar el mensaje
                Response.Write("<script>alert('" + mensaje + "')</script>");
                //this.lblMensaje.Text = "Parámetro nulo";
            }
            else
            {
                ///Creación de variable el cuál almacenará el idAiccion enviada por la variable parametro
                int idAdiccion = Convert.ToInt16(parametro);

                ///Creación de la instancia a la clase BLEmpleado
                BLEmpleado oAdiccionElimina = new BLEmpleado();

                ///Creación de la variable el cual obtendrá los datos del procedimiento almacenado ///Creación de la variable el cual obtendrá los datos del procedimiento almacenado
                pa_RetornaAdiccionesID_Result resultDataAdiccion = new pa_RetornaAdiccionesID_Result();

                this.hdIdAdiccion.Value = resultDataAdiccion.idAdiccion.ToString();

               


            }

        }

        protected void btEliminar_Click(object sender, EventArgs e)
        {
            this.AlmacenarDatos();
        }


        void AlmacenarDatos()
        {
            if (this.IsValid)
            {
                BLEmpleado oElimina = new BLEmpleado();
                bool resultado = false;
                string mensaje = "";
                try
                {
                    int idAdiccion = Convert.ToInt16(this.hdIdAdiccion.Value);

                    resultado = oElimina.EliminaAdicciones(idAdiccion);
                }
                ///catch: se ejecuta en el caso de que haya una excepcion
                ///excepcionCapturada: posee los datos de la excepción
                catch (Exception e)
                {
                    mensaje += $"Ocurrió un error al eliminar: {e}";
                }
                ///finally: siempre se ejecuta (se atrape o no la excepción)
                finally
                {
                    ///si el resultado de la variable es verdadera implica que
                    ///el procedimiento no retornó errores
                    if (resultado)
                    {
                        mensaje += "El registro fue eliminado correctamente";
                    }
                }
                ///mostrar el mensaje
                this.lblMensaje.Text = mensaje;
            }
        }

      
    }
}

