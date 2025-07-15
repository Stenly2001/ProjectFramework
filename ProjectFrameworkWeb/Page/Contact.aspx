<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ProjectFrameworkWeb.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>KTS InfoTech Private Limited</h3>
    <address>
        <asp:Label ID="LabelAddress" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="LabelSite_URL" runat="server" Text=""></asp:Label><br />
        <abbr title="Phone">P:</abbr>
        <asp:Label ID="LabelContact_No" runat="server" Text=""></asp:Label>
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:support@ktsinfotech.com">support@ktsinfotech.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:info@ktsinfotech.com">info@ktsinfotech.com</a>
    </address>
</asp:Content>

