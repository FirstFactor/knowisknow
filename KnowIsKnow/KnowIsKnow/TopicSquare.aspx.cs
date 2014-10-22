using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KnowIsKnow
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.TopicInfo questionlist = new BLL.TopicInfo();
            DataSet ds = questionlist.GetList("1=1");
            this.rptquestionlist.DataSource = ds.Tables[0];
            this.rptquestionlist.DataBind();
        }
    }
}