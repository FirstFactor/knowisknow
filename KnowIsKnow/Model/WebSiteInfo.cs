using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /// <summary>
    /// WebSiteInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class WebSiteInfo
    {
        public WebSiteInfo()
        { }
        #region Model
        private int _websiteinfoid;
        private string _websitename;
        private string _websitecopyright;
        /// <summary>
        /// 
        /// </summary>
        public int webSiteInfoID
        {
            set { _websiteinfoid = value; }
            get { return _websiteinfoid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string webSiteName
        {
            set { _websitename = value; }
            get { return _websitename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string webSiteCopyRight
        {
            set { _websitecopyright = value; }
            get { return _websitecopyright; }
        }
        #endregion Model

    }
}
