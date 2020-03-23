<!DOCTYPE html>
<html>
<head>
<meta name="viewport" content="width=device-width, initial-scale=1.0"> 
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
    height: 400px;
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
    Height: 95px;
    
}
.IdeaTextLable{
    font-family: 'Work Sans', sans-serif;
    font-size: 16px;
    color:#060360;
    text-align: left;
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

        <input class="search-container" type="text" placeholder="Search" name="search" />
        <asp:Button ID="Button1" CssClass="search-button" runat="server" Text="Button" />
<%--</form>--%>
      <h2>What?</h2>
      <p>Chania is a city on the island of Crete.</p>
     
     
            <div class="row">
                <div class="columnleft" style="background-color: aquamarine;"></div>

                <div class="columnright" style="background-color: #606EB2;"></div>

                <div class="row">
                <div class="columnleft" style="background-color: #00C499;"></div>

                <div class="columnright" style="background-color: #060360;"></div>
                 </div>

                 <div class="div2">
                    <h3><b>Most Recent Ideas:</b> </h3>
                    
                    <br />
                    <br />
                     <%--<div>
                        <input type="text" class="idea" placeholder="Lorem blah blah" readonly />
                        <input type="text" class="idea" placeholder="Lorem blah blahfhre vchghvhghg eirhg eurhgerhgh uehg eghehg;eerug  ug egoeug ueg efugeg uetg " readonly />
                        <input type="text" class="idea" placeholder="Lorem blah blah" readonly />
                        <input type="text" class="idea" placeholder="Lorem blah blah uhu ghiuehouwhiwheouhehfh    eurgeugogouegfuhg  oergueghowfh eruhgeogoeufg" readonly />
                        <input type="text" class="idea" placeholder="Lorem blah blah" readonly />
                        <p><b><a href="more" class="more">More..</a></b></p>
          
                    </div>--%>



                     
                     
           <asp:Panel ID="Panel1" CssClass="IdeaContainer" runat="server" >
                        <asp:label id="label1" cssclass="ideatextlable" runat="server" text="label"></asp:label>
                         <%--<asp:Label ID="Label4" CssClass="ThumbsUpLable" runat="server" Text="Label"></asp:Label>
                         <asp:Label ID="Label5" CssClass="ThumbsDwnLable" runat="server" Text="Label"></asp:Label>--%>
                     </asp:Panel>          <asp:Panel ID="Panel2" CssClass="IdeaContainer" runat="server" >
                         <%--<asp:Label ID="Label2" CssClass="IdeaTextLable"  runat="server" Text="Label"></asp:Label>--%>
                         <%--<asp:Label ID="Label6" CssClass="ThumbsUpLable" runat="server" Text="Label"></asp:Label>
                         <asp:Label ID="Label7" CssClass="ThumbsDwnLable" runat="server" Text="Label"></asp:Label>--%>
                         <asp:Table ID="Table1" runat="server" Height="62px" Width="915px">
                         </asp:Table>
                     </asp:Panel>
                     <asp:Panel ID="Panel3" CssClass="IdeaContainer" runat="server" >
                         <%--<asp:Label ID="Label3" CssClass="IdeaTextLable" runat="server" Text="Label"></asp:Label>--%>
                         <%--<asp:Label ID="Label8" CssClass="ThumbsUpLable" runat="server" Text="Label"></asp:Label>
                         <asp:Label ID="Label9" CssClass="ThumbsDwnLable" runat="server" Text="Label"></asp:Label>--%>
                     </asp:Panel>
                     <p><b><a href="more" class="more">More..</a></b></p>
                     


                   </div>

            </div>

    </div>
  </div>

<div class="footer">
 

    <div class="row">
        
  <div class="column">
    <!--<h2>Column 1</h2>-->

    <i class="fa fa-university"></i>
  </div>
  <div class="column">
    <h2>Column 2</h2>
    <p>Some text..</p>
  </div>
  <div class="column">
    <h2>Column 3</h2>
    <p>Some text..</p>
  </div>
</div>


</div>
  
    </form>
  
</body>

</html>
