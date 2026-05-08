using System;
using System.Data;
using System.Windows.Forms;
using KhamBenhMINI.DAL;

namespace KhamBenhMINI
{
    public partial class FThongKe : Form
    {
        private LuotKhamDAL lkDal = new LuotKhamDAL();
        private BacSiDAL bsDal = new BacSiDAL();

        public FThongKe()
        {
            InitializeComponent();
            LoadData();
            SetupControls();
        }

        private void SetupControls()
        {
            // Set default date: Từ đầu tháng đến hôm nay
            dtp_FromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtp_ToDate.Value = DateTime.Today;

            // Load danh sách bác sĩ vào ComboBox
            DataTable dtBacSi = bsDal.GetAll();
            cbo_BacSi.DataSource = dtBacSi;
            cbo_BacSi.DisplayMember = "HoTen";
            cbo_BacSi.ValueMember = "MaBacSi";
            cbo_BacSi.SelectedIndex = -1; 

            // Cấu hình DataGridView
            dgv_ThongKe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ThongKe.MultiSelect = false;
            dgv_ThongKe.ReadOnly = true;
            dgv_ThongKe.AllowUserToAddRows = false;

            dgv_TKTongHop_BacSi.ReadOnly = true;
            dgv_TKTongHop_BacSi.AllowUserToAddRows = false;

            dgv_TKTongHop_ChuanDoan.ReadOnly = true;
            dgv_TKTongHop_ChuanDoan.AllowUserToAddRows = false;
        }

        private void LoadData()
        {
            try
            {
                DataTable dt = lkDal.GetAll();
                dgv_ThongKe.DataSource = dt;
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            if (dgv_ThongKe.Columns.Contains("MaLuotKham"))
                dgv_ThongKe.Columns["MaLuotKham"].HeaderText = "Mã lượt khám";

            if (dgv_ThongKe.Columns.Contains("TenBenhNhan"))
                dgv_ThongKe.Columns["TenBenhNhan"].HeaderText = "Bệnh nhân";

            if (dgv_ThongKe.Columns.Contains("TenBacSi"))
                dgv_ThongKe.Columns["TenBacSi"].HeaderText = "Bác sĩ";

            if (dgv_ThongKe.Columns.Contains("NgayKham"))
            {
                dgv_ThongKe.Columns["NgayKham"].HeaderText = "Ngày khám";
                dgv_ThongKe.Columns["NgayKham"].Width = 120;
            }

            if (dgv_ThongKe.Columns.Contains("ChanDoan"))
                dgv_ThongKe.Columns["ChanDoan"].HeaderText = "Chẩn đoán";
        }

        // ─────────────────────────────────────────────
        //  THỐNG KÊ THEO NGÀY
        // ─────────────────────────────────────────────

        private void btn_ThongKeTheoNgay_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = dtp_FromDate.Value.Date;
                DateTime toDate = dtp_ToDate.Value.Date;

                if (fromDate > toDate)
                {
                    MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!",
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable dt = lkDal.GetByDateRange(fromDate, toDate);
                dgv_ThongKe.DataSource = dt;
                FormatDataGridView();

                txt_TongSoLuot.Text = dt.Rows.Count.ToString();

                MessageBox.Show($"Thống kê từ {fromDate:dd/MM/yyyy} đến {toDate:dd/MM/yyyy}\n" +
                    $"Tổng số lượt khám: {dt.Rows.Count}",
                    "Kết quả thống kê", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thống kê: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─────────────────────────────────────────────
        //  THỐNG KÊ THEO THÁNG
        // ─────────────────────────────────────────────

        private void btn_ThongKeTheoThang_Click(object sender, EventArgs e)
        {
            try
            {
                int nam = dtp_FromDate.Value.Year;
                int thang = dtp_FromDate.Value.Month;

                DataTable dt = lkDal.GetByMonthYear(thang, nam);
                dgv_ThongKe.DataSource = dt;
                FormatDataGridView();

                txt_TongSoLuot.Text = dt.Rows.Count.ToString();

                MessageBox.Show($"Thống kê tháng {thang}/năm {nam}\n" +
                    $"Tổng số lượt khám: {dt.Rows.Count}",
                    "Kết quả thống kê", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thống kê: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─────────────────────────────────────────────
        //  THỐNG KÊ THEO BÁC SĨ
        // ─────────────────────────────────────────────

        private void btn_ThongKeTheoBacSi_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo_BacSi.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn bác sĩ cần thống kê!",
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maBacSi = (int)cbo_BacSi.SelectedValue;
                string tenBacSi = cbo_BacSi.Text;

                DataTable dt = lkDal.GetByBacSi(maBacSi);
                dgv_ThongKe.DataSource = dt;  
                FormatDataGridView();

                txt_TongSoLuot.Text = dt.Rows.Count.ToString();
                
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show($"Đã tìm thấy {dt.Rows.Count} lượt khám của BS. {tenBacSi}",
                        "Thống kê thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgv_ThongKe.Focus();
                    dgv_ThongKe.ClearSelection();
                    if (dgv_ThongKe.Rows.Count > 0)
                        dgv_ThongKe.Rows[0].Selected = true;
                }
                else
                {
                    MessageBox.Show($"Bác sĩ {tenBacSi} chưa có lượt khám nào!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thống kê: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─────────────────────────────────────────────
        //  THỐNG KÊ TỔNG QUAN
        // ─────────────────────────────────────────────

        private void btn_ThongKeTongQuan_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = lkDal.GetAll();
                int tongSoLuot = dt.Rows.Count;

                // Thống kê theo bác sĩ
                DataTable dtByDoctor = lkDal.GetStatisticsByDoctor();
                dgv_TKTongHop_BacSi.DataSource = dtByDoctor;

                // Format
                if (dgv_TKTongHop_BacSi.Columns.Contains("TenBacSi"))
                    dgv_TKTongHop_BacSi.Columns["TenBacSi"].HeaderText = "Bác sĩ";
                if (dgv_TKTongHop_BacSi.Columns.Contains("SoLuot"))
                    dgv_TKTongHop_BacSi.Columns["SoLuot"].HeaderText = "Số lượt khám";

                // Thống kê theo chẩn đoán
                DataTable dtByDiagnosis = lkDal.GetStatisticsByDiagnosis();
                dgv_TKTongHop_ChuanDoan.DataSource = dtByDiagnosis;

                // Format
                if (dgv_TKTongHop_ChuanDoan.Columns.Contains("ChanDoan"))
                    dgv_TKTongHop_ChuanDoan.Columns["ChanDoan"].HeaderText = "Chẩn đoán";
                if (dgv_TKTongHop_ChuanDoan.Columns.Contains("SoLuot"))
                    dgv_TKTongHop_ChuanDoan.Columns["SoLuot"].HeaderText = "Số lượt";

                txt_TongSoLuot.Text = tongSoLuot.ToString();

                MessageBox.Show($"Thống kê tổng quan:\nTổng số lượt khám: {tongSoLuot}",
                    "Thống kê thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thống kê: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─────────────────────────────────────────────
        //  XUẤT BÁO CÁO
        // ─────────────────────────────────────────────

        private void btn_XuatBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                string report = "=== BÁO CÁO THỐNG KÊ LƯỢT KHÁM ===\n\n";
                report += $"Thời gian xuất: {DateTime.Now:dd/MM/yyyy HH:mm:ss}\n";
                report += $"Tổng số lượt khám: {txt_TongSoLuot.Text}\n\n";
                report += "Chi tiết:\n";
                report += "─────────────────────────────────\n";

                foreach (DataGridViewRow row in dgv_ThongKe.Rows)
                {
                    if (row.Cells["TenBenhNhan"].Value != null)
                    {
                        report += $"- {row.Cells["TenBenhNhan"].Value} ";
                        if (row.Cells["TenBacSi"].Value != null)
                            report += $"(BS: {row.Cells["TenBacSi"].Value}) ";
                        if (row.Cells["NgayKham"].Value != null)
                            report += $"- {Convert.ToDateTime(row.Cells["NgayKham"].Value):dd/MM/yyyy}\n";
                    }
                }

                report += "\n\nThống kê theo bác sĩ:\n";
                report += "─────────────────────────────────\n";
                foreach (DataGridViewRow row in dgv_TKTongHop_BacSi.Rows)
                {
                    if (row.Cells["TenBacSi"].Value != null)
                    {
                        report += $"{row.Cells["TenBacSi"].Value}: {row.Cells["SoLuot"].Value} lượt\n";
                    }
                }

                report += "\nThống kê theo chẩn đoán:\n";
                report += "─────────────────────────────────\n";
                foreach (DataGridViewRow row in dgv_TKTongHop_ChuanDoan.Rows)
                {
                    if (row.Cells["ChanDoan"].Value != null)
                    {
                        report += $"{row.Cells["ChanDoan"].Value}: {row.Cells["SoLuot"].Value} lượt\n";
                    }
                }

                // Lưu vào file text
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text Files|*.txt";
                sfd.FileName = $"BaoCao_ThongKe_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(sfd.FileName, report);
                    MessageBox.Show("Xuất báo cáo thành công!\nFile: " + sfd.FileName,
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất báo cáo: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dtp_FromDate_ValueChanged(object sender, EventArgs e) { }
        private void cbo_BacSi_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dtp_ToDate_ValueChanged(object sender, EventArgs e) { }
        private void txt_TongSoLuot_TextChanged(object sender, EventArgs e) { }
        private void dgv_ThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgv_TKTongHop_BacSi_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgv_TKTongHop_ChuanDoan_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void pnl_Content_Paint(object sender, PaintEventArgs e) { }
    }
}