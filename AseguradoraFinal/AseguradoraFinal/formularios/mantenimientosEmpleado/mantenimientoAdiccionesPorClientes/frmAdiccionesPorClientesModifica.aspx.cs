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
                int id_MantAdiccionCliente = Convert.ToInt16(this.hdIdAdiccionCliente.Value);
                int idCliente = Convert.ToInt16(this.hdIdCliente.Value);

                if (oAdiccionCliente.verificaAdiccion(idCliente, id_Adiccion))
                {
                    try
                    {
                        resultado = oAdiccionCliente.modificaAdiccionCliente(id_Adiccion, id_MantAdiccionCliente);
                    }
                    catch (Exception excepcionCapturada)
                    {
                        mensaje += $"Ocurrió un error: {excepcionCapturada}";
                    }
                    finally
                    {
                        if (resultado)
                        {
                            mensaje += "El registro fue modificado.";
                        }
                    }
                    ///mostrar el mensaje
                    Response.Write("<script>alert('" + mensaje + "')</script>");
                }
                else
                {
                    mensaje += "El cliente ya tiene esta adicción, debes cambiarlo.";
                    ///mostrar el mensaje
                    Response.Write("<script>alert('" + mensaje + "')</script>");
                }
            }
        }

        protected void btModificar_Click(object sender, EventArgs e)
        {
            this.AlmacenarDatos();
        }
    }
}