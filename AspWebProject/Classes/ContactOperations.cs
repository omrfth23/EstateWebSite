using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AspWebProject.Classes
{
    public class ContactOperations
    {
        public static List<String> GetContactInfo()
        {
            SqlCommand commandGetContactInfo = new SqlCommand("Select * from ContactTable where contactID=@p1",sqlConnectionClass.connection);

            sqlConnectionClass.checkConnection();
            commandGetContactInfo.Parameters.AddWithValue("@p1", 1);

            SqlDataReader drGetContactInfo = commandGetContactInfo.ExecuteReader();

            string c_mail = "";
            string c_phone = "";
            string c_adress = "";
            List<String> myList = new List<String>();
            while (drGetContactInfo.Read())
            {
                c_mail = drGetContactInfo[1].ToString();
                c_phone = drGetContactInfo[2].ToString();
                c_adress = drGetContactInfo[3].ToString();
                myList.Add(c_mail);
                myList.Add(c_phone);
                myList.Add(c_adress);
            }
            drGetContactInfo.Close();
            return myList;
        }
        
    }
}