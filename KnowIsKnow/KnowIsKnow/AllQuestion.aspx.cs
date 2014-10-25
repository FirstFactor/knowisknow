using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace KnowIsKnow
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string userid_allquestion;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Write("<script>window.location.href='index.aspx'</script>");
            }
            else
            {
                userid_allquestion = Session["UserID"].ToString();
                BLL.QuestionUserView quelist = new BLL.QuestionUserView();
                DataSet ds = quelist.GetList("questionSate='normal' order by quetionPubTime desc");
                this.rpt.DataSource = ds.Tables[0];
                this.rpt.DataBind();

            }
        }
        public string CheckCareQuestion(object questionID)
        {
            BLL.CareQuestion cq = new BLL.CareQuestion();
            List<Model.CareQuestion> list = cq.GetModelList("questionCaredByUID=" + userid_allquestion);
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

        public string CheckQusetionProvider(object questionID)
        {
            BLL.QuestionUserView checkQP = new BLL.QuestionUserView();
            List<Model.QuestionUserView> QPlist = checkQP.GetModelList("questionProvider=" + userid_allquestion);
            int qp = Convert.ToInt32(questionID);
            for (int y = 0; y < QPlist.Count; y++) {
                if (QPlist[y].questionID == qp) { 
                    return "myQuestion";
                }
            }
            return "noMyQuestion";
        }

        public string CheckCarePerson(object questionProvider)
        {
            BLL.CarePerson cq = new BLL.CarePerson();
            List<Model.CarePerson> list = cq.GetModelList("personCaredByUID=" + userid_allquestion);
            int qid = Convert.ToInt32(questionProvider);
            int mid= Convert.ToInt32(userid_allquestion);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].carePersonID == qid)
                {
                    return "follow";
                }
            }
            if(qid==mid){
                return "myself";
            }
            return "nofollow";
        }
    }
}