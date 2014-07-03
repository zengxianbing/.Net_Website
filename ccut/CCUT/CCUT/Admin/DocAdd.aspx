<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DocAdd.aspx.cs" Inherits="CCUT.Admin.DocAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <br /><br /><br /><br />
<table style=" margin:auto; line-height:40px;">
     <tr style=" text-align:left; background-image:url('../Image/030.gif')">
       <td>
         <span><font size="3" ><b>附件添加</b></font></span>
       </td>
     </tr>
     <tr>
       <td>
         新闻标题：<asp:TextBox ID="TextBox1" runat="server" Width="379px" ></asp:TextBox>
       </td>
     </tr>
     <tr>
       <td>
         上传附件：<asp:FileUpload ID="FileUpload1" runat="server" Width="385px" />  
       </td>
     </tr>
     <tr>
       <td>
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button2" runat="server" Text="确定" onclick="Button2_Click" />
       </td>
     </tr>
   </table>
    </form>
</body>
</html>
