using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoCoberturaPoliza
{
    public partial class frmCoberturaPolizaElimina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ///Carga de los datos a mostrar en pantalla
                this.cargaListaTipoPoliza();
                this.cargaDatosRegistro();
            }
        }

        protected void btAceptar_Click(object sender, EventArgs e)
        {
            this.AlmacenarDatos();   
        }

        void cargaListaTipoPoliza()
        {
            ///Creación de la instancia a la clase BLTipoPoliza
            BLTipoPoliza oTipoPoliza = new BLTipoPoliza();
            ///indicarle al dropdownlist la fuente de datos
            this.ddl_TipoPoliza.DataSource = oTipoPoliza.retornaTipoPoliza();
            ///indicarle al dropdownlist que se muestre
            this.ddl_TipoPoliza.DataBind();
        }

        void cargaDatosRegistro()
        {
            ///obtener el parámetro envíado desde el grid
            ///es CASESENSITIVE
            string parametro =
                this.Request.QueryString["idCoberturaPoliza"];

            //validar si el parametro es correcto
            if (String.IsNullOrEmpty(parametro))
            {
                ///Generación mensaje
                string mensaje = "El parámetro es nulo";
                ///mostrar el mensaje
                Response.Write("<script>alert('" + mensaje + "')</script>");
            }
            else
            {
                ///Creación de variable el cuál almacenará el idCoberturaPoliza enviada por la variable parametro
                int id_CoberturaPoliza = Convert.ToInt16(parametro);

                ///Creación de la instancia a la clase BLCoberturaPoliza
                BLCoberturaPoliza oCoberturaPoliza = new BLCoberturaPoliza();

                ///Creación de la variable el cual obtendrá los datos del procedimiento almacenado
                pa_RetornaCoberturaPolizaID_Result datosCoberturaPoliza = new pa_RetornaCoberturaPolizaID_Result();

                ///Invocar el procedimiento almacenado por medio del método
                datosCoberturaPoliza = oCoberturaPoliza.retornaCoberturaPolizaID(id_CoberturaPoliza);

                ///Verificar que el objeto retornado no sea nulo
                if (datosCoberturaPoliza == null)
                {
                    ///Redireccionamiento a la página principal si los datos son nulos
                    Response.Redirect("/formularios/mantenimientosEmpleado/mantenimientoCoberturaPoliza/frmCoberturaPolizaLista.aspx");
                }
                else
                {
                    ///Asginación de cada una de las etiquetas sus valores respectivos en la invocacion del procedimiento almacenado
                    this.ddl_TipoPoliza.SelectedValue = datosCoberturaPoliza.idTipoPoliza.ToString();
                    this.txtNombreCobertura.Text = datosCoberturaPoliza.nombre;
                    this.txtDescCobertura.Text = datosCoberturaPoliza.descripcion;
                    this.txtPorcentajeCobertura.Text = Convert.ToString(datosCoberturaPoliza.porcentaje);

                    ///Asignar al hidden field el valor de llave primaria
                    this.hdIdCoberturaPoliza.Value = datosCoberturaPoliza.idCoberturaPoliza.ToString();
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
                ///Creación de la instancia de la clase BLCoberturaPoliza
                BLCoberturaPoliza oCoberturaPoliza = new BLCoberturaPoliza();

                ///Creación de la variable el cuál verificará el resultado de la acción
                bool resultado = false;

                ///Creación de la variable el cuál almacenará el mensaje a mostrar
                string mensaje = "";
                try
                {
                    ///Obtener el ID del registro a Eliminar
                    int id_CoberturaPoliza = Convert.ToInt16(this.hdIdCoberturaPoliza.Value);

                    ///Asignar a la variable el resultado de la invocacion del procedimiento almacenado
                    resultado = oCoberturaPoliza.eliminaCoberturaPoliza(id_CoberturaPoliza);
                }
                ///catch: se ejecuta en el caso de que haya una excepcion
                ///excepcionCapturada: posee los datos de la excepción
                catch (Exception excepcionCapturada)
                {
                    ///Generación mensaje
                    mensaje += $"Ocurrió un error: {excepcionCapturada.Message}";
                    ///Mostrar mensaje
                    Response.Write("<script>alert('" + mensaje + "')</script>");
                }
                ///finally: siempre se ejecuta (se atrape o no la excepción)
                finally
                {
                    ///si el resultado de la variable es verdadera implica que
                    ///el procedimiento no retornó errores
                    if (resultado)
                    {
                        ///Generación mensaje
                        mensaje += "El registro fue eliminado";
                        ///Mostrar mensaje
                        Response.Write("<script>alert('" + mensaje + "')</script>");
                    }
                }
            }
        }
    }
}