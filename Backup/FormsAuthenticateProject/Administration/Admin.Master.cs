using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsAuthenticateProject.Administration
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check if the user is authenticated
                if (Context.User.Identity.IsAuthenticated)
                {
                    // Display the user's name (assuming the user's name is stored in Context.User.Identity.Name)
                    lblName.Text = "Welcome, " + Context.User.Identity.Name;
                }
                else
                {
                    // Redirect to the login page if the user is not authenticated
                    Response.Redirect("~/Account/Login.aspx");
                }
            }

        }

         protected void lnkSignOut_Click(object sender, EventArgs e)
        {
            // Sign out the user
            FormsAuthentication.SignOut();

            // Redirect to the login page
            Response.Redirect("~/Account/Login.aspx");
        }
    }
}