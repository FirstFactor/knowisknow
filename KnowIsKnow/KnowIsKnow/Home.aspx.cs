using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace KnowIsKnow
{
    public partial class Home : System.Web.UI.Page
    {
        public string userid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Write("<script>window.location.href='index.aspx'</script>");
            }
            else {
                userid = Session["UserID"].ToString();
                BLL.QuestionUserView quelist = new BLL.QuestionUserView();
                DataSet ds = quelist.GetList("1=1 order by quetionPubTime desc");
                this.rpt.DataSource = ds.Tables[0];
                this.rpt.DataBind();

            }
        }

        
        
    }
}