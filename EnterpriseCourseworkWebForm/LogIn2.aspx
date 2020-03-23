<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn2.aspx.cs" Inherits="EnterpriseCourseworkWebForm.LogIn2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
body, html {
  height: 100%;
  font-family: 'Work Sans';
  
  /* The image used */
  background-image: url("https://www.gre.ac.uk/__data/assets/image/0018/1138113/varieties/v1200.jpg");
   
  /* Center and scale the image nicely */
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
  position: relative;
}

* {
  box-sizing: border-box;
}
.logo{
    display:block;
    max-width:80%;

}
.bg-img {
 
  min-height: 380px;

}
/*.bg-img .container-top{}*/
 
 
/* Add styles to the form container */
.container {
  position:absolute;
  right: 20%;
  min-width: 90px; /*t give the page a scroll bar left and right*/
  margin: 20px;
  max-width: 300px;
  padding: 16px;
  background-color: white;
}

/* Full-width input fields */
input[type=text], input[type=password] {
  width: 100%;
  padding: 15px;
  margin: 5px 0 22px 0;
  border: none;
  background: #f1f1f1;
}

input[type=text]:focus, input[type=password]:focus {
  background-color: #ddd;
  outline: none;
}

/* Set a style for the submit button */
.btn {
  background-color: #606EB2;
  color: white;
  float:right;
  padding: 16px 20px;
  border: none;
  cursor: pointer;
  width: 30%;
  opacity: 0.9;
  text-align:center;
 font-weight:bold;
}

.btn:hover {
  opacity: 1;
}
</style>
</head>
<body>
    <form id="form1" runat="server">
 
<div class="bg-img">
   
  <div class="container">
      <img class="logo" src="Images/u18.png" />
      
    <%--<input type="text" placeholder="Enter Username" name="username" required/>--%>
      <asp:TextBox ID="TextBox1" placeholder="Enter username..." runat="server"></asp:TextBox>
      <asp:RequiredFieldValidator ID="r1" runat="server" ErrorMessage="This field is required..." ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
    <%--<input type="password" placeholder="Enter Password" name="psw" required/>--%>
      <asp:TextBox ID="TextBox2" placeholder="Enter password..." TextMode="Password" runat="server"></asp:TextBox>

      <asp:Button ID="loginB" runat="server" CssClass="btn" OnClick="loginB_Click" Text="Login" />
      
    <%--<button< type="submit" class="btn">Log In</button>--%>
      <a href=".." class="resetPasswordClass" ">Reset Password ?</a>
    </div>
  
</div>

    </form>
</body>
</html>
