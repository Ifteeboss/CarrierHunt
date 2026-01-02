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
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            UserService service = new UserService();
            string role = service.LogIn(txtUserName.Text.Trim(), txtPassword.Text.Trim());
            if (role == "Admin")
            {
                MessageBox.Show("Welcome Admin!");
                //Open admin dashboard
            }
            else if (role == "User")
            {
                MessageBox.Show("Login successful!");
                //Open user dashboard
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
