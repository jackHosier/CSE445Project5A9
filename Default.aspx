<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="A8._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <h1> Welcome to my Web Service Application</h1>

    <h4> What I can do is: 
        Sign up as a new member 
    </h4>
    <asp:Button ID="NewMemberBtn" runat="server" Text="Register New Member" />

    <h4>Already a member? Sign in here: </h4>
    <asp:Button ID="MemberSignInBtn" runat="server" Text="Member Sign-in" OnClick="MemberSignInBtn_Click" />
    <asp:Button ID="StaffSignInBtn" runat="server" Text="Staff Sign-in" OnClick="StaffSignInBtn_Click" />

    <h4>Go to the pages </h4>
     <asp:Button ID="OtherMemberBtn" runat="server" Text="Member Page" OnClick="MemberBtn_Click" />
    <asp:Button ID="StaffBtn" runat="server" Text="Staff Page" OnClick="StaffBtn_Click" />

</asp:Content>
