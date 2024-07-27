using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsAuthenticateProject.Customer
{
    public partial class OrderProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadSuppliers();
                LoadExpiryDates();
            }

        }

        private void LoadSuppliers()
        {
            // Example: Load suppliers from the database into ddlSupplier
            // Replace with actual data access logic
            ddlSupplier.Items.Clear();
            ddlSupplier.Items.Add(new ListItem("Select a supplier", ""));
            ddlSupplier.Items.Add(new ListItem("Sony", "1"));
            ddlSupplier.Items.Add(new ListItem("Samsung", "2"));
            ddlSupplier.Items.Add(new ListItem("LG", "3"));
        }

        private void LoadCategories(int supplierId)
        {
            // Example: Load categories based on supplierId from the database into ddlCategory
            // Replace with actual data access logic
            ddlCategory.Items.Clear();
            ddlCategory.Items.Add(new ListItem("Select a category", ""));
            if (supplierId == 1) // Example for Sony
            {
                ddlCategory.Items.Add(new ListItem("Televisions", "1"));
                ddlCategory.Items.Add(new ListItem("Speakers", "2"));
            }
            else if (supplierId == 2) // Example for Samsung
            {
                ddlCategory.Items.Add(new ListItem("Home Theatres", "3"));
                ddlCategory.Items.Add(new ListItem("Televisions", "1"));
            }
        }

        private void LoadProducts(int categoryId)
        {
            // Example: Load products based on categoryId from the database into ddlProduct
            // Replace with actual data access logic
            ddlProduct.Items.Clear();
            ddlProduct.Items.Add(new ListItem("Select a product", ""));
            if (categoryId == 1) // Example for Televisions
            {
                ddlProduct.Items.Add(new ListItem("Sony Bravia", "101"));
                ddlProduct.Items.Add(new ListItem("Samsung Smart TV", "102"));
            }
            else if (categoryId == 2) // Example for Speakers
            {
                ddlProduct.Items.Add(new ListItem("Sony Home Speaker", "201"));
                ddlProduct.Items.Add(new ListItem("LG Soundbar", "202"));
            }
        }

        private void LoadExpiryDates()
        {
            // Load months
            ddlExpiryMonth.Items.Clear();
            for (int month = 1; month <= 12; month++)
            {
                ddlExpiryMonth.Items.Add(new ListItem(month.ToString("D2"), month.ToString()));
            }

            // Load years
            ddlExpiryYear.Items.Clear();
            int currentYear = DateTime.Now.Year;
            for (int year = currentYear; year <= currentYear + 10; year++)
            {
                ddlExpiryYear.Items.Add(new ListItem(year.ToString(), year.ToString()));
            }
        }

        protected void ddlSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            int supplierId = int.Parse(ddlSupplier.SelectedValue);
            LoadCategories(supplierId);
        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryId = int.Parse(ddlCategory.SelectedValue);
            LoadProducts(categoryId);
        }

        protected void btnSaveOrder_Click(object sender, EventArgs e)
        {
            // Example: Get the selected values and input data
            string productId = ddlProduct.SelectedValue;
            string cardHolderName = txtCardHolderName.Text.Trim();
            string cardType = ddlCardType.SelectedValue;
            string cardNumber = txtCardNumber.Text.Trim();
            string securityCode = txtSecurityCode.Text.Trim();
            string expiryMonth = ddlExpiryMonth.SelectedValue;
            string expiryYear = ddlExpiryYear.SelectedValue;
            string houseNumber = txtHouseNumber.Text.Trim();
            string street = txtStreet.Text.Trim();
            string apartment = txtApartment.Text.Trim();
            string city = txtCity.Text.Trim();
            string province = txtProvince.Text.Trim();
            string postalCode = txtPostalCode.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(productId) || string.IsNullOrEmpty(cardHolderName) || 
                string.IsNullOrEmpty(cardNumber) || string.IsNullOrEmpty(securityCode) || 
                string.IsNullOrEmpty(houseNumber) || string.IsNullOrEmpty(street) || 
                string.IsNullOrEmpty(city) || string.IsNullOrEmpty(province) || 
                string.IsNullOrEmpty(postalCode))
            {
                lblError.Text = "All fields are required.";
                lblError.Visible = true;
                return;
            }

            // Example: Process the order (e.g., save to database)
            // Replace with actual order processing logic
            bool isOrderSaved = SaveOrder(productId, cardHolderName, cardType, cardNumber, securityCode, expiryMonth, expiryYear, houseNumber, street, apartment, city, province, postalCode);

            if (isOrderSaved)
            {
                // Redirect to a confirmation page or show a success message
                Response.Redirect("~/Customer/OrderConfirmation.aspx");
            }
            else
            {
                lblError.Text = "There was an error processing your order. Please try again.";
                lblError.Visible = true;
            }
        }

        private bool SaveOrder(string productId, string cardHolderName, string cardType, string cardNumber, string securityCode, string expiryMonth, string expiryYear, string houseNumber, string street, string apartment, string city, string province, string postalCode)
        {
            // Replace with actual data saving logic, such as inserting into a database
            return true; // Placeholder indicating success
        }
    }
}