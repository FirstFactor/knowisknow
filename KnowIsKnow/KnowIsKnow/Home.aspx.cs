using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace KnowIsKnow
{
    public partial class Home : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.QuestionUserReplyView quelist = new BLL.QuestionUserReplyView();
            DataSet ds = quelist.GetList("replyofReplyID is not null");
            this.rpt.DataSource=ds.Tables[0];
            this.rpt.DataBind();
        }
    }
}