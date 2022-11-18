<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MemberLogin.aspx.cs" Inherits="A8._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <h1> Member Login Page</h1>

    <h4> Members must login to continue: 
    </h4>

    <table cellpadding ="8">
        <asp:Label ID="UserNameLbl" runat="server" Text="Username: "></asp:Label>
        <asp:TextBox ID="txtMemberUsername" runat="server"></asp:TextBox>

        <asp:Label ID="PasswordLbl" runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="txtMemberPassword" runat="server"></asp:TextBox>
 
        <asp:Button ID="MemberLoginBtn" runat="server" Text="Login" OnClick="MemberLoginBtn_Click" />

 
        <asp:Label ID="lblMember" runat="server" Text="Label"></asp:Label>
    </table>

    
  

</asp:Content>
