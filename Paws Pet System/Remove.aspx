<%@ Page Title="Remove a Pet" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Remove.aspx.cs" Inherits="Paws_Pet_System.Remove" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3 Style="margin-left:80px;font-family:Cooper;">Remove a Pet</h3>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label" Style="margin:10px 20px 20px 300px;font-family:'Berlin Sans FB';font-size:20px;">Enter the CustomerID</asp:Label>
    <asp:TextBox ID="remove" runat="server" Style="margin:10px 20px 20px 0px;" required="true"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Remove" OnClick="button1_Click" />
    
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"/>
</asp:Content>