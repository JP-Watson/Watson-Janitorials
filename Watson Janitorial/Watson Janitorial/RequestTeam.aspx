<%@ Page Title="Request A Team" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="True" CodeFile="RequestTeam.aspx.vb" Inherits="RequestTeam" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><% %>&nbsp;</h2>
    <h3 class="text-center"; style="font-size: xx-large;"><%: Title %></h3>
    <p class="text-center" style="width: 1268px; height: 19px">
        <asp:Label ID="lblinstructions" runat="server" Font-Size="Medium" Text="Please select how often you wish to have a team conduct janitorial work of your property"></asp:Label>
    </p>
    <p class="text-left" style="width: 1268px; height: 34px">
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="211px">
            <asp:ListItem>One-Time</asp:ListItem>
            <asp:ListItem>Weekly</asp:ListItem>
            <asp:ListItem>Bi-Weekly</asp:ListItem>
            <asp:ListItem>Monthly</asp:ListItem>
            <asp:ListItem>Yearly</asp:ListItem>
            <asp:ListItem>Specified amount of times</asp:ListItem>
        </asp:RadioButtonList>
    </p>
    <p class="text-left" style="width: 1268px; height: 62px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblerror1" runat="server" Font-Size="X-Large" Text="* Please select how often you wish to have a team clean your property" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
    <p class="text-left" style="width: 1268px; height: 62px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button href="Calendar1.Visible = True" ID="btnview" runat="server" Height="59px" Text="View Available Dates" Width="183px" />
    </p>
    <p class="text-center" style="width: 1268px; height: 50px">
        <asp:Label ID="lblselectservices" runat="server" Font-Size="X-Large" Text="Select the services you wish to have completed on the date(s) you have selected" Visible="False"></asp:Label>
    </p>
    <p class="text-center" style="width: 1267px; height: 96px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblselectdates" runat="server" Font-Size="X-Large" Text="Select one of the dates you wish to have a team clean your property and then press the &quot;Add Date&quot; button to add the date to the list below the calendar. Once you have added all of your requested dates, click the &quot;Continue&quot; button to enter the other required information." Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
    <p class="text-left" style="width: 1268px; height: 62px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button href="Calendar1.Visible = True" ID="btnadd" runat="server" Height="59px" Text="Add Date" Width="183px" CssClass="col-xs-offset-0" Visible="False" />
    </p>
    <div class="text-center" style="margin-left: 480px; width: 351px;">
        <asp:Calendar ID="calavailabledates" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="160px" Visible="False" Width="256px" style="margin-left: 0px">
                    <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                    <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                    <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                </asp:Calendar>
        <div class="text-left">
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblerror" runat="server" Text="* You may only select future dates" Visible="False"></asp:Label>

            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbltitle" runat="server" Font-Bold="True" Font-Size="Large" Text="Available Services" Visible="False"></asp:Label>
            <br />
            <asp:CheckBox ID="chkdisinfect" runat="server" Text="Surfaces and High-Touch Points Disinfected" Visible="False" />
            <br />
            <asp:CheckBox ID="chkfvwdm" runat="server" Text="Floors Vacuumed And/Or Wet and Dry Mopped" Visible="False" />
            <br />
            <asp:CheckBox ID="chkwindows" runat="server" Text="Windows Cleaned" Visible="False" />
            <br />
            <asp:CheckBox ID="chkpss" runat="server" Text="Paths Sweeped or Shoveled" Visible="False" />
            <br />
            <asp:CheckBox ID="chklr" runat="server" Text="Litter Removed" Visible="False" />
            <br />
            <asp:CheckBox ID="chklm" runat="server" Text="Lawn Mowed" Visible="False" />
            <br />
            <asp:CheckBox ID="chklbr" runat="server" Text="Leaves Blown And/Or Raked" Visible="False" />
            <br />
            <asp:CheckBox ID="chkht" runat="server" Text="Hedges Trimmed" Visible="False" />
            <br />
            <asp:CheckBox ID="chkrepair" runat="server" Text="Something Repaired" Visible="False" />
        </div>
        <asp:Label ID="lblerror2" runat="server" Text="* Please select the services you wish to have the team complete on your property" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;
        </div>
    <p class="text-left">

        &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
    </p>
    <p class="text-left">

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="lstdates" runat="server" Visible="False"></asp:ListBox>

    </p>
    <p class="text-left">

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button href="Calendar1.Visible = True" ID="btncontinue" runat="server" Height="59px" Text="Continue" Width="183px" Visible="False" />

    </p>
    <p class="text-left">
        <asp:Label ID="lbldirections" runat="server" Text="Please enter the following information and then press the &quot;Calculate&quot; button to calculate the total cost" Visible="False"></asp:Label>
    </p>
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
    <p class="text-center">

        <asp:Button href="Calendar1.Visible = True" ID="btncalculate" runat="server" Height="59px" Text="Calculate" Width="183px" Visible="False" />

    </p>
    <p class="text-center">

        <strong>
        <asp:Label ID="lbltotalcost" runat="server" style="font-size: xx-large" Text="Total Cost (Taxes included): " Visible="False"></asp:Label>
        <asp:Label ID="lbltotalcost1" runat="server" style="font-size: xx-large" Visible="False"></asp:Label>
        <asp:Label ID="lbllabel" runat="server" style="font-size: xx-large" Visible="False"></asp:Label>
        </strong></p>
    <p class="text-center">

        <asp:Button href="Calendar1.Visible = True" ID="btnsend" runat="server" Height="59px" Text="Send Request" Width="183px" Visible="False" />

    </p>
    </asp:Content>