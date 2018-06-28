<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Paws_Pet_System._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="\Content\default.css" rel="stylesheet" type="text/css" />


    <div>
        <h1 class="fronttxt">Welcome to Paws Pet Store</h1>
        <h3 class="fronttxt destxt">From Paws To Tail</h3>
        <h3 class="fronttxt downtxt">UK's No.1 Pet Store</h3>
        <asp:Image ID="Image1" runat="server" ImageUrl="\images\girl.jpg" style="width:100%;height:auto;float:left;"/>
    </div>
    <br />
    <br />
    <div style="width:100%;float:left;">
    <h3 class="what"style="color:deepskyblue;">What we Do</h3>
        <br />
        <asp:Image ID="Image2" runat="server" ImageUrl="\images\adopt.png" style="height:auto;float:left;margin:10px 260px 20px 290px;" class="image1"/>
        <asp:Image ID="Image3" runat="server" ImageUrl="\images\donate.png"  style="height:auto;float:left;" class="image2"/>
        </div>
    <br style="clear:left;" />
    
</asp:Content>
