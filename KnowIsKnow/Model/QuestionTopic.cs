using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /// <summary>
    /// QuestionTopic:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class QuestionTopic
    {
        public QuestionTopic()
        { }
        #region Model
        private int _quesrionttid;
        private int _topictid;
        /// <summary>
        /// 
        /// </summary>
        public int quesrionTTID
        {
            set { _quesrionttid = value; }
            get { return _quesrionttid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int topicTID
        {
            set { _topictid = value; }
            get { return _topictid; }
        }
        #endregion Model

    }
}
