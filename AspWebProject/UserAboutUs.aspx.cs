using AspWebProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspWebProject
{
    public partial class UserAboutUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["IsUserOnline"])!= true)
            {
                Response.Redirect("Login.aspx");
            }

            else
            {
                var new_text = AboutUsOperations.listAboutUs();
                aboutus.InnerText = new_text.ToString();

            }

        }
    }
}