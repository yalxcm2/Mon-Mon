namespace SellingProduct
{
    partial class SellingVoucherList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboShow = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSellingVoucher = new System.Windows.Forms.DataGridView();
            this.VoucherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellingVoucher)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboShow);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1808, 123);
            this.panel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1509, 81);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(209, 22);
            this.txtSearch.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1419, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Search";
            // 
            // comboShow
            // 
            this.comboShow.FormattingEnabled = true;
            this.comboShow.Location = new System.Drawing.Point(129, 86);
            this.comboShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboShow.Name = "comboShow";
            this.comboShow.Size = new System.Drawing.Size(79, 24);
            this.comboShow.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Show";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(125, 46);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1595, 12);
            this.panel3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(844, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Selling Voucher List";
            // 
            // dgvSellingVoucher
            // 
            this.dgvSellingVoucher.AllowUserToAddRows = false;
            this.dgvSellingVoucher.AllowUserToDeleteRows = false;
            this.dgvSellingVoucher.AllowUserToResizeColumns = false;
            this.dgvSellingVoucher.AllowUserToResizeRows = false;
            this.dgvSellingVoucher.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dgvSellingVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellingVoucher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VoucherID,
            this.CustomerName,
            this.Address,
            this.Date,
            this.phoneNumber,
            this.Update,
            this.Delete});
            this.dgvSellingVoucher.Location = new System.Drawing.Point(71, 130);
            this.dgvSellingVoucher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSellingVoucher.Name = "dgvSellingVoucher";
            this.dgvSellingVoucher.ReadOnly = true;
            this.dgvSellingVoucher.RowHeadersWidth = 51;
            this.dgvSellingVoucher.Size = new System.Drawing.Size(1721, 624);
            this.dgvSellingVoucher.TabIndex = 1;
            this.dgvSellingVoucher.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSellingVoucher_CellDoubleClick);
            // 
            // VoucherID
            // 
            this.VoucherID.DataPropertyName = "id";
            this.VoucherID.HeaderText = "VoucherID";
            this.VoucherID.MinimumWidth = 6;
            this.VoucherID.Name = "VoucherID";
            this.VoucherID.Width = 125;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "customerName";
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 125;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // phoneNumber
            // 
            this.phoneNumber.DataPropertyName = "phoneNumber";
            this.phoneNumber.HeaderText = "Phone Number";
            this.phoneNumber.MinimumWidth = 6;
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Width = 125;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 125;
            // 
            // SellingVoucherList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1808, 769);
            this.Controls.Add(this.dgvSellingVoucher);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1808, 769);
            this.MinimumSize = new System.Drawing.Size(1808, 769);
            this.Name = "SellingVoucherList";
            this.Text = "SellingVoucherList";
            this.Load += new System.EventHandler(this.SellingVoucherList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellingVoucher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSellingVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoucherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delete;
    }
}