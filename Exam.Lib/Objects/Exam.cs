using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace Exam.Lib.Objects
{
    public class Exam
    {
        public string Instructions { get; set; }
        public List<Question> Questions { get; set; }
        public int? TimeInSeconds { get; set; }

        public static Exam Populate(XmlDocument doc)
        {
            Exam exam = new Exam();

            XmlNode examNode = doc.SelectSingleNode("exam");
            exam.Instructions = examNode.SelectSingleNode("instructions")?.InnerText;

            string timeInSeconds = examNode.SelectSingleNode("time-in-seconds")?.InnerText;
            if (!String.IsNullOrEmpty(timeInSeconds))
                exam.TimeInSeconds = Convert.ToInt32(timeInSeconds);

            exam.Questions = new List<Question>();
            XmlNode questionsNode = examNode.SelectSingleNode("questions");
            XmlNodeList questionNodes = questionsNode.SelectNodes("question");
            foreach (XmlNode questionNode in questionNodes)
            {
                exam.Questions.Add(Question.Populate(questionNode));
            }

            return exam;
        }
    }
}