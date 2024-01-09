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
    public partial class UserSellingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["IsUserOnline"]) != true)
            {
                Response.Redirect("Login.aspx");
            }
            if (Page.IsPostBack == false)
            {
                DropDownListType.Items.Insert(0, "Konut");
                DropDownListType.Items.Insert(0, "Arsa");


                DropDownListCity.DataTextField = "cityName";
                DropDownListCity.DataValueField = "cityID";

                DropDownListCity.DataSource = CityOperations.BindDropDownCity();
                DropDownListCity.DataBind();
                LoadHoods();
            }

        }

        public void LoadRoom()
        {
            DropDownListRoom.Items.Insert(0, "5+1");
            DropDownListRoom.Items.Insert(0, "4+1");
            DropDownListRoom.Items.Insert(0, "3+1");
            DropDownListRoom.Items.Insert(0, "2+1");
            DropDownListRoom.Items.Insert(0, "1+1");
        }

        public void LoadHoods()
        {
            DropDownListHood.DataTextField = "hoodName";
            DropDownListHood.DataValueField = "hoodID";

            DropDownListHood.DataSource = HoodOperations.BindDropDownHood(Convert.ToInt32(DropDownListCity.SelectedValue));
            DropDownListHood.DataBind();
        }

        protected void DropDownListCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHoods();
        }

        protected void DropDownListType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListType.SelectedValue.ToString() == "Konut")
            {
                if (DropDownListRoom.Items.Count > 0)
                {
                    DropDownListRoom.Visible = true;
                }
                else
                {
                    DropDownListRoom.Visible = true;
                    LoadRoom();
                }

            }
            else
            {
                DropDownListRoom.Visible = false;

            }
        }

        protected void btnAddProperty_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tboxPhoto.Text.ToString()))
            {
                Response.Write("Fotoğraf Kısmı Boş Bırakılamaz.");
            }

            else if (String.IsNullOrEmpty(tboxPrice.Text.ToString()))
            {
                Response.Write("Fiyat Kısmı Boş Bırakılamaz.");
            }
            else if (String.IsNullOrEmpty(tboxTitle.Text.ToString()))
            {
                Response.Write("Başlık Kısmı Boş Bırakılamaz.");
            }
            else
            {

                SqlCommand command = new SqlCommand("INSERT INTO PropertyTable (propertyTitle, propertyRoom, propertyPrice, propertyCity, propertyHood, propertyType, propertyPhotos) VALUES (@propertyTitle, @propertyRoom, @propertyPrice, @propertyCity, @propertyHood, @propertyType, @propertyPhotos)", sqlConnectionClass.connection);
                sqlConnectionClass.checkConnection();




                command.Parameters.AddWithValue("@propertyTitle", tboxTitle.Text);
                command.Parameters.AddWithValue("@propertyRoom", DropDownListRoom.SelectedItem.Text);
                command.Parameters.AddWithValue("@propertyPrice", tboxPrice.Text);
                command.Parameters.AddWithValue("@propertyCity", DropDownListCity.SelectedItem.Text);
                command.Parameters.AddWithValue("@propertyHood", DropDownListHood.SelectedItem.Text);
                command.Parameters.AddWithValue("@propertyType", DropDownListType.SelectedItem.Text);
                command.Parameters.AddWithValue("@propertyPhotos", tboxPhoto.Text);


                command.ExecuteNonQuery();



            }



        }
    }
}