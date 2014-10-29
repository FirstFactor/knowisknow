using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace KnowIsKnow
{
    /// <summary>
    /// Quan 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class Quan : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        /// <summary>
        /// 处理对问题的举报
        /// </summary>
        /// <param name="reportQuID"></param>
        /// <returns></returns>
        [WebMethod]
        public string DealQuestionReport(int reportQuID) {

            #region 更新举报信息的状态

            BLL.ReportQuestion rptq = new BLL.ReportQuestion();
            Model.ReportQuestion model = rptq.GetModel(reportQuID);
            model.reportQuestionDealState = "dealed";
            int reportQuestionID= model.reportQuestionID;
            rptq.Update(model); 

            #endregion
                           
            #region 更新问题表中的问题状态,同时获取该问题的提问者

            BLL.QuestionInfo quest = new BLL.QuestionInfo();
            Model.QuestionInfo modelquest= quest.GetModel(reportQuestionID);
            modelquest.questionSate = "unnormal";
            int questionprovider =modelquest.questionProvider;//获取该问题的提问者
            quest.Update(modelquest);

            #endregion

            #region 向提出非法问题的人发出系统消息

            BLL.MessageInfo bllmsg = new BLL.MessageInfo();
            Model.MessageInfo modelmsg = new Model.MessageInfo();
            modelmsg.MessageContent = "你的问题有非法信息，已被删除";
            modelmsg.MessageReceiverID = questionprovider;
            modelmsg.MessageSate = "unread";
            modelmsg.MessageSendTime = DateTime.Now;
            modelmsg.MessageSenderID = 0;//0代表系统发送的消息;
            modelmsg.MessageReportID = reportQuestionID;
            bllmsg.Add(modelmsg); 

            #endregion

            return "ok";
        }
        /// <summary>
        /// 处理对回答的举报
        /// </summary>
        /// <param name="reportReID"></param>
        /// <returns></returns>
        [WebMethod]
        public string DealReplyReport(int reportReID)
        {

            #region 更新举报状态

            BLL.ReportReply rptp = new BLL.ReportReply();
            Model.ReportReply model = rptp.GetModel(reportReID);
            model.reportReplyDealState = "dealed";
            int ReportReplyID = model.reportReplyID;//获得被举报的回答的ID；
            rptp.Update(model); 

            #endregion

            #region 根据举报的回答的ID，获得回答的 问题的ID

		    BLL.ReplyQuestion rq=new BLL.ReplyQuestion();
            Model.ReplyQuestion mrq=rq.GetModel(ReportReplyID);
            mrq.replySate = "unnormal";//更新回答的状态
            rq.Update(mrq);
            int questionid=mrq.replyQuestionID;

	        #endregion


            #region 向非法的人发出系统消息
            BLL.ReplyQuestion re = new BLL.ReplyQuestion();
            Model.ReplyQuestion qe = re.GetModel(model.reportReplyID);//根据被举报的reportReplyID获得该实例
            int MessageReciverID = qe.replyofUID;//从该实例中获得该回答的回答人ID
         
            DateTime now = DateTime.Now;
            BLL.MessageInfo msg = new BLL.MessageInfo();
          
            Model.MessageInfo mmsg = new Model.MessageInfo();
            mmsg.MessageReportID = questionid;
            mmsg.MessageSenderID = 0;//0代表系统消息;
            mmsg.MessageSendTime = now;
            mmsg.MessageSate = "unread";
            mmsg.MessageContent = "<a href='QuestionDetail.aspx?QuesID=" + questionid + "'>你的回答有非法的内容,已被删除</a>";
            mmsg.MessageReceiverID = MessageReciverID;
            msg.Add(mmsg);

            #endregion

            return "ok";
        }

        /// <summary>
        /// 获得所有未处理的提问举报
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public List<Model.ReportQuestion> GetUnDealReportQuestion()
        {
            List<Model.ReportQuestion> reportlist=new List<Model.ReportQuestion>();
            BLL.ReportQuestion reportq=new BLL.ReportQuestion();
            reportlist = reportq.GetModelList(" reportQuestionDealState='undeal'");
            return reportlist;
        }
        /// <summary>
        /// 获得所有未处理的回答举报
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public List<Model.ReportReply> GetUnDealReportReply()
        {
            List<Model.ReportReply> reportlist = new List<Model.ReportReply>();
            BLL.ReportReply reportr = new BLL.ReportReply();
            reportlist = reportr.GetModelList(" reportReplyDealState='undeal'");
            return reportlist;
        }


        [WebMethod]
        public List<Model.TopicInfo> Pages(string str, string order, int startindex, int endindex)
        {
            int size = endindex - startindex;
            BLL.TopicInfo blltopic = new BLL.TopicInfo();
            //DataSet ds= blltopic.GetList(size,str,index);
            DataSet ds = blltopic.GetListByPage( str,order,startindex,endindex );
            List<Model.TopicInfo> list  = blltopic.DataTableToList(ds.Tables[0]);
            return list;
        }

        [WebMethod]
        public string CountPage(string str, int startindex, int endindex)
        {
            int size = endindex - startindex+1;
            BLL.TopicInfo blltopic = new BLL.TopicInfo();
            int count= blltopic.GetRecordCount(str);
            int allpage;
            if (count % size == 0)
            {
                allpage = count / size;
            }
            else {
                allpage = (count / size) + 1;
            }
            return allpage.ToString();
        }
        /// <summary>
        /// 群发消息
        /// </summary>
        /// <param name="senderid"></param>
        /// <param name="receiverid"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        [WebMethod]
        public string sendSystemMessage(int senderid,int receiverid,string content)
        {


            BLL.MessageInfo message = new BLL.MessageInfo();


            BLL.UserInfo user = new BLL.UserInfo();
            List<Model.UserInfo> userinfo=user.GetModelList("1=1");
            for (int i = 0; i < userinfo.Count; i++)
            {

                
                Model.MessageInfo modelmsg = new Model.MessageInfo();
                modelmsg.MessageSendTime = DateTime.Now;
                modelmsg.MessageContent = content;
                modelmsg.MessageSenderID = senderid;
                modelmsg.MessageSate = "unread";
                modelmsg.MessageReceiverID = userinfo[i].userID; ;
                modelmsg.MessageReportID = 0;

                message.Add(modelmsg);

            }
            
            
           
            return "ok";
        }



        [WebMethod]
        public string addTopic(string topicTitle, string topicDes, string topicPicUrl)
        {


            BLL.TopicInfo addtopic = new BLL.TopicInfo();
            Model.TopicInfo topic = new Model.TopicInfo();
            topic.topicTitle = topicTitle;
            topic.topicDes = topicDes;
            topic.topicPicUrl = topicPicUrl;
            topic.topicAttention = 0;

            addtopic.Add(topic);
            return "ok";
        }

        [WebMethod]

        public string UpdateTopicInfoState(int topicid, string topicstate) 
        {
            BLL.TopicInfo top = new BLL.TopicInfo();
            Model.TopicInfo model = top.GetModel( topicid);
            model.topicState = topicstate;

            top.Update(model);
            return "ok";
        }

        
    }
}
