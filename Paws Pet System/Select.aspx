<%@ Page Title="Select" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Select.aspx.cs" Inherits="Paws_Pet_System.Select" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
 
   <div style="float:left;margin-right:60px;margin-left:120px">
    <asp:ImageButton ID="Germany" runat="server" ImageUrl="\images\Germany-Flag.png" style="width:100%;height:auto;" OnClick="Germany_Click"/>
       <br />
       <asp:Label ID="Label1" runat="server" Text="Label" style="font-size:20px;margin:40px 0px 10px 90px;color:lightskyblue;">Germany</asp:Label>
   </div> 
    <div style="float:left;margin-right:30px;margin-top:25px;">
    <asp:ImageButton ID="UK" runat="server" ImageUrl="\images\UK-Flag.png" style="width:100%;height:auto;" OnClick="UK_Click"/>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label" style="font-size:20px;margin:50px 0px 70px 90px;color:lightskyblue;">United Kingdom</asp:Label>
    </div>
    <div style="float:left;margin-top:20px;">
    <asp:ImageButton ID="Romania" runat="server" ImageUrl="\images\Romania-Flag.png" style="width:85%;height:auto;" OnClick="Romania_Click"/>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label" style="font-size:20px;margin:40px 0px 40px 90px;color:lightskyblue;">Romania</asp:Label>
    </div>
    

    <br style="clear:left;" />
    </asp:Content>
