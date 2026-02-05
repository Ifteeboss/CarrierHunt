namespace CareerOpportunity.UI
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.JobgroupBox = new System.Windows.Forms.GroupBox();
            this.btnJobApproval = new System.Windows.Forms.Button();
            this.RecruitergroupBox = new System.Windows.Forms.GroupBox();
            this.btnRecruiterApproval = new System.Windows.Forms.Button();
            this.ApplicantgroupBox = new System.Windows.Forms.GroupBox();
            this.btnApplicantApproval = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAllRecruiter = new System.Windows.Forms.Button();
            this.btnAllApplicant = new System.Windows.Forms.Button();
            this.btnNotice = new System.Windows.Forms.Button();
            this.UserInfoModifygroupBox = new System.Windows.Forms.GroupBox();
            this.btnModifyInfo = new System.Windows.Forms.Button();
            this.btnRecruiter = new System.Windows.Forms.Button();
            this.btnApplicant = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRecruiterCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.JobgroupBox.SuspendLayout();
            this.RecruitergroupBox.SuspendLayout();
            this.ApplicantgroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.UserInfoModifygroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.JobgroupBox);
            this.panel2.Controls.Add(this.RecruitergroupBox);
            this.panel2.Controls.Add(this.ApplicantgroupBox);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(220, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 522);
            this.panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.DimGray;
            this.btnExit.Location = new System.Drawing.Point(455, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 35);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "✕";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // JobgroupBox
            // 
            this.JobgroupBox.BackColor = System.Drawing.Color.White;
            this.JobgroupBox.Controls.Add(this.btnJobApproval);
            this.JobgroupBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.JobgroupBox.ForeColor = System.Drawing.Color.DimGray;
            this.JobgroupBox.Location = new System.Drawing.Point(20, 150);
            this.JobgroupBox.Name = "JobgroupBox";
            this.JobgroupBox.Size = new System.Drawing.Size(455, 90);
            this.JobgroupBox.TabIndex = 33;
            this.JobgroupBox.TabStop = false;
            this.JobgroupBox.Text = "JOB POSTINGS";
            // 
            // btnJobApproval
            // 
            this.btnJobApproval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnJobApproval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJobApproval.FlatAppearance.BorderSize = 0;
            this.btnJobApproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJobApproval.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnJobApproval.ForeColor = System.Drawing.Color.White;
            this.btnJobApproval.Location = new System.Drawing.Point(15, 35);
            this.btnJobApproval.Name = "btnJobApproval";
            this.btnJobApproval.Size = new System.Drawing.Size(425, 40);
            this.btnJobApproval.TabIndex = 16;
            this.btnJobApproval.Text = "✔ Approve Pending Jobs";
            this.btnJobApproval.UseVisualStyleBackColor = false;
            this.btnJobApproval.Click += new System.EventHandler(this.btnJobApproval_Click);
            // 
            // RecruitergroupBox
            // 
            this.RecruitergroupBox.BackColor = System.Drawing.Color.White;
            this.RecruitergroupBox.Controls.Add(this.btnRecruiterApproval);
            this.RecruitergroupBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.RecruitergroupBox.ForeColor = System.Drawing.Color.DimGray;
            this.RecruitergroupBox.Location = new System.Drawing.Point(20, 45);
            this.RecruitergroupBox.Name = "RecruitergroupBox";
            this.RecruitergroupBox.Size = new System.Drawing.Size(220, 90);
            this.RecruitergroupBox.TabIndex = 30;
            this.RecruitergroupBox.TabStop = false;
            this.RecruitergroupBox.Text = "NEW RECRUITERS";
            // 
            // btnRecruiterApproval
            // 
            this.btnRecruiterApproval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRecruiterApproval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecruiterApproval.FlatAppearance.BorderSize = 0;
            this.btnRecruiterApproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecruiterApproval.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRecruiterApproval.ForeColor = System.Drawing.Color.White;
            this.btnRecruiterApproval.Location = new System.Drawing.Point(15, 35);
            this.btnRecruiterApproval.Name = "btnRecruiterApproval";
            this.btnRecruiterApproval.Size = new System.Drawing.Size(190, 40);
            this.btnRecruiterApproval.TabIndex = 20;
            this.btnRecruiterApproval.Text = "Review Requests";
            this.btnRecruiterApproval.UseVisualStyleBackColor = false;
            this.btnRecruiterApproval.Click += new System.EventHandler(this.btnRecruiterApproval_Click_1);
            // 
            // ApplicantgroupBox
            // 
            this.ApplicantgroupBox.BackColor = System.Drawing.Color.White;
            this.ApplicantgroupBox.Controls.Add(this.btnApplicantApproval);
            this.ApplicantgroupBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ApplicantgroupBox.ForeColor = System.Drawing.Color.DimGray;
            this.ApplicantgroupBox.Location = new System.Drawing.Point(255, 45);
            this.ApplicantgroupBox.Name = "ApplicantgroupBox";
            this.ApplicantgroupBox.Size = new System.Drawing.Size(220, 90);
            this.ApplicantgroupBox.TabIndex = 29;
            this.ApplicantgroupBox.TabStop = false;
            this.ApplicantgroupBox.Text = "NEW APPLICANTS";
            this.ApplicantgroupBox.Enter += new System.EventHandler(this.ApplicantgroupBox_Enter);
            // 
            // btnApplicantApproval
            // 
            this.btnApplicantApproval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnApplicantApproval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplicantApproval.FlatAppearance.BorderSize = 0;
            this.btnApplicantApproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplicantApproval.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnApplicantApproval.ForeColor = System.Drawing.Color.White;
            this.btnApplicantApproval.Location = new System.Drawing.Point(15, 35);
            this.btnApplicantApproval.Name = "btnApplicantApproval";
            this.btnApplicantApproval.Size = new System.Drawing.Size(190, 40);
            this.btnApplicantApproval.TabIndex = 16;
            this.btnApplicantApproval.Text = "Review Requests";
            this.btnApplicantApproval.UseVisualStyleBackColor = false;
            this.btnApplicantApproval.Click += new System.EventHandler(this.btnApplicantApproval_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.UserInfoModifygroupBox);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(20, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(455, 255);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnAllRecruiter);
            this.groupBox1.Controls.Add(this.btnAllApplicant);
            this.groupBox1.Controls.Add(this.btnNotice);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(235, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 235);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REPORTS & ALERTS";
            // 
            // btnAllRecruiter
            // 
            this.btnAllRecruiter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAllRecruiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllRecruiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllRecruiter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAllRecruiter.ForeColor = System.Drawing.Color.Black;
            this.btnAllRecruiter.Location = new System.Drawing.Point(15, 150);
            this.btnAllRecruiter.Name = "btnAllRecruiter";
            this.btnAllRecruiter.Size = new System.Drawing.Size(190, 45);
            this.btnAllRecruiter.TabIndex = 38;
            this.btnAllRecruiter.Text = "Recruiter Database";
            this.btnAllRecruiter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllRecruiter.UseVisualStyleBackColor = false;
            this.btnAllRecruiter.Click += new System.EventHandler(this.btnAllRecruiter_Click);
            // 
            // btnAllApplicant
            // 
            this.btnAllApplicant.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAllApplicant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllApplicant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllApplicant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAllApplicant.ForeColor = System.Drawing.Color.Black;
            this.btnAllApplicant.Location = new System.Drawing.Point(15, 95);
            this.btnAllApplicant.Name = "btnAllApplicant";
            this.btnAllApplicant.Size = new System.Drawing.Size(190, 45);
            this.btnAllApplicant.TabIndex = 37;
            this.btnAllApplicant.Text = "Applicant Database";
            this.btnAllApplicant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllApplicant.UseVisualStyleBackColor = false;
            this.btnAllApplicant.Click += new System.EventHandler(this.btnAllApplicant_Click);
            // 
            // btnNotice
            // 
            this.btnNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnNotice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotice.FlatAppearance.BorderSize = 0;
            this.btnNotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNotice.ForeColor = System.Drawing.Color.White;
            this.btnNotice.Location = new System.Drawing.Point(15, 40);
            this.btnNotice.Name = "btnNotice";
            this.btnNotice.Size = new System.Drawing.Size(190, 45);
            this.btnNotice.TabIndex = 31;
            this.btnNotice.Text = "📢  Broadcast Notice";
            this.btnNotice.UseVisualStyleBackColor = false;
            // 
            // UserInfoModifygroupBox
            // 
            this.UserInfoModifygroupBox.BackColor = System.Drawing.Color.White;
            this.UserInfoModifygroupBox.Controls.Add(this.btnModifyInfo);
            this.UserInfoModifygroupBox.Controls.Add(this.btnRecruiter);
            this.UserInfoModifygroupBox.Controls.Add(this.btnApplicant);
            this.UserInfoModifygroupBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.UserInfoModifygroupBox.ForeColor = System.Drawing.Color.DimGray;
            this.UserInfoModifygroupBox.Location = new System.Drawing.Point(0, 10);
            this.UserInfoModifygroupBox.Name = "UserInfoModifygroupBox";
            this.UserInfoModifygroupBox.Size = new System.Drawing.Size(220, 235);
            this.UserInfoModifygroupBox.TabIndex = 34;
            this.UserInfoModifygroupBox.TabStop = false;
            this.UserInfoModifygroupBox.Text = "ADMIN TOOLS";
            // 
            // btnModifyInfo
            // 
            this.btnModifyInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModifyInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifyInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModifyInfo.ForeColor = System.Drawing.Color.Black;
            this.btnModifyInfo.Location = new System.Drawing.Point(15, 150);
            this.btnModifyInfo.Name = "btnModifyInfo";
            this.btnModifyInfo.Size = new System.Drawing.Size(190, 45);
            this.btnModifyInfo.TabIndex = 34;
            this.btnModifyInfo.Text = "Modify Data";
            this.btnModifyInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyInfo.UseVisualStyleBackColor = false;
            this.btnModifyInfo.Click += new System.EventHandler(this.btnModifyInfo_Click);
            // 
            // btnRecruiter
            // 
            this.btnRecruiter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRecruiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecruiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecruiter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRecruiter.ForeColor = System.Drawing.Color.Black;
            this.btnRecruiter.Location = new System.Drawing.Point(15, 95);
            this.btnRecruiter.Name = "btnRecruiter";
            this.btnRecruiter.Size = new System.Drawing.Size(190, 45);
            this.btnRecruiter.TabIndex = 33;
            this.btnRecruiter.Text = "Add Recruiter";
            this.btnRecruiter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecruiter.UseVisualStyleBackColor = false;
            this.btnRecruiter.Click += new System.EventHandler(this.btnRecruiter_Click);
            // 
            // btnApplicant
            // 
            this.btnApplicant.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnApplicant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplicant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplicant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnApplicant.ForeColor = System.Drawing.Color.Black;
            this.btnApplicant.Location = new System.Drawing.Point(15, 40);
            this.btnApplicant.Name = "btnApplicant";
            this.btnApplicant.Size = new System.Drawing.Size(190, 45);
            this.btnApplicant.TabIndex = 32;
            this.btnApplicant.Text = "Add Applicant";
            this.btnApplicant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplicant.UseVisualStyleBackColor = false;
            this.btnApplicant.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(10, 10);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // lblRecruiterCount
            // 
            this.lblRecruiterCount.AutoSize = true;
            this.lblRecruiterCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRecruiterCount.ForeColor = System.Drawing.Color.Gray;
            this.lblRecruiterCount.Location = new System.Drawing.Point(35, 270);
            this.lblRecruiterCount.Name = "lblRecruiterCount";
            this.lblRecruiterCount.Size = new System.Drawing.Size(0, 19);
            this.lblRecruiterCount.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblRecruiterCount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 522);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.btnBack.ForeColor = System.Drawing.Color.Silver;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 50);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 150);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(213, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.JobgroupBox.ResumeLayout(false);
            this.RecruitergroupBox.ResumeLayout(false);
            this.ApplicantgroupBox.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.UserInfoModifygroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox RecruitergroupBox;
        private System.Windows.Forms.Button btnRecruiterApproval;
        private System.Windows.Forms.Label lblRecruiterCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNotice;
        private System.Windows.Forms.Button btnApplicant;
        private System.Windows.Forms.GroupBox ApplicantgroupBox;
        private System.Windows.Forms.Button btnApplicantApproval;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox JobgroupBox;
        private System.Windows.Forms.Button btnJobApproval;
        private System.Windows.Forms.GroupBox UserInfoModifygroupBox;
        private System.Windows.Forms.Button btnRecruiter;
        private System.Windows.Forms.Button btnModifyInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAllApplicant;
        private System.Windows.Forms.Button btnAllRecruiter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}