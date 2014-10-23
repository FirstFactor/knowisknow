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
    /// 数据访问类:CareTopic
    /// </summary>
    public partial class CareTopic
    {
        public CareTopic()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("careTopicID", "CareTopic");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int careTopicID, int topicCaredByUID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CareTopic");
            strSql.Append(" where careTopicID=@careTopicID and topicCaredByUID=@topicCaredByUID ");
            SqlParameter[] parameters = {
					new SqlParameter("@careTopicID", SqlDbType.Int,4),
					new SqlParameter("@topicCaredByUID", SqlDbType.Int,4)			};
            parameters[0].Value = careTopicID;
            parameters[1].Value = topicCaredByUID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.CareTopic model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CareTopic(");
            strSql.Append("careTopicID,topicCaredByUID,careTopicState)");
            strSql.Append(" values (");
            strSql.Append("@careTopicID,@topicCaredByUID,@careTopicState)");
            SqlParameter[] parameters = {
					new SqlParameter("@careTopicID", SqlDbType.Int,4),
					new SqlParameter("@topicCaredByUID", SqlDbType.Int,4),
                    new SqlParameter("@careTopicState",SqlDbType.VarChar,50)};
            parameters[0].Value = model.careTopicID;
            parameters[1].Value = model.topicCaredByUID;
            parameters[2].Value = model.careTopicState;

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
        public bool Update(Model.CareTopic model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CareTopic set ");
#warning 系统发现缺少更新的字段，请手工确认如此更新是否正确！
            strSql.Append("careTopicID=@careTopicID,");
            strSql.Append("topicCaredByUID=@topicCaredByUID,");
            strSql.Append("careTopicState=@careTopicState");
            strSql.Append(" where careTopicID=@careTopicID and topicCaredByUID=@topicCaredByUID ");
            SqlParameter[] parameters = {
					new SqlParameter("@careTopicID", SqlDbType.Int,4),
					new SqlParameter("@topicCaredByUID", SqlDbType.Int,4),
                    new SqlParameter("@careTopicState",SqlDbType.VarChar,50)};
            parameters[0].Value = model.careTopicID;
            parameters[1].Value = model.topicCaredByUID;
            parameters[2].Value = model.careTopicState;

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
        public bool Delete(int careTopicID, int topicCaredByUID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CareTopic ");
            strSql.Append(" where careTopicID=@careTopicID and topicCaredByUID=@topicCaredByUID ");
            SqlParameter[] parameters = {
					new SqlParameter("@careTopicID", SqlDbType.Int,4),
					new SqlParameter("@topicCaredByUID", SqlDbType.Int,4)			};
            parameters[0].Value = careTopicID;
            parameters[1].Value = topicCaredByUID;

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
        public Model.CareTopic GetModel(int careTopicID, int topicCaredByUID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 careTopicID,topicCaredByUID,careTopicState from CareTopic ");
            strSql.Append(" where careTopicID=@careTopicID and topicCaredByUID=@topicCaredByUID ");
            SqlParameter[] parameters = {
					new SqlParameter("@careTopicID", SqlDbType.Int,4),
					new SqlParameter("@topicCaredByUID", SqlDbType.Int,4)			};
            parameters[0].Value = careTopicID;
            parameters[1].Value = topicCaredByUID;

            Model.CareTopic model = new Model.CareTopic();
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
        public Model.CareTopic DataRowToModel(DataRow row)
        {
            Model.CareTopic model = new Model.CareTopic();
            if (row != null)
            {
                if (row["careTopicID"] != null && row["careTopicID"].ToString() != "")
                {
                    model.careTopicID = int.Parse(row["careTopicID"].ToString());
                }
                if (row["topicCaredByUID"] != null && row["topicCaredByUID"].ToString() != "")
                {
                    model.topicCaredByUID = int.Parse(row["topicCaredByUID"].ToString());
                }
                if (row["careTopicState"] != null && row["careTopicState"].ToString() != "")
                {
                    model.careTopicState = row["careTopicState"].ToString();
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
            strSql.Append("select careTopicID,topicCaredByUID,careTopicState ");
            strSql.Append(" FROM CareTopic ");
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
            strSql.Append(" careTopicID,topicCaredByUID,careTopicState ");
            strSql.Append(" FROM CareTopic ");
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
            strSql.Append("select count(1) FROM CareTopic ");
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
                strSql.Append("order by T.topicCaredByUID desc");
            }
            strSql.Append(")AS Row, T.*  from CareTopic T ");
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
            parameters[0].Value = "CareTopic";
            parameters[1].Value = "topicCaredByUID";
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
