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
    public partial class ShowAllRecruiter : Form
    {
        UserService service = new UserService();
        public ShowAllRecruiter()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Close();
        }

        private void ShowAllRecruiter_Load(object sender, EventArgs e)
        {
            LoadRecruiter();
        }
        private void LoadRecruiter()
        {
            try
            {
                DataTable recruitersTable = service.GetAllUsersByRole("Recruiter");
                dgvShowAllRecruiter.DataSource = recruitersTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading recruiters: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
