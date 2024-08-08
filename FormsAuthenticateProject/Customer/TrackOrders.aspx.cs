using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace FormsAuthenticateProject.Customer
{
    public partial class TrackOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateOrders();
            }
        }

        private void PopulateOrders()
        {
            ddlOrderID.Items.Clear();
            using (SqlConnection con = new SqlConnection("Server=COMFYYYYYY;Database=HeliSoundDB;Trusted_Connection=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT OrderID FROM Orders WHERE UserID = @UserID", con);
                cmd.Parameters.AddWithValue("@UserID", GetCurrentUserID());
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                ddlOrderID.DataSource = reader;
                ddlOrderID.DataTextField = "OrderID";
                ddlOrderID.DataValueField = "OrderID";
                ddlOrderID.DataBind();
                con.Close();
            }
            ddlOrderID.Items.Insert(0, new ListItem("Select an order", ""));
        }

        protected void ddlOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateOrderDetails();
        }

        private void PopulateOrderDetails()
        {
            if (ddlOrderID.SelectedIndex > 0)
            {
                using (SqlConnection con = new SqlConnection("Server=COMFYYYYYY;Database=HeliSoundDB;Trusted_Connection=True"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT ProductName, Quantity, Price FROM OrderDetails WHERE OrderID = @OrderID", con);
                    cmd.Parameters.AddWithValue("@OrderID", ddlOrderID.SelectedValue);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    gvOrderDetails.DataSource = dt;
                    gvOrderDetails.DataBind();
                    con.Close();
                }
            }
        }

        private int GetCurrentUserID()
        {
            // Placeholder function to get the current user's ID
            // Replace with actual logic to get the current user's ID
            return 1; // Assuming 1 is the current user's ID
        }
    }
}
