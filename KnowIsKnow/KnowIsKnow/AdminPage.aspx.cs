﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KnowIsKnow
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
 
        }

        protected void UpLoadbtn1_Click(object sender, EventArgs e)
        {

           

            try
            {
                if (FileUpload1.PostedFile.FileName == "")
                {
                    this.Label1.Text = "请选择文件！";
                }
                else
                {
                    string filepath = FileUpload1.PostedFile.FileName;
                    //if (!IsAllowedExtension(FileUpload1)) 
                    //{ 
                    //    this.lb_info.Text = "上传文件格式不正确！"; 
                    //} 
                    if (IsAllowedExtension(FileUpload1) == true)
                    {
                        string filename = filepath.Substring(filepath.LastIndexOf("\\") + 1);
                        string serverpath = Server.MapPath("~/images/") + filename;
                        FileUpload1.PostedFile.SaveAs(serverpath);
                        this.Label1.Text = "上传成功！";
                    }
                    else
                    {
                        this.Label1.Text = "请上传图片！";
                    }
                }
            }
            catch (Exception ex)
            {
                this.Label1.Text = "上传发生错误！原因：" + ex.ToString();
            } 
        }

        private static bool IsAllowedExtension(FileUpload upfile)
        {
            string strOldFilePath = "";
            string strExtension = "";
            string[] arrExtension = { ".gif", ".jpg", ".bmp", ".png" };

           


            if (upfile.PostedFile.FileName != string.Empty)
            {
                strOldFilePath = upfile.PostedFile.FileName;//获得文件的完整路径名 
                strExtension = strOldFilePath.Substring(strOldFilePath.LastIndexOf("."));//获得文件的扩展名，如：.jpg 
                for (int i = 0; i < arrExtension.Length; i++)
                {
                    if (strExtension.Equals(arrExtension[i]))
                    {
                        return true;
                    }
                }
            }
            return false;
        } 
    }
}