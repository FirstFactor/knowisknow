using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KnowIsKnow
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        public string userId;
        protected void Page_Load(object sender, EventArgs e)
        {
          

            if (Session["UserID"] == null)
            {
                Response.Write("<script>window.location.href='index.aspx'</script>");
                
            }
            else
            {
                Test test = new Test();
                List<Test> ls = new List<Test>();
                List<Test> lst = new List<Test>();
                
                userId = Session["UserID"].ToString();
                BLL.MessageUserView message = new BLL.MessageUserView();
                string sql = "select distinct MessageSenderID,MessageReceiverID from MessageUserView where ( MessageReceiverID =" + userId + " or MessageSenderID="+userId+") group by MessageSenderID,MessageReceiverID";
                DataSet ds = message.GetUnreadSenderList(sql);
                if (ds.Tables.Count > 0)
                {
                    foreach(DataRow row in ds.Tables[0].Rows)
                    {
                      test=new Test();
                      test.Messagesenderid = Convert.ToInt32(row["MessageSenderID"]);
                      test.Messagereceiverid = Convert.ToInt32(row["MessageReceiverID"]);
                      ls.Add(test);
                    }
                }
                if (ls.Count>0)
                {
                    lst.Add(ls[0]);
                    for (int i = 1; i < ls.Count; i++)
                    {
                        bool findFlag = false;
                        for (int j = 0; j < lst.Count; j++)
                        {
                            if (ls[i].Messagereceiverid == lst[j].Messagesenderid && ls[i].Messagesenderid == lst[j].Messagereceiverid)
                            {
                                findFlag = true;
                                break;

                            }
                        }
                        if (findFlag == false)
                        {
                            lst.Add(ls[i]);
                        }

                    }
                }
                
                this.rptMsg.DataSource = lst;
                this.rptMsg.DataBind();
            }
           

        }
        public string getContent(object sid,object rid)
        {
            int senderID = (int)sid;
            int receiverID = (int)rid;
            BLL.MessageUserView bllMsg = new BLL.MessageUserView();

            Model.MessageUserView msg = bllMsg.GetModel(senderID, receiverID);
            string sql = "select top 1 MessageContent,userNickName from MessageUserView  where (MessageSenderID=" + senderID + " and MessageReceiverID =" + receiverID + ") or (MessageSenderID=" + receiverID + " and MessageReceiverID =" + senderID + ") order by MessageSendTime desc";
            DataSet da = bllMsg.GetLastMessage(sql);

            return da.Tables[0].Rows[0]["MessageContent"].ToString();


        }
        public string getNickName(object sid,object rid)
        {
            int senderID = (int)sid;
            int receiverID = (int)rid;
            BLL.MessageUserView bllMsg = new BLL.MessageUserView();
            Model.MessageUserView msg = bllMsg.GetModel(senderID, receiverID);
            string sql = "select top 1 MessageContent,userNickName from MessageUserView  where (MessageSenderID=" + senderID + " and MessageReceiverID =" + receiverID + ") or (MessageSenderID=" + receiverID + " and MessageReceiverID =" + senderID + ") order by MessageSendTime desc";
            DataSet da = bllMsg.GetLastMessage(sql);
            return da.Tables[0].Rows[0]["userNickName"].ToString();

        }
        public string getDatatime(object sid, object rid)
        {
            string datatime;
            int senderID = (int)sid;
            int receiverID = (int)rid;
            BLL.MessageUserView bllMsg = new BLL.MessageUserView();
            Model.MessageUserView msg = bllMsg.GetModel(senderID,receiverID);
            datatime = msg.MessageSendTime.ToString();
            return datatime;
            

        }
        public string getHeaderImage(object sid,object rid)
        {
            int senderID = (int)sid;
            int receiverID = (int)rid;
            BLL.MessageUserView bllMsg = new BLL.MessageUserView();
            Model.MessageUserView msg = bllMsg.GetModel(senderID, receiverID);
            if (receiverID == Convert.ToInt32(userId))
            {
                return msg.userHeadImage;
            }
            else 
            {
                return msg.receiverHeadImage;
            }
   
        }
        public string getMessageCount(object sid,object rid)
        {
            int senderID = (int)sid;
            int receiverID = (int)rid;
            BLL.MessageUserView bllMsg = new BLL.MessageUserView();
            Model.MessageUserView msg = bllMsg.GetModel(senderID, receiverID);
            string sql = "select COUNT(MessageSenderID) AS MessageSenderID from MessageUserView where( MessageSenderID=" + senderID + " and MessageReceiverID=" + receiverID + ") or (MessageSenderID=" + receiverID + " and MessageReceiverID =" + senderID + ")";
            DataSet da = bllMsg.GetMessageCount(sql);

            return da.Tables[0].Rows[0]["MessageSenderID"].ToString();
        }
        public string GetUserinfo(object sid, object rid)
        {
            int senderID = (int)sid;
            int receiverID = (int)rid;
            BLL.MessageUserView bllMsg = new BLL.MessageUserView();
            Model.MessageUserView msg = bllMsg.GetModel(senderID, receiverID);

            if (receiverID == Convert.ToInt32(userId))
            {
                return msg.MessageSenderID.ToString();
            }
            else
            {
                return msg.MessageReceiverID.ToString();
            }
           
        }
        public string GetMessageNickName(object sid, object rid)
        {
            int senderID = (int)sid;
            int receiverID = (int)rid;
            BLL.MessageUserView bllMsg = new BLL.MessageUserView();
            Model.MessageUserView msg = bllMsg.GetModel(senderID, receiverID);

            if (receiverID == Convert.ToInt32(userId))
            {
                return msg.userNickName.ToString();
            }
            else
            {
                return msg.receiverNickName.ToString();
            }
        }
        public string GetMessageUserShuoShuo(object sid, object rid)
        {
            int senderID = (int)sid;
            int receiverID = (int)rid;
            BLL.MessageUserView bllMsg = new BLL.MessageUserView();
            Model.MessageUserView msg = bllMsg.GetModel(senderID, receiverID);

            if (receiverID == Convert.ToInt32(userId))
            {
                return msg.userShuoShuo.ToString();
            }
            else
            {
                return msg.receiverShuoShuo.ToString();
            }
        }

        public string getchatNickName(object sid,object rid) 
        {
            int senderID = (int)sid;
            int receiverID = (int)rid;
            BLL.UserInfo blluser = new BLL.UserInfo();
            DataSet da = blluser.GetList("userID="+senderID+"");
            return da.Tables[0].Rows[0]["userNickName"].ToString();
        }
        public void sendMessage(object o, EventArgs e)
        {
            string receiveNickName = this.txtMessageReceive.ToString();
            string sendContent = this.txtMessageContent.Text;
            if (this.wkuserid.Text == "")
            { 
                Response.Write("<script>alert('输入收件人错误');</script>");
            }
            else 
            {
                string messagereceiverid = this.wkuserid.Text;
                DateTime now = DateTime.Now;
                BLL.MessageInfo bllMsg = new BLL.MessageInfo();
                Model.MessageInfo msg = new Model.MessageInfo();
                msg.MessageSenderID = Convert.ToInt32(userId);
                msg.MessageReceiverID = Convert.ToInt32(messagereceiverid);
                msg.MessageContent = sendContent;
                msg.MessageSendTime = now;
                msg.MessageSate = "unread";
                bllMsg.Add(msg);
                Response.Write("<script>window.location.href='message.aspx'</script>");
            }
            
        }
        public string CheckCarePerson(object GetUserinfo)
        {
            BLL.CarePerson cq = new BLL.CarePerson();
            List<Model.CarePerson> list = cq.GetModelList("personCaredByUID=" + userId);
            int qid = Convert.ToInt32(GetUserinfo);
            int mid = Convert.ToInt32(userId);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].carePersonID == qid)
                {
                    return "follow";
                }
            }
            if (qid == mid)
            {
                return "myself";
            }
            return "nofollow";
        }
    }
    public class Test
    {
        int messagesenderid;

        public int Messagesenderid
        {
            get { return messagesenderid; }
            set { messagesenderid = value; }
        }
        int messagereceiverid;

        public int Messagereceiverid
        {
            get { return messagereceiverid; }
            set { messagereceiverid = value; }
        }
    }
}