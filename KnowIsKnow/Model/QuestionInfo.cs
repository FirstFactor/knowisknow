using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /// <summary>
    /// QuestionInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class QuestionInfo
    {
        public QuestionInfo()
        { }
        #region Model
        private int _questionid;
        private string _questiontitle;
        private string _questioncontent;
        private int _questionprovider;
        private DateTime _quetionpubtime;
        private int _questonapprovecount;
        private int _questionreportcount;
        private string _questionsate = "normal";
        /// <summary>
        /// 
        /// </summary>
        public int questionID
        {
            set { _questionid = value; }
            get { return _questionid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string questionTitle
        {
            set { _questiontitle = value; }
            get { return _questiontitle; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string questionContent
        {
            set { _questioncontent = value; }
            get { return _questioncontent; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int questionProvider
        {
            set { _questionprovider = value; }
            get { return _questionprovider; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime quetionPubTime
        {
            set { _quetionpubtime = value; }
            get { return _quetionpubtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int questonApproveCount
        {
            set { _questonapprovecount = value; }
            get { return _questonapprovecount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int questionReportCount
        {
            set { _questionreportcount = value; }
            get { return _questionreportcount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string questionSate
        {
            set { _questionsate = value; }
            get { return _questionsate; }
        }
        #endregion Model

    }
}
