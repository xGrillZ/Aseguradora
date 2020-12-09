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

            /*string dataUser = this.Session["idusuario"].ToString();*/

            /*if (String.IsNullOrEmpty(dataUser))
            {
                this.lblDatosUsuario.Text = "Bienvenido(a): " + dataUser;
            }*/
            this.cargaDatosUsuario();

        }

        void cargaDatosUsuario()
        {
            int dataUser = int.Parse(Session["idusuario"].ToString());

            blUsuario oUsuario = new blUsuario();
            BLCliente oCliente = new BLCliente();
            BLEmpleado oEmpleado = new BLEmpleado();

            pa_RetornaUsuarioID_Result retornaUsuarioID = new pa_RetornaUsuarioID_Result();

            pa_RetornaUsuarioClienteID_Result retornaClienteID = new pa_RetornaUsuarioClienteID_Result();
            pa_RetornaUsuarioEmpleadoID_Result retornaEmpleadoID = new pa_RetornaUsuarioEmpleadoID_Result();

            retornaEmpleadoID = oEmpleado.retornaUsuarioEmpleadoID(dataUser);
            retornaClienteID = oCliente.retornaUsuarioClienteID(dataUser);

            /*if (Convert.ToInt16(this.Session["tipousuario"]) == 2)
            {
                lblDatosUsuario.Text = $"Bienvenido: {retornaEmpleadoID.nomEmpleado} {retornaEmpleadoID.ape1Empleado} {retornaEmpleadoID.ape2Empleado}";
            }
            else
            {
                lblDatosUsuario.Text = $"Bienvenido: {retornaClienteID.nomCliente} {retornaClienteID.ape1Cliente} {retornaClienteID.ape2Cliente}";
            }*/


            if (retornaClienteID != null || retornaEmpleadoID != null)
            {
                try
                {
                    if (Convert.ToInt16(this.Session["tipousuario"]) == 2)
                    {
                        lblDatosUsuario.Text = $"Bienvenido: {retornaEmpleadoID.nomEmpleado} {retornaEmpleadoID.ape1Empleado} {retornaEmpleadoID.ape2Empleado}";
                    }
                    else
                    {
                        lblDatosUsuario.Text = $"Bienvenido: {retornaClienteID.nomCliente} {retornaClienteID.ape1Cliente} {retornaClienteID.ape2Cliente}";
                    }
                }
                catch (Exception capturaExcepcion)
                {
                    Response.Write("<script>alert('"+capturaExcepcion+"')</script>");
                }
                finally
                {

                }
            }
            else
            {
                lblDatosUsuario.Text = "PRUEBA";
            }

            /*lblDatosUsuario.Text = $"Bienvenido: {retornaUsuarioID.nomEmpleado} {retornaUsuarioID.ape1Empleado} {retornaUsuarioID.ape2Empleado}";*/
        }
    }
}