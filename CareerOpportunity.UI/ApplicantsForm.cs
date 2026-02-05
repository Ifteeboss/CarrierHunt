using System;
using System.Data;
using System.Windows.Forms;
using CareerOpportunity.DAL;

namespace CareerOpportunity.UI
{
    public partial class ApplicantsForm : Form
    {
        private readonly int _jobId;
        private readonly ApplicationsRepository repo = new ApplicationsRepository();

        public ApplicantsForm(int jobId)
        {
            InitializeComponent();
            _jobId = jobId;
            this.Load += new System.EventHandler(this.ApplicantsForm_Load);

        }

        private void ApplicantsForm_Load(object sender, EventArgs e)
        {
            LoadApplicants();
        }

        private void LoadApplicants()
        {
            try
            {
                DataTable dt = repo.GetApplicantsByJobId(_jobId);
                MessageBox.Show("Applicants: " + dt.Rows.Count);

                dataGridApplicants.AutoGenerateColumns = true;
                dataGridApplicants.DataSource = dt;

                dataGridApplicants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridApplicants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridApplicants.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void dataGridApplicants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Close();
        }

        private void btnNotice_Click(object sender, EventArgs e)
        {
            ApplicantNoticeView a = new ApplicantNoticeView();
            a.Show();
            this.Close();
        }

    }
}
