using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FerreWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
             //datos estaticos 
            string user = txtUsuario.Text;
            string password = txtPassword.Text;
            string userName = "user";
            string passName = "user";
            if (user.Equals(userName) && password.Equals(passName))
            {
                Response.Write("<script>alert('Usuario Correcto')</script>");
                Response.Redirect("PanelGeneral.aspx");
            }
            else
            {
                Response.Write("<script>alert('Usuario Incorrecto')</script>");
            }

        }
    }
}