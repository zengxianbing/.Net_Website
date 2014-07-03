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
    public partial class ImageNews : System.Web.UI.Page
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
            DataTable dt = admin.dtimagesnews("select * from ImageNews " );
            if (dt.Rows.Count == 8)
            {
                Response.Write("<script>window.alert('图片新闻添加数量以达到上限，请先删除一些图片新闻后再添加！');</script>");
            }
            else
            {
         
            if (TextBox1.Text == "")
            {
                Response.Write("<script>window.alert('请输入数字！');</script>");
            }
            else
            {
                if (TextBox2.Text == "")
                {
                    Response.Write("<script>window.alert('请填写标题！');</script>");
                }
                else
                {
                    if (FileUpload1.HasFile == false)
                    {
                        Response.Write("<script>window.alert('请先上传图片！');</script>");
                    }
                    else
                    {
                        DataTable dtarticle = admin.dtarticle("select * from article where title='" + TextBox2.Text.Trim() + "'");
                        if (dtarticle.Rows.Count < 0)
                        {
                            Response.Write("<script>alert('没有找到本条新闻请确认新闻标题是否正确！');</script>");
                        }
                        //else
                        //{
                        //    if (dtarticle.Rows.Count > 0)
                        //    {
                        //        Response.Write("<script>alert('一条新闻只能添加新闻图片');</script>");
                        //    }
                            else
                            {
                                int id = Convert.ToInt32(TextBox1.Text);
                                string name = FileUpload1.FileName;
                                string path = "news/";
                                string title = TextBox2.Text;
                                string articleid = dtarticle.Rows[0]["articleid"].ToString();
                                string str = "insert into imagenews values(@id,@name,@path,@title,@articleid,@time)";
                                SqlParameter[] para = new SqlParameter[]{
                                                                   new SqlParameter("@id",id),
                                                                   new SqlParameter("name",name),
                                                                   new SqlParameter("path",path),
                                                                   new SqlParameter("title",title),
                                                                   new SqlParameter("articleid",articleid),
                                                                   new SqlParameter("time",DateTime.Now)
                                                                   };
                                int i = admin.addimagesnews(str, para);
                                string fileloadup = Server.MapPath("\\news\\") + FileUpload1.FileName;
                                FileUpload1.SaveAs(fileloadup);
                                if (i > 0)
                                {
                                    Response.Write("<script>window.alert('上传成功！');</script>");
                                    TextBox2.Text = "";
                                    TextBox1.Text = "";
                                }
                            }
                    }
                    } 
                    //}
                }
            }

        }
    }
}