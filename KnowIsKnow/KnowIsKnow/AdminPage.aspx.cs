using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace KnowIsKnow
{
    public partial class AdminPage : System.Web.UI.Page
    {

        public string userNickName;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["AdminNickName"] == null)
            {
                Response.Redirect("AdminLogin.aspx");
                return;
            }
            userNickName = Session["AdminNickName"].ToString();

            //BLL.TopicInfo topic = new BLL.TopicInfo();
            //DataSet ds = topic.GetList(5,"1=1","1");
            //this.rpttopic.DataSource = ds.Tables[0];
            //this.rpttopic.DataBind();

            BLL.ReportQuestionUserView reportquestion = new BLL.ReportQuestionUserView();
            DataSet ds2 = reportquestion.GetList("reportQuestionDealState='undeal'");
            this.rptreportQeslist.DataSource = ds2.Tables[0];
            this.rptreportQeslist.DataBind();

            BLL.ReportReplyUserView reportreply = new BLL.ReportReplyUserView();
            DataSet ds3 = reportreply.GetList("reportReplyDealState='undeal'");
            this.rtpReportReply.DataSource = ds3.Tables[0];
            this.rtpReportReply.DataBind();
        }

        //protected void UpLoadbtn1_Click(object sender, EventArgs e)
        //{



        //    try
        //    {
        //        if (FileUpload1.PostedFile.FileName == "")
        //        {
        //            this.Label1.Text = "请选择文件！";
        //        }
        //        else
        //        {
        //            string filepath = FileUpload1.PostedFile.FileName;
        //            //if (!IsAllowedExtension(FileUpload1)) 
        //            //{ 
        //            //    this.lb_info.Text = "上传文件格式不正确！"; 
        //            //} 
        //            if (IsAllowedExtension(FileUpload1) == true)
        //            {
        //                string filename = filepath.Substring(filepath.LastIndexOf("\\") + 1);
        //                int idx = filename.LastIndexOf(".");
        //                string suffix = filename.Substring(idx);
        //                string newname = DateTime.Now.Ticks.ToString() + suffix;
        //                Session["newname"] = newname;
        //                string serverpath = Server.MapPath("~/images/topicImages/") + newname;
        //                FileUpload1.PostedFile.SaveAs(serverpath);
        //                this.Label1.Text = "上传成功！";
        //            }
        //            else
        //            {
        //                this.Label1.Text = "请上传图片！";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        this.Label1.Text = "上传发生错误！原因：" + ex.ToString();
        //    }
        //}

        //private static bool IsAllowedExtension(FileUpload upfile)
        //{
        //    string strOldFilePath = "";

        //    string strExtension = "";
        //    string[] arrExtension = { ".gif", ".jpg", ".bmp", ".png" };




        //    if (upfile.PostedFile.FileName != string.Empty)
        //    {
        //        strOldFilePath = upfile.PostedFile.FileName;//获得文件的完整路径名 

        //        strExtension = strOldFilePath.Substring(strOldFilePath.LastIndexOf("."));//获得文件的扩展名，如：.jpg 


        //        for (int i = 0; i < arrExtension.Length; i++)
        //        {
        //            if (strExtension.Equals(arrExtension[i]))
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    return false;
        //}

        protected void addbtn_Click(object sender, EventArgs e)
        {
         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("AdminLogin.aspx");
        }
    }
}