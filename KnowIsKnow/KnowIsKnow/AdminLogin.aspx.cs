using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

namespace KnowIsKnow
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void toadmin_Click(object sender, EventArgs e)
        {
            string email = ademail.Value;
            string pwd = adpassword.Value;
            BLL.AdminInfo blldenglu = new BLL.AdminInfo();
            DataSet info = blldenglu.GetList("adminEmail='" + email + "' and adminPwd='" + pwd + "'");
            if (info.Tables[0].Rows.Count != 0)
            {
                Session["AdminID"] = info.Tables[0].Rows[0]["adminID"];
                Session["AdminEmail"] = info.Tables[0].Rows[0]["adminEmail"];
                Session["AdminNickName"] = info.Tables[0].Rows[0]["adminNickName"];
                Response.Redirect("AdminPage.aspx");
            }
        }
    }
}