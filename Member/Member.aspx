<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="A8._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <h1> Member Page</h1>

    <h3>Services we provide: </h3>

    <h3>JSON Data Conversion</h3>
    <h5>This service takes a textfile and returns a JSON Datastream of all the unique words and the number of their occurences in the file</h5>
    <asp:TextBox ID="WordCountBox" runat="server"></asp:TextBox><asp:Button ID="WordCountBtn" runat="server" Text="WordCount" OnClick="WordCountBtn_Click"/>
    <h3>Top 10 Word Counting on textfiles</h3>
    <h5>This service takes a textfile and returns the top 10 most frequently occuring words</h5>
    <asp:TextBox ID="Top10Box" runat="server"></asp:TextBox><asp:Button ID="Top10Btn" runat="server" Text="Top10ContentWords" OnClick="Top10Btn_Click"/>
    <h3>Automated Email Service</h3>
    <h5>This sends an email to someone</h5>
    <asp:Label ID="Label1" runat="server" Text="From: "></asp:Label><asp:TextBox ID="SenderBox" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="To :"></asp:Label><asp:TextBox ID="RecieverBox" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Message: "></asp:Label><asp:TextBox ID="MessageBox" runat="server"></asp:TextBox><asp:Button ID="SendMessageBtn" runat="server" Text="Button" OnClick="SendMessageBtn_Click"/>

</asp:Content>
