using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using Common;

namespace BLL
{
    /// <summary>
    /// 用户业务逻辑层
    /// </summary>
    public class UserBll
    {
        private UserDal userDAO = new UserDal();

        /// <summary>
        /// 检测用户是否存在
        /// </summary>
        /// <param name="user">用户对象</param>
        /// <returns>返回true时用户已存在</returns>
        public bool CheckUserExists(User user)
        {
            return userDAO.UserExists(user) > 0;
        }

        /// <summary>
        /// 用户注册检测
        /// </summary>
        /// <param name="user">用户对象</param>
        /// <returns>返回true表示注册成功</returns>
        public bool CheckUserSignup(User user)
        {
            user.Password = Common.MD5.GetMD5(user.Password);
            return userDAO.SignUp(user) > 0;
        }

        /// <summary>
        /// 用户登录检测
        /// </summary>
        /// <param name="user">用户对象</param>
        /// <returns>返回true表示登录成功</returns>
        public bool CheckUserLogin(User user)
        {
            user.Password = Common.MD5.GetMD5(user.Password);
            return userDAO.Login(user) > 0;
        }
    }
}
