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
    public partial class DocAdd : System.Web.UI.Page
    {
        Bll.BLLAdmin admin = new Bll.BLLAdmin();
       public void Page_Load(object sender, EventArgs e)
        {
            if (Session["adminname"] == null || Session["adminpassword"] == null)
            {
                Response.Redirect("\\Admin\\Login.aspx");
            }
           

            
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                Response.Write("<script>alert('请填写需要添加附件的新闻标题！');</script>");
            }
            else
                {
                    DataTable dtarticle = admin.dtarticle("select * from article where title='" + TextBox1.Text.Trim() + "'");
                     if (dtarticle.Rows.Count < 0)
                       {
                            Response.Write("<script>alert('没有找到本条新闻请确认新闻标题是否正确！');</script>");
                        }    
                        else
                       {
                         if (FileUpload1.HasFile == false)
                         {
                             Response.Write("<script>window.alert('请先上传文件！');</script>");
                         }
                           else
                           {
                            for (int i = 0; i < dtarticle.Rows.Count; i++)
                            {
                                string downname = FileUpload1.FileName;
                                int articleid = Convert.ToInt32(dtarticle.Rows[i]["articleid"].ToString());
                                string downpath = "upload/";
                                string newstitle = TextBox1.Text;
                                string str = "insert into downupload values(@downname,@downtime,@downpath,@articleid,@newstitle,@downcount)";
                                int k = 0;
                                SqlParameter[] para = new SqlParameter[]{
                                                            new SqlParameter("@downname",downname),
                                                            new SqlParameter("@downtime",DateTime.Now.ToString()),
                                                            new SqlParameter("@downpath",downpath),
                                                            new SqlParameter("@articleid",articleid),
                                                            new SqlParameter("@newstitle",newstitle),
                                                            new SqlParameter("@downcount",k)
                                                            };
                                int j = admin.addUpload(str, para);
                                string fileloadup = Server.MapPath("\\upload\\") + FileUpload1.FileName;
                                FileUpload1.SaveAs(fileloadup);
                                if (j > 0)
                                {
                                    Response.Write("<script>window.alert('上传成功！');</script>");
                                    TextBox1.Text = "";
                                }
                            }
                          }
                      }
                }
         
        
            }
       }
    }
