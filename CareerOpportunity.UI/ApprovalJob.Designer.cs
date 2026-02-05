namespace CareerOpportunity.UI
{
    partial class ApprovalJob
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
            this.lblApprovalName = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.jobIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recruiterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiredSkillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryOrBudgetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnApprove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnReject = new System.Windows.Forms.DataGridViewButtonColumn();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
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
            this.btnExit.Location = new System.Drawing.Point(1373, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 37);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblApprovalName
            // 
            this.lblApprovalName.AutoSize = true;
            this.lblApprovalName.BackColor = System.Drawing.Color.White;
            this.lblApprovalName.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApprovalName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(151)))));
            this.lblApprovalName.Location = new System.Drawing.Point(2, 6);
            this.lblApprovalName.Name = "lblApprovalName";
            this.lblApprovalName.Size = new System.Drawing.Size(278, 34);
            this.lblApprovalName.TabIndex = 15;
            this.lblApprovalName.Text = "Job Approval View";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(1302, 440);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 40);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvJobs
            // 
            this.dgvJobs.AllowUserToAddRows = false;
            this.dgvJobs.AllowUserToDeleteRows = false;
            this.dgvJobs.AutoGenerateColumns = false;
            this.dgvJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJobs.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvJobs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobIDDataGridViewTextBoxColumn,
            this.recruiterIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.requiredSkillDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn,
            this.jobTypeDataGridViewTextBoxColumn,
            this.salaryOrBudgetDataGridViewTextBoxColumn,
            this.postedDateDataGridViewTextBoxColumn,
            this.deadlineDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.btnApprove,
            this.btnReject});
            this.dgvJobs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvJobs.DataSource = this.jobBindingSource;
            this.dgvJobs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvJobs.Location = new System.Drawing.Point(6, 48);
            this.dgvJobs.MultiSelect = false;
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.ReadOnly = true;
            this.dgvJobs.RowHeadersWidth = 51;
            this.dgvJobs.RowTemplate.Height = 24;
            this.dgvJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobs.Size = new System.Drawing.Size(1433, 386);
            this.dgvJobs.TabIndex = 13;
            this.dgvJobs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJobs_CellContentClick);
            // 
            // jobIDDataGridViewTextBoxColumn
            // 
            this.jobIDDataGridViewTextBoxColumn.DataPropertyName = "JobID";
            this.jobIDDataGridViewTextBoxColumn.HeaderText = "JobID";
            this.jobIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobIDDataGridViewTextBoxColumn.Name = "jobIDDataGridViewTextBoxColumn";
            this.jobIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recruiterIDDataGridViewTextBoxColumn
            // 
            this.recruiterIDDataGridViewTextBoxColumn.DataPropertyName = "RecruiterID";
            this.recruiterIDDataGridViewTextBoxColumn.HeaderText = "RecruiterID";
            this.recruiterIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recruiterIDDataGridViewTextBoxColumn.Name = "recruiterIDDataGridViewTextBoxColumn";
            this.recruiterIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requiredSkillDataGridViewTextBoxColumn
            // 
            this.requiredSkillDataGridViewTextBoxColumn.DataPropertyName = "RequiredSkill";
            this.requiredSkillDataGridViewTextBoxColumn.HeaderText = "RequiredSkill";
            this.requiredSkillDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requiredSkillDataGridViewTextBoxColumn.Name = "requiredSkillDataGridViewTextBoxColumn";
            this.requiredSkillDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "Experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "Experience";
            this.experienceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            this.experienceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobTypeDataGridViewTextBoxColumn
            // 
            this.jobTypeDataGridViewTextBoxColumn.DataPropertyName = "JobType";
            this.jobTypeDataGridViewTextBoxColumn.HeaderText = "JobType";
            this.jobTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobTypeDataGridViewTextBoxColumn.Name = "jobTypeDataGridViewTextBoxColumn";
            this.jobTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryOrBudgetDataGridViewTextBoxColumn
            // 
            this.salaryOrBudgetDataGridViewTextBoxColumn.DataPropertyName = "SalaryOrBudget";
            this.salaryOrBudgetDataGridViewTextBoxColumn.HeaderText = "SalaryOrBudget";
            this.salaryOrBudgetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryOrBudgetDataGridViewTextBoxColumn.Name = "salaryOrBudgetDataGridViewTextBoxColumn";
            this.salaryOrBudgetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postedDateDataGridViewTextBoxColumn
            // 
            this.postedDateDataGridViewTextBoxColumn.DataPropertyName = "PostedDate";
            this.postedDateDataGridViewTextBoxColumn.HeaderText = "PostedDate";
            this.postedDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postedDateDataGridViewTextBoxColumn.Name = "postedDateDataGridViewTextBoxColumn";
            this.postedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deadlineDataGridViewTextBoxColumn
            // 
            this.deadlineDataGridViewTextBoxColumn.DataPropertyName = "Deadline";
            this.deadlineDataGridViewTextBoxColumn.HeaderText = "Deadline";
            this.deadlineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deadlineDataGridViewTextBoxColumn.Name = "deadlineDataGridViewTextBoxColumn";
            this.deadlineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnApprove
            // 
            this.btnApprove.HeaderText = "Approve";
            this.btnApprove.MinimumWidth = 6;
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.ReadOnly = true;
            this.btnApprove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnApprove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseColumnTextForButtonValue = true;
            // 
            // btnReject
            // 
            this.btnReject.HeaderText = "Reject";
            this.btnReject.MinimumWidth = 6;
            this.btnReject.Name = "btnReject";
            this.btnReject.ReadOnly = true;
            this.btnReject.Text = "Reject";
            this.btnReject.UseColumnTextForButtonValue = true;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataSource = typeof(CareerOpportunity.Models.Job);
            // 
            // ApprovalJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 492);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblApprovalName);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvJobs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApprovalJob";
            this.Text = "ApprovalJob";
            this.Load += new System.EventHandler(this.ApprovalJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblApprovalName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recruiterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requiredSkillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryOrBudgetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadlineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnApprove;
        private System.Windows.Forms.DataGridViewButtonColumn btnReject;
    }
}