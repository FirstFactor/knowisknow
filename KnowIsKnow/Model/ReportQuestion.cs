using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /// <summary>
    /// ReportQuestion:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ReportQuestion
    {
        public ReportQuestion()
        { }
        #region Model
        private int _reportquid;
        private int _reportquestionid;
        private string _reportquestionreason;
        private int _reportquestionbyuid;
        private DateTime _reportquestiondatetime;
        private string _reportquestiondealstate = "undeal";
        private int _reportquestionreasontypeid = 5;
        /// <summary>
        /// 
        /// </summary>
        public int reportQuID
        {
            set { _reportquid = value; }
            get { return _reportquid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int reportQuestionID
        {
            set { _reportquestionid = value; }
            get { return _reportquestionid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string reportQuestionReason
        {
            set { _reportquestionreason = value; }
            get { return _reportquestionreason; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int reportQuestionByUID
        {
            set { _reportquestionbyuid = value; }
            get { return _reportquestionbyuid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime reportQuestionDateTime
        {
            set { _reportquestiondatetime = value; }
            get { return _reportquestiondatetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string reportQuestionDealState
        {
            set { _reportquestiondealstate = value; }
            get { return _reportquestiondealstate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int reportQuestionReasonTypeID
        {
            set { _reportquestionreasontypeid = value; }
            get { return _reportquestionreasontypeid; }
        }
        #endregion Model

    }
}
