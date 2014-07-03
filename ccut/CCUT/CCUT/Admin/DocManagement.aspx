<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DocManagement.aspx.cs" Inherits="CCUT.Admin.DocManagement" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
  <div id="grobal" runat="server" style=" float:left; width:695px;">
    <div id="lable" runat="server" style="width:695px;">         
    <span><font size="3" ><b>附件管理</b></font></span>
    </div>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" PageSize="16"
                  AutoGenerateColumns="False" Width="590px" CellPadding="4" 
        ForeColor="#333333" GridLines="None" 
            onrowdatabound="GridView1_RowDataBound" EnableModelValidation="True" 
          Height="139px"   >
      <Columns>
        <asp:BoundField DataField="newstitle" HeaderText="新闻标题" />
        <asp:BoundField DataField="downname"  HeaderText="附件管理" />
        <asp:BoundField DataField="downtime" HeaderText="上传时间" />
        <asp:TemplateField>
          <ItemTemplate>
              <asp:CheckBox ID="CheckBox1" runat="server" />
          </ItemTemplate>
        </asp:TemplateField>
      </Columns>  
        <EditRowStyle BackColor="#2461BF" />
      <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />    
    
         
      <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
      <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
      <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"  />
      <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
     <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="true"
                  FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页"
                  ShowInputBox="Always" onpagechanged="AspNetPager1_PageChanged">
          </webdiyer:AspNetPager>
    
    <div id="foot" runat="server">        
        <asp:CheckBox ID="Check" runat="server" Text="全选"  AutoPostBack="true" 
            oncheckedchanged="Check_CheckedChanged" />&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="But" runat="server" Text="删除" onclick="But_Click"   />
    </div> 
  </div>
    </form>
</body>
</html>
