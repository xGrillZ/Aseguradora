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
    public partial class frmClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.cargaDatosRegistro();
            }
        }

        protected void btEliminar_Click(object sender, EventArgs e)
        {
            this.AlmacenarDatos();
        }

        void cargaDatosRegistro()
        {
            string mensaje = "";
            ///obtener el parámetro envíado desde el grid
            ///es CASESENSITIVE
            string parametro =
                this.Request.QueryString["idCliente"];

            //validar si el parametro es correcto
            if (String.IsNullOrEmpty(parametro))
            {
                ///Generador mensaje
                mensaje = "El parámetro es nulo.";
                ///Mostrar mensaje
                Response.Write("<script>alert('" + mensaje + "')</script>");
            }
            else
            {
                int id_Cliente = Convert.ToInt16(parametro);
                BLCliente oCliente = new BLCliente();

                pa_RetornaClienteID_Result datosCliente = new pa_RetornaClienteID_Result();

                ///Invocar el procedimiento almacenado por medio del método
                datosCliente = oCliente.retornaClienteID(id_Cliente);

                ///Verificar que el objeto retornado no sea nulo
                if (datosCliente == null)
                {
                    Response.Redirect("/formularios/mantenimientosEmpleado/mantenimientoClientes/frmClientesLista.aspx");
                }
                else
                {
                    ///Asginación de cada una de las etiquetas sus valores respectivos en la invocacion del procedimiento almacenado
                    this.txtNombreCliente.Text = datosCliente.nomCliente;
                    this.txtPriApellido.Text = datosCliente.ape1Cliente;
                    this.txtSegApellido.Text = datosCliente.ape2Cliente;
                    this.txtDireccionFisica.Text = datosCliente.direccionFisica;
                    this.txtGenero.Text = datosCliente.genero;
                    this.txtNumCedula.Text = datosCliente.numCedula;
                    this.txtPriTelefono.Text = datosCliente.pTelefono;
                    this.txtSegTelefono.Text = datosCliente.sTelefono;

                    ///Asignar al hidden field el valor de llave primaria
                    this.hdIdCliente.Value = datosCliente.idCliente.ToString();
                }
            }

        }

        /// <summary>
        /// Valida que todas las reglas del formulario se hayan cumplido y procede
        /// a insertar el registro utilizando el procedimiento sp_InsertaCliente
        /// </summary>
        void AlmacenarDatos()
        {
            if (this.IsValid)
            {
                ///Creación del instanciamiento con la clase BLCliente
                BLCliente oCliente = new BLCliente();
                ///Creacion de la variable el cual administra la operacion
                bool resultado = false;
                ///Creación de la variable el cuál administra los mensajes
                string mensaje = "";
                try
                {
                    ///Obtener el ID del registro a Eliminar
                    int id_Cliente = Convert.ToInt16(this.hdIdCliente.Value);

                    ///Asignar a la variable el resultado de la invocacion del procedimiento almacenado
                    resultado = oCliente.eliminaCliente(id_Cliente);
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
                        mensaje += "El registro fue eliminado.";
                    }
                }
                ///Mostrar mensaje
                Response.Write("<script>alert('" + mensaje + "')</script>");
            }
        }
    }
}