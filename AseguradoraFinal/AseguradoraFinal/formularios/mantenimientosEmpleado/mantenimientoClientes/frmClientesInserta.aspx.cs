using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoClientes
{
    public partial class frmClientesInserta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.cargaListaUsuario();
            }
        }

        protected void btBuscar_Click(object sender, EventArgs e)
        {
            this.cargaDocUsuario();
        }

        protected void btInsertar_Click(object sender, EventArgs e)
        {
            this.AlmacenarDatos();
        }

        /// <summary>
        /// Carga la lista de tipo usuarios
        /// </summary>
        void cargaListaUsuario()
        {
            ///Creación de la instancia de BLUsuario
            blUsuario oUsuario = new blUsuario();
            ///indicarle al dropdownlist la fuente de datos
            this.ddlCorreoElectronico.DataSource = oUsuario.retornaUsuarioCorreo(null);

            ///indicarle al dropdownlist que se muestre
            this.ddlCorreoElectronico.DataBind();
        }

        /// <summary>
        /// Carga la información de cobertura póliza
        /// </summary>
        void cargaDocUsuario()
        {
            ///Creación de la instancia a la clase BLCoberturaPoliza
            blUsuario oUsuario = new blUsuario();

            /*pa_RetornaUsuarioID_Result resultado = oUsuario.retornaUsuarioID(Convert.ToInt16(this.ddlCorreoElectronico.SelectedValue));*/

            this.hdIdUsuario.Value = this.ddlCorreoElectronico.SelectedValue;

            /*string registro = DateTime.Now.ToString();
            this.txtFechaRegistro.Text = registro;*/

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

                ///Creación de la instancia de la clase BLCliente
                BLCliente oCliente = new BLCliente();
                blUsuario oUsuario = new blUsuario();
                bool resultado = false;

                try
                {
                    ///Obtener los valores seleccionados por el usuario
                    int idUsuario = Convert.ToInt16(this.hdIdUsuario.Value);
                    string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                    

                    if (hdIdUsuario.Value == null)
                    {
                        mensaje = "Debes seleccionar un correo electrónico y hacer click en el botón de buscar";
                    }
                    else
                    {
                        ///Asignar a la variable el resultado de invocar el procedimiento
                        ///almacenado que se encuentra en el método
                        resultado = oCliente.insertaCliente(idUsuario, this.txtNombreCliente.Text, this.txtPriApellido.Text,
                                                            this.txtSegApellido.Text, this.txtNumCedula.Text, this.txtGenero.Text,
                                                            this.txtDireccionFisica.Text, this.txtPriTelefono.Text, this.txtSegTelefono.Text,
                                                            DateTime.Parse(fecha));

                        pa_RetornaClienteCorreo_Result resultadoCorreo = oCliente.retornaClienteCorreo(idUsuario);

                        /*resultadoIDUsuario = oUsuario.retornaUsuarioID(idUsuario);*/

                        oCliente.correoElectronicoIngreso(this.txtPriApellido.Text, this.txtSegApellido.Text, this.txtNombreCliente.Text, resultadoCorreo.correoElectronico);
                    }

                }
                catch (Exception excepcionCapturada)
                {
                    mensaje += $"Ha ocurrido un error: {excepcionCapturada.Message}";
                }
                finally
                {
                    ///Si el resultado de la variable es verdadero, significa que no dió errores
                    if (resultado)
                    {
                        mensaje += "El registro fue insertado";
                    }
                }

                ///Mostrar mensaje
                Response.Write("<script>alert('" + mensaje + "')</script>");
            }
        }
    }
}