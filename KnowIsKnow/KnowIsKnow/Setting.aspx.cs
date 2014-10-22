using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KnowIsKnow
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"]==null)
            {
                Response.Redirect("Index.aspx");
            }
            xingming.InnerHtml = Session["UserNickName"].ToString();
            wodeemail.InnerHtml = Session["UserEmail"].ToString();
            cfuserid.InnerHtml = Session["UserID"].ToString();
            cfuserpwd.InnerHtml = Session["UserPwd"].ToString();
        }

    }
}