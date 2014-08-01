<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="About.aspx.cs" Inherits="聚赚派.About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="about" style="color: Red;">
        <a style="padding-left: 20px">关于我们</a>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Image ID="Image1" runat="server" />
    </div>
</asp:Content>
