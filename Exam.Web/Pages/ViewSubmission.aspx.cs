using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam.Web.Pages
{
    public partial class ViewSubmission : System.Web.UI.Page
    {
        public int ExamId
        {
            get
            {
                return Convert.ToInt32(Request["ExamId"]);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            aBack.HRef = string.Format("{0}?ExamId={1}", URLDefs.Submissions, this.ExamId);
        }
    }
}