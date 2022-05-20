<%@ Page Title="Contact Us" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Contact.aspx.vb" Inherits="Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><% %>&nbsp;</h2>
    <h3 class="text-center"; style="font-size: xx-large;"><%: Title %></h3>
    <h4>Headquarters</h4>
    <address style="height: 62px">
        123 Main St<br />
        New York, NY 10006<br />
        <abbr title="Phone">Phone:</abbr>
        212-555-0000</address>
    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">wjsupport@gmail.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">wjmarketing@gmail.com</a></address>
</asp:Content>