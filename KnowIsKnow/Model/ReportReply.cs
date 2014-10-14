using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /// <summary>
    /// ReportReply:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ReportReply
    {
        public ReportReply()
        { }
        #region Model
        private int _reportreid;
        private int _reportreplyid;
        private string _reportreplyreason;
        private int _reportreplybyuid;
        private DateTime _reportreplydatatime;
        private string _reportreplydealstate = "undeal";
        private int _reportreplyresontypeid = 5;
        /// <summary>
        /// 
        /// </summary>
        public int reportReID
        {
            set { _reportreid = value; }
            get { return _reportreid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int reportReplyID
        {
            set { _reportreplyid = value; }
            get { return _reportreplyid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string reportReplyReason
        {
            set { _reportreplyreason = value; }
            get { return _reportreplyreason; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int reportReplyByUID
        {
            set { _reportreplybyuid = value; }
            get { return _reportreplybyuid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime reportReplyDataTime
        {
            set { _reportreplydatatime = value; }
            get { return _reportreplydatatime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string reportReplyDealState
        {
            set { _reportreplydealstate = value; }
            get { return _reportreplydealstate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int reportReplyResonTypeID
        {
            set { _reportreplyresontypeid = value; }
            get { return _reportreplyresontypeid; }
        }
        #endregion Model

    }
}
