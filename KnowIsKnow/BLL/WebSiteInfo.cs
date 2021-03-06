﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    /// <summary>
    /// WebSiteInfo
    /// </summary>
    public partial class WebSiteInfo
    {
        private readonly DAL.WebSiteInfo dal = new DAL.WebSiteInfo();
        public WebSiteInfo()
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
        public bool Exists(int webSiteInfoID)
        {
            return dal.Exists(webSiteInfoID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.WebSiteInfo model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.WebSiteInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int webSiteInfoID)
        {

            return dal.Delete(webSiteInfoID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string webSiteInfoIDlist)
        {
            return dal.DeleteList(webSiteInfoIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.WebSiteInfo GetModel(int webSiteInfoID)
        {

            return dal.GetModel(webSiteInfoID);
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
        public List<Model.WebSiteInfo> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.WebSiteInfo> DataTableToList(DataTable dt)
        {
            List<Model.WebSiteInfo> modelList = new List<Model.WebSiteInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.WebSiteInfo model;
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
