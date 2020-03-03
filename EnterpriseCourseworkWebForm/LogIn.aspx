<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="EnterpriseCourseworkWebForm.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="css/style.css">
    <link href="https://fonts.googleapis.com/css?family=Ubuntu" rel="stylesheet">
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="path/to/font-awesome/css/font-awesome.min.css">
    <meta charset="utf-8" />
    <title></title>
    <style>
        .main{
            width: 402px;
            height: 369px;
            position: absolute;
            top: 20%;
            right: 35%;
            left: 35%;
            background-color: white;
            border:1px solid;
            border-color: #797979;
            font-family:"Work Sans",sans-serif;
        }
        section{
            margin-top:0;
            margin-bottom:-10px;
            float:none;
            max-width:222px;
            max-height:20px;
            min-height:-20px;
            background-color:white;
        }
         .un {
            width: 76%;
            
            color:#6066B2;
            font-weight: 700;
            font-size: 14px;
            letter-spacing: 1px;
            background: white;
            padding: 10px 20px;
            margin-top:50px;
            outline: none;
            border:1px solid;
            border-color: #797979;
            box-sizing:content-box;
            margin-bottom: 50px;
            margin-left: 26px;
            text-align: left;
            margin-bottom: 27px;
    }
    
        form.form1 {
            padding-top: 100px;
        }
    
        .pass {
            width: 76%;
            color:#606EB2;
            font-weight: 700;
            font-size: 14px;
            letter-spacing: 1px;
            background: white;
            padding: 10px 20px;
            border:1px solid;
            border-color: #797979;
            
            outline: none;
            box-sizing:content-box;
            
            margin-bottom: 50px;
            margin-left: 26px;
            text-align: left;
            margin-bottom: 50px;
        }
    
   
    .un:focus, .pass:focus {
        border: 2px solid rgba(0, 0, 0, 0.18) !important;
        
    }
    
    .submit {
        cursor: pointer;
        
        color: white;
        background: #606EB2;
        border: 0;
        padding-left: 40px;
        padding-right: 40px;
        padding-bottom: 10px;
        padding-top: 10px;
        margin-left: 26px;
        border-radius:4px;
       
        font-size: 17px;
        box-shadow: 0 0 20px 1px rgba(0, 0, 0, 0.04);
    }
    
    .forgot {
        color: #606EB2;
        margin-top: -10px;
    }
    
    a {
        text-shadow: 0px 0px 3px rgba(117, 117, 117, 0.12);
        color: #606EB2;
        text-decoration: none;
        margin-left:150px;
        font-size:13px;
    }
    
    
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
     
<div class="main">
        <section>
            <img src="NewFolder1/u18.png" />
        </section>
     
            <input class="un " type="text" align="center" placeholder="Username"/>
            <input class="pass" type="password" align="center" placeholder="Password"/> 
            <a class="submit" align="center">Log in</a>
            <p class="forgot" align="center"><a href="#">Forgot your Password?</a></p>
       
    </div>

    </form>
</body>
</html>
