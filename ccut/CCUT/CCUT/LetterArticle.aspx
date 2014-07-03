<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="LetterArticle.aspx.cs" Inherits="CCUT.LetterArticle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div  id="container">
  当前位置:<a href="Index.aspx">首页</a>><asp:LinkButton ID="LinkButton1" runat="server"></asp:LinkButton>><asp:LinkButton
      ID="LinkButton2" runat="server"></asp:LinkButton>
 <div id="left"  class="clearfix"  >
  <div id=" left_top" style=" width:100%; ">
   <div class="sharp color1"    >
        <b class="b1"></b><b class="b2"></b><b class="b3"></b><b class="b4"></b> 
        <div class="content"> 
        <div   class="classname">
            <asp:Label ID="Label1" runat="server" ></asp:Label></div>
       <div class="padd">

           
      <asp:Repeater ID="title" runat="server"   >
       <ItemTemplate>
       <table><tr><td class="typename">
         <a href='LetterArticle.aspx?id=<%#Eval("id") %>'><%#Eval("title")%></a><br/>
        </td></tr></table>
       </ItemTemplate>
      </asp:Repeater>
       </div>
            
        </div>
        <b class="b5"></b><b class="b6"></b><b class="b7"></b><b class="b8"></b>    
    </div>
    </div>
  </div>
 
  <div id="right"  class="clearfix"  >
       <div class="sharp color1">
        <b class="b1"></b><b class="b2"></b><b class="b3"></b><b class="b4"></b> 
        <div class="content">  
        <asp:Repeater ID="content" runat="server" >
              <ItemTemplate>
               <%#Eval("content") %>
              </ItemTemplate>
              </asp:Repeater>
        </div>
        <b class="b5"></b><b class="b6"></b><b class="b7"></b><b class="b8"></b>    
    </div>
          

 </div>
        
    </div>

</asp:Content>
