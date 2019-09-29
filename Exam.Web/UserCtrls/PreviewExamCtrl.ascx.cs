﻿using Exam.Lib.DBHelper;
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
    public partial class PreviewExamCtrl : System.Web.UI.UserControl
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
            Exm exam = ExamHelper.GetExam(this.ExamId);
            if (exam !=null)
            {
                litIstructions.Text = exam.Instructions != null ? exam.Instructions : "-";
                litTime.Text = exam.TimeInSeconds != null ? exam.TimeInSeconds.ToString() : "-";

                repQuestions.DataSource = exam.Questions;
                repQuestions.DataBind();
            }
        }

        protected void repQuestions_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var question = e.Item.DataItem as Question;
                var litId = e.Item.FindControl("litId") as Literal;
                var litQuestion = e.Item.FindControl("litQuestion") as Literal;
                var litDescription = e.Item.FindControl("litDescription") as Literal;
                var litScore = e.Item.FindControl("litScore") as Literal;
                var repOptions = e.Item.FindControl("repOptions") as Repeater;

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
        }

        protected void repOptions_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var option = e.Item.DataItem as Option;
                //var chkOption = e.Item.FindControl("chkOption") as CheckBox;
                var litOptionId = e.Item.FindControl("litOptionId") as Literal;
                var litOption = e.Item.FindControl("litOption") as Literal;
                var divOption = e.Item.FindControl("divOption") as HtmlGenericControl;

                litOptionId.Text = option.Id;
                litOption.Text = option.Value;
                if (option.IsCorrect)
                    divOption.Attributes.Add("class", "option correct");
            }

        }
    }
}