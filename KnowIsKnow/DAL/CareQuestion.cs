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
    /// 数据访问类:CareQuestion
    /// </summary>
    public partial class CareQuestion
    {
        public CareQuestion()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("careQuestionID", "CareQuestion");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int careQuestionID, int questionCaredByUID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CareQuestion");
            strSql.Append(" where careQuestionID=@careQuestionID and questionCaredByUID=@questionCaredByUID ");
            SqlParameter[] parameters = {
					new SqlParameter("@careQuestionID", SqlDbType.Int,4),
					new SqlParameter("@questionCaredByUID", SqlDbType.Int,4)			};
            parameters[0].Value = careQuestionID;
            parameters[1].Value = questionCaredByUID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.CareQuestion model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CareQuestion(");
            strSql.Append("careQuestionID,questionCaredByUID)");
            strSql.Append(" values (");
            strSql.Append("@careQuestionID,@questionCaredByUID)");
            SqlParameter[] parameters = {
					new SqlParameter("@careQuestionID", SqlDbType.Int,4),
					new SqlParameter("@questionCaredByUID", SqlDbType.Int,4)};
            parameters[0].Value = model.careQuestionID;
            parameters[1].Value = model.questionCaredByUID;

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
        public bool Update(Model.CareQuestion model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CareQuestion set ");
#warning 系统发现缺少更新的字段，请手工确认如此更新是否正确！
            strSql.Append("careQuestionID=@careQuestionID,");
            strSql.Append("questionCaredByUID=@questionCaredByUID");
            strSql.Append(" where careQuestionID=@careQuestionID and questionCaredByUID=@questionCaredByUID ");
            SqlParameter[] parameters = {
					new SqlParameter("@careQuestionID", SqlDbType.Int,4),
					new SqlParameter("@questionCaredByUID", SqlDbType.Int,4)};
            parameters[0].Value = model.careQuestionID;
            parameters[1].Value = model.questionCaredByUID;

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
        public bool Delete(int careQuestionID, int questionCaredByUID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CareQuestion ");
            strSql.Append(" where careQuestionID=@careQuestionID and questionCaredByUID=@questionCaredByUID ");
            SqlParameter[] parameters = {
					new SqlParameter("@careQuestionID", SqlDbType.Int,4),
					new SqlParameter("@questionCaredByUID", SqlDbType.Int,4)			};
            parameters[0].Value = careQuestionID;
            parameters[1].Value = questionCaredByUID;

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
        public Model.CareQuestion GetModel(int careQuestionID, int questionCaredByUID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 careQuestionID,questionCaredByUID from CareQuestion ");
            strSql.Append(" where careQuestionID=@careQuestionID and questionCaredByUID=@questionCaredByUID ");
            SqlParameter[] parameters = {
					new SqlParameter("@careQuestionID", SqlDbType.Int,4),
					new SqlParameter("@questionCaredByUID", SqlDbType.Int,4)			};
            parameters[0].Value = careQuestionID;
            parameters[1].Value = questionCaredByUID;

            Model.CareQuestion model = new Model.CareQuestion();
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
        public Model.CareQuestion DataRowToModel(DataRow row)
        {
            Model.CareQuestion model = new Model.CareQuestion();
            if (row != null)
            {
                if (row["careQuestionID"] != null && row["careQuestionID"].ToString() != "")
                {
                    model.careQuestionID = int.Parse(row["careQuestionID"].ToString());
                }
                if (row["questionCaredByUID"] != null && row["questionCaredByUID"].ToString() != "")
                {
                    model.questionCaredByUID = int.Parse(row["questionCaredByUID"].ToString());
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
            strSql.Append("select careQuestionID,questionCaredByUID ");
            strSql.Append(" FROM CareQuestion ");
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
            strSql.Append(" careQuestionID,questionCaredByUID ");
            strSql.Append(" FROM CareQuestion ");
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
            strSql.Append("select count(1) FROM CareQuestion ");
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
                strSql.Append("order by T.questionCaredByUID desc");
            }
            strSql.Append(")AS Row, T.*  from CareQuestion T ");
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
            parameters[0].Value = "CareQuestion";
            parameters[1].Value = "questionCaredByUID";
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
