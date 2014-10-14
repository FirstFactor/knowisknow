using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /// <summary>
    /// CareQuestion:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class CareQuestion
    {
        public CareQuestion()
        { }
        #region Model
        private int _carequestionid;
        private int _questioncaredbyuid;
        /// <summary>
        /// 
        /// </summary>
        public int careQuestionID
        {
            set { _carequestionid = value; }
            get { return _carequestionid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int questionCaredByUID
        {
            set { _questioncaredbyuid = value; }
            get { return _questioncaredbyuid; }
        }
        #endregion Model

    }
}
