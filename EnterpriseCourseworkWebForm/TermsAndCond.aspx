<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TermsAndCond.aspx.cs" Inherits="EnterpriseCourseworkWebForm.TermsAndCond" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
.TermConPanel{
    background-color: #F2F2F2;
    margin-left: 10px;
    Height: 30%;
    width:50%;
    text-align:left;
    /*padding-top:5%;*/
    padding-left:5px;
    padding-bottom:5px;
}

.TextArea {
        width:99%;
        height:300px;
    }
.TermConLable1{
    font-family: 'Work Sans', sans-serif;
    font-size: 18px;
    color:#060360;
    text-align: left;
}
.TermConTextLableH2{
padding-left:2.5%; 
font-size:23px; 
font-weight:900; 
font-family:Antonio; 
padding-left:3%; 
padding-top:3%;
color: #060360;

}
.btnSubmitIdea{
  background-color: #060360;
  color: white;
  float:right;
  padding: 16px 20px;
  border: none;
  cursor: pointer;
  width: 20%;
  opacity: 0.9;
  text-align:center;
  font-family:'Work Sans';
 font-weight:bold;
 margin-right:3%;
 margin-bottom:5%;
}
.CheckBoxTermCon{
    font-family:'Work Sans';
    font-size: 18px;
    text-align :Right;
    padding-left:35%;
    color:#060360;
}

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Panel ID="Panel1" CssClass="TermConPanel" runat="server" >
                         
               
                      <%--<asp:TextBox ID="TextBox1" CssClass="TextArea" runat="server"></asp:TextBox>--%>
                          
                      <%--  <h2 style="color: #060360; float:left; font-family:Antonio; padding-left:3%; width: 657px;">Idea- Submitting</h2>--%>
                        <asp:Label ID="LabelTermandCon" runat="server" class="TermConTextLableH2" style="" Text ="Terms and Conditions"></asp:Label>
                        <br /><br />
                        
                        <asp:Label ID="Label8" runat="server" class="TermConLable1" style="padding-left:2.5%" Text =" Please read terms and conditons and tick agree before you can proceec!"></asp:Label>
                               
                         <br /><br />
                         <%--<asp:TextBox ID="TextBoxIdeaInput" runat="server" BackColor="White" CssClass="SubmitIdeaTextBox" Font-Italic="True" Font-Names="Work Sans" ForeColor="#060360" TextMode="MultiLine"></asp:TextBox>--%>
                         <asp:TextBox ID="TextBoxTermCon" CssClass="TextArea"  runat="server" ReadOnly="True"></asp:TextBox> 
                        <br />
                        
                       
                        <%--<asp:CheckBox ID="CheckBox1" runat="server" />--%>
                        <br /><br />
                        <br />
                        <div class="row">
                        <asp:CheckBox id="checkbox1" CssClass="CheckBoxTermCon" runat="server" AutoPostBack="True" Text="I Agree, to Terms and Conditons" TextAlign="Right"/> <%-- OnCheckedChanged="Check_Clicked--%>

                        <%--<asp:Button ID="Button2"  CssClass="btnSubmitIdea" runat="server" Text="Submit" />--%>

                        </div>
                        

                     </asp:Panel>  

        </div>
    </form>
</body>
</html>
