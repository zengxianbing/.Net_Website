<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManaClass.aspx.cs" Inherits="CCUT.Admin.ManaClass" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>管理菜单</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <asp:GridView ID="GridView1" runat="server" CellPadding="4" 
            EnableModelValidation="True" ForeColor="#333333" GridLines="None" 
            Height="265px" Width="395px" AutoGenerateColumns="False" 
            onrowdatabound="GridView1_RowDataBound">
           <AlternatingRowStyle BackColor="White" />
           <Columns>
               <asp:BoundField DataField="classname" HeaderText="大类名称" />
               <asp:TemplateField>
              <ItemTemplate>
                  <asp:CheckBox ID="CheckBox2" runat="server" />
              </ItemTemplate>
               </asp:TemplateField>
           </Columns>
           <EditRowStyle BackColor="#2461BF" />
           <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
           <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
           <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
           <RowStyle BackColor="#EFF3FB" />
           <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
       
       </asp:GridView> <br />
        &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
        <asp:CheckBox ID="Check" runat="server" 
            oncheckedchanged="CheckBox1_CheckedChanged" Text="全选" 
            AutoPostBack="True" /> &nbsp; &nbsp; &nbsp; &nbsp;  
        <asp:Button ID="Button1" runat="server" Text="删除" onclick="Button1_Click" />
    </div>
    </form>
</body>
</html>
