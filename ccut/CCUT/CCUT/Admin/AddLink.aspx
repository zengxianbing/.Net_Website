<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddLink.aspx.cs" Inherits="CCUT.Admin.AddLink" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>   <br /> <br />
     友情链接名：&nbsp; <asp:TextBox ID="TextBox1" runat="server" Height="18px" Width="152px"></asp:TextBox>  <br />   <br />
     友情链接地址：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>   <br />   <br />
       &nbsp; &nbsp; &nbsp; &nbsp; <asp:Button ID="Button1" runat="server" Text="添加" 
            onclick="Button1_Click" />
    </div>
    </form>
</body>
</html>
