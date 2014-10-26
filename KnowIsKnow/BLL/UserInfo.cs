using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    /// <summary>
    /// UserInfo
    /// </summary>
    public partial class UserInfo
    {
        private readonly DAL.UserInfo dal = new DAL.UserInfo();
        public UserInfo()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int userID)
        {
            return dal.Exists(userID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.UserInfo model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.UserInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int userID)
        {

            return dal.Delete(userID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string userIDlist)
        {
            return dal.DeleteList(userIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.UserInfo GetModel(int userID)
        {

            return dal.GetModel(userID);
        }

       

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.UserInfo> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.UserInfo> DataTableToList(DataTable dt)
        {
            List<Model.UserInfo> modelList = new List<Model.UserInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.UserInfo model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
        public DataSet GetreplyName(string sql)
        {
            DAL.UserInfo dalMUV = new DAL.UserInfo();
            return dalMUV.GetreplyName(sql);
        }
    }
}
