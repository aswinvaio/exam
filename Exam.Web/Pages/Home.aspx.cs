using Exam.Lib.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam.Web.Pages
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USER"] != null && !UserDBHelper.IsUserAdmin(Session["USER"].ToString()))
            {
                litTalk.Text = "Welcome " + Session["USER"];
            }
        }

        protected void btnExamID_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtExamID.Text))
            {
                try
                {
                    string xml = ExamDBHelaper.GetExam(Convert.ToInt32(txtExamID.Text));
                    if (!string.IsNullOrEmpty(xml))
                    {
                        Response.Redirect("Question.aspx?ExamId=" + txtExamID.Text);
                    }
                }
                catch (Exception)
                {
                    
                }

            }

            litError.Text = "Please enter valid ExamID";
        }
    }
}