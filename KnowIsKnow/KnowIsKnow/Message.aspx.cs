using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace KnowIsKnow
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.MessageUserView message = new BLL.MessageUserView();
            string sql = "select MessageSenderID from MessageUserView where MessageSenderID !=0 and MessageReceiverID =3 group by MessageSenderID";
            DataSet ds = message.GetUnreadSenderList(sql);
            this.rptMsg.DataSource = ds.Tables[0];
            this.rptMsg.DataBind();

        }
        public string getContent(object id)
        {
            int senderID = (int)id;

            BLL.MessageUserView bllMsg = new BLL.MessageUserView();

            Model.MessageUserView msg = bllMsg.GetModel(senderID, 3);
            string sql = "select top 1 MessageContent,userNickName from MessageUserView  where MessageSenderID=" + senderID + " and MessageSenderID !=0 and MessageReceiverID =3 or MessageSenderID =3 and MessageSenderID !=0 and MessageReceiverID ="+senderID+" order by MessageSendTime desc";
            DataSet da = bllMsg.GetLastMessage(sql);

            return da.Tables[0].Rows[0]["MessageContent"].ToString();


        }
        public string getNickName(object id)
        {
            int senderID = (int)id;

            BLL.MessageUserView bllMsg = new BLL.MessageUserView();
            Model.MessageUserView msg = bllMsg.GetModel(senderID, 3);
            string sql = "select top 1 MessageContent,userNickName from MessageUserView  where MessageSenderID=" + senderID + " and MessageSenderID !=0 and MessageReceiverID =3 or MessageSenderID =3 and MessageSenderID !=0 and MessageReceiverID =" + senderID + " order by MessageSendTime desc";
            DataSet da = bllMsg.GetLastMessage(sql);
            return da.Tables[0].Rows[0]["userNickName"].ToString();

        }
        public string getDatatime(object id)
        {
            int senderID = (int)id;

            BLL.MessageUserView bllMsg = new BLL.MessageUserView();
            Model.MessageUserView msg = bllMsg.GetModel(senderID, 3);

            return msg.MessageSendTime.ToString();

        }
        public string getHeaderImage(object id)
        {
            int senderID = (int)id;

            BLL.MessageUserView bllMsg = new BLL.MessageUserView();
            Model.MessageUserView msg = bllMsg.GetModel(senderID, 3);

            return msg.receiverHeadImage;
        }
        public string getMessageCount(object id)
        {
            int senderID = (int)id;

            BLL.MessageUserView bllMsg = new BLL.MessageUserView();
            Model.MessageUserView msg = bllMsg.GetModel(senderID, 3);
            string sql = "select COUNT(MessageSenderID) AS MessageSenderID from MessageUserView where MessageSenderID=" + senderID + " and MessageReceiverID=3 or MessageSenderID=3 and MessageReceiverID=" + senderID + " ";
            DataSet da = bllMsg.GetMessageCount(sql);

            return da.Tables[0].Rows[0]["MessageSenderID"].ToString();
        }
        public void sendMessage(object o, EventArgs e)
        {
            string receiveNickName = this.txtMessageReceive.ToString();
            string sendContent = this.txtMessageContent.Text;
            DateTime now =DateTime.Now;
            BLL.MessageInfo bllMsg = new BLL.MessageInfo();
            Model.MessageInfo msg = new Model.MessageInfo();
            msg.MessageSenderID = 3;
            msg.MessageReceiverID = 4;
            msg.MessageContent = sendContent;
            msg.MessageSendTime = now;
            msg.MessageSate = "unread";
            bllMsg.Add(msg);
            Response.Write("<script>window.location.href='message.aspx'</script>");
        }
    }
}