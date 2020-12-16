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
/*
                BLGastoCategoria oGastoCategoria = new BLGastoCategoria();

                sp_Retorna_Gasto_Categoria_ID_Result datosGastoCategoria = new sp_Retorna_Gasto_Categoria_ID_Result();

                ///Invocar el procedimiento almacenado por medio del método
                datosGastoCategoria = oGastoCategoria.RetornaGastoCategoriaID(id_Gasto_Categoria);

                ///Verificar que el objeto retornado no sea nulo
                if (datosGastoCategoria == null)
                {
                    Response.Redirect("frmGastoCategoriaLista.aspx");
                }
                else
                {
                    ///Asginación de cada una de las etiquetas sus valores respectivos en la invocacion del procedimiento almacenado
                    this.ddl_Gastos.SelectedValue = datosGastoCategoria.id_Gasto.ToString();
                    this.ddl_Categoria.SelectedValue = datosGastoCategoria.id_Categoria.ToString();
                    this.txtCantidad.Text = Convert.ToString(datosGastoCategoria.cantidad);

                    ///Asignar al hidden field el valor de llave primaria
                    this.hdIdGastoCategoria.Value = datosGastoCategoria.id_Gasto_Categoria.ToString();
                }*/
            }

        }
    }
}