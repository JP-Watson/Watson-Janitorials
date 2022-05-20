<%@ Page Title="Prices" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="True" CodeFile="Prices.aspx.vb" Inherits="Prices" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">   
    <h2><% %>&nbsp;</h2>
    <h3 class="text-center"; style="font-size: xx-large;"><%: Title %></h3>
    <p>
        <asp:Button ID="btnd" runat="server" height="49px" Text="Disinfect" width="225px" />
&nbsp;&nbsp;

        <asp:Button ID="btnjanitor" runat="server" height="49px" Text="Janitorial" width="225px" />
&nbsp;&nbsp;

        <asp:Button ID="btnww" runat="server" height="49px" Text="Window Washing" width="225px"/>
&nbsp;&nbsp;

        <asp:Button ID="btnss" runat="server" height="49px" Text="Sweeping / Shoveling" width="225px" />
&nbsp;&nbsp;

        <asp:Button ID="btnlr" runat="server" height="49px" Text="Removal of Litter" width="225px" />
&nbsp;&nbsp;

        <asp:Button ID="btnlbr" runat="server" height="49px" Text="Leaves Blown / Raked" width="225px" />
&nbsp;&nbsp;

        <asp:Button ID="btnlm" runat="server" height="49px" Text="Lawn Mowed" width="225px" />
&nbsp;&nbsp;

        <asp:Button ID="btnht" runat="server" height="49px" Text="Hedges Trimmed" width="225px" />
&nbsp;&nbsp;

        <asp:Button ID="btnm" runat="server" height="49px" Text="Maintenance" width="225px" />
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
        <asp:ListBox ID="lstlm" runat="server" Visible="False"></asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="lstht" runat="server" Visible="False"></asp:ListBox>
    &nbsp;&nbsp;
        <asp:ListBox ID="lstm" runat="server" Visible="False"></asp:ListBox>
    </p>
</asp:Content>