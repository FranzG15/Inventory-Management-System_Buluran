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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();

            this.Load += ReportsForm_Load;
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            dgvReports.Rows.Clear();

            dgvReports.Rows.Add("P1", "Rice", "Food", 70, 5, 65, "In Stock");
            dgvReports.Rows.Add("P2", "Soap", "Personal Care", 40, 3, 37, "In Stock");
            dgvReports.Rows.Add("P3", "Tuna (can)", "Food", 30, 10, 20, "In Stock");
            dgvReports.Rows.Add("P4", "Shampoo", "Personal Care", 28, 2, 26, "In Stock");
            dgvReports.Rows.Add("P5", "Biscuits", "Snacks", 25, 4, 21, "In Stock");
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearchStockOut_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchReport.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dgvReports.Rows)
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

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            SuppliersForm suppliers = new SuppliersForm();
            suppliers.Show();

            this.Hide();
        }

        private void btnStockout_Click(object sender, EventArgs e)
        {
            StockOutForm stockOut = new StockOutForm();
            stockOut.Show();

            this.Hide();
        }

        private void btnStockin_Click(object sender, EventArgs e)
        {
            StockInForm stockIn = new StockInForm();
            stockIn.Show();

            this.Close();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsForm products = new ProductsForm();
            products.Show();

            this.Close(); ;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();

            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.Show();

            this.Hide();
        }
    }
}
