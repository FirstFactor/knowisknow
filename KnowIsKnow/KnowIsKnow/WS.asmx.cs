using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
namespace KnowIsKnow
{
    /// <summary>
    /// WS 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class WS : System.Web.Services.WebService
    {


        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string UpdateTopicInfo(string topicid, string topictitle, string topicdes, string topicpicurl, string topicattention, string topicstate)
        {
            BLL.TopicInfo topic = new BLL.TopicInfo();
            Model.TopicInfo topicinfo = new Model.TopicInfo();
            topicinfo.topicID = Convert.ToInt32(topicid);
            topicinfo.topicTitle = topictitle;
            topicinfo.topicDes = topicdes;
            topicinfo.topicPicUrl = topicpicurl;
            topicinfo.topicAttention = Convert.ToInt32(topicattention);
            topicinfo.topicState = topicstate;
            topic.Update(topicinfo);
            return "ok";
        }
        [WebMethod]

        public List<Model.UserInfo> selectUserInfo(string usernickname ) 
        {
            BLL.UserInfo userinfo = new BLL.UserInfo();
            List<Model.UserInfo> da = userinfo.GetModelList("userNickName like '%" + usernickname + "%'");
         
            
            return da; 
        }

       
        [WebMethod]
        public string AddCareTopic(string topicid, string userid)
        {
            BLL.CareTopic topic = new BLL.CareTopic();
            Model.CareTopic topicinfo = new Model.CareTopic();
            topicinfo.careTopicID = Convert.ToInt32(topicid);

            topicinfo.topicCaredByUID = Convert.ToInt32( userid);
        
            topic.Add(topicinfo);
            return "ok";
        }
        [WebMethod]
        public  string DeleteCareTopic(string topicid, string userid)
        {
            BLL.CareTopic topic = new BLL.CareTopic();
            Model.CareTopic topicinfo = new Model.CareTopic();
            topic.Delete(Convert.ToInt32(topicid), Convert.ToInt32(userid));
            return "ok";
        }




        [WebMethod]
        public string followQuestion(string questionid, string userid)
        {
            BLL.CareQuestion bllcq = new BLL.CareQuestion();
            Model.CareQuestion cq = new Model.CareQuestion();
            cq.careQuestionID = Convert.ToInt32(questionid);
            cq.questionCaredByUID = Convert.ToInt32(userid);
            bllcq.Add(cq);
            return "已关注该问题";
        }
        [WebMethod]
        public string nFollowQuestion(string questionid, string userid)
        {
            BLL.CareQuestion bllcq = new BLL.CareQuestion();
            Model.CareQuestion cq = new Model.CareQuestion();
            bllcq.Delete(Convert.ToInt32(questionid),Convert.ToInt32(userid));
            return "已取消关注";
        }

        [WebMethod]
        public string reportQuestion(string questionid, string userid, string reportType, string otherReason)
        {
            DateTime now = DateTime.Now;
            BLL.ReportQuestion bllrq = new BLL.ReportQuestion();
            Model.ReportQuestion rq = new Model.ReportQuestion();
            rq.reportQuestionID = Convert.ToInt32(questionid);
            rq.reportQuestionByUID = Convert.ToInt32(userid);
            rq.reportQuestionReasonTypeID = Convert.ToInt32(reportType);
            rq.reportQuestionReason = otherReason.ToString();
            rq.reportQuestionDateTime = now;
            rq.reportQuestionDealState = "undeal";
            bllrq.Add(rq);
            return "举报成功，请耐心等待处理结果";
        }



        [WebMethod]
        public void updateUserAddressJobGender(string address, string job, string gender, string userid)
        {
            BLL.UserInfo blluserinfo = new BLL.UserInfo();
            int uid = Convert.ToInt32(userid);
            Model.UserInfo modeluser = blluserinfo.GetModel(uid);
            modeluser.userAdress = address;
            modeluser.userJob = job;
            modeluser.userGender = gender;
             
            blluserinfo.Update(modeluser);
        }
        [WebMethod]
        public void updateUserCompanyPosition(string company, string position, string userid)
        {
            BLL.UserInfo blluserinfo = new BLL.UserInfo();
            int uid = Convert.ToInt32(userid);
            Model.UserInfo modeluser = blluserinfo.GetModel(uid);
            modeluser.userCompany = company;
            modeluser.userJobPosition = position;
            blluserinfo.Update(modeluser);
        }
        [WebMethod]
        public void updateUserAcademyMajor(string academy, string major,string userid)
        {
            BLL.UserInfo blluserinfo = new BLL.UserInfo();
            int uid = Convert.ToInt32(userid);
            Model.UserInfo modeluser = blluserinfo.GetModel(uid);
            modeluser.userAcademy = academy;
            modeluser.userMajor = major;
            blluserinfo.Update(modeluser);
        }

        [WebMethod]
        public void updateUserBio(string bio, string userid)
        {
            BLL.UserInfo blluserinfo = new BLL.UserInfo();
            int uid = Convert.ToInt32(userid);
            Model.UserInfo modeluser = blluserinfo.GetModel(uid);
            modeluser.userProBio = bio;          
            blluserinfo.Update(modeluser);
        }
        [WebMethod]
        public string updateUserHeadimg(string headimg,string userid)
        {
            BLL.UserInfo blluserinfo = new BLL.UserInfo();
            int uid = Convert.ToInt32(userid);
            Model.UserInfo modeluser = blluserinfo.GetModel(uid);
            modeluser.userHeadImage = headimg;
            return blluserinfo.Update(modeluser).ToString();
        }

        [WebMethod]
        public string updataName(string userid, string name)
        {
            BLL.UserInfo blluserinfo = new BLL.UserInfo();
            int uid = Convert.ToInt32(userid);
            Model.UserInfo modeluser = blluserinfo.GetModel(uid);
            modeluser.userNickName = name;
            return blluserinfo.Update(modeluser).ToString();
        }
       
        [WebMethod]
        public string updataPwd(string userid,string userpwd)
        {
            BLL.UserInfo blluserinfo = new BLL.UserInfo();
            int uid = Convert.ToInt32(userid);
            Model.UserInfo modeluser = blluserinfo.GetModel(uid);
            modeluser.userPwd = userpwd;
            return blluserinfo.Update(modeluser).ToString();
        }

        /// <summary>
        /// 回复功能
        /// </summary>
        /// <param name="replyquestionID">问题ID</param>
        /// <param name="replyofuid">回复人的ID</param>
        /// <param name="replycontent">回复的内容</param>
        /// <param name="replyofreplyid">对回复的回复的ID</param>
        /// <returns></returns>
        [WebMethod]
        public string Reply(int replyquestionID, int replyofuid,string replycontent,int replyofreplyid)
        {
            BLL.ReplyQuestion reply = new BLL.ReplyQuestion();
            DateTime now = DateTime.Now;
            Model.ReplyQuestion answer = new Model.ReplyQuestion();
            answer.replyQuestionID = replyquestionID;
            answer.replyofUID = replyofuid;
            answer.replyContent = replycontent;
            answer.replyDateTime = now;
            answer.replyofReplyID = replyofreplyid;

            reply.Add(answer);
            return "ok";
        }
        
        /// <summary>
        /// 提出问题
        /// </summary>
        /// <param name="questiontilte">标题</param>
        /// <param name="questioncontent">内容</param>
        /// <param name="questionproviderid">提问者ID</param>
        /// <returns></returns>
        [WebMethod]
        public string PubQuestion(string questiontilte, string questioncontent, string questionproviderid)
        {
            DateTime now = DateTime.Now;
            BLL.QuestionInfo bllquestion = new BLL.QuestionInfo();
            Model.QuestionInfo question = new Model.QuestionInfo();
            question.questionTitle = questiontilte;
            question.questionContent = questioncontent;
            question.questionProvider =Convert.ToInt32(questionproviderid);
            question.quetionPubTime = now;
            bllquestion.Add(question);
            return "ok";
        }

        [WebMethod]
        public string updatatopicinfo( string topicID)
        {
            BLL.TopicInfo blltopicinfo = new BLL.TopicInfo();
            int aa = Convert.ToInt32(topicID);
            Model.TopicInfo info= blltopicinfo.GetModel(aa);
            int ss =Convert.ToInt32( info.topicAttention);
            ss = ss + 1;
            info.topicAttention = ss;
            return blltopicinfo.Update(info).ToString();
         }
    }
}
