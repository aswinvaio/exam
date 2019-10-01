using Exam.Lib.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Exam.Web.Pages
{
    public partial class Submissions : System.Web.UI.Page
    {
        public int ExamId
        {
            get
            {
                return Convert.ToInt32(Request["ExamId"]);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //load examsubmisions
            //bind gv
            List<Submission> submissions = ExamResultDBHelper.GetSubmissions(this.ExamId);
            gvSubmissionList.DataSource = submissions;
            gvSubmissionList.DataBind();
        }

        protected void gvSubmissionList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Submission submission = e.Row.DataItem as Submission;
                Literal litId = e.Row.FindControl("litId") as Literal;
                Literal litUserID = e.Row.FindControl("litUserID") as Literal;
                Literal litUsername = e.Row.FindControl("litUsername") as Literal;
                Literal litFullName = e.Row.FindControl("litFullName") as Literal;
                Literal litScore = e.Row.FindControl("litScore") as Literal;
                Literal litUpdatedDate = e.Row.FindControl("litUpdatedDate") as Literal;

                HtmlAnchor btnView = e.Row.FindControl("btnView") as HtmlAnchor;

                litId.Text = submission.ResultID.ToString();
                litUserID.Text = submission.UserID.ToString();
                litUsername.Text = submission.UserName;
                litFullName.Text = submission.FullName;
                litScore.Text = submission.Score.ToString();
                litUpdatedDate.Text = submission.UpdatedOn.ToString();
                btnView.HRef = string.Format("{0}?ExamId={1}&Ans=true&SuId={2}", URLDefs.ViewSubmission, this.ExamId, submission.UserID);
            }
        }
    }
}