using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Exam.Lib.DBHelper
{
    public class UserDBHelper
    {
        public static bool IsCredentialsValid(string username, string password)
        {
            var conn = new SqlConnection(ConfigurationManager.AppSettings.Get("ConnectionString"));
            conn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            string sql = string.Empty, output = string.Empty;

            sql = "SELECT 1 FROM [User] WHERE UserName='" + username + "' AND [Password]='" + password + "'";

            command = new SqlCommand(sql, conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                output = output + dataReader.GetValue(0);
            }

            if (string.Compare(output, "1") == 0)
            {
                return true;
            }

            return false;
        }

        public static bool IsUserAdmin(string username)
        {
            var conn = new SqlConnection(ConfigurationManager.AppSettings.Get("ConnectionString"));
            conn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            string sql = string.Empty, output = string.Empty;

            sql = "SELECT 1 FROM [User] WHERE UserName='" + username + "' AND [Type] = 1";

            command = new SqlCommand(sql, conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                output = output + dataReader.GetValue(0);
            }

            if (string.Compare(output, "1") == 0)
            {
                return true;
            }

            return false;
        }
    }
}