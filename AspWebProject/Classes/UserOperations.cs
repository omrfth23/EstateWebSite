using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AspWebProject.Classes
{
    public class UserOperations
    {
        public static void UserRegister(string temp_mail, string temp_name, string temp_surname, string temp_password)
        {

            SqlCommand commandRegister = new SqlCommand("Insert into UserTable (UserMail,UserName,UserSurname,UserPassword,UserRegisterDate) values(@pmail,@pname,@psurname,@ppass,@pdate) ", sqlConnectionClass.connection);
            sqlConnectionClass.checkConnection();

            commandRegister.Parameters.AddWithValue("@pmail", temp_mail);
            commandRegister.Parameters.AddWithValue("@pname", temp_name);
            commandRegister.Parameters.AddWithValue("@psurname", temp_surname);
            commandRegister.Parameters.AddWithValue("@ppass", sha256Converter.ComputeSha256Hash(temp_password));
            commandRegister.Parameters.AddWithValue("@pdate", DateTime.Now);

            commandRegister.ExecuteNonQuery();

        }

        public static DataTable UserLogin(String mail, string password)
        {
            SqlCommand commandLogin = new SqlCommand("Select * from UserTable where userMail=@pmail and UserPassword=@ppass",sqlConnectionClass.connection);
            sqlConnectionClass.checkConnection();

            commandLogin.Parameters.AddWithValue("@pmail", mail);
            commandLogin.Parameters.AddWithValue("@ppass", sha256Converter.ComputeSha256Hash(password));

            SqlDataAdapter adapter = new SqlDataAdapter(commandLogin);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}