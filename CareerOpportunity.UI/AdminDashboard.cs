using CareerOpportunity.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CareerOpportunity.Models;

namespace CareerOpportunity.UI
{
    public partial class AdminDashboard : Form
    {
        private readonly UserService service = new UserService();
        private readonly JobService jobService = new JobService();
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void lblApplicantCount_Click(object sender, EventArgs e)
        {

        }

        private void RefreshPendingCounts()
        {
            ApplicantgroupBox.Text = $"Applicant Pending:{service.GetPendingCount("Applicant")}";
            RecruitergroupBox.Text = $"Recruiter Pending:{service.GetPendingCount("Recruiter")}";
            JobgroupBox.Text = $"Job Pending:{jobService.GetPendingJobsCount()}";

        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            RefreshPendingCounts();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblApplicantCount1_Click(object sender, EventArgs e)
        {

        }

        private void btnRecruiterApproval_Click(object sender, EventArgs e)
        {
            ApprovalRecruiter approval = new ApprovalRecruiter();
            approval.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ApprovalApplicant approvalApplicant = new ApprovalApplicant();
            approvalApplicant.ShowDialog();

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            SignUpApplicant signUpApplicant = new SignUpApplicant();
            signUpApplicant.ShowDialog();
        }

        private void btnRecruiter_Click(object sender, EventArgs e)
        {
            SignUpRecruiter signUpRecruiter = new SignUpRecruiter();
            signUpRecruiter.ShowDialog();
            btnExit.Hide();
        }

        private void btnModifyInfo_Click(object sender, EventArgs e)
        {
            ModifyUser modifyUser = new ModifyUser();
            modifyUser.ShowDialog();
            this.Hide();
        }

        private void btnAllApplicant_Click(object sender, EventArgs e)
        {
           ShowAllApplicant showAllApplicant = new ShowAllApplicant();
              showAllApplicant.ShowDialog();
            this.Close();
        }

        private void btnAllRecruiter_Click(object sender, EventArgs e)
        {
            ShowAllRecruiter showAllRecruiter = new ShowAllRecruiter();
            showAllRecruiter.ShowDialog();
            this.Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecruiterApproval_Click_1(object sender, EventArgs e)
        {
            ApprovalRecruiter approvalRecruiter = new ApprovalRecruiter();
            approvalRecruiter.ShowDialog();
            RefreshPendingCounts();
            this.Close();
            
        }

        private void btnApplicantApproval_Click(object sender, EventArgs e)
        {
            ApprovalApplicant approvalApplicant = new ApprovalApplicant();
            approvalApplicant.ShowDialog();
            RefreshPendingCounts();
            this.Close();
        }

        private void ApplicantgroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void btnJobApproval_Click(object sender, EventArgs e)
        {
            ApprovalJob approvalJob = new ApprovalJob();
            approvalJob.ShowDialog();
            RefreshPendingCounts();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            LogInForm login = new LogInForm();
            login.ShowDialog();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
