using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsAuthenticateProject.Administration
{
    public partial class ProductManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadSuppliers();
                LoadCategories();
                LoadProducts();
            }

        }

        private void LoadSuppliers()
        {
            // Example: Load suppliers from the database into ddlSupplier
            // Replace with actual data access logic
            ddlSupplier.Items.Add(new ListItem("Supplier A", "1"));
            ddlSupplier.Items.Add(new ListItem("Supplier B", "2"));
        }

        private void LoadCategories()
        {
            // Example: Load categories from the database into ddlCategory
            // Replace with actual data access logic
            ddlCategory.Items.Add(new ListItem("Category X", "1"));
            ddlCategory.Items.Add(new ListItem("Category Y", "2"));
        }

        private void LoadProducts()
        {
            // Example: Load products from the database into gvProducts
            // Replace with actual data access logic
            gvProducts.DataSource = new[]
            {
                new { ProductID = 1, ProductName = "Product 1", SupplierName = "Supplier A", CategoryName = "Category X", Price = 10.00, Description = "Description 1" },
                new { ProductID = 2, ProductName = "Product 2", SupplierName = "Supplier B", CategoryName = "Category Y", Price = 20.00, Description = "Description 2" }
            };
            gvProducts.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // Save product details to the database
            string productName = txtProductName.Text.Trim();
            string supplierId = ddlSupplier.SelectedValue;
            string categoryId = ddlCategory.SelectedValue;
            string priceText = txtPrice.Text.Trim();
            string description = txtDescription.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(supplierId) || string.IsNullOrEmpty(categoryId) || string.IsNullOrEmpty(priceText))
            {
                // Display error message (optional)
                return;
            }

            // Convert price to double
            if (!double.TryParse(priceText, out double price))
            {
                // Display error message (optional)
                return;
            }

            // Example: Save to the database
            // Replace with actual data access logic
            // If editing, update the existing product; otherwise, insert a new product

            LoadProducts(); // Refresh the product list
            ClearForm();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtProductName.Text = string.Empty;
            ddlSupplier.SelectedIndex = -1;
            ddlCategory.SelectedIndex = -1;
            txtPrice.Text = string.Empty;
            txtDescription.Text = string.Empty;
        }

        protected void gvProducts_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvProducts.EditIndex = e.NewEditIndex;
            LoadProducts();
        }

        protected void gvProducts_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            // Update product in the database
            GridViewRow row = gvProducts.Rows[e.RowIndex];
            int productId = Convert.ToInt32(gvProducts.DataKeys[e.RowIndex].Values[0]);
            string productName = ((TextBox)row.FindControl("txtProductName")).Text.Trim();
            string supplierId = ((DropDownList)row.FindControl("ddlSupplier")).SelectedValue;
            string categoryId = ((DropDownList)row.FindControl("ddlCategory")).SelectedValue;
            string priceText = ((TextBox)row.FindControl("txtPrice")).Text.Trim();
            string description = ((TextBox)row.FindControl("txtDescription")).Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(supplierId) || string.IsNullOrEmpty(categoryId) || string.IsNullOrEmpty(priceText))
            {
                // Display error message (optional)
                return;
            }

            // Convert price to double
            if (!double.TryParse(priceText, out double price))
            {
                // Display error message (optional)
                return;
            }

            // Example: Update in the database
            // Replace with actual data access logic

            gvProducts.EditIndex = -1;
            LoadProducts(); // Refresh the product list
        }

        protected void gvProducts_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvProducts.EditIndex = -1;
            LoadProducts();
        }

        protected void gvProducts_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int productId = Convert.ToInt32(gvProducts.DataKeys[e.RowIndex].Values[0]);

            // Example: Delete from the database
            // Replace with actual data access logic

            LoadProducts(); // Refresh the product list
        }
    }
}