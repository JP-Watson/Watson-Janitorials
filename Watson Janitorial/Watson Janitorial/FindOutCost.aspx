<%@ Page Title="Find Out the Cost" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="True" CodeFile="FindOutCost.aspx.vb" Inherits="FindOutCost" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>&nbsp; </h2>
    <h3 class="text-center"; style="font-size: xx-large;"><%: Title %></h3>
    <p>Please select what services you wish to have done on your property and then press the &quot;Continue&quot; button to enter additional details</p>
    <p>
        <asp:CheckBox ID="chkd" runat="server" Text="Surfaces and High-Touch Points Disinfected" />
    </p>
    <p>
        <asp:CheckBox ID="chkvwdm" runat="server" Text="Floors Vacuumed and/or Wet and Dry Mopped" />
    </p>
    <p>
        <asp:CheckBox ID="chkwc" runat="server" Text="Windows Cleaned" />
    </p>
    <p>
        <asp:CheckBox ID="chkpss" runat="server" Text="Paths Sweeped or Shoveled" />
    </p>
    <p>
        <asp:CheckBox ID="chklr" runat="server" Text="Litter Removed" />
    </p>
    <p>
        <asp:CheckBox ID="chklm" runat="server" Text="Lawn Mowed" />
    </p>
    <p>
        <asp:CheckBox ID="chklbr" runat="server" Text="Leaves Blown and/or Raked" />
    </p>
    <p>
        <asp:CheckBox ID="chkht" runat="server" Text="Hedges Trimmed" />
    </p>
    <p>
        <asp:CheckBox ID="chksr" runat="server" Text="Something Repaired" />
    </p>
    <p class="text-center"><strong>
        <asp:Button ID="btncontinue" runat="server" Height="30px" style="font-weight: bold" Text="Continue" Width="141px" />
        </strong></p>
    <p class="text-left">Are you going to want the selected services done one-time, weekly, bi-weekly, monthly, or yearly?</p>
    <p class="text-left">
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Value="One-Time"></asp:ListItem>
            <asp:ListItem Value="Weekly"></asp:ListItem>
            <asp:ListItem Value="Bi-Weekly"></asp:ListItem>
            <asp:ListItem Value="Monthly"></asp:ListItem>
            <asp:ListItem Value="Yearly"></asp:ListItem>
        </asp:RadioButtonList>
    </p>
    <p class="text-left">Please enter the following information and then press the &quot;Calculate&quot; button to calculate the total cost</p>
    <p class="text-left">
        <asp:Label ID="lblinside" runat="server" style="font-size: large" Text="Please enter the total square feet of the interior of your property" Visible="False"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtinside" runat="server" Height="16px" Visible="False" Width="119px"></asp:TextBox>
    &nbsp;&nbsp;
        <asp:Label ID="lblierror" runat="server" Text="* Must be a number greater than zero" Visible="False"></asp:Label>
    </p>
    <p class="text-left">
        <asp:Label ID="lblwindows" runat="server" style="font-size: large" Text="Please enter the number of windows on your property" Visible="False"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtwindows" runat="server" Height="16px" Visible="False" Width="119px" Wrap="False"></asp:TextBox>
    &nbsp;&nbsp;
        <asp:Label ID="lblwerror" runat="server" Text="* Must be a number greater than zero" Visible="False"></asp:Label>
    </p>
    <p class="text-left">
        <asp:Label ID="lbllawn" runat="server" style="font-size: large" Text="Please enter the total square feet of any lawn you own" Visible="False"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtlawn" runat="server" Visible="False"></asp:TextBox>
    &nbsp;&nbsp;
        <asp:Label ID="lbllerror" runat="server" Text="* Must be a number greater than zero" Visible="False"></asp:Label>
    </p>
    <p class="text-left">
        <asp:Label ID="lblconcrete" runat="server" style="font-size: large" Text="Please enter the total square feet of any concrete you own (sidewalks, patios, porches, etc.)" Visible="False"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtconcrete" runat="server" Visible="False"></asp:TextBox>
    &nbsp;&nbsp;
        <asp:Label ID="lblcerror" runat="server" Text="* Must be a number greater than zero" Visible="False"></asp:Label>
    </p>
    <p class="text-left">
        <asp:Label ID="lblhedges" runat="server" style="font-size: large" Text="Please enter the number of hedges on your property" Visible="False"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txthedges" runat="server" Visible="False"></asp:TextBox>
    &nbsp;&nbsp;
        <asp:Label ID="lblherror" runat="server" Text="* Must be a number greater than zero" Visible="False"></asp:Label>
    </p>
    <p class="text-left">
        <asp:Label ID="lblrepair" runat="server" style="font-size: large" Text="Please enter the number of items on your property that need to be repaired" Visible="False"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtrepair" runat="server" Height="19px" Visible="False" Width="47px"></asp:TextBox>
    &nbsp;&nbsp;
        <asp:Label ID="lblrerror" runat="server" Text="* Must be a number greater than zero" Visible="False"></asp:Label>
    </p>
    <p class="text-center"><strong>
        <asp:Button ID="btncalculate" runat="server" Height="30px" style="font-weight: bold" Text="Calculate" Visible="False" Width="141px" />
        </strong></p>
    <p class="text-center"><strong>
        <asp:Label ID="lbltotalcost" runat="server" style="font-size: xx-large" Text="Total Cost (Taxes included): " Visible="False"></asp:Label>
        </strong></p>
</asp:Content>