using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /// <summary>
    /// CareTopic:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class CareTopic
    {
        public CareTopic()
        { }
        #region Model
        private int _caretopicid;
        private int _topiccaredbyuid;
        /// <summary>
        /// 
        /// </summary>
        public int careTopicID
        {
            set { _caretopicid = value; }
            get { return _caretopicid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int topicCaredByUID
        {
            set { _topiccaredbyuid = value; }
            get { return _topiccaredbyuid; }
        }
        #endregion Model

    }
}
