﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoCoberturaPoliza
{
    public partial class frmCoberturaPolizaModifica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.cargaListaTipoPoliza();
                this.cargaDatosRegistro();
            }

        }
        /// <summary>
        /// Carga la lista de tipo poliza
        /// </summary>
        void cargaListaTipoPoliza()
        {
            ///Creación de la instancia a la clase BLTipoPoliza
            BLTipoPoliza oTipoPoliza = new BLTipoPoliza();

            ///indicarle al dropdownlist la fuente de datos
            this.ddlTipoPoliza.DataSource = oTipoPoliza.retornaTipoPoliza(null);

            ///indicarle al dropdownlist que se muestre
            this.ddlTipoPoliza.DataBind();
        }

        protected void btAceptar_Click(object sender, EventArgs e)
        {
            this.AlmacenarDatos();
        }

        void cargaDatosRegistro()
        {

            ///obtener el parámetro envíado desde el grid
            ///es CASESENSITIVE
            string parametro = this.Request.QueryString["idCoberturaPoliza"];

            ///validar si el parametro es correcto
            if (String.IsNullOrEmpty(parametro))
            {
                Response.Write("<script>alert('Parámetro nulo')</script>");
            }
            else
            {
                int idCoberturaPoliza = Convert.ToInt16(parametro);

                BLCoberturaPoliza oCoberturaPoliza = new BLCoberturaPoliza();

                pa_RetornaCoberturaPolizaID_Result datosCoberturaPoliza = new pa_RetornaCoberturaPolizaID_Result();

                ///Invocar al procedimiento almacenado por medio del metodo
                datosCoberturaPoliza = oCoberturaPoliza.retornaCoberturaPolizaID(idCoberturaPoliza);

                ///Verificar que el objeto retornado no sea nulo
                if (datosCoberturaPoliza == null)
                {
                    Response.Redirect("/formularios/mantenimientosEmpleado/mantenimientoCoberturaPoliza/frmCoberturaPolizaLista.aspx");
                }
                else
                {
                    ///Asignar a cada una de las etiquetas los valores obtenidos en la invocación del
                    ///procedimiento almacenado, por medio del método
                    this.ddlTipoPoliza.SelectedValue = datosCoberturaPoliza.idTipoPoliza.ToString();
                    this.txtNombreCobertura.Text = datosCoberturaPoliza.nombre;
                    this.txtDescCobertura.Text = datosCoberturaPoliza.descripcion;
                    this.txtPorcentajeCobertura.Text = Convert.ToString(datosCoberturaPoliza.porcentaje);

                    ///Asignar al hidden field el valor de la llave primaria
                    this.hdidCoberturaPoliza.Value = datosCoberturaPoliza.idCoberturaPoliza.ToString();
                }
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
                BLCoberturaPoliza oCoberturaPoliza = new BLCoberturaPoliza();
                bool resultado = false;
                string mensaje = "";

                ///Creación de una lista el cuál contiene el resultado de datos
                List<pa_RetornaCoberturaPoliza_Result> listaRetornaCoberturaPoliza = oCoberturaPoliza.retornaCoberturaPoliza(null);

                ///Contador para el resultado
                int contadorCobertura = 0;
                try
                {
                    ///Recorrido de la lista que contiene todos los datos de la CoberturaPoliza
                    for (int i = 0; i < listaRetornaCoberturaPoliza.Count; i++)
                    {
                        ///Verificar si el nombre de la cobertura existe o no
                        if (listaRetornaCoberturaPoliza[i].nombre.Equals(this.txtNombreCobertura.Text))
                        {
                            contadorCobertura = 1;
                            ///Generación del mensaje de error
                            mensaje = "Esta cobertura ya se encuentra registrada";
                            ///Mostrar mensaje
                            Response.Write("<script>alert('" + mensaje + "')</script>");
                        }
                        else
                        {
                            ///obtener los valores seleccionados por el usuario
                            ///se toman de la propiedad datavaluefield
                            ///tanto del dropdownlist como del listbox
                            int id_TipoPoliza = Convert.ToInt16(this.ddlTipoPoliza.SelectedValue);
                            //obtener el valor del hidden field 
                            int id_CoberturaPoliza = Convert.ToInt16(this.hdidCoberturaPoliza.Value);
                            ///asignar a la variable el resultado de 
                            ///invocar el procedimiento almacenado
                            resultado = oCoberturaPoliza.modificaCoberturaPoliza(id_CoberturaPoliza, this.txtNombreCobertura.Text,
                                                                                 this.txtDescCobertura.Text, float.Parse(this.txtPorcentajeCobertura.Text),
                                                                                 id_TipoPoliza);
                        }
                    }

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
                        ///Generación del mensaje
                        mensaje += "El registro fue modificado";
                        ////mostrar el mensaje
                        Response.Write("<script>alert('" + mensaje + "')</script>");

                        Response.Redirect("/formularios/mantenimientosEmpleado/mantenimientoCoberturaPoliza/frmCoberturaPolizaLista.aspx");
                    }
                }
                ///mostrar el mensaje
                Response.Write("<script>alert('" + mensaje + "')</script>");
            }
        }
    }
}