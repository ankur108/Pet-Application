<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Paws_Pet_System.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/custom.css" rel="stylesheet" type="text/css" /> 
    <div class="login">
        <asp:Label ID="Label1" runat="server" Text="Label"><h4>User Login</h4></asp:Label>
        <asp:Label ID="Text1" runat="server" Text="Label"><h5>Username</h5></asp:Label>
        <asp:TextBox ID="user" runat="server"></asp:TextBox><br /> 
        <asp:Label ID="Text3" runat="server" Text="Label"><h5>Password</h5></asp:Label>
        <asp:TextBox ID="pass" runat="server" type="password" ></asp:TextBox><br /> 
        <asp:Label ID="Label2" runat="server" style="font-family:Century; Times, serif;color:red;"></asp:Label><br />
        <asp:Button ID="Logins" runat="server" Text="Login" onClick="Logins_Click"/>
        
    </div>
    
    <div class="or">
     <p>OR</p>
    </div>

    <div class="newlogin">
    <asp:Label ID="Label4" runat="server" Text="Label"><h4>Sign Up Free</h4></asp:Label>
        <asp:Label ID="Label5" runat="server" Text="Label"><h5>Username</h5></asp:Label>
        <asp:TextBox ID="newuser" runat="server" ></asp:TextBox><br />
        <asp:Label ID="Label6" runat="server" Text="Label" ><h5>Password</h5></asp:Label>
        <asp:TextBox ID="newpass" runat="server" type="password" ></asp:TextBox><br />
        <asp:Label ID="Label7" runat="server" Text="Label" ><h5>Confirm Password</h5></asp:Label>
        <asp:TextBox ID="confpass" runat="server"  type="password"></asp:TextBox><br />
        <asp:Label ID="Label8" runat="server" Text="Label"><h5>Email</h5></asp:Label>
        <asp:TextBox ID="email" runat="server" ></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" style="font-family:Century; Times, serif;color:red;"></asp:Label><br />
        <asp:Button ID="Create" runat="server" Text="Create My Account" onClick="Create_Click" />
    </div>
    <asp:Label runat="server" Text="Label"><h3>Guest Login</h3></asp:Label>
   <asp:Button ID="Button1" runat="server" PostBackUrl="~/Select.aspx" Text="Continue As Guest" />
    </asp:Content>
