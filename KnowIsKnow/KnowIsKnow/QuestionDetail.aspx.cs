using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Globalization;

namespace KnowIsKnow
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        public string userid;
        public string quesid;
        public string questitle;
        public string quescontent;
        public int wkcount;
        public string datatime;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Write("<script>window.location.href='index.aspx'</script>");
            }
            else 
            {
                userid = Session["UserID"].ToString();
                quesid = Request.QueryString["QuesID"].ToString();
                BLL.QuestionTopic bllQuestionTopic = new BLL.QuestionTopic();
                DataSet da = bllQuestionTopic.GetList("quesrionTTID=" + quesid + "");
                this.rptQttip.DataSource = da.Tables[0];
                this.rptQttip.DataBind();
                BLL.QuestionInfo bllQuestionInfo = new BLL.QuestionInfo();
                Model.QuestionInfo ds = bllQuestionInfo.GetModel(Convert.ToInt32(quesid));
                questitle = ds.questionTitle;
                quescontent = ds.questionContent;
                BLL.QuestionUserReplyView bllQurv = new BLL.QuestionUserReplyView();
                DataSet dsa = bllQurv.GetList("questionID=" + quesid + " and replyofReplyID=0");
                wkcount = dsa.Tables[0].Rows.Count;
                if (wkcount == 0)
                {
                    return;
                }
                else 
                {
                    datatime = Convert.ToDateTime(dsa.Tables[0].Rows[0]["replyDateTime"]).ToShortDateString().ToString();

                    this.wkrtpReply.DataSource = dsa.Tables[0];
                    this.wkrtpReply.DataBind();
                }
              
            }
        }
        public string GetTopicTittle(object sid, object rid)
        {
            int questionid = (int)sid;
            int topid = (int)rid;
            BLL.TopicInfo blltopicinfo = new BLL.TopicInfo();
            Model.TopicInfo mtf = blltopicinfo.GetModel(topid);
            string sql ="select * from TopicInfo where topicID="+topid+"";

            DataSet da = blltopicinfo.GetTopicTittle(sql);
            return da.Tables[0].Rows[0]["topicTitle"].ToString();

        }
        public string GetreplyName(object id) 
        {
            int uid = (int)id;
            BLL.UserInfo blluserinfo = new BLL.UserInfo();
            string sql = "select userNickName from UserInfo where userID=" + uid + "";
            DataSet da = blluserinfo.GetreplyName(sql);

            return da.Tables[0].Rows[0]["userNickName"].ToString();
        }
        public string checkreplyofuid(object ReplyID)
        {
            BLL.ReplyQuestionUserView checkQP = new BLL.ReplyQuestionUserView();
            List<Model.ReplyQuestionUserView> QPlist = checkQP.GetModelList("replyofUID=" + userid);
            int qp = Convert.ToInt32(ReplyID);
            for (int y = 0; y < QPlist.Count; y++)
            {
                if (QPlist[y].ReplyID == qp)
                {
                    return "myReply";
                }
            }
            return "noMyReply";
        }
        public string CheckCarePerson(object replyofUID)
        {
            BLL.CarePerson cq = new BLL.CarePerson();
            List<Model.CarePerson> list = cq.GetModelList("personCaredByUID=" + userid);
            int qid = Convert.ToInt32(replyofUID);
            int mid = Convert.ToInt32(userid);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].carePersonID == qid)
                {
                    return "follow";
                }
            }
            if (qid == mid)
            {
                return "myself";
            }
            return "nofollow";
        }
        protected void wkreply_click(object sender, EventArgs e) 
        {
            //string sendcontent = this.wkreplycontent.Text;
            //DateTime now = DateTime.Now;
            //BLL.ReplyQuestion bllrques = new BLL.ReplyQuestion();
            //Model.ReplyQuestion mrq = new Model.ReplyQuestion();
            //mrq.replyofUID = Convert.ToInt32 (userid);
            //mrq.replyContent = sendcontent;
            //mrq.replyDateTime = now;
            
            //mrq.replyQuestionID =Convert.ToInt32(quesid);
            //mrq.replySate ="normal";
            //bllrques.Add(mrq);
            //this.wkreplycontent.Text = "";
            //Response.Write("<script>window.location.href='QuestionDetail.aspx'</script>");
        }
    }
}