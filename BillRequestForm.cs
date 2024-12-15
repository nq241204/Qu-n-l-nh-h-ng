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
    public partial class BillRequestForm : Form
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();
        public BillRequestForm()
        {
            InitializeComponent();
        }

        private void BillRequestForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRequestBill_Click(object sender, EventArgs e)
        {
            try
            {
                int tableNumber;
                if (!int.TryParse(txtTableNumber.Text, out tableNumber))
                {
                    MessageBox.Show("Please enter a valid table number.");
                    return;
                }

                string query = @"
                    SELECT mi.Name AS [Dish Name], od.Quantity, mi.Price, (od.Quantity * mi.Price) AS [Total Price]
                    FROM Orders o
                    INNER JOIN OrderDetails od ON o.OrderID = od.OrderID
                    INNER JOIN MenuItems mi ON od.MenuItemID = mi.ID
                    INNER JOIN Tables t ON o.TableID = t.ID
                    WHERE t.TableNumber = @TableNumber";

                SqlParameter[] parameters = {
                    new SqlParameter("@TableNumber", tableNumber)
                };

                DataTable billDetails = dbHelper.ExecuteQuery(query, parameters);
                dgvMenuItems.DataSource = billDetails;

                // Tính tổng tiền
                decimal totalAmount = 0;
                foreach (DataRow row in billDetails.Rows)
                {
                    totalAmount += Convert.ToDecimal(row["Total Price"]);
                }
                MessageBox.Show("Total Amount: " + totalAmount.ToString("C"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving bill: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
