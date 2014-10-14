using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /// <summary>
    /// Approve:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Approve
    {
        public Approve()
        { }
        #region Model
        private int _approveid;
        private int _approvereplyid;
        private int _approvebyuid;
        private DateTime _approvedatatime;
        /// <summary>
        /// 
        /// </summary>
        public int approveID
        {
            set { _approveid = value; }
            get { return _approveid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int approveReplyID
        {
            set { _approvereplyid = value; }
            get { return _approvereplyid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int approveByUID
        {
            set { _approvebyuid = value; }
            get { return _approvebyuid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime approveDataTime
        {
            set { _approvedatatime = value; }
            get { return _approvedatatime; }
        }
        #endregion Model

    }
}
