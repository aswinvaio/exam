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
    }
}