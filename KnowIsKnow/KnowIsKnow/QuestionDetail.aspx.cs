using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace KnowIsKnow
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.QuestionTopic bllQuestionTopic = new BLL.QuestionTopic();
            //DataSet da = bllQuestionTopic.GetList();
        }
    }
}