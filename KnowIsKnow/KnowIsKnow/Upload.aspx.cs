using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KnowIsKnow
{
    public partial class Upload : System.Web.UI.Page
    {
        public HttpPostedFile file;
        protected void Page_Load(object sender, EventArgs e)
        {

            file = Request.Files["FileData"];
            string uploadpath = Server.MapPath(Request["folder"] + "\\");
            string pictureNewName = "";

            bool isok = false;

            string strOldFilePath = "";
            string strExtension = "";
            string[] arrExtension = { ".gif", ".jpg", ".bmp", ".png" };
            if (file.FileName != string.Empty)
            {
                strOldFilePath = file.FileName;//获得文件的完整路径名 
                strExtension = strOldFilePath.Substring(strOldFilePath.LastIndexOf("."));//获得文件的扩展名，如：.jpg 
                for (int i = 0; i < arrExtension.Length; i++)
                {
                    if (strExtension.Equals(arrExtension[i]))
                    {
                        isok = true;
                    }
                }
            }
            if (isok == false)
            {
                Response.Write("1");
                return;
            }




            if (file != null)
            {
                if (!Directory.Exists(uploadpath))
                {
                    Directory.CreateDirectory(uploadpath);
                }
                int idx = file.FileName.LastIndexOf(".");
                string suffix = file.FileName.Substring(idx);
                pictureNewName = DateTime.Now.Ticks.ToString() + suffix;

                file.SaveAs(uploadpath + pictureNewName);
                string str = uploadpath + pictureNewName;

                string[] s = Regex.Split(str, "\\\\images", RegexOptions.IgnoreCase);
                string picpath = "images" + s[1];
                Response.Write(picpath);
            }
            else
            {
                Response.Write("0");
            }
        }
    }
}