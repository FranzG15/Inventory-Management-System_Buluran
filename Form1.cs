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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProducts.Rows.Clear();

            dgvProducts.Rows.Add(
                "P1", "Rice", "Food", 50, "₱45.00", "In Stock");

            dgvProducts.Rows.Add(
                "P2", "Soap", "Personal Care", 25, "₱40.00", "In Stock");

            dgvProducts.Rows.Add(
                "P3", "Tuna (can)", "Food", 5, "₱30.00", "Low Stock");

            dgvProducts.Rows.Add(
                "P4", "Shampoo", "Personal Care", 18, "₱85.00", "In Stock");

            dgvProducts.Rows.Add(
                "P5", "Biscuits", "Snacks", 8, "₱60.00", "Low Stock");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReportsForm reports = new ReportsForm();
            reports.Show();

            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.Show();

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsForm products = new ProductsForm();

            products.Show();
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
    }
}
