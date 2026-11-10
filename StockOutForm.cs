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
    public partial class StockOutForm : Form
    {
        public StockOutForm()
        {
            InitializeComponent();

            this.Load += StockOutForm_Load;
        }

        private void StockOutForm_Load(object sender, EventArgs e)
        {
            dgvStockOut.Rows.Clear();

            dgvStockOut.Rows.Add("SO001", "P1", "Rice", 5, "Customer 1", "11/08/2026");
            dgvStockOut.Rows.Add("SO002", "P2", "Soap", 3, "Customer 2", "11/08/2026");
            dgvStockOut.Rows.Add("SO003", "P3", "Tuna (can)", 10, "Customer 3", "11/08/2026");
            dgvStockOut.Rows.Add("SO004", "P4", "Shampoo", 2, "Customer 4", "11/08/2026");
            dgvStockOut.Rows.Add("SO005", "P5", "Biscuits", 4, "Customer 5", "11/08/2026");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearchStockOut_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchStockOut.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dgvStockOut.Rows)
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();

            this.Close();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsForm products = new ProductsForm();
            products.Show();

            this.Close();
        }

        private void btnStockin_Click(object sender, EventArgs e)
        {
            StockInForm stockIn = new StockInForm();
            stockIn.Show();

            this.Close();
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
