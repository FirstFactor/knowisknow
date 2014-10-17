using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KnowIsKnow
{
    public partial class FindHot : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.QuestionUserReplyView questionlist = new BLL.QuestionUserReplyView();
            DataSet ds = questionlist.GetList("replyofReplyID is not null");
            this.rptquestionlist.DataSource = ds.Tables[0];
            //string s=ds.Tables[0].Rows[0]["questionTitle"].ToString();
            this.rptquestionlist.DataBind();

        }
    }
}