using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;



public partial class LoginAndSignup : System.Web.UI.Page
{
    protected BLL.UserBll userBll = new UserBll();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    /// <summary>
    /// 点击注册按钮
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Signup_Click(object sender, EventArgs e)
    {
        Model.User user = new User(this.UserName.Text.Trim(),this.Password.Text.Trim());

        if (userBll.CheckUserExists(user))
        {
            Response.Write("此用户名已被注册<hr>");
            return;
        }

        if (userBll.CheckUserSignup(user))
        {
            Session["username"] = user.UserName;
           
            Response.Redirect("StudentSinup.aspx");
        }
        else
        {
            Response.Write("注册失败，请稍后重试");
        }
    }

    /// <summary>
    /// 点击登录按钮
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void LogIn_Click(object sender, EventArgs e)
    {
       
        Model.User user = new User(this.UserName.Text.Trim(), this.Password.Text.Trim());
        if (userBll.CheckUserLogin(user))
        {
            Session["username"] = user.UserName;
            Response.Redirect("StudentSinup.aspx");
        }
        else
        {
            Response.Write("用户名或密码错误!<hr>");
        }
    }
}