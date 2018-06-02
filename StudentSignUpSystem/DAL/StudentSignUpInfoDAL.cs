using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Common;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// 学生报名信息数据访问层
    /// </summary>
    public class StudentSignUpInfoDal
    {
        /// <summary>
        /// 保存学生的报名信息
        /// </summary>
        /// <param name="ssi">学生报名信息对象</param>
        /// <returns></returns>
        public int SaveStudentSignUpInfo(StudentSignUpInfo ssi)
        {
            string sql = "insert into [tb_studentSignupInfo](studentName,IDCardNumber,gender,birthday,signupMajor,educationalBackground,userID,signupTime) values(@studentName,@IDCardNumber,@gender,@birthday,@signupMajor,@educationalBackground,@userID,@signupTime)";
            SqlParameter[] sp =
            {
                new SqlParameter("@studentName", ssi.StudentName),
                new SqlParameter("@IDCardNumber", ssi.IDCardNumber),
                new SqlParameter("@gender", ssi.Gender),
                new SqlParameter("@birthday", ssi.Birthday),
                new SqlParameter("@signupMajor", ssi.SignupMajor),
                new SqlParameter("@educationalBackground", ssi.EducationalBackground),
                new SqlParameter("@userID", ssi.UserID),
                new SqlParameter("@signupTime", "getdate()")
            };
            return Common.SQLHelper.ExecuteNonQuery(sql, sp);
        }

        public 
    }
}
