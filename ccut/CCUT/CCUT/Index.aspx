<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CCUT.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
ul,li{ list-style-type:none;}
#con{ width:800px; height:210px; margin: auto; position:relative;  background-color:#EEFAFF;
overflow:hidden;}
img{border:0px;}
#con ul{ position:absolute; margin:10px; top:0; left:0; padding:0;}
#con ul li{ width:100%;  border-bottom:1px #333333 dotted; padding:10px 0; overflow:inherit; }
#con ul li a{ float:left;   vertical-align:middle;}

body,div,ul,li { margin:0 auto; padding:0 auto;}
#slide { position:relative; width:802px; height:300px; padding:0px; } 
#pic_list { position:absolute; left:0; bottom:0; width:100%; list-style:none; overflow:hidden; z-index:2;} 
#pic_list li { float:left; width:100px; height:52px; padding-top:10px;}
#pic_list li img { position:absolute; top:18px; width:65px; height:35px; margin:0 20px; border:1px solid #fff; z-index:0} 
#this_pic { position:absolute; width:100%; height:100%; border:none;}
#transparence { position:absolute; left:0; bottom:0; width:100%; height:50px; border-top:1px solid #fff; background:#000; z-index:1;}  


</style>
<link href="css/tabbedContent.css" rel='stylesheet' type='text/css' />
<script type="text/javascript" language="javascript" src="Scripts/1.3.2.js"></script>
<script type="text/javascript" language="javascript" src="Scripts/1.5.3.ui.js"></script>
<script src="Scripts/tabbedContent.js" type="text/javascript"></script>

<script language="javascript"  type="text/javascript">
    $(function () {
        var scrtime;
        $("#con").hover(function () {
            clearInterval(scrtime);
        }, function () {
            scrtime = setInterval(function () {
                var $ul = $("#con ul");
                var liHeight = $ul.find("li:last").height();
                $ul.animate({ marginTop: liHeight + 40 + "px" }, 1000, function () {
                    $ul.find("li:last").prependTo($ul)
                    $ul.find("li:first").hide();
                    $ul.css({ marginTop: 0 });
                    $ul.find("li:first").fadeIn(1000);
                });
            }, 3000);
        }).trigger("mouseleave");
    });
</script>
<script type="text/javascript">
    var theInt = null;
    var curclicked = 0;

    $(function () {
        $('#transparence').css('opacity', '0.4');
        $('#pic_list img').css({ 'opacity': '0.6' });
        $('#pic_list img:eq(0)').css({ 'top': '0', 'opacity': '1' });
        t(0);
        $('#pic_list img').mouseover(function () {
            if ($('#this_pic').attr('src') == $(this).attr('src')) return;
            if (!$(this).is(':animated')) {
                t($('#pic_list img').index($(this)));
            }
        })
    })

    t = function (i) {
        clearInterval(theInt);
        if (typeof i != 'undefined')
            curclicked = i;
        $('#this_pic').fadeOut(0).fadeIn(500).attr('src', $('#pic_list img').eq(i).attr('src'));
        $('#this_a').attr('href', $('#pic_list img').eq(i).parents('a').attr('href'));
        $('#this_a').attr('title', $('#pic_list img').eq(i).parents('a').attr('title'));
        $('#pic_list img').eq(i).parents('li').nextAll('li').find('img').animate({ top: 18, opacity: 0.6 }, 500);
        $('#pic_list img').eq(i).parents('li').prevAll('li').find('img').animate({ top: 18, opacity: 0.6 }, 500);
        $('#pic_list img').eq(i).animate({ top: 0 }, 500).css('opacity', '1');
        theInt = setInterval(function () {
            i++;
            if (i > $('#pic_list img').length - 1) { i = 0 };
            $('#this_pic').fadeOut(0).fadeIn(500).attr('src', $('#pic_list img').eq(i).attr('src'));
            $('#this_a').attr('href', $('#pic_list img').eq(i).parents('a').attr('href'));
            $('#this_a').attr('title', $('#pic_list img').eq(i).parents('a').attr('title'));
            $('#pic_list img').eq(i).parents('li').nextAll('li').find('img').animate({ top: 18, opacity: 0.6 }, 500);
            $('#pic_list img').eq(i).parents('li').prevAll('li').find('img').animate({ top: 18, opacity: 0.6 }, 500);
            $('#pic_list img').eq(i).animate({ top: 0 }, 500).css('opacity', '1');
        }, 3000)
    }
</script>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div  id="container" style=" z-index:0; padding-top:20px; " >
 <div id="left"  class="clearfix"  >
  <div id=" left_top" style=" width:100%; ">
   <div class="sharp color1"    >
        <b class="b1"></b><b class="b2"></b><b class="b3"></b><b class="b4"></b> 
        <div class="content"> 
        <div   class="classname">热点专题</div>
       <div class="padd">
      <asp:Repeater ID="Letter" runat="server"   >
       <ItemTemplate>
       <table><tr><td class="typename">
       <img  src="images/icon2.gif"  alt=""/> <a href='Letter.aspx?lid=<%#Eval("lid")%>&&name=<%#Eval("name")%>'><%#Eval("name")%></a><br/>
        </td></tr></table>
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
                <div class="classname">友情链接 </div>
                <div class="padd">
                 <asp:Repeater  ID="linkname" runat="server">
                 <ItemTemplate>
                 <table>
                 <tr>
                 <td class="typename">
                 
                
                 <img  src="images/mbi_029.gif" alt=""/> <a href='<%#Eval("url")%>'> <%#Eval("linkname")%></a><br/>
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
  </div>
 
  <div id="right"  class="clearfix"  >
                

 <div id="right_top"  >
        <div class="sharp color1" style=" padding:0px;">
        <b class="b1"></b><b class="b3"></b><b class="b4"></b> 
         <div class="content"    style=" padding:0px;"> 
        <div id="slide" style=" z-index:0;">  
         <asp:Repeater ID="ImagesFirst" runat="server">
       <ItemTemplate>
       	<a href='Article.aspx?articleid=<%#Eval("articleid") %>' id="this_a"><img src='<%#Eval("path") %><%#Eval("name") %>' id="this_pic" alt="" /></a>
       </ItemTemplate>
       </asp:Repeater>
	     <ul id="pic_list" style=" text-align:left;">
    <asp:Repeater ID="repimages" runat="server" >
    <ItemTemplate>
    <li><a href='Article.aspx?articleid=<%#Eval("articleid") %>' ><img src='<%#Eval("path") %><%#Eval("name") %>' alt="" /></a></li>
    </ItemTemplate>
    </asp:Repeater>
	</ul>
	   <span id="transparence"></span>

        </div>
         </div> 
        <b class="b5"></b><b class="b6"></b><b class="b7"></b><b class="b8"></b> 
         
    </div>
    </div>
    <br />
<div id="right_bottom"  style=" margin:auto">
 <div class="sharp color1">
        <b class="b1"></b><b class="b2"></b><b class="b3"></b><b class="b4"></b> 
        <div class="content">  
            <div class='tabbed_content'>
               <div   id="con"  >
           
             <ul>

           <asp:Repeater ID="rep5" runat="server" onitemdatabound="rep5_ItemDataBound">
           <ItemTemplate>
           <li>
          
               <img src="images/mbi_005.gif" alt="" style=" float:left;" /><a href='Article.aspx?articleid=<%#Eval("articleid") %>'"> (<asp:Label ID="Label1" runat="server" Text="Label">&nbsp;&nbsp;</asp:Label>)<%#Eval("title").ToString().Length>25?Eval("title").ToString().Substring(0,25)+" ...":Eval("title").ToString() %>[<%#Eval("datetime")  %>](<%#Eval("hits") %>)</a><br />
          </li>
           </ItemTemplate>
           </asp:Repeater>
             </ul>
             </div>
            <div class='tabs' style="  font-size:25px;  text-align:center;  color:Black;">
						<div class='moving_bg'>
					  &nbsp;
                     </div>

					
                        
                        <asp:Repeater ID="classname" runat="server"  >
                        <ItemTemplate>
                        <span class='tab_item'>
							<%#Eval("classname") %>
						</span>
                        </ItemTemplate>
                        </asp:Repeater>
                       
					</div>
          

           <div class='slide_content'>						
						<div class='tabslider' style=" padding:0px;" >
						
							  <ul>
                              <asp:Repeater ID="rep1" runat="server" >
                              <ItemTemplate>
                              <li>
						       <img src="images/mbi_004.gif" alt="" /><a href='Article.aspx?articleid=<%#Eval("articleid") %>' ><%#Eval("title").ToString().Length>25?Eval("title").ToString().Substring(0,25)+" ...":Eval("title").ToString() %>[<%#Eval("datetime")  %>](<%#Eval("hits") %>)</a><br />
								</li>
                              </ItemTemplate>
                              </asp:Repeater>
							</ul>

                             <ul>
                              <asp:Repeater ID="rep2" runat="server" >
                              <ItemTemplate>
                              <li>
						       <img src="images/mbi_004.gif" alt="" /><a href='Article.aspx?articleid=<%#Eval("articleid") %>' ><%#Eval("title").ToString().Length>25?Eval("title").ToString().Substring(0,25)+" ...":Eval("title").ToString() %>[<%#Eval("datetime")  %>](<%#Eval("hits") %>)</a><br />
								</li>
                              </ItemTemplate>
                              </asp:Repeater>
							</ul>


                          <ul>
                              <asp:Repeater ID="rep3" runat="server" >
                              <ItemTemplate>
                              <li>
						     <img src="images/mbi_004.gif" alt="" />  <a href='Article.aspx?articleid=<%#Eval("articleid") %>' ><%#Eval("title").ToString().Length>25?Eval("title").ToString().Substring(0,25)+" ...":Eval("title").ToString() %>[<%#Eval("datetime")  %>](<%#Eval("hits") %>)</a><br />
								</li>
                              </ItemTemplate>
                              </asp:Repeater>
							</ul>
                              <ul>
                              <asp:Repeater ID="rep4" runat="server" >
                              <ItemTemplate>
                              <li>
						       <img src="images/mbi_004.gif" alt="" /><a href='Article.aspx?articleid=<%#Eval("articleid") %>' ><%#Eval("title").ToString().Length>25?Eval("title").ToString().Substring(0,25)+" ...":Eval("title").ToString() %>[<%#Eval("datetime")  %>](<%#Eval("hits") %>)</a><br />
								</li>
                              </ItemTemplate>
                              </asp:Repeater>
							</ul>
						</div>
						<br style='clear: both' />
					</div>
				
				
				
            </div>
        </div>
        <b class="b5"></b><b class="b6"></b><b class="b7"></b><b class="b8"></b>    
    </div>

  </div>
 
  	
				
			
				
                
                
                
                
                
				
				
  </div>

 </div>

</asp:Content>
