using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace KhamBenhMINI
{
    public partial class FHospitalManager : Form
    {
        private Panel _currentOpenPanel = null;

        public FHospitalManager()
        {
            InitializeComponent();
            CollapseAllSubPanels();
        }

        // ─────────────────────────────────────────────
        //  HÀM HELPER DÙNG CHUNG
        // ─────────────────────────────────────────────

        private void CollapseAllSubPanels()
        {
            pnlSubTiepNhan.Visible = false;
            pnlSubKhamBenh.Visible = false;
            pnlSubBaoCao.Visible = false;
            _currentOpenPanel = null;
        }

        private void ToggleSubPanel(Panel targetPanel)
        {
            if (_currentOpenPanel == targetPanel)
            {
                targetPanel.Visible = false;
                _currentOpenPanel = null;
            }
            else
            {
                CollapseAllSubPanels();
                targetPanel.Visible = true;
                _currentOpenPanel = targetPanel;
            }
        }

        // 🔹 METHOD MỚI: Mở form con trong panel content
        private void OpenChildForm(Form childForm)
        {
            // Đóng form cũ nếu có
            foreach (Control ctrl in pnl_Content.Controls)
            {
                if (ctrl is Form oldForm)
                {
                    oldForm.Close();  // oldForm đã là Form nên gọi Close() được
                }
            }

            // Cấu hình form con để nhúng vào panel
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Thêm form vào panel content
            pnl_Content.Controls.Clear();
            pnl_Content.Controls.Add(childForm);
            childForm.Show();
        }

        // ─────────────────────────────────────────────
        //  NHÓM 1 – TIẾP NHẬN VÀ QUẢN LÝ
        // ─────────────────────────────────────────────

        private void btn_MenuTNvaQL_Click(object sender, EventArgs e)
        {
            ToggleSubPanel(pnlSubTiepNhan);
        }

        private void btn_QLBenhNhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FQLBenhNhan());  // ✅ ĐÃ SỬA: Gọi method OpenChildForm
        }

        private void btn_TimKiemBN_Click(object sender, EventArgs e)
        {
            // TODO: Mở form Tìm kiếm bệnh nhân
        }

        //  NHÓM 2 – DỊCH VỤ KHÁM BỆNH

        private void btn_MenuDVKhamBenh_Click(object sender, EventArgs e)
        {
            ToggleSubPanel(pnlSubKhamBenh);
        }

        private void btn_TaoLuotKham_Click(object sender, EventArgs e)
        {
            // TODO: Mở form Tạo lượt khám
        }

        private void btn_GhiTrieuChung_Click(object sender, EventArgs e)
        {
            // TODO: Mở form Ghi triệu chứng
        }

        private void btn_GhiChuanDoan_Click(object sender, EventArgs e)
        {
            // TODO: Mở form Ghi chuẩn đoán
        }

        private void btn_GhiDonThuoc_Click(object sender, EventArgs e)
        {
            // TODO: Mở form Ghi đơn thuốc / xử lý
        }

        //  NHÓM 3 – TRA CỨU VÀ BÁO CÁO

        private void btn_MenuBaoCao_Click(object sender, EventArgs e)
        {
            ToggleSubPanel(pnlSubBaoCao);
        }

        private void btn_LinhSuKB_Click(object sender, EventArgs e)
        {
            // TODO: Mở form Lịch sử khám bệnh
        }

        private void btn_ThongKeKB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FThongKe());
        }

        //  SỰ KIỆN PAINT & LOGO (giữ nguyên, không cần logic)

        private void pnlSubTiepNhan_Paint(object sender, PaintEventArgs e) { }
        private void pnlSubKhamBenh_Paint(object sender, PaintEventArgs e) { }
        private void pnlSubBaoCao_Paint(object sender, PaintEventArgs e) { }
        private void FLPnl_MenuMain_Paint(object sender, PaintEventArgs e) { }
        private void pnl_Content_Paint(object sender, PaintEventArgs e) { }

        private void pictureBox_Logo_Click(object sender, EventArgs e) { }
    }
}