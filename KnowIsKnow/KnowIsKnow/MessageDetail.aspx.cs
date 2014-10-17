using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace KnowIsKnow
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        string userid;
        string msgsid;
        public string chatusername;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["UserID"] = 3;
            userid = Session["UserID"].ToString();
            if (userid != "" && userid != "null")
            {
                msgsid = Request.QueryString["MsgsID"].ToString();
                BLL.MessageUserView message = new BLL.MessageUserView();
                DataSet da = message.GetList("MessageSenderID=" + msgsid + " and MessageReceiverID=" + userid + " or MessageSenderID=" + userid + " and MessageReceiverID=" + msgsid + " order by MessageSendTime desc");
                this.repMsg.DataSource = da.Tables[0];
                this.repMsg.DataBind();
                BLL.UserInfo chatuserid = new BLL.UserInfo();
                DataSet ds = chatuserid.GetList("userID="+msgsid+"");
                chatusername = ds.Tables[0].Rows[0]["userNickName"].ToString();
            }
            else 
            {
                Response.Write("<script>window.location.href='index.aspx'</script>");
            }
           
        }

        protected void chatSendMessage_Click1(object sender, EventArgs e)
        {
            string sendContent = this.chatSendContent.Text;
            DateTime now = DateTime.Now;
            BLL.MessageInfo bllMsg = new BLL.MessageInfo();
            Model.MessageInfo msg = new Model.MessageInfo();
            msg.MessageSenderID = Convert.ToInt32(userid);
            msg.MessageReceiverID = Convert.ToInt32(msgsid);
            msg.MessageContent = sendContent;
            msg.MessageSendTime = now;
            msg.MessageSate = "unread";
            bllMsg.Add(msg);
            Response.Write("<script>window.location.href='MessageDetail.aspx?MsgsID="+msgsid+"'</script>");
        }
    }
}