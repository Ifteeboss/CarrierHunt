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
                    Email = txtEmail.Text.Trim(),
                    Role = roleComboBox.SelectedItem.ToString()
                };
                string confirmPassword = txtReEnterPassword.Text.Trim();
                bool agreedTerms = checkboxCondition.Checked;
               

                string result = service.SignUp(newUser, confirmPassword, agreedTerms);
                MessageBox.Show(result);

                //if (result = "Sign up successful!")
                
                   
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            
        }

        private void roleComboBox_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            roleComboBox.Items.Add("User");
            roleComboBox.Items.Add("Recruiter");
            roleComboBox.SelectedIndex = 0;
           
        }
    }
}
