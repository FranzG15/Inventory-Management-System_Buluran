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
    public partial class StockInForm : Form
    {
        public StockInForm()
        {
            InitializeComponent();

            this.Load += StockInForm_Load;
        }

        private void StockInForm_Load(object sender, EventArgs e)
        {
            dgvStockIn.Rows.Clear();

            // Sample incoming stock records
            dgvStockIn.Rows.Add(
                "SI001", "P1", "Rice", 20, "ABC Trading", "11/08/2026");

            dgvStockIn.Rows.Add(
                "SI002", "P2", "Soap", 15, "XYZ Supplies", "11/08/2026");

            dgvStockIn.Rows.Add(
                "SI003", "P3", "Tuna (can)", 30, "ABC Trading", "11/08/2026");

            dgvStockIn.Rows.Add(
                "SI004", "P4", "Shampoo", 10, "Beauty Products Co.", "11/08/2026");

            dgvStockIn.Rows.Add(
                "SI005", "P5", "Biscuits", 25, "Food Distributors", "11/08/2026");
        }

        private void txtSearchStockIn_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchStockIn.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dgvStockIn.Rows)
            {
                if (row.IsNewRow)
                    continue;

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

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsForm products = new ProductsForm();
            products.Show();

            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();

            this.Close();
        }

        private void StockInForm_Load_1(object sender, EventArgs e)
        {

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
