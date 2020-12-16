using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoUsuario
{
    public partial class frmUsuarioInserta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.cargaListaTipoUsuario();
            }
        }

        protected void btInsertar_Click(object sender, EventArgs e)
        {
            this.AlmacenarDatos();
        }

        /// <summary>
        /// Carga la lista de tipo usuarios
        /// </summary>
        void cargaListaTipoUsuario()
        {
            ///Creación de la instancia de BLUsuario
            blUsuario oUsuario = new blUsuario();
            ///indicarle al dropdownlist la fuente de datos
            this.ddlTipoUsuario.DataSource = oUsuario.retornaTipoUsuario(null);

            ///indicarle al dropdownlist que se muestre
            this.ddlTipoUsuario.DataBind();
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

                blUsuario oUsuario = new blUsuario();

                bool resultado = false;

                try
                {
                    ///obtener los valores seleccionados por el usuario
                    ///se toman de la propiedad datavaluefield
                    ///tanto del dropdown menu 

                    int idTipoUsuario = Convert.ToInt16(this.ddlTipoUsuario.SelectedValue);

                    ///asignar a la variable el resultado de
                    ///invocar el procedimiento almacenado que se encuentra en el metodo

                    resultado = oUsuario.insertaUsuario(this.txtContrasena.Text, idTipoUsuario, this.txtCorreo.Text);
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
                        mensaje += "El registro fue insertado correctamente, puedes crear un nuevo cliente.";
                    }
                    ///mostrar el mensaje
                    Response.Write("<script>alert('" + mensaje + "')</script>");
                }

            }

        }
    }
}