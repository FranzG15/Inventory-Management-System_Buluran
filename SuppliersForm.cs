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
    public partial class SuppliersForm : Form
    {
        public SuppliersForm()
        {
            InitializeComponent();

            this.Load += SuppliersForm_Load;
        }

        private void SuppliersForm_Load(object sender, EventArgs e)
        {
            dgvSuppliers.Rows.Clear();

            dgvSuppliers.Rows.Add("S001", "ABC Trading", "Juan Dela Cruz", "09123456789", "Malolos, Bulacan");
            dgvSuppliers.Rows.Add("S002", "XYZ Supplies", "Maria Santos", "09234567890", "Angat, Bulacan");
            dgvSuppliers.Rows.Add("S003", "Beauty Products Co.", "Pedro Reyes", "09345678901", "Guiguinto, Bulacan");
            dgvSuppliers.Rows.Add("S004", "Food Distributors", "Ana Garcia", "09456789012", "Baliwag, Bulacan");
            dgvSuppliers.Rows.Add("S005", "Global Merchandising", "Mark Lopez", "09567890123", "Meycauayan, Bulacan");
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = Microsoft.VisualBasic.Interaction.InputBox("Enter Supplier ID:");
            string name = Microsoft.VisualBasic.Interaction.InputBox("Enter Supplier Name:");
            string contact = Microsoft.VisualBasic.Interaction.InputBox("Enter Contact Person:");
            string phone = Microsoft.VisualBasic.Interaction.InputBox("Enter Phone Number:");
            string address = Microsoft.VisualBasic.Interaction.InputBox("Enter Address:");

            if (id == "" || name == "")
            {
                MessageBox.Show("Supplier ID and Name are required!");
                return;
            }

            foreach (DataGridViewRow row in dgvSuppliers.Rows)
            {
                if (row.Cells[0].Value != null &&
                    row.Cells[0].Value.ToString() == id)
                {
                    MessageBox.Show("Supplier ID already exists!");
                    return;
                }
            }

            dgvSuppliers.Rows.Add(id, name, contact, phone, address);

            MessageBox.Show("Supplier added successfully!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this supplier?",
                "Confirm Delete",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                dgvSuppliers.Rows.RemoveAt(
                    dgvSuppliers.SelectedRows[0].Index
                );
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier first.");
                return;
            }

            DataGridViewRow row = dgvSuppliers.SelectedRows[0];

            string id = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter Supplier ID:", "Edit Supplier", row.Cells[0].Value.ToString());

            string name = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter Supplier Name:", "Edit Supplier", row.Cells[1].Value.ToString());

            string contact = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter Contact Person:", "Edit Supplier", row.Cells[2].Value.ToString());

            string phone = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter Phone Number:", "Edit Supplier", row.Cells[3].Value.ToString());

            string address = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter Address:", "Edit Supplier", row.Cells[4].Value.ToString());

            if (id == "" || name == "")
            {
                MessageBox.Show("Supplier ID and Name are required!");
                return;
            }

            foreach (DataGridViewRow existingRow in dgvSuppliers.Rows)
            {
                if (existingRow.Index != row.Index &&
                    existingRow.Cells[0].Value != null &&
                    existingRow.Cells[0].Value.ToString() == id)
                {
                    MessageBox.Show("Supplier ID already exists!");
                    return;
                }
            }

            row.Cells[0].Value = id;
            row.Cells[1].Value = name;
            row.Cells[2].Value = contact;
            row.Cells[3].Value = phone;
            row.Cells[4].Value = address;

            MessageBox.Show("Supplier updated successfully!");
        }

        private void btnStockout_Click(object sender, EventArgs e)
        {
            StockOutForm stockOut = new StockOutForm();
            stockOut.Show();

            this.Hide();
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

            this.Close(); ;
        }

        private void btnStockin_Click(object sender, EventArgs e)
        {
            StockInForm stockIn = new StockInForm();
            stockIn.Show();

            this.Close();
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
