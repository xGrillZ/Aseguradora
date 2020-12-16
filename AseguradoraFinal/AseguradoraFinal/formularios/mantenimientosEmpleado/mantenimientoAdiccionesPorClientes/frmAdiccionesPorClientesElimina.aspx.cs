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
    public partial class frmAdiccionesPorClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.cargaListaIdAdiccion();
                this.cargaDatosRegistro();
            }
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
                int id_AdiccionPorCliente = Convert.ToInt16(parametro);

                BLAdiccionCliente oAdiccionCliente = new BLAdiccionCliente();

                pa_RetornaAdiccionClienteID_Result datosAdCliente = new pa_RetornaAdiccionClienteID_Result();

                datosAdCliente = oAdiccionCliente.retornaAdiccionPorClienteID(id_AdiccionPorCliente);

                if (datosAdCliente == null)
                {
                    Response.Redirect("/formularios/mantenimientosEmpleado/mantenimientoAdiccionesPorClientes/frmAdiccionesPorClientesLista.aspx");
                }
                else
                {
                    ///Asignación de cada una de las etiquetas sus valores respectivos en la invocacion del PA
                    this.ddlAdiccion.SelectedValue = datosAdCliente.idAdiccion.ToString();
                    this.txtCedula.Text = datosAdCliente.numCedula;

                    ///Asignar al hidden field el valor de llave primaria
                    this.hdIdAdiccionCliente.Value = datosAdCliente.idMantAdiccionxCliente.ToString();
                    this.hdIdCliente.Value = datosAdCliente.idCliente.ToString();
                }
            }

        }

        /// <summary>
        /// Método para realizar la operación de eliminar
        /// </summary>
        void AlmacenarDatos()
        {
            if (this.IsValid)
            {
                ///Creación del instanciamiento con la clase BLCliente
                BLAdiccionCliente oAdiccionesCliente = new BLAdiccionCliente();
                ///Creacion de la variable el cual administra la operacion
                bool resultado = false;
                ///Creación de la variable el cuál administra los mensajes
                string mensaje = "";
                try
                {
                    ///Obtener el ID del registro a Eliminar
                    int id_AdiccionCliente = Convert.ToInt16(this.hdIdAdiccionCliente.Value);

                    ///Asignar a la variable el resultado de la invocacion del procedimiento almacenado
                    resultado = oAdiccionesCliente.eliminaAdiccionPorCliente(id_AdiccionCliente);
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

        protected void btEliminar_Click(object sender, EventArgs e)
        {
            this.AlmacenarDatos();
        }
    }
}