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
using CareerOpportunity.Models;

namespace CareerOpportunity.UI
{
    public partial class ModifyUser : Form
    {
        private readonly UserService service = new UserService();
        public ModifyUser()
        {
            InitializeComponent();
        }

        private void ModifyUser_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchById.Text, out int userId))
            {
                User user = service.GetUserById(userId);
                if (user != null)
                {
                    dgvUsers.DataSource = null;
                    dgvUsers.Rows.Clear();
                    dgvUsers.Rows.Add(user.Id, user.UserName, user.Password, user.Email, user.Role, user.CompanyName,user.IsApproved);
                }
                else
                {
                    MessageBox.Show("User not found.");
                    dgvUsers.Rows.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid User ID.");
                dgvUsers.Rows.Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0) 
            {
                int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells[0].Value);
                UpdateUserInfo updateForm = new UpdateUserInfo(userId);
                updateForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a user to update.");
            }
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count >0)
            {
                int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells[0].Value);
                var confirmResult = MessageBox.Show("Are you sure to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    string result = service.DeleteUser(userId);
                    MessageBox.Show(result,"",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                    dgvUsers.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Close();
        }
    }
}
