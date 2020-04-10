<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Statistics_QAmanager.aspx.cs" Inherits="EnterpriseCourseworkWebForm.Statistics_QAmanager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

 <style>
        body {
            margin: 0;
        }

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

            ul.topnav li {
                float: left;
            }

                ul.topnav li a {
                    display: block;
                    color: white;
                    text-align: center;
                    padding: 14px 16px;
                    text-decoration: none;
                }

                    ul.topnav li a:hover:not(.active) {
                        background-color: #2E2E2E;
                    }

                ul.topnav li.right {
                    float: right;
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
            box-shadow: 0 1px 3px rgba(0,0,0,0.12), 0 1px 2px rgba(0,0,0,0.24);
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

        .uniLogoBanner {
            margin-right: 0;
            margin-left: 0;
        }

        .fab fa-university {
            color: white;
            font-size: 50px;
        }

        .search-container {
            display: block;
            float: none;
            min-width: 30%;
            height: 46px;
            font-size: 15px;
            margin-top: 8px;
            margin-right: 5%;
            margin-left: 0%;
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
            height: 800px;
            max-width: 100%;
            float: none;
            margin: auto auto auto auto;
            position: center;
            padding-right: 10px;
            padding-top: 10px;
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
            height: auto;
            font-size: 12px;
            margin-left: 5px;
            margin-top: 7px;
            height: 60px;
            font-family: 'Work Sans', sans-serif;
            font-size: 20px;
        }

        .IdeaSubmitPanel {
            background-color: #F2F2F2;
            margin-left: 10px;
            Height: 500px;
            text-align: left;
            padding-top: 5px;
            padding-left: 5px;
            padding-bottom: 5px;
        }

        .TextArea {
            width: 30%;
            height: auto;
        }

        .IdeaTextLable1 {
            font-family: 'Work Sans', sans-serif;
            font-size: 18px;
            color: #060360;
            text-align: left;
        }

        .IdeaTextLableH2 {
            padding-left: 2.5%;
            font-size: 23px;
            font-weight: 900;
            font-family: Antonio;
            padding-left: 3%;
            color: #060360;
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
            ul.topnav li {
                float: none;
            }
        }

        #TextArea1 {
            margin-bottom: 0px;
        }

        .ThumbsBtn {
            /*padding-right:1%;*/
            height: 48px;
            width: 48px;
        }

        .containerFooter {
            display: block;
            font-family: 'Work Sans',sans-serif;
            font-size: 16px;
            font-weight: 400;
            color: #fff;
        }

        .btnSubmitIdea {
            border-style: none;
         border-color: inherit;
         border-width: medium;
         background-color: #060360;
            color: white;
            float: left;
            padding: 16px 20px;
            cursor: pointer;
            opacity: 0.9;
            text-align: center;
            font-family: 'Work Sans';
            font-weight: bold;
            margin-right: 3%;
            margin-bottom: 5%;
         margin-top: 0px;
     }

        .CheckBoxIdea {
            font-family: 'Work Sans';
            font-size: 18px;
            text-align: Right;
            padding-left: 35%;
            color: #060360;
        }


        .FileUpploadIdea {
            margin-left: 4%;
        }

        .connect-with-us {
            color: white;
        }

        .ThumbsDwnBtn {
        }

         .datagridview{
        color: black; 
        width: 80%;
        margin-left: 10%;
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



        <div class="uniLogoBanner" style="padding: 0 16px;">
            <%--<h4>Resize the browser window to see the effect.</h4>--%>
            <section>
                <img src="Images/u18.png" />
            </section>
        </div>

        <div class="col-3 col-s-12">
            <div class="aside">
                <div class="div2">
                    <asp:Panel ID="Panel1" CssClass="IdeaSubmitPanel" runat="server">

                        <h2 style="color: #060360; font-family: Antonio; float: left; padding-left: 2.5%">Statistics</h2>
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />

                        <asp:Label ID="Label8" runat="server" class="IdeaTextLable1" Style="padding-left: 2.5%" Text=""></asp:Label>

                        <br />
                        <br />
                        <br />
                        
                        <asp:Label ID="Label2" runat="server" Text="" CssClass="h2"></asp:Label>   
                        <br />
                         <asp:Label ID="Label5" runat="server" Text="" CssClass="h2"></asp:Label> 
                         <br />
                        <asp:Label ID="Label3" runat="server" CssClass="h2" Text=""></asp:Label>
                         <br />
                        <asp:Label ID="Label4" runat="server" Text="" CssClass="h2"></asp:Label> 
                      
                        
                        <br /><br />

                
                        <br />
                        <asp:Button ID="Button1" runat="server" CssClass="btnSubmitIdea" Height="50px" OnClick="Button1_Click" Text="Download all ideas into CSV" Width="363px" /><br /><br /><br />

                        <asp:Label ID="Label1" runat="server" Text="" CssClass="h2"></asp:Label>
                        <br />
                    </asp:Panel>
                </div>
            </div>

        </div>




    </form>
</body>
</html>
