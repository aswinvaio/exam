using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml;

namespace Exam.Lib.Objects
{
    public class Exam
    {
        public int ID { get; set; }
        public string Instructions { get; set; }
        public List<Question> Questions { get; set; }
        public int? TimeInSeconds { get; set; }
        public DateTime? CreatedDate { get; set; } 

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

        public static Exam Populate(SqlDataReader reader)
        {
            Exam exam = new Exam();
            exam.ID = Convert.ToInt32(reader["ExamID"]);
            exam.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
            //ExamXML
            return exam;
        }
    }
}