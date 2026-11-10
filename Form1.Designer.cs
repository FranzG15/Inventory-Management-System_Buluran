namespace Information_Management_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnStockout = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnStockin = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlStockout = new System.Windows.Forms.Panel();
            this.lblStockouts = new System.Windows.Forms.Label();
            this.lblStockout = new System.Windows.Forms.Label();
            this.pnlStockin = new System.Windows.Forms.Panel();
            this.lblStockIns = new System.Windows.Forms.Label();
            this.lblStockin = new System.Windows.Forms.Label();
            this.pnlLowstock = new System.Windows.Forms.Panel();
            this.lblLowStocks = new System.Windows.Forms.Label();
            this.lblLowstock = new System.Windows.Forms.Label();
            this.pnlTotalProduct = new System.Windows.Forms.Panel();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.lblTotalProduct = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.pnlStockout.SuspendLayout();
            this.pnlStockin.SuspendLayout();
            this.pnlLowstock.SuspendLayout();
            this.pnlTotalProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(168)))));
            this.panelSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSidebar.Controls.Add(this.btnSettings);
            this.panelSidebar.Controls.Add(this.btnReports);
            this.panelSidebar.Controls.Add(this.btnSuppliers);
            this.panelSidebar.Controls.Add(this.btnStockout);
            this.panelSidebar.Controls.Add(this.btnProducts);
            this.panelSidebar.Controls.Add(this.btnStockin);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(220, 661);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSettings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(22, 525);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(170, 60);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnReports
            // 
            this.btnReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReports.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(22, 442);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(170, 60);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuppliers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.Location = new System.Drawing.Point(22, 362);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(170, 60);
            this.btnSuppliers.TabIndex = 5;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnStockout
            // 
            this.btnStockout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStockout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStockout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockout.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockout.Location = new System.Drawing.Point(22, 272);
            this.btnStockout.Name = "btnStockout";
            this.btnStockout.Size = new System.Drawing.Size(170, 60);
            this.btnStockout.TabIndex = 4;
            this.btnStockout.Text = "StockOut";
            this.btnStockout.UseVisualStyleBackColor = false;
            this.btnStockout.Click += new System.EventHandler(this.btnStockout_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProducts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Location = new System.Drawing.Point(22, 93);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(170, 60);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnStockin
            // 
            this.btnStockin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStockin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStockin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockin.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockin.Location = new System.Drawing.Point(22, 182);
            this.btnStockin.Name = "btnStockin";
            this.btnStockin.Size = new System.Drawing.Size(170, 60);
            this.btnStockin.TabIndex = 2;
            this.btnStockin.Text = "StockIn";
            this.btnStockin.UseVisualStyleBackColor = false;
            this.btnStockin.Click += new System.EventHandler(this.btnStockin_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDashboard.Location = new System.Drawing.Point(22, 7);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(170, 60);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(166)))), ((int)(((byte)(111)))));
            this.panelMain.Controls.Add(this.dgvProducts);
            this.panelMain.Controls.Add(this.pnlStockout);
            this.panelMain.Controls.Add(this.pnlStockin);
            this.panelMain.Controls.Add(this.pnlLowstock);
            this.panelMain.Controls.Add(this.pnlTotalProduct);
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(220, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(864, 661);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.Category,
            this.Quantity,
            this.Price,
            this.Status});
            this.dgvProducts.Location = new System.Drawing.Point(27, 231);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(820, 400);
            this.dgvProducts.TabIndex = 3;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Product ID";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // pnlStockout
            // 
            this.pnlStockout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlStockout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStockout.Controls.Add(this.lblStockouts);
            this.pnlStockout.Controls.Add(this.lblStockout);
            this.pnlStockout.Location = new System.Drawing.Point(651, 84);
            this.pnlStockout.Name = "pnlStockout";
            this.pnlStockout.Size = new System.Drawing.Size(151, 127);
            this.pnlStockout.TabIndex = 2;
            // 
            // lblStockouts
            // 
            this.lblStockouts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStockouts.AutoSize = true;
            this.lblStockouts.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockouts.Location = new System.Drawing.Point(60, 66);
            this.lblStockouts.Name = "lblStockouts";
            this.lblStockouts.Size = new System.Drawing.Size(24, 29);
            this.lblStockouts.TabIndex = 4;
            this.lblStockouts.Text = "8";
            // 
            // lblStockout
            // 
            this.lblStockout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStockout.AutoSize = true;
            this.lblStockout.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockout.Location = new System.Drawing.Point(20, 25);
            this.lblStockout.Name = "lblStockout";
            this.lblStockout.Size = new System.Drawing.Size(110, 29);
            this.lblStockout.TabIndex = 4;
            this.lblStockout.Text = "Stock Out";
            // 
            // pnlStockin
            // 
            this.pnlStockin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlStockin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStockin.Controls.Add(this.lblStockIns);
            this.pnlStockin.Controls.Add(this.lblStockin);
            this.pnlStockin.Location = new System.Drawing.Point(442, 84);
            this.pnlStockin.Name = "pnlStockin";
            this.pnlStockin.Size = new System.Drawing.Size(151, 127);
            this.pnlStockin.TabIndex = 2;
            // 
            // lblStockIns
            // 
            this.lblStockIns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStockIns.AutoSize = true;
            this.lblStockIns.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockIns.Location = new System.Drawing.Point(63, 66);
            this.lblStockIns.Name = "lblStockIns";
            this.lblStockIns.Size = new System.Drawing.Size(35, 29);
            this.lblStockIns.TabIndex = 3;
            this.lblStockIns.Text = "12";
            // 
            // lblStockin
            // 
            this.lblStockin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStockin.AutoSize = true;
            this.lblStockin.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockin.Location = new System.Drawing.Point(29, 25);
            this.lblStockin.Name = "lblStockin";
            this.lblStockin.Size = new System.Drawing.Size(91, 29);
            this.lblStockin.TabIndex = 2;
            this.lblStockin.Text = "Stock In";
            // 
            // pnlLowstock
            // 
            this.pnlLowstock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLowstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLowstock.Controls.Add(this.lblLowStocks);
            this.pnlLowstock.Controls.Add(this.lblLowstock);
            this.pnlLowstock.Location = new System.Drawing.Point(234, 84);
            this.pnlLowstock.Name = "pnlLowstock";
            this.pnlLowstock.Size = new System.Drawing.Size(151, 127);
            this.pnlLowstock.TabIndex = 2;
            // 
            // lblLowStocks
            // 
            this.lblLowStocks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLowStocks.AutoSize = true;
            this.lblLowStocks.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStocks.Location = new System.Drawing.Point(67, 66);
            this.lblLowStocks.Name = "lblLowStocks";
            this.lblLowStocks.Size = new System.Drawing.Size(24, 29);
            this.lblLowStocks.TabIndex = 2;
            this.lblLowStocks.Text = "3";
            // 
            // lblLowstock
            // 
            this.lblLowstock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLowstock.AutoSize = true;
            this.lblLowstock.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowstock.Location = new System.Drawing.Point(22, 25);
            this.lblLowstock.Name = "lblLowstock";
            this.lblLowstock.Size = new System.Drawing.Size(112, 29);
            this.lblLowstock.TabIndex = 1;
            this.lblLowstock.Text = "Low Stock";
            // 
            // pnlTotalProduct
            // 
            this.pnlTotalProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTotalProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalProduct.Controls.Add(this.lblTotalProducts);
            this.pnlTotalProduct.Controls.Add(this.lblTotalProduct);
            this.pnlTotalProduct.Location = new System.Drawing.Point(27, 84);
            this.pnlTotalProduct.Name = "pnlTotalProduct";
            this.pnlTotalProduct.Size = new System.Drawing.Size(151, 127);
            this.pnlTotalProduct.TabIndex = 1;
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalProducts.AutoSize = true;
            this.lblTotalProducts.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProducts.Location = new System.Drawing.Point(64, 66);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(24, 29);
            this.lblTotalProducts.TabIndex = 1;
            this.lblTotalProducts.Text = "6";
            // 
            // lblTotalProduct
            // 
            this.lblTotalProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalProduct.AutoSize = true;
            this.lblTotalProduct.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProduct.Location = new System.Drawing.Point(3, 25);
            this.lblTotalProduct.Name = "lblTotalProduct";
            this.lblTotalProduct.Size = new System.Drawing.Size(145, 29);
            this.lblTotalProduct.TabIndex = 0;
            this.lblTotalProduct.Text = "Total Product";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Gill Sans MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(163, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System_Buluran";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.pnlStockout.ResumeLayout(false);
            this.pnlStockout.PerformLayout();
            this.pnlStockin.ResumeLayout(false);
            this.pnlStockin.PerformLayout();
            this.pnlLowstock.ResumeLayout(false);
            this.pnlLowstock.PerformLayout();
            this.pnlTotalProduct.ResumeLayout(false);
            this.pnlTotalProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnStockout;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnStockin;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlStockout;
        private System.Windows.Forms.Panel pnlStockin;
        private System.Windows.Forms.Panel pnlLowstock;
        private System.Windows.Forms.Panel pnlTotalProduct;
        private System.Windows.Forms.Label lblTotalProduct;
        private System.Windows.Forms.Label lblLowStocks;
        private System.Windows.Forms.Label lblLowstock;
        private System.Windows.Forms.Label lblTotalProducts;
        private System.Windows.Forms.Label lblStockouts;
        private System.Windows.Forms.Label lblStockout;
        private System.Windows.Forms.Label lblStockIns;
        private System.Windows.Forms.Label lblStockin;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}

