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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            txtSystemName.Text = "Inventory Management System";
            numLowStock.Value = 10;
            cmbCurrency.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblCurrency_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSystemName.Text))
            {
                MessageBox.Show("Please enter a system name.");
                return;
            }

            if (cmbCurrency.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a currency.");
                return;
            }

            string systemName = txtSystemName.Text;
            int lowStockLevel = (int)numLowStock.Value;
            string currency = cmbCurrency.SelectedItem.ToString();

            MessageBox.Show(
                "Settings saved successfully!\n\n" +
                "System Name: " + systemName +
                "\nLow Stock Level: " + lowStockLevel +
                "\nCurrency: " + currency
            );
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();

            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reports = new ReportsForm();
            reports.Show();

            this.Hide();
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

            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
           ProductsForm products = new ProductsForm();
            products.Show();

            this.Hide();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
