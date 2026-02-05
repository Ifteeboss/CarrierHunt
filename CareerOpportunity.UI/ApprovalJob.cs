using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CareerOpportunity.BLL;

namespace CareerOpportunity.UI
{
    public partial class ApprovalJob : Form
    {
        private readonly JobService jobService = new JobService();
        public ApprovalJob()
        {
            InitializeComponent();
        }
        private void LoadPendingJobs()
        {
            dgvJobs.DataSource = jobService.GetPendingJobs();
        }
        private void ApprovalJob_Load(object sender, EventArgs e)
        {
            LoadPendingJobs();
        }


        private void dgvJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int jobId = Convert.ToInt32(dgvJobs.Rows[e.RowIndex].Cells[0].Value);

                if (dgvJobs.Columns[e.ColumnIndex].Name == "btnApprove")
                {
                    MessageBox.Show(jobService.ApproveJob(jobId));
                    dgvJobs.DataSource = jobService.GetPendingJobs();
                }
                else if (dgvJobs.Columns[e.ColumnIndex].Name == "btnReject")
                {
                    MessageBox.Show(jobService.RejectJob(jobId));
                    dgvJobs.DataSource = jobService.GetPendingJobs();
                }

            }
        }

       
        private void btnExit_Click(object sender, EventArgs e)
        {
            //AdminDashboard dashboard = new AdminDashboard();
           // dashboard.Show();
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           LoadPendingJobs();
        }
    }
}
