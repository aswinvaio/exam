using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Exam.Web
{
    public class Utils
    {
        public static string TimeString(int time)
        {
            string format  = ConfigurationManager.AppSettings.Get("TimeIn");
            switch (format)
            {
                case "S":
                case "s": return string.Format("{0} Sec", time);
                case "M":
                case "m": return string.Format("{0} Min", time/60);
                case "H":
                case "h": return string.Format("{0} Hrs", time/3600);
                default: return string.Format("{0} Min", time / 60);
            }
            
        }
    }
}