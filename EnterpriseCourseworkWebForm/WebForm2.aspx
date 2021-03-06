﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="EnterpriseCourseworkWebForm.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<meta name="viewport" content="width=device-width, initial-scale=1.0"/> 
    <link href="FontAwsm/css/all.css" rel="stylesheet" />
    <!--Update-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform -r  //copy to package manager-->
    <!--<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"> NOT NEEDED ANYMORE I THINK-->
    <link href="Content/font-awesome.css" rel="stylesheet" />
    <link href="Content/font-awesome.min.css" rel="stylesheet" />
<style>
body {margin: 0;}
html {
  font-family: "Work Sans";
}
ul.topnav {
  list-style-type: none;
  margin: 0;
  padding: 0;
  margin-right: 0;
  margin-left: 0;
  overflow: hidden;
  background-color: #2E2E2E;
}

ul.topnav li {float: left;}

ul.topnav li a {
  display: block;
  color: white;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
}

ul.topnav li a:hover:not(.active) {background-color: #2E2E2E;}

ul.topnav li.right {float: right;
background-color: #2E2E2E;
}

    /*.content-padding {
        width:5%;
    }*/


.aside {
  background-color: #F2F2F2;
  padding: 15px;
  color: #ffffff;
  text-align: center;
  font-size: 14px;
  width: 64%;
  box-shadow:0 1px 3px rgba(0,0,0,0.12), 0 1px 2px rgba(0,0,0,0.24);
  /*margin-left: 10%;
  margin-right:10%*/
  margin-right: 18%;
  margin-left: 18%;
}


.footer {
  background-color: #2E2E2E;
  color: #ffffff;
  margin-right: 0;
  margin-left: 0;
  text-align: center;
  font-size: 12px;
  padding: 15px;
}
    .row:after {
        content: "";
        display: table;
        clear: both;
    }


    /*searchbar-https://www.w3schools.com/howto/tryit.asp?filename=tryhow_css_search_button*/
    body {
  font-family: Arial;
}

* {
  box-sizing: border-box;

}

form.example input[type=text] {
  padding: 10px;
  font-size: 17px;
  border: 1px solid grey;
  float: left;
  width: 80%;
  background: #f1f1f1;
}

form.example button {
  float: left;
  width: 20%;
  padding: 10px;
  background: #2196F3;
  color: white;
  font-size: 17px;
  border: 1px solid grey;
  border-left: none;
  cursor: pointer;
}

form.example button:hover {
  background: #0b7dda;
}

form.example::after {
  content: "";
  clear: both;
  display: table;
}

    /* Create three equal columns that floats next to each other */
    .column {
        float: left;
        width: 30%;
        padding: 10px;
        height: 200px;
    }
.uniLogoBanner{
  margin-right: 0;
  margin-left: 0;
}
.fab fa-university{
    color:white;
    font-size:50px;

}
.search-container {
    display: block;
    float: none;
    min-width: 30%;
    height: 46px;
    font-size: 15px;
    margin-top: 8px;
    margin-right:5%;
    margin-left:0%;
    width: 95%;
}

.search-button {
    background-color: #606EB2;
    float: right;
    width: 55px;
    height: 46px;
    border: none;
    margin-top: -46px;
}
.columnleft {
    float: left;
    width: 50%;
    height: 170px;
    border: none;
    position: initial;
}


.columnright {
    float: right;
    width: 50%;
    height: 170px;
    border: none;
    position: initial;
}

.row {
    margin: auto auto auto auto;
}

.div2 {
    background-color: #606EB2;
    height: 500px;
    max-width: 100%;
    float: none;
    margin: auto auto auto auto;
    position: center;
    padding-right: 10px;
}


.more {
    display: block;
    float: left;
    font-family: 'Work Sans', sans-serif;
    font-size: 16px;
    color: #060360;
    margin-left: 5px;
    margin-top: 5px;
}

h3 {
    font-family: 'Work Sans', sans-serif;
    /*font-size: 25px;*/
    color: white;
    float: left;
    width: 427px;
    }
.h2 {
    font-family: 'Work Sans', sans-serif;

    /*font-size: 25px;*/
    color: #060360;
    float: left;
    width: 427px;
    }

.idea {
    display: block;
    float: none;
    min-width: 100%;
    height:auto;
    font-size: 12px;
    margin-left: 5px;
    margin-top: 7px;
    height: 60px;
    font-family: 'Work Sans', sans-serif;
    font-size: 20px;
}
.IdeaContainer{
    background-color: #ffffff;
    margin-top: 13px;
    margin-left: 10px;
    Height: 130px;
    text-align:left;
    padding-top:5px;
    padding-left:5px;
    padding-bottom:5px;
}

.TextArea {
        width:87%;
        height:78%;
    }
.IdeaTextLable{
    font-family: 'Work Sans', sans-serif;
    font-size: 16px;
    color:#060360;
    text-align: left;
}
.bottomDivIdeaLeft{
     Height:15%;
     width:99%;
     font-family: 'Work Sans', sans-serif;
    font-size: 16px;
    color:#060360;
}

.bottomDivIdeaRight{
     Height:15%;
     width:12%;
     font-family: 'Work Sans', sans-serif;
    font-size: 16px;
    color:#060360;
}

/*.ThumbsUpLable{
    font-family: 'Work Sans', sans-serif;
    font-size: 10px;
    color:#060360;
    padding-right: 30px;
    margin-bottom: 5%;
    text-align: left;
}*/


    /* Responsive layout - makes the three columns stack on top of each other instead of next to each other */
@media screen and (max-width: 600px) {
  .column {
    width: 100%;
  }
}
@media screen and (max-width: 600px) {
  ul.topnav li.right, 
  ul.topnav li {float: none;}
}
    #TextArea1 {
        margin-bottom: 0px;
    }
    .ThumbsBtn {
        /*padding-right:1%;*/
        height: 48px;
        width: 48px;
    }
.containerFooter{
    display:block;
    font-family: 'Work Sans',sans-serif;
    font-size: 16px;
    font-weight: 400;
        color: #fff;
}
.connect-with-us{
    color:white;
}
    .ThumbsDwnBtn {}

</style>
</head>
<body>

    <form id="form1" runat="server">

<ul class="topnav">
  <li><a href="#home">Home</a></li>
  <li><a href="#news">News</a></li>
  <li><a href="#contact">Contact</a></li>
  <li class="right"><a href="#logIn">Login</a></li>
</ul>

 

<div class="uniLogoBanner" style="padding:0 16px;">
  <%--<h4>Resize the browser window to see the effect.</h4>--%>
      <section>
            <img src="Images/u18.png" />
        </section>
</div>

 <div class="col-3 col-s-12">
    <div class="aside">

        <%--<form class="example" action="/action_page.php">
  <input type="text" placeholder="Search.." name="search">
  <button type="submit"><i class="fa fa-search"></i></button> OLD code--%>

        <%--<input class="search-container" type="text" placeholder="Search" name="search" />--%>
        <asp:TextBox ID="searchContainer" CssClass="search-container" placeholder="Search..." runat="server"></asp:TextBox>
        <asp:Button ID="Button1" CssClass="search-button" runat="server" Text="Button" />
<%--</form>--%>
      <h2 style="color: #060360; font-family:Antonio; padding-left:0.5%">HOME</h2>
      <%--<p>Chania is a city on the island of Crete.</p>--%>
     
     
            <div class="row">
                <div class="columnleft" style="background-color: aquamarine;"> <asp:Image ID="Image1" runat="server" Height="181px" ImageAlign="Middle" ImageUrl="~/Images/grePic.jpg" Width="780px" /></div>

                <div class="columnright" style="background-color: #606EB2;">
                    <asp:Label ID="Label7" runat="server" style="color: #f1f1f1; font-family:'Work Sans'; padding-left:0.5%; padding-top:0.5%" Text="Lfbkbkfbbdbhfdfhbhbsbhfbhfbhfbb jvnbhvbv vbbbv hbchbvh"></asp:Label></div>

                <div class="row">
                <div class="columnleft" style="background-color: #00C499;"> <h2 style="color: #060360; float:left; font-family:Antonio; padding-left:3%">News</h2> </div>

                <div class="columnright" style="background-color: #060360;"><h2 style="color: #00C499; float:left; font-family:Antonio; padding-left:3%">Updates</h2></div>
                 </div>

                 <div class="div2">
                    <h3><b>Most Recent Ideas:</b> </h3>
                    
                    <br />
                    <br />
                     



                     
                     
           <asp:Panel ID="Panel1" CssClass="IdeaContainer" runat="server" >
                         <%--<asp:Label ID="Label4" CssClass="ThumbsUpLable" runat="server" Text="Label"></asp:Label>
                         <asp:Label ID="Label5" CssClass="ThumbsDwnLable" runat="server" Text="Label"></asp:Label>--%>
               <div> 
               </div>
                         <asp:TextBox ID="TextBox1" CssClass="TextArea" runat="server"></asp:TextBox>
&nbsp;<asp:ImageButton ID="ImageButtonThumbsUp" CssClass="ThumbsBtn" runat="server" Style=" vertical-align:top; padding-right:0.5% ;margin-top:2.5%" ImageUrl="~/Images/thumbs up.png" />
                         <asp:ImageButton ID="ImageButtonThumbsDwn" CssClass="ThumbsBtn" runat="server"  Style=" vertical-align:top ;margin-top:2.5%" ImageUrl="~/Images/thumbs down.png" />

                          <div class="bottomDivIdeaLeft"> 
                              <%--<asp:Label ID="Label4" runat="server" Style="padding-right:15%" Text="Label"></asp:Label>--%>
                              <asp:LinkButton ID="LinkButton4" runat="server" Style="padding-right:20%">Comments...</asp:LinkButton>
                              <asp:HyperLink ID="HyperLink2" runat="server" Style="padding-right:20%">Tag,Tag,Tag,Tag..</asp:HyperLink>
                              <asp:LinkButton ID="LinkButton2" runat="server" Style="padding-right:15%">File.1.5kb</asp:LinkButton>
                              <asp:Label ID="Label5" runat="server" Style="padding-right:3%" Text="No"></asp:Label>
                               <asp:Label ID="Label6" runat="server" Text="No"></asp:Label>
                         </div>
                     </asp:Panel>         
                     
                     <asp:Panel ID="Panel2" CssClass="IdeaContainer"  runat="server" >
                          
                                <asp:TextBox ID="TextBox2" CssClass="TextArea" runat="server"></asp:TextBox>
                                &nbsp;<asp:ImageButton ID="ImageButton1" CssClass="ThumbsBtn" runat="server" Style=" vertical-align:top; padding-right:0.5%; padding-left:0.5%" ImageUrl="~/Images/thumbs up.png" />
                                <asp:ImageButton ID="ImageButton2" CssClass="ThumbsBtn" runat="server"  Style=" vertical-align:top" ImageUrl="~/Images/thumbs down.png" />
                     
                          <div class="bottomDivIdeaLeft"> 
                               <asp:LinkButton ID="LinkButton1" runat="server" Style="padding-right:20%">Comments...</asp:LinkButton>
                              <asp:HyperLink ID="HyperLink1" runat="server" Style="padding-right:20%">Tag,Tag,Tag,Tag..</asp:HyperLink>
                              <asp:LinkButton ID="LinkButton5" runat="server" Style="padding-right:15%">File.1.5kb</asp:LinkButton>
                              <asp:Label ID="Label1" runat="server" Style="padding-right:3%" Text="No"></asp:Label>
                               <asp:Label ID="Label2" runat="server" Text="No"></asp:Label>
                         </div>
                         
                     </asp:Panel>
                     <asp:Panel ID="Panel3" CssClass="IdeaContainer" runat="server" >
                        

                         <asp:TextBox ID="TextBox3" CssClass="TextArea" runat="server"></asp:TextBox>
                                &nbsp;<asp:ImageButton ID="ImageButton3" CssClass="ThumbsBtn" runat="server" Style=" vertical-align:top; padding-right:0.5%; padding-left:0.5%" ImageUrl="~/Images/thumbs up.png" />
                                <asp:ImageButton ID="ImageButton4" CssClass="ThumbsBtn" runat="server"  Style=" vertical-align:top" ImageUrl="~/Images/thumbs down.png" />
                     
                          <div class="bottomDivIdeaLeft"> 
                               <asp:LinkButton ID="LinkButton3" runat="server" Style="padding-right:20%">Comments...</asp:LinkButton>
                              <asp:HyperLink ID="HyperLink3" runat="server" Style="padding-right:20%">Tag,Tag,Tag,Tag..</asp:HyperLink>
                              <asp:LinkButton ID="LinkButton6" runat="server" Style="padding-right:15%">File.1.5kb</asp:LinkButton>
                              <asp:Label ID="Label3" runat="server" Style="padding-right:3%" Text="No"></asp:Label>
                               <asp:Label ID="Label4" runat="server" Text="No"></asp:Label>
                         </div>
                         



                     </asp:Panel>
                     <%--<p><b><a href="more" class="more">More..</a></b></p>--%>
                     <b></b><asp:LinkButton ID="LinkButtonMore" class="more" runat="server">More..</asp:LinkButton></b>


                   </div>

            </div>

    </div>
  </div>

<div class="footer">
  
   <div class="containerFooter">
 <div id="useful-links"> 
 <h4>Useful links</h4> 
<div class="list-wrapper">
 <ul> 
     <li><a href="https://www.gre.ac.uk/accessibility-statement/portal" style="color:white" target="_blank">Accessibility Statement</a></li> 
     <li><a href="https://servicestatus.gre.ac.uk/" style="color:white" target="_blank">IT Service Status</a></li> 
     <li><a href="https://www.gre.ac.uk/it-and-library" style="color:white" target="_blank">IT and Library Services</a></li>
     <li><a href="https://www.gre.ac.uk/it-and-library/mobile" style="color:white" target="_blank">Mobile App</a></li> 
     <li><a href="https://www.gre.ac.uk/contact" style="color:white" target="_blank">Contact Us</a></li> 
     <li><a href="https://www.gre.ac.uk/it-and-library/support/tassistance" style="color:white" target="_blank">Need more help?</a></li> 

 </ul> 
</div> </div>
    <div id="connect-with-us"> 
        <h4>Connect with us</h4> 
        <div class="gre-social-main"> 
            <div class="gre-social-button"> 
                <a class="button" href="https://facebook.com/uniofgreenwich" style="color:white" target="_blank">
                    <i class="fa fa-facebook-official"></i>
                    <span class="sr-only">Facebook page</span></a> </div> 
            <div class="gre-social-button"> 
                <a class="button" href="https://twitter.com/UniofGreenwich" style="color:white; display:inline" target="_blank">
                    <i class="fa fa-twitter"></i>
                    <span class="sr-only">Twitter feed</span></a> </div> 
            <div class="gre-social-button"> 
                <a class="button" href="https://www.youtube.com/user/UniversityGreenwich" style="color:white; display:inline" target="_blank">
                    <i class="fa fa-youtube-play"></i>
                    <span class="sr-only">YouTube channel</span></a> </div> 
            <div class="gre-social-button"> 
                <a class="button" href="https://instagram.com/uniofgreenwich/" style="color:white" target="_blank">
                    <i class="fa fa-instagram"></i>
                    <span class="sr-only">Instagram page</span></a> </div>

            <div class="gre-social-button"> 
                <a class="button" href="https://www.linkedin.com/edu/school?id=12704" style="color:white" target="_blank">
                    <i class="fa fa-linkedin"></i>
                    <span class="sr-only">LinkedIn page</span></a> </div> 
            <div class="gre-social-button"> 
                <a class="button" href="https://www.snapchat.com/add/uniofgreenwich" style="color:white; height: 80px; width:80px"  target="_blank">
                    <i class="fa fa-snapchat-ghost"></i>
                    <span class="sr-only">Snapchat page</span></a>  </div> 

           

        </div> 

    </div>
    </div>
</div>
  
    </form>
  
</body>

</html>
