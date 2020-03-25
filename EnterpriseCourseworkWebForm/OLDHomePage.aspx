<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OLDHomePage.aspx.cs" Inherits="EnterpriseCourseworkWebForm.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Stylesheets/BaseStyles.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
    <webopt:BundleReference runat="server" Path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <style>
        
    </style>

</head>
<body>
    <form id="HomePage" runat="server">

        <nav>
            <a href="#home" class="button1">Home</a>
            <a href="#login" class="button1" style="float: right">Login</a>
        </nav>

        <section>
            <img src="Images/u18.png" />
        </section>

        <div class="div1">
            <br />
            <div>
                <input class="search-container" type="text" placeholder="Search" name="search" />
                
                <asp:Button ID="Button1" CssClass="search-button" runat="server" Text="Button" />
            </div>

            <br />
            <h2><b>Home 
            </b>
            </h2>
            <br />
            <br />


            <div class="row">
                <div class="columnleft" style="background-color: aquamarine;"></div>

                <div class="columnright" style="background-color: #606EB2;"></div>

            </div>

            <div class="row">
                <div class="columnleft" style="background-color: #00C499;"></div>

                <div class="columnright" style="background-color: #060360;"></div>
            </div>


            <div class="row">
                <div class="div2">
                    <h3><b>Most Recent Ideas:  </b></h3>
                    <br />
                    <br />
                    <br />
                    <div>
                        <input type="text" class="idea" placeholder="Lorem blah blah" readonly />
                        <input type="text" class="idea" placeholder="Lorem blah blah" readonly />
                        <input type="text" class="idea" placeholder="Lorem blah blah" readonly />
                        <input type="text" class="idea" placeholder="Lorem blah blah" readonly />
                        <p><b><a href="more" class="more">More..</a></b></p>
                    </div>
                </div>
            </div>


        </div>


        <footer>
            <a href="#first" class="first"><i class="fa fa-university"></i><span>Label1</span></a>
            <a href="#first1" class="first"><i class="fa fa-map-marker"></i><span>Label2</span></a>
            <a href="#first2" class="first"><i class="fa fa-phone"></i><span>Label3</span></a>

        </footer>



    </form>

</body>
</html>
