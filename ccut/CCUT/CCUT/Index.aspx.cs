using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;
namespace CCUT
{
    public partial class Index : System.Web.UI.Page
    {
        Bll.BLLindex index = new Bll.BLLindex();
        int i = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                bingLetter();
                binglinkname();
                bingimages();
                bingindexclassname();
                bingclassarticle();
                dtfocusnews();
            }
        }
        private void bingLetter()//绑定专题链接
        {
            DataTable tableLetter = new DataTable();
            tableLetter = index.gettableLetter();
            Letter.DataSource = tableLetter;
            Letter.DataBind();
        
        }
        private void binglinkname()  //绑定友情链接
        {
            string str = "select * from Link";
            DataTable table = index.gettablelink(str );
            linkname.DataSource = table;
            linkname.DataBind();
        }
        private   void bingimages()
        {
            string str = "select top 1 * from ImageNews order by id ";
            DataTable dtFirst = index.dtFirst(str);
            ImagesFirst.DataSource = dtFirst;
            ImagesFirst.DataBind();
            string str1 = "select top 9 * from ImageNews  order by id  ";
            repimages.DataSource = index.dtothers(str1);
            repimages.DataBind();
        }
      
        public void bingindexclassname()
        {
            DataTable dtclassname = index.dtindexclassname("select * from class where classid in(3,6,5,9)");
            classname.DataSource = dtclassname;
            classname.DataBind();
        }
        public void bingclassarticle()
        {
            string str1 = "select top 5 * from article where classid=3 order by datetime desc";
            string str2 = "select top 5 * from article where classid=3 order by datetime desc";
            string str3 = "select top 5 * from article where classid=3 order by datetime desc";
            string str4 = "select top 5 * from article where classid=3 order by datetime desc";
            DataTable table1 =index.dtclssarticle (str1 );
            DataTable table2 = index.dtclssarticle(str2);
            DataTable table3 = index.dtclssarticle(str3);
            DataTable table4 = index.dtclssarticle(str4);
            rep1.DataSource = table1;
            rep1.DataBind();
            rep2.DataSource = table2;
            rep2.DataBind();
            rep3.DataSource = table3;
            rep3.DataBind();
            rep4.DataSource = table4;
            rep4.DataBind();
        }
        private void dtfocusnews()//焦点新闻
        {
            DataTable dtfocusnews = index.dtfocusnews("select top 5 * from article  order by  hits desc ");
            rep5.DataSource = dtfocusnews;
            rep5.DataBind();
        }

        protected void rep5_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Label lb = (Label)(e.Item.FindControl("Label1"));
            lb.Text = (++i).ToString();
        }
        //public void bingimagesnews()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append("<div id=\"header\"><div class=\"wrap\">");
        //    sb.Append("<div id=\"slide-holder\">");
        //    sb.Append("<div id=\"slide-runner\">");
        //    DataTable dtimages = index.dtimagenews("select * from ImageNews");
        //    int imagecount = dtimages.Rows.Count;
        //    for (int i = 0; i < imagecount; i++)
        //    {
        //        sb.Append("<a href='Article.aspx?articleid=");
        //        sb.Append (dtimages.Rows[i]["articleid"]);
        //        sb.Append("'>");
        //        sb.Append("<img id=\"slide-img-"+i);
        //        sb.Append("\" ");
        //        sb.Append ("src=\"images/"+dtimages .Rows[i]["name"] );
        //        sb.Append("\" ");
        //        sb.Append("class=\"slide\"");
        //        sb.Append("\" ");
        //        sb.Append ("alt=\""+ dtimages.Rows[i]["title"]);
        //        sb.Append("\" ");
        //        sb.Append ("/>");
        //        sb.Append("</a>");
               
        //    }
        //    sb.Append("<div id=\"slide-controls\">");
        //    sb.Append("<p id=\"slide-client\" class=\"text\"><strong>post: </strong><span></span></p>");
        //    sb.Append("<p id=\"slide-desc\" class=\"text\"></p>");
        //    sb.Append("<p id=\"slide-nav\"></p>");
        //    sb.Append("</div>");
        //    sb.Append("</div>");
        //    sb.Append("</div>");
        //    sb.Append("<script type=\"text/javascript\">");
        //    sb.Append("if(!window.slider) var slider={};");
        //    sb.Append("slider.data=[");
        //     for (int i = 0; i < imagecount-1; i++)
        //    {
        //         sb.Append ("{\"id\":\"slide-img-"+i);
        //         sb.Append (",\"client\":\"nature beauty\",\"desc\":\"");
        //         sb.Append (dtimages.Rows[i]["title"]);
        //         sb.Append ("\"},");
        //    }
        //     int lastcount = Convert.ToInt32 ( dtimages.Rows.Count.ToString()) - 1;
        //     sb.Append("{\"id\":\"slide-img-" +lastcount);
        //     sb.Append(",\"client\":\"nature beauty\",\"desc\":\"");
        //     sb.Append(dtimages.Rows[dtimages.Rows.Count-1]["title"]);
        //     sb.Append("\"}");
        //     sb.Append("];");
        //     sb.Append("</script>");
        //     sb.Append(" </div>");
        //     sb.Append("</div>");
        //     imagenews.InnerHtml = sb.ToString();  
        //    }
    }
}