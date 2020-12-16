using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.formularios.mantenimientoCliente.mantenimientoCliente
{
    public partial class frmClienteLista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnModificarDatos_Click(object sender, EventArgs e)
        {

        }

        void cargaDatosRegistro()
        {

            ///Variable que almacena el IDUsuario a la hora de iniciar sesión
            int dataUser = int.Parse(Session["idusuario"].ToString());
/*
            //validar si el parametro es correcto
            if (String.IsNullOrEmpty(parametro))
            {
                this.lblMensaje.Text = "El parámetro es nulo";
            }
            else
            {
                int id_Gasto_Categoria = Convert.ToInt16(parametro);
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
                }
            }*/

        }
    }
}