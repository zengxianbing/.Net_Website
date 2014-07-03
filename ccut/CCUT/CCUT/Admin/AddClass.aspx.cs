using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CCUT.Admin
{
    public partial class AddClass : System.Web.UI.Page
    {
        Bll.BLLAdmin admin = new Bll.BLLAdmin();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                Response.Write("<script>alert('请输入大类的名称！');</script>");
            }
            else
            {
                string str = "insert into Class values('" + TextBox1.Text.ToString ().Trim ()+ "')";
                int i = admin.addclass(str);
                if (i > 0)
                {
                    Response.Write("<script>alert('添加成功！');</script>");
                }
            }
        }
    }
}