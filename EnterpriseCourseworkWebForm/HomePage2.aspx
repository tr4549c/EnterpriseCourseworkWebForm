<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage2.aspx.cs" Inherits="EnterpriseCourseworkWebForm.HomePage2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HomePage</title>
    <link href="Stylesheets/BaseStyles.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <nav>
            <%--<a href="#home" class="button1">Home</a>&nbsp;
            <a href="#login" class="button1" style="float: right">Login</a>--%>

            <ul class="topnav">
  <li><a href="#home">Home</a></li>
  <li><a href="#news">News</a></li>
  <li><a href="#contact">Contact</a></li>
  <li class="right"><a href="#logIn">Login</a></li>
</ul>
         </nav>

        <section>
            <img src="Images/u18.png" />
        </section>



        </div>
    </form>
</body>
</html>
