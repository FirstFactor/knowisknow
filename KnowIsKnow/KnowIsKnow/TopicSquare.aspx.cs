using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KnowIsKnow
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        public int userID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("Index.aspx");
            }
            else
            {
                userID = Convert.ToInt32(Session["UserID"]);
                BLL.TopicInfo questionlist = new BLL.TopicInfo();
                DataSet ds = questionlist.GetList("1=1");
                this.rptquestionlist.DataSource = ds.Tables[0];
                this.rptquestionlist.DataBind();
            }
            
            
        }
        public string Check(object topicID)
        {
            int tpID = Convert.ToInt32(topicID);
            BLL.CareTopic BLLCareTopic = new BLL.CareTopic();
            List< Model.CareTopic> list=  BLLCareTopic.GetModelList("topicCaredByUID=" + userID );
            for (int i = 0; i < list.Count; i++)
            {

                if (list[i].careTopicID == tpID)
                {
                    return "true";
                }
            }


            return "false";

        }
    }
}