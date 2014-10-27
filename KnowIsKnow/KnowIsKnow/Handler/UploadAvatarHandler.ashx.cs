using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Handler
{
    /// <summary>
    /// UploadAvatarHandler 的摘要说明
    /// </summary>
    public class UploadAvatarHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Charset = "utf-8";

            System.IO.Stream stream = null;
            System.Drawing.Image originalImg = null;   //原图
            System.Drawing.Image thumbImg = null;      //缩放图       


            try
            {
                int minWidth = 100;   //最小宽度
                int minHeight = 100;  //最小高度
                int maxWidth = 500;  //最大宽度
                int maxHeight = 500;  //最大高度

                string resultTip = string.Empty;  //返回信息

                HttpPostedFile file = context.Request.Files["Filedata"];      //上传文件      

                string uploadPath = HttpContext.Current.Server.MapPath(@context.Request["folder"]);  //得到上传路径

                string lastImgUrl = @context.Request.Params["LastImgUrl"];

                if (!string.IsNullOrEmpty(lastImgUrl))
                {
                    PubClass.FileDel(HttpContext.Current.Server.MapPath(lastImgUrl));
                }

                if (file != null)
                {
                    if (!System.IO.Directory.Exists(uploadPath))
                    {
                        System.IO.Directory.CreateDirectory(uploadPath);
                    }

                    string ext = System.IO.Path.GetExtension(file.FileName).ToLower();   //上传文件的后缀（小写）

                    if (ext == ".jpg" || ext == ".png")
                    {
                        string flag = "ThumbNail" + DateTime.Now.ToFileTime() + ext;

                        string uploadFilePath = uploadPath + "\\" + flag;   //缩放图文件路径

                        stream = file.InputStream;

                        originalImg = System.Drawing.Image.FromStream(stream);

                        if (originalImg.Width > minWidth && originalImg.Height > minHeight)
                        {
                            thumbImg = PubClass.GetThumbNailImage(originalImg, maxWidth, maxHeight);  //按宽、高缩放

                            if (thumbImg.Width > minWidth && thumbImg.Height > minWidth)
                            {
                                thumbImg.Save(uploadFilePath);

                                resultTip = @context.Request["folder"] + "\\" + flag + "$" + thumbImg.Width + "$" + thumbImg.Height;
                            }
                            else
                            {
                                resultTip = "图片比例不符合要求";
                            }
                        }
                        else
                        {
                            resultTip = "图片尺寸必须大于" + minWidth + "*" + minHeight;
                        }
                    }
                }
                else
                {
                    resultTip = "上传文件为空";
                }

                context.Response.Write(resultTip);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (originalImg != null)
                {
                    originalImg.Dispose();
                }

                if (stream != null)
                {
                    stream.Close();
                    stream.Dispose();
                }

                if (thumbImg != null)
                {
                    thumbImg.Dispose();
                }

                GC.Collect();
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}