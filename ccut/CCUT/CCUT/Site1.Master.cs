using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace CCUT
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        Bll.BLLindex index = new Bll.BLLindex();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable gettableclass = index.gettableclass();
            classname.DataSource = gettableclass;
            classname.DataBind();
            
        }

        protected void classname_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            string hf = ((HiddenField)e.Item.FindControl("hf")).Value.ToString().Trim();
            Repeater reptype = (Repeater)e.Item.FindControl("typename");
            string str = "select * from Type where classid='" + hf + "'";
            DataTable talbe = index.gettabletypename(str);
            reptype.DataSource = talbe;
            reptype.DataBind();
        }
    }
}