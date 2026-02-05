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
    public partial class SignUpRecruiter : Form
    {
        public SignUpRecruiter()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                UserService service = new UserService();
                User newUser = new User()
                {
                    UserName = txtUserName.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    CompanyName = txtCompanyName.Text.Trim(),
                    IsApproved = false,

                };
                string confirmPassword =txtReEnterPassword.Text.Trim();
                bool agreedTerms = checkboxCondition.Checked;

                string result = service.SignUpRecruiter(newUser, confirmPassword, agreedTerms);
                MessageBox.Show(result);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Close();
        }
    }
}
