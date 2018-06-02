using Common;
using System.Data;
using System.Data.SqlClient;
using Model;
namespace DAL
{
    /// <summary>
    /// 用户数据访问层
    /// </summary>
    public class UserDal
    {
        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>数据库受影响行数</returns>
        public int SignUp(User user)
        {
            string sql = "insert into [tb_user](userName, password) values(@username,@password)";
            SqlParameter[] sp = {
                new SqlParameter("@username", user.UserName),
                new SqlParameter("@password", user.Password)
            };
            return Common.SQLHelper.ExecuteNonQuery(sql, sp); 
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>数据库中匹配的记录数</returns>
        public int Login(User user)
        {
            string sql = "select count(userName) from [tb_user] where userName=@username and password = @password";
            SqlParameter[] sp =
            {
                new SqlParameter("@username", user.UserName),
                new SqlParameter("@password", user.Password)
            };
            return (int)Common.SQLHelper.ExecuteScalar(sql, sp);
        }

        /// <summary>
        /// 判断用户是否已存在
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns>数据库中对应用户名的记录条数</returns>
        public int UserExists(User user)
        {
            string sql = "select count(userName) from [tb_user] where userName=@username";
            return (int)Common.SQLHelper.ExecuteScalar(sql, new SqlParameter("@username", user.UserName));
        }
    }
}
