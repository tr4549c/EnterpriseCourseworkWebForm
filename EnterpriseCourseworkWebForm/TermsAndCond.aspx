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
                        
                        <asp:Label ID="Label8" runat="server" class="TermConLable1" style="padding-left:2.5%" Text =" Please read terms and conditions before you can proceed!"></asp:Label>
                               
                         <br /><br />

                         <%--<asp:TextBox ID="TextBoxIdeaInput" runat="server" BackColor="White" CssClass="SubmitIdeaTextBox" Font-Italic="True" Font-Names="Work Sans" ForeColor="#060360" TextMode="MultiLine"></asp:TextBox>--%>
                         <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi. Nulla quis sem at nibh elementum imperdiet. Duis sagittis ipsum. Praesent mauris. Fusce nec tellus sed augue semper porta. Mauris massa. Vestibulum lacinia arcu eget nulla. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Curabitur sodales ligula in libero. </p>

<p>Sed dignissim lacinia nunc. Curabitur tortor. Pellentesque nibh. Aenean quam. In scelerisque sem at dolor. Maecenas mattis. Sed convallis tristique sem. Proin ut ligula vel nunc egestas porttitor. Morbi lectus risus, iaculis vel, suscipit quis, luctus non, massa. Fusce ac turpis quis ligula lacinia aliquet. Mauris ipsum. Nulla metus metus, ullamcorper vel, tincidunt sed, euismod in, nibh. Quisque volutpat condimentum velit. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. </p>

<p>Nam nec ante. <i>Curabitur tortor</i>. Sed lacinia, urna non tincidunt mattis, tortor neque adipiscing diam, a cursus ipsum ante quis turpis. Nulla facilisi. Ut fringilla. Suspendisse potenti. Nunc feugiat mi a tellus consequat imperdiet. Vestibulum sapien. Proin quam. Etiam ultrices. Suspendisse in justo eu magna luctus suscipit. Sed lectus. Integer euismod lacus luctus magna. Quisque cursus, metus vitae pharetra auctor, sem massa mattis sem, at interdum magna augue eget diam. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Morbi lacinia molestie dui. </p>

<p>Praesent blandit dolor. Sed non quam. In vel mi sit amet augue congue elementum. Morbi in ipsum sit amet pede facilisis laoreet. Donec lacus nunc, viverra nec, blandit vel, egestas et, augue. Vestibulum tincidunt malesuada tellus. Ut ultrices ultrices enim. Curabitur sit amet mauris. Morbi in dui quis est pulvinar ullamcorper. Nulla facilisi. Integer lacinia sollicitudin massa. </p>

<p>Cras metus. Sed aliquet risus a tortor. Integer id quam. Morbi mi. Quisque nisl felis, venenatis tristique, dignissim in, ultrices sit amet, augue. Proin sodales libero eget ante. Nulla quam. Aenean laoreet. Vestibulum nisi lectus, commodo ac, facilisis ac, ultricies eu, pede. Ut orci risus, accumsan porttitor, cursus quis, aliquet eget, justo. Sed pretium blandit orci. Ut eu diam at pede suscipit sodales. Aenean lectus elit, fermentum non, convallis id, sagittis at, neque. Nullam mauris orci, aliquet et, iaculis et, viverra vitae, ligula. </p>

 
                        <br />
                        
                       
                        <%--<asp:CheckBox ID="CheckBox1" runat="server" />--%>
                        <br /><br />
                        <br />
                        

                     </asp:Panel>  

        </div>
    </form>
</body>
</html>
