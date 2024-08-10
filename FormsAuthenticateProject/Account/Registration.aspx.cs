using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsAuthenticateProject.Account
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Populate the secret question dropdown list
                dlSecretQuestion1.Items.Add("What is your mother's maiden name?");
                dlSecretQuestion1.Items.Add("What was the name of your first pet?");
                dlSecretQuestion1.Items.Add("What is your favorite movie?");
                // More questions can be added here
            }

        }
        protected void btnCreateProfile_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string email = txtEmailAddress.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string secretQuestion = dlSecretQuestion1.SelectedItem.Text;
            string secretAnswer = txtSecretAnswer1.Text.Trim();

            // Validate that all required fields are filled
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(firstName) ||
                string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(secretAnswer))
            {
                lblMsg.Text = "All fields are required.";
                lblMsg.Visible = true;
                return;
            }

            // Check if passwords match
            if (password != confirmPassword)
            {
                lblMsg.Text = "Passwords do not match.";
                lblMsg.Visible = true;
                return;
            }

            // Check if username already exists
            // Assuming a method UserExists that checks the existence of a user in the database
            if (UserExists(username))
            {
                lblMsg.Text = "Username already exists. Please choose another one.";
                lblMsg.Visible = true;
                return;
            }

            // Hash the password
            // Assuming a method HashPassword that hashes the password
            string hashedPassword = HashPassword(password);

            // Create the new user account
            // Assuming a method CreateUser that saves the user data to the database
            bool isUserCreated = CreateUser(username, hashedPassword, email, phoneNumber, firstName, lastName, secretQuestion, secretAnswer);

            if (isUserCreated)
            {
                lblMsg.Text = "Registration successful! You can now log in.";
                lblMsg.ForeColor = System.Drawing.Color.Green;
                lblMsg.Visible = true;

                // Redirect to login page or another page if needed
                Response.Redirect("~/Account/Login.aspx");
            }
            else
            {
                lblMsg.Text = "Registration failed. Please try again.";
                lblMsg.Visible = true;
            }

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            // Redirect to a different page, e.g., the home page
            Response.Redirect("~/Welcome.aspx");
        }

        private bool UserExists(string username)
        {
            // Implement logic to check if the username exists in the database
            return false;
        }

        private string HashPassword(string password)
        {
            // Implement password hashing logic
            return password; // Placeholder
        }

        private bool CreateUser(string username, string hashedPassword, string email, string phoneNumber, string firstName, string lastName, string secretQuestion, string secretAnswer)
        {
            // Implement logic to save user data to the database
            return true; // Placeholder
        }
    }
}