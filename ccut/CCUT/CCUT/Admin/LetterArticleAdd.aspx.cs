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
    public partial class LetterAdd : System.Web.UI.Page
    {Bll.BLLAdmin admin=new Bll.BLLAdmin ();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["adminname"] == null || Session["adminpassword"] == null)
            {
                Response.Redirect("\\Admin\\Login.aspx");
            }
            if(!Page.IsPostBack )
            {
             bingLetter();
            }
        }
        private void  bingLetter()
        {
          DataTable dt=admin.dtLetter ("select * from LetterLink");
          DropDownList1.DataSource=dt;
          DropDownList1.DataTextField="name";
          DropDownList1.DataValueField = "lid";
          DropDownList1.DataBind();
        }
        protected void but_Click(object sender, EventArgs e)
        {
            int classid = Convert.ToInt32(DropDownList1.SelectedItem.Value);
            string title = TextBox1.Text;
            string cont = content1.InnerHtml;
            int hits = 0;
            string admin1 = Session["truename"].ToString();
            string lidnum = DropDownList1.SelectedItem.Value.ToString();
            string str = "insert into letterarticle(lid,title,content,hits,truename,datetime) values(@lid,@title,@content,@hits,@truename,@datetime)";
            SqlParameter[] para = new SqlParameter[]{
                                                   new SqlParameter("@lid",classid),
                                                   new SqlParameter("@title",title),
                                                   new SqlParameter("@content",cont),
                                                   new SqlParameter("@hits",hits),
                                                   new SqlParameter("@truename",admin1),
                                                   new SqlParameter("@datetime",DateTime.Now)
                                                  };
            if (title != "")
            {
                int i = admin.addLetterArticle(str, para);
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
    }
}