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
            /*this.cargaDatosUsuario();*/

        }

        void cargaDatosUsuario()
        {
            /*int dataUser = Convert.ToInt16(this.Session["idusuario"]);*/

            /*if (!String.IsNullOrEmpty(dataUser))
            {
                Response.Write("<script>alert('Parametro nulo')</script>");
            }
            else
            {
                int id_Usuario = Convert.ToInt16(dataUser);
                blUsuario oUsuario = new blUsuario();

                pa_RetornaUsuarioID_Result datosUsuario = new pa_RetornaUsuarioID_Result();

                datosUsuario = oUsuario.retornaUsuarioID(id_Usuario);

                if (datosUsuario == null)
                {
                    Response.Write("<script>alert('DATO NULO')</script>");
                }
                else
                {
                    this.lblDatosUsuario.Text = datosUsuario.nomEmpleado;
                }
                
            }*/
        }
    }
}