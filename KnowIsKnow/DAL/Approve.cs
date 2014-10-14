using DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    /// <summary>
    /// 数据访问类:Approve
    /// </summary>
    public partial class Approve
    {
        public Approve()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("approveID", "Approve");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int approveID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Approve");
            strSql.Append(" where approveID=@approveID");
            SqlParameter[] parameters = {
					new SqlParameter("@approveID", SqlDbType.Int,4)
			};
            parameters[0].Value = approveID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.Approve model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Approve(");
            strSql.Append("approveReplyID,approveByUID,approveDataTime)");
            strSql.Append(" values (");
            strSql.Append("@approveReplyID,@approveByUID,@approveDataTime)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@approveReplyID", SqlDbType.Int,4),
					new SqlParameter("@approveByUID", SqlDbType.Int,4),
					new SqlParameter("@approveDataTime", SqlDbType.DateTime)};
            parameters[0].Value = model.approveReplyID;
            parameters[1].Value = model.approveByUID;
            parameters[2].Value = model.approveDataTime;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.Approve model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Approve set ");
            strSql.Append("approveReplyID=@approveReplyID,");
            strSql.Append("approveByUID=@approveByUID,");
            strSql.Append("approveDataTime=@approveDataTime");
            strSql.Append(" where approveID=@approveID");
            SqlParameter[] parameters = {
					new SqlParameter("@approveReplyID", SqlDbType.Int,4),
					new SqlParameter("@approveByUID", SqlDbType.Int,4),
					new SqlParameter("@approveDataTime", SqlDbType.DateTime),
					new SqlParameter("@approveID", SqlDbType.Int,4)};
            parameters[0].Value = model.approveReplyID;
            parameters[1].Value = model.approveByUID;
            parameters[2].Value = model.approveDataTime;
            parameters[3].Value = model.approveID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int approveID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Approve ");
            strSql.Append(" where approveID=@approveID");
            SqlParameter[] parameters = {
					new SqlParameter("@approveID", SqlDbType.Int,4)
			};
            parameters[0].Value = approveID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string approveIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Approve ");
            strSql.Append(" where approveID in (" + approveIDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Approve GetModel(int approveID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 approveID,approveReplyID,approveByUID,approveDataTime from Approve ");
            strSql.Append(" where approveID=@approveID");
            SqlParameter[] parameters = {
					new SqlParameter("@approveID", SqlDbType.Int,4)
			};
            parameters[0].Value = approveID;

            Model.Approve model = new Model.Approve();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Approve DataRowToModel(DataRow row)
        {
            Model.Approve model = new Model.Approve();
            if (row != null)
            {
                if (row["approveID"] != null && row["approveID"].ToString() != "")
                {
                    model.approveID = int.Parse(row["approveID"].ToString());
                }
                if (row["approveReplyID"] != null && row["approveReplyID"].ToString() != "")
                {
                    model.approveReplyID = int.Parse(row["approveReplyID"].ToString());
                }
                if (row["approveByUID"] != null && row["approveByUID"].ToString() != "")
                {
                    model.approveByUID = int.Parse(row["approveByUID"].ToString());
                }
                if (row["approveDataTime"] != null && row["approveDataTime"].ToString() != "")
                {
                    model.approveDataTime = DateTime.Parse(row["approveDataTime"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select approveID,approveReplyID,approveByUID,approveDataTime ");
            strSql.Append(" FROM Approve ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" approveID,approveReplyID,approveByUID,approveDataTime ");
            strSql.Append(" FROM Approve ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Approve ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.approveID desc");
            }
            strSql.Append(")AS Row, T.*  from Approve T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "Approve";
            parameters[1].Value = "approveID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
