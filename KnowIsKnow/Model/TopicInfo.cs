using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /// <summary>
    /// TopicInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class TopicInfo
    {
        public TopicInfo()
        { }
        #region Model
        private int _topicid;
        private string _topictitle;
        private string _topicdes;
        private string _topicpicurl;
        private int _topicattention = 0;
        private string _topicstate = "normal";
        /// <summary>
        /// 
        /// </summary>
        public int topicID
        {
            set { _topicid = value; }
            get { return _topicid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string topicTitle
        {
            set { _topictitle = value; }
            get { return _topictitle; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string topicDes
        {
            set { _topicdes = value; }
            get { return _topicdes; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string topicPicUrl
        {
            set { _topicpicurl = value; }
            get { return _topicpicurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int topicAttention
        {
            set { _topicattention = value; }
            get { return _topicattention; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string topicState
        {
            set { _topicstate = value; }
            get { return _topicstate; }
        }
        #endregion Model

    }
}
