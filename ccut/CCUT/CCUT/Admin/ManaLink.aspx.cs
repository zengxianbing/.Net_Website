using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace CCUT.Admin
{
    public partial class ManaLink : System.Web.UI.Page
    {        Bll.BLLAdmin admin=new Bll.BLLAdmin ();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                binglink();
            }
        }
        public void binglink()//绑定友情链接
        {
            string str = "select * from Link";
            DataTable dt = admin.dtlink(str );
            GridView1.DataKeyNames = new string[] { "id" };
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                CheckBox ch = (CheckBox)(row.Cells[1].FindControl("CheckBox2"));
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                CheckBox ch = (CheckBox)(row.Cells[1].FindControl("CheckBox2"));
                if (ch.Checked == true)
                {
                    string id = GridView1.DataKeys[row.RowIndex].Value.ToString();
                    int i = admin.deletelink ("delete from link where id=" + id);
                    if (i > 0)
                    {
                        
                                Response.Write("<script>alert('删除成功！');</script>");
                        
                    }
                }
            }
            binglink();
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