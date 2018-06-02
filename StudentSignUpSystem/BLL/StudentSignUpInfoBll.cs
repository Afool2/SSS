using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Model;

namespace BLL
{
    /// <summary>
    /// 学生报名信息业务逻辑层
    /// </summary>
    public class StudentSignUpInfoBll
    {
        // 学生报名信息数据访问对象
        private StudentSignUpInfoDal StudentSignUpInfoDAO = new StudentSignUpInfoDal();
        /// <summary>
        /// 检测保存是否成功
        /// </summary>
        /// <param name="ssi">学生信息对象</param>
        /// <returns></returns>
        public bool CheckSaveStudentSignUpInfo(StudentSignUpInfo ssi)
        {
            return StudentSignUpInfoDAO.SaveStudentSignUpInfo(ssi) > 0;
        }

        /// <summary>
        /// 检测获取所有报名信息成功
        /// </summary>
        /// <returns></returns>
        public bool CheckGetAllStudentSignUpInfoSuccessed()
        {
            return StudentSignUpInfoDAO.GetAllStudentSignUpInfo() != null;
        }
    }
}
