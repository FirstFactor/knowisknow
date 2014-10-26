using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace KnowIsKnow
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        public string userid_caredquestion;
        public string caredquestioncount;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Write("<script>window.location.href='index.aspx'</script>");
            }
            else
            {
                userid_caredquestion = Session["UserID"].ToString();
                BLL.CareQuestionQuestionUserView quelist = new BLL.CareQuestionQuestionUserView();
                List<Model.CareQuestionQuestionUserView> list = quelist.GetModelList("questionCaredByUID=" + userid_caredquestion);
                caredquestioncount = list.Count.ToString();
                DataSet ds = quelist.GetList("questionSate='normal' and questionCaredByUID=" + userid_caredquestion + "  order by quetionPubTime desc");
                this.rpt.DataSource = ds.Tables[0];
                this.rpt.DataBind();

            }
        }

        public string CheckCarePerson(object questionProvider)
        {
            BLL.CarePerson cq = new BLL.CarePerson();
            List<Model.CarePerson> list = cq.GetModelList("personCaredByUID=" + userid_caredquestion);
            int qid = Convert.ToInt32(questionProvider);
            int mid = Convert.ToInt32(userid_caredquestion);
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
        
    }
}