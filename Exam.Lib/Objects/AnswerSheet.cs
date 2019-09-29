using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace Exam.Lib.Objects
{
    public class AnswerSheet
    {
        public List<Answer> Answers { get; set; }

        public static AnswerSheet Populate(XmlDocument doc)
        {
            AnswerSheet answersheet = new AnswerSheet();

            XmlNode answersheetNode = doc.SelectSingleNode("answer-sheet");

            XmlNodeList answerNodes = answersheetNode.SelectNodes("answer");
            answersheet.Answers = new List<Answer>();
            foreach (XmlNode answerNode in answerNodes)
            {
                Answer answer = new Answer();
                answer.QuestionId = answerNode.Attributes["questionid"].Value;
                XmlNodeList selectedOptionsNodes= answerNode.SelectNodes("selected-option");
                answer.SelectedOptionIds = new List<string>();
                foreach(XmlNode optionNode in selectedOptionsNodes)
                {
                    answer.SelectedOptionIds.Add(optionNode.Attributes["id"].Value);
                }

                answersheet.Answers.Add(answer);
            }

            return answersheet;
        }

        public XmlDocument ToXML()
        {
            XmlDocument answersheet = new XmlDocument();

            XmlDeclaration xmlDeclaration = answersheet.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = answersheet.DocumentElement;
            answersheet.InsertBefore(xmlDeclaration, root);


            XmlNode rootNode = answersheet.CreateElement("answer-sheet");

            foreach(Answer answer in this.Answers)
            {
                XmlAttribute questionidAttrib = answersheet.CreateAttribute("questionid");
                questionidAttrib.Value = answer.QuestionId;
                XmlNode answerNode = answersheet.CreateElement("answer");
                answerNode.Attributes.Append(questionidAttrib);
                rootNode.AppendChild(answerNode);
            }

            return answersheet;
        }

    }
}