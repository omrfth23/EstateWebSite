<%@ Page Title="" Language="C#" MasterPageFile="~/NonUser.Master" AutoEventWireup="true" CodeBehind="NonUserPropertyDetails.aspx.cs" Inherits="AspWebProject.NonUserPropertyDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form2" runat="server">
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>

                <asp:Label ID="Label1" runat="server"  Text='<%# Eval("propertyTitle") %>'></asp:Label>
                <br />
                <br />
                <asp:Image ID="Image2" runat="server" Height="416px" ImageUrl='<%# Eval("propertyPhotos") %>' Width="994px" />
                <br />
                <br />
               
                <asp:Label ID="Label2" runat="server" Text='<%#  "Tür: " + Eval("propertyType") %>'></asp:Label>
                <br />

                <asp:Label ID="Label3" runat="server" Text='<%# "Şehir: " + Eval("propertyCity") %>'></asp:Label>
                <br />

                <asp:Label ID="Label4" runat="server" Text='<%# "Mahalle: " + Eval("propertyHood") %>'></asp:Label>
                <br />

                <asp:Label ID="Label5" runat="server" Text='<%# "Fiyat: " + Eval("propertyPrice") %>'></asp:Label>
                <br />

                <asp:Label ID="Label6" runat="server" Text='<%# "Oda Sayısı: " + Eval("propertyRoom") %>'></asp:Label>
                <br />
            
            </ItemTemplate>

        </asp:DataList>
    </form>

</asp:Content>
