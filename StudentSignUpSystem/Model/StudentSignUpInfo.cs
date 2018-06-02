using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 学生报名信息
    /// </summary>
    public class StudentSignUpInfo
    {
        /// <summary>
        /// 信息id
        /// </summary>
        public int InfoID { get; set; }
        /// <summary>
        /// 学生姓名
        /// </summary>
        public string StudentName { get; set; }
        /// <summary>
        /// 学生身份证号
        /// </summary>
        public string IDCardNumber { get; set; }
        /// <summary>
        /// 性别。0为男，1为女
        /// </summary>
        public int Gender { get; set; }
        /// <summary>
        /// 学生出生日期
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// 所报专业
        /// </summary>
        public string SignupMajor { get; set; }
        /// <summary>
        /// 学历
        /// </summary>
        public string EducationalBackground { get; set; }
        /// <summary>
        /// 所注册的用户id
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// 注册（报名）时间
        /// </summary>
        public DateTime SignupTime { get; set; }

        /// <summary>
        /// 有参构造方法
        /// </summary>
        /// <param name="studentName"></param>
        /// <param name="IdCardNumber"></param>
        /// <param name="gender"></param>
        /// <param name="birthday"></param>
        /// <param name="signupMajor"></param>
        /// <param name="educationalBackground"></param>
        /// <param name="userID"></param>
        /// <param name="signupTime"></param>
        public StudentSignUpInfo(string studentName, string IdCardNumber, int gender, DateTime birthday, string signupMajor, string educationalBackground, int userID, DateTime signupTime)
        {
            this.StudentName = studentName;
            this.IDCardNumber = IdCardNumber;
            this.Gender = gender;
            this.Birthday = birthday;
            this.SignupMajor = signupMajor;
            this.EducationalBackground = educationalBackground;
            this.UserID = userID;
            this.SignupTime = signupTime;
        }
    }
}
