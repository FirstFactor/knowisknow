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
    /// 数据访问类:TopicInfo
    /// </summary>
    public partial class TopicInfo
    {
        public TopicInfo()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("topicID", "TopicInfo");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int topicID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TopicInfo");
            strSql.Append(" where topicID=@topicID");
            SqlParameter[] parameters = {
					new SqlParameter("@topicID", SqlDbType.Int,4)
			};
            parameters[0].Value = topicID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.TopicInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TopicInfo(");
            strSql.Append("topicTitle,topicDes,topicPicUrl,topicAttention,topicState)");
            strSql.Append(" values (");
            strSql.Append("@topicTitle,@topicDes,@topicPicUrl,@topicAttention,@topicState)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@topicTitle", SqlDbType.NVarChar,50),
					new SqlParameter("@topicDes", SqlDbType.NVarChar,400),
					new SqlParameter("@topicPicUrl", SqlDbType.VarChar,100),
					new SqlParameter("@topicAttention", SqlDbType.Int,4),
					new SqlParameter("@topicState", SqlDbType.VarChar,50)};
            parameters[0].Value = model.topicTitle;
            parameters[1].Value = model.topicDes;
            parameters[2].Value = model.topicPicUrl;
            parameters[3].Value = model.topicAttention;
            parameters[4].Value = model.topicState;

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
        public bool Update(Model.TopicInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TopicInfo set ");
            strSql.Append("topicTitle=@topicTitle,");
            strSql.Append("topicDes=@topicDes,");
            strSql.Append("topicPicUrl=@topicPicUrl,");
            strSql.Append("topicAttention=@topicAttention,");
            strSql.Append("topicState=@topicState");
            strSql.Append(" where topicID=@topicID");
            SqlParameter[] parameters = {
					new SqlParameter("@topicTitle", SqlDbType.NVarChar,50),
					new SqlParameter("@topicDes", SqlDbType.NVarChar,400),
					new SqlParameter("@topicPicUrl", SqlDbType.VarChar,100),
					new SqlParameter("@topicAttention", SqlDbType.Int,4),
					new SqlParameter("@topicState", SqlDbType.VarChar,50),
					new SqlParameter("@topicID", SqlDbType.Int,4)};
            parameters[0].Value = model.topicTitle;
            parameters[1].Value = model.topicDes;
            parameters[2].Value = model.topicPicUrl;
            parameters[3].Value = model.topicAttention;
            parameters[4].Value = model.topicState;
            parameters[5].Value = model.topicID;

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
        public bool Delete(int topicID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TopicInfo ");
            strSql.Append(" where topicID=@topicID");
            SqlParameter[] parameters = {
					new SqlParameter("@topicID", SqlDbType.Int,4)
			};
            parameters[0].Value = topicID;

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
        public bool DeleteList(string topicIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TopicInfo ");
            strSql.Append(" where topicID in (" + topicIDlist + ")  ");
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
        public Model.TopicInfo GetModel(int topicID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 topicID,topicTitle,topicDes,topicPicUrl,topicAttention,topicState from TopicInfo ");
            strSql.Append(" where topicID=@topicID");
            SqlParameter[] parameters = {
					new SqlParameter("@topicID", SqlDbType.Int,4)
			};
            parameters[0].Value = topicID;

            Model.TopicInfo model = new Model.TopicInfo();
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
        public Model.TopicInfo DataRowToModel(DataRow row)
        {
            Model.TopicInfo model = new Model.TopicInfo();
            if (row != null)
            {
                if (row["topicID"] != null && row["topicID"].ToString() != "")
                {
                    model.topicID = int.Parse(row["topicID"].ToString());
                }
                if (row["topicTitle"] != null)
                {
                    model.topicTitle = row["topicTitle"].ToString();
                }
                if (row["topicDes"] != null)
                {
                    model.topicDes = row["topicDes"].ToString();
                }
                if (row["topicPicUrl"] != null)
                {
                    model.topicPicUrl = row["topicPicUrl"].ToString();
                }
                if (row["topicAttention"] != null && row["topicAttention"].ToString() != "")
                {
                    model.topicAttention = int.Parse(row["topicAttention"].ToString());
                }
                if (row["topicState"] != null)
                {
                    model.topicState = row["topicState"].ToString();
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
            strSql.Append("select topicID,topicTitle,topicDes,topicPicUrl,topicAttention,topicState ");
            strSql.Append(" FROM TopicInfo ");
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
            strSql.Append(" topicID,topicTitle,topicDes,topicPicUrl,topicAttention,topicState ");
            strSql.Append(" FROM TopicInfo ");
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
            strSql.Append("select count(1) FROM TopicInfo ");
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
                strSql.Append("order by T.topicID desc");
            }
            strSql.Append(")AS Row, T.*  from TopicInfo T ");
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
            parameters[0].Value = "TopicInfo";
            parameters[1].Value = "topicID";
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
