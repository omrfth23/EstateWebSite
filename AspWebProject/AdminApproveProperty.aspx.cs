﻿using AspWebProject.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspWebProject
{
    public partial class AdminApproveProperty : System.Web.UI.Page
    {
        public SqlDataReader drProp;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["IsAdmin"]) != true)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                drProp = AdminOperations.AdminGetAllPropUnApproved();
                DataList1.DataSource = drProp;
                DataList1.DataBind();
                AdminOperations.drGetAllPropUnApproved.Close();
            }
        }
    }
}