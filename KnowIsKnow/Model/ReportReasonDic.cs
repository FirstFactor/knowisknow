using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /// <summary>
    /// ReportReasonDic:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ReportReasonDic
    {
        public ReportReasonDic()
        { }
        #region Model
        private int _reportreasonid;
        private string _reportreasoncontent;
        /// <summary>
        /// 
        /// </summary>
        public int reportReasonID
        {
            set { _reportreasonid = value; }
            get { return _reportreasonid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string reportReasonContent
        {
            set { _reportreasoncontent = value; }
            get { return _reportreasoncontent; }
        }
        #endregion Model

    }
}
