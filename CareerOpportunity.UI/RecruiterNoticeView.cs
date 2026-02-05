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
    public partial class RecruiterNoticeView : Form
    {
        private readonly RecruiterNoticeService _service;

        public RecruiterNoticeView()
        {
            InitializeComponent();
            _service = new RecruiterNoticeService();

            //initialze krtesi jno surutei call hye jai nahole grid e data load hobe na
            this.Load += RecruiterNoticeView_Load;
        }
        private void RecruiterNoticeView_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                ResetForm();
                StyleAdminGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form Load error: " + ex.ToString());
            }
        }


        // ================= LOAD DATA krtesi =================
        private bool LoadData()
        {
            try
            {
                dgvAdminPreview.DataSource = _service.GetAllNotices();
                dgvAdminPreview.ClearSelection();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("LoadData error: " + ex.Message);
                return false;
            }
        }


        // ================= RESET FORM krtesi =================
        private void ResetForm()
        {
            txtNoticeId.Text = "Auto Increment";
            NoticeTitle.Text = "";

            if (NoticeType.Items.Count > 0)
                NoticeType.SelectedIndex = -1;

            DetailsBox.Text = "";
            PublishDate.Value = DateTime.Now;
            DeadlineDate.Value = DateTime.Now.AddDays(7);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // apatoto lagbe na
        }

     

        // ================= SAVE krtesi button diye =================
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // amr logic gulo
                if (string.IsNullOrWhiteSpace(NoticeTitle.Text))
                {
                    MessageBox.Show("Notice title required");
                    return;
                }

                if (NoticeType.SelectedItem == null)
                {
                    MessageBox.Show("Please select notice type");
                    return;
                }

                if (DeadlineDate.Value < PublishDate.Value)
                {
                    MessageBox.Show("Deadline cannot be before publish date");
                    return;
                }

                // object baniye dilam eksathe rakhar jonno 
                Notice notice = new Notice
                {
                    NoticeTitle = NoticeTitle.Text.Trim(),
                    NoticeType = NoticeType.SelectedItem.ToString(),
                    DetailsBox = string.IsNullOrWhiteSpace(DetailsBox.Text)
                                    ? "Will publish later"
                                    : DetailsBox.Text.Trim(),
                    PublishDate = PublishDate.Value,
                    DeadlineDate = DeadlineDate.Value
                };

                // save krlam
                _service.AddNotice(notice);

                MessageBox.Show("Saved successfully");

                LoadData();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        

        // ================= REFRESH  krtesi=================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAdminPreview.DataSource = null;
                dgvAdminPreview.DataSource = _service.GetAllNotices();
                dgvAdminPreview.ClearSelection();

                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Refresh error: " + ex.Message);
            }
        }

        // ================= GRID DOUBLE CLICK button jate full row select kre ami update delete sob krte pari =================
        private void dgvAdminPreview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvAdminPreview.Rows[e.RowIndex];

            txtNoticeId.Text = row.Cells[0].Value.ToString();
            NoticeTitle.Text = row.Cells[1].Value.ToString();
            NoticeType.Text = row.Cells[2].Value.ToString();
            DetailsBox.Text = row.Cells[3].Value.ToString();
            PublishDate.Value = Convert.ToDateTime(row.Cells[4].Value);
            DeadlineDate.Value = Convert.ToDateTime(row.Cells[5].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // lagbe na
        }

        private void dgvAdminPreview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // lagbe na
        }

        // ================= UPDATE button er code =================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNoticeId.Text == "Auto Increment")
            {
                MessageBox.Show("Please select a notice first");
                return;
            }

            Notice notice = new Notice
            {
                NoticeId = int.Parse(txtNoticeId.Text),
                NoticeTitle = NoticeTitle.Text,
                NoticeType = NoticeType.Text,
                DetailsBox = DetailsBox.Text,
                PublishDate = PublishDate.Value,
                DeadlineDate = DeadlineDate.Value
            };

            _service.UpdateNotice(notice);

            MessageBox.Show("Notice updated successfully");
            LoadData();
            ResetForm();
        }

        // ================= DELETE button er code =================
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (txtNoticeId.Text == "Auto Increment")
            {
                MessageBox.Show("Please select a notice first");
                return;
            }

            int id = int.Parse(txtNoticeId.Text);
            _service.DeleteNotice(id);

            MessageBox.Show("Notice deleted successfully");
            LoadData();
            ResetForm();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // lagbe na,complexity besi version alada kaj korbe na
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    MessageBox.Show("Enter Notice ID");
                    return;
                }

                int id = int.Parse(txtSearch.Text);

                var result = _service.SearchNoticeById(id);

                if (result.Count == 0)
                {
                    MessageBox.Show("No notice found");
                    return;
                }

                dgvAdminPreview.DataSource = null;
                dgvAdminPreview.DataSource = result;
                dgvAdminPreview.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            // lagbe na
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Recuiter recuiter = new Recuiter(1);
            recuiter.Show();
            this.Close();

        }

        private void dgvAdminPreview_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // gpt diye colour kralam button er jonno
            int statusColumnIndex = dgvAdminPreview.Columns["Status"].Index;

            if (e.ColumnIndex == statusColumnIndex && e.Value != null)
            {
                string status = e.Value.ToString();

                e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                if (status == "Active")
                {
                    e.CellStyle.BackColor = Color.FromArgb(232, 245, 233); // light green
                    e.CellStyle.ForeColor = Color.FromArgb(56, 142, 60);   // dark green
                    e.CellStyle.SelectionBackColor = e.CellStyle.BackColor;
                }
                else if (status == "Expired")
                {
                    e.CellStyle.BackColor = Color.FromArgb(255, 235, 238); // light red
                    e.CellStyle.ForeColor = Color.FromArgb(198, 40, 40);   // dark red
                    e.CellStyle.SelectionBackColor = e.CellStyle.BackColor;
                }
            }
        }
        

        // ================= GRID STYLE  for decoration =================
        private void StyleAdminGrid()
        {
            dgvAdminPreview.EnableHeadersVisualStyles = false;
            dgvAdminPreview.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(63, 81, 181);
            dgvAdminPreview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAdminPreview.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ColorNoticeIdColumn_RowLoop()
        {
            // lagbe na
        }

        private void dgvAdminPreview_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // lagbe na
        }

        private void RecruiterNoticeView_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadData();
            ResetForm();
        }
    }
}
