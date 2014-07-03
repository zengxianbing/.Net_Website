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
    public partial class NewsAdd : System.Web.UI.Page
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
                bingclassname();
                DropDownList1.SelectedIndex = 0;
                bingtypename(DropDownList1.SelectedValue );
            }
        }
        public  void bingclassname()
        {
            DataTable dtclassname = admin.dtclassname("select * from Class");
            DropDownList1.DataSource = dtclassname;
            DropDownList1.DataTextField = "classname";
            DropDownList1.DataValueField = "classid";
            DropDownList1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bingtypename( DropDownList1.SelectedValue);
        }
        private void bingtypename(string classid)
        {
            DataTable dttypename = admin.dttypename("select * from Type where classid=" +classid );
            DropDownList2.DataSource = dttypename;
            DropDownList2.DataTextField = "typename";
            DropDownList2.DataValueField = "typeid";
            DropDownList2.DataBind();
        }

        protected void but_Click(object sender, EventArgs e)
        {
            if (DropDownList2.Text != "")
            {
                //向tb_link表添加数据，用参数化SQL语句
                //string str = "insert into article(typeid,classid,title,content,hits,truename,datetime) values(@typeid,@classid,@title,@content,@hits,@truename,@datetime)";
                int classid = Convert.ToInt32(DropDownList1.SelectedItem.Value);
                int typeid = Convert.ToInt32(DropDownList2.SelectedItem.Value);
                string title = TextBox1.Text;
                string cont = content1.InnerText;
                int hits = 0;
                string admin1 = Session["truename"].ToString();
                string str = "insert into article(typeid,classid,title,content,hits,truename,datetime) values(@typeid,@classid,@title,@content,@hits,@truename,@datetime)";
                SqlParameter[] para = new SqlParameter[]{
                                                   new SqlParameter("@typeid",typeid),
                                                   new SqlParameter("@classid",classid),
                                                   new SqlParameter("@title",title),
                                                   new SqlParameter("@content",cont),
                                                   new SqlParameter("@hits",hits),
                                                   new SqlParameter("@truename",admin1),
                                                   new SqlParameter("@datetime",DateTime.Now)
                                                  };
                if (title != "")
                {
                    int i = admin.addnews(str,para);;
                    if (i > 0)
                    {
                        Response.Write("<script>alert('提交成功！');</script>");

                    }
                    else
                    {
                        Response.Write("<script>alert('提交失败！');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('请填写文件标题！');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('请选择文件的所属分类！');</script>");
            }
        }
        }
    
}