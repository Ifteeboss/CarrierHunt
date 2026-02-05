namespace CareerOpportunity.UI
{
    partial class ApprovalRecruiter
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
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblRecruiterName = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.RecruiterApprovalDataGridView = new System.Windows.Forms.DataGridView();
            this.userBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsApproved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnApprove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnReject = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RecruiterApprovalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnExit.Location = new System.Drawing.Point(905, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 37);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblRecruiterName
            // 
            this.lblRecruiterName.AutoSize = true;
            this.lblRecruiterName.BackColor = System.Drawing.Color.White;
            this.lblRecruiterName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecruiterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(151)))));
            this.lblRecruiterName.Location = new System.Drawing.Point(10, 12);
            this.lblRecruiterName.Name = "lblRecruiterName";
            this.lblRecruiterName.Size = new System.Drawing.Size(250, 23);
            this.lblRecruiterName.TabIndex = 15;
            this.lblRecruiterName.Text = "Recruiter Approval View";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(834, 444);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 40);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // RecruiterApprovalDataGridView
            // 
            this.RecruiterApprovalDataGridView.AllowUserToAddRows = false;
            this.RecruiterApprovalDataGridView.AllowUserToDeleteRows = false;
            this.RecruiterApprovalDataGridView.AutoGenerateColumns = false;
            this.RecruiterApprovalDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RecruiterApprovalDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RecruiterApprovalDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RecruiterApprovalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecruiterApprovalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.CompanyNameDataGridViewTextBoxColumn,
            this.IsApproved,
            this.btnApprove,
            this.btnReject});
            this.RecruiterApprovalDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecruiterApprovalDataGridView.DataSource = this.userBindingSource2;
            this.RecruiterApprovalDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RecruiterApprovalDataGridView.Location = new System.Drawing.Point(14, 48);
            this.RecruiterApprovalDataGridView.MultiSelect = false;
            this.RecruiterApprovalDataGridView.Name = "RecruiterApprovalDataGridView";
            this.RecruiterApprovalDataGridView.ReadOnly = true;
            this.RecruiterApprovalDataGridView.RowHeadersWidth = 51;
            this.RecruiterApprovalDataGridView.RowTemplate.Height = 24;
            this.RecruiterApprovalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RecruiterApprovalDataGridView.Size = new System.Drawing.Size(957, 386);
            this.RecruiterApprovalDataGridView.TabIndex = 13;
            this.RecruiterApprovalDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecruiterApprovalDataGridView_CellContentClick);
            // 
            // userBindingSource2
            // 
            this.userBindingSource2.DataSource = typeof(CareerOpportunity.Models.User);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(CareerOpportunity.Models.User);
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataSource = typeof(CareerOpportunity.Models.User);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 61.25966F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.FillWeight = 115.9998F;
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 137.166F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.FillWeight = 82.48643F;
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CompanyNameDataGridViewTextBoxColumn
            // 
            this.CompanyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.CompanyNameDataGridViewTextBoxColumn.FillWeight = 123.0248F;
            this.CompanyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.CompanyNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.CompanyNameDataGridViewTextBoxColumn.Name = "CompanyNameDataGridViewTextBoxColumn";
            this.CompanyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IsApproved
            // 
            this.IsApproved.DataPropertyName = "IsApproved";
            this.IsApproved.FillWeight = 123.6168F;
            this.IsApproved.HeaderText = "IsApproved";
            this.IsApproved.MinimumWidth = 6;
            this.IsApproved.Name = "IsApproved";
            this.IsApproved.ReadOnly = true;
            // 
            // btnApprove
            // 
            this.btnApprove.FillWeight = 90.78664F;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.HeaderText = "Approve";
            this.btnApprove.MinimumWidth = 6;
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.ReadOnly = true;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseColumnTextForButtonValue = true;
            // 
            // btnReject
            // 
            this.btnReject.FillWeight = 87.28992F;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.HeaderText = "Reject";
            this.btnReject.MinimumWidth = 6;
            this.btnReject.Name = "btnReject";
            this.btnReject.ReadOnly = true;
            this.btnReject.Text = "Reject";
            this.btnReject.UseColumnTextForButtonValue = true;
            // 
            // ApprovalRecruiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(983, 496);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblRecruiterName);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.RecruiterApprovalDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApprovalRecruiter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApprovalRecruiter";
            this.Load += new System.EventHandler(this.ApprovalRecruiter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RecruiterApprovalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblRecruiterName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView RecruiterApprovalDataGridView;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource2;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsApproved;
        private System.Windows.Forms.DataGridViewButtonColumn btnApprove;
        private System.Windows.Forms.DataGridViewButtonColumn btnReject;
    }
}