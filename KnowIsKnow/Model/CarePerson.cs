using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /// <summary>
    /// CarePerson:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class CarePerson
    {
        public CarePerson()
        { }
        #region Model
        private int _carepersonid;
        private int _personcaredbyuid;
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
        #endregion Model

    }
}
