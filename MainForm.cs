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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        

        private void MainForm_Load(object sender, EventArgs e)
        {

        } 

        private void hệThốngQuảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var QLHD = new BillManagementForm();
            QLHD.ShowDialog();
        }

        private void quảnLýBànToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var QLDB = new QuanLyDatBan();
            QLDB.ShowDialog();
        }

        private void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reportForm = new RevenueReportForm();
            reportForm.ShowDialog();
        }

        private void quảnLýThựcĐơnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var menuForm = new MenuForm();
            menuForm.ShowDialog();
        }
    }
}
