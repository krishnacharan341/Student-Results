<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Student_Results.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align:center; color:darkblue;">Show Student Result</h1>
            <hr />
            <center>
                <b> Enter Student Roll Number:</b>&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" Height="30px" Width="180px" BorderColor="Black"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Show Result" BackColor="#990000" BorderColor="White"
                    Font-Bold="True" Font-Size="18pt" ForeColor="White" Height="35px" Width="185px" OnClick="Button1_Click" CssClass="auto-style1" />
                <br />
            </center>
        </div>
    </form>
</body>
</html>
