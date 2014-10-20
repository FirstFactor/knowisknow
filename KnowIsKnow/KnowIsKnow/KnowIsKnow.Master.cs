using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KnowIsKnow
{
  
    public partial class KnowIsKnow : System.Web.UI.MasterPage
    {
        string userid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                return;

            }
            else
            {
                userid = Session["UserID"].ToString();
            }
        }
    }
}