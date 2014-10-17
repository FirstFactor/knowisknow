using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KnowIsKnow
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnzhuce_Click(object sender, EventArgs e)
        {
            string xing = inputxing.Value;
            string ming = inputming.Value;
            string youx = inputyx.Value;
            string mima = inputmm.Value;
            faultshow.InnerHtml = "";

            BLL.UserInfo blluserinfo = new BLL.UserInfo();
            int qq =blluserinfo.GetRecordCount("userEmail='" + youx + "'");

            if (xing == "")
            {
                faultshow.InnerHtml += "<p>请输入姓氏</p>";
            }
            if (ming == "")
            {
                faultshow.InnerHtml += "<p>请输入名字</p>";
            }
            if (youx == "")
            {
                faultshow.InnerHtml += "<p>请输入邮箱</p>";
            }

            if (mima == "")
            {
                faultshow.InnerHtml += "<p>请输入密码</p>";
            }


            if (qq == 1)
            {

                faultshow.InnerHtml = "<p>该邮箱已注册，请直接登录！</p>";

            }

            if (xing != "" && ming != "" && youx != "" && mima != "" && qq != 1)
            {
                //BLL.UserInfo blluserinfo = new BLL.UserInfo();
                Model.UserInfo modeluserinfo = new Model.UserInfo();
                modeluserinfo.userEmail = inputyx.Value;
                modeluserinfo.userPwd = inputmm.Value;
                modeluserinfo.userNickName = inputxing.Value + inputming.Value;
                modeluserinfo.userVerifyCode = "123456";
                modeluserinfo.userGender = "男";
                blluserinfo.Add(modeluserinfo);

                Session["UserEmail"] = inputyx.Value;

                Response.Redirect("http://localhost:38547/SelectTopic.aspx");

            }

        }

        protected void btndenglu_Click(object sender, EventArgs e)
        {
            BLL.UserInfo blldenglu = new BLL.UserInfo();
            string signyx = inputsignyx.Value;
            string signmm = inputsignmm.Value;
            //int qq= blldenglu.GetRecordCount("userEmail='" +signyx+"' and userPwd='" +signmm+"'");
            // if(qq==1)
            // {

            //     Response.Redirect("http://localhost:38547/Home.aspx");
            // }
            // else
            // {
            //     faultshow.InnerHtml = "";
            //     faultshow.InnerHtml = "<p>登录失败！</p>";
            //     faultshow.InnerHtml += "<p>请检查您的帐号和密码是否正确</p>";
            // }                      

            DataSet info = blldenglu.GetList("userEmail='" + signyx + "' and userPwd='" + signmm + "'");
            if (info.Tables[0].Rows.Count != 0)
            {
                Session["UserID"] = Convert.ToInt32(info.Tables[0].Rows[0]["userID"]);
                Session["UserNickName"] = Convert.ToString(info.Tables[0].Rows[0]["userNickName"]);
                Session["UserHeadImage"] = Convert.ToString(info.Tables[0].Rows[0]["userHeadImage"]);
                Session["UserEmail"] = Convert.ToString(info.Tables[0].Rows[0]["userEmail"]);
                Session["UserPwd"] = Convert.ToString(info.Tables[0].Rows[0]["userPwd"]);
                Response.Redirect("http://localhost:38547/Home.aspx");
                
                
            }
            else
            {
                faultshow.InnerHtml = "";
                faultshow.InnerHtml = "<p>登录失败！</p>";
                faultshow.InnerHtml += "<p>请检查您的帐号和密码是否正确</p>";
            }


        }

    }
}