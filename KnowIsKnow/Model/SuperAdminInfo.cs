using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /// <summary>
    /// SuperAdminInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class SuperAdminInfo
    {
        public SuperAdminInfo()
        { }
        #region Model
        private int _superadminid;
        private string _superadminemail;
        private string _superadminpwd;
        private string _superadminverifycode;
        /// <summary>
        /// 
        /// </summary>
        public int superAdminID
        {
            set { _superadminid = value; }
            get { return _superadminid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string superAdminEmail
        {
            set { _superadminemail = value; }
            get { return _superadminemail; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string superAdminPwd
        {
            set { _superadminpwd = value; }
            get { return _superadminpwd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string superAdminVerifyCode
        {
            set { _superadminverifycode = value; }
            get { return _superadminverifycode; }
        }
        #endregion Model

    }
}
