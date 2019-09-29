using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Exam.Lib.DBHelper
{
    public class ExamDBHelaper
    {
        
        public static string GetExam(int examId)
        {
            string examXML = null;
            using (SqlConnection con = new SqlConnection(DBConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Proc_Exam_Get", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = examId;
                    cmd.Parameters.Add("@ExamXML", SqlDbType.NVarChar, -1); //MAX
                    cmd.Parameters["@ExamXML"].Direction = ParameterDirection.Output;

                    con.Open();
                    cmd.ExecuteNonQuery();

                    examXML = Convert.ToString(cmd.Parameters["@ExamXML"].Value);
                }
            }
            return examXML;         
        }

        public static int? PutExam(string text)
        {
            using (SqlConnection con = new SqlConnection(DBConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Proc_Exam_Instert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var param = cmd.Parameters.Add("@ExamXML", SqlDbType.NVarChar, -1); //MAX
                    param.Direction = ParameterDirection.Input;
                    param.Value = text;

                    cmd.Parameters.Add("@ID", SqlDbType.Int);
                    cmd.Parameters["@ID"].Direction = ParameterDirection.Output;

                    con.Open();
                    cmd.ExecuteNonQuery();

                    int? examId = Convert.ToInt32(cmd.Parameters["@ID"].Value);
                    return examId;
                }
            }
        }
    }
}