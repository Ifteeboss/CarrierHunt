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
    public partial class UpdateUserInfo : Form
    {
        private readonly UserService service = new UserService();
        private readonly int userId;
        public UpdateUserInfo(int id)
        {
            InitializeComponent();
            userId = id;
            LoadUser();
        }

        private void LoadUser()
        {
            User user = service.GetUserById(userId);
            if (user != null)
            {
                txtUserName.Text = user.UserName;
                txtPassword.Text = user.Password;
                txtEmail.Text = user.Email;
                cmbRole.SelectedItem = user.Role;
                txtCompanyName.Text = user.CompanyName;

                if(user.Role == "Applicant")
                {
                    txtCompanyName.Enabled = false;
                    txtCompanyName.Text = "";
                }
                else
                {
                    txtCompanyName.Enabled = true;
                }
                
            }
            else
            {
                MessageBox.Show("User not found.");
                this.Close();
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.SelectedItem.ToString() == "Applicant")
            {
                txtCompanyName.Enabled = false;
                txtCompanyName.Text = "";

            }
            else
            {
                txtCompanyName.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cmbRole.SelectedItem.ToString()== "Applicant" && ! string.IsNullOrEmpty(txtCompanyName.Text))
            {
                MessageBox.Show("Applicants cannot have a company name.");
                return;
            }
            User user = new User
            {
                Id = userId,
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                Email = txtEmail.Text,
                Role = cmbRole.SelectedItem.ToString(),
                CompanyName = txtCompanyName.Text,
                
            };
            string result = service.UpdateUser(user);
            MessageBox.Show(result);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModifyUser modifyUser = new ModifyUser();
            modifyUser.Show();
            this.Close();
        }
    }
}
