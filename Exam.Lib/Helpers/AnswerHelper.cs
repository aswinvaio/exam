using Exam.Lib.DBHelper;
using Exam.Lib.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace Exam.Lib.Helpers
{
    public class AnswerHelper
    {
        public static XmlDocument GetAnswerXML(int userId, int examId)
        {
            string strAnswerXml = ExamResultDBHelper.GetAnswers(userId, examId);
            if (string.IsNullOrEmpty(strAnswerXml)) return null;
            XmlDocument answerXML = new XmlDocument();
            answerXML.LoadXml(strAnswerXml);
            return answerXML;
        }

        public static AnswerSheet GetAnswerSheet(int userId, int examId)
        {
            XmlDocument answerXML = GetAnswerXML(userId, examId);
            if (answerXML != null)
            {
                AnswerSheet answerSheet = AnswerSheet.Populate(answerXML);
                return answerSheet;
            }
            return null;
        }
    }
}