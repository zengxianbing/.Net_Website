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
    public partial class Type : System.Web.UI.Page
    {
        Bll.BLLindex index = new Bll.BLLindex();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                bingLabel();
                typename2.Text = Request.QueryString["typename"].ToString().Trim();
                typename1.Text = Request.QueryString["typename"].ToString().Trim();
                bingtypename();
                bingarticle1();
                bingarticle2();
            }
        }
        private void bingLabel()// 绑定当前位置
        {
            string typeid = Request.QueryString["typeid"].ToString().Trim ();
            string str = "select * from Class where classid=(select classid from Type where typeid="+typeid +" )";
            DataTable tableclass = index.gettableclassid(str );
            classname.Text = tableclass.Rows[0]["classname"].ToString();
            classname1.Text = tableclass.Rows[0]["classname"].ToString();
            classname1.PostBackUrl = "~/Class.aspx?classid=" + tableclass.Rows[0]["classid"].ToString() + "&&classname=" + tableclass.Rows[0]["classname"].ToString();
             typename2.PostBackUrl = "~/Type.aspx?typeid="+Request.QueryString["typeid"].ToString().Trim()+"&&typename="+Request.QueryString["typename"].ToString().Trim();
        }
 
        private void bingtypename()//绑定小类名
        {
            string str = "select * from Type where classid=(select classid from Class where classid=(select classid from Type where typeid=" + Request.QueryString["typeid"].ToString().Trim() + " ))";
            DataTable tabletype = index.gettabletypename1(str);
            typename.DataSource = tabletype ;
            typename.DataBind();
       }
        private void bingarticle1() // 绑定阅读排行榜
        {
            string str = "select  top 10 * from Article order by hits desc";
            DataTable table = index.gettablearticle1(str );
            article1.DataSource = table;
            article1.DataBind();
        }
        private void bingarticle2()//绑定文章题目
        {
            string str = "select * from Article where typeid=" + Request.QueryString["typeid"].ToString().Trim();
            DataTable table = index.gettalbearticle2(str );
            article.DataSource = table;
            article.DataBind();
        }

    }
}