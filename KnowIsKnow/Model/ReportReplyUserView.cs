using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// ReportReplyUserView:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ReportReplyUserView
    {
        public ReportReplyUserView()
        { }
        #region Model
        private int _reportreplybyuid;
        private int _reportreplyid;
        private int _reportreid;
        private string _reportreplyreason;
        private DateTime _reportreplydatatime;
        private string _reportreplydealstate;
        private int _reportreplyresontypeid;
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
        private string _reportreasoncontent;
        /// <summary>
        /// 
        /// </summary>
        public int reportReplyByUID
        {
            set { _reportreplybyuid = value; }
            get { return _reportreplybyuid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int reportReplyID
        {
            set { _reportreplyid = value; }
            get { return _reportreplyid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int reportReID
        {
            set { _reportreid = value; }
            get { return _reportreid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string reportReplyReason
        {
            set { _reportreplyreason = value; }
            get { return _reportreplyreason; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime reportReplyDataTime
        {
            set { _reportreplydatatime = value; }
            get { return _reportreplydatatime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string reportReplyDealState
        {
            set { _reportreplydealstate = value; }
            get { return _reportreplydealstate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int reportReplyResonTypeID
        {
            set { _reportreplyresontypeid = value; }
            get { return _reportreplyresontypeid; }
        }
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
        public string reportReasonContent
        {
            set { _reportreasoncontent = value; }
            get { return _reportreasoncontent; }
        }
        #endregion Model

    }
}
