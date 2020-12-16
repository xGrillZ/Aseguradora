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
    public partial class frmAdiccionesModifica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            this.cargaListaIdAdiccion();
            this.cargaDatosRegistro();
            this.cargaDatosIdCategoria(); 


        }
        /// <summary>
        /// Carga la lista de id Adiccion
        /// </summary>
        void cargaListaIdAdiccion()
        {

            BLEmpleado oAdiccion = new BLEmpleado();
            ///indicarle al dropdownlist la fuente de datos
            this.ddlIdAdiccion.DataSource = oAdiccion.RetornaAdicciones(null);


            ///indicarle al dropdownlist que se muestre
            this.ddlIdAdiccion.DataBind();

        }

        /// <summary>
        /// Carga la lista de id Adiccion
        /// </summary>
        void cargaDatosIdCategoria()
        {

            BLEmpleado oCategoria = new BLEmpleado();
            ///indicarle al dropdownlist la fuente de datos
            this.ddlIdCategoria.DataSource = oCategoria.RetornaAdicciones(null);


            ///indicarle al dropdownlist que se muestre 
            this.ddlIdCategoria.DataBind();

        }

        void cargaDatosRegistro()
        {
            ///obtener el parámetro envíado desde el grid
            ///es CASESENSITIVE
            String parametro = this.Request.QueryString["idAdiccion"];

            //validar si el parametro enviado es correcto
            if (String.IsNullOrEmpty(parametro))
            {
                ///Generación mensaje
                string mensaje = "El parámetro es nulo";
                ///mostrar el mensaje
                Response.Write("<script>alert('" + mensaje + "')</script>");

            }
            else
            {
                ///Creación de variable el cuál almacenará el idAdiccion enviada por la variable parametro
                int idAdiccion = Convert.ToInt16(parametro);

                ///Creación de la instancia a la clase BLEmpleado
                BLEmpleado oAdiccionElimina = new BLEmpleado();

                ///Creación de la variable el cual obtendrá los datos del procedimiento almacenado ///Creación de la variable el cual obtendrá los datos del procedimiento almacenado
                pa_RetornaAdiccionesID_Result resultDataAdiccion = new pa_RetornaAdiccionesID_Result();
                resultDataAdiccion = oAdiccionElimina.RetornaAdiccionesID(idAdiccion);

                this.hdIdAdiccion.Value = resultDataAdiccion.idAdiccion.ToString();

                if (resultDataAdiccion == null)
                {
                    Response.Redirect("frmAdiccionesLista.aspx");
                }
                else
                {

                    //this.ddlIdAdiccion.SelectedValue = resultDataAdiccion.idAdiccion; // broncas con este
                    this.ddlIdCategoria.SelectedValue = resultDataAdiccion.nombre.ToString();
                    

                    this.hdIdAdiccion.Value = resultDataAdiccion.idAdiccion.ToString();
                  
                }
            }
            //validar si el parametro es correcto

        }


        protected void btAceptar_Click(object sender, EventArgs e)
          {
              this.AlmacenarDatos();
          }
        /// <summary>
        /// Valida que todas las reglas del formulario se hayan cumplido y procede
        /// a modificar el registro utilizando el procedimiento pa_ModificaAdicciones
        /// </summary>
        void AlmacenarDatos()
          {
              if (this.IsValid)
              {
                  BLEmpleado oModifica = new BLEmpleado();
                   bool resultado = false;
                   string mensaje = "";
                   try
                   {
                    ///obtener los valores seleccionados por el usuario
                    ///se toman de la propiedad datavaluefield
                    ///tanto del dropdownlist como del listbox
                    string nombre = this.ddlIdAdiccion.SelectedValue;
                    int idCategoriaAdicion = Convert.ToInt16(this.ddlIdCategoria.SelectedValue);
                       //obtener el valor del hidden field 
                      int idAdiccion = Convert.ToInt16(this.hdIdAdiccion.Value);
                    ///asignar a la variable el resultado de 
                    ///invocar el procedimiento almacenado
                    resultado = oModifica.ModificaAdicciones( 
                           idAdiccion,
                           nombre,
                           idCategoriaAdicion
                           );

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
                           mensaje += "El registro fue modificado";
                       }
                   }
                   ///mostrar el mensaje
                   Response.Write("<script>alert('" + mensaje + "')</script>"); ;
              }

          }
      }
    }

