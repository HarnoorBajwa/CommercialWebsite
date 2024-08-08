using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsAuthenticateProject.Customer
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Load secret questions into ddlSecretQuestion
                LoadSecretQuestions();
            }

        }
        private void LoadSecretQuestions()
        {
            // Example: Load secret questions from the database
            // Replace with actual data access logic
            ddlSecretQuestion.Items.Clear();
            ddlSecretQuestion.Items.Add(new ListItem("What is your mother's maiden name?", "1"));
            ddlSecretQuestion.Items.Add(new ListItem("What was the name of your first pet?", "2"));
            ddlSecretQuestion.Items.Add(new ListItem("What was the name of your first school?", "3"));
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string selectedQuestion = ddlSecretQuestion.SelectedValue;
            string secretAnswer = txtSecretAnswer.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            // Validate the inputs
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(secretAnswer) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                lblError.Text = "All fields are required.";
                lblError.Visible = true;
                return;
            }

            if (newPassword != confirmPassword)
            {
                lblError.Text = "New passwords do not match.";
                lblError.Visible = true;
                return;
            }

            // Example: Validate email and secret question/answer from the database
            // Replace with actual data access logic
            if (ValidateUser(email, selectedQuestion, secretAnswer))
            {
                // Encrypt the new password
                string encryptedPassword = EncryptPassword(newPassword);

                // Example: Update the password in the database
                // Replace with actual data access logic
                bool isUpdated = UpdatePassword(email, encryptedPassword);

                if (isUpdated)
                {
                    // Redirect to login page or show success message
                    Response.Redirect("~/Account/Login.aspx");
                }
                else
                {
                    lblError.Text = "Error updating password. Please try again.";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Invalid email or secret answer.";
                lblError.Visible = true;
            }
        }

        private bool ValidateUser(string email, string questionId, string secretAnswer)
        {
            // Replace with logic to validate the user based on email, question ID, and secret answer
            // Example: Check the database to see if the email, question, and answer match
            return true; // Placeholder
        }

        private string EncryptPassword(string password)
        {
            // Implement your password encryption logic here
            // Example: Use a hashing algorithm to encrypt the password
            return password; // Placeholder for encrypted password
        }

        private bool UpdatePassword(string email, string encryptedPassword)
        {
            // Replace with logic to update the user's password in the database
            // Example: Update the database with the new encrypted password
            return true; // Placeholder
        }


    }
}