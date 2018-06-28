<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Aboutus.aspx.cs" Inherits="Paws_Pet_System.Aboutus" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >
  <link href="Content/custom.css" rel="stylesheet" type="text/css" /> 
    

    
    <asp:Label ID="Label1" runat="server" Text="Label" Style="font-size:30px;font-family:'Cooper Std';margin:20px 0px 10px 480px;color:orangered">About Us</asp:Label>
    <br />
    <br />
    <asp:Image ID="Image1" runat="server" ImageUrl="\images\about1.png" style="width:10%;height:auto;margin-left:20px;float:left;"/>
        <asp:Image ID="Image2" runat="server" ImageUrl="\images\about.jpg" style="width:70%;height:auto;margin-left:100px;"/>
        <br />
        <br />
    <asp:Label ID="Label2" runat="server" Text="Label" Style="font-size:20px;font-family:'Gill Sans MT';margin:10px 0px 10px 0px;color:deepskyblue;text-align:right;width:100px;height:auto;">
    Paws Pet Store is  a retail business which sells different kinds of animals to the public. Friends with paws” Welfare Trust is an animal rehoming charity with their main
    site based on the outskirts of London in the UK. For the moment the organization is
    managing pets’ sanctuaries in 3 countries UK, Romania and Germany.
    As well as the young and healthy, their countryside sanctuaries always have a
    collection of much loved resident pets that are unlikely to be adopted, such as the
    elderly and long-term sick. Sanctuary animals include dogs, cats, rabbits, hamsters
    etc. as well as a few hand reared sheep, goats and a potbellied pig.
    “Friends with paws” is a large and vital safety net for vulnerable animals. Running
    costs are high as many of their pets need veterinary attention and may be with the
    charity for weeks as they recover. </asp:Label>
   
    </asp:Content>
