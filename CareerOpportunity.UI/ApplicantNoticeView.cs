using CareerOpportunity.BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CareerOpportunity.UI
{
    public partial class ApplicantNoticeView : Form
    {
        private readonly ApplicantNoticeService _service;

        public ApplicantNoticeView()
        {
            InitializeComponent();
            _service = new ApplicantNoticeService();
        }

        private void ApplicantNoticeView_Load(object sender, EventArgs e)
        {
            cmbFilterBox.SelectedIndex = 0;
            LoadData();
            StyleGrid();
        }

        private void LoadData()
        {
            dgvUserNotice.DataSource = _service.GetAll();
            dgvUserNotice.ClearSelection();
        }

        private void cmbFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterBox.SelectedIndex == 0)
                LoadData();
            else
                dgvUserNotice.DataSource = _service.Filter(cmbFilterBox.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchNoticeId.Text)) return;

            int id = Convert.ToInt32(txtSearchNoticeId.Text);
            dgvUserNotice.DataSource = _service.SearchById(id);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchNoticeId.Text = "";
            cmbFilterBox.SelectedIndex = 0;
            LoadData();
        }

        private void StyleGrid()
        {
            dgvUserNotice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ⛔ Unused buttons/events — keep empty
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void dgvUserNotice_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) {
            UserJob userJobForm = new UserJob(1);
            userJobForm.Show();
            this.Close();

        }

        private void ApplicantNoticeView_Load_1(object sender, EventArgs e)
        {
            // 🔒 Temporarily detach event
            cmbFilterBox.SelectedIndexChanged -= cmbFilterBox_SelectedIndexChanged;

            LoadData();          // ✅ FIRST load all data
            StyleGrid();

            cmbFilterBox.SelectedIndex = 0;  // All
            cmbFilterBox.SelectedIndexChanged += cmbFilterBox_SelectedIndexChanged;
        }

        private void dgvUserNotice_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUserNotice.Columns[e.ColumnIndex].Name == "Status")
            {
                DateTime deadline =
                    Convert.ToDateTime(dgvUserNotice.Rows[e.RowIndex]
                    .Cells["DeadlineDate"].Value);

                if (deadline >= DateTime.Today)
                {
                    e.Value = "Active";
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.BackColor = Color.FromArgb(232, 245, 233); // Active bg
                    e.CellStyle.ForeColor = Color.FromArgb(56, 142, 60);

                }
                else
                {
                    e.Value = "Expired";
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.BackColor = Color.FromArgb(255, 235, 238); // Expired bg
                    e.CellStyle.ForeColor = Color.FromArgb(198, 40, 40);

                }

                e.FormattingApplied = true;
            }
        }

        private void txtSearchNoticeId_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvUserNotice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
