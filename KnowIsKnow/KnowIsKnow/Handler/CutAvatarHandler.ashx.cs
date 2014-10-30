using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Handler
{
    /// <summary>
    /// CutAvatarHandler 的摘要说明
    /// </summary>
    public class CutAvatarHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Charset = "utf-8";

            System.Drawing.Bitmap bitmap = null;   //按截图区域生成Bitmap
            System.Drawing.Image thumbImg = null;      //被截图 
            System.Drawing.Graphics gps = null;    //存绘图对象   
            System.Drawing.Image finalImg = null;  //最终图片


            try
            {
                string pointX = context.Request.Params["pointX"];   //X坐标
                string pointY = context.Request.Params["pointY"];   //Y坐标
                string sizeWidth = context.Request.Params["sizeW"];     //选取区域的宽度
                string sizeHeight = context.Request.Params["sizeH"];   //选取区域的高度
                string imgUrl = context.Request.Params["imgUrl"];   //被截图图片地址
                string rlSize = context.Request.Params["maxVal"];        //截图矩形的大小
                string lujing = context.Request.Params["lujing"];

                int finalWidth = 100;
                int finalHeight = 100;

                if (!string.IsNullOrEmpty(pointX) && !string.IsNullOrEmpty(pointY) && !string.IsNullOrEmpty(imgUrl))
                {

                    string ext = System.IO.Path.GetExtension(imgUrl).ToLower();   //上传文件的后缀（小写）

                    bitmap = new System.Drawing.Bitmap(Convert.ToInt32(rlSize), Convert.ToInt32(rlSize));

                    thumbImg = System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath(imgUrl));

                    System.Drawing.Rectangle rl = new System.Drawing.Rectangle(Convert.ToInt32(pointX), Convert.ToInt32(pointY), Convert.ToInt32(rlSize), Convert.ToInt32(rlSize));   //得到截图矩形

                    gps = System.Drawing.Graphics.FromImage(bitmap);      //读到绘图对象

                    gps.DrawImage(thumbImg, 0, 0, rl, System.Drawing.GraphicsUnit.Pixel);

                    finalImg = PubClass.GetThumbNailImage(bitmap, finalWidth, finalHeight);

                    string finalPath = lujing + DateTime.Now.ToFileTime() + ext;

                    finalImg.Save(HttpContext.Current.Server.MapPath(finalPath));

                    bitmap.Dispose();
                    thumbImg.Dispose();
                    gps.Dispose();
                    finalImg.Dispose();
                    GC.Collect();

                    PubClass.FileDel(HttpContext.Current.Server.MapPath(imgUrl));

                    context.Response.Write(finalPath);
                }
            }
            catch (Exception)
            {
                throw;
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