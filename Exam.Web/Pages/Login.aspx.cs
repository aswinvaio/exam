using Exam.Lib.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam.Web.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            int? userId = UserDBHelper.IsCredentialsValid(txtUserName.Text, txtPassword.Text);
            if (userId != null)
            {
                Session["USER"] = txtUserName.Text;
                Session["USERID"] = userId;
                if (UserDBHelper.IsUserAdmin(Session["USER"].ToString()))
                {
                    Response.Redirect("AdminHome.aspx");
                }
                Response.Redirect("Home.aspx");
            }
        }
    }
}