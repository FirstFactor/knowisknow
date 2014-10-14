using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// MessageUserView:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class MessageUserView
    {
        public MessageUserView()
        { }
        #region Model
        private string _useremail;
        private string _usernickname;
        private string _userheadimage;
        private string _userstate;
        private string _usergender;
        private DateTime _userbirthday;
        private string _useradress;
        private string _userjob;
        private string _usershuoshuo;
        private string _usercompany;
        private string _userjobposition;
        private string _useracademy;
        private string _usermajor;
        private string _userprobio;
        private string _receiveremail;
        private string _receivernickname;
        private string _receiverheadimage;
        private string _receiverstate;
        private string _receivergender;
        private DateTime _receiverbirthday;
        private string _receiveradress;
        private string _receiverjob;
        private string _receivershuoshuo;
        private string _receivercompany;
        private string _receiverjobposition;
        private string _receiveracademy;
        private string _receivermajor;
        private string _receiverprobio;
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
        public string userEmail
        {
            set { _useremail = value; }
            get { return _useremail; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userNickName
        {
            set { _usernickname = value; }
            get { return _usernickname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userHeadImage
        {
            set { _userheadimage = value; }
            get { return _userheadimage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userState
        {
            set { _userstate = value; }
            get { return _userstate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userGender
        {
            set { _usergender = value; }
            get { return _usergender; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime userBirthday
        {
            set { _userbirthday = value; }
            get { return _userbirthday; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userAdress
        {
            set { _useradress = value; }
            get { return _useradress; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userJob
        {
            set { _userjob = value; }
            get { return _userjob; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userShuoShuo
        {
            set { _usershuoshuo = value; }
            get { return _usershuoshuo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userCompany
        {
            set { _usercompany = value; }
            get { return _usercompany; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userJobPosition
        {
            set { _userjobposition = value; }
            get { return _userjobposition; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userAcademy
        {
            set { _useracademy = value; }
            get { return _useracademy; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userMajor
        {
            set { _usermajor = value; }
            get { return _usermajor; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userProBio
        {
            set { _userprobio = value; }
            get { return _userprobio; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string receiverEmail
        {
            set { _receiveremail = value; }
            get { return _receiveremail; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string receiverNickName
        {
            set { _receivernickname = value; }
            get { return _receivernickname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string receiverHeadImage
        {
            set { _receiverheadimage = value; }
            get { return _receiverheadimage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string receiverState
        {
            set { _receiverstate = value; }
            get { return _receiverstate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string receiverGender
        {
            set { _receivergender = value; }
            get { return _receivergender; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime receiverBirthday
        {
            set { _receiverbirthday = value; }
            get { return _receiverbirthday; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string receiverAdress
        {
            set { _receiveradress = value; }
            get { return _receiveradress; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string receiverJob
        {
            set { _receiverjob = value; }
            get { return _receiverjob; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string receiverShuoShuo
        {
            set { _receivershuoshuo = value; }
            get { return _receivershuoshuo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string receiverCompany
        {
            set { _receivercompany = value; }
            get { return _receivercompany; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string receiverJobPosition
        {
            set { _receiverjobposition = value; }
            get { return _receiverjobposition; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string receiverAcademy
        {
            set { _receiveracademy = value; }
            get { return _receiveracademy; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string receiverMajor
        {
            set { _receivermajor = value; }
            get { return _receivermajor; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string receiverProBio
        {
            set { _receiverprobio = value; }
            get { return _receiverprobio; }
        }
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
