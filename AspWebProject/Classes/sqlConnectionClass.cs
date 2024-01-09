using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace AspWebProject.Classes
{
    public class sqlConnectionClass
    {
        public static SqlConnection connection = new SqlConnection("Data Source=OMRFTH\\SQLEXPRESS;Initial Catalog=EstateDB;Integrated Security=True");

        public static void checkConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed) {
                
                connection.Open();
            }

            else
            {

            }
        }
    }
}