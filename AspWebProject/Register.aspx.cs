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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tboxMail.Text) || string.IsNullOrEmpty(tboxName.Text) ||
        string.IsNullOrEmpty(tboxSurname.Text) || string.IsNullOrEmpty(tboxPassword.Text))
            {
                // Tüm textbox'lar boş veya null ise uyarı mesajı göster
                Response.Write("<script>alert('Lütfen tüm bilgileri doldurunuz.');</script>"); 
            }
            else
            {
                UserOperations.UserRegister(tboxMail.Text, tboxName.Text, tboxSurname.Text, tboxPassword.Text);
            }

        }

       
    }
}