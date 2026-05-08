using System;
using System.Data;
using Microsoft.Data.SqlClient; // Dùng Microsoft.Data.SqlClient nếu bạn dùng .NET Core / .NET 5+
using System.Windows.Forms;

namespace KhamBenhMINI
{
    public partial class FLogin : Form
    {
        private const string ConnectionString = "Server=YENNHU;Database=BTGK_KhamBenh;Trusted_Connection=True;TrustServerCertificate=true;";

        public FLogin()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string username = textBox_Name.Text.Trim();
            string password = textBox_Password.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Name.Focus();
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Password.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    // Kiểm tra tên đăng nhập, mật khẩu và trạng thái hoạt động (TrangThai = 1)
                    string query = @"SELECT MaAdmin, HoTen, Quyen FROM Admin 
                                     WHERE TenDangNhap = @username AND MatKhau = @password AND TrangThai = 1";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Dùng Add thay vì AddWithValue để tránh lỗi ép kiểu ngầm định
                        cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar, 255).Value = password;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Đăng nhập thành công
                                int maAdmin = reader.GetInt32(0);
                                string hoTen = reader.IsDBNull(1) ? "Người dùng" : reader.GetString(1);
                                string quyen = reader.IsDBNull(2) ? "Nhân viên" : reader.GetString(2);

                                // Lưu thông tin người dùng vào session toàn cục
                                AppSession.CurrentUser = new UserInfo
                                {
                                    MaAdmin = maAdmin,
                                    HoTen = hoTen,
                                    Quyen = quyen
                                };

                                MessageBox.Show($"Đăng nhập thành công!\nChào mừng: {hoTen}\nQuyền: {quyen}",
                                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Hide();
                                FHospitalManager fHM = new FHospitalManager();
                                fHM.ShowDialog(); // Dừng ở đây cho đến khi form chính đóng
                                this.Close();     // Đóng form login sau khi thoát form chính
                            }
                            else
                            {
                                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng, hoặc tài khoản đã bị khóa!",
                                                "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBox_Password.Clear();
                                textBox_Password.Focus();
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Các sự kiện TextChanged / LabelClick giữ nguyên nếu không dùng
        private void textBox_Name_TextChanged(object sender, EventArgs e) { }
        private void textBox_Password_TextChanged(object sender, EventArgs e) { }
        private void label_Login_Click(object sender, EventArgs e) { }
        private void label_Name_Click(object sender, EventArgs e) { }
        private void label_Password_Click(object sender, EventArgs e) { }
    }

    // 🔹 Class hỗ trợ lưu thông tin người dùng đã đăng nhập (dùng toàn dự án)
    public static class AppSession
    {
        public static UserInfo CurrentUser { get; set; }
    }

    public class UserInfo
    {
        public int MaAdmin { get; set; }
        public string HoTen { get; set; }
        public string Quyen { get; set; }
    }
}