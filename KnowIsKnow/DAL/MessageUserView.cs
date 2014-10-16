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
    /// 数据访问类:MessageUserView
    /// </summary>
    public partial class MessageUserView
    {
        public MessageUserView()
        { }
        public DataSet GetUnreadSenderList(string sql)
        {
            return DbHelperSQL.Query(sql);

        }

        public DataSet GetLastMessage(string sql)
        {
            return DbHelperSQL.Query(sql);
        }
        public DataSet GetMessageCount(string sql)
        {
            return DbHelperSQL.Query(sql);
        }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int MessageSenderID, int MessageReceiverID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from MessageUserView");
            strSql.Append(" where MessageSenderID=@MessageSenderID and MessageReceiverID=@MessageReceiverID ");
            SqlParameter[] parameters = {
					new SqlParameter("@MessageSenderID", SqlDbType.Int,4),
					new SqlParameter("@MessageReceiverID", SqlDbType.Int,4)			};
            parameters[0].Value = MessageSenderID;
            parameters[1].Value = MessageReceiverID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.MessageUserView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MessageUserView(");
            strSql.Append("userEmail,userNickName,userHeadImage,userState,userGender,userBirthday,userAdress,userJob,userShuoShuo,userCompany,userJobPosition,userAcademy,userMajor,userProBio,receiverEmail,receiverNickName,receiverHeadImage,receiverState,receiverGender,receiverBirthday,receiverAdress,receiverJob,receiverShuoShuo,receiverCompany,receiverJobPosition,receiverAcademy,receiverMajor,receiverProBio,MessageID,MessageSenderID,MessageReceiverID,MessageContent,MessageSendTime,MessageSate,MessageReportID)");
            strSql.Append(" values (");
            strSql.Append("@userEmail,@userNickName,@userHeadImage,@userState,@userGender,@userBirthday,@userAdress,@userJob,@userShuoShuo,@userCompany,@userJobPosition,@userAcademy,@userMajor,@userProBio,@receiverEmail,@receiverNickName,@receiverHeadImage,@receiverState,@receiverGender,@receiverBirthday,@receiverAdress,@receiverJob,@receiverShuoShuo,@receiverCompany,@receiverJobPosition,@receiverAcademy,@receiverMajor,@receiverProBio,@MessageID,@MessageSenderID,@MessageReceiverID,@MessageContent,@MessageSendTime,@MessageSate,@MessageReportID)");
            SqlParameter[] parameters = {
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
					new SqlParameter("@receiverEmail", SqlDbType.VarChar,100),
					new SqlParameter("@receiverNickName", SqlDbType.VarChar,20),
					new SqlParameter("@receiverHeadImage", SqlDbType.VarChar,100),
					new SqlParameter("@receiverState", SqlDbType.VarChar,20),
					new SqlParameter("@receiverGender", SqlDbType.NVarChar,1),
					new SqlParameter("@receiverBirthday", SqlDbType.Date,3),
					new SqlParameter("@receiverAdress", SqlDbType.VarChar,100),
					new SqlParameter("@receiverJob", SqlDbType.VarChar,50),
					new SqlParameter("@receiverShuoShuo", SqlDbType.VarChar,50),
					new SqlParameter("@receiverCompany", SqlDbType.VarChar,50),
					new SqlParameter("@receiverJobPosition", SqlDbType.VarChar,50),
					new SqlParameter("@receiverAcademy", SqlDbType.VarChar,50),
					new SqlParameter("@receiverMajor", SqlDbType.VarChar,50),
					new SqlParameter("@receiverProBio", SqlDbType.VarChar,-1),
					new SqlParameter("@MessageID", SqlDbType.Int,4),
					new SqlParameter("@MessageSenderID", SqlDbType.Int,4),
					new SqlParameter("@MessageReceiverID", SqlDbType.Int,4),
					new SqlParameter("@MessageContent", SqlDbType.VarChar,400),
					new SqlParameter("@MessageSendTime", SqlDbType.DateTime),
					new SqlParameter("@MessageSate", SqlDbType.VarChar,20),
					new SqlParameter("@MessageReportID", SqlDbType.Int,4)};
            parameters[0].Value = model.userEmail;
            parameters[1].Value = model.userNickName;
            parameters[2].Value = model.userHeadImage;
            parameters[3].Value = model.userState;
            parameters[4].Value = model.userGender;
            parameters[5].Value = model.userBirthday;
            parameters[6].Value = model.userAdress;
            parameters[7].Value = model.userJob;
            parameters[8].Value = model.userShuoShuo;
            parameters[9].Value = model.userCompany;
            parameters[10].Value = model.userJobPosition;
            parameters[11].Value = model.userAcademy;
            parameters[12].Value = model.userMajor;
            parameters[13].Value = model.userProBio;
            parameters[14].Value = model.receiverEmail;
            parameters[15].Value = model.receiverNickName;
            parameters[16].Value = model.receiverHeadImage;
            parameters[17].Value = model.receiverState;
            parameters[18].Value = model.receiverGender;
            parameters[19].Value = model.receiverBirthday;
            parameters[20].Value = model.receiverAdress;
            parameters[21].Value = model.receiverJob;
            parameters[22].Value = model.receiverShuoShuo;
            parameters[23].Value = model.receiverCompany;
            parameters[24].Value = model.receiverJobPosition;
            parameters[25].Value = model.receiverAcademy;
            parameters[26].Value = model.receiverMajor;
            parameters[27].Value = model.receiverProBio;
            parameters[28].Value = model.MessageID;
            parameters[29].Value = model.MessageSenderID;
            parameters[30].Value = model.MessageReceiverID;
            parameters[31].Value = model.MessageContent;
            parameters[32].Value = model.MessageSendTime;
            parameters[33].Value = model.MessageSate;
            parameters[34].Value = model.MessageReportID;

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
        public bool Update(Model.MessageUserView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MessageUserView set ");
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
            strSql.Append("receiverEmail=@receiverEmail,");
            strSql.Append("receiverNickName=@receiverNickName,");
            strSql.Append("receiverHeadImage=@receiverHeadImage,");
            strSql.Append("receiverState=@receiverState,");
            strSql.Append("receiverGender=@receiverGender,");
            strSql.Append("receiverBirthday=@receiverBirthday,");
            strSql.Append("receiverAdress=@receiverAdress,");
            strSql.Append("receiverJob=@receiverJob,");
            strSql.Append("receiverShuoShuo=@receiverShuoShuo,");
            strSql.Append("receiverCompany=@receiverCompany,");
            strSql.Append("receiverJobPosition=@receiverJobPosition,");
            strSql.Append("receiverAcademy=@receiverAcademy,");
            strSql.Append("receiverMajor=@receiverMajor,");
            strSql.Append("receiverProBio=@receiverProBio,");
            strSql.Append("MessageID=@MessageID,");
            strSql.Append("MessageSenderID=@MessageSenderID,");
            strSql.Append("MessageReceiverID=@MessageReceiverID,");
            strSql.Append("MessageContent=@MessageContent,");
            strSql.Append("MessageSendTime=@MessageSendTime,");
            strSql.Append("MessageSate=@MessageSate,");
            strSql.Append("MessageReportID=@MessageReportID");
            strSql.Append(" where MessageSenderID=@MessageSenderID and MessageReceiverID=@MessageReceiverID ");
            SqlParameter[] parameters = {
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
					new SqlParameter("@receiverEmail", SqlDbType.VarChar,100),
					new SqlParameter("@receiverNickName", SqlDbType.VarChar,20),
					new SqlParameter("@receiverHeadImage", SqlDbType.VarChar,100),
					new SqlParameter("@receiverState", SqlDbType.VarChar,20),
					new SqlParameter("@receiverGender", SqlDbType.NVarChar,1),
					new SqlParameter("@receiverBirthday", SqlDbType.Date,3),
					new SqlParameter("@receiverAdress", SqlDbType.VarChar,100),
					new SqlParameter("@receiverJob", SqlDbType.VarChar,50),
					new SqlParameter("@receiverShuoShuo", SqlDbType.VarChar,50),
					new SqlParameter("@receiverCompany", SqlDbType.VarChar,50),
					new SqlParameter("@receiverJobPosition", SqlDbType.VarChar,50),
					new SqlParameter("@receiverAcademy", SqlDbType.VarChar,50),
					new SqlParameter("@receiverMajor", SqlDbType.VarChar,50),
					new SqlParameter("@receiverProBio", SqlDbType.VarChar,-1),
					new SqlParameter("@MessageID", SqlDbType.Int,4),
					new SqlParameter("@MessageSenderID", SqlDbType.Int,4),
					new SqlParameter("@MessageReceiverID", SqlDbType.Int,4),
					new SqlParameter("@MessageContent", SqlDbType.VarChar,400),
					new SqlParameter("@MessageSendTime", SqlDbType.DateTime),
					new SqlParameter("@MessageSate", SqlDbType.VarChar,20),
					new SqlParameter("@MessageReportID", SqlDbType.Int,4)};
            parameters[0].Value = model.userEmail;
            parameters[1].Value = model.userNickName;
            parameters[2].Value = model.userHeadImage;
            parameters[3].Value = model.userState;
            parameters[4].Value = model.userGender;
            parameters[5].Value = model.userBirthday;
            parameters[6].Value = model.userAdress;
            parameters[7].Value = model.userJob;
            parameters[8].Value = model.userShuoShuo;
            parameters[9].Value = model.userCompany;
            parameters[10].Value = model.userJobPosition;
            parameters[11].Value = model.userAcademy;
            parameters[12].Value = model.userMajor;
            parameters[13].Value = model.userProBio;
            parameters[14].Value = model.receiverEmail;
            parameters[15].Value = model.receiverNickName;
            parameters[16].Value = model.receiverHeadImage;
            parameters[17].Value = model.receiverState;
            parameters[18].Value = model.receiverGender;
            parameters[19].Value = model.receiverBirthday;
            parameters[20].Value = model.receiverAdress;
            parameters[21].Value = model.receiverJob;
            parameters[22].Value = model.receiverShuoShuo;
            parameters[23].Value = model.receiverCompany;
            parameters[24].Value = model.receiverJobPosition;
            parameters[25].Value = model.receiverAcademy;
            parameters[26].Value = model.receiverMajor;
            parameters[27].Value = model.receiverProBio;
            parameters[28].Value = model.MessageID;
            parameters[29].Value = model.MessageSenderID;
            parameters[30].Value = model.MessageReceiverID;
            parameters[31].Value = model.MessageContent;
            parameters[32].Value = model.MessageSendTime;
            parameters[33].Value = model.MessageSate;
            parameters[34].Value = model.MessageReportID;

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
        public bool Delete(int MessageSenderID, int MessageReceiverID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MessageUserView ");
            strSql.Append(" where MessageSenderID=@MessageSenderID and MessageReceiverID=@MessageReceiverID ");
            SqlParameter[] parameters = {
					new SqlParameter("@MessageSenderID", SqlDbType.Int,4),
					new SqlParameter("@MessageReceiverID", SqlDbType.Int,4)			};
            parameters[0].Value = MessageSenderID;
            parameters[1].Value = MessageReceiverID;

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
        public Model.MessageUserView GetModel(int MessageSenderID, int MessageReceiverID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 userEmail,userNickName,userHeadImage,userState,userGender,userBirthday,userAdress,userJob,userShuoShuo,userCompany,userJobPosition,userAcademy,userMajor,userProBio,receiverEmail,receiverNickName,receiverHeadImage,receiverState,receiverGender,receiverBirthday,receiverAdress,receiverJob,receiverShuoShuo,receiverCompany,receiverJobPosition,receiverAcademy,receiverMajor,receiverProBio,MessageID,MessageSenderID,MessageReceiverID,MessageContent,MessageSendTime,MessageSate,MessageReportID from MessageUserView ");
            strSql.Append(" where MessageSenderID=@MessageSenderID and MessageReceiverID=@MessageReceiverID ");
            SqlParameter[] parameters = {
					new SqlParameter("@MessageSenderID", SqlDbType.Int,4),
					new SqlParameter("@MessageReceiverID", SqlDbType.Int,4)			};
            parameters[0].Value = MessageSenderID;
            parameters[1].Value = MessageReceiverID;

            Model.MessageUserView model = new Model.MessageUserView();
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
        public Model.MessageUserView DataRowToModel(DataRow row)
        {
            Model.MessageUserView model = new Model.MessageUserView();
            if (row != null)
            {
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
                if (row["receiverEmail"] != null)
                {
                    model.receiverEmail = row["receiverEmail"].ToString();
                }
                if (row["receiverNickName"] != null)
                {
                    model.receiverNickName = row["receiverNickName"].ToString();
                }
                if (row["receiverHeadImage"] != null)
                {
                    model.receiverHeadImage = row["receiverHeadImage"].ToString();
                }
                if (row["receiverState"] != null)
                {
                    model.receiverState = row["receiverState"].ToString();
                }
                if (row["receiverGender"] != null)
                {
                    model.receiverGender = row["receiverGender"].ToString();
                }
                if (row["receiverBirthday"] != null && row["receiverBirthday"].ToString() != "")
                {
                    model.receiverBirthday = DateTime.Parse(row["receiverBirthday"].ToString());
                }
                if (row["receiverAdress"] != null)
                {
                    model.receiverAdress = row["receiverAdress"].ToString();
                }
                if (row["receiverJob"] != null)
                {
                    model.receiverJob = row["receiverJob"].ToString();
                }
                if (row["receiverShuoShuo"] != null)
                {
                    model.receiverShuoShuo = row["receiverShuoShuo"].ToString();
                }
                if (row["receiverCompany"] != null)
                {
                    model.receiverCompany = row["receiverCompany"].ToString();
                }
                if (row["receiverJobPosition"] != null)
                {
                    model.receiverJobPosition = row["receiverJobPosition"].ToString();
                }
                if (row["receiverAcademy"] != null)
                {
                    model.receiverAcademy = row["receiverAcademy"].ToString();
                }
                if (row["receiverMajor"] != null)
                {
                    model.receiverMajor = row["receiverMajor"].ToString();
                }
                if (row["receiverProBio"] != null)
                {
                    model.receiverProBio = row["receiverProBio"].ToString();
                }
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
            strSql.Append("select userEmail,userNickName,userHeadImage,userState,userGender,userBirthday,userAdress,userJob,userShuoShuo,userCompany,userJobPosition,userAcademy,userMajor,userProBio,receiverEmail,receiverNickName,receiverHeadImage,receiverState,receiverGender,receiverBirthday,receiverAdress,receiverJob,receiverShuoShuo,receiverCompany,receiverJobPosition,receiverAcademy,receiverMajor,receiverProBio,MessageID,MessageSenderID,MessageReceiverID,MessageContent,MessageSendTime,MessageSate,MessageReportID ");
            strSql.Append(" FROM MessageUserView ");
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
            strSql.Append(" userEmail,userNickName,userHeadImage,userState,userGender,userBirthday,userAdress,userJob,userShuoShuo,userCompany,userJobPosition,userAcademy,userMajor,userProBio,receiverEmail,receiverNickName,receiverHeadImage,receiverState,receiverGender,receiverBirthday,receiverAdress,receiverJob,receiverShuoShuo,receiverCompany,receiverJobPosition,receiverAcademy,receiverMajor,receiverProBio,MessageID,MessageSenderID,MessageReceiverID,MessageContent,MessageSendTime,MessageSate,MessageReportID ");
            strSql.Append(" FROM MessageUserView ");
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
            strSql.Append("select count(1) FROM MessageUserView ");
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
                strSql.Append("order by T.MessageReceiverID desc");
            }
            strSql.Append(")AS Row, T.*  from MessageUserView T ");
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
            parameters[0].Value = "MessageUserView";
            parameters[1].Value = "MessageReceiverID";
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
