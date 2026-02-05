// FreelenceAdmin.Designer.cs
namespace CareerOpportunity.UI
{
    partial class Recuiter
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnCloseHeader = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbJobType = new System.Windows.Forms.ComboBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxptitle = new System.Windows.Forms.TextBox();
            this.lblprojectDes = new System.Windows.Forms.Label();
            this.textBoxprojectdescription = new System.Windows.Forms.TextBox();
            this.lblrequiredskill = new System.Windows.Forms.Label();
            this.textBoxrequiredskill = new System.Windows.Forms.TextBox();
            this.lblbudget = new System.Windows.Forms.Label();
            this.textBoxbudget = new System.Windows.Forms.TextBox();
            this.lbldeadline = new System.Windows.Forms.Label();
            this.dateTimePickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.lblexperience = new System.Windows.Forms.Label();
            this.textBoxexperience = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnpublish = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnNotice = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridViewshowapplicant = new System.Windows.Forms.DataGridView();
            this.SEEApplicants = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelHeader.SuspendLayout();
            this.groupBoxForm.SuspendLayout();
            this.flowLayoutPanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewshowapplicant)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.panelHeader.Controls.Add(this.btnCloseHeader);
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1218, 52);
            this.panelHeader.TabIndex = 6;
            // 
            // btnCloseHeader
            // 
            this.btnCloseHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseHeader.FlatAppearance.BorderSize = 0;
            this.btnCloseHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseHeader.ForeColor = System.Drawing.Color.White;
            this.btnCloseHeader.Location = new System.Drawing.Point(2048, 12);
            this.btnCloseHeader.Name = "btnCloseHeader";
            this.btnCloseHeader.Size = new System.Drawing.Size(60, 28);
            this.btnCloseHeader.TabIndex = 1;
            this.btnCloseHeader.Text = "Close";
            this.btnCloseHeader.UseVisualStyleBackColor = true;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.labelHeader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(14, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(158, 30);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "🧑🏽‍💼CarrierHunt";
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxForm.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxForm.Controls.Add(this.label1);
            this.groupBoxForm.Controls.Add(this.cmbJobType);
            this.groupBoxForm.Controls.Add(this.labelTitle);
            this.groupBoxForm.Controls.Add(this.textBoxptitle);
            this.groupBoxForm.Controls.Add(this.lblprojectDes);
            this.groupBoxForm.Controls.Add(this.textBoxprojectdescription);
            this.groupBoxForm.Controls.Add(this.lblrequiredskill);
            this.groupBoxForm.Controls.Add(this.textBoxrequiredskill);
            this.groupBoxForm.Controls.Add(this.lblbudget);
            this.groupBoxForm.Controls.Add(this.textBoxbudget);
            this.groupBoxForm.Controls.Add(this.lbldeadline);
            this.groupBoxForm.Controls.Add(this.dateTimePickerDeadline);
            this.groupBoxForm.Controls.Add(this.lblexperience);
            this.groupBoxForm.Controls.Add(this.textBoxexperience);
            this.groupBoxForm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxForm.Location = new System.Drawing.Point(16, 80);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new System.Drawing.Size(1186, 233);
            this.groupBoxForm.TabIndex = 2;
            this.groupBoxForm.TabStop = false;
            this.groupBoxForm.Text = "Publish Job";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "JOB";
            // 
            // cmbJobType
            // 
            this.cmbJobType.FormattingEnabled = true;
            this.cmbJobType.Items.AddRange(new object[] {
            "Internship",
            "Freelence"});
            this.cmbJobType.Location = new System.Drawing.Point(16, 133);
            this.cmbJobType.Name = "cmbJobType";
            this.cmbJobType.Size = new System.Drawing.Size(173, 29);
            this.cmbJobType.TabIndex = 14;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitle.Location = new System.Drawing.Point(13, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(86, 18);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Project Title";
            // 
            // textBoxptitle
            // 
            this.textBoxptitle.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxptitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxptitle.Location = new System.Drawing.Point(16, 46);
            this.textBoxptitle.Name = "textBoxptitle";
            this.textBoxptitle.Size = new System.Drawing.Size(198, 29);
            this.textBoxptitle.TabIndex = 3;
            // 
            // lblprojectDes
            // 
            this.lblprojectDes.AutoSize = true;
            this.lblprojectDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblprojectDes.Location = new System.Drawing.Point(671, 22);
            this.lblprojectDes.Name = "lblprojectDes";
            this.lblprojectDes.Size = new System.Drawing.Size(142, 20);
            this.lblprojectDes.TabIndex = 4;
            this.lblprojectDes.Text = "Project Description";
            // 
            // textBoxprojectdescription
            // 
            this.textBoxprojectdescription.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxprojectdescription.Location = new System.Drawing.Point(675, 45);
            this.textBoxprojectdescription.Multiline = true;
            this.textBoxprojectdescription.Name = "textBoxprojectdescription";
            this.textBoxprojectdescription.Size = new System.Drawing.Size(269, 117);
            this.textBoxprojectdescription.TabIndex = 5;
            // 
            // lblrequiredskill
            // 
            this.lblrequiredskill.AutoSize = true;
            this.lblrequiredskill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrequiredskill.Location = new System.Drawing.Point(228, 23);
            this.lblrequiredskill.Name = "lblrequiredskill";
            this.lblrequiredskill.Size = new System.Drawing.Size(114, 20);
            this.lblrequiredskill.TabIndex = 6;
            this.lblrequiredskill.Text = "Required Skills";
            // 
            // textBoxrequiredskill
            // 
            this.textBoxrequiredskill.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxrequiredskill.Location = new System.Drawing.Point(232, 45);
            this.textBoxrequiredskill.Name = "textBoxrequiredskill";
            this.textBoxrequiredskill.Size = new System.Drawing.Size(153, 29);
            this.textBoxrequiredskill.TabIndex = 7;
            // 
            // lblbudget
            // 
            this.lblbudget.AutoSize = true;
            this.lblbudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbudget.Location = new System.Drawing.Point(432, 23);
            this.lblbudget.Name = "lblbudget";
            this.lblbudget.Size = new System.Drawing.Size(61, 20);
            this.lblbudget.TabIndex = 8;
            this.lblbudget.Text = "Budget";
            // 
            // textBoxbudget
            // 
            this.textBoxbudget.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxbudget.Location = new System.Drawing.Point(431, 45);
            this.textBoxbudget.Name = "textBoxbudget";
            this.textBoxbudget.Size = new System.Drawing.Size(158, 29);
            this.textBoxbudget.TabIndex = 9;
            // 
            // lbldeadline
            // 
            this.lbldeadline.AutoSize = true;
            this.lbldeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeadline.Location = new System.Drawing.Point(428, 107);
            this.lbldeadline.Name = "lbldeadline";
            this.lbldeadline.Size = new System.Drawing.Size(65, 18);
            this.lbldeadline.TabIndex = 10;
            this.lbldeadline.Text = "Deadline";
            // 
            // dateTimePickerDeadline
            // 
            this.dateTimePickerDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDeadline.Location = new System.Drawing.Point(431, 129);
            this.dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            this.dateTimePickerDeadline.Size = new System.Drawing.Size(158, 29);
            this.dateTimePickerDeadline.TabIndex = 11;
            // 
            // lblexperience
            // 
            this.lblexperience.AutoSize = true;
            this.lblexperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexperience.Location = new System.Drawing.Point(228, 108);
            this.lblexperience.Name = "lblexperience";
            this.lblexperience.Size = new System.Drawing.Size(88, 20);
            this.lblexperience.TabIndex = 12;
            this.lblexperience.Text = "Experience";
            // 
            // textBoxexperience
            // 
            this.textBoxexperience.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxexperience.Location = new System.Drawing.Point(232, 133);
            this.textBoxexperience.Name = "textBoxexperience";
            this.textBoxexperience.Size = new System.Drawing.Size(160, 29);
            this.textBoxexperience.TabIndex = 13;
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelButtons.AutoSize = true;
            this.flowLayoutPanelButtons.Controls.Add(this.btnpublish);
            this.flowLayoutPanelButtons.Controls.Add(this.btnback);
            this.flowLayoutPanelButtons.Controls.Add(this.btnNotice);
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(768, 335);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(434, 44);
            this.flowLayoutPanelButtons.TabIndex = 3;
            // 
            // btnpublish
            // 
            this.btnpublish.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnpublish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpublish.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpublish.ForeColor = System.Drawing.Color.White;
            this.btnpublish.Location = new System.Drawing.Point(3, 3);
            this.btnpublish.Name = "btnpublish";
            this.btnpublish.Size = new System.Drawing.Size(137, 36);
            this.btnpublish.TabIndex = 0;
            this.btnpublish.Text = "📢Publish";
            this.btnpublish.UseVisualStyleBackColor = false;
            this.btnpublish.Click += new System.EventHandler(this.btnpublish_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.SeaGreen;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnback.Location = new System.Drawing.Point(146, 3);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(136, 36);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "🧹Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnNotice
            // 
            this.btnNotice.BackColor = System.Drawing.Color.Brown;
            this.btnNotice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNotice.Location = new System.Drawing.Point(288, 3);
            this.btnNotice.Name = "btnNotice";
            this.btnNotice.Size = new System.Drawing.Size(143, 36);
            this.btnNotice.TabIndex = 2;
            this.btnNotice.Text = "📰 Notice";
            this.btnNotice.UseVisualStyleBackColor = false;
            this.btnNotice.Click += new System.EventHandler(this.btnNotice_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Purple;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(19, 335);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 39);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "🔄️ Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridViewshowapplicant
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewshowapplicant.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewshowapplicant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewshowapplicant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewshowapplicant.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewshowapplicant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewshowapplicant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewshowapplicant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SEEApplicants,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewshowapplicant.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewshowapplicant.EnableHeadersVisualStyles = false;
            this.dataGridViewshowapplicant.GridColor = System.Drawing.Color.Black;
            this.dataGridViewshowapplicant.Location = new System.Drawing.Point(19, 385);
            this.dataGridViewshowapplicant.MultiSelect = false;
            this.dataGridViewshowapplicant.Name = "dataGridViewshowapplicant";
            this.dataGridViewshowapplicant.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewshowapplicant.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewshowapplicant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewshowapplicant.Size = new System.Drawing.Size(1186, 322);
            this.dataGridViewshowapplicant.TabIndex = 5;
            this.dataGridViewshowapplicant.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewshowapplicant_CellClick);
            this.dataGridViewshowapplicant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewshowapplicant_CellContentClick);
            // 
            // SEEApplicants
            // 
            this.SEEApplicants.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SEEApplicants.HeaderText = "See Applicants";
            this.SEEApplicants.Name = "SEEApplicants";
            this.SEEApplicants.ReadOnly = true;
            this.SEEApplicants.Text = "SEE Applicants";
            this.SEEApplicants.UseColumnTextForButtonValue = true;
            this.SEEApplicants.Width = 117;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "DELETE";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "DELETE";
            this.Delete.ToolTipText = "DELETE";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 67;
            // 
            // Recuiter
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1218, 719);
            this.Controls.Add(this.dataGridViewshowapplicant);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.flowLayoutPanelButtons);
            this.Controls.Add(this.groupBoxForm);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Recuiter";
            this.Text = "Freelence Admin - CarrierHunt";
            this.Load += new System.EventHandler(this.Recuiter_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.groupBoxForm.ResumeLayout(false);
            this.groupBoxForm.PerformLayout();
            this.flowLayoutPanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewshowapplicant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnCloseHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.GroupBox groupBoxForm;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxptitle;
        private System.Windows.Forms.Label lblprojectDes;
        private System.Windows.Forms.TextBox textBoxprojectdescription;
        private System.Windows.Forms.Label lblrequiredskill;
        private System.Windows.Forms.TextBox textBoxrequiredskill;
        private System.Windows.Forms.Label lblbudget;
        private System.Windows.Forms.TextBox textBoxbudget;
        private System.Windows.Forms.Label lbldeadline;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadline;
        private System.Windows.Forms.Label lblexperience;
        private System.Windows.Forms.TextBox textBoxexperience;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button btnpublish;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnNotice;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridViewshowapplicant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbJobType;
        private System.Windows.Forms.DataGridViewButtonColumn SEEApplicants;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}