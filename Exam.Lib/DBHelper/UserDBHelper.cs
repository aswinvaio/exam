using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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

        public static bool InsertUser(string fullname, string username, string password, string email, string mobile)
        {
            var conn = new SqlConnection(ConfigurationManager.AppSettings.Get("ConnectionString"));
            conn.Open();

            var command = new SqlCommand();
            command = conn.CreateCommand();
            command.CommandText = @"INSERT INTO [User] (UserName, FullName, Password, Email, Mobile) VALUES (@UserName, @FullName, @Password, @Email, @Mobile)";
            command.Parameters.Add("@UserName", SqlDbType.NVarChar);
            command.Parameters["@UserName"].Value = username;
            command.Parameters.Add("@FullName", SqlDbType.NVarChar);
            command.Parameters["@FullName"].Value = fullname;
            command.Parameters.Add("@Password", SqlDbType.NVarChar);
            command.Parameters["@Password"].Value = password;
            command.Parameters.Add("@Email", SqlDbType.NVarChar);
            command.Parameters["@Email"].Value = email;
            command.Parameters.Add("@Mobile", SqlDbType.NVarChar);
            command.Parameters["@Mobile"].Value = mobile;
            int rowCount = 0;
            try
            {
                rowCount = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            conn.Close();

            return rowCount > 0;
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