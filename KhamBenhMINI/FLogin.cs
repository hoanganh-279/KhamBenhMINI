using System;
using System.Data;
using System.Drawing;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace KhamBenhMINI
{
    public partial class FLogin : Form
    {
        private const string ConnectionString = "Server=DESKTOP-ANOQA7D\\SQLEXPRESS;Database=BTGK_KhamBenh;Trusted_Connection=True;TrustServerCertificate=true;";

        public FLogin()
        {
            InitializeComponent();
            textBox_Password.UseSystemPasswordChar = true;
            showpassword.Image = GetEyeImage(false);
            showpassword.Text = "";
            ClearError();
        }
        private bool isShowPassword = false;

        private static Image GetEyeImage(bool showPassword)
        {
            Bitmap source = showPassword ? Properties.Resources.hide : Properties.Resources.view;
            return new Bitmap(source, new Size(16, 16));
        }

        private void ShowError(string message)
        {
            label_Error.Text = message;
            label_Error.Visible = true;
        }

        private void ClearError()
        {
            label_Error.Text = "";
            label_Error.Visible = false;
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            ClearError();
            string username = textBox_Name.Text.Trim();
            string password = textBox_Password.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                ShowError("Vui lòng nhập tên đăng nhập!");
                textBox_Name.Focus();
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                ShowError("Vui lòng nhập mật khẩu!");
                textBox_Password.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string queryUser = @"SELECT MaAdmin, HoTen, Quyen, MatKhau
                     FROM Admin
                     WHERE TenDangNhap = @username AND TrangThai = 1";

                    using (SqlCommand cmdUser = new SqlCommand(queryUser, conn))
                    {
                        cmdUser.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;

                        using (SqlDataReader readerUser = cmdUser.ExecuteReader())
                        {
                            if (!readerUser.Read())
                            {
                                ShowError("Tài khoản không tồn tại hoặc đã bị khóa!");
                                textBox_Name.Focus();
                                textBox_Name.SelectAll();
                                return;
                            }

                            int maAdmin = readerUser.GetInt32(0);
                            string hoTen = readerUser.IsDBNull(1) ? "Người dùng" : readerUser.GetString(1);
                            string quyen = readerUser.IsDBNull(2) ? "Nhân viên" : readerUser.GetString(2);
                            string dbPassword = readerUser.IsDBNull(3) ? "" : readerUser.GetString(3);

                            if (dbPassword != password)
                            {
                                ShowError("Sai mật khẩu!");
                                textBox_Password.Clear();
                                textBox_Password.Focus();
                                return;
                            }

                            AppSession.CurrentUser = new UserInfo
                            {
                                MaAdmin = maAdmin,
                                HoTen = hoTen,
                                Quyen = quyen
                            };
                        }
                    }

                    this.Hide();
                    new FHospitalManager().ShowDialog();
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                ShowError("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
            }
            catch (Exception ex)
            {
                ShowError("Đã xảy ra lỗi hệ thống: " + ex.Message);
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Các sự kiện TextChanged / LabelClick giữ nguyên nếu không dùng
        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            ClearError();
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            // chỉ clear lỗi khi user thực sự bắt đầu gõ lại
            if (!string.IsNullOrWhiteSpace(textBox_Password.Text))
                ClearError();
        }

        private void label_Login_Click(object sender, EventArgs e) { }
        private void label_Name_Click(object sender, EventArgs e) { }
        private void label_Password_Click(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            isShowPassword = !isShowPassword;
            textBox_Password.UseSystemPasswordChar = !isShowPassword;
            showpassword.Image = GetEyeImage(isShowPassword);
        }
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