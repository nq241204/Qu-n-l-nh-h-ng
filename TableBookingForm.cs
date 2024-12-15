using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class TableBookingForm : Form
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();
        public TableBookingForm()
        {
            InitializeComponent();
            LoadTableStatus();
        }
        private void LoadTableStatus()
        {
            try
            {
                string query = "SELECT TableNumber AS [Table Number], Status FROM Tables";
                DataTable tableStatus = dbHelper.ExecuteQuery(query);
                dgvTables.DataSource = tableStatus;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading table status: " + ex.Message);
            }
        }
        private void TableBookingForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBookTable_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTables.SelectedRows.Count > 0)
                {
                    int tableNumber = Convert.ToInt32(dgvTables.SelectedRows[0].Cells[0].Value);
                    string query = "UPDATE Tables SET Status = 'Đã đặt' WHERE TableNumber = @TableNumber";
                    SqlParameter[] parameters = {
                        new SqlParameter("@TableNumber", tableNumber)
                    };
                    dbHelper.ExecuteNonQuery(query, parameters);

                    MessageBox.Show("Table booked successfully!");
                    LoadTableStatus();
                }
                else
                {
                    MessageBox.Show("Please select a table.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error booking table: " + ex.Message);
            }
        }

        private void btnViewMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
