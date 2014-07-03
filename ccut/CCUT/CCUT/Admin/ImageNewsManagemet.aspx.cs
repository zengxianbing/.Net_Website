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
    public partial class ImageNewsManagemet : System.Web.UI.Page
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
                DataTable dt = admin.dtimagesnews("select * from imagenews");
                AspNetPager1.RecordCount = dt.Rows.Count;
                AspNetPager1.PageSize = 3;
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
            dt = admin.DTimagesnews("ImageNews1", param);
            GridView1.DataKeyNames = new string[] { "id" };
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void Check_CheckedChanged(object sender, EventArgs e)
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

        protected void But_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                CheckBox ch = (CheckBox)(row.Cells[2].FindControl("CheckBox1"));
                if (ch.Checked == true)
                {
                    string id = GridView1.DataKeys[row.RowIndex].Value.ToString();
                    int i = delete( id);

                }
            }
            bing();

        }
        public int delete(string id)
        {
            string str = "delete from imagenews where id=" + id;
            int i = admin.deleteimagesnews(str);
            return i;
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
            bing();
        }

     
    }
}