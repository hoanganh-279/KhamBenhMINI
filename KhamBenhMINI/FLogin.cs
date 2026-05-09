using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using KhamBenhMINI.Features.DichVuKhamBenh;

namespace KhamBenhMINI
{
    public partial class FLogin : Form
    {
        private const string ConnectionString = "Server=DESKTOP-ANOQA7D\\SQLEXPRESS;Database=BTGK_KhamBenh;Trusted_Connection=True;TrustServerCertificate=true;";

        public FLogin()
        {
            InitializeComponent();
            layoutCard.Resize += (_, _) => SyncErrorLabelWrapWidth();
            tblBrand.Resize += (_, _) => SyncSidebarWrapWidths();
            KeyDown += FLogin_KeyDown;

            ApplyLoginTheme();
            textBox_Password.UseSystemPasswordChar = true;
            showpassword.Image = GetEyeImage(false);
            showpassword.Text = "";
            ClearError();
            panelPassRow.Resize += PanelPassRow_Resize;
            PanelPassRow_Resize(panelPassRow, EventArgs.Empty);
            SyncErrorLabelWrapWidth();
            SyncSidebarWrapWidths();
        }

        private void FLogin_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
                e.SuppressKeyPress = true;
            }
        }

        private void SyncSidebarWrapWidths()
        {
            int w = tblBrand.ClientSize.Width - tblBrand.Padding.Horizontal;
            if (w <= 48)
                return;
            var wrap = new Size(w, 0);
            lblBrandFooter.MaximumSize = wrap;
            foreach (Control c in tblSidebarFeatures.Controls)
            {
                foreach (Control inner in c.Controls)
                {
                    if (inner is Label lb)
                        lb.MaximumSize = wrap;
                }
            }
        }

        private void SyncErrorLabelWrapWidth()
        {
            int w = layoutCard.ClientSize.Width - layoutCard.Padding.Horizontal;
            if (w > 40)
                label_Error.MaximumSize = new Size(w, 0);
        }

        private void ApplyLoginTheme()
        {
            UiTheme.StyleButton(button_Login, true);
            button_Login.Height = 50;
            AcceptButton = button_Login;
            ActiveControl = textBox_Name;
            label_Error.AutoSize = true;

            UnderlineFieldHelper.AttachUnderline(pnlUnderlineName, textBox_Name);
            UnderlineFieldHelper.AttachUnderlineRow(panelPassRow, textBox_Password, showpassword);
            textBox_Password.BackColor = Color.White;

            foreach (var pair in new[]
                     {
                         (pnlFeat1, lblFeat1), (pnlFeat2, lblFeat2), (pnlFeat3, lblFeat3), (pnlFeat4, lblFeat4)
                     })
                StyleLoginFeatureRow(pair.Item1, pair.Item2);
        }

        private static void StyleLoginFeatureRow(Panel strip, Label caption)
        {
            caption.BackColor = Color.White;
            caption.ForeColor = UiTheme.TextPrimary;
            caption.Font = UiTheme.NormalFont;
            caption.AutoEllipsis = true;
            caption.UseMnemonic = false;
            strip.BackColor = Color.White;
            strip.Padding = new Padding(12, 0, 10, 0);
            strip.Margin = new Padding(0, 0, 0, 10);

            void StripPaint(object? s, PaintEventArgs e)
            {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                var r = strip.ClientRectangle;
                using var accent = new SolidBrush(UiTheme.PrimaryBlue);
                g.FillRectangle(accent, r.Left, r.Top, 4, r.Height);
                using var pen = new Pen(Color.FromArgb(226, 232, 240));
                int y = r.Bottom - 1;
                g.DrawLine(pen, r.Left, y, r.Right - 1, y);
            }

            strip.Paint -= StripPaint;
            strip.Paint += StripPaint;
        }

        private void PanelPassRow_Resize(object? sender, EventArgs e)
        {
            const int rowH = 44;
            const int tbH = 26;
            int btnW = showpassword.Width;
            showpassword.Left = panelPassRow.ClientSize.Width - btnW;
            showpassword.Height = 32;
            showpassword.Top = (rowH - showpassword.Height) / 2;
            textBox_Password.Height = tbH;
            textBox_Password.Top = (rowH - tbH) / 2;
            textBox_Password.Width = Math.Max(120, panelPassRow.ClientSize.Width - btnW - 10);
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
            layoutCard.RowStyles[2].Height = Math.Max(30f, label_Error.PreferredHeight + 6f);
        }

        private void ClearError()
        {
            label_Error.Text = "";
            label_Error.Visible = false;
            layoutCard.RowStyles[2].Height = 30f;
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

                    Hide();
                    new FHospitalManager().ShowDialog();
                    Close();
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

        private void linkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void lblForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                "Vui lòng liên hệ quản trị hệ thống hoặc phòng CNTT để được cấp lại mật khẩu.",
                "Quên mật khẩu",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            ClearError();
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_Password.Text))
                ClearError();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isShowPassword = !isShowPassword;
            textBox_Password.UseSystemPasswordChar = !isShowPassword;
            showpassword.Image = GetEyeImage(isShowPassword);
        }
    }

    public static class AppSession
    {
        public static UserInfo? CurrentUser { get; set; }
    }

    public class UserInfo
    {
        public int MaAdmin { get; set; }
        public string HoTen { get; set; } = string.Empty;
        public string Quyen { get; set; } = string.Empty;
    }
}
