using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace KnowIsKnow
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string userid_allquestion;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Write("<script>window.location.href='index.aspx'</script>");
            }
            else
            {
                userid_allquestion = Session["UserID"].ToString();
                BLL.QuestionUserView quelist = new BLL.QuestionUserView();
                DataSet ds = quelist.GetList("questionSate='normal' order by quetionPubTime desc");
                this.rpt.DataSource = ds.Tables[0];
                this.rpt.DataBind();

            }
        }
        public string CheckCareQuestion(object questionID)
        {
            BLL.CareQuestion cq = new BLL.CareQuestion();
            List<Model.CareQuestion> list = cq.GetModelList("questionCaredByUID=" + userid_allquestion);
            int qid = Convert.ToInt32(questionID);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].careQuestionID == qid)
                {
                    return "true";
                }
            }
            return "false";
        }

        public string CheckQusetionProvider(object questionID)
        {
            BLL.QuestionUserView checkQP = new BLL.QuestionUserView();
            List<Model.QuestionUserView> QPlist = checkQP.GetModelList("questionProvider=" + userid_allquestion);
            int qp = Convert.ToInt32(questionID);
            for (int y = 0; y < QPlist.Count; y++) {
                if (QPlist[y].questionID == qp) { 
                    return "myQuestion";
                }
            }
            return "noMyQuestion";
        }

        public string CheckCarePerson(object questionProvider)
        {
            BLL.CarePerson cq = new BLL.CarePerson();
            List<Model.CarePerson> list = cq.GetModelList("personCaredByUID=" + userid_allquestion);
            int qid = Convert.ToInt32(questionProvider);
            int mid= Convert.ToInt32(userid_allquestion);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].carePersonID == qid)
                {
                    return "follow";
                }
            }
            if(qid==mid){
                return "myself";
            }
            return "nofollow";
        }

        public static string GetContentSummary(string content, int length, bool StripHTML)
        {
            if (string.IsNullOrEmpty(content) || length == 0)
                return "";
            if (StripHTML)
            {
                Regex re = new Regex("<[^>]*>");
                content = re.Replace(content, "");
                content = content.Replace("　", "").Replace(" ", "");
                if (content.Length <= length)
                    return content;
                else
                    return content.Substring(0, length) + "……";
            }
            else
            {
                if (content.Length <= length)
                    return content;

                int pos = 0, npos = 0, size = 0;
                bool firststop = false, notr = false, noli = false;
                StringBuilder sb = new StringBuilder();
                while (true)
                {
                    if (pos >= content.Length)
                        break;
                    string cur = content.Substring(pos, 1);
                    if (cur == "<")
                    {
                        string next = content.Substring(pos + 1, 3).ToLower();
                        if (next.IndexOf("p") == 0 && next.IndexOf("pre") != 0)
                        {
                            npos = content.IndexOf(">", pos) + 1;
                        }
                        else if (next.IndexOf("/p") == 0 && next.IndexOf("/pr") != 0)
                        {
                            npos = content.IndexOf(">", pos) + 1;
                            if (size < length)
                                sb.Append("<br/>");
                        }
                        else if (next.IndexOf("br") == 0)
                        {
                            npos = content.IndexOf(">", pos) + 1;
                            if (size < length)
                                sb.Append("<br/>");
                        }
                        else if (next.IndexOf("img") == 0)
                        {
                            npos = content.IndexOf(">", pos) + 1;
                            if (size < length)
                            {
                                sb.Append(content.Substring(pos, npos - pos));
                                size += npos - pos + 1;
                            }
                        }
                        else if (next.IndexOf("li") == 0 || next.IndexOf("/li") == 0)
                        {
                            npos = content.IndexOf(">", pos) + 1;
                            if (size < length)
                            {
                                sb.Append(content.Substring(pos, npos - pos));
                            }
                            else
                            {
                                if (!noli && next.IndexOf("/li") == 0)
                                {
                                    sb.Append(content.Substring(pos, npos - pos));
                                    noli = true;
                                }
                            }
                        }
                        else if (next.IndexOf("tr") == 0 || next.IndexOf("/tr") == 0)
                        {
                            npos = content.IndexOf(">", pos) + 1;
                            if (size < length)
                            {
                                sb.Append(content.Substring(pos, npos - pos));
                            }
                            else
                            {
                                if (!notr && next.IndexOf("/tr") == 0)
                                {
                                    sb.Append(content.Substring(pos, npos - pos));
                                    notr = true;
                                }
                            }
                        }
                        else if (next.IndexOf("td") == 0 || next.IndexOf("/td") == 0)
                        {
                            npos = content.IndexOf(">", pos) + 1;
                            if (size < length)
                            {
                                sb.Append(content.Substring(pos, npos - pos));
                            }
                            else
                            {
                                if (!notr)
                                {
                                    sb.Append(content.Substring(pos, npos - pos));
                                }
                            }
                        }
                        else
                        {
                            npos = content.IndexOf(">", pos) + 1;
                            sb.Append(content.Substring(pos, npos - pos));
                        }
                        if (npos <= pos)
                            npos = pos + 1;
                        pos = npos;
                    }
                    else
                    {
                        if (size < length)
                        {
                            sb.Append(cur);
                            size++;
                        }
                        else
                        {
                            if (!firststop)
                            {
                                sb.Append("……");
                                firststop = true;
                            }
                        }
                        pos++;
                    }

                }
                return sb.ToString();
            }
        }

    }
}