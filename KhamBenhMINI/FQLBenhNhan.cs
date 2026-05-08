using System;
using System.Data;
using System.Windows.Forms;

namespace KhamBenhMINI
{
    public partial class FQLBenhNhan : Form
    {
        private BenhNhanDAL dal = new BenhNhanDAL();
        private int currentMaBN = 0;

        public FQLBenhNhan()
        {
            InitializeComponent();
            LoadData();
            SetupControls();
        }

        private void SetupControls()
        {
            tbox_SDT.KeyPress += TextBox_KeyPress_OnlyNumber;
            rbtn_GioiTinh_Nam.Checked = true;

            dgv_DanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_DanhSach.MultiSelect = false;
            dgv_DanhSach.ReadOnly = true;
        }

        private void LoadData()
        {
            try
            {
                DataTable dt = dal.GetAll();
                dgv_DanhSach.DataSource = dt;

                // Cấu hình cột
                if (dgv_DanhSach.Columns.Contains("MaBenhNhan"))
                    dgv_DanhSach.Columns["MaBenhNhan"].HeaderText = "Mã BN";
                if (dgv_DanhSach.Columns.Contains("HoTen"))
                    dgv_DanhSach.Columns["HoTen"].HeaderText = "Họ và tên";
                if (dgv_DanhSach.Columns.Contains("GioiTinh"))
                    dgv_DanhSach.Columns["GioiTinh"].HeaderText = "Giới tính";
                if (dgv_DanhSach.Columns.Contains("NamSinh"))
                    dgv_DanhSach.Columns["NamSinh"].HeaderText = "Năm sinh";
                if (dgv_DanhSach.Columns.Contains("SoDienThoai"))
                    dgv_DanhSach.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
                if (dgv_DanhSach.Columns.Contains("DiaChi"))
                    dgv_DanhSach.Columns["DiaChi"].HeaderText = "Địa chỉ";
                if (dgv_DanhSach.Columns.Contains("NgayTao"))
                    dgv_DanhSach.Columns["NgayTao"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            currentMaBN = 0;
            tbox_Name.Clear();
            tbox_SDT.Clear();
            tbox_Location.Clear();
            dtp_NamSinh.Value = DateTime.Today;  // ← SỬA: Dùng DateTime.Today
            rbtn_GioiTinh_Nam.Checked = true;
            tbox_Name.Focus();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(tbox_Name.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên bệnh nhân!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbox_Name.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbox_SDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbox_SDT.Focus();
                return false;
            }

            if (tbox_SDT.Text.Length < 9 || tbox_SDT.Text.Length > 11)
            {
                MessageBox.Show("Số điện thoại không hợp lệ (9-11 số)!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbox_SDT.Focus();
                return false;
            }

            return true;
        }

        private void btn_Function_Them_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                string gioiTinh = rbtn_GioiTinh_Nam.Checked ? "Nam" : "Nữ";
                int namSinh = dtp_NamSinh.Value.Year;  

                if (dal.Insert(tbox_Name.Text.Trim(), gioiTinh, namSinh,
                    tbox_SDT.Text.Trim(), tbox_Location.Text.Trim()))
                {
                    MessageBox.Show("Thêm bệnh nhân thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Function_Sua_Click(object sender, EventArgs e)
        {
            if (currentMaBN == 0)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân cần sửa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput())
                return;

            try
            {
                string gioiTinh = rbtn_GioiTinh_Nam.Checked ? "Nam" : "Nữ";
                int namSinh = dtp_NamSinh.Value.Year;

                if (dal.Update(currentMaBN, tbox_Name.Text.Trim(), gioiTinh,
                    namSinh, tbox_SDT.Text.Trim(), tbox_Location.Text.Trim()))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Function_Xóa_Click(object sender, EventArgs e)
        {
            if (currentMaBN == 0)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân cần xóa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa bệnh nhân này?\n\n⚠️ Lưu ý: Sẽ xóa luôn lịch sử khám!",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (dal.Delete(currentMaBN))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ResetForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Function_LamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadData();
        }

        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DanhSach.Rows[e.RowIndex];

                if (row.Cells["MaBenhNhan"].Value != null)
                    currentMaBN = Convert.ToInt32(row.Cells["MaBenhNhan"].Value);

                if (row.Cells["HoTen"].Value != null)
                    tbox_Name.Text = row.Cells["HoTen"].Value.ToString();

                if (row.Cells["NamSinh"].Value != null)
                {
                    int namSinh = Convert.ToInt32(row.Cells["NamSinh"].Value);
                    dtp_NamSinh.Value = new DateTime(namSinh, 1, 1);  
                }

                if (row.Cells["SoDienThoai"].Value != null)
                    tbox_SDT.Text = row.Cells["SoDienThoai"].Value.ToString();

                if (row.Cells["DiaChi"].Value != null)
                    tbox_Location.Text = row.Cells["DiaChi"].Value.ToString();

                if (row.Cells["GioiTinh"].Value != null)
                {
                    string gioiTinh = row.Cells["GioiTinh"].Value.ToString();
                    if (gioiTinh == "Nam")
                        rbtn_GioiTinh_Nam.Checked = true;
                    else
                        rbtn_GioiTinh_Nu.Checked = true;
                }
            }
        }

        private void TextBox_KeyPress_OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gbox_QLBenhNhan_Enter(object sender, EventArgs e) { }
        private void gbox_QLBenhNhan_TTBenhNhan_Enter(object sender, EventArgs e) { }
        private void tbox_Name_TextChanged(object sender, EventArgs e) { }
        private void rbtn_GioiTinh_Nam_CheckedChanged(object sender, EventArgs e) { }
        private void rbtn_GioiTinh_Nu_CheckedChanged(object sender, EventArgs e) { }
        private void tbox_Location_TextChanged(object sender, EventArgs e) { }
        private void dtp_NamSinh_ValueChanged(object sender, EventArgs e) { }
        private void tbox_SDT_TextChanged(object sender, EventArgs e) { }
        private void btn_Function_ThongKe_Click(object sender, EventArgs e) { }
        private void gbox_QLBenhNhan_Function_Enter(object sender, EventArgs e) { }
        private void rbtn_Function_ThongKe_CanBenh_CheckedChanged(object sender, EventArgs e) { }
        private void rbtn_Function_ThongKe_BenhNhan_CheckedChanged(object sender, EventArgs e) { }
        private void rbtn_Function_ThongKe_LoaiThuoc_CheckedChanged(object sender, EventArgs e) { }
        private void dgv_DanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}