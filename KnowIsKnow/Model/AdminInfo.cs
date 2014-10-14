using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// AdminInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class AdminInfo
    {
        public AdminInfo()
        { }
        #region Model
        private int _adminid;
        private string _adminemail;
        private string _adminpwd;
        private string _adminnickname;
        private string _adminstate;
        private string _adminverifycode;
        private bool _canaddtopic;
        private bool _candeletetopic;
        private bool _candeletequestion;
        private bool _candeleteanswer;
        private bool _canaddquestion;
        private bool _cananswer;
        private bool _cansendmes;
        /// <summary>
        /// 
        /// </summary>
        public int adminID
        {
            set { _adminid = value; }
            get { return _adminid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string adminEmail
        {
            set { _adminemail = value; }
            get { return _adminemail; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string adminPwd
        {
            set { _adminpwd = value; }
            get { return _adminpwd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string adminNickName
        {
            set { _adminnickname = value; }
            get { return _adminnickname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string adminState
        {
            set { _adminstate = value; }
            get { return _adminstate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string adminVerifyCode
        {
            set { _adminverifycode = value; }
            get { return _adminverifycode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool canAddTopic
        {
            set { _canaddtopic = value; }
            get { return _canaddtopic; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool canDeleteTopic
        {
            set { _candeletetopic = value; }
            get { return _candeletetopic; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool canDeleteQuestion
        {
            set { _candeletequestion = value; }
            get { return _candeletequestion; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool canDeleteanswer
        {
            set { _candeleteanswer = value; }
            get { return _candeleteanswer; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool canAddQuestion
        {
            set { _canaddquestion = value; }
            get { return _canaddquestion; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool canAnswer
        {
            set { _cananswer = value; }
            get { return _cananswer; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool canSendMes
        {
            set { _cansendmes = value; }
            get { return _cansendmes; }
        }
        #endregion Model

    }
}
