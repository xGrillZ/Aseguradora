﻿/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoAdicciones
{
    public partial class frmAdiccionesModifica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.cargaListaPaisProcedencia();
                this.cargaListaTipoCliente();
                this.cargaDatosRegistro();
            }
        }

        /// <summary>
        /// Carga la lista de tipo cliente
        /// </summary>
        void cargaListaTipoCliente()
        {
            /*
            BLEmpleado blAddiciones = new BLEmpleado();
            ///indicarle al dropdownlist la fuente de datos
            this.ddlTipoCliente.DataSource = oTipoCliente.RetornaTipoCliente();
            ///indicarle al dropdownlist que se muestre
            this.ddlTipoCliente.DataBind();*/
        }

        /// <summary>
        /// Carga la lista de país de procedencia
        /// </summary>
        void cargaListaPaisProcedencia()
        {
            /* BLPaisProcedencia oPaisProcedencia = new BLPaisProcedencia();
             ///indicarle al dropdownlist la fuente de datos
             this.lstPaisProcedencia.DataSource = oPaisProcedencia.RetornaPaisProcedencia();
             ///indicarle al dropdownlist que se muestre
             this.lstPaisProcedencia.DataBind();*/

        }

        void cargaDatosRegistro()
        {

            ///obtener el parámetro envíado desde el grid
            ///es CASESENSITIVE


            //validar si el parametro es correcto

        }

        protected void btAceptar_Click(object sender, EventArgs e)
        {
            this.AlmacenarDatos();
        }
        /// <summary>
        /// Valida que todas las reglas del formulario se hayan cumplido y procede
        /// a insertar el registro utilizando el procedimiento sp_InsertaCliente
        /// </summary>
        void AlmacenarDatos()
        {
            if (this.IsValid)
            {
                /* BLCliente oCliente = new BLCliente();
                 bool resultado = false;
                 string mensaje = "";
                 try
                 {
                     ///obtener los valores seleccionados por el usuario
                     ///se toman de la propiedad datavaluefield
                     ///tanto del dropdownlist como del listbox
                     int id_TipoCliente = Convert.ToInt16(this.ddlTipoCliente.SelectedValue);
                     int id_PaisProcedencia = Convert.ToInt16(this.lstPaisProcedencia.SelectedValue);
                     //obtener el valor del hidden field 
                     int id_Cliente = 0;
                     ///asignar a la variable el resultado de 
                     ///invocar el procedimiento almacenado
                     resultado = oCliente.ModificaCliente(
                         id_Cliente,
                         id_TipoCliente,
                         this.txtPrimerApellido.Text,
                         this.txtSegundoApellido.Text,
                         this.txtNombre.Text,
                         id_PaisProcedencia,
                         this.txtTelefono1.Text,
                         this.txtTelefono2.Text
                         );

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
                 Response.Write("<script>alert('" + mensaje + "')</script>"); ;*/
            }

        }
<<<<<<< HEAD
    }*/
=======
    }
}
>>>>>>> 24ac19d02534a61daf3a1bdecc4da6e243998c50
