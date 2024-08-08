using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace FormsAuthenticateProject.Administration
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Perform any initialization that is required only once
                InitializePage();
            }

        }

        private void InitializePage()
        {
            
            // Check if the user is an admini
            if (!UserIsAdmin())
            {
                // If not an admin, redirect to the login page
                Response.Redirect("~/Account/Login.aspx");
            }
            
        }

        private bool UserIsAdmin()
        {
            // Get the current user's email
            string email = Context.User.Identity.Name;
           

            try
            {
                using (SqlConnection con = new SqlConnection("Server=COMFYYYYYY;Database=HeliSoundDB;Trusted_Connection=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT RoleName FROM UserRoles INNER JOIN Users ON UserRoles.RoleId = Users.RoleId WHERE Users.email = @Email", con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string roleName = reader["RoleName"].ToString();
                                if (roleName.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception and handle as necessary
                Response.Write("An error occurred: " + ex.Message);
            }

            return false;
        }
    }
}
