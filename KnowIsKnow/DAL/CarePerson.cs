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
    /// 数据访问类:CarePerson
    /// </summary>
    public partial class CarePerson
    {
        public CarePerson()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("carePersonID", "CarePerson");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int carePersonID, int personCaredByUID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CarePerson");
            strSql.Append(" where carePersonID=@carePersonID and personCaredByUID=@personCaredByUID ");
            SqlParameter[] parameters = {
					new SqlParameter("@carePersonID", SqlDbType.Int,4),
					new SqlParameter("@personCaredByUID", SqlDbType.Int,4)			};
            parameters[0].Value = carePersonID;
            parameters[1].Value = personCaredByUID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.CarePerson model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CarePerson(");
            strSql.Append("carePersonID,personCaredByUID)");
            strSql.Append(" values (");
            strSql.Append("@carePersonID,@personCaredByUID)");
            SqlParameter[] parameters = {
					new SqlParameter("@carePersonID", SqlDbType.Int,4),
					new SqlParameter("@personCaredByUID", SqlDbType.Int,4)};
            parameters[0].Value = model.carePersonID;
            parameters[1].Value = model.personCaredByUID;

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
        public bool Update(Model.CarePerson model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CarePerson set ");
        #warning 系统发现缺少更新的字段，请手工确认如此更新是否正确！
            strSql.Append("carePersonID=@carePersonID,");
            strSql.Append("personCaredByUID=@personCaredByUID");
            strSql.Append(" where carePersonID=@carePersonID and personCaredByUID=@personCaredByUID ");
            SqlParameter[] parameters = {
					new SqlParameter("@carePersonID", SqlDbType.Int,4),
					new SqlParameter("@personCaredByUID", SqlDbType.Int,4)};
            parameters[0].Value = model.carePersonID;
            parameters[1].Value = model.personCaredByUID;

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
        public bool Delete(int carePersonID, int personCaredByUID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CarePerson ");
            strSql.Append(" where carePersonID=@carePersonID and personCaredByUID=@personCaredByUID ");
            SqlParameter[] parameters = {
					new SqlParameter("@carePersonID", SqlDbType.Int,4),
					new SqlParameter("@personCaredByUID", SqlDbType.Int,4)			};
            parameters[0].Value = carePersonID;
            parameters[1].Value = personCaredByUID;

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
        public Model.CarePerson GetModel(int carePersonID, int personCaredByUID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 carePersonID,personCaredByUID from CarePerson ");
            strSql.Append(" where carePersonID=@carePersonID and personCaredByUID=@personCaredByUID ");
            SqlParameter[] parameters = {
					new SqlParameter("@carePersonID", SqlDbType.Int,4),
					new SqlParameter("@personCaredByUID", SqlDbType.Int,4)			};
            parameters[0].Value = carePersonID;
            parameters[1].Value = personCaredByUID;

            Model.CarePerson model = new Model.CarePerson();
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
        public Model.CarePerson DataRowToModel(DataRow row)
        {
            Model.CarePerson model = new Model.CarePerson();
            if (row != null)
            {
                if (row["carePersonID"] != null && row["carePersonID"].ToString() != "")
                {
                    model.carePersonID = int.Parse(row["carePersonID"].ToString());
                }
                if (row["personCaredByUID"] != null && row["personCaredByUID"].ToString() != "")
                {
                    model.personCaredByUID = int.Parse(row["personCaredByUID"].ToString());
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
            strSql.Append("select carePersonID,personCaredByUID ");
            strSql.Append(" FROM CarePerson ");
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
            strSql.Append(" carePersonID,personCaredByUID ");
            strSql.Append(" FROM CarePerson ");
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
            strSql.Append("select count(1) FROM CarePerson ");
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
                strSql.Append("order by T.personCaredByUID desc");
            }
            strSql.Append(")AS Row, T.*  from CarePerson T ");
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
            parameters[0].Value = "CarePerson";
            parameters[1].Value = "personCaredByUID";
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
