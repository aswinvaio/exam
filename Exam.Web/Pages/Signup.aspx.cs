using Exam.Lib.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam.Web.Pages
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            divAlert.Attributes.Add("class", "alert col-sm-10 offset-sm-2");
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                litMessage.Text = "Name, Username and Password fields are mandatory.";
                divAlert.Attributes["class"] += " alert-danger";
                divAlert.Visible = true;
            }
            else
            {
                bool inserted = UserDBHelper.InsertUser(txtFullName.Text, txtUsername.Text, txtPassword.Text, txtEmail.Text, txtMobile.Text);
                if (!inserted)
                {
                    litMessage.Text = "Please choose another Username.";
                    divAlert.Attributes["class"] += " alert-danger";
                    divAlert.Visible = true;
                }
                else
                {
                    litMessage.Text = "Signup success for Username <strong>" + txtUsername.Text + "</strong>";
                    divAlert.Attributes["class"] += " alert-success";
                    divAlert.Visible = true;
                }
            }
        }
    }
}