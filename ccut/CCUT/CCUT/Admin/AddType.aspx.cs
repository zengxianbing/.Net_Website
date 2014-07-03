using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace CCUT.Admin
{
    public partial class AddType : System.Web.UI.Page
    {
        Bll.BLLAdmin admin = new Bll.BLLAdmin();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bingclassname();
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
            string str = "insert into Type values('" + TextBox1.Text +"','"+   Convert.ToInt32(DropDownList1.SelectedItem.Value)+"')";
            int i = admin.addtype(str);
            if (i > 0)
            {
                Response.Write("<script>alert('添加成功！');</script>");
            }
        }
    }
}