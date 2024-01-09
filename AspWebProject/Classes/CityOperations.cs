using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AspWebProject.Classes
{
    public class CityOperations
    {
        public static DataTable BindDropDownCity()
        {
            SqlCommand commandBindDropDownCity = new SqlCommand("Select * from CityTable", sqlConnectionClass.connection);
            sqlConnectionClass.checkConnection();

            SqlDataAdapter da = new SqlDataAdapter(commandBindDropDownCity);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}