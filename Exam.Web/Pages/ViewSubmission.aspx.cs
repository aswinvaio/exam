using Exam.Lib.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam.Web.Pages
{
    public partial class ViewSubmission : System.Web.UI.Page
    {
        public int ExamId
        {
            get
            {
                return Convert.ToInt32(Request["ExamId"]);
            }
        }

        public int SubmittedUserId
        {
            get
            {
                return Convert.ToInt32(Request["SuId"]);
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            aBack.HRef = string.Format("{0}?ExamId={1}", URLDefs.Submissions, this.ExamId);

            List<Submission> submissions = ExamResultDBHelper.GetSubmissions(this.ExamId);
            Submission thisSubmission = submissions.FirstOrDefault(s => s.UserID == this.SubmittedUserId);
            if (thisSubmission != null)
            {
                litUserID.Text = thisSubmission.UserID.ToString();
                litUsername.Text = thisSubmission.UserName;
                litFullName.Text = thisSubmission.FullName;
                litScore.Text = thisSubmission.Score.ToString();
                litUpdatedDate.Text = thisSubmission.UpdatedOn.ToString();
            }
        }
    }
}