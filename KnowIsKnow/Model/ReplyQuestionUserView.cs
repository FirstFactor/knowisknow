﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// ReplyQuestionUserView:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ReplyQuestionUserView
    {
        public ReplyQuestionUserView()
        { }
        #region Model
        private int _replyid;
        private int _replyquestionid;
        private int _replyofuid;
        private string _replycontent;
        private DateTime _replydatetime;
        private int _replyapprovecount;
        private int _replyofreplyid;
        private string _replysate;
        private string _useremail;
        private string _usernickname;
        private string _userheadimage;
        private string _userstate;
        private string _userverifycode;
        private string _usergender;
        private string _userpwd;
        private DateTime _userbirthday;
        private string _useradress;
        private string _userjob;
        private string _usershuoshuo;
        private string _usercompany;
        private string _userjobposition;
        private string _useracademy;
        private string _usermajor;
        private string _userprobio;
        private string _questiontitle;
        /// <summary>
        /// 
        /// </summary>
        public int ReplyID
        {
            set { _replyid = value; }
            get { return _replyid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int replyQuestionID
        {
            set { _replyquestionid = value; }
            get { return _replyquestionid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int replyofUID
        {
            set { _replyofuid = value; }
            get { return _replyofuid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string replyContent
        {
            set { _replycontent = value; }
            get { return _replycontent; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime replyDateTime
        {
            set { _replydatetime = value; }
            get { return _replydatetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int replyApproveCount
        {
            set { _replyapprovecount = value; }
            get { return _replyapprovecount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int replyofReplyID
        {
            set { _replyofreplyid = value; }
            get { return _replyofreplyid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string replySate
        {
            set { _replysate = value; }
            get { return _replysate; }
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
        public string userVerifyCode
        {
            set { _userverifycode = value; }
            get { return _userverifycode; }
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
        public string userPwd
        {
            set { _userpwd = value; }
            get { return _userpwd; }
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
        public string questionTitle
        {
            set { _questiontitle = value; }
            get { return _questiontitle; }
        }
        #endregion Model

    }
}
