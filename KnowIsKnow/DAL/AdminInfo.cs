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
    /// 数据访问类:AdminInfo
    /// </summary>
    public partial class AdminInfo
    {
        public AdminInfo()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("adminID", "AdminInfo");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int adminID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from AdminInfo");
            strSql.Append(" where adminID=@adminID");
            SqlParameter[] parameters = {
					new SqlParameter("@adminID", SqlDbType.Int,4)
			};
            parameters[0].Value = adminID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.AdminInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into AdminInfo(");
            strSql.Append("adminEmail,adminPwd,adminNickName,adminState,adminVerifyCode,canAddTopic,canDeleteTopic,canDeleteQuestion,canDeleteanswer,canAddQuestion,canAnswer,canSendMes)");
            strSql.Append(" values (");
            strSql.Append("@adminEmail,@adminPwd,@adminNickName,@adminState,@adminVerifyCode,@canAddTopic,@canDeleteTopic,@canDeleteQuestion,@canDeleteanswer,@canAddQuestion,@canAnswer,@canSendMes)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@adminEmail", SqlDbType.VarChar,100),
					new SqlParameter("@adminPwd", SqlDbType.VarChar,50),
					new SqlParameter("@adminNickName", SqlDbType.NVarChar,20),
					new SqlParameter("@adminState", SqlDbType.VarChar,20),
					new SqlParameter("@adminVerifyCode", SqlDbType.VarChar,16),
					new SqlParameter("@canAddTopic", SqlDbType.Bit,1),
					new SqlParameter("@canDeleteTopic", SqlDbType.Bit,1),
					new SqlParameter("@canDeleteQuestion", SqlDbType.Bit,1),
					new SqlParameter("@canDeleteanswer", SqlDbType.Bit,1),
					new SqlParameter("@canAddQuestion", SqlDbType.Bit,1),
					new SqlParameter("@canAnswer", SqlDbType.Bit,1),
					new SqlParameter("@canSendMes", SqlDbType.Bit,1)};
            parameters[0].Value = model.adminEmail;
            parameters[1].Value = model.adminPwd;
            parameters[2].Value = model.adminNickName;
            parameters[3].Value = model.adminState;
            parameters[4].Value = model.adminVerifyCode;
            parameters[5].Value = model.canAddTopic;
            parameters[6].Value = model.canDeleteTopic;
            parameters[7].Value = model.canDeleteQuestion;
            parameters[8].Value = model.canDeleteanswer;
            parameters[9].Value = model.canAddQuestion;
            parameters[10].Value = model.canAnswer;
            parameters[11].Value = model.canSendMes;

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
        public bool Update(Model.AdminInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update AdminInfo set ");
            strSql.Append("adminEmail=@adminEmail,");
            strSql.Append("adminPwd=@adminPwd,");
            strSql.Append("adminNickName=@adminNickName,");
            strSql.Append("adminState=@adminState,");
            strSql.Append("adminVerifyCode=@adminVerifyCode,");
            strSql.Append("canAddTopic=@canAddTopic,");
            strSql.Append("canDeleteTopic=@canDeleteTopic,");
            strSql.Append("canDeleteQuestion=@canDeleteQuestion,");
            strSql.Append("canDeleteanswer=@canDeleteanswer,");
            strSql.Append("canAddQuestion=@canAddQuestion,");
            strSql.Append("canAnswer=@canAnswer,");
            strSql.Append("canSendMes=@canSendMes");
            strSql.Append(" where adminID=@adminID");
            SqlParameter[] parameters = {
					new SqlParameter("@adminEmail", SqlDbType.VarChar,100),
					new SqlParameter("@adminPwd", SqlDbType.VarChar,50),
					new SqlParameter("@adminNickName", SqlDbType.NVarChar,20),
					new SqlParameter("@adminState", SqlDbType.VarChar,20),
					new SqlParameter("@adminVerifyCode", SqlDbType.VarChar,16),
					new SqlParameter("@canAddTopic", SqlDbType.Bit,1),
					new SqlParameter("@canDeleteTopic", SqlDbType.Bit,1),
					new SqlParameter("@canDeleteQuestion", SqlDbType.Bit,1),
					new SqlParameter("@canDeleteanswer", SqlDbType.Bit,1),
					new SqlParameter("@canAddQuestion", SqlDbType.Bit,1),
					new SqlParameter("@canAnswer", SqlDbType.Bit,1),
					new SqlParameter("@canSendMes", SqlDbType.Bit,1),
					new SqlParameter("@adminID", SqlDbType.Int,4)};
            parameters[0].Value = model.adminEmail;
            parameters[1].Value = model.adminPwd;
            parameters[2].Value = model.adminNickName;
            parameters[3].Value = model.adminState;
            parameters[4].Value = model.adminVerifyCode;
            parameters[5].Value = model.canAddTopic;
            parameters[6].Value = model.canDeleteTopic;
            parameters[7].Value = model.canDeleteQuestion;
            parameters[8].Value = model.canDeleteanswer;
            parameters[9].Value = model.canAddQuestion;
            parameters[10].Value = model.canAnswer;
            parameters[11].Value = model.canSendMes;
            parameters[12].Value = model.adminID;

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
        public bool Delete(int adminID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from AdminInfo ");
            strSql.Append(" where adminID=@adminID");
            SqlParameter[] parameters = {
					new SqlParameter("@adminID", SqlDbType.Int,4)
			};
            parameters[0].Value = adminID;

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
        public bool DeleteList(string adminIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from AdminInfo ");
            strSql.Append(" where adminID in (" + adminIDlist + ")  ");
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
        public Model.AdminInfo GetModel(int adminID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 adminID,adminEmail,adminPwd,adminNickName,adminState,adminVerifyCode,canAddTopic,canDeleteTopic,canDeleteQuestion,canDeleteanswer,canAddQuestion,canAnswer,canSendMes from AdminInfo ");
            strSql.Append(" where adminID=@adminID");
            SqlParameter[] parameters = {
					new SqlParameter("@adminID", SqlDbType.Int,4)
			};
            parameters[0].Value = adminID;

            Model.AdminInfo model = new Model.AdminInfo();
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
        public Model.AdminInfo DataRowToModel(DataRow row)
        {
            Model.AdminInfo model = new Model.AdminInfo();
            if (row != null)
            {
                if (row["adminID"] != null && row["adminID"].ToString() != "")
                {
                    model.adminID = int.Parse(row["adminID"].ToString());
                }
                if (row["adminEmail"] != null)
                {
                    model.adminEmail = row["adminEmail"].ToString();
                }
                if (row["adminPwd"] != null)
                {
                    model.adminPwd = row["adminPwd"].ToString();
                }
                if (row["adminNickName"] != null)
                {
                    model.adminNickName = row["adminNickName"].ToString();
                }
                if (row["adminState"] != null)
                {
                    model.adminState = row["adminState"].ToString();
                }
                if (row["adminVerifyCode"] != null)
                {
                    model.adminVerifyCode = row["adminVerifyCode"].ToString();
                }
                if (row["canAddTopic"] != null && row["canAddTopic"].ToString() != "")
                {
                    if ((row["canAddTopic"].ToString() == "1") || (row["canAddTopic"].ToString().ToLower() == "true"))
                    {
                        model.canAddTopic = true;
                    }
                    else
                    {
                        model.canAddTopic = false;
                    }
                }
                if (row["canDeleteTopic"] != null && row["canDeleteTopic"].ToString() != "")
                {
                    if ((row["canDeleteTopic"].ToString() == "1") || (row["canDeleteTopic"].ToString().ToLower() == "true"))
                    {
                        model.canDeleteTopic = true;
                    }
                    else
                    {
                        model.canDeleteTopic = false;
                    }
                }
                if (row["canDeleteQuestion"] != null && row["canDeleteQuestion"].ToString() != "")
                {
                    if ((row["canDeleteQuestion"].ToString() == "1") || (row["canDeleteQuestion"].ToString().ToLower() == "true"))
                    {
                        model.canDeleteQuestion = true;
                    }
                    else
                    {
                        model.canDeleteQuestion = false;
                    }
                }
                if (row["canDeleteanswer"] != null && row["canDeleteanswer"].ToString() != "")
                {
                    if ((row["canDeleteanswer"].ToString() == "1") || (row["canDeleteanswer"].ToString().ToLower() == "true"))
                    {
                        model.canDeleteanswer = true;
                    }
                    else
                    {
                        model.canDeleteanswer = false;
                    }
                }
                if (row["canAddQuestion"] != null && row["canAddQuestion"].ToString() != "")
                {
                    if ((row["canAddQuestion"].ToString() == "1") || (row["canAddQuestion"].ToString().ToLower() == "true"))
                    {
                        model.canAddQuestion = true;
                    }
                    else
                    {
                        model.canAddQuestion = false;
                    }
                }
                if (row["canAnswer"] != null && row["canAnswer"].ToString() != "")
                {
                    if ((row["canAnswer"].ToString() == "1") || (row["canAnswer"].ToString().ToLower() == "true"))
                    {
                        model.canAnswer = true;
                    }
                    else
                    {
                        model.canAnswer = false;
                    }
                }
                if (row["canSendMes"] != null && row["canSendMes"].ToString() != "")
                {
                    if ((row["canSendMes"].ToString() == "1") || (row["canSendMes"].ToString().ToLower() == "true"))
                    {
                        model.canSendMes = true;
                    }
                    else
                    {
                        model.canSendMes = false;
                    }
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
            strSql.Append("select adminID,adminEmail,adminPwd,adminNickName,adminState,adminVerifyCode,canAddTopic,canDeleteTopic,canDeleteQuestion,canDeleteanswer,canAddQuestion,canAnswer,canSendMes ");
            strSql.Append(" FROM AdminInfo ");
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
            strSql.Append(" adminID,adminEmail,adminPwd,adminNickName,adminState,adminVerifyCode,canAddTopic,canDeleteTopic,canDeleteQuestion,canDeleteanswer,canAddQuestion,canAnswer,canSendMes ");
            strSql.Append(" FROM AdminInfo ");
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
            strSql.Append("select count(1) FROM AdminInfo ");
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
                strSql.Append("order by T.adminID desc");
            }
            strSql.Append(")AS Row, T.*  from AdminInfo T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        
       /* /// <summary>
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
            parameters[0].Value = "AdminInfo";
            parameters[1].Value = "adminID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }
        */
        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
