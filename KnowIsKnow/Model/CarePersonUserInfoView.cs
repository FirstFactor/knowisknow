using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// CarePersonUserInfoView:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class CarePersonUserInfoView
    {
        public CarePersonUserInfoView()
        { }
        #region Model
        private int _carepersonid;
        private int _personcaredbyuid;
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
        private string _cuseremail;
        private string _cusernickname;
        private string _cuserheadimage;
        private string _cuserstate;
        private string _cusergender;
        private DateTime _cuserbirthday;
        private string _cuseradress;
        private string _cuserjob;
        private string _cusershuoshuo;
        private string _cusercompany;
        private string _cuserjobposition;
        private string _cuseracademy;
        private string _cusermajor;
        private string _cuserprobio;
        /// <summary>
        /// 
        /// </summary>
        public int carePersonID
        {
            set { _carepersonid = value; }
            get { return _carepersonid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int personCaredByUID
        {
            set { _personcaredbyuid = value; }
            get { return _personcaredbyuid; }
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
        public string cuserEmail
        {
            set { _cuseremail = value; }
            get { return _cuseremail; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cuserNickName
        {
            set { _cusernickname = value; }
            get { return _cusernickname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cuserHeadImage
        {
            set { _cuserheadimage = value; }
            get { return _cuserheadimage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cuserState
        {
            set { _cuserstate = value; }
            get { return _cuserstate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cuserGender
        {
            set { _cusergender = value; }
            get { return _cusergender; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime cuserBirthday
        {
            set { _cuserbirthday = value; }
            get { return _cuserbirthday; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cuserAdress
        {
            set { _cuseradress = value; }
            get { return _cuseradress; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cuserJob
        {
            set { _cuserjob = value; }
            get { return _cuserjob; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cuserShuoShuo
        {
            set { _cusershuoshuo = value; }
            get { return _cusershuoshuo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cuserCompany
        {
            set { _cusercompany = value; }
            get { return _cusercompany; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cuserJobPosition
        {
            set { _cuserjobposition = value; }
            get { return _cuserjobposition; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cuserAcademy
        {
            set { _cuseracademy = value; }
            get { return _cuseracademy; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cuserMajor
        {
            set { _cusermajor = value; }
            get { return _cusermajor; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cuserProBio
        {
            set { _cuserprobio = value; }
            get { return _cuserprobio; }
        }
        #endregion Model

    }
}
