using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
namespace KnowIsKnow
{
    /// <summary>
    /// WS 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class WS : System.Web.Services.WebService
    {
        

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string UpdateTopicInfo(string topicid, string topictitle, string topicdes, string topicpicurl, string topicattention, string topicstate) 
        {
            BLL.TopicInfo topic = new BLL.TopicInfo();
            Model.TopicInfo topicinfo = new Model.TopicInfo();
            topicinfo.topicID = Convert.ToInt32(topicid);
            topicinfo.topicTitle = topictitle;
            topicinfo.topicDes = topicdes;
            topicinfo.topicPicUrl = topicpicurl;
            topicinfo.topicAttention = Convert.ToInt32( topicattention);
            topicinfo.topicState = topicstate;
            topic.Update(topicinfo);
            return "ok";
        }
        [WebMethod]
        public List<Model.UserInfo> selectUserInfo(string usernickname ) 
        {
            BLL.UserInfo userinfo = new BLL.UserInfo();
            List<Model.UserInfo> da = userinfo.GetModelList("userNickName like '%" + usernickname + "%'");
         
            
            return da; 
        }
        [WebMethod]
        public void AddCareTopic(string topicid,string userid)
        {
            BLL.CareTopic topic = new BLL.CareTopic();
            Model.CareTopic topicinfo = new Model.CareTopic();
            topicinfo.careTopicID = Convert.ToInt32(topicid);
            topicinfo.topicCaredByUID = Convert.ToInt32( userid);
        
            topic.Add(topicinfo);
            
        }
        [WebMethod]
        public  void DeleteCareTopic(int topicid, int userid)
        {
            BLL.CareTopic topic = new BLL.CareTopic();
            Model.CareTopic topicinfo = new Model.CareTopic();
            topic.Delete(topicid,userid);
            
        }
    }
}
