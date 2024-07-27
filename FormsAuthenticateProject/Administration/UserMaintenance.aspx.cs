using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsAuthenticateProject.Administration
{
    public partial class UserMaintenance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadUsers();
                LoadRoles();
            }

        }

        private void LoadUsers()
        {
            // Example: Load users from the database into gvUsers
            // Replace with actual data access logic
            gvUsers.DataSource = new[]
            {
                new { UserID = 1, Username = "admin", FirstName = "Admin", LastName = "User", Email = "admin@example.com", Role = "Admin" },
                new { UserID = 2, Username = "johndoe", FirstName = "John", LastName = "Doe", Email = "johndoe@example.com", Role = "User" }
            };
            gvUsers.DataBind();
        }

        private void LoadRoles()
        {
            // Example: Load roles from the database into ddlRole
            // Replace with actual data access logic
            ddlRole.Items.Clear();
            ddlRole.Items.Add(new ListItem("Admin", "Admin"));
            ddlRole.Items.Add(new ListItem("User", "User"));
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string role = ddlRole.SelectedValue;

            // Validate inputs
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email))
            {
                // Display error message (optional)
                return;
            }

            // Example: Save or update user in the database
            // Replace with actual data access logic
            // If UserID is set, update the existing user; otherwise, insert a new user

            ClearForm();
            LoadUsers(); // Refresh the user list
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtUsername.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            ddlRole.SelectedIndex = -1;
        }

        protected void gvUsers_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvUsers.EditIndex = e.NewEditIndex;
            LoadUsers();
        }

        protected void gvUsers_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            // Update user details in the database
            GridViewRow row = gvUsers.Rows[e.RowIndex];
            int userId = Convert.ToInt32(gvUsers.DataKeys[e.RowIndex].Values[0]);
            string username = ((TextBox)row.FindControl("txtUsername")).Text.Trim();
            string firstName = ((TextBox)row.FindControl("txtFirstName")).Text.Trim();
            string lastName = ((TextBox)row.FindControl("txtLastName")).Text.Trim();
            string email = ((TextBox)row.FindControl("txtEmail")).Text.Trim();
            string role = ((DropDownList)row.FindControl("ddlRole")).SelectedValue;

            // Validate inputs
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email))
            {
                // Display error message (optional)
                return;
            }

            // Example: Update user in the database
            // Replace with actual data access logic

            gvUsers.EditIndex = -1;
            LoadUsers(); // Refresh the user list
        }

        protected void gvUsers_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvUsers.EditIndex = -1;
            LoadUsers();
        }

        protected void gvUsers_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int userId = Convert.ToInt32(gvUsers.DataKeys[e.RowIndex].Values[0]);

            // Example: Delete user from the database
            // Replace with actual data access logic

            LoadUsers(); // Refresh the user list
        }
    }
}