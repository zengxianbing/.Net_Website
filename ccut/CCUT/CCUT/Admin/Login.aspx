<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CCUT.Admin.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <link  type="text/css" href="images/public.css" rel="Stylesheet" />
    <link  type="text/css" href="images/login.css" rel="Stylesheet"/>
  <META content="MSHTML 6.00.2900.5848" name=GENERATOR> 
</head>
<body>
    
<form id="form1" runat="server">
<DIV id="div1" >
  <TABLE id="login" height="760px" cellSpacing="0" cellPadding="0" width="800"  
align=center>
    <TBODY>
      <TR id="main">
        <TD>
          <TABLE height="100%" cellSpacing="0" cellPadding="0" width="100%">
            <TBODY>
              <TR>
                <TD colSpan="4">&nbsp;</TD>
              </TR>
              <TR height="30">
                <TD width="380">&nbsp;</TD>
                <TD>&nbsp;</TD>
                <TD>&nbsp;</TD>
                <TD>&nbsp;</TD>
              </TR>
              <TR height="40">
                <TD rowSpan="4">&nbsp;</TD>
                <TD>用户名：</TD>
                <TD>
                    <asp:TextBox ID="TextBoxusername" runat="server"></asp:TextBox>
                </TD>
                <TD width="120">&nbsp;</TD>
              </TR>
              <TR height="40">
                <TD>密　码：</TD>
                <TD>
                    <asp:TextBox ID="TextBoxpassword" runat="server" TextMode="Password" 
                        Width="145px"></asp:TextBox>
                </TD>
                <TD width="120">&nbsp;</TD>
              </TR>
             
              <TR height="40">
                <TD></TD>
                <TD align="center">
                    <asp:Button ID="Buttonlogin" runat="server" Text="登录" 
                        onclick="Buttonlogin_Click" />
                </TD>
                <TD width="120">&nbsp;</TD>
              </TR>
              <TR height="110">
                <TD colSpan=4>&nbsp;</TD>
              </TR>
            </TBODY>
          </TABLE>
        </TD>
      </TR>
      <TR id="root" height="104">
        <TD>&nbsp;</TD>
      </TR>
    </TBODY>
  </TABLE>
</DIV>
<DIV id="div2" style="DISPLAY: none"></DIV>




</form> 
</body>
</html>
