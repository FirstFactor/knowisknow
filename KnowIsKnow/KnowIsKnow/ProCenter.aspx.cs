using System;
using System.Collections.Generic;
using System.Data;
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
        public int myquestion;
        public int myreply;
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.UserInfo blluserinfo = new BLL.UserInfo();
            if (Session["UserID"] == null)
            {

                Response.Redirect("Index.aspx");
                return;

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
            

                BLL.QuestionInfo countmyquestion = new BLL.QuestionInfo();
                myquestion= countmyquestion.GetRecordCount("questionProvider="+userid);

                BLL.ReplyQuestion countmyreply = new BLL.ReplyQuestion();
                myreply= countmyreply.GetRecordCount("replyofUID="+userid+" and replyofReplyID=0");



                BLL.TopicUserView topicuser = new BLL.TopicUserView();

                DataSet ds=  topicuser.GetList("userID="+userid);
                this.rtpcared.DataSource = ds.Tables[0];
                this.rtpcared.DataBind();
                BLL.TopicUserView bllTopuv = new BLL.TopicUserView();
                DataSet da = bllTopuv.GetList("userID="+userid);
                this.Repeater2.DataSource = ds.Tables[0];
                this.Repeater2.DataBind();

            }
            
        }

        protected void wtbuttonlast_Click(object sender, EventArgs e)
        {
            BLL.UserInfo ww = new BLL.UserInfo();
            Model.UserInfo tt = ww.GetModel(userid);
            tt.userAcademy = Request.Form["wtinputschool"];
            tt.userProBio = Request.Form["wtzm-profile-edit-description"];
            tt.userJob = Request.Form["wth-business"];
            tt.userAdress = Request.Form["wth-jv"];
            tt.userCompany = Request.Form["wth-company"];
            tt.userJobPosition = Request.Form["wth-position"];
            tt.userMajor = Request.Form["wth-major"];

            tt.userGender = xingbie.Value;

            Response.Write(tt.userGender);
            ww.Update(tt);
            
            Response.Redirect("ProCenter.aspx");
        }
    }
}