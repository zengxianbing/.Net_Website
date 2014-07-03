using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace CCUT.Admin
{
    public partial class NewsManagement : System.Web.UI.Page
    {
        Bll.BLLAdmin admin = new Bll.BLLAdmin();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["adminname"] == null || Session["adminpassword"] == null)
            {
                Response.Redirect("\\Admin\\Login.aspx");
            }
            if (!Page.IsPostBack)
            {
                    DataTable dtcount=admin.dtmanaarticlecount ("select * from dbo.Article");
                    AspNetPager1.RecordCount = dtcount.Rows.Count ;
                    AspNetPager1.PageSize = 11;
                    bing();
            }
        }
        void bing()
        {
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[] { 
                                            new SqlParameter("@pageIndex",AspNetPager1.CurrentPageIndex -1),
                                            new SqlParameter("@pageSize",AspNetPager1.PageSize)
                                        };
            dt = admin.dtmanaarticle("Article1", param);
            GridView1.DataKeyNames = new string[] { "articleid" };
            GridView1.DataSource = dt;
            GridView1.DataBind();
         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                CheckBox ch = (CheckBox)(row.Cells[2].FindControl("CheckBox1"));
                if (ch.Checked == true)
                {
                    string id = GridView1.DataKeys[row.RowIndex].Value.ToString();
                    int i = admin.deletearticle("delete from article where articleid=" + id);
                    if (i > 0)
                    {
                        Response.Write("<script>alert('删除成功！');</script>");
                    }
                }
            }
            bing();

        }

        protected void Check_CheckedChanged1(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                CheckBox ch = (CheckBox)(row.Cells[2].FindControl("CheckBox1"));
                if (Check.Checked == true)
                {
                    ch.Checked = true;
                }
                else
                {
                    ch.Checked = false;
                }
            }
        }
       
        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
             bing();
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // 鼠标经过时，行背景色变 
                e.Row.Attributes.Add("onmouseover", "e=this.style.backgroundColor,this.style.backgroundColor='#E6F5FA'");
                // 鼠标移出时，行背景色变 
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=e");
            }
        }
       
    }
}