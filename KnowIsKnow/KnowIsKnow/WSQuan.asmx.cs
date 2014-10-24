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

            BLL.ReportQuestion rptq = new BLL.ReportQuestion();
            Model.ReportQuestion model = rptq.GetModel(reportQuID);
            model.reportQuestionDealState = "unnormal";
            rptq.Update(model);
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
            model.reportReplyDealState = "unnormal";
            rptp.Update(model); 

            #endregion

            #region 向非法的人发出系统消息
            BLL.ReplyQuestion re = new BLL.ReplyQuestion();
            Model.ReplyQuestion qe = re.GetModel(model.reportReplyID);//根据被举报的reportReplyID获得该实例
            int MessageReciverID = qe.replyofUID;//从该实例中获得该回答的回答人ID
            
            BLL.MessageInfo msg = new BLL.MessageInfo();
            Model.MessageInfo mmsg = new Model.MessageInfo();
            
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


    }
}
