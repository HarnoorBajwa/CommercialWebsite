using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;
using System.Web.UI;

namespace FormsAuthenticateProject.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Visible = false; // Ensure the message label is hidden initially
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                lblMsg.Text = "Please enter both email and password.";
                lblMsg.Visible = true;
                return;
            }

            try
            {
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["HeliSoundDBConnection"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE email=@Email AND passwordHash=@PasswordHash", con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@PasswordHash", password); // Hash the password
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataSet ds = new DataSet();
                            da.Fill(ds, "Users");
                            if (ds.Tables["Users"].Rows.Count == 0)
                            {
                                lblMsg.Text = "Invalid user.";
                                lblMsg.Visible = true;
                            }
                            else
                            {
                                // Set the authentication cookie
                                FormsAuthentication.SetAuthCookie(email, false);
                                // Get the RoleID from the Users table
                                int roleId = Convert.ToInt32(ds.Tables["Users"].Rows[0]["RoleID"]);

                                // Check the role of the user
                                using (SqlCommand roleCmd = new SqlCommand("SELECT RoleName FROM UserRoles WHERE RoleId = @RoleId", con))
                                {
                                    roleCmd.Parameters.AddWithValue("@RoleId", roleId);
                                    using (SqlDataReader reader = roleCmd.ExecuteReader())
                                    {
                                        bool isAdmin = false;
                                        bool isCustomer = false;
                                        bool isShipping = false;

                                        while (reader.Read())
                                        {
                                            string roleName = reader["RoleName"].ToString();
                                            if (roleName.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                                            {
                                                isAdmin = true;
                                                
                                            }
                                            else if (roleName.Equals("Customer", StringComparison.OrdinalIgnoreCase))
                                            {
                                                isCustomer = true;
                                            }
                                            else if (roleName.Equals("Shipping", StringComparison.OrdinalIgnoreCase))
                                            {
                                                isShipping = true;
                                            }

                                        }

                                        if (isAdmin)
                                        {
                                            Response.Write("User is an admin.");
                                            Response.Redirect("~/Administration/default.aspx");
                                        }
                                        else if (isCustomer)
                                        {
                                            Response.Write("User is a customer.");
                                            Response.Redirect("~/Customer/default.aspx");
                                        }
                                        else if (isShipping)
                                        {
                                            Response.Write("User is in shipping.");
                                            Response.Redirect("~/Shipping/default.aspx");
                                        }
                                        else
                                        {
                                            Response.Write("User role is not recognized.");
                                            Response.Redirect("~/Welcome.aspx");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = "An error occurred: " + ex.Message;
                lblMsg.Visible = true;
            }
        }
    }
}