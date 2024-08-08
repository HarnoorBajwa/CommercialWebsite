using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsAuthenticateProject
{
    public partial class Public : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Initialize any components or settings needed on first load
                // Example: Set up navigation links, check for user session, etc.
                SetupNavigation();
            }

        }

        private void SetupNavigation()
        {
            // Example: Add logic to customize navigation items or display user-specific info
            // For instance, highlight the current page in the navigation
            // Or check if a user is logged in and display a logout link, etc.
        }

        protected void lnkHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void lnkProducts_Click(object sender, EventArgs e)
        {
            Response.Redirect("Products.aspx");
        }

        protected void lnkAbout_Click(object sender, EventArgs e)
        {
            Response.Redirect("About.aspx");
        }

        protected void lnkContact_Click(object sender, EventArgs e)
        {
            Response.Redirect("Contact.aspx");
        }
    }
}