using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Exam.Lib.DBHelper
{
    public class DBConnection
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings.Get("ConnectionString");
            }
        }
    }
}