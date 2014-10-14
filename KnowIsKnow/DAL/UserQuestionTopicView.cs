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
    /// 数据访问类:UserQuestionTopicView
    /// </summary>
    public partial class UserQuestionTopicView
    {
        public UserQuestionTopicView()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int questionID, int topicID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from UserQuestionTopicView");
            strSql.Append(" where questionID=@questionID and topicID=@topicID ");
            SqlParameter[] parameters = {
					new SqlParameter("@questionID", SqlDbType.Int,4),
					new SqlParameter("@topicID", SqlDbType.Int,4)			};
            parameters[0].Value = questionID;
            parameters[1].Value = topicID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.UserQuestionTopicView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into UserQuestionTopicView(");
            strSql.Append("questionID,questionTitle,questionContent,quetionPubTime,questonApproveCount,questionReportCount,questionSate,userID,userEmail,userNickName,userHeadImage,userState,userGender,userBirthday,userAdress,userJob,userShuoShuo,userCompany,userJobPosition,userAcademy,userMajor,userProBio,topicID,topicTitle,topicDes,topicPicUrl,topicAttention,topicState)");
            strSql.Append(" values (");
            strSql.Append("@questionID,@questionTitle,@questionContent,@quetionPubTime,@questonApproveCount,@questionReportCount,@questionSate,@userID,@userEmail,@userNickName,@userHeadImage,@userState,@userGender,@userBirthday,@userAdress,@userJob,@userShuoShuo,@userCompany,@userJobPosition,@userAcademy,@userMajor,@userProBio,@topicID,@topicTitle,@topicDes,@topicPicUrl,@topicAttention,@topicState)");
            SqlParameter[] parameters = {
					new SqlParameter("@questionID", SqlDbType.Int,4),
					new SqlParameter("@questionTitle", SqlDbType.VarChar,50),
					new SqlParameter("@questionContent", SqlDbType.VarChar,-1),
					new SqlParameter("@quetionPubTime", SqlDbType.DateTime),
					new SqlParameter("@questonApproveCount", SqlDbType.Int,4),
					new SqlParameter("@questionReportCount", SqlDbType.Int,4),
					new SqlParameter("@questionSate", SqlDbType.VarChar,50),
					new SqlParameter("@userID", SqlDbType.Int,4),
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
					new SqlParameter("@topicID", SqlDbType.Int,4),
					new SqlParameter("@topicTitle", SqlDbType.NVarChar,50),
					new SqlParameter("@topicDes", SqlDbType.NVarChar,400),
					new SqlParameter("@topicPicUrl", SqlDbType.VarChar,100),
					new SqlParameter("@topicAttention", SqlDbType.Int,4),
					new SqlParameter("@topicState", SqlDbType.VarChar,50)};
            parameters[0].Value = model.questionID;
            parameters[1].Value = model.questionTitle;
            parameters[2].Value = model.questionContent;
            parameters[3].Value = model.quetionPubTime;
            parameters[4].Value = model.questonApproveCount;
            parameters[5].Value = model.questionReportCount;
            parameters[6].Value = model.questionSate;
            parameters[7].Value = model.userID;
            parameters[8].Value = model.userEmail;
            parameters[9].Value = model.userNickName;
            parameters[10].Value = model.userHeadImage;
            parameters[11].Value = model.userState;
            parameters[12].Value = model.userGender;
            parameters[13].Value = model.userBirthday;
            parameters[14].Value = model.userAdress;
            parameters[15].Value = model.userJob;
            parameters[16].Value = model.userShuoShuo;
            parameters[17].Value = model.userCompany;
            parameters[18].Value = model.userJobPosition;
            parameters[19].Value = model.userAcademy;
            parameters[20].Value = model.userMajor;
            parameters[21].Value = model.userProBio;
            parameters[22].Value = model.topicID;
            parameters[23].Value = model.topicTitle;
            parameters[24].Value = model.topicDes;
            parameters[25].Value = model.topicPicUrl;
            parameters[26].Value = model.topicAttention;
            parameters[27].Value = model.topicState;

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
        public bool Update(Model.UserQuestionTopicView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update UserQuestionTopicView set ");
            strSql.Append("questionID=@questionID,");
            strSql.Append("questionTitle=@questionTitle,");
            strSql.Append("questionContent=@questionContent,");
            strSql.Append("quetionPubTime=@quetionPubTime,");
            strSql.Append("questonApproveCount=@questonApproveCount,");
            strSql.Append("questionReportCount=@questionReportCount,");
            strSql.Append("questionSate=@questionSate,");
            strSql.Append("userID=@userID,");
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
            strSql.Append("topicID=@topicID,");
            strSql.Append("topicTitle=@topicTitle,");
            strSql.Append("topicDes=@topicDes,");
            strSql.Append("topicPicUrl=@topicPicUrl,");
            strSql.Append("topicAttention=@topicAttention,");
            strSql.Append("topicState=@topicState");
            strSql.Append(" where questionID=@questionID and topicID=@topicID ");
            SqlParameter[] parameters = {
					new SqlParameter("@questionID", SqlDbType.Int,4),
					new SqlParameter("@questionTitle", SqlDbType.VarChar,50),
					new SqlParameter("@questionContent", SqlDbType.VarChar,-1),
					new SqlParameter("@quetionPubTime", SqlDbType.DateTime),
					new SqlParameter("@questonApproveCount", SqlDbType.Int,4),
					new SqlParameter("@questionReportCount", SqlDbType.Int,4),
					new SqlParameter("@questionSate", SqlDbType.VarChar,50),
					new SqlParameter("@userID", SqlDbType.Int,4),
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
					new SqlParameter("@topicID", SqlDbType.Int,4),
					new SqlParameter("@topicTitle", SqlDbType.NVarChar,50),
					new SqlParameter("@topicDes", SqlDbType.NVarChar,400),
					new SqlParameter("@topicPicUrl", SqlDbType.VarChar,100),
					new SqlParameter("@topicAttention", SqlDbType.Int,4),
					new SqlParameter("@topicState", SqlDbType.VarChar,50)};
            parameters[0].Value = model.questionID;
            parameters[1].Value = model.questionTitle;
            parameters[2].Value = model.questionContent;
            parameters[3].Value = model.quetionPubTime;
            parameters[4].Value = model.questonApproveCount;
            parameters[5].Value = model.questionReportCount;
            parameters[6].Value = model.questionSate;
            parameters[7].Value = model.userID;
            parameters[8].Value = model.userEmail;
            parameters[9].Value = model.userNickName;
            parameters[10].Value = model.userHeadImage;
            parameters[11].Value = model.userState;
            parameters[12].Value = model.userGender;
            parameters[13].Value = model.userBirthday;
            parameters[14].Value = model.userAdress;
            parameters[15].Value = model.userJob;
            parameters[16].Value = model.userShuoShuo;
            parameters[17].Value = model.userCompany;
            parameters[18].Value = model.userJobPosition;
            parameters[19].Value = model.userAcademy;
            parameters[20].Value = model.userMajor;
            parameters[21].Value = model.userProBio;
            parameters[22].Value = model.topicID;
            parameters[23].Value = model.topicTitle;
            parameters[24].Value = model.topicDes;
            parameters[25].Value = model.topicPicUrl;
            parameters[26].Value = model.topicAttention;
            parameters[27].Value = model.topicState;

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
        public bool Delete(int questionID, int topicID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from UserQuestionTopicView ");
            strSql.Append(" where questionID=@questionID and topicID=@topicID ");
            SqlParameter[] parameters = {
					new SqlParameter("@questionID", SqlDbType.Int,4),
					new SqlParameter("@topicID", SqlDbType.Int,4)			};
            parameters[0].Value = questionID;
            parameters[1].Value = topicID;

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
        public Model.UserQuestionTopicView GetModel(int questionID, int topicID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 questionID,questionTitle,questionContent,quetionPubTime,questonApproveCount,questionReportCount,questionSate,userID,userEmail,userNickName,userHeadImage,userState,userGender,userBirthday,userAdress,userJob,userShuoShuo,userCompany,userJobPosition,userAcademy,userMajor,userProBio,topicID,topicTitle,topicDes,topicPicUrl,topicAttention,topicState from UserQuestionTopicView ");
            strSql.Append(" where questionID=@questionID and topicID=@topicID ");
            SqlParameter[] parameters = {
					new SqlParameter("@questionID", SqlDbType.Int,4),
					new SqlParameter("@topicID", SqlDbType.Int,4)			};
            parameters[0].Value = questionID;
            parameters[1].Value = topicID;

            Model.UserQuestionTopicView model = new Model.UserQuestionTopicView();
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
        public Model.UserQuestionTopicView DataRowToModel(DataRow row)
        {
            Model.UserQuestionTopicView model = new Model.UserQuestionTopicView();
            if (row != null)
            {
                if (row["questionID"] != null && row["questionID"].ToString() != "")
                {
                    model.questionID = int.Parse(row["questionID"].ToString());
                }
                if (row["questionTitle"] != null)
                {
                    model.questionTitle = row["questionTitle"].ToString();
                }
                if (row["questionContent"] != null)
                {
                    model.questionContent = row["questionContent"].ToString();
                }
                if (row["quetionPubTime"] != null && row["quetionPubTime"].ToString() != "")
                {
                    model.quetionPubTime = DateTime.Parse(row["quetionPubTime"].ToString());
                }
                if (row["questonApproveCount"] != null && row["questonApproveCount"].ToString() != "")
                {
                    model.questonApproveCount = int.Parse(row["questonApproveCount"].ToString());
                }
                if (row["questionReportCount"] != null && row["questionReportCount"].ToString() != "")
                {
                    model.questionReportCount = int.Parse(row["questionReportCount"].ToString());
                }
                if (row["questionSate"] != null)
                {
                    model.questionSate = row["questionSate"].ToString();
                }
                if (row["userID"] != null && row["userID"].ToString() != "")
                {
                    model.userID = int.Parse(row["userID"].ToString());
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
            strSql.Append("select questionID,questionTitle,questionContent,quetionPubTime,questonApproveCount,questionReportCount,questionSate,userID,userEmail,userNickName,userHeadImage,userState,userGender,userBirthday,userAdress,userJob,userShuoShuo,userCompany,userJobPosition,userAcademy,userMajor,userProBio,topicID,topicTitle,topicDes,topicPicUrl,topicAttention,topicState ");
            strSql.Append(" FROM UserQuestionTopicView ");
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
            strSql.Append(" questionID,questionTitle,questionContent,quetionPubTime,questonApproveCount,questionReportCount,questionSate,userID,userEmail,userNickName,userHeadImage,userState,userGender,userBirthday,userAdress,userJob,userShuoShuo,userCompany,userJobPosition,userAcademy,userMajor,userProBio,topicID,topicTitle,topicDes,topicPicUrl,topicAttention,topicState ");
            strSql.Append(" FROM UserQuestionTopicView ");
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
            strSql.Append("select count(1) FROM UserQuestionTopicView ");
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
            strSql.Append(")AS Row, T.*  from UserQuestionTopicView T ");
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
            parameters[0].Value = "UserQuestionTopicView";
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
