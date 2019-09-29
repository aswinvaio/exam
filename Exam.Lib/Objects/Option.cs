using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace Exam.Lib.Objects
{
    public class Option
    {
        public string Id { get; set; }
        public string Value { get; set; }
        public bool IsCorrect { get; set; }

        public static Option Populate(XmlNode optionNode)
        {
            Option option = new Option();

            option.Id = optionNode.Attributes["id"].Value;

            XmlAttribute isCorrectAttrib = optionNode.Attributes["is-correct"];
            if (isCorrectAttrib != null)
                option.IsCorrect = bool.Parse(isCorrectAttrib.Value);

            option.Value = optionNode.InnerText;

            return option;
        }
    }
}