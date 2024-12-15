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
    public partial class MenuViewForm : Form
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();
        public MenuViewForm()
        {
            InitializeComponent();
            LoadMenuItems();
        }

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadMenuItems()
        {
            try
            {
                string query = "SELECT Name AS [Dish Name], Price, Category FROM MenuItems";
                DataTable menuTable = dbHelper.ExecuteQuery(query);
                dataGridViewMenu.DataSource = menuTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading menu: " + ex.Message);
            }
        }
        private void MenuViewForm_Load(object sender, EventArgs e)
        {

        }

        private void btnViewMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
