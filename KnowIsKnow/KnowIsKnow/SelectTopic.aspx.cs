using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace KnowIsKnow
{
    public partial class SelectTopic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null || Session["UserEmail"].ToString() == null)
            {
                Response.Redirect("Index.aspx");
            }

            string no = "normal";
            BLL.TopicInfo topic = new BLL.TopicInfo();
            DataSet ds = topic.GetList("topicState='"+no+"'");
            this.topiclist.DataSource = ds.Tables[0];
          
            this.topiclist.DataBind();


            int userid = Convert.ToInt32(Session["UserID"]);
            aaa.InnerHtml = userid.ToString();

           
            
            
           
          
           
        }

      
    }
}