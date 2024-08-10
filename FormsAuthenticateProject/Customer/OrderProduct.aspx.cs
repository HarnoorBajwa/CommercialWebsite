using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace FormsAuthenticateProject.Customer
{
    public partial class OrderProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateSuppliers();
                PopulateExpiryMonths();
                PopulateExpiryYears();
            }
        }

        private void PopulateSuppliers()
        {
            ddlSupplier.Items.Clear();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["HeliSoundDBConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT SupplierID, CompanyName FROM Suppliers", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                ddlSupplier.DataSource = reader;
                ddlSupplier.DataTextField = "CompanyName";
                ddlSupplier.DataValueField = "SupplierID";
                ddlSupplier.DataBind();
                con.Close();
            }
            ddlSupplier.Items.Insert(0, new ListItem("Select a supplier", ""));
        }

        private void PopulateCategories()
        {
            ddlCategory.Items.Clear();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["HeliSoundDBConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT CategoryID, Description FROM Categories WHERE SupplierID = @SupplierID", con);
                cmd.Parameters.AddWithValue("@SupplierID", ddlSupplier.SelectedValue);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                ddlCategory.DataSource = reader;
                ddlCategory.DataTextField = "Description";
                ddlCategory.DataValueField = "CategoryID";
                ddlCategory.DataBind();
                con.Close();
            }
            ddlCategory.Items.Insert(0, new ListItem("Select a category", ""));
        }

        private void PopulateProducts()
        {
            ddlProduct.Items.Clear();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["HeliSoundDBConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT ProductID, ProductName FROM Products WHERE CategoryID = @CategoryID", con);
                cmd.Parameters.AddWithValue("@CategoryID", ddlCategory.SelectedValue);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                ddlProduct.DataSource = reader;
                ddlProduct.DataTextField = "ProductName";
                ddlProduct.DataValueField = "ProductID";
                ddlProduct.DataBind();
                con.Close();
            }
            ddlProduct.Items.Insert(0, new ListItem("Select a product", ""));
        }

        private void PopulateExpiryMonths()
        {
            ddlExpiryMonth.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                ddlExpiryMonth.Items.Add(new ListItem(i.ToString("00"), i.ToString()));
            }
        }

        private void PopulateExpiryYears()
        {
            ddlExpiryYear.Items.Clear();
            int currentYear = DateTime.Now.Year;
            for (int i = 0; i < 10; i++)
            {
                ddlExpiryYear.Items.Add(new ListItem((currentYear + i).ToString(), (currentYear + i).ToString()));
            }
        }

        protected void ddlSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateCategories();
        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateProducts();
        }

        protected void btnSaveOrder_Click(object sender, EventArgs e)
        {
            // Implement save order logic here
        }
    }
}
