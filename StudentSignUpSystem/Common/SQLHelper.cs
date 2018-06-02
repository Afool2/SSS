using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;



namespace Common
{
    public class SQLHelper
    {
        // 连接字符串
        static readonly string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        /// <summary>
        /// 执行非查询语句，返回受影响的行数
        /// </summary>
        /// <param name="cmdText">sql语句</param>
        /// <param name="sp">SqlParameter类型的可变参数</param>
        /// <returns>int类型，受影响的行数</returns>
        public static int ExecuteNonQuery(string cmdText, params SqlParameter[] sp)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(cmdText, conn))
                {
                    cmd.Parameters.AddRange(sp);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 执行查询
        /// </summary>
        /// <param name="cmdText">sql语句</param>
        /// <param name="sp">可变参数</param>
        /// <returns>第一行第一列</returns>
        public static object ExecuteScalar(string cmdText, params SqlParameter[] sp)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(cmdText, conn))
                {
                    cmd.Parameters.AddRange(sp);
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        public static SqlDataReader ExecuteReader(string cmdText, params SqlParameter[] sp)
        {
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                using (SqlCommand cmd = new SqlCommand(cmdText, conn))
                {
                    cmd.Parameters.AddRange(sp);
                    conn.Open();

                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
            }
            catch (Exception ex)
            {
                conn.Dispose();
                throw ex;
            }


        }

        public static DataSet GetDataSet(string cmdText, params SqlParameter[] sp)
        {
            DataSet ds = new DataSet();
            using (SqlDataAdapter sda = new SqlDataAdapter(cmdText, connStr))
            {
                sda.SelectCommand.Parameters.AddRange(sp);
                sda.Fill(ds);
            }
            return ds;
        }
    }
}
