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
    /// 数据访问类:CarePersonQuestionView
    /// </summary>
    public partial class CarePersonQuestionView
    {
        public CarePersonQuestionView()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int personCaredByUID, int questionProvider)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CarePersonQuestionView");
            strSql.Append(" where personCaredByUID=@personCaredByUID and questionProvider=@questionProvider ");
            SqlParameter[] parameters = {
					new SqlParameter("@personCaredByUID", SqlDbType.Int,4),
					new SqlParameter("@questionProvider", SqlDbType.Int,4)			};
            parameters[0].Value = personCaredByUID;
            parameters[1].Value = questionProvider;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.CarePersonQuestionView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CarePersonQuestionView(");
            strSql.Append("personCaredByUID,questionID,questionTitle,questionContent,quetionPubTime,questionProvider,questonApproveCount,questionReportCount,questionSate)");
            strSql.Append(" values (");
            strSql.Append("@personCaredByUID,@questionID,@questionTitle,@questionContent,@quetionPubTime,@questionProvider,@questonApproveCount,@questionReportCount,@questionSate)");
            SqlParameter[] parameters = {
					new SqlParameter("@personCaredByUID", SqlDbType.Int,4),
					new SqlParameter("@questionID", SqlDbType.Int,4),
					new SqlParameter("@questionTitle", SqlDbType.VarChar,50),
					new SqlParameter("@questionContent", SqlDbType.VarChar,-1),
					new SqlParameter("@quetionPubTime", SqlDbType.DateTime),
					new SqlParameter("@questionProvider", SqlDbType.Int,4),
					new SqlParameter("@questonApproveCount", SqlDbType.Int,4),
					new SqlParameter("@questionReportCount", SqlDbType.Int,4),
					new SqlParameter("@questionSate", SqlDbType.VarChar,50)};
            parameters[0].Value = model.personCaredByUID;
            parameters[1].Value = model.questionID;
            parameters[2].Value = model.questionTitle;
            parameters[3].Value = model.questionContent;
            parameters[4].Value = model.quetionPubTime;
            parameters[5].Value = model.questionProvider;
            parameters[6].Value = model.questonApproveCount;
            parameters[7].Value = model.questionReportCount;
            parameters[8].Value = model.questionSate;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.CarePersonQuestionView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CarePersonQuestionView set ");
            strSql.Append("personCaredByUID=@personCaredByUID,");
            strSql.Append("questionID=@questionID,");
            strSql.Append("questionTitle=@questionTitle,");
            strSql.Append("questionContent=@questionContent,");
            strSql.Append("quetionPubTime=@quetionPubTime,");
            strSql.Append("questionProvider=@questionProvider,");
            strSql.Append("questonApproveCount=@questonApproveCount,");
            strSql.Append("questionReportCount=@questionReportCount,");
            strSql.Append("questionSate=@questionSate");
            strSql.Append(" where personCaredByUID=@personCaredByUID and questionProvider=@questionProvider ");
            SqlParameter[] parameters = {
					new SqlParameter("@personCaredByUID", SqlDbType.Int,4),
					new SqlParameter("@questionID", SqlDbType.Int,4),
					new SqlParameter("@questionTitle", SqlDbType.VarChar,50),
					new SqlParameter("@questionContent", SqlDbType.VarChar,-1),
					new SqlParameter("@quetionPubTime", SqlDbType.DateTime),
					new SqlParameter("@questionProvider", SqlDbType.Int,4),
					new SqlParameter("@questonApproveCount", SqlDbType.Int,4),
					new SqlParameter("@questionReportCount", SqlDbType.Int,4),
					new SqlParameter("@questionSate", SqlDbType.VarChar,50)};
            parameters[0].Value = model.personCaredByUID;
            parameters[1].Value = model.questionID;
            parameters[2].Value = model.questionTitle;
            parameters[3].Value = model.questionContent;
            parameters[4].Value = model.quetionPubTime;
            parameters[5].Value = model.questionProvider;
            parameters[6].Value = model.questonApproveCount;
            parameters[7].Value = model.questionReportCount;
            parameters[8].Value = model.questionSate;

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
        public bool Delete(int personCaredByUID, int questionProvider)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CarePersonQuestionView ");
            strSql.Append(" where personCaredByUID=@personCaredByUID and questionProvider=@questionProvider ");
            SqlParameter[] parameters = {
					new SqlParameter("@personCaredByUID", SqlDbType.Int,4),
					new SqlParameter("@questionProvider", SqlDbType.Int,4)			};
            parameters[0].Value = personCaredByUID;
            parameters[1].Value = questionProvider;

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
        /// 得到一个对象实体
        /// </summary>
        public Model.CarePersonQuestionView GetModel(int personCaredByUID, int questionProvider)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 personCaredByUID,questionID,questionTitle,questionContent,quetionPubTime,questionProvider,questonApproveCount,questionReportCount,questionSate from CarePersonQuestionView ");
            strSql.Append(" where personCaredByUID=@personCaredByUID and questionProvider=@questionProvider ");
            SqlParameter[] parameters = {
					new SqlParameter("@personCaredByUID", SqlDbType.Int,4),
					new SqlParameter("@questionProvider", SqlDbType.Int,4)			};
            parameters[0].Value = personCaredByUID;
            parameters[1].Value = questionProvider;

            Model.CarePersonQuestionView model = new Model.CarePersonQuestionView();
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
        public Model.CarePersonQuestionView DataRowToModel(DataRow row)
        {
            Model.CarePersonQuestionView model = new Model.CarePersonQuestionView();
            if (row != null)
            {
                if (row["personCaredByUID"] != null && row["personCaredByUID"].ToString() != "")
                {
                    model.personCaredByUID = int.Parse(row["personCaredByUID"].ToString());
                }
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
                if (row["quetionPubTime"] != null && row["quetionPubTime"].ToString() != "")
                {
                    model.quetionPubTime = DateTime.Parse(row["quetionPubTime"].ToString());
                }
                if (row["questionProvider"] != null && row["questionProvider"].ToString() != "")
                {
                    model.questionProvider = int.Parse(row["questionProvider"].ToString());
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
            strSql.Append("select personCaredByUID,questionID,questionTitle,questionContent,quetionPubTime,questionProvider,questonApproveCount,questionReportCount,questionSate ");
            strSql.Append(" FROM CarePersonQuestionView ");
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
            strSql.Append(" personCaredByUID,questionID,questionTitle,questionContent,quetionPubTime,questionProvider,questonApproveCount,questionReportCount,questionSate ");
            strSql.Append(" FROM CarePersonQuestionView ");
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
            strSql.Append("select count(1) FROM CarePersonQuestionView ");
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
                strSql.Append("order by T.questionProvider desc");
            }
            strSql.Append(")AS Row, T.*  from CarePersonQuestionView T ");
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
            parameters[0].Value = "CarePersonQuestionView";
            parameters[1].Value = "questionProvider";
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
