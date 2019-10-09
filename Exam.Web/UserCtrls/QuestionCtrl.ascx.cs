using Exam.Lib.DBHelper;
using Exam.Lib.Helpers;
using Exam.Lib.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Xml;
using Exm = Exam.Lib.Objects.Exam;

namespace Exam.Web.UserCtrls
{
    public partial class QuestionCtrl : System.Web.UI.UserControl
    {
        public int ExamId
        {
            get
            {
                return Convert.ToInt32(Request["ExamId"]);
            }
        }

        public int UserId
        {
            get
            {
                return Convert.ToInt32(Session["USERID"]);
            }
        }

        protected void Page_Init(object sender, EventArgs e)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                _SetUIAndBindData();
            }
        }

        private void _SetUIAndBindData()
        {
            Exm exam = ExamHelper.GetExam(this.ExamId);

            AnswerSheet answersheet = AnswerHelper.GetAnswerSheet(this.UserId, this.ExamId);
            if (!Page.IsPostBack)
            {
                divQuestionContainer.Visible = false;
                divMessage.Visible = false;
                divWelcome.Visible = true;

                litIstructions.Text = exam.Instructions != null ? exam.Instructions : "-";
                litTime.Text = exam.TimeInSeconds.HasValue ? Utils.TimeString(exam.TimeInSeconds.Value) : "-";
                return;
            }
            else if (answersheet != null && answersheet.Answers.Count == exam.Questions.Count)
            {
                divQuestionContainer.Visible = false;
                divMessage.Visible = true;
                divWelcome.Visible = false;

                //lblMessage.Text = "Finished!";
            }
            else if (answersheet == null || answersheet.Answers.Count < exam.Questions.Count)
            {
                divQuestionContainer.Visible = true;
                divMessage.Visible = false;
                divWelcome.Visible = false;
                Question question = ExamHelper.NextQuestion(exam, answersheet);
                if (question != null)
                {
                    populateQuestionUI(question);
                }
            }
        }

        private void populateQuestionUI(Question question)
        {
            litId.Text = question.Id;
            litQuestion.Text = question.Short;
            litDescription.Text = question.Description;
            if (question.Score != null)
            {
                litScore.Text = string.Format("{0} ({1} if wrong)", question.Score.True, question.Score.False);
            }
            repOptions.DataSource = question.Options;
            repOptions.DataBind();
        }

        protected void repOptions_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var option = e.Item.DataItem as Option;
                var chkOption = e.Item.FindControl("chkOption") as CheckBox;
                var litOptionId = e.Item.FindControl("litOptionId") as Literal;
                var litOption = e.Item.FindControl("litOption") as Literal;
                var divOption = e.Item.FindControl("divOption") as HtmlGenericControl;

                litOptionId.Text = option.Id;
                litOption.Text = option.Value;
            }
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            _SetUIAndBindData();
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            //validate
            AnswerSheet answerSheet = AnswerHelper.GetAnswerSheet(this.UserId, this.ExamId);
            List<string> checkedOptionIds = new List<string>();
            foreach (RepeaterItem item in repOptions.Items)
            {
                if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
                {
                    var chkOption = item.FindControl("chkOption") as CheckBox;
                    var litOptionId = item.FindControl("litOptionId") as Literal;

                    if (chkOption.Checked)
                    {
                        checkedOptionIds.Add(litOptionId.Text);
                    }
                }
            }
            if (checkedOptionIds.Count > 0)
            {
                if (answerSheet == null)
                {
                    answerSheet = new AnswerSheet()
                    {
                        Answers = new List<Answer>()
                    };
                }

                if (!answerSheet.Answers.Any(x => x.QuestionId == litId.Text))
                {
                    answerSheet.Answers.Add(new Answer()
                    {
                        QuestionId = litId.Text,
                        SelectedOptionIds = checkedOptionIds
                    });
                    ExamHelper.SaveAnswerSheet(this.UserId, this.ExamId, answerSheet);
                }
            }
            _SetUIAndBindData();
        }
    }
}
