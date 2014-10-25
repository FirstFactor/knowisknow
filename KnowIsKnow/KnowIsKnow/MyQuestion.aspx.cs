using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace KnowIsKnow
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        public string userid_myquestion;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Write("<script>window.location.href='index.aspx'</script>");
            }
            else
            {
                userid_myquestion = Session["UserID"].ToString();
                BLL.QuestionUserView quelist = new BLL.QuestionUserView();
                DataSet ds = quelist.GetList("questionSate='normal' and questionProvider=" + userid_myquestion + " order by quetionPubTime desc");
                this.rpt.DataSource = ds.Tables[0];
                this.rpt.DataBind();

            }
        }
        public string CheckCareQuestion(object questionID)
        {
            BLL.CareQuestion cq = new BLL.CareQuestion();
            List<Model.CareQuestion> list = cq.GetModelList("questionCaredByUID=" + userid_myquestion);
            int qid = Convert.ToInt32(questionID);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].careQuestionID == qid)
                {
                    return "true";
                }
            }
            return "false";

        }
    }
}