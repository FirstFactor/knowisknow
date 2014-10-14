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
    /// 数据访问类:QuestionInfoCareQuestionView
    /// </summary>
    public partial class QuestionInfoCareQuestionView
    {
        public QuestionInfoCareQuestionView()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int careQuestionID, int questionCaredByUID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from QuestionInfoCareQuestionView");
            strSql.Append(" where careQuestionID=@careQuestionID and questionCaredByUID=@questionCaredByUID ");
            SqlParameter[] parameters = {
					new SqlParameter("@careQuestionID", SqlDbType.Int,4),
					new SqlParameter("@questionCaredByUID", SqlDbType.Int,4)			};
            parameters[0].Value = careQuestionID;
            parameters[1].Value = questionCaredByUID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.QuestionInfoCareQuestionView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into QuestionInfoCareQuestionView(");
            strSql.Append("userMajor,careQuestionID,questionCaredByUID,questionTitle,questionContent,questionProvider,quetionPubTime,questonApproveCount,questionReportCount,questionSate,userNickName,userHeadImage,userGender,userJob,userShuoShuo,userBirthday,userAdress,userCompany,userJobPosition,userAcademy)");
            strSql.Append(" values (");
            strSql.Append("@userMajor,@careQuestionID,@questionCaredByUID,@questionTitle,@questionContent,@questionProvider,@quetionPubTime,@questonApproveCount,@questionReportCount,@questionSate,@userNickName,@userHeadImage,@userGender,@userJob,@userShuoShuo,@userBirthday,@userAdress,@userCompany,@userJobPosition,@userAcademy)");
            SqlParameter[] parameters = {
					new SqlParameter("@userMajor", SqlDbType.VarChar,50),
					new SqlParameter("@careQuestionID", SqlDbType.Int,4),
					new SqlParameter("@questionCaredByUID", SqlDbType.Int,4),
					new SqlParameter("@questionTitle", SqlDbType.VarChar,50),
					new SqlParameter("@questionContent", SqlDbType.VarChar,-1),
					new SqlParameter("@questionProvider", SqlDbType.Int,4),
					new SqlParameter("@quetionPubTime", SqlDbType.DateTime),
					new SqlParameter("@questonApproveCount", SqlDbType.Int,4),
					new SqlParameter("@questionReportCount", SqlDbType.Int,4),
					new SqlParameter("@questionSate", SqlDbType.VarChar,50),
					new SqlParameter("@userNickName", SqlDbType.VarChar,20),
					new SqlParameter("@userHeadImage", SqlDbType.VarChar,100),
					new SqlParameter("@userGender", SqlDbType.NVarChar,1),
					new SqlParameter("@userJob", SqlDbType.VarChar,50),
					new SqlParameter("@userShuoShuo", SqlDbType.VarChar,50),
					new SqlParameter("@userBirthday", SqlDbType.Date,3),
					new SqlParameter("@userAdress", SqlDbType.VarChar,100),
					new SqlParameter("@userCompany", SqlDbType.VarChar,50),
					new SqlParameter("@userJobPosition", SqlDbType.VarChar,50),
					new SqlParameter("@userAcademy", SqlDbType.VarChar,50)};
            parameters[0].Value = model.userMajor;
            parameters[1].Value = model.careQuestionID;
            parameters[2].Value = model.questionCaredByUID;
            parameters[3].Value = model.questionTitle;
            parameters[4].Value = model.questionContent;
            parameters[5].Value = model.questionProvider;
            parameters[6].Value = model.quetionPubTime;
            parameters[7].Value = model.questonApproveCount;
            parameters[8].Value = model.questionReportCount;
            parameters[9].Value = model.questionSate;
            parameters[10].Value = model.userNickName;
            parameters[11].Value = model.userHeadImage;
            parameters[12].Value = model.userGender;
            parameters[13].Value = model.userJob;
            parameters[14].Value = model.userShuoShuo;
            parameters[15].Value = model.userBirthday;
            parameters[16].Value = model.userAdress;
            parameters[17].Value = model.userCompany;
            parameters[18].Value = model.userJobPosition;
            parameters[19].Value = model.userAcademy;

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
        public bool Update(Model.QuestionInfoCareQuestionView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update QuestionInfoCareQuestionView set ");
            strSql.Append("userMajor=@userMajor,");
            strSql.Append("careQuestionID=@careQuestionID,");
            strSql.Append("questionCaredByUID=@questionCaredByUID,");
            strSql.Append("questionTitle=@questionTitle,");
            strSql.Append("questionContent=@questionContent,");
            strSql.Append("questionProvider=@questionProvider,");
            strSql.Append("quetionPubTime=@quetionPubTime,");
            strSql.Append("questonApproveCount=@questonApproveCount,");
            strSql.Append("questionReportCount=@questionReportCount,");
            strSql.Append("questionSate=@questionSate,");
            strSql.Append("userNickName=@userNickName,");
            strSql.Append("userHeadImage=@userHeadImage,");
            strSql.Append("userGender=@userGender,");
            strSql.Append("userJob=@userJob,");
            strSql.Append("userShuoShuo=@userShuoShuo,");
            strSql.Append("userBirthday=@userBirthday,");
            strSql.Append("userAdress=@userAdress,");
            strSql.Append("userCompany=@userCompany,");
            strSql.Append("userJobPosition=@userJobPosition,");
            strSql.Append("userAcademy=@userAcademy");
            strSql.Append(" where careQuestionID=@careQuestionID and questionCaredByUID=@questionCaredByUID ");
            SqlParameter[] parameters = {
					new SqlParameter("@userMajor", SqlDbType.VarChar,50),
					new SqlParameter("@careQuestionID", SqlDbType.Int,4),
					new SqlParameter("@questionCaredByUID", SqlDbType.Int,4),
					new SqlParameter("@questionTitle", SqlDbType.VarChar,50),
					new SqlParameter("@questionContent", SqlDbType.VarChar,-1),
					new SqlParameter("@questionProvider", SqlDbType.Int,4),
					new SqlParameter("@quetionPubTime", SqlDbType.DateTime),
					new SqlParameter("@questonApproveCount", SqlDbType.Int,4),
					new SqlParameter("@questionReportCount", SqlDbType.Int,4),
					new SqlParameter("@questionSate", SqlDbType.VarChar,50),
					new SqlParameter("@userNickName", SqlDbType.VarChar,20),
					new SqlParameter("@userHeadImage", SqlDbType.VarChar,100),
					new SqlParameter("@userGender", SqlDbType.NVarChar,1),
					new SqlParameter("@userJob", SqlDbType.VarChar,50),
					new SqlParameter("@userShuoShuo", SqlDbType.VarChar,50),
					new SqlParameter("@userBirthday", SqlDbType.Date,3),
					new SqlParameter("@userAdress", SqlDbType.VarChar,100),
					new SqlParameter("@userCompany", SqlDbType.VarChar,50),
					new SqlParameter("@userJobPosition", SqlDbType.VarChar,50),
					new SqlParameter("@userAcademy", SqlDbType.VarChar,50)};
            parameters[0].Value = model.userMajor;
            parameters[1].Value = model.careQuestionID;
            parameters[2].Value = model.questionCaredByUID;
            parameters[3].Value = model.questionTitle;
            parameters[4].Value = model.questionContent;
            parameters[5].Value = model.questionProvider;
            parameters[6].Value = model.quetionPubTime;
            parameters[7].Value = model.questonApproveCount;
            parameters[8].Value = model.questionReportCount;
            parameters[9].Value = model.questionSate;
            parameters[10].Value = model.userNickName;
            parameters[11].Value = model.userHeadImage;
            parameters[12].Value = model.userGender;
            parameters[13].Value = model.userJob;
            parameters[14].Value = model.userShuoShuo;
            parameters[15].Value = model.userBirthday;
            parameters[16].Value = model.userAdress;
            parameters[17].Value = model.userCompany;
            parameters[18].Value = model.userJobPosition;
            parameters[19].Value = model.userAcademy;

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
        public bool Delete(int careQuestionID, int questionCaredByUID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from QuestionInfoCareQuestionView ");
            strSql.Append(" where careQuestionID=@careQuestionID and questionCaredByUID=@questionCaredByUID ");
            SqlParameter[] parameters = {
					new SqlParameter("@careQuestionID", SqlDbType.Int,4),
					new SqlParameter("@questionCaredByUID", SqlDbType.Int,4)			};
            parameters[0].Value = careQuestionID;
            parameters[1].Value = questionCaredByUID;

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
        public Model.QuestionInfoCareQuestionView GetModel(int careQuestionID, int questionCaredByUID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 userMajor,careQuestionID,questionCaredByUID,questionTitle,questionContent,questionProvider,quetionPubTime,questonApproveCount,questionReportCount,questionSate,userNickName,userHeadImage,userGender,userJob,userShuoShuo,userBirthday,userAdress,userCompany,userJobPosition,userAcademy from QuestionInfoCareQuestionView ");
            strSql.Append(" where careQuestionID=@careQuestionID and questionCaredByUID=@questionCaredByUID ");
            SqlParameter[] parameters = {
					new SqlParameter("@careQuestionID", SqlDbType.Int,4),
					new SqlParameter("@questionCaredByUID", SqlDbType.Int,4)			};
            parameters[0].Value = careQuestionID;
            parameters[1].Value = questionCaredByUID;

            Model.QuestionInfoCareQuestionView model = new Model.QuestionInfoCareQuestionView();
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
        public Model.QuestionInfoCareQuestionView DataRowToModel(DataRow row)
        {
            Model.QuestionInfoCareQuestionView model = new Model.QuestionInfoCareQuestionView();
            if (row != null)
            {
                if (row["userMajor"] != null)
                {
                    model.userMajor = row["userMajor"].ToString();
                }
                if (row["careQuestionID"] != null && row["careQuestionID"].ToString() != "")
                {
                    model.careQuestionID = int.Parse(row["careQuestionID"].ToString());
                }
                if (row["questionCaredByUID"] != null && row["questionCaredByUID"].ToString() != "")
                {
                    model.questionCaredByUID = int.Parse(row["questionCaredByUID"].ToString());
                }
                if (row["questionTitle"] != null)
                {
                    model.questionTitle = row["questionTitle"].ToString();
                }
                if (row["questionContent"] != null)
                {
                    model.questionContent = row["questionContent"].ToString();
                }
                if (row["questionProvider"] != null && row["questionProvider"].ToString() != "")
                {
                    model.questionProvider = int.Parse(row["questionProvider"].ToString());
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
                if (row["userNickName"] != null)
                {
                    model.userNickName = row["userNickName"].ToString();
                }
                if (row["userHeadImage"] != null)
                {
                    model.userHeadImage = row["userHeadImage"].ToString();
                }
                if (row["userGender"] != null)
                {
                    model.userGender = row["userGender"].ToString();
                }
                if (row["userJob"] != null)
                {
                    model.userJob = row["userJob"].ToString();
                }
                if (row["userShuoShuo"] != null)
                {
                    model.userShuoShuo = row["userShuoShuo"].ToString();
                }
                if (row["userBirthday"] != null && row["userBirthday"].ToString() != "")
                {
                    model.userBirthday = DateTime.Parse(row["userBirthday"].ToString());
                }
                if (row["userAdress"] != null)
                {
                    model.userAdress = row["userAdress"].ToString();
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
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select userMajor,careQuestionID,questionCaredByUID,questionTitle,questionContent,questionProvider,quetionPubTime,questonApproveCount,questionReportCount,questionSate,userNickName,userHeadImage,userGender,userJob,userShuoShuo,userBirthday,userAdress,userCompany,userJobPosition,userAcademy ");
            strSql.Append(" FROM QuestionInfoCareQuestionView ");
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
            strSql.Append(" userMajor,careQuestionID,questionCaredByUID,questionTitle,questionContent,questionProvider,quetionPubTime,questonApproveCount,questionReportCount,questionSate,userNickName,userHeadImage,userGender,userJob,userShuoShuo,userBirthday,userAdress,userCompany,userJobPosition,userAcademy ");
            strSql.Append(" FROM QuestionInfoCareQuestionView ");
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
            strSql.Append("select count(1) FROM QuestionInfoCareQuestionView ");
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
                strSql.Append("order by T.questionCaredByUID desc");
            }
            strSql.Append(")AS Row, T.*  from QuestionInfoCareQuestionView T ");
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
            parameters[0].Value = "QuestionInfoCareQuestionView";
            parameters[1].Value = "questionCaredByUID";
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
