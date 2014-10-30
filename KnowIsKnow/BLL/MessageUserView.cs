using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// MessageUserView
    /// </summary>
    public partial class MessageUserView
    {
        private readonly DAL.MessageUserView dal = new DAL.MessageUserView();
        public MessageUserView()
        { }
        public DataSet GetUnreadSenderList(string sql)
        {
            DAL.MessageUserView dalMUV = new DAL.MessageUserView();
            return dalMUV.GetUnreadSenderList(sql);
        }
        public DataSet GetLastMessage(string sql)
        {
            DAL.MessageUserView dalMUV = new DAL.MessageUserView();
            return dalMUV.GetUnreadSenderList(sql);
        }
        public DataSet GetMessageCount(string sql)
        {
            DAL.MessageUserView dalMUV = new DAL.MessageUserView();
            return dalMUV.GetUnreadSenderList(sql);
        }
        public DataSet GetUserinfo(string sql)
        {
            DAL.UserInfo dalMUV = new DAL.UserInfo();
            return dalMUV.GetreplyName(sql);
        }
        public DataSet GetMessageNickName(string sql)
        {
            DAL.UserInfo dalMUV = new DAL.UserInfo();
            return dalMUV.GetreplyName(sql);
        }
        public DataSet GetMessageUserShuoShuo(string sql)
        {
            DAL.UserInfo dalMUV = new DAL.UserInfo();
            return dalMUV.GetreplyName(sql);
        }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int MessageSenderID, int MessageReceiverID)
        {
            return dal.Exists(MessageSenderID, MessageReceiverID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.MessageUserView model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.MessageUserView model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int MessageSenderID, int MessageReceiverID)
        {

            return dal.Delete(MessageSenderID, MessageReceiverID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.MessageUserView GetModel(int MessageSenderID, int MessageReceiverID)
        {

            return dal.GetModel(MessageSenderID, MessageReceiverID);
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
        public List<Model.MessageUserView> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.MessageUserView> DataTableToList(DataTable dt)
        {
            List<Model.MessageUserView> modelList = new List<Model.MessageUserView>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.MessageUserView model;
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
