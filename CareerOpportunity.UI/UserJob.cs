using CareerOpportunity.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace CareerOpportunity.UI
{
    public partial class UserJob : Form
    {
        private readonly RecuiterRepository repo = new RecuiterRepository();
        private readonly int _userId;
        private readonly ApplicationsRepository repo1 = new ApplicationsRepository();


        public UserJob(int userId)
        {
            InitializeComponent();
            _userId = userId;
            this.Load += new System.EventHandler(this.UserJob_Load);
            dataGridViewseeuser.CellContentClick += dataGridViewseeuser_CellContentClick;

        }

        private void UserJob_Load(object sender, EventArgs e)
        {
            LoadApprovedJobs();
            LoadAppliedCount();
        }

        // ✅ Loads the same job data style as Admin/Recruiter (but only Approved)
        private void LoadApprovedJobs()
        {
            dataGridViewseeuser.Columns.Clear();  // ✅ clears old Apply too

            DataTable dt = repo.GetApprovedJobs();
            dataGridViewseeuser.AutoGenerateColumns = true;
            dataGridViewseeuser.DataSource = dt;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnApply";
            btn.HeaderText = "Apply";
            btn.Text = "Apply";
            btn.UseColumnTextForButtonValue = true;
            dataGridViewseeuser.Columns.Add(btn);

            dataGridViewseeuser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        // ✅ Apply button click
        private void dataGridViewseeuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
                if (dataGridViewseeuser.Columns[e.ColumnIndex].Name != "btnApply") return;

                int jobId = Convert.ToInt32(dataGridViewseeuser.Rows[e.RowIndex].Cells["JobID"].Value);

                int rows = repo.ApplyForJob(jobId, _userId);

                if (rows > 0)
                {
                    MessageBox.Show("Applied successfully!");
                    LoadAppliedCount();
                }
                else
                {
                    MessageBox.Show("You already applied for this job.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Apply Error");
            }
        }


        // Optional: Refresh button if you have one
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadApprovedJobs();
            LoadAppliedCount();
        }

        private void lblapplied_Click(object sender, EventArgs e)
        {

        }


        // this is counting applied jobs by user id
        private void LoadAppliedCount()
        {
            try
            {
                int count = repo1.GetAppliedJobCount(_userId);
                label1.Text = $"Applied : {count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            LoadAppliedCount();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LogInForm login = new LogInForm();
            login.Show();
            this.Hide();
        }

        private void btnCloseHeader_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNotice_Click(object sender, EventArgs e)
        {
           ApplicantNoticeView notice = new ApplicantNoticeView();
            notice.Show();
            this.Hide();
        }
    }
}
