<%@ Page Title="" Language="C#" MasterPageFile="~/NonUser.Master" AutoEventWireup="true" CodeBehind="NonUserSellingPage.aspx.cs" Inherits="AspWebProject.NonUserSellingPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
    h1 {
        font-family: Arial, sans-serif;
        font-size: 24px;
        color: #333;
        margin-bottom: 20px;
        text-align: center;
    }

    .btn {
        display: inline-block;
        padding: 10px 20px;
        font-family: Arial, sans-serif;
        font-size: 16px;
        color: #fff;
        background-color: #4287f5;
        border: none;
        border-radius: 4px;
        text-decoration: none;
        margin-right: 10px;
        transition: background-color 0.5s ease;
        
    }
    .btn-container{
        text-align: center;
    }

    .btn:hover {
        background-color: #84b9ff;
    }
</style>
<div class="btn-container">
    <h1>İlan Yerleştirmek İçin Lütfen Giriş Yapın Ya Da Kayıt Olun</h1>
    <a href="Login.aspx" class ="btn btn-danger ">Giriş Sayfasına Git </a>
    <a href ="Register.aspx" class ="btn btn-danger ">Kayıt Ol Sayfasına Git </a>
</div>
    
</asp:Content>
