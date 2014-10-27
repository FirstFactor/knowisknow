using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
namespace KnowIsKnow
{
    /// <summary>
    /// WSWang 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class WSWang : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public List<Model.QuestionUserReplyView> selectRely(string replyquestionId)
        {
            BLL.QuestionUserReplyView bllRqes = new BLL.QuestionUserReplyView();
            List<Model.QuestionUserReplyView> da = bllRqes.GetModelList("replyofReplyID=" + replyquestionId + "");
            return da;
        }
        [WebMethod]
        public string Reply(int replyquestionID, int replyofuid, string replycontent, int replyofreplyid)
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
            BLL.MessageInfo bllmsg = new BLL.MessageInfo();
            BLL.UserInfo blluserinfo = new BLL.UserInfo();
            DataSet da = blluserinfo.GetList("userID="+replyofuid+"");
            string username = da.Tables[0].Rows[0]["userNickName"].ToString();
            Model.MessageInfo mmsg = new Model.MessageInfo();
            mmsg.MessageContent = username+"回答您的问题";
            mmsg.MessageReceiverID = replyofuid;
            mmsg.MessageSendTime = now;
            mmsg.MessageSenderID = 0;
            mmsg.MessageSate = "unread";
            bllmsg.Add(mmsg);
            return "ok";
        }
    }
}
