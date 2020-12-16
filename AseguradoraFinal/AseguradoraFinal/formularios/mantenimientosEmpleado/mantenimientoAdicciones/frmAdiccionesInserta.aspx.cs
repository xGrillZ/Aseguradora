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
            this.cargaListCategoriaAdicciones();
        }
        
        void cargaListCategoriaAdicciones()
        {

            BLEmpleado oIdCategoria = new BLEmpleado();
            ///indicarle al dropdownlist la fuente de datos
            this.ddlIdCategoria.DataSource = oIdCategoria.retornaCategoriaAdicciones(null);


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
                ///Variable que administra los mensajes a mostrar
                string mensaje = "";
                ///Creación de la instancia de la clase BLEmpleado
                BLEmpleado oAdiccion = new BLEmpleado();
                ///Variable que administra el resultado de la operación
                bool resultado = false;
                ///Verificación si el nombre de adicción existe
                if (oAdiccion.verificaAdiccion(this.txtNombreAdiccion.Text))
                {
                    try
                    {
                        ///obtener los valores seleccionados por el usuario
                        ///se toman de la propiedad datavaluefield
                        ///tanto del dropdown menu 



                        ///asignar a la variable el resultado de
                        ///invocar el procedimiento almacenado que se encuentra en el metodo

                        resultado = oAdiccion.InsertaAdicciones(this.txtNombreAdiccion.Text, Convert.ToInt16(this.ddlIdCategoria.Text));
                    }
                    ///catch se ejecuta en el caso de que haya una excepcion    
                    ///excepcionCapturada posee los datos de la excepcion
                    catch (Exception e)
                    {
                        mensaje += $"Ocurrió un error con la inserción{e}";
                    }
                    /// siempre se ejecuta se atrape o no la excepcion
                    finally
                    {
                        ///si el resultado de la variable es verdadera implica que
                        ///el proceimiento no retornó errores

                        if (resultado)
                        {
                            mensaje += "El registro fue insertado correctamente";
                        }
                        ///mostrar el mensaje
                        Response.Write("<script>alert('" + mensaje + "')</script>");
                    }
                }
                else
                {
                    ///Generador de mensaje
                    mensaje += "El nombre de la adicción ya existe, ingresa otro.";
                    ///mostrar el mensaje
                    Response.Write("<script>alert('" + mensaje + "')</script>");
                }

            }

        }

        
        protected void ddlIdCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///Obtener el texto seleccionado
            string text = this.ddlIdCategoria.SelectedItem.Text;
            ///Obtener el valor seleccionado, es decir el que sera
            ///utilizando para almacenar en la DB, muchas veces la llave foranea
            string valorIndentificado = this.ddlIdCategoria.SelectedValue;
        }

    }
}
