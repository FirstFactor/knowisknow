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
    /// 数据访问类:ReplyQuestionUserView
    /// </summary>
    public partial class ReplyQuestionUserView
    {
        public ReplyQuestionUserView()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ReplyID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ReplyQuestionUserView");
            strSql.Append(" where ReplyID=@ReplyID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ReplyID", SqlDbType.Int,4)			};
            parameters[0].Value = ReplyID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.ReplyQuestionUserView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ReplyQuestionUserView(");
            strSql.Append("ReplyID,replyQuestionID,replyofUID,replyContent,replyDateTime,replyApproveCount,replyofReplyID,replySate,userEmail,userNickName,userHeadImage,userState,userVerifyCode,userGender,userPwd,userBirthday,userAdress,userJob,userShuoShuo,userCompany,userJobPosition,userAcademy,userMajor,userProBio,questionTitle)");
            strSql.Append(" values (");
            strSql.Append("@ReplyID,@replyQuestionID,@replyofUID,@replyContent,@replyDateTime,@replyApproveCount,@replyofReplyID,@replySate,@userEmail,@userNickName,@userHeadImage,@userState,@userVerifyCode,@userGender,@userPwd,@userBirthday,@userAdress,@userJob,@userShuoShuo,@userCompany,@userJobPosition,@userAcademy,@userMajor,@userProBio,@questionTitle)");
            SqlParameter[] parameters = {
					new SqlParameter("@ReplyID", SqlDbType.Int,4),
					new SqlParameter("@replyQuestionID", SqlDbType.Int,4),
					new SqlParameter("@replyofUID", SqlDbType.Int,4),
					new SqlParameter("@replyContent", SqlDbType.VarChar,-1),
					new SqlParameter("@replyDateTime", SqlDbType.DateTime),
					new SqlParameter("@replyApproveCount", SqlDbType.Int,4),
					new SqlParameter("@replyofReplyID", SqlDbType.Int,4),
					new SqlParameter("@replySate", SqlDbType.VarChar,50),
					new SqlParameter("@userEmail", SqlDbType.VarChar,100),
					new SqlParameter("@userNickName", SqlDbType.VarChar,20),
					new SqlParameter("@userHeadImage", SqlDbType.VarChar,100),
					new SqlParameter("@userState", SqlDbType.VarChar,20),
					new SqlParameter("@userVerifyCode", SqlDbType.VarChar,16),
					new SqlParameter("@userGender", SqlDbType.NVarChar,1),
					new SqlParameter("@userPwd", SqlDbType.VarChar,50),
					new SqlParameter("@userBirthday", SqlDbType.Date,3),
					new SqlParameter("@userAdress", SqlDbType.VarChar,100),
					new SqlParameter("@userJob", SqlDbType.VarChar,50),
					new SqlParameter("@userShuoShuo", SqlDbType.VarChar,50),
					new SqlParameter("@userCompany", SqlDbType.VarChar,50),
					new SqlParameter("@userJobPosition", SqlDbType.VarChar,50),
					new SqlParameter("@userAcademy", SqlDbType.VarChar,50),
					new SqlParameter("@userMajor", SqlDbType.VarChar,50),
					new SqlParameter("@userProBio", SqlDbType.VarChar,-1),
					new SqlParameter("@questionTitle", SqlDbType.VarChar,50)};
            parameters[0].Value = model.ReplyID;
            parameters[1].Value = model.replyQuestionID;
            parameters[2].Value = model.replyofUID;
            parameters[3].Value = model.replyContent;
            parameters[4].Value = model.replyDateTime;
            parameters[5].Value = model.replyApproveCount;
            parameters[6].Value = model.replyofReplyID;
            parameters[7].Value = model.replySate;
            parameters[8].Value = model.userEmail;
            parameters[9].Value = model.userNickName;
            parameters[10].Value = model.userHeadImage;
            parameters[11].Value = model.userState;
            parameters[12].Value = model.userVerifyCode;
            parameters[13].Value = model.userGender;
            parameters[14].Value = model.userPwd;
            parameters[15].Value = model.userBirthday;
            parameters[16].Value = model.userAdress;
            parameters[17].Value = model.userJob;
            parameters[18].Value = model.userShuoShuo;
            parameters[19].Value = model.userCompany;
            parameters[20].Value = model.userJobPosition;
            parameters[21].Value = model.userAcademy;
            parameters[22].Value = model.userMajor;
            parameters[23].Value = model.userProBio;
            parameters[24].Value = model.questionTitle;

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
        public bool Update(Model.ReplyQuestionUserView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ReplyQuestionUserView set ");
            strSql.Append("ReplyID=@ReplyID,");
            strSql.Append("replyQuestionID=@replyQuestionID,");
            strSql.Append("replyofUID=@replyofUID,");
            strSql.Append("replyContent=@replyContent,");
            strSql.Append("replyDateTime=@replyDateTime,");
            strSql.Append("replyApproveCount=@replyApproveCount,");
            strSql.Append("replyofReplyID=@replyofReplyID,");
            strSql.Append("replySate=@replySate,");
            strSql.Append("userEmail=@userEmail,");
            strSql.Append("userNickName=@userNickName,");
            strSql.Append("userHeadImage=@userHeadImage,");
            strSql.Append("userState=@userState,");
            strSql.Append("userVerifyCode=@userVerifyCode,");
            strSql.Append("userGender=@userGender,");
            strSql.Append("userPwd=@userPwd,");
            strSql.Append("userBirthday=@userBirthday,");
            strSql.Append("userAdress=@userAdress,");
            strSql.Append("userJob=@userJob,");
            strSql.Append("userShuoShuo=@userShuoShuo,");
            strSql.Append("userCompany=@userCompany,");
            strSql.Append("userJobPosition=@userJobPosition,");
            strSql.Append("userAcademy=@userAcademy,");
            strSql.Append("userMajor=@userMajor,");
            strSql.Append("userProBio=@userProBio,");
            strSql.Append("questionTitle=@questionTitle");
            strSql.Append(" where ReplyID=@ReplyID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ReplyID", SqlDbType.Int,4),
					new SqlParameter("@replyQuestionID", SqlDbType.Int,4),
					new SqlParameter("@replyofUID", SqlDbType.Int,4),
					new SqlParameter("@replyContent", SqlDbType.VarChar,-1),
					new SqlParameter("@replyDateTime", SqlDbType.DateTime),
					new SqlParameter("@replyApproveCount", SqlDbType.Int,4),
					new SqlParameter("@replyofReplyID", SqlDbType.Int,4),
					new SqlParameter("@replySate", SqlDbType.VarChar,50),
					new SqlParameter("@userEmail", SqlDbType.VarChar,100),
					new SqlParameter("@userNickName", SqlDbType.VarChar,20),
					new SqlParameter("@userHeadImage", SqlDbType.VarChar,100),
					new SqlParameter("@userState", SqlDbType.VarChar,20),
					new SqlParameter("@userVerifyCode", SqlDbType.VarChar,16),
					new SqlParameter("@userGender", SqlDbType.NVarChar,1),
					new SqlParameter("@userPwd", SqlDbType.VarChar,50),
					new SqlParameter("@userBirthday", SqlDbType.Date,3),
					new SqlParameter("@userAdress", SqlDbType.VarChar,100),
					new SqlParameter("@userJob", SqlDbType.VarChar,50),
					new SqlParameter("@userShuoShuo", SqlDbType.VarChar,50),
					new SqlParameter("@userCompany", SqlDbType.VarChar,50),
					new SqlParameter("@userJobPosition", SqlDbType.VarChar,50),
					new SqlParameter("@userAcademy", SqlDbType.VarChar,50),
					new SqlParameter("@userMajor", SqlDbType.VarChar,50),
					new SqlParameter("@userProBio", SqlDbType.VarChar,-1),
					new SqlParameter("@questionTitle", SqlDbType.VarChar,50)};
            parameters[0].Value = model.ReplyID;
            parameters[1].Value = model.replyQuestionID;
            parameters[2].Value = model.replyofUID;
            parameters[3].Value = model.replyContent;
            parameters[4].Value = model.replyDateTime;
            parameters[5].Value = model.replyApproveCount;
            parameters[6].Value = model.replyofReplyID;
            parameters[7].Value = model.replySate;
            parameters[8].Value = model.userEmail;
            parameters[9].Value = model.userNickName;
            parameters[10].Value = model.userHeadImage;
            parameters[11].Value = model.userState;
            parameters[12].Value = model.userVerifyCode;
            parameters[13].Value = model.userGender;
            parameters[14].Value = model.userPwd;
            parameters[15].Value = model.userBirthday;
            parameters[16].Value = model.userAdress;
            parameters[17].Value = model.userJob;
            parameters[18].Value = model.userShuoShuo;
            parameters[19].Value = model.userCompany;
            parameters[20].Value = model.userJobPosition;
            parameters[21].Value = model.userAcademy;
            parameters[22].Value = model.userMajor;
            parameters[23].Value = model.userProBio;
            parameters[24].Value = model.questionTitle;

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
            strSql.Append("delete from ReplyQuestionUserView ");
            strSql.Append(" where ReplyID=@ReplyID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ReplyID", SqlDbType.Int,4)			};
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
            strSql.Append("delete from ReplyQuestionUserView ");
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
        public Model.ReplyQuestionUserView GetModel(int ReplyID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ReplyID,replyQuestionID,replyofUID,replyContent,replyDateTime,replyApproveCount,replyofReplyID,replySate,userEmail,userNickName,userHeadImage,userState,userVerifyCode,userGender,userPwd,userBirthday,userAdress,userJob,userShuoShuo,userCompany,userJobPosition,userAcademy,userMajor,userProBio,questionTitle from ReplyQuestionUserView ");
            strSql.Append(" where ReplyID=@ReplyID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ReplyID", SqlDbType.Int,4)			};
            parameters[0].Value = ReplyID;

            Model.ReplyQuestionUserView model = new Model.ReplyQuestionUserView();
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
        public Model.ReplyQuestionUserView DataRowToModel(DataRow row)
        {
            Model.ReplyQuestionUserView model = new Model.ReplyQuestionUserView();
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
                if (row["userVerifyCode"] != null)
                {
                    model.userVerifyCode = row["userVerifyCode"].ToString();
                }
                if (row["userGender"] != null)
                {
                    model.userGender = row["userGender"].ToString();
                }
                if (row["userPwd"] != null)
                {
                    model.userPwd = row["userPwd"].ToString();
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
                if (row["questionTitle"] != null)
                {
                    model.questionTitle = row["questionTitle"].ToString();
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
            strSql.Append("select ReplyID,replyQuestionID,replyofUID,replyContent,replyDateTime,replyApproveCount,replyofReplyID,replySate,userEmail,userNickName,userHeadImage,userState,userVerifyCode,userGender,userPwd,userBirthday,userAdress,userJob,userShuoShuo,userCompany,userJobPosition,userAcademy,userMajor,userProBio,questionTitle ");
            strSql.Append(" FROM ReplyQuestionUserView ");
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
            strSql.Append(" ReplyID,replyQuestionID,replyofUID,replyContent,replyDateTime,replyApproveCount,replyofReplyID,replySate,userEmail,userNickName,userHeadImage,userState,userVerifyCode,userGender,userPwd,userBirthday,userAdress,userJob,userShuoShuo,userCompany,userJobPosition,userAcademy,userMajor,userProBio,questionTitle ");
            strSql.Append(" FROM ReplyQuestionUserView ");
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
            strSql.Append("select count(1) FROM ReplyQuestionUserView ");
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
            strSql.Append(")AS Row, T.*  from ReplyQuestionUserView T ");
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
            parameters[0].Value = "ReplyQuestionUserView";
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
