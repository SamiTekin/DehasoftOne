namespace DehasoftOne.Winforms
{
    partial class CustomersForm
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
            this.tblLayoutPanelCustomers = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbCustomerSurname = new System.Windows.Forms.TextBox();
            this.tbCustomerAddress = new System.Windows.Forms.TextBox();
            this.tbCustomerPhone = new System.Windows.Forms.TextBox();
            this.tbCustomerTCKN = new System.Windows.Forms.TextBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.tblLayoutPanelCustomers.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLayoutPanelCustomers
            // 
            this.tblLayoutPanelCustomers.ColumnCount = 3;
            this.tblLayoutPanelCustomers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelCustomers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblLayoutPanelCustomers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblLayoutPanelCustomers.Controls.Add(this.btnAddCustomer, 0, 2);
            this.tblLayoutPanelCustomers.Controls.Add(this.btnUpdateCustomer, 1, 2);
            this.tblLayoutPanelCustomers.Controls.Add(this.btnDeleteCustomer, 2, 2);
            this.tblLayoutPanelCustomers.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tblLayoutPanelCustomers.Controls.Add(this.dgvCustomers, 0, 0);
            this.tblLayoutPanelCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelCustomers.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelCustomers.Name = "tblLayoutPanelCustomers";
            this.tblLayoutPanelCustomers.RowCount = 3;
            this.tblLayoutPanelCustomers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelCustomers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLayoutPanelCustomers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblLayoutPanelCustomers.Size = new System.Drawing.Size(901, 582);
            this.tblLayoutPanelCustomers.TabIndex = 0;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddCustomer.Location = new System.Drawing.Point(3, 535);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(294, 44);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Ekle";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateCustomer.Location = new System.Drawing.Point(303, 535);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(294, 44);
            this.btnUpdateCustomer.TabIndex = 1;
            this.btnUpdateCustomer.Text = "Güncelle";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteCustomer.Location = new System.Drawing.Point(603, 535);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(295, 44);
            this.btnDeleteCustomer.TabIndex = 2;
            this.btnDeleteCustomer.Text = "Sil";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tblLayoutPanelCustomers.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbCustomerName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbCustomerSurname, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbCustomerAddress, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbCustomerPhone, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbCustomerTCKN, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 415);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(895, 114);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(226, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri Soyadı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.tableLayoutPanel2.SetRowSpan(this.label3, 2);
            this.label3.Size = new System.Drawing.Size(217, 58);
            this.label3.TabIndex = 0;
            this.label3.Text = "Müşteri Adres";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(449, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Müşteri Telefon";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(672, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Müşteri TCKN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCustomerName.Location = new System.Drawing.Point(3, 31);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(217, 23);
            this.tbCustomerName.TabIndex = 1;
            // 
            // tbCustomerSurname
            // 
            this.tbCustomerSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCustomerSurname.Location = new System.Drawing.Point(226, 31);
            this.tbCustomerSurname.Name = "tbCustomerSurname";
            this.tbCustomerSurname.Size = new System.Drawing.Size(217, 23);
            this.tbCustomerSurname.TabIndex = 1;
            // 
            // tbCustomerAddress
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tbCustomerAddress, 3);
            this.tbCustomerAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCustomerAddress.Location = new System.Drawing.Point(226, 59);
            this.tbCustomerAddress.Multiline = true;
            this.tbCustomerAddress.Name = "tbCustomerAddress";
            this.tableLayoutPanel2.SetRowSpan(this.tbCustomerAddress, 2);
            this.tbCustomerAddress.Size = new System.Drawing.Size(666, 52);
            this.tbCustomerAddress.TabIndex = 1;
            // 
            // tbCustomerPhone
            // 
            this.tbCustomerPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCustomerPhone.Location = new System.Drawing.Point(449, 31);
            this.tbCustomerPhone.Name = "tbCustomerPhone";
            this.tbCustomerPhone.Size = new System.Drawing.Size(217, 23);
            this.tbCustomerPhone.TabIndex = 1;
            // 
            // tbCustomerTCKN
            // 
            this.tbCustomerTCKN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCustomerTCKN.Location = new System.Drawing.Point(672, 31);
            this.tbCustomerTCKN.Name = "tbCustomerTCKN";
            this.tbCustomerTCKN.Size = new System.Drawing.Size(220, 23);
            this.tbCustomerTCKN.TabIndex = 1;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblLayoutPanelCustomers.SetColumnSpan(this.dgvCustomers, 3);
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCustomers.Location = new System.Drawing.Point(3, 3);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowTemplate.Height = 25;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(895, 406);
            this.dgvCustomers.TabIndex = 4;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 582);
            this.Controls.Add(this.tblLayoutPanelCustomers);
            this.Name = "CustomersForm";
            this.Text = "CustomersForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            this.tblLayoutPanelCustomers.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblLayoutPanelCustomers;
        private Button btnAddCustomer;
        private Button btnUpdateCustomer;
        private Button btnDeleteCustomer;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbCustomerName;
        private TextBox tbCustomerSurname;
        private TextBox tbCustomerAddress;
        private TextBox tbCustomerPhone;
        private TextBox tbCustomerTCKN;
        private DataGridView dgvCustomers;
    }
}
