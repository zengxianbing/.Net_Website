<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImageNews.aspx.cs" Inherits="CCUT.Admin.ImageNews" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     
</head>
<body>
    <form id="form1" runat="server">
    <div id="grobal" runat="server">
      <br /><br /><br /><br />
    <table style="width:575px; text-align:left; height: 266px;">
      <tr style=" background-image:url('../Image/030.gif');">
        <td>
          <span><font size="3" ><b>添加图片新闻</b></font></span></td>
      </tr>
      <tr>
        <td>
          请输入图片新闻的上传顺序：<asp:TextBox ID="TextBox1" runat="server" Width="24px" 
                Height="21px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;
          <font size="2" color="red">*注意：所输入的数字越小越靠前，并且最多只能添加8张图片</font>
        </td>
      </tr>
      <tr>
        <td>
          新闻标题：<asp:TextBox ID="TextBox2" runat="server" Width="274px"></asp:TextBox>
        </td>
      </tr>
      <tr>
        <td>
          上传图片：<asp:FileUpload ID="FileUpload1" runat="server" Width="271px" />  <!--FileUpload上传控件-->
        </td>
      </tr>
      <tr>
        <td style="text-align:center;">
            <asp:Button ID="Button1" runat="server" Text="提交" onclick="Button1_Click"/>
        </td>
      </tr>
    </table>
  </div>
    </form>
</body>
</html>
