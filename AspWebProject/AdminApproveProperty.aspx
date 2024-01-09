<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="AdminApproveProperty.aspx.cs" Inherits="AspWebProject.AdminApproveProperty" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .item-container {
            width: 1100px;
            min-height: 150px;
            margin: 10px;
            padding: 20px;
            border: 1px solid #808080;
            display: flex;
            flex-direction: row;
            justify-content: space-between;
            text-decoration: none;
            color: #333;
        }

        .item-container:hover {
            background-color: #f5f5f5;
        }

        .item-image {
            width: 260px;
            height: 130px;
        }

        .item-title {
            font-size: 20px;
            margin-bottom: 5px;
        }

        .item-price {
  
            font-size: 20px;
            font-weight: bold;
        }
    </style>

    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <a href="AdminApprove.aspx?selectedid=<%# Eval("propertyID") %>"  style="text-decoration: none">
                <div class="item-container">
                    <asp:Image ID="Image2" runat="server" ImageUrl='<%# Eval("propertyPhotos") %>' CssClass="item-image" />
                    <h2 class="item-title"><%# Eval("propertyTitle") %></h2>
                    <h2 class="item-price"><%# string.Format("{0:N}", Eval("propertyPrice")) %> TL</h2>
                </div>
            </a>
            <a href="AdminApprove.aspx?selectedid=<%# Eval("propertyID") %>" class="btn btn-info">Onayla</a>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
