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
    /// 数据访问类:MessageInfo
    /// </summary>
    public partial class MessageInfo
    {
        public MessageInfo()
        { }
        public int UpdataMessage(string sql)
        {
            int da = DbHelperSQL.ExecuteSql(sql);
            return da;
        }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("MessageID", "MessageInfo");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int MessageID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from MessageInfo");
            strSql.Append(" where MessageID=@MessageID");
            SqlParameter[] parameters = {
					new SqlParameter("@MessageID", SqlDbType.Int,4)
			};
            parameters[0].Value = MessageID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.MessageInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MessageInfo(");
            strSql.Append("MessageSenderID,MessageReceiverID,MessageContent,MessageSendTime,MessageSate,MessageReportID)");
            strSql.Append(" values (");
            strSql.Append("@MessageSenderID,@MessageReceiverID,@MessageContent,@MessageSendTime,@MessageSate,@MessageReportID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MessageSenderID", SqlDbType.Int,4),
					new SqlParameter("@MessageReceiverID", SqlDbType.Int,4),
					new SqlParameter("@MessageContent", SqlDbType.VarChar,400),
					new SqlParameter("@MessageSendTime", SqlDbType.DateTime),
					new SqlParameter("@MessageSate", SqlDbType.VarChar,20),
					new SqlParameter("@MessageReportID", SqlDbType.Int,4)};
            parameters[0].Value = model.MessageSenderID;
            parameters[1].Value = model.MessageReceiverID;
            parameters[2].Value = model.MessageContent;
            parameters[3].Value = model.MessageSendTime;
            parameters[4].Value = model.MessageSate;
            parameters[5].Value = model.MessageReportID;

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
        public bool Update(Model.MessageInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MessageInfo set ");
            strSql.Append("MessageSenderID=@MessageSenderID,");
            strSql.Append("MessageReceiverID=@MessageReceiverID,");
            strSql.Append("MessageContent=@MessageContent,");
            strSql.Append("MessageSendTime=@MessageSendTime,");
            strSql.Append("MessageSate=@MessageSate,");
            strSql.Append("MessageReportID=@MessageReportID");
            strSql.Append(" where MessageID=@MessageID");
            SqlParameter[] parameters = {
					new SqlParameter("@MessageSenderID", SqlDbType.Int,4),
					new SqlParameter("@MessageReceiverID", SqlDbType.Int,4),
					new SqlParameter("@MessageContent", SqlDbType.VarChar,400),
					new SqlParameter("@MessageSendTime", SqlDbType.DateTime),
					new SqlParameter("@MessageSate", SqlDbType.VarChar,20),
					new SqlParameter("@MessageReportID", SqlDbType.Int,4),
					new SqlParameter("@MessageID", SqlDbType.Int,4)};
            parameters[0].Value = model.MessageSenderID;
            parameters[1].Value = model.MessageReceiverID;
            parameters[2].Value = model.MessageContent;
            parameters[3].Value = model.MessageSendTime;
            parameters[4].Value = model.MessageSate;
            parameters[5].Value = model.MessageReportID;
            parameters[6].Value = model.MessageID;

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
        public bool Delete(int MessageID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MessageInfo ");
            strSql.Append(" where MessageID=@MessageID");
            SqlParameter[] parameters = {
					new SqlParameter("@MessageID", SqlDbType.Int,4)
			};
            parameters[0].Value = MessageID;

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
        public bool DeleteList(string MessageIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MessageInfo ");
            strSql.Append(" where MessageID in (" + MessageIDlist + ")  ");
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
        public Model.MessageInfo GetModel(int MessageID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 MessageID,MessageSenderID,MessageReceiverID,MessageContent,MessageSendTime,MessageSate,MessageReportID from MessageInfo ");
            strSql.Append(" where MessageID=@MessageID");
            SqlParameter[] parameters = {
					new SqlParameter("@MessageID", SqlDbType.Int,4)
			};
            parameters[0].Value = MessageID;

            Model.MessageInfo model = new Model.MessageInfo();
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
        public Model.MessageInfo DataRowToModel(DataRow row)
        {
            Model.MessageInfo model = new Model.MessageInfo();
            if (row != null)
            {
                if (row["MessageID"] != null && row["MessageID"].ToString() != "")
                {
                    model.MessageID = int.Parse(row["MessageID"].ToString());
                }
                if (row["MessageSenderID"] != null && row["MessageSenderID"].ToString() != "")
                {
                    model.MessageSenderID = int.Parse(row["MessageSenderID"].ToString());
                }
                if (row["MessageReceiverID"] != null && row["MessageReceiverID"].ToString() != "")
                {
                    model.MessageReceiverID = int.Parse(row["MessageReceiverID"].ToString());
                }
                if (row["MessageContent"] != null)
                {
                    model.MessageContent = row["MessageContent"].ToString();
                }
                if (row["MessageSendTime"] != null && row["MessageSendTime"].ToString() != "")
                {
                    model.MessageSendTime = DateTime.Parse(row["MessageSendTime"].ToString());
                }
                if (row["MessageSate"] != null)
                {
                    model.MessageSate = row["MessageSate"].ToString();
                }
                if (row["MessageReportID"] != null && row["MessageReportID"].ToString() != "")
                {
                    model.MessageReportID = int.Parse(row["MessageReportID"].ToString());
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
            strSql.Append("select MessageID,MessageSenderID,MessageReceiverID,MessageContent,MessageSendTime,MessageSate,MessageReportID ");
            strSql.Append(" FROM MessageInfo ");
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
            strSql.Append(" MessageID,MessageSenderID,MessageReceiverID,MessageContent,MessageSendTime,MessageSate,MessageReportID ");
            strSql.Append(" FROM MessageInfo ");
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
            strSql.Append("select count(1) FROM MessageInfo ");
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
                strSql.Append("order by T.MessageID desc");
            }
            strSql.Append(")AS Row, T.*  from MessageInfo T ");
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
            parameters[0].Value = "MessageInfo";
            parameters[1].Value = "MessageID";
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
