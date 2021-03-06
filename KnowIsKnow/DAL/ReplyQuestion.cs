﻿using DBUtility;
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
    /// 数据访问类:ReplyQuestion
    /// </summary>
    public partial class ReplyQuestion
    {
        public ReplyQuestion()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ReplyID", "ReplyQuestion");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ReplyID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ReplyQuestion");
            strSql.Append(" where ReplyID=@ReplyID");
            SqlParameter[] parameters = {
					new SqlParameter("@ReplyID", SqlDbType.Int,4)
			};
            parameters[0].Value = ReplyID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.ReplyQuestion model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ReplyQuestion(");
            strSql.Append("replyQuestionID,replyofUID,replyContent,replyDateTime,replyApproveCount,replyofReplyID,replySate)");
            strSql.Append(" values (");
            strSql.Append("@replyQuestionID,@replyofUID,@replyContent,@replyDateTime,@replyApproveCount,@replyofReplyID,@replySate)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@replyQuestionID", SqlDbType.Int,4),
					new SqlParameter("@replyofUID", SqlDbType.Int,4),
					new SqlParameter("@replyContent", SqlDbType.VarChar,-1),
					new SqlParameter("@replyDateTime", SqlDbType.DateTime),
					new SqlParameter("@replyApproveCount", SqlDbType.Int,4),
					new SqlParameter("@replyofReplyID", SqlDbType.Int,4),
					new SqlParameter("@replySate", SqlDbType.VarChar,50)};
            parameters[0].Value = model.replyQuestionID;
            parameters[1].Value = model.replyofUID;
            parameters[2].Value = model.replyContent;
            parameters[3].Value = model.replyDateTime;
            parameters[4].Value = model.replyApproveCount;
            parameters[5].Value = model.replyofReplyID;
            parameters[6].Value = model.replySate;

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
        public bool Update(Model.ReplyQuestion model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ReplyQuestion set ");
            strSql.Append("replyQuestionID=@replyQuestionID,");
            strSql.Append("replyofUID=@replyofUID,");
            strSql.Append("replyContent=@replyContent,");
            strSql.Append("replyDateTime=@replyDateTime,");
            strSql.Append("replyApproveCount=@replyApproveCount,");
            strSql.Append("replyofReplyID=@replyofReplyID,");
            strSql.Append("replySate=@replySate");
            strSql.Append(" where ReplyID=@ReplyID");
            SqlParameter[] parameters = {
					new SqlParameter("@replyQuestionID", SqlDbType.Int,4),
					new SqlParameter("@replyofUID", SqlDbType.Int,4),
					new SqlParameter("@replyContent", SqlDbType.VarChar,-1),
					new SqlParameter("@replyDateTime", SqlDbType.DateTime),
					new SqlParameter("@replyApproveCount", SqlDbType.Int,4),
					new SqlParameter("@replyofReplyID", SqlDbType.Int,4),
					new SqlParameter("@replySate", SqlDbType.VarChar,50),
					new SqlParameter("@ReplyID", SqlDbType.Int,4)};
            parameters[0].Value = model.replyQuestionID;
            parameters[1].Value = model.replyofUID;
            parameters[2].Value = model.replyContent;
            parameters[3].Value = model.replyDateTime;
            parameters[4].Value = model.replyApproveCount;
            parameters[5].Value = model.replyofReplyID;
            parameters[6].Value = model.replySate;
            parameters[7].Value = model.ReplyID;

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
        public bool Delete(int ReplyID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ReplyQuestion ");
            strSql.Append(" where ReplyID=@ReplyID");
            SqlParameter[] parameters = {
					new SqlParameter("@ReplyID", SqlDbType.Int,4)
			};
            parameters[0].Value = ReplyID;

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
        public bool DeleteList(string ReplyIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ReplyQuestion ");
            strSql.Append(" where ReplyID in (" + ReplyIDlist + ")  ");
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
        public Model.ReplyQuestion GetModel(int ReplyID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ReplyID,replyQuestionID,replyofUID,replyContent,replyDateTime,replyApproveCount,replyofReplyID,replySate from ReplyQuestion ");
            strSql.Append(" where ReplyID=@ReplyID");
            SqlParameter[] parameters = {
					new SqlParameter("@ReplyID", SqlDbType.Int,4)
			};
            parameters[0].Value = ReplyID;

            Model.ReplyQuestion model = new Model.ReplyQuestion();
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
        public Model.ReplyQuestion DataRowToModel(DataRow row)
        {
            Model.ReplyQuestion model = new Model.ReplyQuestion();
            if (row != null)
            {
                if (row["ReplyID"] != null && row["ReplyID"].ToString() != "")
                {
                    model.ReplyID = int.Parse(row["ReplyID"].ToString());
                }
                if (row["replyQuestionID"] != null && row["replyQuestionID"].ToString() != "")
                {
                    model.replyQuestionID = int.Parse(row["replyQuestionID"].ToString());
                }
                if (row["replyofUID"] != null && row["replyofUID"].ToString() != "")
                {
                    model.replyofUID = int.Parse(row["replyofUID"].ToString());
                }
                if (row["replyContent"] != null)
                {
                    model.replyContent = row["replyContent"].ToString();
                }
                if (row["replyDateTime"] != null && row["replyDateTime"].ToString() != "")
                {
                    model.replyDateTime = DateTime.Parse(row["replyDateTime"].ToString());
                }
                if (row["replyApproveCount"] != null && row["replyApproveCount"].ToString() != "")
                {
                    model.replyApproveCount = int.Parse(row["replyApproveCount"].ToString());
                }
                if (row["replyofReplyID"] != null && row["replyofReplyID"].ToString() != "")
                {
                    model.replyofReplyID = int.Parse(row["replyofReplyID"].ToString());
                }
                if (row["replySate"] != null)
                {
                    model.replySate = row["replySate"].ToString();
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
            strSql.Append("select ReplyID,replyQuestionID,replyofUID,replyContent,replyDateTime,replyApproveCount,replyofReplyID,replySate ");
            strSql.Append(" FROM ReplyQuestion ");
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
            strSql.Append(" ReplyID,replyQuestionID,replyofUID,replyContent,replyDateTime,replyApproveCount,replyofReplyID,replySate ");
            strSql.Append(" FROM ReplyQuestion ");
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
            strSql.Append("select count(1) FROM ReplyQuestion ");
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
                strSql.Append("order by T.ReplyID desc");
            }
            strSql.Append(")AS Row, T.*  from ReplyQuestion T ");
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
            parameters[0].Value = "ReplyQuestion";
            parameters[1].Value = "ReplyID";
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
