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
    /// 数据访问类:QuestionInfo
    /// </summary>
    public partial class QuestionInfo
    {
        public QuestionInfo()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("questionID", "QuestionInfo");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int questionID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from QuestionInfo");
            strSql.Append(" where questionID=@questionID");
            SqlParameter[] parameters = {
					new SqlParameter("@questionID", SqlDbType.Int,4)
			};
            parameters[0].Value = questionID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.QuestionInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into QuestionInfo(");
            strSql.Append("questionTitle,questionContent,questionProvider,quetionPubTime,questonApproveCount,questionReportCount,questionSate)");
            strSql.Append(" values (");
            strSql.Append("@questionTitle,@questionContent,@questionProvider,@quetionPubTime,@questonApproveCount,@questionReportCount,@questionSate)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@questionTitle", SqlDbType.VarChar,50),
					new SqlParameter("@questionContent", SqlDbType.VarChar,-1),
					new SqlParameter("@questionProvider", SqlDbType.Int,4),
					new SqlParameter("@quetionPubTime", SqlDbType.DateTime),
					new SqlParameter("@questonApproveCount", SqlDbType.Int,4),
					new SqlParameter("@questionReportCount", SqlDbType.Int,4),
					new SqlParameter("@questionSate", SqlDbType.VarChar,50)};
            parameters[0].Value = model.questionTitle;
            parameters[1].Value = model.questionContent;
            parameters[2].Value = model.questionProvider;
            parameters[3].Value = model.quetionPubTime;
            parameters[4].Value = model.questonApproveCount;
            parameters[5].Value = model.questionReportCount;
            parameters[6].Value = model.questionSate;

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
        public bool Update(Model.QuestionInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update QuestionInfo set ");
            strSql.Append("questionTitle=@questionTitle,");
            strSql.Append("questionContent=@questionContent,");
            strSql.Append("questionProvider=@questionProvider,");
            strSql.Append("quetionPubTime=@quetionPubTime,");
            strSql.Append("questonApproveCount=@questonApproveCount,");
            strSql.Append("questionReportCount=@questionReportCount,");
            strSql.Append("questionSate=@questionSate");
            strSql.Append(" where questionID=@questionID");
            SqlParameter[] parameters = {
					new SqlParameter("@questionTitle", SqlDbType.VarChar,50),
					new SqlParameter("@questionContent", SqlDbType.VarChar,-1),
					new SqlParameter("@questionProvider", SqlDbType.Int,4),
					new SqlParameter("@quetionPubTime", SqlDbType.DateTime),
					new SqlParameter("@questonApproveCount", SqlDbType.Int,4),
					new SqlParameter("@questionReportCount", SqlDbType.Int,4),
					new SqlParameter("@questionSate", SqlDbType.VarChar,50),
					new SqlParameter("@questionID", SqlDbType.Int,4)};
            parameters[0].Value = model.questionTitle;
            parameters[1].Value = model.questionContent;
            parameters[2].Value = model.questionProvider;
            parameters[3].Value = model.quetionPubTime;
            parameters[4].Value = model.questonApproveCount;
            parameters[5].Value = model.questionReportCount;
            parameters[6].Value = model.questionSate;
            parameters[7].Value = model.questionID;

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
        public bool Delete(int questionID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from QuestionInfo ");
            strSql.Append(" where questionID=@questionID");
            SqlParameter[] parameters = {
					new SqlParameter("@questionID", SqlDbType.Int,4)
			};
            parameters[0].Value = questionID;

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
        public bool DeleteList(string questionIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from QuestionInfo ");
            strSql.Append(" where questionID in (" + questionIDlist + ")  ");
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
        public Model.QuestionInfo GetModel(int questionID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 questionID,questionTitle,questionContent,questionProvider,quetionPubTime,questonApproveCount,questionReportCount,questionSate from QuestionInfo ");
            strSql.Append(" where questionID=@questionID");
            SqlParameter[] parameters = {
					new SqlParameter("@questionID", SqlDbType.Int,4)
			};
            parameters[0].Value = questionID;

            Model.QuestionInfo model = new Model.QuestionInfo();
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
        public Model.QuestionInfo DataRowToModel(DataRow row)
        {
            Model.QuestionInfo model = new Model.QuestionInfo();
            if (row != null)
            {
                if (row["questionID"] != null && row["questionID"].ToString() != "")
                {
                    model.questionID = int.Parse(row["questionID"].ToString());
                }
                if (row["questionTitle"] != null)
                {
                    model.questionTitle = row["questionTitle"].ToString();
                }
                if (row["questionContent"] != null)
                {
                    model.questionContent = row["questionContent"].ToString();
                }
                if (row["questionProvider"] != null && row["questionProvider"].ToString() != "")
                {
                    model.questionProvider = int.Parse(row["questionProvider"].ToString());
                }
                if (row["quetionPubTime"] != null && row["quetionPubTime"].ToString() != "")
                {
                    model.quetionPubTime = DateTime.Parse(row["quetionPubTime"].ToString());
                }
                if (row["questonApproveCount"] != null && row["questonApproveCount"].ToString() != "")
                {
                    model.questonApproveCount = int.Parse(row["questonApproveCount"].ToString());
                }
                if (row["questionReportCount"] != null && row["questionReportCount"].ToString() != "")
                {
                    model.questionReportCount = int.Parse(row["questionReportCount"].ToString());
                }
                if (row["questionSate"] != null)
                {
                    model.questionSate = row["questionSate"].ToString();
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
            strSql.Append("select questionID,questionTitle,questionContent,questionProvider,quetionPubTime,questonApproveCount,questionReportCount,questionSate ");
            strSql.Append(" FROM QuestionInfo ");
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
            strSql.Append(" questionID,questionTitle,questionContent,questionProvider,quetionPubTime,questonApproveCount,questionReportCount,questionSate ");
            strSql.Append(" FROM QuestionInfo ");
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
            strSql.Append("select count(1) FROM QuestionInfo ");
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
                strSql.Append("order by T.questionID desc");
            }
            strSql.Append(")AS Row, T.*  from QuestionInfo T ");
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
            parameters[0].Value = "QuestionInfo";
            parameters[1].Value = "questionID";
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
