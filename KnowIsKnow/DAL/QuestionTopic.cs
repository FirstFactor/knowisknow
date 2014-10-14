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
    /// 数据访问类:QuestionTopic
    /// </summary>
    public partial class QuestionTopic
    {
        public QuestionTopic()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("quesrionTTID", "QuestionTopic");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int quesrionTTID, int topicTID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from QuestionTopic");
            strSql.Append(" where quesrionTTID=@quesrionTTID and topicTID=@topicTID ");
            SqlParameter[] parameters = {
					new SqlParameter("@quesrionTTID", SqlDbType.Int,4),
					new SqlParameter("@topicTID", SqlDbType.Int,4)			};
            parameters[0].Value = quesrionTTID;
            parameters[1].Value = topicTID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.QuestionTopic model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into QuestionTopic(");
            strSql.Append("quesrionTTID,topicTID)");
            strSql.Append(" values (");
            strSql.Append("@quesrionTTID,@topicTID)");
            SqlParameter[] parameters = {
					new SqlParameter("@quesrionTTID", SqlDbType.Int,4),
					new SqlParameter("@topicTID", SqlDbType.Int,4)};
            parameters[0].Value = model.quesrionTTID;
            parameters[1].Value = model.topicTID;

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
        public bool Update(Model.QuestionTopic model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update QuestionTopic set ");
#warning 系统发现缺少更新的字段，请手工确认如此更新是否正确！
            strSql.Append("quesrionTTID=@quesrionTTID,");
            strSql.Append("topicTID=@topicTID");
            strSql.Append(" where quesrionTTID=@quesrionTTID and topicTID=@topicTID ");
            SqlParameter[] parameters = {
					new SqlParameter("@quesrionTTID", SqlDbType.Int,4),
					new SqlParameter("@topicTID", SqlDbType.Int,4)};
            parameters[0].Value = model.quesrionTTID;
            parameters[1].Value = model.topicTID;

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
        public bool Delete(int quesrionTTID, int topicTID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from QuestionTopic ");
            strSql.Append(" where quesrionTTID=@quesrionTTID and topicTID=@topicTID ");
            SqlParameter[] parameters = {
					new SqlParameter("@quesrionTTID", SqlDbType.Int,4),
					new SqlParameter("@topicTID", SqlDbType.Int,4)			};
            parameters[0].Value = quesrionTTID;
            parameters[1].Value = topicTID;

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
        public Model.QuestionTopic GetModel(int quesrionTTID, int topicTID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 quesrionTTID,topicTID from QuestionTopic ");
            strSql.Append(" where quesrionTTID=@quesrionTTID and topicTID=@topicTID ");
            SqlParameter[] parameters = {
					new SqlParameter("@quesrionTTID", SqlDbType.Int,4),
					new SqlParameter("@topicTID", SqlDbType.Int,4)			};
            parameters[0].Value = quesrionTTID;
            parameters[1].Value = topicTID;

            Model.QuestionTopic model = new Model.QuestionTopic();
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
        public Model.QuestionTopic DataRowToModel(DataRow row)
        {
            Model.QuestionTopic model = new Model.QuestionTopic();
            if (row != null)
            {
                if (row["quesrionTTID"] != null && row["quesrionTTID"].ToString() != "")
                {
                    model.quesrionTTID = int.Parse(row["quesrionTTID"].ToString());
                }
                if (row["topicTID"] != null && row["topicTID"].ToString() != "")
                {
                    model.topicTID = int.Parse(row["topicTID"].ToString());
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
            strSql.Append("select quesrionTTID,topicTID ");
            strSql.Append(" FROM QuestionTopic ");
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
            strSql.Append(" quesrionTTID,topicTID ");
            strSql.Append(" FROM QuestionTopic ");
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
            strSql.Append("select count(1) FROM QuestionTopic ");
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
                strSql.Append("order by T.topicTID desc");
            }
            strSql.Append(")AS Row, T.*  from QuestionTopic T ");
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
            parameters[0].Value = "QuestionTopic";
            parameters[1].Value = "topicTID";
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
