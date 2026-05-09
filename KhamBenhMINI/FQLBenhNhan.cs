using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using KhamBenhMINI.DAL;
using System.Linq;

namespace KhamBenhMINI
{
    public partial class FQLBenhNhan : Form
    {
        private BenhNhanDAL dal = new BenhNhanDAL();
        private int currentMaBN = 0;
        private TextBox tbox_TimKiem; 

        public FQLBenhNhan()
        {
            InitializeComponent();
            CreateSearchBox();       
            SetupControls();
            LoadData();
        }

        // ==================== TẠO Ô TÌM KIẾM BẰNG CODE ====================
        private void CreateSearchBox()
        {
            tbox_TimKiem = new TextBox
            {
                Name = "tbox_TimKiem",
                Location = new Point(20, 20),      // Vị trí
                Size = new Size(400, 30),          // Kích thước
                Font = new Font("Segoe UI", 11),
                PlaceholderText = "Nhập họ tên, SĐT hoặc địa chỉ để tìm kiếm..."
            };

            // Thêm vào form (nên thêm vào Panel hoặc GroupBox chứa DataGridView)
            this.Controls.Add(tbox_TimKiem);

            // Nếu bạn có GroupBox hoặc Panel chứa danh sách, hãy thay this.Controls.Add bằng:
            // gbox_DanhSach.Controls.Add(tbox_TimKiem);   // hoặc tên groupbox của bạn
        }

        private void SetupControls()
        {
            tbox_SDT.KeyPress += TextBox_KeyPress_OnlyNumber;
            rbtn_GioiTinh_Nam.Checked = true;

            dgv_DanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_DanhSach.MultiSelect = false;
            dgv_DanhSach.ReadOnly = true;

            // Gán event cho ô tìm kiếm
            if (tbox_TimKiem != null)
            {
                tbox_TimKiem.TextChanged += tbox_TimKiem_TextChanged;
                tbox_TimKiem.KeyDown += tbox_TimKiem_KeyDown;
            }
        }

        private void LoadData(string keyword = "")
        {
            try
            {
                DataTable dt = string.IsNullOrWhiteSpace(keyword)
                             ? dal.GetAll()
                             : dal.Search(keyword);

                dgv_DanhSach.DataSource = dt;

                // Cấu hình cột
                if (dgv_DanhSach.Columns.Contains("MaBenhNhan")) dgv_DanhSach.Columns["MaBenhNhan"].HeaderText = "Mã BN";
                if (dgv_DanhSach.Columns.Contains("HoTen")) dgv_DanhSach.Columns["HoTen"].HeaderText = "Họ và tên";
                if (dgv_DanhSach.Columns.Contains("GioiTinh")) dgv_DanhSach.Columns["GioiTinh"].HeaderText = "Giới tính";
                if (dgv_DanhSach.Columns.Contains("NamSinh")) dgv_DanhSach.Columns["NamSinh"].HeaderText = "Năm sinh";
                if (dgv_DanhSach.Columns.Contains("SoDienThoai")) dgv_DanhSach.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
                if (dgv_DanhSach.Columns.Contains("DiaChi")) dgv_DanhSach.Columns["DiaChi"].HeaderText = "Địa chỉ";
                if (dgv_DanhSach.Columns.Contains("NgayTao")) dgv_DanhSach.Columns["NgayTao"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbox_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData(tbox_TimKiem.Text.Trim());
        }

        private void tbox_TimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoadData(tbox_TimKiem.Text.Trim());
        }

        private void btn_Function_LamMoi_Click(object sender, EventArgs e)
        {
            tbox_TimKiem.Clear();
            ResetForm();
            LoadData();
        }

        // ====================== CÁC HÀM CÒN LẠI (giữ nguyên) ======================
        private void ResetForm()
        {
            currentMaBN = 0;
            tbox_Name.Clear();
            tbox_SDT.Clear();
            tbox_Location.Clear();
            dtp_NamSinh.Value = DateTime.Today;
            rbtn_GioiTinh_Nam.Checked = true;
            tbox_Name.Focus();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(tbox_Name.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên bệnh nhân!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbox_Name.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbox_SDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbox_SDT.Focus();
                return false;
            }
            if (tbox_SDT.Text.Length < 9 || tbox_SDT.Text.Length > 11)
            {
                MessageBox.Show("Số điện thoại không hợp lệ (9-11 số)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbox_SDT.Focus();
                return false;
            }
            return true;
        }

        private void btn_Function_Them_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                string gioiTinh = rbtn_GioiTinh_Nam.Checked ? "Nam" : "Nữ";
                int namSinh = dtp_NamSinh.Value.Year;  


                if (dal.Insert(tbox_Name.Text.Trim(), gioiTinh, namSinh, tbox_SDT.Text.Trim(), tbox_Location.Text.Trim()))
                {
                    MessageBox.Show("Thêm bệnh nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(tbox_TimKiem.Text.Trim());
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Function_Sua_Click(object sender, EventArgs e)
        {
            if (currentMaBN == 0)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInput()) return;

            try
            {
                string gioiTinh = rbtn_GioiTinh_Nam.Checked ? "Nam" : "Nữ";
                int namSinh = dtp_NamSinh.Value.Year;

                if (dal.Update(currentMaBN, tbox_Name.Text.Trim(), gioiTinh, namSinh, tbox_SDT.Text.Trim(), tbox_Location.Text.Trim()))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(tbox_TimKiem.Text.Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Function_Xóa_Click(object sender, EventArgs e)
        {
            if (currentMaBN == 0)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bệnh nhân này?\n\n⚠️ Lưu ý: Sẽ xóa luôn lịch sử khám!",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (dal.Delete(currentMaBN))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(tbox_TimKiem.Text.Trim());
                        ResetForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DanhSach.Rows[e.RowIndex];

                currentMaBN = Convert.ToInt32(row.Cells["MaBenhNhan"].Value ?? 0);

                tbox_Name.Text = row.Cells["HoTen"].Value?.ToString() ?? "";
                tbox_SDT.Text = row.Cells["SoDienThoai"].Value?.ToString() ?? "";
                tbox_Location.Text = row.Cells["DiaChi"].Value?.ToString() ?? "";

                if (row.Cells["NamSinh"].Value != null)
                {
                    int namSinh = Convert.ToInt32(row.Cells["NamSinh"].Value);
                    dtp_NamSinh.Value = new DateTime(namSinh, 1, 1);  

                }

                string gt = row.Cells["GioiTinh"].Value?.ToString() ?? "Nam";
                rbtn_GioiTinh_Nam.Checked = (gt == "Nam");
                rbtn_GioiTinh_Nu.Checked = (gt == "Nữ");
            }
        }

        private void TextBox_KeyPress_OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void gbox_QLBenhNhan_Enter(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}