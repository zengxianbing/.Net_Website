using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace CCUT
{
    public partial class Letter : System.Web.UI.Page
    {
        Bll.BLLindex index = new Bll.BLLindex();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bingLetter();
                bingLetter1();
                Letter3.Text=Request.QueryString["name"].ToString ();
            }
        }
        private void bingLetter()//绑定热点专题
        {
            DataTable tableLetter = new DataTable();
            tableLetter = index.gettableLetter();
              letter. DataSource = tableLetter;
              letter.DataBind();
        }
        private void bingLetter1()//绑定热点专题
        {
            DataTable tableLetter = new DataTable();
            tableLetter = index.gettableLetter();
            letter1.DataSource = tableLetter;
            letter1.DataBind();
        }
        protected void letter1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            HiddenField hf = (HiddenField)e.Item.FindControl("HiddenField1");
            string lid = hf.Value.Trim ();
            string str = "select * from LetterArticle where lid=" + lid ;
            DataTable table = index.letterarticle(str );
            Repeater letterarticle = (Repeater)e.Item.FindControl("letterarticle");
            letterarticle.DataSource = table;
            letterarticle.DataBind();
        }
    }
}