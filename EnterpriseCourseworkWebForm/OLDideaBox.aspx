<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OLDideaBox.aspx.cs" Inherits="EnterpriseCourseworkWebForm.ideaBox" %>

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
    Height: 95px;
    
}
.ThumbsUpBtn{
float:left;
}
.ThumbsDwnBtn{
float:right;
}
.PanelTuTdButtons{
    Height:55px;
    Width:20%;
}
.row {
    margin: auto auto auto auto;
}
.LblTumbUpNumber{
font-family: 'Work Sans', sans-serif;
    font-size: 16px;
    color:#060360;
}

.LblTumbDwnNumber{
    font-family: 'Work Sans', sans-serif;
    font-size: 16px;
    color:#060360;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <div>
                         <asp:Panel ID="Panel1" CssClass="IdeaContainer" runat="server" >
                        

                        
                             <asp:Label ID="label1" runat="server" cssclass="ideatextlable" text="label"></asp:Label>
                     <asp:Panel ID="Panel2" runat="server" Height="80px" Width="80px" style="margin-left: 339px">
                         <div class="row">
            <asp:ImageButton ID="ImageButtonThumbsUp" CssClass="ThumbsUpBtn" runat="server" Height="40px" Width="40px" ImageUrl="~/Images/thumbs up.png" />
            <asp:ImageButton ID="ImageButtonThumbsDwn" CssClass="ThumbsDwnBtn" runat="server" Height="40px" Width="40px" ImageUrl="~/Images/thumbs down.png" /> </div>
                         <div class="row">
                            <asp:Label ID="LblTumbUpNumber" CssClass="LblTumbUpNumber" runat="server" Text="Labl"></asp:Label>
                            <asp:Label ID="LblTumbDwnNumber" CssClass="LblTumbDwnNumber" runat="server" Text="Labl"></asp:Label>
                         </div>
            <%--<asp:Label ID="LblTumbUpNumber" CssClass="ThumbsUpBtn" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="LblTumbDwnNumber" CssClass="ThumbsDwnBtn" runat="server" Text="Label"></asp:Label>--%>
        </asp:Panel>
                        </asp:Panel>



        </div>
        
    </form>
</body>
</html>
