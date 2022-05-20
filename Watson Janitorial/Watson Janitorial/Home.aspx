<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Home.aspx.vb" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1 aria-atomic="True" style="width: 1260px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Watson Janitorial</h1>
        <h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; We make your inside look clean and your outside look green!</h2>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>About Us</h2>
            <p>
                All starting with a 17 year old getting a job as a Covid disinfector.</p>
            <p>
                <a class="btn btn-default" href="About.aspx">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Prices</h2>
            <p>
                Check out how much it will cost to get your place tidied up.</p>
            <p>
                <a class="btn btn-default" href="Prices.aspx">View Prices &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Careers</h2>
            <p>
                Join our clean team!</p>
            <p>
                <a class="btn btn-default" href="Careers.aspx">View Careers &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>