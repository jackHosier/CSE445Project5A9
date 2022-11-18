<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MemberReg.aspx.cs" Inherits="A8._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <h1> New Member Registration</h1>

  <h4>Make a new account here, so you can explore what services I have to offer (wink wink nudge nudge)</h4>

    <asp:Label ID="newUserNameLbl" runat="server" Text="Username: "></asp:Label>
    <asp:TextBox ID="newUserNameBox" runat="server"></asp:TextBox>

    <br /><br />

    <asp:Label ID="newPasswordLbl" runat="server" Text="Password: "></asp:Label>
    <asp:TextBox ID="newPasswordBox" runat="server"></asp:TextBox>

    <br />
    <br />

    <h4>Before you can make your account, we need to make sure you are not a robot</h4>



    <asp:Button ID="RegisterUserBtn" runat="server" Text="Register New User" OnClick="RegisterUserBtn_Click"/>

    <br />
    <asp:Label ID="StatusLbl" runat="server" Text="______"></asp:Label>

</asp:Content>
