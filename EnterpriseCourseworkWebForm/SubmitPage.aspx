<!DOCTYPE html>
<html>
<head>
    <title>Submit Page</title>
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

    .content-padding {
        width:5%;
    }

    .col{
        height:100%;
    }
.aside {
  background-color: #F2F2F2;
  padding: 15px;
  color: #ffffff;
  text-align: center;
  font-size: 14px;
  width: 64%;
  min-height:100%;
  box-shadow:0 1px 3px rgba(0,0,0,0.12), 0 1px 2px rgba(0,0,0,0.24);
  /*margin-left: 10%;
  margin-right:10%*/
  margin-right: 18%;
  margin-left: 18%;
  height:100%;
  min-height:100%;
  /*margin-bottom:50%;*/
}
.aside1{
    background-color: #606EB2;
  height:1030px;
  color: #ffffff;
  text-align: left;
  font-size: 14px;
  max-width: 100%;
       width:100%;
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
    .column i{
        font-size:65px;
    }
.uniLogoBanner{
  margin-right: 0;
  margin-left: 0;
}

.search-container {
    display: block;
    float: left;
    min-width: 30%;
    height: 32px;
    font-size: 15px;
    margin-top: 8px;
   
    margin-left:5px;
    width: 45%;
}
.dropdown2{
     color:black;
     background-color:white;
    display: block;
    float: right;
    width:44%;
    margin-top:-32px;
   
    margin-left:5px;
    font-size: 12px;
    margin-right:5px;
    margin-left: 5px;
   /* margin-right:10px;
    margin-top: 7px;
    height: 60px;
    */
    font-family: 'Work Sans', sans-serif;
    font-size: 20px;
    max-height:32px;
}
.search-button {
    background-color: #060360;
    float: left;
    width: 32px;
    height: 32px;
    border: none;
    margin-top:8px;
    margin-right:45%;
    color:white;
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
    height: 1080px;
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

.IdeaTextLable{
    font-family: Antonio;
   padding-left:10px;
   padding-bottom:10px;
    font-size: 30px;
    color:#fff;
    text-align: left;
}
.IdeaTextLable1{
    font-family: 'Work Sans';
   padding-left:5px;
    font-size: 14px;
    color:#060360;
    text-align: left;
}
.dropdown1{
     color:black;
     min-width:98%;
     background-color:white;
        display: block;
    float: none;
    
    height:auto;
    font-size: 12px;
    margin-left: 5px;
    margin-right:10px;
    margin-top: 7px;
    height: 60px;
    font-family: 'Work Sans', sans-serif;
    font-size: 20px;
}
.button11{
    margin-left:5px;
    height:35px;
    font-family:'Work Sans', sans-serif;
    background-color:white;
    box-shadow:0 1px 3px rgba(0,0,0,0.12), 0 1px 2px rgba(0,0,0,0.24);
    font-size:18px;
    color:#060360;
    margin-top:10px;
}
.IdeaC{
    /*background-color: #ffffff;
    margin-top: 13px;
    margin-left: 5px;
    Height: 78px;
    width:98%;*/
     background-color: #ffffff;
    margin-top: 13px;
    margin-left: 10px;
    Height: 130px;
    text-align:left;
    padding-top:5px;
    padding-left:5px;
    padding-bottom:5px;
}
/* ///////////////////////////////////////////  */

.rating-area{
  width:100px;
  height:78px;
  padding:10px;
  
  display:flex;
  float:right;
  flex-direction:column;
}
.align-center{
   display:flex;
  justify-content:center;
  align-items:center;
}
.transition-fast{
  transition:0.2s ease-out;
}
.thumbs-up{
    cursor:pointer;
  color:#060360;
  font-size:24px;
  transform:rotate(0) translate(0);
  
}

.thumbs-up:hover .thumbs-up{
  color:#1976D2;
  transform:rotate(-5deg) translate(0px, -1px);
}
.thumbs-up:active{
  background:#e0e0e0;
  box-shadow:1px 1px 0px rgba(0,0,0,0.2);
}
.thumbs-up:active .thumbs-up{
  color:#065bae;
  transition:0.1s;
  transform:rotate(-10deg) translate(0px, -2px);
}
.thumbs-down{
  color:#9E9E9E;
  font-size:24px;
  transform:rotate(0) translate(0);
  cursor:pointer;
  margin-right:-20px;
  margin-left:10px;
}
.thumbs-up:hover .thumbs-down{
  color:#565656;
  transform:rotate(5deg) translate(0px, 1px);
}
.thumbs-up:active .thumbs-down{
  color:#424242;
  transition:0.1s;
  transform:rotate(10deg) translate(0px, 2px);
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

 <div class="col">
    <div class="aside">
    
         <div class="div2">
             <br /><br />
        <asp:Label ID="Label1" runat="server" class="IdeaTextLable" Text =" <b>Ideas</b>"></asp:Label><br /><br />
        <asp:Label ID="Label2" runat="server" class="IdeaTextLable1" Text =" Please select a preffered department:"></asp:Label>
             <br />
             <asp:DropDownList ID="DropDownList1" runat="server" Height="38px" class="dropdown1">
             </asp:DropDownList><br />
             <asp:Label ID="Label3" runat="server" class="IdeaTextLable1" Text =" Filter By:"></asp:Label>
             <br />
           <%--  <input class="search-container" type="text" placeholder="Search for tags.." name="search" />
             <input class="search-button" type="button" > <i class="fa fa-search"></i> <input/>
             --%> 
             <input class="search-container" type="text" placeholder="Search for tags.." name="search" />
        
             <%-- <asp:Button ID="Button1" CssClass="search-button" runat="server"  />--%>
             <button class="search-button" id="srcbtn"><i class="fa fa-search"></i></button>
             <asp:DropDownList ID="DropDownList2" runat="server" Height="38px" class="dropdown2">
             </asp:DropDownList>
             <br /><br /><br />
             <asp:Button ID="Button1" class="button11" runat="server" Text="Submit an Idea" />
            <br /><br />


             <asp:Label ID="Label4" runat="server" class="IdeaTextLable" Text ="Latest Ideas"></asp:Label>
            
             
             
             <asp:Panel ID="Panel1" CssClass="IdeaC" runat="server" >
                    <section class="rating-area align-center">
                    <div >
                    <span class="thumbs-up transition-fast"><i class="icon fa fa-thumbs-up thumb "></i></span>
                    <span class="thumbs-down transition-fast"><i class="icon fa fa-thumbs-down thumb "></i></span>
                    </div>
                    </section>
             </asp:Panel>

             <asp:Panel ID="Panel6" CssClass="IdeaContainer" runat="server" >
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

             <asp:Panel ID="Panel2" CssClass="IdeaC" runat="server" >
                  <section class="rating-area align-center">
                    <div >
                    <span class="thumbs-up transition-fast"><i class="icon fa fa-thumbs-up thumb "></i></span>
                    <span class="thumbs-down transition-fast"><i class="icon fa fa-thumbs-down thumb "></i></span>
                    </div>
                    </section>
             </asp:Panel>
             <asp:Panel ID="Panel3" CssClass="IdeaC" runat="server" >
                  <section class="rating-area align-center">
                    <div >
                    <span class="thumbs-up transition-fast"><i class="icon fa fa-thumbs-up thumb "></i></span>
                    <span class="thumbs-down transition-fast"><i class="icon fa fa-thumbs-down thumb "></i></span>
                    </div>
                    </section>
             </asp:Panel>
             <asp:Panel ID="Panel4" CssClass="IdeaC" runat="server" >
                  <section class="rating-area align-center">
                    <div >
                    <span class="thumbs-up transition-fast"><i class="icon fa fa-thumbs-up thumb "></i></span>
                    <span class="thumbs-down transition-fast"><i class="icon fa fa-thumbs-down thumb "></i></span>
                    </div>
                    </section>
             </asp:Panel>
             <asp:Panel ID="Panel5" CssClass="IdeaC" runat="server" >
                  <section class="rating-area align-center">
                    <div >
                    <span class="thumbs-up transition-fast"><i class="fa fa-thumbs-up thumb "></i></span>
                    <span class="thumbs-down transition-fast"><i class="fa fa-thumbs-down thumb "></i></span>
                    </div>
                    </section>
             </asp:Panel>
             <p><b><a href="more" id="more" class="more">More..</a></b></p>
         </div>
    </div>
 </div>

<div class="footer">
 

    <div class="row">
        
  <div class="column">
    

    <i class="fa fa-university"></i>
      <h2>Column 1</h2>
  </div>
  <div class="column">
      <i class="fa fa-map-marker" aria-hidden="true"></i>

    <h2>Column 22</h2>
    <p>Some text..</p>
  </div>
  <div class="column">
      <i class="fa fa-phone" aria-hidden="true"></i>

    <h2>Column 3</h2>
    <p>Some text..</p>
  </div>
</div>


</div>
  
    </form>
  
</body>

</html>
