namespace DehasoftOne.Winforms
{
    partial class OrderForm
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
            this.tblLayoutPanelOrders = new System.Windows.Forms.TableLayoutPanel();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.dtPickerOrder = new System.Windows.Forms.DateTimePicker();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.tblLayoutPanelOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLayoutPanelOrders
            // 
            this.tblLayoutPanelOrders.ColumnCount = 4;
            this.tblLayoutPanelOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelOrders.Controls.Add(this.cbStatus, 3, 2);
            this.tblLayoutPanelOrders.Controls.Add(this.label4, 3, 1);
            this.tblLayoutPanelOrders.Controls.Add(this.dgvOrders, 0, 0);
            this.tblLayoutPanelOrders.Controls.Add(this.label1, 0, 1);
            this.tblLayoutPanelOrders.Controls.Add(this.label2, 1, 1);
            this.tblLayoutPanelOrders.Controls.Add(this.label3, 2, 1);
            this.tblLayoutPanelOrders.Controls.Add(this.cbCustomer, 0, 2);
            this.tblLayoutPanelOrders.Controls.Add(this.dtPickerOrder, 1, 2);
            this.tblLayoutPanelOrders.Controls.Add(this.tbDescription, 2, 2);
            this.tblLayoutPanelOrders.Controls.Add(this.btnAddOrder, 0, 3);
            this.tblLayoutPanelOrders.Controls.Add(this.btnDeleteOrder, 1, 3);
            this.tblLayoutPanelOrders.Controls.Add(this.btnUpdateOrder, 2, 3);
            this.tblLayoutPanelOrders.Controls.Add(this.btnOrderDetails, 3, 3);
            this.tblLayoutPanelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelOrders.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelOrders.Name = "tblLayoutPanelOrders";
            this.tblLayoutPanelOrders.RowCount = 4;
            this.tblLayoutPanelOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblLayoutPanelOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblLayoutPanelOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblLayoutPanelOrders.Size = new System.Drawing.Size(784, 361);
            this.tblLayoutPanelOrders.TabIndex = 0;
            // 
            // cbStatus
            // 
            this.cbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(591, 294);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(190, 23);
            this.cbStatus.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(591, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "Durum";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblLayoutPanelOrders.SetColumnSpan(this.dgvOrders, 4);
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOrders.Location = new System.Drawing.Point(3, 3);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowTemplate.Height = 25;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(778, 250);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(199, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sipariş Tarih";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(395, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "Açıklama";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cbCustomer
            // 
            this.cbCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(3, 294);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(190, 23);
            this.cbCustomer.TabIndex = 2;
            // 
            // dtPickerOrder
            // 
            this.dtPickerOrder.Location = new System.Drawing.Point(199, 294);
            this.dtPickerOrder.Name = "dtPickerOrder";
            this.dtPickerOrder.Size = new System.Drawing.Size(190, 23);
            this.dtPickerOrder.TabIndex = 3;
            // 
            // tbDescription
            // 
            this.tbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDescription.Location = new System.Drawing.Point(395, 294);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(190, 23);
            this.tbDescription.TabIndex = 4;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddOrder.Location = new System.Drawing.Point(3, 329);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(190, 29);
            this.btnAddOrder.TabIndex = 5;
            this.btnAddOrder.Text = "Ekle";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteOrder.Location = new System.Drawing.Point(199, 329);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(190, 29);
            this.btnDeleteOrder.TabIndex = 6;
            this.btnDeleteOrder.Text = "Sil";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateOrder.Location = new System.Drawing.Point(395, 329);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(190, 29);
            this.btnUpdateOrder.TabIndex = 7;
            this.btnUpdateOrder.Text = "Güncelle";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrderDetails.Location = new System.Drawing.Point(591, 329);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(190, 29);
            this.btnOrderDetails.TabIndex = 8;
            this.btnOrderDetails.Text = "Detaya Git";
            this.btnOrderDetails.UseVisualStyleBackColor = true;
            this.btnOrderDetails.Click += new System.EventHandler(this.btnOrderDetails_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.tblLayoutPanelOrders);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.tblLayoutPanelOrders.ResumeLayout(false);
            this.tblLayoutPanelOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblLayoutPanelOrders;
        private ComboBox cbStatus;
        private Label label4;
        private DataGridView dgvOrders;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbCustomer;
        private DateTimePicker dtPickerOrder;
        private TextBox tbDescription;
        private Button btnAddOrder;
        private Button btnDeleteOrder;
        private Button btnUpdateOrder;
        private Button btnOrderDetails;
    }
}
