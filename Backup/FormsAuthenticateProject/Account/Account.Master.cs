using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsAuthenticateProject.Account
{
    public partial class Account : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Context.User.Identity.IsAuthenticated)
                {
                    // Perform additional actions for authenticated users
                    // Example: Display welcome message, user-specific links, etc.
                    lblWelcome.Text = "Welcome, " + Context.User.Identity.Name + "!";
                }
                else
                {
                    // Redirect to the login page if the user is not authenticated
                    Response.Redirect("~/Account/Login.aspx");
                }
            }
        }
    
        protected void Logout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("~/Account/Login.aspx");
        }
        protected ContentPlaceHolder head;
        protected HtmlForm form1;
        protected ContentPlaceHolder ContentPlaceHolder1;
        protected Label lblWelcome;
        
    }
}