using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KnowIsKnow
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public int userid;
        public string headimg;
        public string gender;
        public string address;
        public string company;
        public string academy;
        public string job;
        public string position;
        public string major;
        public string probio;
        public string shuoshuo;
        public string nickname;
      
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.UserInfo blluserinfo = new BLL.UserInfo();
            if (Session["UserID"] == null)
            {

                Session["UserID"] = 3;
                Session["UserNickName"]="wangkan";
                 Session["UserHeadImage"]="1";

            }
            else {
                userid=Convert.ToInt32( Session["UserID"]);
                Model.UserInfo user = blluserinfo.GetModel(userid);
                headimg= user.userHeadImage;
                address=user.userAdress;
                company= user.userCompany;
                academy= user.userAcademy;
                gender=user.userGender;
                job=user.userJob;
                position= user.userJobPosition;
                major= user.userMajor;
                probio=user.userProBio;
                shuoshuo= user.userShuoShuo;
                nickname= user.userNickName;
            }
            
        }
    }
}