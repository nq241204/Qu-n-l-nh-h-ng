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
    public partial class BillManagementForm : Form
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();

        public BillManagementForm()
        {
            InitializeComponent();
        }
      

        private void BillManagementForm_Load(object sender, EventArgs e)
        {                     
            InitializeDataGridView();
            LoadTables();
            LoadMenuItems();

        }
        private void LoadTables()
        {
            string query = "SELECT ID, TableNumber FROM Tables WHERE Status = 'Đang sử dụng'";
            DataTable tables = dbHelper.ExecuteQuery(query);

            cbTables.DisplayMember = "TableNumber";
            cbTables.ValueMember = "ID";
            cbTables.DataSource = tables;
        }
        private void LoadMenuItems()
        {
            string query = "SELECT ID, Name FROM MenuItems";
            DataTable menuItems = dbHelper.ExecuteQuery(query);

            cbMenuItems.DisplayMember = "Name";
            cbMenuItems.ValueMember = "ID";
            cbMenuItems.DataSource = menuItems;
        }

        private void btnRequestBill_Click(object sender, EventArgs e)
        {
            int menuItemId = (int)cbMenuItems.SelectedValue;
            string menuItemName = cbMenuItems.Text;
            int quantity = 1; // Giả sử số lượng là 1. Bạn có thể thêm TextBox để nhập số lượng
            decimal price = GetMenuItemPrice(menuItemId);

            // Tính tổng tiền cho món ăn
            decimal total = price * quantity;
       
            // Thêm món vào DataGridView
            dgvBillDetails.Rows.Add(menuItemId, menuItemName, quantity, price, total);
        }
        private decimal GetMenuItemPrice(int menuItemId)
        {
            string query = "SELECT Price FROM MenuItems WHERE ID = @MenuItemId";
            SqlParameter[] parameters = { new SqlParameter("@MenuItemId", menuItemId) };
            return (decimal)dbHelper.ExecuteQuery(query, parameters).Rows[0]["Price"];
        }
        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tableId = (int)cbTables.SelectedValue;

            // Tải thông tin hóa đơn của bàn từ cơ sở dữ liệu
            string query = "SELECT * FROM Orders WHERE TableID = @TableId AND Status = 'Đang sử dụng'";
            SqlParameter[] parameters = { new SqlParameter("@TableId", tableId) };
            DataTable orderData = dbHelper.ExecuteQuery(query, parameters);

            // Nếu có hóa đơn, hiển thị thông tin hóa đơn
            if (orderData.Rows.Count > 0)
            {
                // Hiển thị thông tin hóa đơn
                // (Cập nhật DataGridView và TotalAmount)
                dgvBillDetails.Rows.Clear(); // Xóa các món ăn cũ
                decimal totalAmount = 0;
                foreach (DataRow row in orderData.Rows)
                {
                    dgvBillDetails.Rows.Add(row["MenuItemId"], row["MenuItemName"], row["Quantity"], row["Price"], row["Total"]);
                    totalAmount += Convert.ToDecimal(row["Total"]);
                }
                txtTotalAmount.Text = totalAmount.ToString("C");
            }
        }
        private void InitializeDataGridView()
        {
            // Đảm bảo rằng cột đã được khai báo
            dgvBillDetails.Columns.Clear();  // Xóa các cột cũ nếu có
            dgvBillDetails.Columns.Add("MenuItemId", "Mã món");
            dgvBillDetails.Columns.Add("MenuItemName", "Tên món");
            dgvBillDetails.Columns.Add("Quantity", "Số lượng");
            dgvBillDetails.Columns.Add("Price", "Giá");
            dgvBillDetails.Columns.Add("Total", "Tổng tiền");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvBillDetails.SelectedRows.Count > 0)
            {
                dgvBillDetails.Rows.RemoveAt(dgvBillDetails.SelectedRows[0].Index);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tableId = (int)cbTables.SelectedValue;
            decimal totalAmount = Convert.ToDecimal(txtTotalAmount.Text);

            // Cập nhật tổng tiền trong bảng Orders
            string query = "UPDATE Orders SET TotalAmount = @TotalAmount WHERE TableID = @TableId AND Status = 'Đang sử dụng'";
            SqlParameter[] parameters = {
        new SqlParameter("@TotalAmount", totalAmount),
        new SqlParameter("@TableId", tableId)
    };
            dbHelper.ExecuteNonQuery(query, parameters);

            // Cập nhật trạng thái của bàn (Đã thanh toán)
            string updateTableQuery = "UPDATE Tables SET Status = 'Trống' WHERE ID = @TableId";
            dbHelper.ExecuteNonQuery(updateTableQuery, parameters);
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dgvBillDetails.Rows)
            {
                totalAmount += Convert.ToDecimal(row.Cells["Total"].Value);
            }

            txtTotalAmount.Text = totalAmount.ToString("C");
        }
    }
}
