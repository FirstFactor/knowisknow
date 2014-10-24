using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace KnowIsKnow
{
    public partial class setnewpassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string email = Convert.ToString(Request.QueryString["verifycode"]);
            BLL.UserInfo blluser = new BLL.UserInfo();
            DataSet ds = blluser.GetList("userEmail='" + email + "'");
            string xuliehao = Convert.ToString(ds.Tables[0].Rows[0]["userVerifyCode"]);
            string userid = Convert.ToString(ds.Tables[0].Rows[0]["userID"]);
            dddd.InnerHtml = xuliehao;
            eeee.InnerHtml = userid;

        }

        //protected void btncz_Click(object sender, EventArgs e)
        //{
        //    string fpassword = diyici.Value;
        //    string spassword = dierci.Value;
        //    string yanzheng = xuliehao.Value;
        //    string email= Convert.ToString( Request.QueryString["verifycode"]);
            

        //}

    }
}