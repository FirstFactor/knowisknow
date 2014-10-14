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
    /// 数据访问类:CarePersonUserInfoView
    /// </summary>
    public partial class CarePersonUserInfoView
    {
        public CarePersonUserInfoView()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int carePersonID, int personCaredByUID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CarePersonUserInfoView");
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
        public bool Add(Model.CarePersonUserInfoView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CarePersonUserInfoView(");
            strSql.Append("carePersonID,personCaredByUID,userEmail,userNickName,userHeadImage,userState,userGender,userBirthday,userAdress,userJob,userShuoShuo,userCompany,userJobPosition,userAcademy,userMajor,userProBio,cuserEmail,cuserNickName,cuserHeadImage,cuserState,cuserGender,cuserBirthday,cuserAdress,cuserJob,cuserShuoShuo,cuserCompany,cuserJobPosition,cuserAcademy,cuserMajor,cuserProBio)");
            strSql.Append(" values (");
            strSql.Append("@carePersonID,@personCaredByUID,@userEmail,@userNickName,@userHeadImage,@userState,@userGender,@userBirthday,@userAdress,@userJob,@userShuoShuo,@userCompany,@userJobPosition,@userAcademy,@userMajor,@userProBio,@cuserEmail,@cuserNickName,@cuserHeadImage,@cuserState,@cuserGender,@cuserBirthday,@cuserAdress,@cuserJob,@cuserShuoShuo,@cuserCompany,@cuserJobPosition,@cuserAcademy,@cuserMajor,@cuserProBio)");
            SqlParameter[] parameters = {
					new SqlParameter("@carePersonID", SqlDbType.Int,4),
					new SqlParameter("@personCaredByUID", SqlDbType.Int,4),
					new SqlParameter("@userEmail", SqlDbType.VarChar,100),
					new SqlParameter("@userNickName", SqlDbType.VarChar,20),
					new SqlParameter("@userHeadImage", SqlDbType.VarChar,100),
					new SqlParameter("@userState", SqlDbType.VarChar,20),
					new SqlParameter("@userGender", SqlDbType.NVarChar,1),
					new SqlParameter("@userBirthday", SqlDbType.Date,3),
					new SqlParameter("@userAdress", SqlDbType.VarChar,100),
					new SqlParameter("@userJob", SqlDbType.VarChar,50),
					new SqlParameter("@userShuoShuo", SqlDbType.VarChar,50),
					new SqlParameter("@userCompany", SqlDbType.VarChar,50),
					new SqlParameter("@userJobPosition", SqlDbType.VarChar,50),
					new SqlParameter("@userAcademy", SqlDbType.VarChar,50),
					new SqlParameter("@userMajor", SqlDbType.VarChar,50),
					new SqlParameter("@userProBio", SqlDbType.VarChar,-1),
					new SqlParameter("@cuserEmail", SqlDbType.VarChar,100),
					new SqlParameter("@cuserNickName", SqlDbType.VarChar,20),
					new SqlParameter("@cuserHeadImage", SqlDbType.VarChar,100),
					new SqlParameter("@cuserState", SqlDbType.VarChar,20),
					new SqlParameter("@cuserGender", SqlDbType.NVarChar,1),
					new SqlParameter("@cuserBirthday", SqlDbType.Date,3),
					new SqlParameter("@cuserAdress", SqlDbType.VarChar,100),
					new SqlParameter("@cuserJob", SqlDbType.VarChar,50),
					new SqlParameter("@cuserShuoShuo", SqlDbType.VarChar,50),
					new SqlParameter("@cuserCompany", SqlDbType.VarChar,50),
					new SqlParameter("@cuserJobPosition", SqlDbType.VarChar,50),
					new SqlParameter("@cuserAcademy", SqlDbType.VarChar,50),
					new SqlParameter("@cuserMajor", SqlDbType.VarChar,50),
					new SqlParameter("@cuserProBio", SqlDbType.VarChar,-1)};
            parameters[0].Value = model.carePersonID;
            parameters[1].Value = model.personCaredByUID;
            parameters[2].Value = model.userEmail;
            parameters[3].Value = model.userNickName;
            parameters[4].Value = model.userHeadImage;
            parameters[5].Value = model.userState;
            parameters[6].Value = model.userGender;
            parameters[7].Value = model.userBirthday;
            parameters[8].Value = model.userAdress;
            parameters[9].Value = model.userJob;
            parameters[10].Value = model.userShuoShuo;
            parameters[11].Value = model.userCompany;
            parameters[12].Value = model.userJobPosition;
            parameters[13].Value = model.userAcademy;
            parameters[14].Value = model.userMajor;
            parameters[15].Value = model.userProBio;
            parameters[16].Value = model.cuserEmail;
            parameters[17].Value = model.cuserNickName;
            parameters[18].Value = model.cuserHeadImage;
            parameters[19].Value = model.cuserState;
            parameters[20].Value = model.cuserGender;
            parameters[21].Value = model.cuserBirthday;
            parameters[22].Value = model.cuserAdress;
            parameters[23].Value = model.cuserJob;
            parameters[24].Value = model.cuserShuoShuo;
            parameters[25].Value = model.cuserCompany;
            parameters[26].Value = model.cuserJobPosition;
            parameters[27].Value = model.cuserAcademy;
            parameters[28].Value = model.cuserMajor;
            parameters[29].Value = model.cuserProBio;

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
        public bool Update(Model.CarePersonUserInfoView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CarePersonUserInfoView set ");
            strSql.Append("carePersonID=@carePersonID,");
            strSql.Append("personCaredByUID=@personCaredByUID,");
            strSql.Append("userEmail=@userEmail,");
            strSql.Append("userNickName=@userNickName,");
            strSql.Append("userHeadImage=@userHeadImage,");
            strSql.Append("userState=@userState,");
            strSql.Append("userGender=@userGender,");
            strSql.Append("userBirthday=@userBirthday,");
            strSql.Append("userAdress=@userAdress,");
            strSql.Append("userJob=@userJob,");
            strSql.Append("userShuoShuo=@userShuoShuo,");
            strSql.Append("userCompany=@userCompany,");
            strSql.Append("userJobPosition=@userJobPosition,");
            strSql.Append("userAcademy=@userAcademy,");
            strSql.Append("userMajor=@userMajor,");
            strSql.Append("userProBio=@userProBio,");
            strSql.Append("cuserEmail=@cuserEmail,");
            strSql.Append("cuserNickName=@cuserNickName,");
            strSql.Append("cuserHeadImage=@cuserHeadImage,");
            strSql.Append("cuserState=@cuserState,");
            strSql.Append("cuserGender=@cuserGender,");
            strSql.Append("cuserBirthday=@cuserBirthday,");
            strSql.Append("cuserAdress=@cuserAdress,");
            strSql.Append("cuserJob=@cuserJob,");
            strSql.Append("cuserShuoShuo=@cuserShuoShuo,");
            strSql.Append("cuserCompany=@cuserCompany,");
            strSql.Append("cuserJobPosition=@cuserJobPosition,");
            strSql.Append("cuserAcademy=@cuserAcademy,");
            strSql.Append("cuserMajor=@cuserMajor,");
            strSql.Append("cuserProBio=@cuserProBio");
            strSql.Append(" where carePersonID=@carePersonID and personCaredByUID=@personCaredByUID ");
            SqlParameter[] parameters = {
					new SqlParameter("@carePersonID", SqlDbType.Int,4),
					new SqlParameter("@personCaredByUID", SqlDbType.Int,4),
					new SqlParameter("@userEmail", SqlDbType.VarChar,100),
					new SqlParameter("@userNickName", SqlDbType.VarChar,20),
					new SqlParameter("@userHeadImage", SqlDbType.VarChar,100),
					new SqlParameter("@userState", SqlDbType.VarChar,20),
					new SqlParameter("@userGender", SqlDbType.NVarChar,1),
					new SqlParameter("@userBirthday", SqlDbType.Date,3),
					new SqlParameter("@userAdress", SqlDbType.VarChar,100),
					new SqlParameter("@userJob", SqlDbType.VarChar,50),
					new SqlParameter("@userShuoShuo", SqlDbType.VarChar,50),
					new SqlParameter("@userCompany", SqlDbType.VarChar,50),
					new SqlParameter("@userJobPosition", SqlDbType.VarChar,50),
					new SqlParameter("@userAcademy", SqlDbType.VarChar,50),
					new SqlParameter("@userMajor", SqlDbType.VarChar,50),
					new SqlParameter("@userProBio", SqlDbType.VarChar,-1),
					new SqlParameter("@cuserEmail", SqlDbType.VarChar,100),
					new SqlParameter("@cuserNickName", SqlDbType.VarChar,20),
					new SqlParameter("@cuserHeadImage", SqlDbType.VarChar,100),
					new SqlParameter("@cuserState", SqlDbType.VarChar,20),
					new SqlParameter("@cuserGender", SqlDbType.NVarChar,1),
					new SqlParameter("@cuserBirthday", SqlDbType.Date,3),
					new SqlParameter("@cuserAdress", SqlDbType.VarChar,100),
					new SqlParameter("@cuserJob", SqlDbType.VarChar,50),
					new SqlParameter("@cuserShuoShuo", SqlDbType.VarChar,50),
					new SqlParameter("@cuserCompany", SqlDbType.VarChar,50),
					new SqlParameter("@cuserJobPosition", SqlDbType.VarChar,50),
					new SqlParameter("@cuserAcademy", SqlDbType.VarChar,50),
					new SqlParameter("@cuserMajor", SqlDbType.VarChar,50),
					new SqlParameter("@cuserProBio", SqlDbType.VarChar,-1)};
            parameters[0].Value = model.carePersonID;
            parameters[1].Value = model.personCaredByUID;
            parameters[2].Value = model.userEmail;
            parameters[3].Value = model.userNickName;
            parameters[4].Value = model.userHeadImage;
            parameters[5].Value = model.userState;
            parameters[6].Value = model.userGender;
            parameters[7].Value = model.userBirthday;
            parameters[8].Value = model.userAdress;
            parameters[9].Value = model.userJob;
            parameters[10].Value = model.userShuoShuo;
            parameters[11].Value = model.userCompany;
            parameters[12].Value = model.userJobPosition;
            parameters[13].Value = model.userAcademy;
            parameters[14].Value = model.userMajor;
            parameters[15].Value = model.userProBio;
            parameters[16].Value = model.cuserEmail;
            parameters[17].Value = model.cuserNickName;
            parameters[18].Value = model.cuserHeadImage;
            parameters[19].Value = model.cuserState;
            parameters[20].Value = model.cuserGender;
            parameters[21].Value = model.cuserBirthday;
            parameters[22].Value = model.cuserAdress;
            parameters[23].Value = model.cuserJob;
            parameters[24].Value = model.cuserShuoShuo;
            parameters[25].Value = model.cuserCompany;
            parameters[26].Value = model.cuserJobPosition;
            parameters[27].Value = model.cuserAcademy;
            parameters[28].Value = model.cuserMajor;
            parameters[29].Value = model.cuserProBio;

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
            strSql.Append("delete from CarePersonUserInfoView ");
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
        public Model.CarePersonUserInfoView GetModel(int carePersonID, int personCaredByUID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 carePersonID,personCaredByUID,userEmail,userNickName,userHeadImage,userState,userGender,userBirthday,userAdress,userJob,userShuoShuo,userCompany,userJobPosition,userAcademy,userMajor,userProBio,cuserEmail,cuserNickName,cuserHeadImage,cuserState,cuserGender,cuserBirthday,cuserAdress,cuserJob,cuserShuoShuo,cuserCompany,cuserJobPosition,cuserAcademy,cuserMajor,cuserProBio from CarePersonUserInfoView ");
            strSql.Append(" where carePersonID=@carePersonID and personCaredByUID=@personCaredByUID ");
            SqlParameter[] parameters = {
					new SqlParameter("@carePersonID", SqlDbType.Int,4),
					new SqlParameter("@personCaredByUID", SqlDbType.Int,4)			};
            parameters[0].Value = carePersonID;
            parameters[1].Value = personCaredByUID;

            Model.CarePersonUserInfoView model = new Model.CarePersonUserInfoView();
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
        public Model.CarePersonUserInfoView DataRowToModel(DataRow row)
        {
            Model.CarePersonUserInfoView model = new Model.CarePersonUserInfoView();
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
                if (row["userEmail"] != null)
                {
                    model.userEmail = row["userEmail"].ToString();
                }
                if (row["userNickName"] != null)
                {
                    model.userNickName = row["userNickName"].ToString();
                }
                if (row["userHeadImage"] != null)
                {
                    model.userHeadImage = row["userHeadImage"].ToString();
                }
                if (row["userState"] != null)
                {
                    model.userState = row["userState"].ToString();
                }
                if (row["userGender"] != null)
                {
                    model.userGender = row["userGender"].ToString();
                }
                if (row["userBirthday"] != null && row["userBirthday"].ToString() != "")
                {
                    model.userBirthday = DateTime.Parse(row["userBirthday"].ToString());
                }
                if (row["userAdress"] != null)
                {
                    model.userAdress = row["userAdress"].ToString();
                }
                if (row["userJob"] != null)
                {
                    model.userJob = row["userJob"].ToString();
                }
                if (row["userShuoShuo"] != null)
                {
                    model.userShuoShuo = row["userShuoShuo"].ToString();
                }
                if (row["userCompany"] != null)
                {
                    model.userCompany = row["userCompany"].ToString();
                }
                if (row["userJobPosition"] != null)
                {
                    model.userJobPosition = row["userJobPosition"].ToString();
                }
                if (row["userAcademy"] != null)
                {
                    model.userAcademy = row["userAcademy"].ToString();
                }
                if (row["userMajor"] != null)
                {
                    model.userMajor = row["userMajor"].ToString();
                }
                if (row["userProBio"] != null)
                {
                    model.userProBio = row["userProBio"].ToString();
                }
                if (row["cuserEmail"] != null)
                {
                    model.cuserEmail = row["cuserEmail"].ToString();
                }
                if (row["cuserNickName"] != null)
                {
                    model.cuserNickName = row["cuserNickName"].ToString();
                }
                if (row["cuserHeadImage"] != null)
                {
                    model.cuserHeadImage = row["cuserHeadImage"].ToString();
                }
                if (row["cuserState"] != null)
                {
                    model.cuserState = row["cuserState"].ToString();
                }
                if (row["cuserGender"] != null)
                {
                    model.cuserGender = row["cuserGender"].ToString();
                }
                if (row["cuserBirthday"] != null && row["cuserBirthday"].ToString() != "")
                {
                    model.cuserBirthday = DateTime.Parse(row["cuserBirthday"].ToString());
                }
                if (row["cuserAdress"] != null)
                {
                    model.cuserAdress = row["cuserAdress"].ToString();
                }
                if (row["cuserJob"] != null)
                {
                    model.cuserJob = row["cuserJob"].ToString();
                }
                if (row["cuserShuoShuo"] != null)
                {
                    model.cuserShuoShuo = row["cuserShuoShuo"].ToString();
                }
                if (row["cuserCompany"] != null)
                {
                    model.cuserCompany = row["cuserCompany"].ToString();
                }
                if (row["cuserJobPosition"] != null)
                {
                    model.cuserJobPosition = row["cuserJobPosition"].ToString();
                }
                if (row["cuserAcademy"] != null)
                {
                    model.cuserAcademy = row["cuserAcademy"].ToString();
                }
                if (row["cuserMajor"] != null)
                {
                    model.cuserMajor = row["cuserMajor"].ToString();
                }
                if (row["cuserProBio"] != null)
                {
                    model.cuserProBio = row["cuserProBio"].ToString();
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
            strSql.Append("select carePersonID,personCaredByUID,userEmail,userNickName,userHeadImage,userState,userGender,userBirthday,userAdress,userJob,userShuoShuo,userCompany,userJobPosition,userAcademy,userMajor,userProBio,cuserEmail,cuserNickName,cuserHeadImage,cuserState,cuserGender,cuserBirthday,cuserAdress,cuserJob,cuserShuoShuo,cuserCompany,cuserJobPosition,cuserAcademy,cuserMajor,cuserProBio ");
            strSql.Append(" FROM CarePersonUserInfoView ");
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
            strSql.Append(" carePersonID,personCaredByUID,userEmail,userNickName,userHeadImage,userState,userGender,userBirthday,userAdress,userJob,userShuoShuo,userCompany,userJobPosition,userAcademy,userMajor,userProBio,cuserEmail,cuserNickName,cuserHeadImage,cuserState,cuserGender,cuserBirthday,cuserAdress,cuserJob,cuserShuoShuo,cuserCompany,cuserJobPosition,cuserAcademy,cuserMajor,cuserProBio ");
            strSql.Append(" FROM CarePersonUserInfoView ");
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
            strSql.Append("select count(1) FROM CarePersonUserInfoView ");
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
            strSql.Append(")AS Row, T.*  from CarePersonUserInfoView T ");
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
            parameters[0].Value = "CarePersonUserInfoView";
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
