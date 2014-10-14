using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /// <summary>
    /// ReplyQuestion:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ReplyQuestion
    {
        public ReplyQuestion()
        { }
        #region Model
        private int _replyid;
        private int _replyquestionid;
        private int _replyofuid;
        private string _replycontent;
        private DateTime _replydatetime;
        private int _replyapprovecount = 0;
        private int _replyofreplyid;
        private string _replysate = "normal";
        /// <summary>
        /// 
        /// </summary>
        public int ReplyID
        {
            set { _replyid = value; }
            get { return _replyid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int replyQuestionID
        {
            set { _replyquestionid = value; }
            get { return _replyquestionid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int replyofUID
        {
            set { _replyofuid = value; }
            get { return _replyofuid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string replyContent
        {
            set { _replycontent = value; }
            get { return _replycontent; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime replyDateTime
        {
            set { _replydatetime = value; }
            get { return _replydatetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int replyApproveCount
        {
            set { _replyapprovecount = value; }
            get { return _replyapprovecount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int replyofReplyID
        {
            set { _replyofreplyid = value; }
            get { return _replyofreplyid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string replySate
        {
            set { _replysate = value; }
            get { return _replysate; }
        }
        #endregion Model

    }
}
