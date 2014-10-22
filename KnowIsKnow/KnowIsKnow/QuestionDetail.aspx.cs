using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace KnowIsKnow
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        string quesid;
        public string questitle;
        public string quescontent;
        protected void Page_Load(object sender, EventArgs e)
        {
            quesid = Request.QueryString["QuesID"].ToString();
            BLL.QuestionTopic bllQuestionTopic = new BLL.QuestionTopic();
            DataSet da = bllQuestionTopic.GetList("quesrionTTID="+quesid+"");
            this.rptQttip.DataSource = da.Tables[0];
            this.rptQttip.DataBind();
            BLL.QuestionInfo bllQuestionInfo = new BLL.QuestionInfo();
            Model.QuestionInfo ds = bllQuestionInfo.GetModel(Convert.ToInt32(quesid));
            questitle = ds.questionTitle;
            quescontent = ds.questionContent;
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
    }
}