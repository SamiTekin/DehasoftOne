namespace DehasoftOne.Winforms
{
    partial class MainForm
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
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.tblLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCustomers
            // 
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCustomers.Location = new System.Drawing.Point(10, 10);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(10);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(208, 110);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Text = "Müşteriler";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProducts.Location = new System.Drawing.Point(238, 10);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(10);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(208, 110);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "Ürünler";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrders.Location = new System.Drawing.Point(466, 10);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(10);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(208, 110);
            this.btnOrders.TabIndex = 0;
            this.btnOrders.Text = "Siparişler";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // tblLayoutPanelMain
            // 
            this.tblLayoutPanelMain.ColumnCount = 3;
            this.tblLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelMain.Controls.Add(this.btnCustomers, 0, 0);
            this.tblLayoutPanelMain.Controls.Add(this.btnOrders, 2, 0);
            this.tblLayoutPanelMain.Controls.Add(this.btnProducts, 1, 0);
            this.tblLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelMain.Name = "tblLayoutPanelMain";
            this.tblLayoutPanelMain.RowCount = 2;
            this.tblLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelMain.Size = new System.Drawing.Size(684, 261);
            this.tblLayoutPanelMain.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.tblLayoutPanelMain);
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tblLayoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCustomers;
        private Button btnProducts;
        private Button btnOrders;
        private TableLayoutPanel tblLayoutPanelMain;
    }
}
