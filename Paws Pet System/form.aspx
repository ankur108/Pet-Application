<%@ Page Title="Add Information" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="form.aspx.cs" Inherits="Paws_Pet_System.form" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  
    <asp:Label ID="Label1" runat="server" Text="Label"><h1>Welcome to Paws Pet Store</h1></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="Label"><h3>Adopte, Donate, Inspect</h3></asp:Label>
         

    <div style="float:left;">
    <h3 Style="margin-left:80px;font-family:Cooper;">Add New Information</h3>
    <table style="width:100%;">
        <tr>
            <td >&nbsp;<asp:Label  runat="server" Text="Label">First Name</asp:Label></td>
            <td>&nbsp;<asp:TextBox ID="firstname" runat="server"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td>&nbsp;<asp:Label  runat="server" Text="Label">Last Name</asp:Label></td>
            <td>&nbsp;<asp:TextBox ID="lastname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>&nbsp;<asp:Label  runat="server" Text="Label">Telephone Phone</asp:Label></td>
            <td>&nbsp;<asp:TextBox ID="phone" runat="server" type="tel"></asp:TextBox></td>
        </tr>
        <tr>
            <td>&nbsp;<asp:Label  runat="server" Text="Label">Email</asp:Label></td>
            <td>&nbsp;<asp:TextBox ID="emailid" runat="server" type="email"></asp:TextBox></td>
        </tr>
        <tr>
             <td><h4>Pet Information</h4></td>
        </tr>
        <tr>
            <td>&nbsp;<asp:Label  runat="server" Text="Label">Name</asp:Label></td>
            <td>&nbsp;<asp:TextBox ID="petname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>&nbsp;<asp:Label  runat="server" Text="Label">Age</asp:Label></td>
            <td>&nbsp;<asp:TextBox ID="petage" runat="server" type="number"></asp:TextBox></td>
        </tr>
        <tr>
            <td>&nbsp;<asp:Label  runat="server" Text="Label">Gender</asp:Label></td>
            <td>&nbsp;<asp:DropDownList runat="server" ID="petgender" >
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>&nbsp;<asp:Label  runat="server" Text="Label">Weight</asp:Label></td>
            <td>&nbsp;<asp:TextBox ID="petweight" runat="server" type="number"></asp:TextBox></td>
        </tr>
        <tr>
            <td>&nbsp;<asp:Label  runat="server" Text="Label">Date Rescued</asp:Label></td>
            <td>&nbsp;<asp:TextBox ID="petrescued" runat="server" type="date"></asp:TextBox></td>
        </tr>
        <tr>
            <td>&nbsp;<asp:Label  runat="server" Text="Label">Pet Photo</asp:Label></td>
            <td>&nbsp;<asp:FileUpload ID="petphoto" runat="server" /></td>
        </tr>
        <tr>
            <td>&nbsp;<asp:Label  runat="server" Text="Label">Pet Species</asp:Label></td>
            <td>&nbsp;<asp:DropDownList runat="server" ID="petspecies">
                <asp:ListItem>Dog</asp:ListItem>
                <asp:ListItem>Cat</asp:ListItem>
                <asp:ListItem>Frog</asp:ListItem>
                <asp:ListItem>Parrot</asp:ListItem>
                <asp:ListItem>Horse</asp:ListItem>
                <asp:ListItem>Others</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>&nbsp;<asp:Label  runat="server" Text="Label">Pet Breed</asp:Label></td>
            <td>&nbsp;<asp:DropDownList runat="server" ID="petbreed">
                <asp:ListItem>German Shepherd</asp:ListItem>
                <asp:ListItem>Labrador Retriever</asp:ListItem>
                <asp:ListItem>Rotteweiler</asp:ListItem>
                <asp:ListItem>Bulldog</asp:ListItem>
                <asp:ListItem>Great Dane</asp:ListItem>
                <asp:ListItem>Boxer</asp:ListItem>
                <asp:ListItem>Pug</asp:ListItem>
                <asp:ListItem>Doberman Pinscher</asp:ListItem>
                <asp:ListItem>Pitbull</asp:ListItem>
                <asp:ListItem>Others</asp:ListItem>

                <asp:ListItem>British Shorthair</asp:ListItem>
                <asp:ListItem>Persian Cat</asp:ListItem>
                <asp:ListItem>Bengal Cat</asp:ListItem>
                <asp:ListItem>Ragdoll</asp:ListItem>
                <asp:ListItem>Siamese Cat</asp:ListItem>
                <asp:ListItem>American Shorthair</asp:ListItem>
                <asp:ListItem>American Bobtail</asp:ListItem>
                <asp:ListItem>Ocicat</asp:ListItem>
                <asp:ListItem>Cornish Rex</asp:ListItem>
                <asp:ListItem>Others</asp:ListItem>

                <asp:ListItem>Others</asp:ListItem>

                 </asp:DropDownList></td>
        </tr>
        <tr>
            <td>&nbsp;<asp:Label  runat="server" Text="Label">Food Cost</asp:Label></td>
            <td>£&nbsp;<asp:TextBox ID="foodcost" runat="server" type="number" ></asp:TextBox></td>
        </tr>
        <tr>
            <td>&nbsp;<asp:Label  runat="server" Text="Label">Housing Cost</asp:Label></td>
            <td>£&nbsp;<asp:TextBox ID="housingcost" runat="server" type="number"></asp:TextBox></td>
        </tr>
        <tr>
            <td><h4>Vet Bills</h4></td>
        </tr>
        <tr>
            <td>&nbsp;<asp:Label  runat="server" Text="Label">Vaccines</asp:Label></td>
            <td>£&nbsp;<asp:TextBox ID="vaccine" runat="server" type="number" ></asp:TextBox></td>
        </tr>
        <tr>
            <td>&nbsp;<asp:Label  runat="server" Text="Label">Neutering</asp:Label></td>
            <td>£&nbsp;<asp:TextBox ID="neuter" runat="server" type="number"></asp:TextBox></td>
        </tr>
        <tr>
            <td>&nbsp;<asp:Label  runat="server" Text="Label">ID Chipping</asp:Label></td>
            <td>£&nbsp;<asp:TextBox ID="chip" runat="server" type="number"></asp:TextBox></td>
        </tr>
        <tr>
            <td>&nbsp;<asp:Label  runat="server" Text="Label">Flea Spraying </asp:Label></td>
            <td>£&nbsp;<asp:TextBox ID="flea" runat="server" type="number"></asp:TextBox></td>
        </tr>
        <tr>
            <td>&nbsp;<asp:Label  runat="server" Text="Label">Worming Pills</asp:Label></td>
            <td>£&nbsp;<asp:TextBox ID="pills" runat="server" type="number"></asp:TextBox></td>
        </tr>
    </table>
    <asp:Button ID="Submit" runat="server" Text="Submit" style="margin:20px 0px 0px 210px" OnClick="Submit_Click"/>
    <asp:Label ID="Label15" runat="server" style="font-family:Century; Times, serif;color:red;"></asp:Label>
        </div>
    <div style="margin-left:120px;float:left;">
           <div>
                <h2 style="font-family:Cooper;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Adopt a Pet</h2>
               <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="\images\adoptinfo.png" style="width:100%;height:auto;" href="adopt.aspx" PostBackUrl="~/adopt.aspx"/>
           </div>   
        <div>
            <h2 style="font-family:Cooper;">Want to Remove a Pet?</h2>
            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="\images\crying.png" style="width:100%;height:auto;" href="remove.aspx" PostBackUrl="~/remove.aspx"/>
        </div>
    </div>
    <br style="clear:left;" />
</asp:Content>


