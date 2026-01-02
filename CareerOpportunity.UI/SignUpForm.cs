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
using CareerOpportunity.BLL;


namespace CareerOpportunity.UI
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                UserService service = new UserService();
                User newUser = new Models.User()
                {
                    UserName = txtUserName.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    Email = txtEmail.Text.Trim()
                };
                string confirmPassword = txtReEnterPassword.Text.Trim();
                bool agreedTerms = checkboxCondition.Checked;

                string result = service.SignUp(newUser, confirmPassword, agreedTerms);
                MessageBox.Show(result);

                if (result == "Sign up successful!")
                {
                    LogInForm logInForm = new LogInForm();
                    logInForm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
