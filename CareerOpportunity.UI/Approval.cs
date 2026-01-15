using CareerOpportunity.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CareerOpportunity.UI
{
    public partial class Approval : Form
    {
        private readonly UserService service = new UserService();
        public Approval()
        {
            InitializeComponent();
        }

        private void ApprovalDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            string columnName = ApprovalDataGridView.Columns[e.ColumnIndex].Name;
            int userId = Convert.ToInt32(ApprovalDataGridView.Rows[e.RowIndex].Cells[0].Value);
          
            if(columnName == "btnApprove")
            {
                string result = service.ApproveUser(userId);
                MessageBox.Show(result,"",MessageBoxButtons.OK,MessageBoxIcon.Question);
                
            }
            else if(columnName == "btnReject")
            {
                string result = service.RejectUser(userId);
                MessageBox.Show(result,"",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
        }

        private void LoadPendingUsers()
        {
            try
            {
                
                ApprovalDataGridView.DataSource = service.GetPendingUsers();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading pending users: " + ex.Message);
            }
        }

        private void Approval_Load(object sender, EventArgs e)
        {
            LoadPendingUsers();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPendingUsers();
        }

        private void ApprovalDataGridView_BackgroundColorChanged(object sender, EventArgs e)
        {

        }
    }
}
