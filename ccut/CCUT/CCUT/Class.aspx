<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Class.aspx.cs" Inherits="CCUT.Class" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div  id="container">
        <div>当前位置：<a href="Index.aspx">首页</a>><asp:LinkButton ID="LinkButton1" runat="server"></asp:LinkButton> </div>

 <div id="left"  class="clearfix">
  <div id=" left_top" style=" width:100%;  ">
   <div class="sharp color1"    >
        <b class="b1"></b><b class="b2"></b><b class="b3"></b><b class="b4"></b> 
        <div class="content" > 
        <div class="classname"> <asp:Label ID="classname" runat="server"></asp:Label></div>
      <div class="padd" >
       <asp:Repeater ID="typename" runat="server">
        <ItemTemplate>
         <table>
         <tr>
         <td class="typename">
         <img  src="images/33.gif" alt=""/>  <a href="Type.aspx?typeid=<%#Eval("typeid")%>&&typename=<%#Eval("typename")%>" > <%#Eval("typename") %></a><br/>
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
                <div   class="classname">热点专题 </div>
               <div  class="padd">
                <asp:Repeater ID="Letter" runat="server"   >
               <ItemTemplate>
               <table><tr><td class="typename">
                <img  src="images/icon2.gif"  alt=""/><a href='Letter.aspx?lid=<%#Eval("lid")%>&&name=<%#Eval("name")%>'><%#Eval("name")%></a><br/>
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
            <asp:Repeater  ID="typename1" runat="server"  onitemdatabound="typename1_ItemDataBound"    >
            <ItemTemplate>
              <div class="sharp color1">
              <b class="b1"></b><b class="b2"></b><b class="b3"></b><b class="b4"></b> 
             <div class="content" style="  font-size:large; line-height:30px;">  
             <div  class="padd">
               <img  src="images/33.gif" alt=""/><a  href="Type.aspx?typeid=<%#Eval("typeid")%>&&typename=<%#Eval("typename")%>"  class="righttypename" style=" color:Black " ><%#Eval("typename")%></a> <asp:HiddenField  ID="typeid" runat="server" Value='<%#Eval("typeid") %>'/><br />
             
              <asp:Repeater ID="article" runat="server">
              <ItemTemplate>
              <img src="images/mbi_005.gif"  alt=""/><a href='Article.aspx?articleid=<%#Eval("articleid") %>' ><%#Eval("title").ToString().Length>25?Eval("title").ToString().Substring(0,25)+" ...":Eval("title").ToString() %>[<%#Eval("datetime")  %>](<%#Eval("hits") %>)</a><br />
               
              </ItemTemplate>
              </asp:Repeater>
              </div>
              </div>
                 <b class="b5"></b><b class="b6"></b><b class="b7"></b><b class="b8"></b>    
        </div>
      
           <br />
           <br />
            </ItemTemplate>
            </asp:Repeater>
        
        </div>
        
    

 </div>


    
</asp:Content>
