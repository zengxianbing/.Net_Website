using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data ;
namespace CCUT.Admin
{
    public partial class ManaType : System.Web.UI.Page
    {     
        Bll.BLLAdmin admin=new Bll.BLLAdmin ();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bingclassname();
                DropDownList1.SelectedIndex = 0;
                bingtype (DropDownList1.SelectedValue);
               
            }
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
        public void bingclassname()
        {
            DataTable dtclassname = admin.dtclassname("select * from Class");
            DropDownList1.DataSource = dtclassname;
            DropDownList1.DataTextField = "classname";
            DropDownList1.DataValueField = "classid";
            DropDownList1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                CheckBox ch = (CheckBox)(row.Cells[1].FindControl("CheckBox2"));
                if (ch.Checked == true)
                {
                    string id = GridView1.DataKeys[row.RowIndex].Value.ToString();
                    int i = admin.deletearticle("delete from article where typeid=" + id);
                    int j = admin.deletetype("delete from Type where typeid=" + id);
                    if (i > 0)
                    {
                        if (j > 0)
                        {
                           
                                Response.Write("<script>alert('删除成功！');</script>");
                            
                        }
                    }
                }
            }
            bingtype(DropDownList1.SelectedValue);
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
         public void bingtype(string str1)//绑定小类
        {
            string str = "select * from Type where classid="+str1;
            DataTable dt = admin.dtclass(str);
            GridView1.DataKeyNames = new string[] { "typeid" };
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

         protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
         {
             bingtype(DropDownList1.SelectedValue);
             Check.Checked = false;
         }
    }
}