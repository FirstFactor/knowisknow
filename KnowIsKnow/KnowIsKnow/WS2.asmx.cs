using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
namespace KnowIsKnow
{
    /// <summary>
    /// WS2 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class WS2 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public void gdhuati(string topicid, string userid, string careTopicState)
        {
            BLL.CareTopic topic = new BLL.CareTopic();
            Model.CareTopic topicinfo = topic.GetModel( Convert.ToInt32( topicid),  Convert.ToInt32( userid));
            topicinfo.careTopicState = "special";

            topic.Update(topicinfo);

        }
        [WebMethod]
        public void quxiaogd(string topicid, string userid, string careTopicState)
        {
            BLL.CareTopic topic = new BLL.CareTopic();
            Model.CareTopic topicinfo = topic.GetModel(Convert.ToInt32(topicid), Convert.ToInt32(userid));
            topicinfo.careTopicState = "normal";
            topic.Update(topicinfo);
            
        }
    }
   
}
