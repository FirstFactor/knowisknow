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
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.MessageUserView message = new BLL.MessageUserView();
            DataSet da = message.GetList("MessageSenderID=4 and MessageReceiverID=3 or MessageSenderID=3 and MessageReceiverID=4 order by MessageSendTime");
            this.repMsg.DataSource = da.Tables[0];
            this.repMsg.DataBind();
        }
    }
}