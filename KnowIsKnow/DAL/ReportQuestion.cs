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
    /// 数据访问类:ReportQuestion
    /// </summary>
    public partial class ReportQuestion
    {
        public ReportQuestion()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("reportQuID", "ReportQuestion");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int reportQuID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ReportQuestion");
            strSql.Append(" where reportQuID=@reportQuID");
            SqlParameter[] parameters = {
					new SqlParameter("@reportQuID", SqlDbType.Int,4)
			};
            parameters[0].Value = reportQuID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.ReportQuestion model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ReportQuestion(");
            strSql.Append("reportQuestionID,reportQuestionReason,reportQuestionByUID,reportQuestionDateTime,reportQuestionDealState,reportQuestionReasonTypeID)");
            strSql.Append(" values (");
            strSql.Append("@reportQuestionID,@reportQuestionReason,@reportQuestionByUID,@reportQuestionDateTime,@reportQuestionDealState,@reportQuestionReasonTypeID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@reportQuestionID", SqlDbType.Int,4),
					new SqlParameter("@reportQuestionReason", SqlDbType.VarChar,100),
					new SqlParameter("@reportQuestionByUID", SqlDbType.Int,4),
					new SqlParameter("@reportQuestionDateTime", SqlDbType.DateTime),
					new SqlParameter("@reportQuestionDealState", SqlDbType.VarChar,50),
					new SqlParameter("@reportQuestionReasonTypeID", SqlDbType.Int,4)};
            parameters[0].Value = model.reportQuestionID;
            parameters[1].Value = model.reportQuestionReason;
            parameters[2].Value = model.reportQuestionByUID;
            parameters[3].Value = model.reportQuestionDateTime;
            parameters[4].Value = model.reportQuestionDealState;
            parameters[5].Value = model.reportQuestionReasonTypeID;

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
        public bool Update(Model.ReportQuestion model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ReportQuestion set ");
            strSql.Append("reportQuestionID=@reportQuestionID,");
            strSql.Append("reportQuestionReason=@reportQuestionReason,");
            strSql.Append("reportQuestionByUID=@reportQuestionByUID,");
            strSql.Append("reportQuestionDateTime=@reportQuestionDateTime,");
            strSql.Append("reportQuestionDealState=@reportQuestionDealState,");
            strSql.Append("reportQuestionReasonTypeID=@reportQuestionReasonTypeID");
            strSql.Append(" where reportQuID=@reportQuID");
            SqlParameter[] parameters = {
					new SqlParameter("@reportQuestionID", SqlDbType.Int,4),
					new SqlParameter("@reportQuestionReason", SqlDbType.VarChar,100),
					new SqlParameter("@reportQuestionByUID", SqlDbType.Int,4),
					new SqlParameter("@reportQuestionDateTime", SqlDbType.DateTime),
					new SqlParameter("@reportQuestionDealState", SqlDbType.VarChar,50),
					new SqlParameter("@reportQuestionReasonTypeID", SqlDbType.Int,4),
					new SqlParameter("@reportQuID", SqlDbType.Int,4)};
            parameters[0].Value = model.reportQuestionID;
            parameters[1].Value = model.reportQuestionReason;
            parameters[2].Value = model.reportQuestionByUID;
            parameters[3].Value = model.reportQuestionDateTime;
            parameters[4].Value = model.reportQuestionDealState;
            parameters[5].Value = model.reportQuestionReasonTypeID;
            parameters[6].Value = model.reportQuID;

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
        public bool Delete(int reportQuID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ReportQuestion ");
            strSql.Append(" where reportQuID=@reportQuID");
            SqlParameter[] parameters = {
					new SqlParameter("@reportQuID", SqlDbType.Int,4)
			};
            parameters[0].Value = reportQuID;

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
        public bool DeleteList(string reportQuIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ReportQuestion ");
            strSql.Append(" where reportQuID in (" + reportQuIDlist + ")  ");
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
        public Model.ReportQuestion GetModel(int reportQuID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 reportQuID,reportQuestionID,reportQuestionReason,reportQuestionByUID,reportQuestionDateTime,reportQuestionDealState,reportQuestionReasonTypeID from ReportQuestion ");
            strSql.Append(" where reportQuID=@reportQuID");
            SqlParameter[] parameters = {
					new SqlParameter("@reportQuID", SqlDbType.Int,4)
			};
            parameters[0].Value = reportQuID;

            Model.ReportQuestion model = new Model.ReportQuestion();
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
        public Model.ReportQuestion DataRowToModel(DataRow row)
        {
            Model.ReportQuestion model = new Model.ReportQuestion();
            if (row != null)
            {
                if (row["reportQuID"] != null && row["reportQuID"].ToString() != "")
                {
                    model.reportQuID = int.Parse(row["reportQuID"].ToString());
                }
                if (row["reportQuestionID"] != null && row["reportQuestionID"].ToString() != "")
                {
                    model.reportQuestionID = int.Parse(row["reportQuestionID"].ToString());
                }
                if (row["reportQuestionReason"] != null)
                {
                    model.reportQuestionReason = row["reportQuestionReason"].ToString();
                }
                if (row["reportQuestionByUID"] != null && row["reportQuestionByUID"].ToString() != "")
                {
                    model.reportQuestionByUID = int.Parse(row["reportQuestionByUID"].ToString());
                }
                if (row["reportQuestionDateTime"] != null && row["reportQuestionDateTime"].ToString() != "")
                {
                    model.reportQuestionDateTime = DateTime.Parse(row["reportQuestionDateTime"].ToString());
                }
                if (row["reportQuestionDealState"] != null)
                {
                    model.reportQuestionDealState = row["reportQuestionDealState"].ToString();
                }
                if (row["reportQuestionReasonTypeID"] != null && row["reportQuestionReasonTypeID"].ToString() != "")
                {
                    model.reportQuestionReasonTypeID = int.Parse(row["reportQuestionReasonTypeID"].ToString());
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
            strSql.Append("select reportQuID,reportQuestionID,reportQuestionReason,reportQuestionByUID,reportQuestionDateTime,reportQuestionDealState,reportQuestionReasonTypeID ");
            strSql.Append(" FROM ReportQuestion ");
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
            strSql.Append(" reportQuID,reportQuestionID,reportQuestionReason,reportQuestionByUID,reportQuestionDateTime,reportQuestionDealState,reportQuestionReasonTypeID ");
            strSql.Append(" FROM ReportQuestion ");
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
            strSql.Append("select count(1) FROM ReportQuestion ");
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
                strSql.Append("order by T.reportQuID desc");
            }
            strSql.Append(")AS Row, T.*  from ReportQuestion T ");
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
            parameters[0].Value = "ReportQuestion";
            parameters[1].Value = "reportQuID";
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
