using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /// <summary>
    /// MessageInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class MessageInfo
    {
        public MessageInfo()
        { }
        #region Model
        private int _messageid;
        private int _messagesenderid;
        private int _messagereceiverid;
        private string _messagecontent;
        private DateTime _messagesendtime;
        private string _messagesate;
        private int _messagereportid;
        /// <summary>
        /// 
        /// </summary>
        public int MessageID
        {
            set { _messageid = value; }
            get { return _messageid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int MessageSenderID
        {
            set { _messagesenderid = value; }
            get { return _messagesenderid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int MessageReceiverID
        {
            set { _messagereceiverid = value; }
            get { return _messagereceiverid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MessageContent
        {
            set { _messagecontent = value; }
            get { return _messagecontent; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime MessageSendTime
        {
            set { _messagesendtime = value; }
            get { return _messagesendtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MessageSate
        {
            set { _messagesate = value; }
            get { return _messagesate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int MessageReportID
        {
            set { _messagereportid = value; }
            get { return _messagereportid; }
        }
        #endregion Model

    }
}
