<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LetterAdd.aspx.cs" Inherits="CCUT.Admin.LetterAdd1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div><div style="  font-size:25px;">专题添加</div> 
    <br />
     <br />
       专题名称
        <asp:TextBox ID="TextBox1" runat="server" Width="173px"></asp:TextBox>
      <br />
     <br />
     <br />
      <br />
        专题状态
        <asp:RadioButton ID="RadioButton1" runat="server" Text="专题已开始" 
            GroupName="letter" />&nbsp; &nbsp;&nbsp; &nbsp;<asp:RadioButton 
            ID="RadioButton2" runat="server" Text="专题已结束" GroupName="letter" />
          <br />
      <br />
       &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp; 
        <asp:Button ID="Button1" runat="server" Text="添加" onclick="Button1_Click" />
    </div>
    </form>
   
</body>
</html>
