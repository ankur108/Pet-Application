<%@ Page Title="Adopt" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="adopt.aspx.cs" Inherits="Paws_Pet_System.adopt" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3 Style="margin-left:80px;font-family:Cooper;">All Pets Available to Adopt</h3>
    <br />
    <h3 style="margin:10px 20px 20px 350px;float:left;">View By</h3>
   
    <asp:RadioButtonList ID="filter" runat="server" Style="margin-bottom:20px;margin-top:10px;" >
        <asp:ListItem >Breed</asp:ListItem>
        <asp:ListItem>Species</asp:ListItem>
        <asp:ListItem>Sanctuary</asp:ListItem>
    </asp:RadioButtonList>
    
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="button1_Click" Style="margin-left:500px;margin-bottom:20px;"/>
    <br />
    <asp:Label ID="Label1" runat="server" style="font-family:'Adobe Devanagari';font-size:20px;margin-left:380px;margin-bottom:20px"></asp:Label>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"/>
    </asp:Content>
