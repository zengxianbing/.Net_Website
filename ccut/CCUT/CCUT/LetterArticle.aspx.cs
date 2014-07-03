using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace CCUT
{
    public partial class LetterArticle : System.Web.UI.Page
    {
        Bll.BLLindex index = new Bll.BLLindex();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bingcontent();
                bingname();
                bingtitle();
            }
        }
        private void bingcontent()
        {
            string str = "select * from LetterArticle where id="+Request.QueryString ["id"].ToString ().Trim();
            DataTable talbe = index.dtLetterArticle(str );
            content.DataSource = talbe;
            content.DataBind();
        }
        private void bingname()//绑定所在专题
        {
            string str = "select * from LetterLink where lid=(select lid from LetterArticle where id=" + Request.QueryString["id"].ToString().Trim() + ")";
            DataTable table = index.dtLettername(str );
            Label1.Text = table.Rows[0]["name"].ToString();
            LinkButton2.Text = table.Rows[0]["name"].ToString();
            LinkButton2.PostBackUrl = "~/Letter.aspx?lid=" + table.Rows[0]["lid"].ToString()+"&&name="+table.Rows[0]["name"].ToString();
        }
        private void bingtitle()//绑定该专题所有文章
        {
            string str = "select * from LetterArticle  where lid=(select lid from LetterArticle where id=" + Request.QueryString["id"].ToString().Trim() + ")";
            DataTable table = index.dtLetterTitle(str );
            title.DataSource = table;
            title.DataBind();
        }


    }
}