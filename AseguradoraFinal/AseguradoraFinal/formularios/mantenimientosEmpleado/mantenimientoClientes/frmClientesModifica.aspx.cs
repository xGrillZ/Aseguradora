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
    public partial class frmClientesModifica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.cargaDatosRegistro();
        }

        protected void btModificar_Click(object sender, EventArgs e)
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
        /// a insertar el registro utilizando el procedimiento sp_ModificaCliente
        /// </summary>
        void AlmacenarDatos()
        {
            if (this.IsValid)
            {
                ///Creación de la instancia a la clase BLCliente
                BLCliente oCliente = new BLCliente();

                ///Creación de la variable que administra el resultado de la operación
                bool resultado = false;
                ///Creación de la variable que administra el mensaje a mostrar
                string mensaje = "";

                try
                {
               
                    ///obtener el valor del hidden field 
                    int id_Cliente = Convert.ToInt16(this.hdIdCliente.Value);
                    ///asignar a la variable el resultado de 
                    ///invocar el procedimiento almacenado
                    resultado = oCliente.modificaCliente(id_Cliente, this.txtNombreCliente.Text, this.txtPriApellido.Text,
                                                         this.txtSegApellido.Text, this.txtNumCedula.Text, this.txtGenero.Text,
                                                         this.txtDireccionFisica.Text, this.txtPriTelefono.Text, this.txtSegTelefono.Text);

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
                ///Mostrar mensaje
                Response.Write("<script>alert('" + mensaje + "')</script>");
            }
        }
    }
}