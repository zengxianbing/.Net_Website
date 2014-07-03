<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Letter.aspx.cs" Inherits="CCUT.Letter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div  id="container"><div>首页><asp:LinkButton ID="Letter3" runat="server"></asp:LinkButton> </div>
 <div id="left"  class="clearfix">
  <div id="left_top">
   <div class="sharp color1">
        <b class="b1"></b><b class="b2"></b><b class="b3"></b><b class="b4"></b> 
        <div class="content"> 
               <div style=" background:url(images/navbar.gif);width:100%;height:30px; text-align:center; vertical-align:bottom; font-size:20px; color:#8470FF; font-weight:bold;">热点专题 </div>
               <div  class="padd">
                <asp:Repeater ID="letter" runat="server"   >
               <ItemTemplate>
               <table><tr><td class="typename">
               <img  src="images/icon2.gif"  alt=""/> <a href="#<%#Eval("lid")%>"><%#Eval("name")%></a><br/>
                </td></tr></table>
               </ItemTemplate>
              </asp:Repeater>
              </div>
            </div>
       
        <b class="b5"></b><b class="b6"></b><b class="b7"></b><b class="b8"></b> 
         </div>   
    </div>
   
  </div>

 <div id="right"  class="clearfix">
   <asp:Repeater ID="letter1" runat="server" 
         onitemdatabound="letter1_ItemDataBound" >
    <ItemTemplate>
     <div class="sharp color1">
        <b class="b1"></b><b class="b2"></b><b class="b3"></b><b class="b4"></b> 
        <div class="content">  
        <div class="padd">
         <img  src="images/icon2.gif"  alt=""/> <a id="<%#Eval("lid")%>" style=" list-style-type:none;"><%#Eval("name")%> </a><asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval("lid") %>' />
            <br/>
       <asp:Repeater ID="letterarticle" runat="server" >
       <ItemTemplate>
       <table>
       <tr>
       <td class="typename">
     
         <img src="images/mbi_005.gif"  alt=""/> <a href="LetterArticle.aspx?id=<%#Eval("id")%>"><%#Eval("title").ToString().Length>25?Eval("title").ToString().Substring(0,25)+" ...":Eval("title").ToString() %></a><br />
          </td>
       </tr>
       </table>
       </ItemTemplate>
       </asp:Repeater>
       </div>
        <b class="b5"></b><b class="b6"></b><b class="b7"></b><b class="b8"></b> 
        </div>   
    </div>
    <br />
    <br />
    </ItemTemplate>
   </asp:Repeater>
 </div></div>
</asp:Content>
