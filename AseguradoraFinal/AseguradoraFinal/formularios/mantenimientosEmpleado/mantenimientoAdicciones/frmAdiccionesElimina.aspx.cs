﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoAdicciones
{
    public partial class frmAdiccionesElimina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //validar que sea la primera vez que se carga la pagina
            //o bien que no es una  "recarga" de pagina
            //if(!this.IsPostBack)
            if (this.IsPostBack == false)
            {
                this.cargaListaAdicciones();
                this.cargaListaClientes();
                this.cargaListaAddicionesCliente();
                this.cargaDatosRegistro();
            }


        }
        /// <summary>
        /// Carga la lista Gasto
        /// </summary>
        void cargaListaAdicciones()
        {
            BLEmpleado oAdicciones = new BLEmpleado();
            ///indicarle al dropdownlist la fuente de datos
            this.ddlAdicciones.DataSource = oAdicciones.ReturnGastoCatalogo(null);

            ///indicarle al dropdownlist que se muestre
            this.ddlAdicciones.DataBind();
        }

        /// <summary>
        /// Carga la lista de país de procedencia
        /// </summary>
        void cargaListaClientes()
        {
            BLEmpleado oClientes = new BLEmpleado();
            ///indicarle al dropdownlist la fuente de datos
            this.ddlClientes.DataSource = oClientes.Retorna_Catalogo_Categorias(null);
            ///indicarle al dropdownlist que se muestre
            this.ddlClientes.DataBind();
        }

        void cargaListaAddicionesCliente()
        {
            BLEmpleado oAdiccionesCliente = new BLEmpleado();
            ///indicarle al dropdownlist la fuente de datos
            this.ddlAdiccionesCliente.DataSource = oAdiccionesCliente.ReturnaAdiccionesxCliente(null);



            ///indicarle al dropdownlist que se muestre
            this.ddlAdiccionesCliente.DataBind();
        }

        void cargaDatosRegistro()
        {
            String parametro = this.Request.QueryString["id_Gasto_Categoria"];

            if (String.IsNullOrEmpty(parametro))
            {
                this.lblMensaje.Text = "Parámetro nulo";
            }
            else
            {
                int id_Gasto_Categoria = Convert.ToInt16(parametro);

                BLEmpleado oBLGastoCategoria = new BLEmpleado();

                sp_Retorna_Gasto_Categoria_ID_Result resultDataGastoCategoria = new sp_Retorna_Gasto_Categoria_ID_Result();

                resultDataGastoCategoria = oBLGastoCategoria.Retorna_Gasto_Categoria_ID(id_Gasto_Categoria);

                if (resultDataGastoCategoria == null)
                {
                    Response.Redirect("frmGastoCategoriaLista.aspx");
                }
                else
                {
                    this.ddlAdicciones.SelectedValue = resultDataGastoCategoria.id_Gasto.ToString();
                    this.ddlClientes.SelectedValue = resultDataGastoCategoria.id_Categoria.ToString();
                    this.ddlAdiccionesCliente.Text = Convert.ToString(resultDataGastoCategoria.cantidad);

                    ///Asignar al hidden field el valor de llave primaria
                    this.hdGastos.Value = resultDataGastoCategoria.id_Gasto_Categoria.ToString();
                }
            }

        }

        protected void btEliminar_Click(object sender, EventArgs e)
        {
            this.AlmacenarDatos();
        }
        void AlmacenarDatos()
        {
            if (this.IsValid)
            {
                BLGastoCategoria oBLGastoCategoria = new BLGastoCategoria();
                bool resultado = false;
                string mensaje = "";
                try
                {
                    int id_Gasto_Categoria = Convert.ToInt16(this.hdGastos.Value);

                    resultado = oBLGastoCategoria.Elimina_Gasto_Categoria(id_Gasto_Categoria);
                }
                ///catch: se ejecuta en el caso de que haya una excepcion
                ///excepcionCapturada: posee los datos de la excepción
                catch (Exception e)
                {
                    mensaje += $"Ocurrió un error al eliminar: {e}";
                }
                ///finally: siempre se ejecuta (se atrape o no la excepción)
                finally
                {
                    ///si el resultado de la variable es verdadera implica que
                    ///el procedimiento no retornó errores
                    if (resultado)
                    {
                        mensaje += "El registro fue eliminado correctamente";
                    }
                }
                ///mostrar el mensaje
                this.lblMensaje.Text = mensaje;
            }
        }

        
    }
}
