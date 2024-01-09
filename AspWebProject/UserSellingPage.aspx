<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserSellingPage.aspx.cs" Inherits="AspWebProject.UserSellingPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" method="post">
        <h2 style="text-align: center; font-size: 24px; margin-bottom: 20px;">Kullanıcı Satış Sayfası</h2>
        <div style="display: flex; flex-direction: column; align-items: center;">
            <p style="margin-bottom: 30px;">
                <asp:TextBox ID="tboxTitle" placeholder="Başlık Giriniz" runat="server" Style="width: 376px; padding: 10px; border: 1px solid #ccc; border-radius: 4px;"></asp:TextBox>
            </p>
            <p style="margin-bottom: 30px;">
                <asp:TextBox ID="tboxPrice" placeholder="Fiyat Giriniz" runat="server" Style="width: 376px; padding: 10px; border: 1px solid #ccc; border-radius: 4px;"></asp:TextBox>
            </p>
            <p style="margin-bottom: 30px;">
                <asp:DropDownList ID="DropDownListCity" OnSelectedIndexChanged="DropDownListCity_SelectedIndexChanged" runat="server" Height="33" Width="376px"></asp:DropDownList>
            </p>
            <p style="margin-bottom: 30px;">
                <asp:DropDownList ID="DropDownListHood" runat="server" Height="33" Width="376px"></asp:DropDownList>
            </p> 
            <p style="margin-bottom: 30px;">
                <asp:DropDownList ID="DropDownListType" AutoPostBack="true" OnSelectedIndexChanged="DropDownListType_SelectedIndexChanged"  runat="server"  Height="33" Width="376px"></asp:DropDownList>
            </p>
            <p style="margin-bottom: 30px;">
                <asp:DropDownList ID="DropDownListRoom" runat="server" Height="33" Width="376px" ></asp:DropDownList>
            </p>
            <p style="margin-bottom: 30px;">
                <asp:TextBox ID="tboxPhoto" placeholder="Fotoğraf Linki Giriniz" runat="server" Width="376px" Style="padding: 10px; border: 1px solid #ccc; border-radius: 4px;"></asp:TextBox>
            </p>
            <asp:Button ID="btnAddProperty" CssClass="btn btn-info" OnClick="btnAddProperty_Click" runat="server" Text="İlan Ekle" />
        </div>
    </form>
</asp:Content>
