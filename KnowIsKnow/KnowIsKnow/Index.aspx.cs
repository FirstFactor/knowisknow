using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using SendEmailSample;

namespace KnowIsKnow
{
    public partial class Index : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.UserInfo blluserinfo = new BLL.UserInfo();
            DataSet ds = blluserinfo.GetList("userID<'" + 154 + "'");
            this.touph.DataSource = ds.Tables[0];

            this.touph.DataBind();


            
        }

        protected void btnzhuce_Click(object sender, EventArgs e)
        {
            string xing = inputxing.Value;
            string ming = inputming.Value;
            string youx = inputyx.Value;
            string mima = inputmm.Value;
            faultshow.InnerHtml = "";


            string strGUID = System.Guid.NewGuid().ToString(); //直接返回字符串类型

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
                MailRequest mail = new MailRequest();
                mail.Subject = "请确认你在知乎知的注册邮箱";//主题
                mail.Body = "<div style='width:500px;height:300px;margin:auto;'><div style='width:500px;height:250px; border:1px solid #DEDEDE;margin:auto;'> <div style='height:40px;font-size:25px;color:#FFF;line-height:40px;background-color:#0a82e4;text-align:center;'>知乎知</div> <div style='font-size:17px;color:#7b7b7b;padding-left:30px;font-weight:bold;line-height:70px;'>"+xing+""+ming+" 欢迎加入知乎</div><div style='font-size:14px;color:#7b7b7b;padding-left:30px;line-height:40px;'>为了保证你正常使用知乎的「提问」「回答」「评论」等功能,请激活账号。</div> <a href='http://localhost:38547/Home.aspx?verifycode="+strGUID+"' style='padding:10px 25px 10px 25px;border-radius:3px;text-align:center;text-decoration:none;background-color:#0a82e4;color:#ffffff;font-size:17px;display:inline-block; margin:30px 0 0 170px;;white-space:nowrap'>立即激活账号</a></div><span style='font-size:12px;color:#b6c2cc;margin:10px 0 0 130px;display:block;'>你可以通过  <a href='http://localhost:38547/Home.aspx' style='border:none;color:#8a939b;text-decoration:none; font-size:14px;'>设置</a>  管理其它来知乎知的邮件</span><span style='font-size:12px;color:#b6c2cc;line-height:17px;display:block;margin:5px 0 0 195px;'>© 2014 知乎知</span><div style='display:none;'>"+strGUID+"</div></div>";//内容
                mail.Bcc = "13337965191@163.com";//秘密抄送人
                mail.From = "13337965191@163.com";//发送人
                mail.CC = youx;//抄送人
                mail.To = youx;//收件人

                ////读取文件到bytes
                //FileStream stream = new FileStream(Path.Combine(Server.MapPath("~"), "doc\\test.txt"), FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
                //byte[] bytes = new byte[stream.Length];
                //stream.Read(bytes, 0, bytes.Length);
                //stream.Close();

                ////附件
                //MailRequestAttachments attachments = new MailRequestAttachments();
                //attachments.FileName = "test.txt";
                //attachments.FileData = bytes;
                //mail.Attachments = new MailRequestAttachments[] { 
                //        attachments
                //    };

                string sendMainResult = "-1";
                if (!string.IsNullOrEmpty(mail.CC.Replace(";", "")) && !string.IsNullOrEmpty(mail.To.Replace(";", "")))
                {
                    sendMainResult = MailHelper.SendMail(mail);
                }
                Response.Write(sendMainResult);



                //BLL.UserInfo blluserinfo = new BLL.UserInfo();
                Model.UserInfo modeluserinfo = new Model.UserInfo();
                modeluserinfo.userEmail = youx;
                modeluserinfo.userPwd = mima;
                modeluserinfo.userNickName = xing + ming;
                modeluserinfo.userVerifyCode = strGUID;
                modeluserinfo.userGender = "男";
                blluserinfo.Add(modeluserinfo);
               
                
                DataSet ds = blluserinfo.GetList("userEmail='" + youx + "'");
                Session["UserID"] = Convert.ToInt32(ds.Tables[0].Rows[0]["userID"]);
                Session["UserNickName"] = Convert.ToString(ds.Tables[0].Rows[0]["userNickName"]);
                Session["UserHeadImage"] = Convert.ToString(ds.Tables[0].Rows[0]["userHeadImage"]);
                Session["UserEmail"] = Convert.ToString(ds.Tables[0].Rows[0]["userEmail"]);
                Session["UserPwd"] = Convert.ToString(ds.Tables[0].Rows[0]["userPwd"]);

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