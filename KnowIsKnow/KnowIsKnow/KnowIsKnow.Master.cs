using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace KnowIsKnow
{
  
    public partial class KnowIsKnow : System.Web.UI.MasterPage
    {
        public string userid;
        public string usernickname;
        public string userheadimg;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                return;

            }
            else
            {
                userid = Session["UserID"].ToString();
                usernickname = Session["UserNickName"].ToString();
                userheadimg = Session["UserHeadImage"].ToString();
            }
        }
        public void sendQuestion(object o, EventArgs e) {
            string questionTitle = this.txtQuestionTitle.Text;
            string questionContent = this.txtQuestionContent.InnerText;
            DateTime now = DateTime.Now;
            BLL.QuestionInfo bllque = new BLL.QuestionInfo();
            Model.QuestionInfo que = new Model.QuestionInfo();
            que.questionProvider = Convert.ToInt32(userid);
            que.questionTitle = questionTitle;
            que.questionContent = questionContent;
            que.quetionPubTime = now;
            que.questionSate = "unread";
            bllque.Add(que);
            Response.Write("<script>window.location.href='home.aspx'</script>");
        }
    }
}