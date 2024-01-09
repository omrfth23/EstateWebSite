using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AspWebProject.Classes
{
    public class AboutUsOperations
    {
        public static string listAboutUs()
        {
            SqlCommand commandListAboutUs = new SqlCommand("Select * from AboutUsTable where aboutUsID=@pid", sqlConnectionClass.connection);

            sqlConnectionClass.checkConnection();

            commandListAboutUs.Parameters.AddWithValue("@pid", 1);

            SqlDataReader drListAboutUs = commandListAboutUs.ExecuteReader();

            string myNewText = "";

            while (drListAboutUs.Read())
            {
                myNewText = drListAboutUs[1].ToString();
            }
            drListAboutUs.Close();
            return myNewText;
        }

    }
}