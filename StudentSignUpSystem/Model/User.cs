﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        public User(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }
    }
}
