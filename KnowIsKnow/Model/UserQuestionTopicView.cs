using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// UserQuestionTopicView:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class UserQuestionTopicView
    {
        public UserQuestionTopicView()
        { }
        #region Model
        private int _questionid;
        private string _questiontitle;
        private string _questioncontent;
        private DateTime _quetionpubtime;
        private int _questonapprovecount;
        private int _questionreportcount;
        private string _questionsate;
        private int _userid;
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
        private int _topicid;
        private string _topictitle;
        private string _topicdes;
        private string _topicpicurl;
        private int _topicattention;
        private string _topicstate;
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
        /// <summary>
        /// 
        /// </summary>
        public int userID
        {
            set { _userid = value; }
            get { return _userid; }
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
