using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoAdiccionesPorClientes
{
    public partial class frmAdiccionesPorClientesInserta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.cargaListaIdAdiccion();
            }
        }

        protected void btInsertar_Click(object sender, EventArgs e)
        {
            this.AlmacenarDatos();
        }

        /// <summary>
        /// Carga la lista de id Adiccion
        /// </summary>
        void cargaListaIdAdiccion()
        {

            BLEmpleado oAdiccion = new BLEmpleado();
            ///indicarle al dropdownlist la fuente de datos
            this.ddlAdiccion.DataSource = oAdiccion.RetornaAdicciones(null);


            ///indicarle al dropdownlist que se muestre
            this.ddlAdiccion.DataBind();

        }

        protected void btBuscar_Click(object sender, EventArgs e)
        {
            this.cargaDocCliente();
        }

        /// <summary>
        /// Carga la información del Cliente
        /// </summary>
        void cargaDocCliente()
        {
            ///Creación de la instancia a la clase BLCoberturaPoliza
            BLCliente oCliente = new BLCliente();
            string mensaje = "";

            if (oCliente.verificaCedulaNegativo(this.txtCedula.Text))
            {
                /*pa_RetornaUsuarioID_Result resultado = oUsuario.retornaUsuarioID(Convert.ToInt16(this.ddlCorreoElectronico.SelectedValue));*/
                pa_RetornaClienteCed_Result resultado = oCliente.retornaClienteCedPoliza(this.txtCedula.Text);

                this.hdIdCliente.Value = resultado.idCliente.ToString();

                /*string registro = DateTime.Now.ToString();
                this.txtFechaRegistro.Text = registro;*/
            }
            else
            {
                ///Generador de mensaje
                mensaje += "El número de cédula no existe, ingresa otro.";
                ///mostrar el mensaje
                Response.Write("<script>alert('" + mensaje + "')</script>");
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
                ///Variable que administra los mensajes
                string mensaje = "";

                ///Creación de la instancia de la clase BLAdiccionCliente
                BLAdiccionCliente oAdiccionCliente = new BLAdiccionCliente();
                ///Variable que administra el resultado de la operación
                bool resultado = false;

                ///Obtener los valores seleccionados por el usuario
                int id_Cliente = Convert.ToInt16(this.hdIdCliente.Value);
                int id_Adiccion = Convert.ToInt16(this.ddlAdiccion.SelectedValue);

                ///Verificador si el cliente tiene la adiccion o no
                if (oAdiccionCliente.verificaAdiccion(id_Cliente, id_Adiccion))
                {
                    try
                    {

                        ///Asignar a la variable el resultado de invocar el procedimiento
                        ///almacenado que se encuentra en el método
                        resultado = oAdiccionCliente.insertaAdiccionCliente(id_Adiccion, id_Cliente);

                    }
                    catch (Exception excepcionCapturada)
                    {
                        ///Generador de mensaje
                        mensaje += $"Ha ocurrido un error: {excepcionCapturada.Message}";
                    }
                    finally
                    {
                        ///Si el resultado de la variable es verdadero, significa que no dió errores
                        if (resultado)
                        {
                            ///Generador de mensaje
                            mensaje += "El registro fue insertado";
                        }
                    }
                    ///mostrar el mensaje
                    Response.Write("<script>alert('" + mensaje + "')</script>");
                }
                else
                {
                    ///Generador de mensaje
                    mensaje += "Esta adicción ya le pertenece a este usuario, ingresa otra.";
                    ///mostrar el mensaje
                    Response.Write("<script>alert('" + mensaje + "')</script>");
                }
            }
        }
    }
}