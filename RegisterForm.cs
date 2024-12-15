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
using BCrypt.Net;
namespace RestaurantManagement
{
    public partial class RegisterForm : Form
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            
        }
        private void label2_Click(object sender, EventArgs e)
        {
            // Trở về form đăng nhập
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide(); // Ẩn form đăng ký
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Trở về form đăng nhập
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide(); // Ẩn form đăng ký
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string fullName = txtFullName.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu không khớp.");
                return;
            }

            // Mã hóa mật khẩu
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            // Kiểm tra xem tên người dùng đã tồn tại trong cơ sở dữ liệu chưa
            string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
            SqlParameter[] checkParams = { new SqlParameter("@Username", username) };
            int userCount = (int)dbHelper.ExecuteScalar(checkQuery, checkParams);

            if (userCount > 0)
            {
                MessageBox.Show("Tên người dùng đã tồn tại.");
                return;
            }

            // Đặt mặc định role là "user"
            string role = "user";

            // Thêm người dùng vào cơ sở dữ liệu
            string query = "INSERT INTO Users (Username, Password, Role, FullName) VALUES (@Username, @Password, @Role, @FullName)";
            SqlParameter[] parameters = {
        new SqlParameter("@Username", username),
        new SqlParameter("@Password", hashedPassword),
        new SqlParameter("@Role", role),  // Mặc định role là "user"
        new SqlParameter("@FullName", fullName)
    };

            int result = dbHelper.ExecuteNonQuery(query, parameters);

            if (result > 0)
            {
                MessageBox.Show("Đăng ký thành công!");
            }
            else
            {
                MessageBox.Show("Đã có lỗi khi đăng ký.");
            }
        }
    }
}
