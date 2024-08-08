using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsAuthenticateProject.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Optional: Check if the user is already logged in
            if (User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Default.aspx");
            }

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // Retrieve username and password from the form
            string username = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            // Validate credentials (this should ideally be against a database or user store)
            if (Membership.ValidateUser(username, password))
            {
                FormsAuthentication.SetAuthCookie(username, false);
                Response.Redirect(FormsAuthentication.GetRedirectUrl(username, false));
            }
            else
            {
                lblMsg.Text = "Invalid username or password.";
                lblMsg.Visible = true;
            }
        }
    }
}