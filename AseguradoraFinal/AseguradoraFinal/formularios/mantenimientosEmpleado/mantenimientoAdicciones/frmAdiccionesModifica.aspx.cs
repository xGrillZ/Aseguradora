﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoAdicciones
{
    public partial class frmAdiccionesModifica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            this.cargaListaIdAdiccion();
            this.cargaListaNombre();
            this.cargaListaCodigo();
            this.cargaListaIdCategoriaAdiccion();

        }
        /// <summary>
        /// Carga la lista de id Adiccion
        /// </summary>
        void cargaListaIdAdiccion()
        {

            BLEmpleado oAdiccion = new BLEmpleado();
            ///indicarle al dropdownlist la fuente de datos
            this.ddlIdAdiccion.DataSource = oAdiccion.RetornaAdicciones(0, 0);


            ///indicarle al dropdownlist que se muestre
            this.ddlIdAdiccion.DataBind();

        }

        /// <summary>
        /// Carga la lista de Nombre de adicción
        /// </summary>
        void cargaListaNombre()
        {

            BLEmpleado oNombreAdiccion = new BLEmpleado();
            ///indicarle al dropdownlist la fuente de datos
            this.ddlNombreAdiccion.DataSource = oNombreAdiccion.RetornaAdicciones(0, 0);


            ///indicarle al dropdownlist que se muestre
            this.ddlNombreAdiccion.DataBind();

        }

        void cargaListaCodigo()
        {

            BLEmpleado oCodigoAdiccion = new BLEmpleado();
            ///indicarle al dropdownlist la fuente de datos
            this.ddlCodigoAdiccion.DataSource = oCodigoAdiccion.RetornaAdicciones(0, 0);


            ///indicarle al dropdownlist que se muestre
            this.ddlCodigoAdiccion.DataBind();

        }

        void cargaListaIdCategoriaAdiccion()
        {

            BLEmpleado oIdCategoria = new BLEmpleado();
            ///indicarle al dropdownlist la fuente de datos
            this.ddlIdCategoria.DataSource = oIdCategoria.RetornaAdicciones(0, 0);


            ///indicarle al dropdownlist que se muestre
            this.ddlIdCategoria.DataBind();

        }

        /*  protected void btAceptar_Click(object sender, EventArgs e)
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
                  BLCliente oCliente = new BLCliente();
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
                   Response.Write("<script>alert('" + mensaje + "')</script>"); ;
              }

          }
      }*/
    }
}
