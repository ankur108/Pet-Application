<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contactus.aspx.cs" Inherits="Paws_Pet_System.Contactus" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  <link href="Content/custom.css" rel="stylesheet" type="text/css" /> 
   <asp:Image ID="Image2" runat="server" ImageUrl="\images\contactus.png" style="width:100%;height:auto;float:left;"/>
    
    <asp:Label ID="Label1" runat="server" Text="Label" Style="font-size:30px;margin:20px 0px 10px 400px;color:darkorange;">We Would Love to help!</asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Label" Style="font-size:20px;margin:30px 0px 10px 250px;color:lightskyblue;">We like to create things with fun and open minded people.Feel free to say hello!</asp:Label>
    <br /><br /><br />
    <div style="float:left;">
    
    <asp:Label ID="Label3" runat="server" Text="Label" Style="font-size:20px;margin:30px 0px 10px 50px;">Name</asp:Label>
    <asp:TextBox ID="name" runat="server"></asp:TextBox><br /><br />
    <asp:Label ID="Label4" runat="server" Text="Label" Style="font-size:20px;margin:30px 0px 10px 50px;">Email</asp:Label>
    <asp:TextBox ID="email" runat="server"></asp:TextBox><br /><br />
    <asp:Label ID="Label5" runat="server" Text="Label" Style="font-size:20px;margin:30px 0px 10px 5px;">Comments</asp:Label>
    <asp:TextBox ID="comment" runat="server" Height="50px" TextMode="MultiLine" Width="500px"></asp:TextBox>
        <br />
        <br />
        <br />
    <asp:Button ID="Contact" runat="server" Text="Submit" Style="margin-left:200px;" OnClick="Contact_Click" />
        <br />
        <asp:Label ID="Label10" runat="server" style="font-family:Century; Times, serif;color:red;"></asp:Label>
        </div>
    <div style="float:left;margin-left:15px;">
        <asp:Image ID="Image1" runat="server" ImageUrl="\images\loc.png" style="width:5%;height:auto;float:left;"/>
        <asp:Label ID="Label6" runat="server" Text="Label" style="margin-left:60px;font-family:'Cooper Std';color:tomato;font-size:20px;">Paws Pet Store</asp:Label><br />
        <asp:Label ID="Label7" runat="server" Text="Label" style="margin-left:60px;font-family:'Cooper Std';color:tomato;font-size:15px;">United Kingdom</asp:Label>
        <br />
        <br />
        <asp:Image ID="Image3" runat="server" ImageUrl="\images\phone.png" style="width:5%;height:auto;float:left;"/>
        <asp:Label ID="Label8" runat="server" Text="Label" style="margin-left:60px;font-family:'Cooper Std';color:tomato;font-size:15px;">(+44) 52048621482</asp:Label><br /><br />
        <asp:Image ID="Image4" runat="server" ImageUrl="\images\mail.png" style="width:5%;height:auto;float:left;"/>
        <asp:Label ID="Label9" runat="server" Text="Label" style="margin-left:60px;font-family:'Cooper Std';color:tomato;font-size:15px;">pawssystem@yahoo.uk</asp:Label>
    </div>
    <br style="clear:left;" />
    </asp:Content>
