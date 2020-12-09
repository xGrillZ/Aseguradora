using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AseguradoraFinal.BL;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.formularios
{
    public partial class frmPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.cargaDatosUsuario();
        }

        /// <summary>
        /// Método para cargar los datos del Usuario por medio del IDUsuario
        /// obteniendo resultado por medio del procedimiento almacenado
        /// </summary>
        void cargaDatosUsuario()
        {
            ///Variable que almacena el IDUsuario a la hora de iniciar sesión
            int dataUser = int.Parse(Session["idusuario"].ToString());

            ///Creación de instancias para las clases necesarias
            blUsuario oUsuario = new blUsuario();
            BLCliente oCliente = new BLCliente();
            BLEmpleado oEmpleado = new BLEmpleado();

            pa_RetornaUsuarioID_Result retornaUsuarioID = new pa_RetornaUsuarioID_Result();

            ///Creación de la variable el cual retornará los datos del procedimiento almacenado
            pa_RetornaUsuarioClienteID_Result retornaClienteID = new pa_RetornaUsuarioClienteID_Result();
            pa_RetornaUsuarioEmpleadoID_Result retornaEmpleadoID = new pa_RetornaUsuarioEmpleadoID_Result();

            ///Variable que obtiene la información del procedimiento almacenado
            retornaEmpleadoID = oEmpleado.retornaUsuarioEmpleadoID(dataUser);
            retornaClienteID = oCliente.retornaUsuarioClienteID(dataUser);

            ///Variable para almacenar el mensaje a mostrar
            string mensaje = "";

            ///Verificación de la variable cargada con datos si tiene datos nulos o no
            if (retornaClienteID != null || retornaEmpleadoID != null)
            {

                ///Manejo de excepciones
                try
                {
                    ///Verificador de tipos de usuarios, el cual enviará el dato según el rol
                    if (Convert.ToInt16(this.Session["tipousuario"]) == 2)
                    {
                        lblDatosUsuario.Text = $"Bienvenido: {retornaEmpleadoID.nomEmpleado} {retornaEmpleadoID.ape1Empleado} {retornaEmpleadoID.ape2Empleado}";
                        lblDatosUsuarioLog.Text = $"Su última conexión fué: {retornaEmpleadoID.ultimoIngreso}";
                    }
                    else
                    {
                        lblDatosUsuario.Text = $"Bienvenido: {retornaClienteID.nomCliente} {retornaClienteID.ape1Cliente} {retornaClienteID.ape2Cliente}";
                        lblDatosUsuarioLog.Text = $"Su última conexión fué: {retornaClienteID.ultimoIngreso}";
                    }
                }
                catch (Exception capturaExcepcion)
                {
                    mensaje += $"Ocurrió un error: {capturaExcepcion}";
                    ///Mensaje de excepcion
                    Response.Write("<script>alert('"+mensaje+"')</script>");
                }
                finally
                {

                }
            }
            else
            {
                mensaje += "Los datos que se necesitan son nulos";
                ///Mensaje de error si cumple lo contrario del verificado de datos nulos
                Response.Write("<script>alert('"+mensaje+"')</script>");
            }

            /*lblDatosUsuario.Text = $"Bienvenido: {retornaUsuarioID.nomEmpleado} {retornaUsuarioID.ape1Empleado} {retornaUsuarioID.ape2Empleado}";*/
        }
    }
}