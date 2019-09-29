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

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (fuExam.HasFile)
            {
                using (StreamReader reader = new StreamReader(fuExam.FileContent))
                {
                    string text = reader.ReadToEnd();
                    int? examId = ExamDBHelaper.PutExam(text);
                    if (examId == null)
                    {
                        lblMessage.Text = "Could not save Exam! Check XML";
                    }
                    else
                    {
                        lblMessage.Text = "Exam saved successfully, Exam ID: <strong>" + examId + "</strong>";
                    }
                }
            }
            else
            {
                lblMessage.Text = "File not selected!";
            }
            
        }
    }
}