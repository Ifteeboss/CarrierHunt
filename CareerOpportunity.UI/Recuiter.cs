using CareerOpportunity.DAL;
using CareerOpportunity.Models;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CareerOpportunity.UI
{
    public partial class Recuiter : Form
    {
        private int rId;
        private int SelectedJobId = 0;
        private readonly RecuiterRepository repo = new RecuiterRepository();

        public Recuiter(int recuiterId)
        {
            InitializeComponent();
            rId = recuiterId;
        }

        private void Recuiter_Load(object sender, EventArgs e)
        {
            cmbJobType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJobType.Items.Clear();
            cmbJobType.Items.Add("Internship");
            cmbJobType.Items.Add("Freelance");
            cmbJobType.SelectedIndex = 0;
            LoadJobs();
        }

        private void LoadJobs()
        {
            DataTable dt = repo.GetJobsByRecruiter(rId);

            dataGridViewshowapplicant.AutoGenerateColumns = true;
            dataGridViewshowapplicant.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewshowapplicant.RowHeadersVisible = false;
            dataGridViewshowapplicant.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewshowapplicant.RowsDefaultCellStyle.ForeColor = Color.Black;
            dataGridViewshowapplicant.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewshowapplicant.MultiSelect = false;

            dataGridViewshowapplicant.DataSource = dt;
        }

        private void btnpublish_Click(object sender, EventArgs e)
        {
            Job job = new Job
            {
                RecruiterID = rId,
                Title = textBoxptitle.Text.Trim(),
                Description = textBoxprojectdescription.Text.Trim(),
                RequiredSkill = textBoxrequiredskill.Text.Trim(),
                Experience = textBoxexperience.Text.Trim(),
                SalaryOrBudget = textBoxbudget.Text.Trim(),
                JobType = cmbJobType.SelectedItem?.ToString(),
                Deadline = dateTimePickerDeadline.Value.Date
            };

            if (string.IsNullOrWhiteSpace(job.Title) ||
                string.IsNullOrWhiteSpace(job.Description) ||
                string.IsNullOrWhiteSpace(job.RequiredSkill) ||
                string.IsNullOrWhiteSpace(job.Experience) ||
                string.IsNullOrWhiteSpace(job.SalaryOrBudget) ||
                string.IsNullOrWhiteSpace(job.JobType))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (job.Deadline < DateTime.Now.Date)
            {
                MessageBox.Show("Deadline cannot be in the past.");
                return;
            }

            int rows = repo.PublishJob(job);

            if (rows > 0)
            {
                MessageBox.Show("Job published successfully and is pending admin approval.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadJobs();
            }
            else
            {
                MessageBox.Show("Failed to publish job.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            textBoxptitle.Clear();
            textBoxprojectdescription.Clear();
            textBoxrequiredskill.Clear();
            textBoxbudget.Clear();
            textBoxexperience.Clear();
            cmbJobType.SelectedIndex = 0;
            dateTimePickerDeadline.Value = DateTime.Now;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SelectedJobId == 0)
            {
                MessageBox.Show("Please select a job to update.");
                return;
            }

            Job job = new Job
            {
                JobID = SelectedJobId,
                RecruiterID = rId,
                Title = textBoxptitle.Text.Trim(),
                Description = textBoxprojectdescription.Text.Trim(),
                RequiredSkill = textBoxrequiredskill.Text.Trim(),
                Experience = textBoxexperience.Text.Trim(),
                SalaryOrBudget = textBoxbudget.Text.Trim(),
                JobType = cmbJobType.SelectedItem?.ToString(),
                Deadline = dateTimePickerDeadline.Value.Date
            };

            if (string.IsNullOrWhiteSpace(job.Title) ||
                string.IsNullOrWhiteSpace(job.Description) ||
                string.IsNullOrWhiteSpace(job.RequiredSkill) ||
                string.IsNullOrWhiteSpace(job.Experience) ||
                string.IsNullOrWhiteSpace(job.SalaryOrBudget) ||
                string.IsNullOrWhiteSpace(job.JobType))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (job.Deadline < DateTime.Now.Date)
            {
                MessageBox.Show("Deadline cannot be in the past.");
                return;
            }

            int rows = repo.Update(job);

            if (rows > 0)
            {
                MessageBox.Show("Job updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                SelectedJobId = 0;
                LoadJobs();
            }
            else
            {
                MessageBox.Show("Failed to update job.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Logic for populating form when row is clicked
        private void dataGridViewshowapplicant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var rowView = dataGridViewshowapplicant.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (rowView == null) return;

            // FIX: Postgres returns lowercase column names. Use "jobid" instead of "JobID"
            if (rowView["JobID"] == DBNull.Value) return;

            SelectedJobId = Convert.ToInt32(rowView["JobID"]);

            // FIX: Updated all keys to lowercase to match PostgreSQL DataTable
            textBoxptitle.Text = rowView["Title"]?.ToString();
            textBoxbudget.Text = rowView["SalaryOrBudget"]?.ToString();
            textBoxexperience.Text = rowView["Experience"]?.ToString();
            textBoxrequiredskill.Text = rowView["RequiredSkill"]?.ToString();
            textBoxprojectdescription.Text = rowView["Description"]?.ToString();

            string jobType = rowView["JobType"]?.ToString();
            if (!string.IsNullOrWhiteSpace(jobType))
                cmbJobType.SelectedItem = jobType;

            object ddl = rowView["Deadline"];
            if (ddl != null && ddl != DBNull.Value)
                dateTimePickerDeadline.Value = Convert.ToDateTime(ddl);
        }

        // Logic for handling buttons inside the grid
        private void dataGridViewshowapplicant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (!(dataGridViewshowapplicant.Columns[e.ColumnIndex] is DataGridViewButtonColumn))
                return;

            var rowView = dataGridViewshowapplicant.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (rowView == null) return;

            // FIX: Use lowercase "jobid"
            if (rowView["jobid"] == DBNull.Value) return;

            int jobId = Convert.ToInt32(rowView["jobid"]);

            string btnText = dataGridViewshowapplicant.Rows[e.RowIndex]
                .Cells[e.ColumnIndex].FormattedValue?.ToString();

            if (btnText == "SEE Applicants")
            {
                ApplicantsForm a = new ApplicantsForm(jobId);
                a.ShowDialog();
                return;
            }

            if (btnText == "DELETE")
            {
                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete this job?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    bool isDeleted = repo.DeleteJob(jobId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Job deleted successfully.");
                        ClearForm();
                        SelectedJobId = 0;
                        LoadJobs();
                    }
                    else
                    {
                        MessageBox.Show("Delete failed.");
                    }
                }
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Close();
        }

        private void btnNotice_Click(object sender, EventArgs e)
        {
            RecruiterNoticeView a = new RecruiterNoticeView();
            a.ShowDialog();
            this.Hide();
        }

        // Empty event handlers kept to avoid Designer errors

    }
}