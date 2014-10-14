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
    /// 数据访问类:ReportReplyUserView
    /// </summary>
    public partial class ReportReplyUserView
    {
        public ReportReplyUserView()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int reportReplyByUID, int reportReplyID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ReportReplyUserView");
            strSql.Append(" where reportReplyByUID=@reportReplyByUID and reportReplyID=@reportReplyID ");
            SqlParameter[] parameters = {
					new SqlParameter("@reportReplyByUID", SqlDbType.Int,4),
					new SqlParameter("@reportReplyID", SqlDbType.Int,4)			};
            parameters[0].Value = reportReplyByUID;
            parameters[1].Value = reportReplyID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.ReportReplyUserView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ReportReplyUserView(");
            strSql.Append("reportReplyByUID,reportReplyID,reportReID,reportReplyReason,reportReplyDataTime,reportReplyDealState,reportReplyResonTypeID,userEmail,userNickName,userHeadImage,userState,userGender,userBirthday,userAdress,userJob,userShuoShuo,userCompany,userJobPosition,userAcademy,userMajor,userProBio,reportReasonContent)");
            strSql.Append(" values (");
            strSql.Append("@reportReplyByUID,@reportReplyID,@reportReID,@reportReplyReason,@reportReplyDataTime,@reportReplyDealState,@reportReplyResonTypeID,@userEmail,@userNickName,@userHeadImage,@userState,@userGender,@userBirthday,@userAdress,@userJob,@userShuoShuo,@userCompany,@userJobPosition,@userAcademy,@userMajor,@userProBio,@reportReasonContent)");
            SqlParameter[] parameters = {
					new SqlParameter("@reportReplyByUID", SqlDbType.Int,4),
					new SqlParameter("@reportReplyID", SqlDbType.Int,4),
					new SqlParameter("@reportReID", SqlDbType.Int,4),
					new SqlParameter("@reportReplyReason", SqlDbType.VarChar,100),
					new SqlParameter("@reportReplyDataTime", SqlDbType.DateTime),
					new SqlParameter("@reportReplyDealState", SqlDbType.VarChar,50),
					new SqlParameter("@reportReplyResonTypeID", SqlDbType.Int,4),
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
					new SqlParameter("@reportReasonContent", SqlDbType.VarChar,400)};
            parameters[0].Value = model.reportReplyByUID;
            parameters[1].Value = model.reportReplyID;
            parameters[2].Value = model.reportReID;
            parameters[3].Value = model.reportReplyReason;
            parameters[4].Value = model.reportReplyDataTime;
            parameters[5].Value = model.reportReplyDealState;
            parameters[6].Value = model.reportReplyResonTypeID;
            parameters[7].Value = model.userEmail;
            parameters[8].Value = model.userNickName;
            parameters[9].Value = model.userHeadImage;
            parameters[10].Value = model.userState;
            parameters[11].Value = model.userGender;
            parameters[12].Value = model.userBirthday;
            parameters[13].Value = model.userAdress;
            parameters[14].Value = model.userJob;
            parameters[15].Value = model.userShuoShuo;
            parameters[16].Value = model.userCompany;
            parameters[17].Value = model.userJobPosition;
            parameters[18].Value = model.userAcademy;
            parameters[19].Value = model.userMajor;
            parameters[20].Value = model.userProBio;
            parameters[21].Value = model.reportReasonContent;

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
        public bool Update(Model.ReportReplyUserView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ReportReplyUserView set ");
            strSql.Append("reportReplyByUID=@reportReplyByUID,");
            strSql.Append("reportReplyID=@reportReplyID,");
            strSql.Append("reportReID=@reportReID,");
            strSql.Append("reportReplyReason=@reportReplyReason,");
            strSql.Append("reportReplyDataTime=@reportReplyDataTime,");
            strSql.Append("reportReplyDealState=@reportReplyDealState,");
            strSql.Append("reportReplyResonTypeID=@reportReplyResonTypeID,");
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
            strSql.Append("reportReasonContent=@reportReasonContent");
            strSql.Append(" where reportReplyByUID=@reportReplyByUID and reportReplyID=@reportReplyID ");
            SqlParameter[] parameters = {
					new SqlParameter("@reportReplyByUID", SqlDbType.Int,4),
					new SqlParameter("@reportReplyID", SqlDbType.Int,4),
					new SqlParameter("@reportReID", SqlDbType.Int,4),
					new SqlParameter("@reportReplyReason", SqlDbType.VarChar,100),
					new SqlParameter("@reportReplyDataTime", SqlDbType.DateTime),
					new SqlParameter("@reportReplyDealState", SqlDbType.VarChar,50),
					new SqlParameter("@reportReplyResonTypeID", SqlDbType.Int,4),
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
					new SqlParameter("@reportReasonContent", SqlDbType.VarChar,400)};
            parameters[0].Value = model.reportReplyByUID;
            parameters[1].Value = model.reportReplyID;
            parameters[2].Value = model.reportReID;
            parameters[3].Value = model.reportReplyReason;
            parameters[4].Value = model.reportReplyDataTime;
            parameters[5].Value = model.reportReplyDealState;
            parameters[6].Value = model.reportReplyResonTypeID;
            parameters[7].Value = model.userEmail;
            parameters[8].Value = model.userNickName;
            parameters[9].Value = model.userHeadImage;
            parameters[10].Value = model.userState;
            parameters[11].Value = model.userGender;
            parameters[12].Value = model.userBirthday;
            parameters[13].Value = model.userAdress;
            parameters[14].Value = model.userJob;
            parameters[15].Value = model.userShuoShuo;
            parameters[16].Value = model.userCompany;
            parameters[17].Value = model.userJobPosition;
            parameters[18].Value = model.userAcademy;
            parameters[19].Value = model.userMajor;
            parameters[20].Value = model.userProBio;
            parameters[21].Value = model.reportReasonContent;

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
        public bool Delete(int reportReplyByUID, int reportReplyID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ReportReplyUserView ");
            strSql.Append(" where reportReplyByUID=@reportReplyByUID and reportReplyID=@reportReplyID ");
            SqlParameter[] parameters = {
					new SqlParameter("@reportReplyByUID", SqlDbType.Int,4),
					new SqlParameter("@reportReplyID", SqlDbType.Int,4)			};
            parameters[0].Value = reportReplyByUID;
            parameters[1].Value = reportReplyID;

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
        public Model.ReportReplyUserView GetModel(int reportReplyByUID, int reportReplyID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 reportReplyByUID,reportReplyID,reportReID,reportReplyReason,reportReplyDataTime,reportReplyDealState,reportReplyResonTypeID,userEmail,userNickName,userHeadImage,userState,userGender,userBirthday,userAdress,userJob,userShuoShuo,userCompany,userJobPosition,userAcademy,userMajor,userProBio,reportReasonContent from ReportReplyUserView ");
            strSql.Append(" where reportReplyByUID=@reportReplyByUID and reportReplyID=@reportReplyID ");
            SqlParameter[] parameters = {
					new SqlParameter("@reportReplyByUID", SqlDbType.Int,4),
					new SqlParameter("@reportReplyID", SqlDbType.Int,4)			};
            parameters[0].Value = reportReplyByUID;
            parameters[1].Value = reportReplyID;

            Model.ReportReplyUserView model = new Model.ReportReplyUserView();
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
        public Model.ReportReplyUserView DataRowToModel(DataRow row)
        {
            Model.ReportReplyUserView model = new Model.ReportReplyUserView();
            if (row != null)
            {
                if (row["reportReplyByUID"] != null && row["reportReplyByUID"].ToString() != "")
                {
                    model.reportReplyByUID = int.Parse(row["reportReplyByUID"].ToString());
                }
                if (row["reportReplyID"] != null && row["reportReplyID"].ToString() != "")
                {
                    model.reportReplyID = int.Parse(row["reportReplyID"].ToString());
                }
                if (row["reportReID"] != null && row["reportReID"].ToString() != "")
                {
                    model.reportReID = int.Parse(row["reportReID"].ToString());
                }
                if (row["reportReplyReason"] != null)
                {
                    model.reportReplyReason = row["reportReplyReason"].ToString();
                }
                if (row["reportReplyDataTime"] != null && row["reportReplyDataTime"].ToString() != "")
                {
                    model.reportReplyDataTime = DateTime.Parse(row["reportReplyDataTime"].ToString());
                }
                if (row["reportReplyDealState"] != null)
                {
                    model.reportReplyDealState = row["reportReplyDealState"].ToString();
                }
                if (row["reportReplyResonTypeID"] != null && row["reportReplyResonTypeID"].ToString() != "")
                {
                    model.reportReplyResonTypeID = int.Parse(row["reportReplyResonTypeID"].ToString());
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
                if (row["reportReasonContent"] != null)
                {
                    model.reportReasonContent = row["reportReasonContent"].ToString();
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
            strSql.Append("select reportReplyByUID,reportReplyID,reportReID,reportReplyReason,reportReplyDataTime,reportReplyDealState,reportReplyResonTypeID,userEmail,userNickName,userHeadImage,userState,userGender,userBirthday,userAdress,userJob,userShuoShuo,userCompany,userJobPosition,userAcademy,userMajor,userProBio,reportReasonContent ");
            strSql.Append(" FROM ReportReplyUserView ");
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
            strSql.Append(" reportReplyByUID,reportReplyID,reportReID,reportReplyReason,reportReplyDataTime,reportReplyDealState,reportReplyResonTypeID,userEmail,userNickName,userHeadImage,userState,userGender,userBirthday,userAdress,userJob,userShuoShuo,userCompany,userJobPosition,userAcademy,userMajor,userProBio,reportReasonContent ");
            strSql.Append(" FROM ReportReplyUserView ");
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
            strSql.Append("select count(1) FROM ReportReplyUserView ");
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
                strSql.Append("order by T.reportReplyID desc");
            }
            strSql.Append(")AS Row, T.*  from ReportReplyUserView T ");
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
            parameters[0].Value = "ReportReplyUserView";
            parameters[1].Value = "reportReplyID";
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
