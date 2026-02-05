namespace CareerOpportunity.UI
{
    partial class ApplicantsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridApplicants = new System.Windows.Forms.DataGridView();
            this.lblApprovalName = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnCloseHeader = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnpublish = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridApplicants)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridApplicants
            // 
            this.dataGridApplicants.AllowUserToAddRows = false;
            this.dataGridApplicants.AllowUserToDeleteRows = false;
            this.dataGridApplicants.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.dataGridApplicants.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridApplicants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridApplicants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridApplicants.BackgroundColor = System.Drawing.Color.White;
            this.dataGridApplicants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridApplicants.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridApplicants.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridApplicants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridApplicants.ColumnHeadersHeight = 45;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridApplicants.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridApplicants.EnableHeadersVisualStyles = false;
            this.dataGridApplicants.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dataGridApplicants.Location = new System.Drawing.Point(12, 130);
            this.dataGridApplicants.Name = "dataGridApplicants";
            this.dataGridApplicants.ReadOnly = true;
            this.dataGridApplicants.RowHeadersVisible = false;
            this.dataGridApplicants.RowTemplate.Height = 40;
            this.dataGridApplicants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridApplicants.Size = new System.Drawing.Size(922, 385);
            this.dataGridApplicants.TabIndex = 0;
            this.dataGridApplicants.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridApplicants_CellContentClick);
            // 
            // lblApprovalName
            // 
            this.lblApprovalName.AutoSize = true;
            this.lblApprovalName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblApprovalName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblApprovalName.Location = new System.Drawing.Point(160, 20);
            this.lblApprovalName.Name = "lblApprovalName";
            this.lblApprovalName.Size = new System.Drawing.Size(118, 21);
            this.lblApprovalName.TabIndex = 12;
            this.lblApprovalName.Text = "/  All Applicants";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.panelHeader.Controls.Add(this.btnCloseHeader);
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Controls.Add(this.lblApprovalName);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(954, 60);
            this.panelHeader.TabIndex = 13;
            // 
            // btnCloseHeader
            // 
            this.btnCloseHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseHeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseHeader.FlatAppearance.BorderSize = 0;
            this.btnCloseHeader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCloseHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseHeader.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCloseHeader.ForeColor = System.Drawing.Color.White;
            this.btnCloseHeader.Location = new System.Drawing.Point(892, 10);
            this.btnCloseHeader.Name = "btnCloseHeader";
            this.btnCloseHeader.Size = new System.Drawing.Size(48, 40);
            this.btnCloseHeader.TabIndex = 1;
            this.btnCloseHeader.Text = "✕";
            this.btnCloseHeader.UseVisualStyleBackColor = true;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(15, 12);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(136, 30);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "CarrierHunt";
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelButtons.AutoSize = true;
            this.flowLayoutPanelButtons.Controls.Add(this.btnpublish);
            this.flowLayoutPanelButtons.Controls.Add(this.btnback);
            this.flowLayoutPanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(668, 75);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(272, 50);
            this.flowLayoutPanelButtons.TabIndex = 17;
            // 
            // btnpublish
            // 
            this.btnpublish.BackColor = System.Drawing.Color.Green;
            this.btnpublish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpublish.FlatAppearance.BorderSize = 0;
            this.btnpublish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpublish.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnpublish.ForeColor = System.Drawing.Color.White;
            this.btnpublish.Location = new System.Drawing.Point(119, 3);
            this.btnpublish.Name = "btnpublish";
            this.btnpublish.Size = new System.Drawing.Size(150, 40);
            this.btnpublish.TabIndex = 0;
            this.btnpublish.Text = "👤 View Profile";
            this.btnpublish.UseVisualStyleBackColor = false;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.White;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnback.Location = new System.Drawing.Point(3, 3);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(110, 40);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // ApplicantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(954, 537);
            this.Controls.Add(this.flowLayoutPanelButtons);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.dataGridApplicants);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApplicantsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Applicants List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridApplicants)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridApplicants;
        private System.Windows.Forms.Label lblApprovalName;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnCloseHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button btnpublish;
        private System.Windows.Forms.Button btnback;
    }
}