<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Type.aspx.cs" Inherits="CCUT.Type" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div  id="container">
     <div><a href="Index.aspx">首页></a><asp:LinkButton ID="classname1" runat="server"></asp:LinkButton>>
    <asp:LinkButton ID="typename2" runat="server"></asp:LinkButton>
   </div>
  <div id="left" class="clearfix">
  <div id=" left_top" style=" width:100%;  ">
   <div class="sharp color1"    >
        <b class="b1"></b><b class="b2"></b><b class="b3"></b><b class="b4"></b> 
        <div class="content" > 
        <div style=" background:url(images/navbar.gif);width:100%;height:30px; text-align:center; vertical-align:bottom; font-size:20px; color:#8470FF; font-weight:bold;"> <asp:Label ID="classname" runat="server"></asp:Label></div>
      <div  class="padd">
       <asp:Repeater ID="typename" runat="server">
        <ItemTemplate>
         <table>
         <tr>
         <td class="typename">
            <img  src="images/33.gif" alt=""/><a  href="Type.aspx?typeid=<%#Eval("typeid")%>&&typename=<%#Eval("typename")%>"  ><%#Eval("typename")%></a><br />
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
                <div style=" background:url(images/navbar.gif);width:100%;height:30px; text-align:center; vertical-align:bottom; font-size:20px; color:#8470FF; font-weight:bold;">阅读排行榜 </div>
               <div class="padd" >
                <asp:Repeater ID="article1" runat="server"   >
               <ItemTemplate>
               <table><tr><td class="typename">
              <img  src="images/icon4.gif"  alt=""/> <a href='Article.aspx?articleid=<%#Eval("articleid") %>'><%#Eval("title").ToString().Length>25?Eval("title").ToString().Substring(0,25)+" ...":Eval("title").ToString() %>[<%#Eval("datetime")  %>](<%#Eval("hits") %>)</a><br />
                </td></tr></table>
               </ItemTemplate>
              </asp:Repeater>
              </div>
            </div>
       
        <b class="b5"></b><b class="b6"></b><b class="b7"></b><b class="b8"></b> 
         </div>   
    </div>
   
  </div>
 
 <div id="right" class="clearfix ">
 <div class="sharp color1">
   
        <b class="b1"></b><b class="b2"></b><b class="b3"></b><b class="b4"></b> 
        <div class="content" style=" padding:10px;  line-height:30px;">
          <div  class="righttypename"><asp:Label ID="typename1" runat="server" ></asp:Label></div>
        <asp:Repeater ID="article" runat="server" >
        <ItemTemplate>
             <img src="images/mbi_005.gif"  alt=""/><a href='Article.aspx?articleid=<%#Eval("articleid") %>'><%#Eval("title").ToString().Length>25?Eval("title").ToString().Substring(0,25)+" ...":Eval("title").ToString() %>[<%#Eval("datetime")  %>](<%#Eval("hits") %>)</a><br />
        </ItemTemplate>
        </asp:Repeater> 
         </div>
        <b class="b5"></b><b class="b6"></b><b class="b7"></b><b class="b8"></b>  
        </div>
 </div>
 </div>
</asp:Content>
