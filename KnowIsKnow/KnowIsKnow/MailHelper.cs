using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Configuration;

namespace SendEmailSample
{
    /// <summary>
    /// 邮件帮助类
    /// </summary>
    public static class MailHelper
    {
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="request">邮件内容对象</param>
        /// <returns>发送邮件所遇到的异常</returns>
        public static string SendMail(MailRequest request)
        {
            try
            {
                MailMessage mail = new MailMessage();

                if (string.IsNullOrEmpty(request.From))
                {
                    request.From = WebConfigurationManager.AppSettings["DefaultMailFrom"];
                }
                mail.From = new MailAddress(request.From);

                PaserMailAddress(request.To, mail.To);
                PaserMailAddress(request.CC, mail.CC);
                PaserMailAddress(request.Bcc, mail.Bcc);

                mail.Subject = request.Subject;
                mail.SubjectEncoding = System.Text.Encoding.UTF8;
                mail.Body = request.Body;
                mail.ReplyTo = new MailAddress(request.From);
                mail.IsBodyHtml = true;

                if (request.Attachments != null && request.Attachments.Length > 0)
                {
                    for (int i = 0; i < request.Attachments.Length; i++)
                    {
                        Attachment mailAttach = new Attachment(ByteArrayToStream(request.Attachments[i].FileData), request.Attachments[i].FileName);

                        mail.Attachments.Add(mailAttach);
                    }
                }

                if (string.IsNullOrEmpty(WebConfigurationManager.AppSettings["SMTPSERVER"]))
                {
                    throw new ApplicationException("邮件服务无效");
                }

                //Smtp Server
                SmtpClient mailClient = new SmtpClient(WebConfigurationManager.AppSettings["SMTPSERVER"]);

                if (!string.IsNullOrEmpty(WebConfigurationManager.AppSettings["SMTPSERVERPORT"]))
                {
                    //端口号
                    try
                    {
                        mailClient.Port = Int32.Parse(WebConfigurationManager.AppSettings["SMTPSERVERPORT"]);
                    }
                    catch
                    {
                        return "SMTP服务器端口设置错误，端口必须设置为数值型";
                    }
                }

                if (!string.IsNullOrEmpty(WebConfigurationManager.AppSettings["MAILUSER"]))
                {
                    mailClient.Credentials = new System.Net.NetworkCredential(WebConfigurationManager.AppSettings["MAILUSER"], WebConfigurationManager.AppSettings["MAILUSERPW"]);
                    mailClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                }
                else
                {
                    mailClient.Credentials = CredentialCache.DefaultNetworkCredentials;
                }

                mailClient.Send(mail);
                mail.Dispose();

                return "";
            }
            catch (SmtpFailedRecipientsException e)
            {
                return e.Message;
            }
            catch (SmtpFailedRecipientException e)
            {
                return e.Message;
            }
            catch (SmtpException e)
            {
                return e.Message;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        /// <summary>
        /// 解析分解邮件地址
        /// </summary>
        /// <param name="mailAddress">邮件地址</param>
        /// <param name="mailCollection">邮件对象</param>
        private static void PaserMailAddress(string mailAddress, MailAddressCollection mailCollection)
        {
            if (string.IsNullOrEmpty(mailAddress))
            {
                return;
            }

            char[] separator = new char[2] { ',', ';' };
            string[] addressArray = mailAddress.Split(separator);

            foreach (string address in addressArray)
            {
                if (address.Trim() == string.Empty)
                {
                    continue;
                }

                mailCollection.Add(new MailAddress(address));
            }
        }

        /// <summary>
        /// 字节数组转换为流
        /// </summary>
        /// <param name="byteArray">字节数组</param>
        /// <returns>Stream</returns>
        private static Stream ByteArrayToStream(byte[] byteArray)
        {
            MemoryStream mstream = new MemoryStream(byteArray);

            return mstream;
        }
    }
}