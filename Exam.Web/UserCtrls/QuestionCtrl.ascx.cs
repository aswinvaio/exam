using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam.Web.UserCtrls
{
    public partial class QuestionCtrl : System.Web.UI.UserControl
    {
        public int ExamId
        {
            get
            {
                return Convert.ToInt32(Request["ExamId"]);
            }
        }

        //TODO Need to get it from session
        public int UserId 
        {
            get
            {
                return Convert.ToInt32(Request["UserId"]);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void repOptions_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

        }
    }
}