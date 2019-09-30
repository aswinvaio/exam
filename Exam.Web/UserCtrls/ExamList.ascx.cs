using Exam.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Exm = Exam.Lib.Objects.Exam;

namespace Exam.Web.UserCtrls
{
    public partial class ExamList : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Exm> exams = ExamHelper.GetAllExams();
            gvExamList.DataSource = exams;
            gvExamList.DataBind();
        }

        protected void gvExamList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Exm exam = e.Row.DataItem as Exm;
                Literal litExamId = e.Row.FindControl("litExamId") as Literal;
                Literal litDate = e.Row.FindControl("litDate") as Literal;
                HtmlAnchor btnPreviewQuestions = e.Row.FindControl("btnPreviewQuestions") as HtmlAnchor;
                HtmlAnchor btnViewSubmissions = e.Row.FindControl("btnViewSubmissions") as HtmlAnchor;

                litExamId.Text = exam.ID.ToString();
                litDate.Text = exam.CreatedDate.ToString();
                btnPreviewQuestions.HRef = string.Format("{0}?ExamId={1}", URLDefs.PreviewExam, exam.ID);
                btnViewSubmissions.HRef = string.Format("{0}?ExamId={1}", URLDefs.Submissions, exam.ID);
            }
        }
    }
}