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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnViewMenu_Click(object sender, EventArgs e)
        {
            MenuViewForm menuView = new MenuViewForm();
            menuView.ShowDialog();
        }

        private void btnBookTable_Click(object sender, EventArgs e)
        {
            TableBookingForm tableBooking = new TableBookingForm();
            tableBooking.ShowDialog();
        }

        private void btnRequestBill_Click(object sender, EventArgs e)
        {
            BillRequestForm billRequest = new BillRequestForm();
            billRequest.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
