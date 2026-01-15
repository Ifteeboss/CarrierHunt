namespace CareerOpportunity.UI
{
    partial class Approval
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
            this.ApprovalDataGridView = new System.Windows.Forms.DataGridView();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isApprovedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnApprove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnReject = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ApprovalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ApprovalDataGridView
            // 
            this.ApprovalDataGridView.AllowUserToAddRows = false;
            this.ApprovalDataGridView.AllowUserToDeleteRows = false;
            this.ApprovalDataGridView.AutoGenerateColumns = false;
            this.ApprovalDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ApprovalDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.ApprovalDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ApprovalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApprovalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.isApprovedDataGridViewCheckBoxColumn,
            this.btnApprove,
            this.btnReject});
            this.ApprovalDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApprovalDataGridView.DataSource = this.userBindingSource;
            this.ApprovalDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.ApprovalDataGridView.Location = new System.Drawing.Point(12, 54);
            this.ApprovalDataGridView.MultiSelect = false;
            this.ApprovalDataGridView.Name = "ApprovalDataGridView";
            this.ApprovalDataGridView.ReadOnly = true;
            this.ApprovalDataGridView.RowHeadersWidth = 51;
            this.ApprovalDataGridView.RowTemplate.Height = 24;
            this.ApprovalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ApprovalDataGridView.Size = new System.Drawing.Size(850, 386);
            this.ApprovalDataGridView.TabIndex = 0;
            this.ApprovalDataGridView.BackgroundColorChanged += new System.EventHandler(this.ApprovalDataGridView_BackgroundColorChanged);
            this.ApprovalDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ApprovalDataGridView_CellContentClick);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(CareerOpportunity.Models.User);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(705, 457);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 40);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isApprovedDataGridViewCheckBoxColumn
            // 
            this.isApprovedDataGridViewCheckBoxColumn.DataPropertyName = "IsApproved";
            this.isApprovedDataGridViewCheckBoxColumn.HeaderText = "IsApproved";
            this.isApprovedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isApprovedDataGridViewCheckBoxColumn.Name = "isApprovedDataGridViewCheckBoxColumn";
            this.isApprovedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isApprovedDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isApprovedDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnApprove
            // 
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApprove.HeaderText = "Approve";
            this.btnApprove.MinimumWidth = 6;
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.ReadOnly = true;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseColumnTextForButtonValue = true;
            // 
            // btnReject
            // 
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.HeaderText = "Reject";
            this.btnReject.MinimumWidth = 6;
            this.btnReject.Name = "btnReject";
            this.btnReject.ReadOnly = true;
            this.btnReject.Text = "Reject";
            this.btnReject.UseColumnTextForButtonValue = true;
            // 
            // Approval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 509);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.ApprovalDataGridView);
            this.Name = "Approval";
            this.Text = "Approval";
            this.Load += new System.EventHandler(this.Approval_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ApprovalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ApprovalDataGridView;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isApprovedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnApprove;
        private System.Windows.Forms.DataGridViewButtonColumn btnReject;
    }
}