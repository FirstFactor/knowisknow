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
                DataSet ds = quelist.GetList("questionSate='normal' and questionCaredByUID=" + userid_caredquestion + "  order by quetionPubTime desc");
                this.rpt.DataSource = ds.Tables[0];
                this.rpt.DataBind();

            }
        }
        
    }
}