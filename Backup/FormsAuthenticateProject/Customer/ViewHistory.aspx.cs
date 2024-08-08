using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsAuthenticateProject.Customer
{
    public partial class ViewHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadOrderHistory();
            }
        }

        private void LoadOrderHistory()
        {
            // Example: Fetch the customer's order history from the database
            // Replace this with actual data access logic
            string customerId = Context.User.Identity.Name; // Assuming the customer ID is stored in the username field

            // Example data (replace with actual database call)
            DataTable orderHistory = GetOrderHistory(customerId);

            gvOrderHistory.DataSource = orderHistory;
            gvOrderHistory.DataBind();
        }

        private DataTable GetOrderHistory(string customerId)
        {
            // Replace with actual logic to fetch data from your database
            // This is a placeholder for demonstration purposes
            DataTable table = new DataTable();
            table.Columns.Add("OrderDate", typeof(DateTime));
            table.Columns.Add("InvoiceNumber", typeof(string));
            table.Columns.Add("TotalAmount", typeof(decimal));
            table.Columns.Add("ShippedDate", typeof(DateTime));

            // Example rows (remove these and replace with actual data retrieval logic)
            table.Rows.Add(new DateTime(2023, 1, 15), "INV001", 299.99m, new DateTime(2023, 1, 17));
            table.Rows.Add(new DateTime(2023, 2, 10), "INV002", 149.99m, DBNull.Value); // DBNull.Value represents no shipped date yet

            return table;
        }
    }
}