using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    /// <summary>
    /// ReportReasonDic
    /// </summary>
    public partial class ReportReasonDic
    {
        private readonly DAL.ReportReasonDic dal = new DAL.ReportReasonDic();
        public ReportReasonDic()
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
        public bool Exists(int reportReasonID)
        {
            return dal.Exists(reportReasonID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.ReportReasonDic model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.ReportReasonDic model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int reportReasonID)
        {

            return dal.Delete(reportReasonID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string reportReasonIDlist)
        {
            return dal.DeleteList(reportReasonIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.ReportReasonDic GetModel(int reportReasonID)
        {

            return dal.GetModel(reportReasonID);
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
        public List<Model.ReportReasonDic> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.ReportReasonDic> DataTableToList(DataTable dt)
        {
            List<Model.ReportReasonDic> modelList = new List<Model.ReportReasonDic>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.ReportReasonDic model;
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
