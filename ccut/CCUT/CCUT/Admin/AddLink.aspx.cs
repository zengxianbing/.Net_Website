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
    public partial class AddLink : System.Web.UI.Page
    {
        Bll.BLLAdmin admin = new Bll.BLLAdmin();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "insert into Link values(@linkname,@url)";
            SqlParameter[] para = new SqlParameter[]{
                                                            new SqlParameter("@linkname",TextBox1.Text.Trim ()),
                                                            new SqlParameter("@url",TextBox2.Text.Trim ())
                                                          
                                                            };
            int i = admin.addlink(str,para);
            if (i > 0)
            {
                Response.Write("<script>window.alert('上传成功！');</script>");
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
        }
    }
}