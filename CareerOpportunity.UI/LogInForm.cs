using CareerOpportunity.BLL;
using CareerOpportunity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CareerOpportunity.UI
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }



        private void LogInForm_Load(object sender, EventArgs e)
        {


        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            SignUpApplicant signUpForm = new SignUpApplicant();
            signUpForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            UserService service = new UserService();
            User user = service.LogIn(txtUserName.Text.Trim(),txtPassword.Text.Trim());

            if(user == null)
            {
                MessageBox.Show("Invalid username or password or account not appeoved yet.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            MessageBox.Show($"Role: {user.Role}\n Welcome {user.UserName}!", "Log In Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

            if (user.Role == "Admin") 
            {
                //admin dashboard
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
                this.Hide();
            }
            else if(user.Role == "Applicant")
            {
                this.Hide();
                UserJob userJob = new UserJob(user.Id);
                userJob.Show();
                

            }
            else if(user.Role== "Recruiter")
            {
                 Recuiter recuiter = new Recuiter(user.Id);
                 recuiter.Show();
                 this.Hide();
            }

        }

        private void lblOr_Click(object sender, EventArgs e)
        {

        }

        private void btnRecruiter_Click(object sender, EventArgs e)
        {
            SignUpRecruiter signUpRecruiter = new SignUpRecruiter();
            signUpRecruiter.Show();
            this.Hide();
            
        }

        private void btnSignUpApplicant_Click(object sender, EventArgs e)
        {
            SignUpApplicant signUpApplicant = new SignUpApplicant();
            signUpApplicant.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
