using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AspWebProject.Classes
{
    public class AdminOperations
    {
        public static void AdminDeleteProperty(int id)
        {
            SqlCommand commandAdminDeleteProperty = new SqlCommand("Delete from PropertyTable where propertyID=@pid",sqlConnectionClass.connection);
            sqlConnectionClass.checkConnection();
            commandAdminDeleteProperty.Parameters.AddWithValue("@pid", id);
            commandAdminDeleteProperty.ExecuteNonQuery();
        }
        public static SqlDataReader drGetAllPropUnApproved;

        public static SqlDataReader AdminGetAllPropUnApproved()
        {
            SqlCommand commandLoadProperties = new SqlCommand("Select * from PropertyTable where propertyApprove=@p1", sqlConnectionClass.connection);
            sqlConnectionClass.checkConnection();
            commandLoadProperties.Parameters.AddWithValue("@p1", 0);
            drGetAllPropUnApproved = commandLoadProperties.ExecuteReader();

            return drGetAllPropUnApproved;
        }

        public static void AdminApprove(int id)
        {
            SqlCommand commandApprove = new SqlCommand("Update PropertyTable set propertyApprove=@p1 where propertyID=@pid", sqlConnectionClass.connection);
            sqlConnectionClass.checkConnection();
            commandApprove.Parameters.AddWithValue("@p1", 1);
            commandApprove.Parameters.AddWithValue("@pid", id);
            commandApprove.ExecuteNonQuery();
        }
    }
}