using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KnowIsKnow
{
    public partial class CareTopic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //BLL.QuestionUserReplyView questionlist = new BLL.QuestionUserReplyView();
            //DataSet ds = questionlist.GetList("replyofReplyID is not null");
            //this.rptquestionlist.DataSource = ds.Tables[0];

            //this.rptquestionlist.DataBind();
            if (Session["UserID"]==null)
            {
                Response.Redirect("index.aspx");
            }
            else { 
            BLL.TopicUserView  caretopic= new BLL.TopicUserView();
            DataSet ds = caretopic.GetList("userID = "+Session["UserID"]);
            this.rptquestionlist.DataSource = ds.Tables[0];
            this.rptquestionlist.DataBind();
        }



        }
    }
}