﻿using SendEmailSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KnowIsKnow
{
    public partial class resetpassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void resetpwd_Click(object sender, EventArgs e)
        {
           

            string email = rspemail.Value;

            if (email != "")
            {
                MailRequest mail = new MailRequest();
                mail.Subject = "请确认你在知乎知的注册邮箱";//主题
                mail.Body = "<div style='width:500px;height:300px;margin:auto;'><div style='width:500px;height:250px; border:1px solid #DEDEDE;margin:auto;'> <div style='height:40px;font-size:25px;color:#FFF;line-height:40px;background-color:#0a82e4;text-align:center;'>知乎知</div> <div style='font-size:17px;color:#7b7b7b;padding-left:30px;font-weight:bold;line-height:70px;'>你好</div><div style='font-size:14px;color:#7b7b7b;padding-left:30px;line-height:40px;'>知为知已收到了你的密码重置请求，请24小时内点击下面的按钮重置密码</div> <a href='http://localhost:38547/setnewpassword.aspx?verifycode="+email+"' style='padding:10px 25px 10px 25px;border-radius:3px;text-align:center;text-decoration:none;background-color:#0a82e4;color:#ffffff;font-size:17px;display:inline-block; margin:30px 0 0 170px;;white-space:nowrap'>重置密码</a></div><span style='font-size:12px;color:#b6c2cc;margin:10px 0 0 130px;display:block;'>你可以通过  <a href='http://localhost:38547/Setting.aspx' style='border:none;color:#8a939b;text-decoration:none; font-size:14px;'>设置</a>  管理其它来知乎知的邮件</span><span style='font-size:12px;color:#b6c2cc;line-height:17px;display:block;margin:5px 0 0 195px;'>© 2014 知乎知</span><div style='display:none;' mail=" + email + "></div></div>";//内容
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
                qingkong.InnerHtml +="<div class='chenggong'>";
                qingkong.InnerHtml += " 密码重设的链接已发送至<br />";
                qingkong.InnerHtml += "<span class='fsyouxiang' style='margin-top:5px;' runat='server' id='faemail'>"+email+"</span>";
                qingkong.InnerHtml += " </div>";

            }
            
        }
    }
}