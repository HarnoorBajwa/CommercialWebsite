using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsAuthenticateProject.Customer
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check if the user is authenticated
                if (Context.User.Identity.IsAuthenticated)
                {
                    // Optionally, you could load user-specific data or set a personalized message
                    // For example: lblWelcome.Text = "Welcome, " + Context.User.Identity.Name;
                }
                else
                {
                    // Redirect unauthenticated users to the login page
                    Response.Redirect("~/Account/Login.aspx");
                }
            }

        }
    }
}