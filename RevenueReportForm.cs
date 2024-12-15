using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class RevenueReportForm : Form
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();
        public RevenueReportForm()
        {
            InitializeComponent();
        }

        private void RevenueReportForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpStartDate.Value.Date;

            string query = $"SELECT * FROM RevenueReports WHERE Date BETWEEN '{startDate}' AND '{endDate}'";
            DataTable reports = dbHelper.ExecuteQuery(query);
            dgvReports.DataSource = reports;
        }
    }
}
