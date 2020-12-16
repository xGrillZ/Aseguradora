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
                ///Variable que contiene el mensaje a visualizar
                string mensaje = "";

                ///Creación de la instancia de la clase BLCoberturaPoliza
                blUsuario oUsuario = new blUsuario();
                bool resultado = false;

                ///Creación de una lista el cuál contiene el resultado de datos
                List<pa_RetornaUsuarioCorreo_Result> listaRetornaUsuarioCorreo = oUsuario.retornaUsuarioCorreo(null);

                ///Contador para el resultado
                int contadorUsuario = 0;

                try
                {
                    ///Recorrido de la lista que contiene todos los datos de la CoberturaPoliza
                    for (int i = 0; i < listaRetornaUsuarioCorreo.Count; i++)
                    {
                        ///Verificar si el nombre de la cobertura existe o no
                        if (listaRetornaUsuarioCorreo[i].correoElectronico.Equals(this.txtCorreo.Text))
                        {
                            contadorUsuario = 1;
                            ///Generación del mensaje de error
                            mensaje = "Este usuario ya se encuentra registrado.";
                            ///Mostrar mensaje
                            Response.Write("<script>alert('" + mensaje + "')</script>");
                        }
                        else
                        {
                            ///Asignar a la variable el resultado de invocar el procedimiento
                            ///almacenado que se encuentra en el método
                            int idTipoUsuario = Convert.ToInt16(ddlTipoUsuario.SelectedValue);
                            string correo = this.txtCorreo.Text;
                            string contrasena = this.txtContrasena.Text;

                            resultado = oUsuario.insertaUsuario(contrasena, idTipoUsuario, correo);
                        }
                    }
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
                        mensaje += "El registro fue insertado, puedes crear un nuevo cliente.";
                        ///Mostrar mensaje
                        Response.Write("<script>alert('" + mensaje + "')</script>");
                    }
                }
            }
        }
    }
}