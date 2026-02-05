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
    public partial class ShowAllApplicant : Form
    {
        private readonly UserService service = new UserService();
        public ShowAllApplicant()
        {
            InitializeComponent();
        }

        private void lblApprovalName_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Close();
        }
        

        private void dgvShowAllApplicant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadApplicant()
        {
            try
            {
                DataTable dt = service.GetAllUsersByRole("Applicant");
                dgvShowAllApplicant.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading applicants: " + ex.Message);
            }
        }

        private void ShowAllApplicant_Load(object sender, EventArgs e)
        {
            LoadApplicant();
        }
    }
}
