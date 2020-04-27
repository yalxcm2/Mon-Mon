namespace SellingProduct
{
    partial class SabarVoucher
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSoont = new System.Windows.Forms.TextBox();
            this.txtSaBarTin = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhNo = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtPhwalNu = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSabarVoucherListGrid = new System.Windows.Forms.DataGridView();
            this.voucherid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabarTin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashOrNot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSabarVoucherListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dtpDate);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.txtSoont);
            this.panel3.Controls.Add(this.txtSaBarTin);
            this.panel3.Controls.Add(this.txtAddress);
            this.panel3.Controls.Add(this.txtPhNo);
            this.panel3.Controls.Add(this.txtCusName);
            this.panel3.Controls.Add(this.txtPhwalNu);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(43, 78);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 434);
            this.panel3.TabIndex = 3;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(244, 271);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(265, 22);
            this.dtpDate.TabIndex = 18;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(207, 338);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 30);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSoont
            // 
            this.txtSoont.Location = new System.Drawing.Point(244, 239);
            this.txtSoont.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoont.Name = "txtSoont";
            this.txtSoont.Size = new System.Drawing.Size(132, 22);
            this.txtSoont.TabIndex = 13;
            // 
            // txtSaBarTin
            // 
            this.txtSaBarTin.Location = new System.Drawing.Point(244, 207);
            this.txtSaBarTin.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaBarTin.Name = "txtSaBarTin";
            this.txtSaBarTin.Size = new System.Drawing.Size(132, 22);
            this.txtSaBarTin.TabIndex = 12;
            this.txtSaBarTin.Leave += new System.EventHandler(this.txtSaBarTin_Leave);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(244, 143);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(240, 56);
            this.txtAddress.TabIndex = 10;
            // 
            // txtPhNo
            // 
            this.txtPhNo.Location = new System.Drawing.Point(244, 111);
            this.txtPhNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhNo.Name = "txtPhNo";
            this.txtPhNo.Size = new System.Drawing.Size(132, 22);
            this.txtPhNo.TabIndex = 9;
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(244, 79);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(132, 22);
            this.txtCusName.TabIndex = 8;
            // 
            // txtPhwalNu
            // 
            this.txtPhwalNu.AutoSize = true;
            this.txtPhwalNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhwalNu.Location = new System.Drawing.Point(151, 271);
            this.txtPhwalNu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPhwalNu.Name = "txtPhwalNu";
            this.txtPhwalNu.Size = new System.Drawing.Size(45, 20);
            this.txtPhwalNu.TabIndex = 7;
            this.txtPhwalNu.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(179, 239);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Soont";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(149, 212);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "SaBarTin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ph No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SabarVoucher";
            // 
            // dgvSabarVoucherListGrid
            // 
            this.dgvSabarVoucherListGrid.AllowUserToAddRows = false;
            this.dgvSabarVoucherListGrid.AllowUserToDeleteRows = false;
            this.dgvSabarVoucherListGrid.AllowUserToResizeColumns = false;
            this.dgvSabarVoucherListGrid.AllowUserToResizeRows = false;
            this.dgvSabarVoucherListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSabarVoucherListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.voucherid,
            this.customerName,
            this.phNumber,
            this.address,
            this.sabarTin,
            this.date,
            this.status,
            this.cashOrNot});
            this.dgvSabarVoucherListGrid.Location = new System.Drawing.Point(629, 78);
            this.dgvSabarVoucherListGrid.Name = "dgvSabarVoucherListGrid";
            this.dgvSabarVoucherListGrid.RowHeadersWidth = 51;
            this.dgvSabarVoucherListGrid.RowTemplate.Height = 24;
            this.dgvSabarVoucherListGrid.Size = new System.Drawing.Size(1174, 484);
            this.dgvSabarVoucherListGrid.TabIndex = 4;
            this.dgvSabarVoucherListGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSabarVoucherListGrid_CellDoubleClick);
            // 
            // voucherid
            // 
            this.voucherid.DataPropertyName = "voucherId";
            this.voucherid.HeaderText = "Voucher ID";
            this.voucherid.MinimumWidth = 6;
            this.voucherid.Name = "voucherid";
            this.voucherid.Width = 125;
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "customerName";
            this.customerName.HeaderText = "Customer Name";
            this.customerName.MinimumWidth = 6;
            this.customerName.Name = "customerName";
            this.customerName.Width = 125;
            // 
            // phNumber
            // 
            this.phNumber.DataPropertyName = "phoneNumber";
            this.phNumber.HeaderText = "Phone Number";
            this.phNumber.MinimumWidth = 6;
            this.phNumber.Name = "phNumber";
            this.phNumber.Width = 125;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.Width = 125;
            // 
            // sabarTin
            // 
            this.sabarTin.DataPropertyName = "sabarTin";
            this.sabarTin.HeaderText = "Sabar  Tin";
            this.sabarTin.MinimumWidth = 6;
            this.sabarTin.Name = "sabarTin";
            this.sabarTin.Width = 125;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Width = 125;
            // 
            // cashOrNot
            // 
            this.cashOrNot.DataPropertyName = "cashOrNot";
            this.cashOrNot.HeaderText = "Payment";
            this.cashOrNot.MinimumWidth = 6;
            this.cashOrNot.Name = "cashOrNot";
            this.cashOrNot.Width = 125;
            // 
            // SabarVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1808, 769);
            this.Controls.Add(this.dgvSabarVoucherListGrid);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1808, 769);
            this.MinimumSize = new System.Drawing.Size(1808, 769);
            this.Name = "SabarVoucher";
            this.Text = "SabarVoucher";
            this.Load += new System.EventHandler(this.SabarVoucher_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSabarVoucherListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSoont;
        private System.Windows.Forms.TextBox txtSaBarTin;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhNo;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label txtPhwalNu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSabarVoucherListGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherid;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabarTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashOrNot;
    }
}