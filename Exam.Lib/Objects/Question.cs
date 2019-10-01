using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace Exam.Lib.Objects
{
    public class Question
    {
        public string Id { get; set; }
        public string Short { get; set; }
        public string Description { get; set; }
        public Score Score { get; set; }
        public List<Option> Options { get; set; }

        public Answer SubmittedAnswer { get; set; }
        public int CalculatedScore { get; set; }

        public static Question Populate(XmlNode questionNode)
        {
            Question question = new Question();
            question.Id = questionNode.Attributes["id"].Value;
            question.Short = questionNode.SelectSingleNode("short")?.InnerText;
            question.Description = questionNode.SelectSingleNode("description")?.InnerText;
            
            XmlNode scoreNode = questionNode.SelectSingleNode("score");
            question.Score = new Score();
            string t = scoreNode.SelectSingleNode("t")?.InnerText;
            if (!string.IsNullOrEmpty(t))
                question.Score.True = Convert.ToInt32(t);
            string f = scoreNode.SelectSingleNode("f")?.InnerText;
            if (!string.IsNullOrEmpty(f))
                question.Score.False = Convert.ToInt32(f);

            question.Options = new List<Option>();
            XmlNode optionsNode = questionNode.SelectSingleNode("options");
            XmlNodeList optionNodes = optionsNode.SelectNodes("option");
            foreach(XmlNode optionNode in optionNodes)
            {
                question.Options.Add(Option.Populate(optionNode));
            }
            

            return question;
        }
    }
}