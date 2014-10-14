using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// CarePersonUserInfoView
    /// </summary>
    public partial class CarePersonUserInfoView
    {
        private readonly DAL.CarePersonUserInfoView dal = new DAL.CarePersonUserInfoView();
        public CarePersonUserInfoView()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int carePersonID, int personCaredByUID)
        {
            return dal.Exists(carePersonID, personCaredByUID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.CarePersonUserInfoView model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.CarePersonUserInfoView model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int carePersonID, int personCaredByUID)
        {

            return dal.Delete(carePersonID, personCaredByUID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.CarePersonUserInfoView GetModel(int carePersonID, int personCaredByUID)
        {

            return dal.GetModel(carePersonID, personCaredByUID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.CarePersonUserInfoView GetModelByCache(int carePersonID, int personCaredByUID)
        {

            string CacheKey = "CarePersonUserInfoViewModel-" + carePersonID + personCaredByUID;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(carePersonID, personCaredByUID);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.CarePersonUserInfoView)objModel;
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
        public List<Model.CarePersonUserInfoView> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.CarePersonUserInfoView> DataTableToList(DataTable dt)
        {
            List<Model.CarePersonUserInfoView> modelList = new List<Model.CarePersonUserInfoView>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.CarePersonUserInfoView model;
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
    }
}
