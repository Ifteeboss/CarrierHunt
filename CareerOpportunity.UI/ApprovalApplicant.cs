using CareerOpportunity.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CareerOpportunity.UI
{
    public partial class ApprovalApplicant : Form
    {
        private readonly UserService service = new UserService();
        public ApprovalApplicant()
        {
            InitializeComponent();
        }

        private void ApprovalDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            string columnName = ApplicantApprovalDataGridView.Columns[e.ColumnIndex].Name;
            int userId = Convert.ToInt32(ApplicantApprovalDataGridView.Rows[e.RowIndex].Cells[0].Value);
          
            if(columnName == "btnApprove")
            {
                string result = service.ApproveUser(userId);
                MessageBox.Show(result,"Approval",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
            else if(columnName == "btnReject")
            {
                string result = service.RejectUser(userId);
                MessageBox.Show(result,"Rejection",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

            }
        }

        private void LoadPendingUsers(string role)
        {
            try
            {
                
                ApplicantApprovalDataGridView.DataSource = service.GetPendingUsers(role);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading pending users: " + ex.Message);
            }
        }

        private void Approval_Load(object sender, EventArgs e)
        {
            LoadPendingUsers("Applicant");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPendingUsers("Applicant");
        }

        private void ApprovalDataGridView_BackgroundColorChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Close();
        }

        private void lblApprovalName_Click(object sender, EventArgs e)
        {

        }
    }
}
