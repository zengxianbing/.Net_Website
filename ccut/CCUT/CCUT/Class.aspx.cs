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
    public partial class Class : System.Web.UI.Page
    {
        Bll.BLLindex index = new Bll.BLLindex();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bingLetter();
                classname.Text = Request.QueryString["classname"].ToString();
                LinkButton1.Text = Request.QueryString["classname"].ToString();
                LinkButton1.PostBackUrl = "~/Class.aspx?classid=" + Request.QueryString["classid"].ToString().Trim() + "&&classname=" + Request.QueryString["classname"].ToString();
                bingtypename();
                bingtypename1();
            } 
        }
        private void bingtypename()
        {
            string classid = Request.QueryString["classid"].ToString().Trim();
            string str = "select * from Type where classid='"+classid+"'";
            DataTable table = index.gettabletypename(str);
            typename.DataSource = table;
            typename.DataBind();
        }
        private void bingtypename1()
        {
            string classid = Request.QueryString["classid"].ToString().Trim();
            string str = "select * from Type where classid='" + classid + "'";
            DataTable table = index.gettabletypename(str);
            typename1.DataSource = table;
            typename1.DataBind();
        }

        protected void typename1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            HiddenField hf =((HiddenField)e.Item.FindControl("typeid"));
            string typeid = hf.Value;
            Repeater repacticle = (Repeater)e.Item.FindControl("article");
            string str = "select * from Article where typeid="+typeid +"";
            DataTable table = index.gettableTitle(str );
            repacticle.DataSource = table;
            repacticle.DataBind();
        }
        private void bingLetter()//绑定热点专题
        {
            DataTable tableLetter = new DataTable();
            tableLetter = index.gettableLetter();
            Letter.DataSource = tableLetter;
            Letter.DataBind();
        }

       
    }
}