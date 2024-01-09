using AspWebProject.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspWebProject
{
    public partial class UserPropertyPage : System.Web.UI.Page
    {
        public SqlDataReader drProp;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["IsUserOnline"]) != true)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                drProp = PropertyOperations.getAllProp();
                DataList1.DataSource = drProp;
                DataList1.DataBind();
                PropertyOperations.drGetAllProp.Close();
            }
        }
    }
}