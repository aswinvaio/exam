using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam.Web.MasterPages
{
    public partial class AdminBase : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckIfUserAvailable();
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["USER"] = null;
            Session["ISADMIN"] = null;
            
            CheckIfUserAvailable();
        }

        private void CheckIfUserAvailable()
        {
            if (Session["USER"] == null 
                || string.IsNullOrWhiteSpace(Session["USER"].ToString()) 
                || Session["ISADMIN"] == null 
                || Session["ISADMIN"].ToString() != "1")
            {
                Response.Redirect("/Pages/Login.aspx");
            }
        }
    }
}