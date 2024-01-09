<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserContact.aspx.cs" Inherits="AspWebProject.UserContact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .contact-header {
            font-size: 24px;
            color: #333;
            text-decoration: underline;
            margin-bottom: 10px;
        }

        .contact-info {
            font-size: 18px;
            color: #555;
            margin-bottom: 10px;
        }
    </style>

    <h2 class="contact-header">Bizimle İletişim Kurun</h2>
    <br />
    <h3 runat="server" id="contactmail" class="contact-info"></h3>
    <br />
    <h3 runat="server" id="contactphone" class="contact-info"></h3>
    <br />
    <h3 runat="server" id="contactadress" class="contact-info"></h3>
</asp:Content>

