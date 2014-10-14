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
    /// 数据访问类:ReportReply
    /// </summary>
    public partial class ReportReply
    {
        public ReportReply()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("reportReID", "ReportReply");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int reportReID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ReportReply");
            strSql.Append(" where reportReID=@reportReID");
            SqlParameter[] parameters = {
					new SqlParameter("@reportReID", SqlDbType.Int,4)
			};
            parameters[0].Value = reportReID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.ReportReply model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ReportReply(");
            strSql.Append("reportReplyID,reportReplyReason,reportReplyByUID,reportReplyDataTime,reportReplyDealState,reportReplyResonTypeID)");
            strSql.Append(" values (");
            strSql.Append("@reportReplyID,@reportReplyReason,@reportReplyByUID,@reportReplyDataTime,@reportReplyDealState,@reportReplyResonTypeID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@reportReplyID", SqlDbType.Int,4),
					new SqlParameter("@reportReplyReason", SqlDbType.VarChar,100),
					new SqlParameter("@reportReplyByUID", SqlDbType.Int,4),
					new SqlParameter("@reportReplyDataTime", SqlDbType.DateTime),
					new SqlParameter("@reportReplyDealState", SqlDbType.VarChar,50),
					new SqlParameter("@reportReplyResonTypeID", SqlDbType.Int,4)};
            parameters[0].Value = model.reportReplyID;
            parameters[1].Value = model.reportReplyReason;
            parameters[2].Value = model.reportReplyByUID;
            parameters[3].Value = model.reportReplyDataTime;
            parameters[4].Value = model.reportReplyDealState;
            parameters[5].Value = model.reportReplyResonTypeID;

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
        public bool Update(Model.ReportReply model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ReportReply set ");
            strSql.Append("reportReplyID=@reportReplyID,");
            strSql.Append("reportReplyReason=@reportReplyReason,");
            strSql.Append("reportReplyByUID=@reportReplyByUID,");
            strSql.Append("reportReplyDataTime=@reportReplyDataTime,");
            strSql.Append("reportReplyDealState=@reportReplyDealState,");
            strSql.Append("reportReplyResonTypeID=@reportReplyResonTypeID");
            strSql.Append(" where reportReID=@reportReID");
            SqlParameter[] parameters = {
					new SqlParameter("@reportReplyID", SqlDbType.Int,4),
					new SqlParameter("@reportReplyReason", SqlDbType.VarChar,100),
					new SqlParameter("@reportReplyByUID", SqlDbType.Int,4),
					new SqlParameter("@reportReplyDataTime", SqlDbType.DateTime),
					new SqlParameter("@reportReplyDealState", SqlDbType.VarChar,50),
					new SqlParameter("@reportReplyResonTypeID", SqlDbType.Int,4),
					new SqlParameter("@reportReID", SqlDbType.Int,4)};
            parameters[0].Value = model.reportReplyID;
            parameters[1].Value = model.reportReplyReason;
            parameters[2].Value = model.reportReplyByUID;
            parameters[3].Value = model.reportReplyDataTime;
            parameters[4].Value = model.reportReplyDealState;
            parameters[5].Value = model.reportReplyResonTypeID;
            parameters[6].Value = model.reportReID;

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
        public bool Delete(int reportReID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ReportReply ");
            strSql.Append(" where reportReID=@reportReID");
            SqlParameter[] parameters = {
					new SqlParameter("@reportReID", SqlDbType.Int,4)
			};
            parameters[0].Value = reportReID;

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
        public bool DeleteList(string reportReIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ReportReply ");
            strSql.Append(" where reportReID in (" + reportReIDlist + ")  ");
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
        public Model.ReportReply GetModel(int reportReID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 reportReID,reportReplyID,reportReplyReason,reportReplyByUID,reportReplyDataTime,reportReplyDealState,reportReplyResonTypeID from ReportReply ");
            strSql.Append(" where reportReID=@reportReID");
            SqlParameter[] parameters = {
					new SqlParameter("@reportReID", SqlDbType.Int,4)
			};
            parameters[0].Value = reportReID;

            Model.ReportReply model = new Model.ReportReply();
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
        public Model.ReportReply DataRowToModel(DataRow row)
        {
            Model.ReportReply model = new Model.ReportReply();
            if (row != null)
            {
                if (row["reportReID"] != null && row["reportReID"].ToString() != "")
                {
                    model.reportReID = int.Parse(row["reportReID"].ToString());
                }
                if (row["reportReplyID"] != null && row["reportReplyID"].ToString() != "")
                {
                    model.reportReplyID = int.Parse(row["reportReplyID"].ToString());
                }
                if (row["reportReplyReason"] != null)
                {
                    model.reportReplyReason = row["reportReplyReason"].ToString();
                }
                if (row["reportReplyByUID"] != null && row["reportReplyByUID"].ToString() != "")
                {
                    model.reportReplyByUID = int.Parse(row["reportReplyByUID"].ToString());
                }
                if (row["reportReplyDataTime"] != null && row["reportReplyDataTime"].ToString() != "")
                {
                    model.reportReplyDataTime = DateTime.Parse(row["reportReplyDataTime"].ToString());
                }
                if (row["reportReplyDealState"] != null)
                {
                    model.reportReplyDealState = row["reportReplyDealState"].ToString();
                }
                if (row["reportReplyResonTypeID"] != null && row["reportReplyResonTypeID"].ToString() != "")
                {
                    model.reportReplyResonTypeID = int.Parse(row["reportReplyResonTypeID"].ToString());
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
            strSql.Append("select reportReID,reportReplyID,reportReplyReason,reportReplyByUID,reportReplyDataTime,reportReplyDealState,reportReplyResonTypeID ");
            strSql.Append(" FROM ReportReply ");
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
            strSql.Append(" reportReID,reportReplyID,reportReplyReason,reportReplyByUID,reportReplyDataTime,reportReplyDealState,reportReplyResonTypeID ");
            strSql.Append(" FROM ReportReply ");
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
            strSql.Append("select count(1) FROM ReportReply ");
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
                strSql.Append("order by T.reportReID desc");
            }
            strSql.Append(")AS Row, T.*  from ReportReply T ");
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
            parameters[0].Value = "ReportReply";
            parameters[1].Value = "reportReID";
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
