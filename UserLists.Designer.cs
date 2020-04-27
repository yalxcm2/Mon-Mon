namespace SellingProduct
{
    partial class UserLists
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
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboShow);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1808, 123);
            this.panel1.TabIndex = 24;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1509, 81);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(844, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "User List";
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AllowUserToResizeColumns = false;
            this.dgvUser.AllowUserToResizeRows = false;
            this.dgvUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userid,
            this.userName,
            this.userType,
            this.update,
            this.delete});
            this.dgvUser.Location = new System.Drawing.Point(49, 130);
            this.dgvUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.Size = new System.Drawing.Size(1721, 624);
            this.dgvUser.TabIndex = 25;
            this.dgvUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellDoubleClick);
            // 
            // userid
            // 
            this.userid.DataPropertyName = "userid";
            this.userid.HeaderText = "User ID";
            this.userid.MinimumWidth = 6;
            this.userid.Name = "userid";
            this.userid.Width = 125;
            // 
            // userName
            // 
            this.userName.DataPropertyName = "username";
            this.userName.HeaderText = "User Name";
            this.userName.MinimumWidth = 6;
            this.userName.Name = "userName";
            this.userName.Width = 125;
            // 
            // userType
            // 
            this.userType.DataPropertyName = "usertype";
            this.userType.HeaderText = "User Type";
            this.userType.MinimumWidth = 6;
            this.userType.Name = "userType";
            this.userType.Width = 125;
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
            // UserLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1808, 769);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1808, 769);
            this.MinimumSize = new System.Drawing.Size(1808, 769);
            this.Name = "UserLists";
            this.Text = "UserLists";
            this.Load += new System.EventHandler(this.UserLists_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userType;
        private System.Windows.Forms.DataGridViewTextBoxColumn update;
        private System.Windows.Forms.DataGridViewTextBoxColumn delete;
    }
}