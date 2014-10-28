using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace KnowIsKnow
{
  
    public partial class KnowIsKnow : System.Web.UI.MasterPage
    {
        public string userid;
        public string usernickname;
        public string userheadimg;
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
            if (Session["UserID"] == null)
            {
                return;

            }
            else
            {
                userid = Session["UserID"].ToString();
                usernickname = Session["UserNickName"].ToString();
                userheadimg = Session["UserHeadImage"].ToString();
                string  useremail=Session["userEmail"].ToString();
                string verify = Convert.ToString(Request.QueryString["verifycode"]);
                if (verify != null)  
                {
                    BLL.UserInfo blluse = new BLL.UserInfo();
                    Model.UserInfo modeluser = blluse.GetModel(Convert.ToInt32(userid));
                    modeluser.userState = "verify";
                    blluse.Update(modeluser);
                }

                BLL.UserInfo blluser = new BLL.UserInfo();
                DataSet ds = blluser.GetList("userID='" + userid + "'");
                string yanzheng = Convert.ToString(ds.Tables[0].Rows[0]["userState"]);

                string mail = useremail.Substring(useremail.LastIndexOf("@") + 1);  // 截取    

                if (mail == "qq.com")
                {
                    if (yanzheng == "unverify")
                    {
                        jihuo.InnerHtml = "<div>欢迎！为正常使用知乎，请激活您的邮箱:<a href='https://mail.qq.com/cgi-bin/loginpage'>" + useremail + "</a></div>";
                    }
                };
                if (mail == "163.com")
                {
                     if (yanzheng == "unverify")
                    {
                        jihuo.InnerHtml = "<div>欢迎！为正常使用知乎，请激活您的邮箱:<a href='http://mail.163.com/'>" + useremail + "</a></div>";
                    }
                }
                if (mail == "sina.com")
                {
                    if (yanzheng == "unverify")
                    {
                        jihuo.InnerHtml = "<div>欢迎！为正常使用知乎，请激活您的邮箱:<a href='http://mail.sina.com.cn/'>" + useremail + "</a></div>";
                    }
                }
               
            }
        }
        
        //public void sendQuestion(object o, EventArgs e) {
        //    string questionTitle = this.txtQuestionTitle.Text;
        //    string questionContent = this.txtQuestionContent.InnerText;
        //    DateTime now = DateTime.Now;
        //    BLL.QuestionInfo bllque = new BLL.QuestionInfo();
        //    Model.QuestionInfo que = new Model.QuestionInfo();
        //    que.questionProvider = Convert.ToInt32(userid);
        //    que.questionTitle = questionTitle;
        //    que.questionContent = questionContent;
        //    que.quetionPubTime = now;
        //    que.questionSate = "unread";
        //    bllque.Add(que);
        //    Response.Write("<script>window.location.href='Home.aspx'</script>");
        //}
    }
}