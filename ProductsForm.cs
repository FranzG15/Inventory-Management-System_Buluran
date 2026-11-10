using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_Management_System
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();

            this.Load += ProductsForm_Load;
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            dgvProducts.Rows.Clear();

            dgvProducts.Rows.Add("P1", "Rice", "Food", 50, "₱45.00", "In Stock");
            dgvProducts.Rows.Add("P2", "Soap", "Personal Care", 25, "₱40.00", "In Stock");
            dgvProducts.Rows.Add("P3", "Tuna (can)", "Food", 5, "₱30.00", "Low Stock");
            dgvProducts.Rows.Add("P4", "Shampoo", "Personal Care", 18, "₱85.00", "In Stock");
            dgvProducts.Rows.Add("P5", "Biscuits", "Snacks", 8, "₱60.00", "Low Stock");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();

            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = Microsoft.VisualBasic.Interaction.InputBox(
        "Enter Product ID:", "Add Product");

            if (string.IsNullOrWhiteSpace(id)) return;

            // Check if the Product ID already exists
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.Cells[0].Value != null &&
                    row.Cells[0].Value.ToString().Equals(id,
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Product ID already exists!");
                    return;
                }
            }

            string name = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter Product Name:", "Add Product");

            if (string.IsNullOrWhiteSpace(name)) return;

            string category = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter Category:", "Add Product");

            if (string.IsNullOrWhiteSpace(category)) return;

            string quantityText = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter Quantity:", "Add Product");

            if (!int.TryParse(quantityText, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            string priceText = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter Price:", "Add Product");

            if (!decimal.TryParse(priceText, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            string status = quantity <= 10 ? "Low Stock" : "In Stock";

            dgvProducts.Rows.Add(
                id, name, category, quantity,
                "₱" + price.ToString("0.00"), status);

            MessageBox.Show("Product added successfully!");
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                dgvProducts.Rows.Remove(
                    dgvProducts.SelectedRows[0]);

                MessageBox.Show("Product deleted successfully!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to edit.");
                return;
            }

            DataGridViewRow row = dgvProducts.SelectedRows[0];

            string id = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter Product ID:", "Edit Product",
                row.Cells[0].Value.ToString());

            if (string.IsNullOrWhiteSpace(id)) return;

            string name = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter Product Name:", "Edit Product",
                row.Cells[1].Value.ToString());

            if (string.IsNullOrWhiteSpace(name)) return;

            string category = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter Category:", "Edit Product",
                row.Cells[2].Value.ToString());

            if (string.IsNullOrWhiteSpace(category)) return;

            string quantityText = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter Quantity:", "Edit Product",
                row.Cells[3].Value.ToString());

            if (!int.TryParse(quantityText, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            string priceText = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter Price:", "Edit Product",
                row.Cells[4].Value.ToString().Replace("₱", ""));

            if (!decimal.TryParse(priceText, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            // Check for duplicate Product ID
            foreach (DataGridViewRow existingRow in dgvProducts.Rows)
            {
                if (existingRow.Index != row.Index &&
                    existingRow.Cells[0].Value != null &&
                    existingRow.Cells[0].Value.ToString().Equals(
                        id, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Product ID already exists!");
                    return;
                }
            }

            row.Cells[0].Value = id;
            row.Cells[1].Value = name;
            row.Cells[2].Value = category;
            row.Cells[3].Value = quantity;
            row.Cells[4].Value = "₱" + price.ToString("0.00");
            row.Cells[5].Value = quantity <= 10 ? "Low Stock" : "In Stock";

            MessageBox.Show("Product updated successfully!");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.IsNewRow) continue;

                bool found = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null &&
                        cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        found = true;
                        break;
                    }
                }

                row.Visible = found;
            }
        }

        private void btnStockin_Click(object sender, EventArgs e)
        {
            StockInForm stockIn = new StockInForm();
            stockIn.Show();
        }

        private void btnStockout_Click(object sender, EventArgs e)
        {
            StockOutForm stockOut = new StockOutForm();
            stockOut.Show();

            this.Hide();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            SuppliersForm suppliers = new SuppliersForm();
            suppliers.Show();

            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reports = new ReportsForm();
            reports.Show();

            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.Show();

            this.Hide();
        }
    }
}
