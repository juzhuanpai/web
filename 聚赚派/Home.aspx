<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Home.aspx.cs" Inherits="聚赚派.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 240px; line-height: 240px; text-align: center">
        图片
        <asp:TextBox ID="TextBox1" runat="server">
        </asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
    </div>
    <div style="float: left; width: 240px; height: 360px">
        <div style="height: 120px">
        </div>
        <div style="height:240px"></div>
    </div>
    <div style="float: right; width: 720px; height: 360px">
    </div>
</asp:Content>
