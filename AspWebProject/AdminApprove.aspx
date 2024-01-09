<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="AdminApprove.aspx.cs" Inherits="AspWebProject.AdminApprove" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <a href="NonUserPropertyDetails.aspx?selectedid=<%# Eval("propertyID") %>" style="text-decoration: none">
                <div class="item-container">
                    <asp:Image ID="Image2" runat="server" ImageUrl='<%# Eval("propertyPhotos") %>' CssClass="item-image" />
                    <h2 class="item-title"><%# Eval("propertyTitle") %></h2>
                    <h2 class="item-price"><%# string.Format("{0:N}", Eval("propertyPrice")) %> TL</h2>
                </div>
            </a>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
