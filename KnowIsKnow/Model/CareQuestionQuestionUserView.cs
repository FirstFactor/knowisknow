using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// CareQuestionQuestionUserView:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class CareQuestionQuestionUserView
    {
        public CareQuestionQuestionUserView()
        { }
        #region Model
        private int _carequestionid;
        private int _questioncaredbyuid;
        private string _questiontitle;
        private string _questioncontent;
        private int _questionprovider;
        private DateTime _quetionpubtime;
        private int _questonapprovecount;
        private int _questionreportcount;
        private string _questionsate;
        private string _usernickname;
        private string _userheadimage;
        private string _useremail;
        private string _userstate;
        private DateTime? _userbirthday;
        private string _useradress;
        private string _userjob;
        private string _usershuoshuo;
        private string _usercompany;
        private string _userjobposition;
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
        public int questionProvider
        {
            set { _questionprovider = value; }
            get { return _questionprovider; }
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
        public string userEmail
        {
            set { _useremail = value; }
            get { return _useremail; }
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
        public DateTime? userBirthday
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
        #endregion Model

    }
}
