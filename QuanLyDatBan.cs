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
    public partial class QuanLyDatBan : Form
    {
        private DatabaseHelper dbHelper;
        public QuanLyDatBan()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            LoadTables();
        }
        private void LoadTables()
        {
            string query = "SELECT * FROM Tables";
            DataTable tables = dbHelper.ExecuteQuery(query);
            dgvTables.DataSource = tables;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvTables.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bàn để cập nhật trạng thái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = dgvTables.SelectedRows[0];
            int tableId = Convert.ToInt32(row.Cells["ID"].Value);

            string status = cbStatus.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Vui lòng chọn trạng thái hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cập nhật trạng thái trong cơ sở dữ liệu
            string query = $"UPDATE Tables SET Status = '{status}' WHERE ID = {tableId}";
            dbHelper.ExecuteNonQuery(query);

            MessageBox.Show("Cập nhật trạng thái bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Tải lại danh sách bàn
            LoadTables();
        }
        private void LoadTablesWithComboBox()
        {
            string query = "SELECT ID, TableNumber, Status FROM Tables";
            DataTable dataTable = dbHelper.ExecuteQuery(query);

            dgvTables.DataSource = dataTable;

            // Thêm cột ComboBox vào DataGridView
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Trạng thái",
                DataSource = new string[] { "Trống", "Đã đặt", "Đang sử dụng" },
                DataPropertyName = "Status", // Liên kết với cột 'Status' trong DataTable
            };
            dgvTables.Columns.Add(comboBoxColumn);
        }
        private void dgvTables_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTables.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvTables.SelectedRows[0];

                // Lấy trạng thái từ cột 'Status'
                string status = row.Cells["Status"].Value.ToString();

                // Đặt trạng thái tương ứng trong ComboBox
                cbStatus.SelectedItem = status;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvTables.SelectedRows.Count > 0)
            {
                int id = (int)dgvTables.SelectedRows[0].Cells["ID"].Value;

                string query = $"UPDATE Tables SET Status = 'Đã đặt' WHERE ID = {id}";
                dbHelper.ExecuteNonQuery(query);
                LoadTables();
            }
        }

        private void QuanLyDatBan_Load(object sender, EventArgs e)
        {

            // Các trạng thái có sẵn
            cbStatus.Items.Add("Trống");
            cbStatus.Items.Add("Đã đặt");
            cbStatus.Items.Add("Đang sử dụng");

            // Tải danh sách bàn
            LoadTables();
        }

      
    }
}
