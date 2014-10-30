using SendEmailSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Security.Cryptography;
using System.Web.Security;

using System.Collections.Specialized;

namespace KnowIsKnow
{
    public partial class resetpassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           //Response.Write(FormsAuthentication.HashPasswordForStoringInConfigFile("123", "MD5"));   
        }     

        protected void resetpwd_Click(object sender, EventArgs e)
        {
            //string strInput = "zqy123";
            //byte[] b = System.Text.Encoding.UTF8.GetBytes(strInput);
            ////计算字符串UTF8编码后的MD5哈希值，并转换为字符串  
            //MD5 md5 = new MD5CryptoServiceProvider();
            //string str=System.Text.Encoding.UTF8.GetString(md5.ComputeHash(b));  
            tipfault.InnerHtml = "";
            

            string email =rspemail.Value;

            BLL.UserInfo blluser = new BLL.UserInfo();

            int count = blluser.GetRecordCount("userEmail='" + email + "'");
            if (count == 0)
            {
                tipfault.InnerHtml="账号不存在";
            }
            else
            {
                DataSet ds = blluser.GetList("userEmail='" + email + "'");
                string yanzheng = Convert.ToString(ds.Tables[0].Rows[0]["userVerifyCode"]);
                MailRequest mail = new MailRequest();
                mail.Subject = "请确认你在知为知的重置密码请求";//主题
                mail.Body = "<div style='width:500px;height:300px;margin:auto;'><div style='width:500px;height:250px; border:1px solid #DEDEDE;margin:auto;'> <div style='height:40px;font-size:25px;color:#FFF;line-height:40px;background-color:#0a82e4;text-align:center;'>知为知</div> <div style='font-size:17px;color:#7b7b7b;padding-left:30px;font-weight:bold;line-height:70px;'>你好</div><div style='font-size:14px;color:#7b7b7b;padding-left:30px;line-height:30px;'>知为知已收到了你的密码重置请求，请24小时内点击下面的按钮重置密码<br/> 请记住您的验证码：" + yanzheng + "</div> <a href='http://114.215.109.40//setnewpassword.aspx?verifycode=" + email + " ' style='padding:10px 25px 10px 25px;border-radius:3px;text-align:center;text-decoration:none;background-color:#0a82e4;color:#ffffff;font-size:17px;display:inline-block; margin:15px 0 0 170px;;white-space:nowrap'>重置密码</a></div><span style='font-size:12px;color:#b6c2cc;margin:10px 0 0 130px;display:block;'>你可以通过  <a href='http://localhost:38547/Setting.aspx' style='border:none;color:#8a939b;text-decoration:none; font-size:14px;'>设置</a>  管理其它来知为知的邮件</span><span style='font-size:12px;color:#b6c2cc;line-height:17px;display:block;margin:5px 0 0 195px;'>© 2014 知为知</span><div style='display:none;' mail=" + email + "></div></div>";//内容
                //mail.Bcc = "13337965191@163.com";//秘密抄送人
                mail.From = "13337965191@163.com";//发送人
                mail.CC = email;//抄送人
                mail.To = email;//收件人



                string sendMainResult = "";
                if (!string.IsNullOrEmpty(mail.CC.Replace(";", "")) && !string.IsNullOrEmpty(mail.To.Replace(";", "")))
                {
                    sendMainResult = MailHelper.SendMail(mail);
                }
                Response.Write(sendMainResult);

                qingkong.InnerHtml = "";
                qingkong.InnerHtml += "<div class='chenggong'>";
                qingkong.InnerHtml += " 密码重设的链接已发送至<br />";
                qingkong.InnerHtml += "<span class='fsyouxiang' style='margin-top:5px;' runat='server' id='faemail'>" + email + "</span>";
                qingkong.InnerHtml += " </div>";

            }            
        }
    }
}