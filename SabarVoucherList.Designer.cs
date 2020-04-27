namespace SellingProduct
{
    partial class SabarVoucherList
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboShow = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSabarVoucherList = new System.Windows.Forms.DataGridView();
            this.VoucherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SabarTin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashOrNot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateVoucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReload = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSabarVoucherList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboShow);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1808, 123);
            this.panel1.TabIndex = 23;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1509, 81);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(209, 22);
            this.txtSearch.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1419, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search";
            // 
            // comboShow
            // 
            this.comboShow.FormattingEnabled = true;
            this.comboShow.Location = new System.Drawing.Point(129, 86);
            this.comboShow.Margin = new System.Windows.Forms.Padding(4);
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
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1595, 12);
            this.panel3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(844, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sabar Voucher List";
            // 
            // dgvSabarVoucherList
            // 
            this.dgvSabarVoucherList.AllowUserToAddRows = false;
            this.dgvSabarVoucherList.AllowUserToDeleteRows = false;
            this.dgvSabarVoucherList.AllowUserToResizeColumns = false;
            this.dgvSabarVoucherList.AllowUserToResizeRows = false;
            this.dgvSabarVoucherList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dgvSabarVoucherList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSabarVoucherList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VoucherID,
            this.CustomerName,
            this.phNo,
            this.Address,
            this.SabarTin,
            this.Date,
            this.Status,
            this.cashOrNot,
            this.CreateVoucher,
            this.update,
            this.delete});
            this.dgvSabarVoucherList.Location = new System.Drawing.Point(32, 130);
            this.dgvSabarVoucherList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSabarVoucherList.Name = "dgvSabarVoucherList";
            this.dgvSabarVoucherList.RowHeadersWidth = 51;
            this.dgvSabarVoucherList.Size = new System.Drawing.Size(1721, 624);
            this.dgvSabarVoucherList.TabIndex = 24;
            this.dgvSabarVoucherList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSabarVoucherList_CellDoubleClick);
            // 
            // VoucherID
            // 
            this.VoucherID.DataPropertyName = "voucherId";
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
            // phNo
            // 
            this.phNo.DataPropertyName = "phoneNumber";
            this.phNo.HeaderText = "Phone Number";
            this.phNo.MinimumWidth = 6;
            this.phNo.Name = "phNo";
            this.phNo.Width = 125;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // SabarTin
            // 
            this.SabarTin.DataPropertyName = "sabarTin";
            this.SabarTin.HeaderText = "Sabar Tin";
            this.SabarTin.MinimumWidth = 6;
            this.SabarTin.Name = "SabarTin";
            this.SabarTin.Width = 125;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // cashOrNot
            // 
            this.cashOrNot.DataPropertyName = "cashOrNot";
            this.cashOrNot.HeaderText = "Payment";
            this.cashOrNot.MinimumWidth = 6;
            this.cashOrNot.Name = "cashOrNot";
            this.cashOrNot.Width = 125;
            // 
            // CreateVoucher
            // 
            this.CreateVoucher.HeaderText = "createVoucher";
            this.CreateVoucher.MinimumWidth = 6;
            this.CreateVoucher.Name = "CreateVoucher";
            this.CreateVoucher.Width = 125;
            // 
            // update
            // 
            this.update.HeaderText = "Update";
            this.update.MinimumWidth = 6;
            this.update.Name = "update";
            this.update.Width = 125;
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.Width = 125;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(1207, 86);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 18;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // SabarVoucherList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1808, 769);
            this.Controls.Add(this.dgvSabarVoucherList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1808, 769);
            this.MinimumSize = new System.Drawing.Size(1808, 769);
            this.Name = "SabarVoucherList";
            this.Text = "SabarVoucherList";
            this.Load += new System.EventHandler(this.SabarVoucherList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSabarVoucherList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvSabarVoucherList;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoucherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn SabarTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashOrNot;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn update;
        private System.Windows.Forms.DataGridViewTextBoxColumn delete;
        private System.Windows.Forms.Button btnReload;
    }
}