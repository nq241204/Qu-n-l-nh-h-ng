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
    public partial class LoginForm : Form
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();
        public LoginForm()
        {
            InitializeComponent();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            /* var op = new UserForm();
            op.ShowDialog();*/
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Xây dựng câu lệnh SQL để lấy thông tin người dùng
            string query = "SELECT * FROM Users WHERE Username = @Username";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@Username", SqlDbType.NVarChar) { Value = username }
            };

            // Thực thi câu lệnh và lấy thông tin người dùng
            DataTable userTable = dbHelper.ExecuteQuery(query, parameters);

            if (userTable.Rows.Count == 1)
            {
                string storedPassword = userTable.Rows[0]["Password"].ToString(); // Mật khẩu đã mã hóa
                string role = userTable.Rows[0]["Role"].ToString();

                // Kiểm tra mật khẩu
                if (BCrypt.Net.BCrypt.Verify(password, storedPassword))
                {
                    // Nếu đăng nhập thành công, điều hướng đến form phù hợp
                    if (role == "admin")
                    {
                        MessageBox.Show("Đăng nhập thành công với quyền Admin!");
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide(); // Ẩn form đăng nhập
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công với quyền User!");
                        UserForm userForm = new UserForm();
                        userForm.Show();
                        this.Hide(); // Ẩn form đăng nhập
                    }
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu!");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }
    }
}
