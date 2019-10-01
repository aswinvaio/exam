using Exam.Lib.DBHelper;
using Exam.Lib.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using Exm = Exam.Lib.Objects.Exam;

namespace Exam.Lib.Helpers
{
    public class ExamHelper
    {
        public static Exm GetExam(int examId)
        {
            string examXml = ExamDBHelaper.GetExam(examId);
            if (!string.IsNullOrEmpty(examXml))
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(examXml);

                Exm exam = Exm.Populate(doc);
                return exam;
            }
            return null;
        }

        public static List<Exm> GetAllExams()
        {
            return ExamDBHelaper.GetAllExams();
        }

        public static Question NextQuestion(Exm exam, AnswerSheet answersheet)
        {
            foreach (Question question in exam.Questions)
            {
                bool unAnswered = true;
                if (answersheet != null)
                    foreach (Answer answer in answersheet.Answers)
                    {
                        if (answer.QuestionId == question.Id)
                            unAnswered = false;
                    }
                if (unAnswered)
                    return question;
            }
            return null;
        }

        public static int SaveAnswerSheet(int userId, int examId, AnswerSheet answerSheet)
        {
            //get Score
            Exm exam = GetExam(examId);
            int score = CalculateScore(exam, answerSheet);

            return ExamResultDBHelper.SaveAnswers(userId, examId, answerSheet.ToString(), score);
        }

        public static int CalculateScore(Exm exam, AnswerSheet answersheet)
        {
            int score = 0;
            foreach (Question question in exam.Questions)
            {
                foreach (Answer answer in answersheet.Answers)
                {
                    if (answer.QuestionId == question.Id)
                    {
                        bool isAnswerCorrect = true;
                        foreach(Option opt in question.Options)
                        {
                            if (opt.IsCorrect)
                            {
                                if (!answer.SelectedOptionIds.Contains(opt.Id))
                                    isAnswerCorrect = false;
                            }
                            else
                            {
                                if (answer.SelectedOptionIds.Contains(opt.Id))
                                    isAnswerCorrect = false;
                            }
                        }
                        if (isAnswerCorrect)
                        {
                            score += question.Score.True;
                        }
                        else
                        {
                            score += question.Score.False;
                        }
                    }
                }
            }
            return score;
        }

        public static Exm ProcessAnswers(Exm exam, AnswerSheet answersheet)
        {
            foreach (Question question in exam.Questions)
            {
                foreach (Answer answer in answersheet.Answers)
                {
                    if (answer.QuestionId == question.Id)
                    {
                        bool isAnswerCorrect = true;
                        foreach (Option opt in question.Options)
                        {
                            if (opt.IsCorrect)
                            {
                                if (!answer.SelectedOptionIds.Contains(opt.Id))
                                    isAnswerCorrect = false;
                            }
                            else
                            {
                                if (answer.SelectedOptionIds.Contains(opt.Id))
                                    isAnswerCorrect = false;
                            }
                        }
                        question.CalculatedScore = isAnswerCorrect ? question.Score.True : question.Score.False;
                        question.SubmittedAnswer = answer;
                    }
                }
            }
            return exam;
        }
    }
}