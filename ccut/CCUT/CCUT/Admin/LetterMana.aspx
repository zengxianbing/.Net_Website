<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LetterMana.aspx.cs" Inherits="CCUT.Admin.LetterMana" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div style=" font-size:25px;">专题管理</div>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" 
            EnableModelValidation="True" ForeColor="#333333" GridLines="None" 
            Height="275px" Width="480px" AutoGenerateColumns="False" 
            onrowdatabound="GridView1_RowDataBound">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            
            <Columns>
            <asp:BoundField DataField="name" HeaderText="专题名" />
            <asp:BoundField DataField="status" HeaderText="状态" />
            <asp:TemplateField>
            <ItemTemplate>
             <asp:CheckBox ID="CheckBox1" runat="server"  />
             </ItemTemplate>
            </asp:TemplateField>
            </Columns>
        </asp:GridView>
          <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="true"
                  FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页"
                  ShowInputBox="Always" onpagechanged="AspNetPager1_PageChanged" >
          </webdiyer:AspNetPager><br /><br />
        <asp:CheckBox ID="CheckBox2" runat="server" 
            oncheckedchanged="CheckBox2_CheckedChanged" Text="全选"  AutoPostBack="true"/>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="删除" onclick="Button1_Click" 
            Width="41px" />
    </div>
    </form>
</body>
</html>
