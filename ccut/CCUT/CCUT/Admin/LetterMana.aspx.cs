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
    public partial class LetterMana : System.Web.UI.Page
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
                AspNetPager1.RecordCount = admin.dtLetter("select * from LetterLink").Rows.Count;
                AspNetPager1.PageSize = 2;
                Manage();
            }

        }
        private void Manage()
        {
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[] { 
                                            new SqlParameter("@pageIndex",AspNetPager1.CurrentPageIndex -1),
                                            new SqlParameter("@pageSize",AspNetPager1.PageSize)
                                        };
            dt = admin.DTLetter("LetterLink1", param);
            GridView1.DataKeyNames = new string[] { "lid" };
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
                    string str = GridView1.DataKeys[row.RowIndex].Value.ToString();
                    int i = admin.deleteLetter("delete from letterarticle where lid=" + str);
                    int j = admin.deLetter("delete from LetterLink where lid=" + str);
                    if (i > 0 && j > 0)
                    {
                        Response.Write("<script>alert('删除成功！');</script>");
                    }
                }
            }
            Manage();
          
        }

       

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {

                //鼠标经过时，行背景色变 
                e.Row.Attributes.Add("onmouseover", "e=this.style.backgroundColor,this.style.backgroundColor='#E6F5FA'");
                //鼠标移出时，行背景色变 
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=e");
            }
          

        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            Manage();

        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                CheckBox ch = (CheckBox)(row.Cells[2].FindControl("CheckBox1"));
                if (CheckBox2.Checked == true)
                {
                    ch.Checked = true;
                }
                else
                {
                    ch.Checked = false;
                }
            }
        }

       
    }
}