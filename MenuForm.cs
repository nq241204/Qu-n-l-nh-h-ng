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
    public partial class MenuForm : Form
    {
        private DatabaseHelper dbHelper;
        public MenuForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            LoadMenuItems();
        }
        private void LoadMenuItems()
        {
            string query = "SELECT * FROM MenuItems";
            DataTable menuItems = dbHelper.ExecuteQuery(query);
            dataGridViewMenu.DataSource = menuItems;
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên món ăn không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Giá món ăn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Loại món ăn không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Chèn vào cơ sở dữ liệu
            string query = $"INSERT INTO MenuItems (Name, Price, Category) VALUES ('{txtName.Text}', {price}, '{txtCategory.Text}')";
            dbHelper.ExecuteNonQuery(query);

            // Cập nhật lại danh sách món ăn
            LoadMenuItems();
            MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenu.SelectedRows.Count > 0)
            {
                int id = (int)dataGridViewMenu.SelectedRows[0].Cells["ID"].Value;
                string name = txtName.Text;
                decimal price = decimal.Parse(txtPrice.Text);
                string category = txtCategory.Text;

                string query = $"UPDATE MenuItems SET Name = '{name}', Price = {price}, Category = '{category}' WHERE ID = {id}";
                dbHelper.ExecuteNonQuery(query);
                LoadMenuItems();
                MessageBox.Show("Sửa món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewMenu.SelectedRows[0].Cells["ID"].Value.ToString());
            string query = $"DELETE FROM MenuItems WHERE ID = {id}";
            dbHelper.ExecuteNonQuery(query);
            LoadMenuItems();
            MessageBox.Show("Xóa món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
