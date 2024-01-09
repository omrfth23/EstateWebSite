using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace AspWebProject.Classes
{
    public class HoodOperations
    {

        public static DataTable BindDropDownHood(int id)
        {
            SqlCommand commandBindDropDownHood = new SqlCommand("Select * from HoodTable where hoodCityID=@pid", sqlConnectionClass.connection);
            sqlConnectionClass.checkConnection();

            commandBindDropDownHood.Parameters.AddWithValue("@pid", id);

            SqlDataAdapter da = new SqlDataAdapter(commandBindDropDownHood);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}