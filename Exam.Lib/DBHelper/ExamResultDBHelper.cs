using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml;

namespace Exam.Lib.DBHelper
{
    public class ExamResultDBHelper
    {
        public static string GetAnswers(int userId, int examId)
        {
            string examXML = null;
            using (SqlConnection con = new SqlConnection(DBConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Proc_ExamResult_GetAnswers", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                    cmd.Parameters.Add("@ExamId", SqlDbType.Int).Value = examId;
                    cmd.Parameters.Add("@AnswerXML", SqlDbType.NVarChar, -1); //MAX
                    cmd.Parameters["@AnswerXML"].Direction = ParameterDirection.Output;

                    con.Open();
                    cmd.ExecuteNonQuery();

                    examXML = Convert.ToString(cmd.Parameters["@AnswerXML"].Value);
                }
            }
            return examXML;
        }

        public static int SaveAnswers(int userId, int examId, string answerSheetXML, int score)
        {
            int status = -1;
            using (SqlConnection con = new SqlConnection(DBConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Proc_ExamResult_SaveAnswers", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                    cmd.Parameters.Add("@ExamId", SqlDbType.Int).Value = examId;
                    cmd.Parameters.Add("@AnswerXML", SqlDbType.Xml).Value = answerSheetXML;
                    cmd.Parameters.Add("@Score", SqlDbType.Int).Value = score;

                    cmd.Parameters.Add("@Status", SqlDbType.Int);
                    cmd.Parameters["@Status"].Direction = ParameterDirection.Output;

                    con.Open();
                    cmd.ExecuteNonQuery();

                    status = Convert.ToInt32(cmd.Parameters["@Status"].Value);
                }
            }
            return status;
        }
    }
}