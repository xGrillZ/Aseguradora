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
    public partial class frmAdiccionesPorClientesModifica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.cargaListaIdAdiccion();
                this.cargaDatosRegistro();
            }
        }

        protected void btModificar_Click(object sender, EventArgs e)
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

        void cargaDatosRegistro()
        {

            ///obtener el parámetro envíado desde el grid
            ///es CASESENSITIVE
            string parametro =
                this.Request.QueryString["idMantAdiccionxCliente"];
            ///Variable que administra los mensajes
            string mensaje = "";

            //validar si el parametro es correcto
            if (String.IsNullOrEmpty(parametro))
            {
                ///Mensaje a mostrar
                mensaje = "El parámetro es nulo";
                ///mostrar el mensaje
                Response.Write("<script>alert('" + mensaje + "')</script>");
            }
            else
            {
                int id_AdiccionCliente = Convert.ToInt16(parametro);

                BLAdiccionCliente oAdiccionCliente = new BLAdiccionCliente();

                pa_RetornaAdiccionClienteID_Result datosAdiccionCliente = new pa_RetornaAdiccionClienteID_Result();

                ///Invocar el procedimiento almacenado por medio del método
                datosAdiccionCliente = oAdiccionCliente.retornaAdiccionClienteID(id_AdiccionCliente);

                ///Verificar que el objeto retornado no sea nulo
                if (datosAdiccionCliente == null)
                {
                    Response.Redirect("/formularios/mantenimientosEmpleado/mantenimientoAdiccionesPorClientes/frmAdiccionesPorClientesLista.aspx");
                }
                else
                {
                    ///Asginación de cada una de las etiquetas sus valores respectivos en la invocacion del procedimiento almacenado
                    this.ddlAdiccion.SelectedValue = datosAdiccionCliente.idAdiccion.ToString();
                    this.txtCedula.Text = Convert.ToString(datosAdiccionCliente.numCedula);

                    ///Asignar al hidden field el valor de llave primaria
                    this.hdIdAdiccionCliente.Value = datosAdiccionCliente.idMantAdiccionxCliente.ToString();
                    this.hdIdCliente.Value = datosAdiccionCliente.idCliente.ToString();
                }
            }

        }

        /// <summary>
        /// Valida que todas las reglas del formulario se hayan cumplido y procede
        /// a insertar el registro utilizando el procedimiento sp_ModificaAdiccionCliente
        /// </summary>
        void AlmacenarDatos()
        {
            if (this.IsValid)
            {
                ///Creación de la instancia a la clase BLAdiccionCliente
                BLAdiccionCliente oAdiccionCliente = new BLAdiccionCliente();
                ///Creación de la variable que administra el resultado de la operacion
                bool resultado = false;
                ///Creación de la variable que administra los mensajes a mostrar
                string mensaje = "";

                ///obtener los valores seleccionados por el usuario
                ///se toman de la propiedad datavaluefield del dropdownlist
                int id_Adiccion = Convert.ToInt16(this.ddlAdiccion.SelectedValue);
                ///obtener el valor del hidden field 
                int id_AdiccionCliente = Convert.ToInt16(this.hdIdAdiccionCliente.Value);
                int idCliente = Convert.ToInt16(this.hdIdCliente.Value);

                if (oAdiccionCliente.verificaAdiccion(idCliente, id_Adiccion))
                {
                    try
                    {
                        ///asignar a la variable el resultado de 
                        ///invocar el procedimiento almacenado
                        resultado = oAdiccionCliente.modificaAdiccionCliente(id_Adiccion, id_AdiccionCliente);

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