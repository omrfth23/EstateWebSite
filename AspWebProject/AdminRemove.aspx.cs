using AspWebProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspWebProject
{
    public partial class AdminRemove : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["IsAdmin"]) != true)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                DataList1.DataSource = PropertyOperations.getAllProp();
                DataList1.DataBind();
                PropertyOperations.drGetAllProp.Close();
            }
        }
    }
}