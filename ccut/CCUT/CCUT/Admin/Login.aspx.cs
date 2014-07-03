using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace CCUT.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        Bll.BLLAdmin admin = new Bll.BLLAdmin();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Buttonlogin_Click(object sender, EventArgs e)
        {
            
            SqlDataReader reader = admin.dtLogin("select * from Admin");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetString(1) == TextBoxusername.Text.Trim() && reader.GetInt32 (2).ToString () == TextBoxpassword.Text.Trim())
                    {
                        Session["adminname"] = reader.GetString(1);    //将用户账号赋给Session
                        Session["adminpassword"] = reader.GetInt32(2).ToString();  //将用户密码赋给Session
                        Session["truename"] = reader.GetString(3);  //将用户真实姓名赋给Session
                        Response.Redirect("admin.htm");
                    }
                    if (reader.GetString(1) != TextBoxusername.Text.Trim()||reader.GetInt32(2).ToString() != TextBoxpassword.Text.Trim())
                    {
                        Response.Write("<script>alert('您的姓名或密码不正确，请重新输入！');</script>");
                    }
                   
                }
            }
        }
    }
}