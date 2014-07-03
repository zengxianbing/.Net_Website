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
    public partial class LetterAdd1 : System.Web.UI.Page
    {
        Bll.BLLAdmin admin = new Bll.BLLAdmin();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["adminname"] == null || Session["adminpassword"] == null)
            {
                Response.Redirect("\\Admin\\Login.aspx");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string status = "";
            if (RadioButton1.Checked)
            {
                status = "1";
            }
            if (RadioButton2.Checked)
            {
                status = "0";
            }
            if (status == "")
            {
                Response.Write("<script>alert('请选择该专题的状态！');</script>");
            }
            else
            {
                if (TextBox1.Text == "")
                {
                    Response.Write("<script>alert('请输入新添加专题的名称！');</script>");
                }
                else
                {
                    string str = "insert into LetterLink(name,status) values(@name,@status)";
                    SqlParameter[] para = new SqlParameter[]{
                                                   new SqlParameter("@name",TextBox1.Text),
                                                   new SqlParameter("@status",status)
                                                  };
                    int i = admin.addLetter(str, para);
                    if (i > 0)
                    {
                        Response.Write("<script>alert('提交成功！');</script>");
                    }
                }
            }
        }
    }
}