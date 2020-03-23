<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ideaBox.aspx.cs" Inherits="EnterpriseCourseworkWebForm.ideaBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
.IdeaTextLable{
    font-family: 'Work Sans', sans-serif;
    font-size: 16px;
    color:#060360;
    text-align: left;
}
.IdeaContainer{
    background-color: #ffffff;
    margin-top: 13px;
    margin-left: 10px;
    Height: 400px;
    
}
.ThumbsUpBtn{
float:left;
}
.ThumbsDwnBtn{
float:right;
}
.PanelTuTdButtons{
    Height:316px;
    Width:311px;
}
.row {
    margin: auto auto auto auto;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <div>
                         <asp:Panel ID="Panel1" CssClass="IdeaContainer" runat="server" >
                        <textarea id="TextAreaIdeaDispl" rows="2" style="font-family: 'Work Sans'; font-size: small; text-align: left; word-spacing: normal; letter-spacing: normal; width: 1002px; height: 150px"></textarea>
                        
                             <asp:Label ID="label1" runat="server" cssclass="ideatextlable" text="label"></asp:Label>
                     <asp:Panel ID="Panel2" runat="server" Height="215px" style="margin-left: 2359px">
                         <div class="row">
            <asp:ImageButton ID="ImageButtonThumbsUp" CssClass="ThumbsUpBtn" runat="server" Height="116px" Width="111px" ImageUrl="~/Images/thumbs up.png" />
            <asp:ImageButton ID="ImageButtonThumbsDwn" CssClass="ThumbsDwnBtn" runat="server" Height="116px" Width="111px" ImageUrl="~/Images/thumbs down.png" /> </div>
            <asp:Label ID="LblTumbUpNumber" CssClass="ThumbsUpBtn" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="LblTumbDwnNumber" CssClass="ThumbsDwnBtn" runat="server" Text="Label"></asp:Label>
        </asp:Panel>
                        </asp:Panel>



        </div>
        
    </form>
</body>
</html>
