using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using SendEmailSample;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KnowIsKnow
{
    /// <summary>
    /// WSZQY 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class WSZQY : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(EnableSession = true)]
        public string yanzhengma()
        {
            return Session["CheckCode"].ToString();
        }

        [WebMethod(EnableSession = true)]
        public string denglu( string useremail,string  userpwd)
        {
            BLL.UserInfo blldenglu = new BLL.UserInfo();
            string jiamipwd = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(userpwd, "MD5").ToLower();
            DataSet ds = blldenglu.GetList("userEmail='" + useremail + "' and userPwd='" + jiamipwd + "'");
            //string str =Convert.ToString( ds.Tables[0].Rows.Count);
            if (ds.Tables[0].Rows.Count != 0)
            {
                Session["UserID"] = Convert.ToInt32(ds.Tables[0].Rows[0]["userID"]);
                Session["UserNickName"] = Convert.ToString(ds.Tables[0].Rows[0]["userNickName"]);
                Session["UserHeadImage"] = Convert.ToString(ds.Tables[0].Rows[0]["userHeadImage"]);
                Session["UserEmail"] = Convert.ToString(ds.Tables[0].Rows[0]["userEmail"]);
                Session["UserPwd"] = Convert.ToString(ds.Tables[0].Rows[0]["userPwd"]);
            }
            return Convert.ToString(ds.Tables[0].Rows.Count);
        }

        [WebMethod(EnableSession=true)]
        public string zhuce(string xing, string ming, string email, string mima)
        {
            BLL.UserInfo blluser = new BLL.UserInfo();
            int count= blluser.GetRecordCount("userEmail='" + email + "'");
            if (count ==0)
            {
                Model.UserInfo modeluser = new Model.UserInfo();
                string strGUID = System.Guid.NewGuid().ToString(); //直接返回字符串类型
                string xm = xing + ming;
                string jiamipwd = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(mima, "MD5").ToLower();
                modeluser.userEmail = email;
                modeluser.userPwd = jiamipwd;
                modeluser.userNickName = xm;
                modeluser.userGender = "男";
                modeluser.userVerifyCode = strGUID;
                modeluser.userHeadImage = "images/headImages/1.png";
                int userid= blluser.Add(modeluser);

                //向注册邮箱发送邮件通知激活
                MailRequest mail = new MailRequest();
                mail.Subject = "请确认你在知为知的注册邮箱";//主题
                mail.Body = "<div style='width:500px;height:300px;margin:auto;'><div style='width:500px;height:250px; border:1px solid #DEDEDE;margin:auto;'> <div style='height:40px;font-size:25px;color:#FFF;line-height:40px;background-color:#0a82e4;text-align:center;'>知为知</div> <div style='font-size:17px;color:#7b7b7b;padding-left:30px;font-weight:bold;line-height:70px;'>" + xing + "" + ming + " 欢迎加入知为知</div><div style='font-size:14px;color:#7b7b7b;padding-left:30px;line-height:40px;'>为保证你正常使用知为知的「提问」「回答」「评论」等功能,请激活账号。</div> <a href='http://114.215.109.40/Home.aspx?verifycode=" + strGUID + "'  style='padding:10px 25px 10px 25px;border-radius:3px;text-align:center;text-decoration:none;background-color:#0a82e4;color:#ffffff;font-size:17px;display:inline-block; margin:20px 0 0 170px;;white-space:nowrap'>立即激活账号</a></div><span style='font-size:12px;color:#b6c2cc;margin:10px 0 0 130px;display:block;'>你可以通过  <a href='http://localhost:38547/Home.aspx' style='border:none;color:#8a939b;text-decoration:none; font-size:14px;'>设置</a>  管理其它来知为知的邮件</span><span style='font-size:12px;color:#b6c2cc;line-height:17px;display:block;margin:5px 0 0 195px;'>© 2014 知为知</span><div style='display:none;'>" + strGUID + "</div></div>";//内容
                mail.Bcc = "13337965191@163.com";//秘密抄送人
                mail.From = "13337965191@163.com";//发送人
                mail.CC = email;//抄送人
                mail.To = email;//收件人

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
                
            

                //存储session
                Session["UserID"] = userid;
                Session["UserNickName"] = xm;
                Session["UserEmail"] = email;
                Session["UserPwd"] = jiamipwd;

                return "yes";
            }
            else
            {
                return "no";
            }
            
        }


        [WebMethod]
        public string updataPwd(string userid, string userpwd, string shurumima, string yuanlaimima)
        {
            BLL.UserInfo blluserinfo = new BLL.UserInfo();
            string jiamipwd = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(userpwd, "MD5").ToLower();
            string shuru = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(shurumima, "MD5").ToLower();
            if (yuanlaimima == shuru)
            {
                int uid = Convert.ToInt32(userid);
                Model.UserInfo modeluser = blluserinfo.GetModel(uid);
                modeluser.userPwd = jiamipwd;
                return blluserinfo.Update(modeluser).ToString();
            }
            else
            {
                return "no";
            }
            
        }


        [WebMethod]
        public string chongzhimima(string userid, string userpwd)
        {
            BLL.UserInfo blluserinfo = new BLL.UserInfo();
            int uid = Convert.ToInt32(userid);
            string czpwd = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(userpwd, "MD5").ToLower();
            Model.UserInfo modeluser = blluserinfo.GetModel(uid);
            modeluser.userPwd = czpwd;
            return blluserinfo.Update(modeluser).ToString();
        }

    }
}
