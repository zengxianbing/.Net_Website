using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace CCUT
{
    public partial class Article : System.Web.UI.Page
    {
        Bll.BLLindex index = new Bll.BLLindex();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                hitsarticle();
                bingarticle();
                bingLetter();
                binglink();
                binglastnews();
                DataTable dtupload = index.dtupload("select * from DownUpload where articleid=" + Request.QueryString["articleid"].ToString());
                if (dtupload.Rows.Count > 0)
                {
                    repupload.DataSource = dtupload;
                    repupload.DataBind();
                }
                else
                {
                    Label1.Text = "无";
                    repupload.Visible = false;
                }
            }

        }
       
        private void hitsarticle()//文章阅读点击率
        {
            string str = "update article set hits=hits+1 where  articleid=" + Request.QueryString["articleid"].ToString();
            index.hitsarticle(str);
        }
        private void bingarticle()
        {
            string article = Request.QueryString["articleid"].ToString();
            string str = "select * from Article where articleid="+article ;
            DataTable table = index.gettalbearticle(str);
            content.DataSource = table;
            content.DataBind();
        }
        private  void binglink()//绑定当前位置的链接
        {
            string strclassname = "select * from Class where classid =(select classid from Article where articleid="+Request.QueryString["articleid"].ToString().Trim ()+") ";
            string strtypename = "select * from Type where typeid =(select typeid from Article where articleid=" + Request.QueryString["articleid"].ToString().Trim() + ")";
            DataTable dtclassname = index.getclassname(strclassname );
            DataTable dttypename = index.gettypename(strtypename );
            classname1.Text = dtclassname.Rows[0]["classname"].ToString();
            typename1.Text = dttypename.Rows[0]["typename"].ToString();
            classname1.PostBackUrl = "~/Class.aspx?classid=" + dtclassname.Rows[0]["classid"].ToString() + "&&classname=" + dtclassname.Rows[0]["classname"].ToString();
            typename1.PostBackUrl = "~/Type.aspx?typeid=" + dttypename.Rows[0]["typeid"].ToString() + "&&typename=" + dttypename.Rows[0]["typename"].ToString();
        }
        private void bingLetter()//绑定热点专题
        {
            DataTable tableLetter = new DataTable();
            tableLetter = index.gettableLetter();
            Letter.DataSource = tableLetter;
            Letter.DataBind();
        }
        private void binglastnews()//绑定最新新闻列表
        {
            string str = "select  top 10 * from Article order by datetime desc";
            DataTable table = index.getlastestnews(str );
            lastnews.DataSource = table;
            lastnews.DataBind();
            
        }
    }
}