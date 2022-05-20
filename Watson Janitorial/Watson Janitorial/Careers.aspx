<%@ Page Title="Careers" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="True" CodeFile="Careers.aspx.vb" Inherits="Careers" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><% %>&nbsp;</h2>
    <h3 class="text-center"; style="font-size: xx-large;"><%: Title %></h3>
    <p>
        <asp:Button ID="btnd" runat="server" height="49px" Text="Disinfector" width="200px" />
&nbsp;&nbsp;

        <asp:Button ID="btnjanitor" runat="server" height="49px" Text="Janitor" width="200px" />
&nbsp;&nbsp;

        <asp:Button ID="btnww" runat="server" height="49px" Text="Window Washer" width="200px"/>
&nbsp;&nbsp;

        <asp:Button ID="btnss" runat="server" height="49px" Text="Sweeper / Shoveler" width="200px" />
&nbsp;&nbsp;

        <asp:Button ID="btnlr" runat="server" height="49px" Text="Litter Remover" width="200px" />
&nbsp;&nbsp;

        <asp:Button ID="btnlbr" runat="server" height="49px" Text="Leaf Blower / Raker" width="200px" />
&nbsp;&nbsp;

        <asp:Button ID="btnlmht" runat="server" height="49px" Text="Lawn Mower / Hedge Trimmer" width="200px" />
&nbsp;&nbsp;

        <asp:Button ID="btnmt" runat="server" height="49px" Text="Maintenance Technician" width="200px" />
    &nbsp;&nbsp;

        <asp:Button ID="btntd" runat="server" height="49px" Text="Truck Driver" width="200px" />
    </p>
    <p>
        &nbsp;</p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="lstd" runat="server" Visible="False"></asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="lstj" runat="server" Visible="False"></asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="lstww" runat="server" Visible="False"></asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="lstss" runat="server" Visible="False"></asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="lstlr" runat="server" Visible="False"></asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="lstlbr" runat="server" Visible="False"></asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="lstlmht" runat="server" Visible="False"></asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="lstmt" runat="server" Visible="False"></asp:ListBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="lsttd" runat="server" Visible="False"></asp:ListBox>
    </p>
</asp:Content>