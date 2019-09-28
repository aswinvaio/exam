using Exam.Lib.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam.Web.MasterPages
{
    public partial class UserBase : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckIfUserAvailable();
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["USER"] = null;
            CheckIfUserAvailable();
        }

        private void CheckIfUserAvailable()
        {
            if (Session["USER"] == null || string.IsNullOrWhiteSpace(Session["USER"].ToString()))
            {
                Response.Redirect("/Pages/Login.aspx");
            }
        }
    }
}