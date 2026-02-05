using System;
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

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            // Populate Dropdown
            roleComboBox.Items.Clear();
            roleComboBox.Items.Add("User");
            roleComboBox.Items.Add("Recruiter");
            roleComboBox.SelectedIndex = 0;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                if (roleComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a role.");
                    return;
                }

                UserService service = new UserService();
                User newUser = new Models.User()
                {
                    UserName = txtUserName.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Role = roleComboBox.SelectedItem.ToString()
                };

                string result = service.SignUp(newUser, txtReEnterPassword.Text.Trim(), checkboxCondition.Checked);

                MessageBox.Show(result);

                // If success, go to login
                if (result.StartsWith("Sign up successful"))
                {
                    LogInForm logInForm = new LogInForm();
                    logInForm.Show();
                    this.Hide();
                }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void roleComboBox_ControlAdded(object sender, ControlEventArgs e) { }
        private void panelRight_Paint(object sender, PaintEventArgs e) { }
    }
}