using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace Exam.Lib.Objects
{
    public class Answer
    {
        public string QuestionId { get; set; }
        public List<string> SelectedOptionIds { get; set; }

        public static Answer Populate(XmlNode answerNode)
        {
            Answer answer = new Answer();

            return answer;
        }
    }
}