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
    }
}