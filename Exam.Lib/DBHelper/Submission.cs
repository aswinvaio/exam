using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Exam.Lib.DBHelper
{
    public class Submission
    {
        public int ResultID { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int Score { get; set; }


        public static Submission Populate(SqlDataReader reader)
        {
            Submission submission = new Submission();
            submission.ResultID = Convert.ToInt32(reader["ResultID"]);
            submission.UserID = Convert.ToInt32(reader["UserID"]);
            submission.UserName = Convert.ToString(reader["UserName"]);
            submission.FullName = Convert.ToString(reader["FullName"]);
            submission.Score = Convert.ToInt32(reader["Score"]);
            submission.UpdatedOn = Convert.ToDateTime(reader["UpdatedOn"]);

            return submission;
        }
    }
}