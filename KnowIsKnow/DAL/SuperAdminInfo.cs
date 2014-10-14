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
    /// 数据访问类:SuperAdminInfo
    /// </summary>
    public partial class SuperAdminInfo
    {
        public SuperAdminInfo()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("superAdminID", "SuperAdminInfo");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int superAdminID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SuperAdminInfo");
            strSql.Append(" where superAdminID=@superAdminID ");
            SqlParameter[] parameters = {
					new SqlParameter("@superAdminID", SqlDbType.Int,4)			};
            parameters[0].Value = superAdminID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.SuperAdminInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SuperAdminInfo(");
            strSql.Append("superAdminID,superAdminEmail,superAdminPwd,superAdminVerifyCode)");
            strSql.Append(" values (");
            strSql.Append("@superAdminID,@superAdminEmail,@superAdminPwd,@superAdminVerifyCode)");
            SqlParameter[] parameters = {
					new SqlParameter("@superAdminID", SqlDbType.Int,4),
					new SqlParameter("@superAdminEmail", SqlDbType.VarChar,100),
					new SqlParameter("@superAdminPwd", SqlDbType.VarChar,50),
					new SqlParameter("@superAdminVerifyCode", SqlDbType.VarChar,16)};
            parameters[0].Value = model.superAdminID;
            parameters[1].Value = model.superAdminEmail;
            parameters[2].Value = model.superAdminPwd;
            parameters[3].Value = model.superAdminVerifyCode;

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
        public bool Update(Model.SuperAdminInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SuperAdminInfo set ");
            strSql.Append("superAdminEmail=@superAdminEmail,");
            strSql.Append("superAdminPwd=@superAdminPwd,");
            strSql.Append("superAdminVerifyCode=@superAdminVerifyCode");
            strSql.Append(" where superAdminID=@superAdminID ");
            SqlParameter[] parameters = {
					new SqlParameter("@superAdminEmail", SqlDbType.VarChar,100),
					new SqlParameter("@superAdminPwd", SqlDbType.VarChar,50),
					new SqlParameter("@superAdminVerifyCode", SqlDbType.VarChar,16),
					new SqlParameter("@superAdminID", SqlDbType.Int,4)};
            parameters[0].Value = model.superAdminEmail;
            parameters[1].Value = model.superAdminPwd;
            parameters[2].Value = model.superAdminVerifyCode;
            parameters[3].Value = model.superAdminID;

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
        public bool Delete(int superAdminID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SuperAdminInfo ");
            strSql.Append(" where superAdminID=@superAdminID ");
            SqlParameter[] parameters = {
					new SqlParameter("@superAdminID", SqlDbType.Int,4)			};
            parameters[0].Value = superAdminID;

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
        public bool DeleteList(string superAdminIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SuperAdminInfo ");
            strSql.Append(" where superAdminID in (" + superAdminIDlist + ")  ");
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
        public Model.SuperAdminInfo GetModel(int superAdminID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 superAdminID,superAdminEmail,superAdminPwd,superAdminVerifyCode from SuperAdminInfo ");
            strSql.Append(" where superAdminID=@superAdminID ");
            SqlParameter[] parameters = {
					new SqlParameter("@superAdminID", SqlDbType.Int,4)			};
            parameters[0].Value = superAdminID;

            Model.SuperAdminInfo model = new Model.SuperAdminInfo();
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
        public Model.SuperAdminInfo DataRowToModel(DataRow row)
        {
            Model.SuperAdminInfo model = new Model.SuperAdminInfo();
            if (row != null)
            {
                if (row["superAdminID"] != null && row["superAdminID"].ToString() != "")
                {
                    model.superAdminID = int.Parse(row["superAdminID"].ToString());
                }
                if (row["superAdminEmail"] != null)
                {
                    model.superAdminEmail = row["superAdminEmail"].ToString();
                }
                if (row["superAdminPwd"] != null)
                {
                    model.superAdminPwd = row["superAdminPwd"].ToString();
                }
                if (row["superAdminVerifyCode"] != null)
                {
                    model.superAdminVerifyCode = row["superAdminVerifyCode"].ToString();
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
            strSql.Append("select superAdminID,superAdminEmail,superAdminPwd,superAdminVerifyCode ");
            strSql.Append(" FROM SuperAdminInfo ");
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
            strSql.Append(" superAdminID,superAdminEmail,superAdminPwd,superAdminVerifyCode ");
            strSql.Append(" FROM SuperAdminInfo ");
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
            strSql.Append("select count(1) FROM SuperAdminInfo ");
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
                strSql.Append("order by T.superAdminID desc");
            }
            strSql.Append(")AS Row, T.*  from SuperAdminInfo T ");
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
            parameters[0].Value = "SuperAdminInfo";
            parameters[1].Value = "superAdminID";
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
