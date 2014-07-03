using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace CCUT
{
    public partial class Down : System.Web.UI.Page
    {
        Bll.BLLindex index = new Bll.BLLindex();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {   int  downid=Convert.ToInt32 ( Request.QueryString["downid"].ToString().Trim());
                string path = "";
                string name = "";
                DataTable dtupload = new DataTable();
                dtupload = index.dtupload("select * from DownUpload  where downid=" +downid);
                path = dtupload.Rows[0]["downpath"].ToString();
                name = dtupload.Rows[0]["downname"].ToString();
                index.updowncount("update DownUpload set downcount=downcount+1 where downid=" + downid);
                Response.Redirect(path + name);
            }
        }
    }
}