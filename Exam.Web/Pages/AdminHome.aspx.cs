using Exam.Lib.DBHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam.Web.Pages
{
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserDBHelper.IsUserAdmin(Session["USER"].ToString()))
            {
                litTalk.Text = "Welcome " + Session["USER"];
            }
        }


    }
}