﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LetterArticleAdd.aspx.cs" Inherits="CCUT.Admin.LetterAdd" validateRequest="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <link rel="stylesheet" href="../kindeditor/themes/default/default.css" />
	<link rel="stylesheet" href="../kindeditor/plugins/code/prettify.css"/>
	<script charset="utf-8" src="../kindeditor/kindeditor.js"></script>
	<script charset="utf-8" src="../kindeditor/lang/zh_CN.js"></script>
	<script charset="utf-8" src="../kindeditor/plugins/code/prettify.js"></script>
	<script>
	    KindEditor.ready(function (K) {
	        var editor1 = K.create('#content1', {
	            cssPath: '../kindeditor/plugins/code/prettify.css',
	            uploadJson: '../kindeditor/asp.net/upload_json.ashx',
	            fileManagerJson: '../kindeditor/asp.net/file_manager_json.ashx',
	            allowFileManager: true,
	            afterCreate: function () {
	                //	                var self = this;
	                //	                K.ctrl(document, 13, function () {
	                //	                    self.sync();
	                //	                    K('form[name=example]')[0].submit();
	                //	                });
	                //	                K.ctrl(self.edit.doc, 13, function () {
	                //	                    self.sync();
	                //	                    K('form[name=example]')[0].submit();                });
	            }
	        });
	        prettyPrint();
	    });
	</script>
</head>
<body>
    <form id="form1" runat="server">
   <div id="grobal" runat="server" style="float:left;">
     <table style="background-color:#F7FAFF;width:695px; text-align:left;" >
          <tr id="head" style=" background-image:url('../Image/030.jpg')">
            <td>
              <span><font size="2"><b>专题新闻</b></font></span>
            </td>
          </tr>
          <tr id="FL">
            <td>
                <asp:Label ID="Label1" runat="server" Text="所属专题:"></asp:Label>&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server"   >
                <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
          </tr>
          <tr style="background-color:#EDF2F8;"><td><br /></td></tr>
         
          <tr id="NRBT">
            <td>
                <asp:Label ID="Label3" runat="server" Text="文章标题"></asp:Label>&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" Width="300px"></asp:TextBox><br />
            </td>
          </tr>
          <tr style="background-color:#EDF2F8;"><td><br /></td></tr>     
          <tr id="NRBJ">
            <td>
              内容编辑:<br />
                  <textarea id="content1"  cols="100" rows="8" style="width:700px;height:200px;visibility:hidden;" runat="server"></textarea>

            </td>
          </tr> 
          <tr style="text-align:center;">
            <td>
              <asp:Button ID="but" runat="server" Text="提交" onclick="but_Click" /><br />
            </td>
          </tr>
        </table>
</div>
    </form>
</body>
</html>
