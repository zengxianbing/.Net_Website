<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Article.aspx.cs" Inherits="CCUT.Article" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div  id="container">
    <div>当前位置：<a href="Index.aspx">首页</a>><asp:LinkButton ID="classname1" runat="server"></asp:LinkButton>><asp:LinkButton
    ID="typename1" runat="server"></asp:LinkButton></div>
 <div id="left"    class="clearfix" >
  <div id=" left_top" style=" width:100%; ">
   <div class="sharp color1"    >
        <b class="b1"></b><b class="b2"></b><b class="b3"></b><b class="b4"></b> 
        <div class="content"> 
        <div  class="classname">最新新闻列表</div>
      <div class="padd">
      <asp:Repeater ID="lastnews" runat="server">
        <ItemTemplate>
         <table>
         <tr>
         <td class="typename" >
            <img  src="images/21.gif" alt=""/> <a href='Article.aspx?articleid=<%#Eval("articleid") %>' ><%#Eval("title").ToString().Length>25?Eval("title").ToString().Substring(0,25)+" ...":Eval("title").ToString() %>[<%#Eval("datetime")  %>](<%#Eval("hits") %>)</a><br />
         </td>
         </tr>
         </table>
        </ItemTemplate>
       </asp:Repeater>
       </div>
            </div>
      
        <b class="b5"></b><b class="b6"></b><b class="b7"></b><b class="b8"></b>   
         </div>  
    </div>
    <br />
 
  
  <div id="left_bottom">
   <div class="sharp color1">
        <b class="b1"></b><b class="b2"></b><b class="b3"></b><b class="b4"></b> 
        <div class="content"> 
                <div  class="classname">热点专题 </div>
               <div class="padd">
               <asp:Repeater ID="Letter" runat="server"   >
               <ItemTemplate>
               <table><tr><td class="typename">
               <img  src="images/icon2.gif"  alt=""/><a href='Letter.aspx?lid="+<%#Eval("lid")%>+"&&name="+<%#Eval("name")%>'><%#Eval("name")%></a><br/>
                </td></tr></table>
               </ItemTemplate>
              </asp:Repeater>
           </div>
            </div>
       
        <b class="b5"></b><b class="b6"></b><b class="b7"></b><b class="b8"></b>    
         </div>
    </div>
  </div>

 <div id="right" class="clearfix">
       <div class="sharp color1">
        <b class="b1"></b><b class="b2"></b><b class="b3"></b><b class="b4"></b> 
        <div class="content"  style="text-align:center; ">  
         <asp:Repeater ID="content" runat="server">
         <ItemTemplate>
          <%#Eval("content") %>
         </ItemTemplate>
         </asp:Repeater> 
         <br /> <br/>
      
         附件：
        <asp:Label ID="Label1" runat="server" ></asp:Label>
         <asp:Repeater ID="repupload" runat="server" >
           <ItemTemplate> 
           <asp:Label ID="Label2" runat="server" ><%#Eval("newstitle")%></asp:Label>
             <a href="Down.aspx?downid=<%#Eval("downid") %>"><%#Eval("downname") %>【<%#Eval("downcount")%>】</a><img  src="images/mbi_001.gif"/><br />
           </ItemTemplate>
         </asp:Repeater>           
        </div>
       
     
        <b class="b5"></b><b class="b6"></b><b class="b7"></b><b class="b8"></b>    
    
    </div>
 </div>
 </div>
   
</asp:Content>
