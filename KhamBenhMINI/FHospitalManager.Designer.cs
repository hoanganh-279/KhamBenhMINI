using KhamBenhMINI.Features.DichVuKhamBenh;

namespace KhamBenhMINI
{
    partial class FHospitalManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pnlSidebarHeader = new Panel();
            btnToggleSidebar = new Button();
            FLPnl_MenuMain = new FlowLayoutPanel();
            btn_MenuTNvaQL = new Button();
            pnlSubTiepNhan = new Panel();
            btn_TimKiemBN = new Button();
            btn_QLBenhNhan = new Button();
            btn_MenuDVKhamBenh = new Button();
            pnlSubKhamBenh = new Panel();
            btn_GhiDonThuoc = new Button();
            btn_GhiChuanDoan = new Button();
            btn_GhiTrieuChung = new Button();
            btn_TaoLuotKham = new Button();
            btn_MenuBaoCao = new Button();
            pnlSubBaoCao = new Panel();
            btn_ThongKeKB = new Button();
            btn_LinhSuKB = new Button();
            pnl_Content = new Panel();
            panel1.SuspendLayout();
            pnlSidebarHeader.SuspendLayout();
            FLPnl_MenuMain.SuspendLayout();
            pnlSubTiepNhan.SuspendLayout();
            pnlSubKhamBenh.SuspendLayout();
            pnlSubBaoCao.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = false;
            panel1.BackColor = UiTheme.SoftBlue;
            panel1.Controls.Add(FLPnl_MenuMain);
            panel1.Controls.Add(pnlSidebarHeader);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.MinimumSize = new Size(56, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 700);
            panel1.TabIndex = 0;
            // 
            // pnlSidebarHeader
            // 
            pnlSidebarHeader.BackColor = UiTheme.PrimaryBlue;
            pnlSidebarHeader.Controls.Add(btnToggleSidebar);
            pnlSidebarHeader.Dock = DockStyle.Top;
            pnlSidebarHeader.Location = new Point(0, 0);
            pnlSidebarHeader.Name = "pnlSidebarHeader";
            pnlSidebarHeader.Size = new Size(288, 58);
            pnlSidebarHeader.TabIndex = 1;
            // 
            // btnToggleSidebar
            // 
            btnToggleSidebar.BackColor = UiTheme.PrimaryBlue;
            btnToggleSidebar.Cursor = Cursors.Hand;
            btnToggleSidebar.Dock = DockStyle.Fill;
            btnToggleSidebar.FlatAppearance.BorderSize = 0;
            btnToggleSidebar.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 185);
            btnToggleSidebar.FlatStyle = FlatStyle.Flat;
            btnToggleSidebar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnToggleSidebar.ForeColor = Color.White;
            btnToggleSidebar.Location = new Point(0, 0);
            btnToggleSidebar.Name = "btnToggleSidebar";
            btnToggleSidebar.Size = new Size(288, 58);
            btnToggleSidebar.TabIndex = 0;
            btnToggleSidebar.Text = "☰  Phòng khám MINI";
            btnToggleSidebar.TextAlign = ContentAlignment.MiddleLeft;
            btnToggleSidebar.Padding = new Padding(14, 0, 0, 0);
            btnToggleSidebar.UseVisualStyleBackColor = false;
            btnToggleSidebar.Click += btnToggleSidebar_Click;
            // 
            // FLPnl_MenuMain
            // 
            FLPnl_MenuMain.AutoScroll = true;
            FLPnl_MenuMain.BackColor = UiTheme.SoftBlue;
            FLPnl_MenuMain.Controls.Add(btn_MenuTNvaQL);
            FLPnl_MenuMain.Controls.Add(pnlSubTiepNhan);
            FLPnl_MenuMain.Controls.Add(btn_MenuDVKhamBenh);
            FLPnl_MenuMain.Controls.Add(pnlSubKhamBenh);
            FLPnl_MenuMain.Controls.Add(btn_MenuBaoCao);
            FLPnl_MenuMain.Controls.Add(pnlSubBaoCao);
            FLPnl_MenuMain.Dock = DockStyle.Fill;
            FLPnl_MenuMain.FlowDirection = FlowDirection.TopDown;
            FLPnl_MenuMain.Location = new Point(0, 58);
            FLPnl_MenuMain.Margin = new Padding(0);
            FLPnl_MenuMain.Name = "FLPnl_MenuMain";
            FLPnl_MenuMain.Padding = new Padding(10, 14, 10, 16);
            FLPnl_MenuMain.Size = new Size(288, 642);
            FLPnl_MenuMain.TabIndex = 0;
            FLPnl_MenuMain.WrapContents = false;
            FLPnl_MenuMain.Paint += FLPnl_MenuMain_Paint;
            FLPnl_MenuMain.SizeChanged += FLPnl_MenuMain_SizeChanged;
            // 
            // btn_MenuTNvaQL
            // 
            btn_MenuTNvaQL.BackColor = UiTheme.PrimaryBlue;
            btn_MenuTNvaQL.Dock = DockStyle.None;
            btn_MenuTNvaQL.FlatAppearance.BorderSize = 0;
            btn_MenuTNvaQL.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 185);
            btn_MenuTNvaQL.FlatStyle = FlatStyle.Flat;
            btn_MenuTNvaQL.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_MenuTNvaQL.ForeColor = Color.White;
            btn_MenuTNvaQL.Location = new Point(3, 140);
            btn_MenuTNvaQL.Name = "btn_MenuTNvaQL";
            btn_MenuTNvaQL.Padding = new Padding(10, 0, 0, 0);
            btn_MenuTNvaQL.Size = new Size(264, 48);
            btn_MenuTNvaQL.TabIndex = 1;
            btn_MenuTNvaQL.Text = "🏥  Tiếp nhận và Quản lý";
            btn_MenuTNvaQL.TextAlign = ContentAlignment.MiddleLeft;
            btn_MenuTNvaQL.UseVisualStyleBackColor = false;
            btn_MenuTNvaQL.Click += btn_MenuTNvaQL_Click;
            // 
            // pnlSubTiepNhan
            // 
            pnlSubTiepNhan.Controls.Add(btn_QLBenhNhan);
            pnlSubTiepNhan.Controls.Add(btn_TimKiemBN);
            pnlSubTiepNhan.Dock = DockStyle.None;
            pnlSubTiepNhan.Location = new Point(3, 191);
            pnlSubTiepNhan.Name = "pnlSubTiepNhan";
            pnlSubTiepNhan.Size = new Size(264, 80);
            pnlSubTiepNhan.TabIndex = 2;
            pnlSubTiepNhan.Paint += pnlSubNav_Paint;
            // 
            // btn_TimKiemBN
            // 
            btn_TimKiemBN.Dock = DockStyle.Top;
            btn_TimKiemBN.FlatAppearance.BorderSize = 0;
            btn_TimKiemBN.FlatAppearance.MouseOverBackColor = Color.FromArgb(186, 210, 240);
            btn_TimKiemBN.FlatStyle = FlatStyle.Flat;
            btn_TimKiemBN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_TimKiemBN.ForeColor = Color.FromArgb(30, 41, 59);
            btn_TimKiemBN.Location = new Point(0, 38);
            btn_TimKiemBN.Name = "btn_TimKiemBN";
            btn_TimKiemBN.Padding = new Padding(28, 0, 0, 0);
            btn_TimKiemBN.Size = new Size(264, 38);
            btn_TimKiemBN.TabIndex = 1;
            btn_TimKiemBN.Text = "🔍  Tìm kiếm bệnh nhân";
            btn_TimKiemBN.TextAlign = ContentAlignment.MiddleLeft;
            btn_TimKiemBN.UseVisualStyleBackColor = true;
            btn_TimKiemBN.Click += btn_TimKiemBN_Click;
            // 
            // btn_QLBenhNhan
            // 
            btn_QLBenhNhan.Dock = DockStyle.Top;
            btn_QLBenhNhan.FlatAppearance.BorderSize = 0;
            btn_QLBenhNhan.FlatAppearance.MouseOverBackColor = Color.FromArgb(186, 210, 240);
            btn_QLBenhNhan.FlatStyle = FlatStyle.Flat;
            btn_QLBenhNhan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_QLBenhNhan.ForeColor = Color.FromArgb(30, 41, 59);
            btn_QLBenhNhan.Location = new Point(0, 0);
            btn_QLBenhNhan.Name = "btn_QLBenhNhan";
            btn_QLBenhNhan.Padding = new Padding(28, 0, 0, 0);
            btn_QLBenhNhan.Size = new Size(264, 38);
            btn_QLBenhNhan.TabIndex = 0;
            btn_QLBenhNhan.Text = "👤  Quản lý bệnh nhân";
            btn_QLBenhNhan.TextAlign = ContentAlignment.MiddleLeft;
            btn_QLBenhNhan.UseVisualStyleBackColor = true;
            btn_QLBenhNhan.Click += btn_QLBenhNhan_Click;
            // 
            // btn_MenuDVKhamBenh
            // 
            btn_MenuDVKhamBenh.BackColor = UiTheme.PrimaryBlue;
            btn_MenuDVKhamBenh.Dock = DockStyle.None;
            btn_MenuDVKhamBenh.FlatAppearance.BorderSize = 0;
            btn_MenuDVKhamBenh.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 185);
            btn_MenuDVKhamBenh.FlatStyle = FlatStyle.Flat;
            btn_MenuDVKhamBenh.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_MenuDVKhamBenh.ForeColor = Color.White;
            btn_MenuDVKhamBenh.Location = new Point(3, 259);
            btn_MenuDVKhamBenh.Name = "btn_MenuDVKhamBenh";
            btn_MenuDVKhamBenh.Padding = new Padding(10, 0, 0, 0);
            btn_MenuDVKhamBenh.Size = new Size(264, 48);
            btn_MenuDVKhamBenh.TabIndex = 3;
            btn_MenuDVKhamBenh.Text = "🩺  Dịch vụ khám bệnh";
            btn_MenuDVKhamBenh.TextAlign = ContentAlignment.MiddleLeft;
            btn_MenuDVKhamBenh.UseVisualStyleBackColor = false;
            btn_MenuDVKhamBenh.Click += btn_MenuDVKhamBenh_Click;
            // 
            // pnlSubKhamBenh
            // 
            pnlSubKhamBenh.Controls.Add(btn_GhiDonThuoc);
            pnlSubKhamBenh.Controls.Add(btn_GhiChuanDoan);
            pnlSubKhamBenh.Controls.Add(btn_GhiTrieuChung);
            pnlSubKhamBenh.Controls.Add(btn_TaoLuotKham);
            pnlSubKhamBenh.Dock = DockStyle.None;
            pnlSubKhamBenh.Location = new Point(3, 310);
            pnlSubKhamBenh.Name = "pnlSubKhamBenh";
            pnlSubKhamBenh.Size = new Size(264, 156);
            pnlSubKhamBenh.TabIndex = 4;
            pnlSubKhamBenh.Paint += pnlSubNav_Paint;
            // 
            // btn_GhiDonThuoc
            // 
            btn_GhiDonThuoc.Dock = DockStyle.Top;
            btn_GhiDonThuoc.FlatAppearance.BorderSize = 0;
            btn_GhiDonThuoc.FlatAppearance.MouseOverBackColor = Color.FromArgb(186, 210, 240);
            btn_GhiDonThuoc.FlatStyle = FlatStyle.Flat;
            btn_GhiDonThuoc.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_GhiDonThuoc.ForeColor = Color.FromArgb(30, 41, 59);
            btn_GhiDonThuoc.Location = new Point(0, 114);
            btn_GhiDonThuoc.Name = "btn_GhiDonThuoc";
            btn_GhiDonThuoc.Padding = new Padding(28, 0, 0, 0);
            btn_GhiDonThuoc.Size = new Size(264, 38);
            btn_GhiDonThuoc.TabIndex = 3;
            btn_GhiDonThuoc.Text = "💊  Ghi nhận xử lý / thuốc";
            btn_GhiDonThuoc.TextAlign = ContentAlignment.MiddleLeft;
            btn_GhiDonThuoc.UseVisualStyleBackColor = true;
            btn_GhiDonThuoc.Click += btn_GhiDonThuoc_Click;
            // 
            // btn_GhiChuanDoan
            // 
            btn_GhiChuanDoan.Dock = DockStyle.Top;
            btn_GhiChuanDoan.FlatAppearance.BorderSize = 0;
            btn_GhiChuanDoan.FlatAppearance.MouseOverBackColor = Color.FromArgb(186, 210, 240);
            btn_GhiChuanDoan.FlatStyle = FlatStyle.Flat;
            btn_GhiChuanDoan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_GhiChuanDoan.ForeColor = Color.FromArgb(30, 41, 59);
            btn_GhiChuanDoan.Location = new Point(0, 76);
            btn_GhiChuanDoan.Name = "btn_GhiChuanDoan";
            btn_GhiChuanDoan.Padding = new Padding(28, 0, 0, 0);
            btn_GhiChuanDoan.Size = new Size(264, 38);
            btn_GhiChuanDoan.TabIndex = 2;
            btn_GhiChuanDoan.Text = "📋  Ghi nhận chuẩn đoán";
            btn_GhiChuanDoan.TextAlign = ContentAlignment.MiddleLeft;
            btn_GhiChuanDoan.UseVisualStyleBackColor = true;
            btn_GhiChuanDoan.Click += btn_GhiChuanDoan_Click;
            // 
            // btn_GhiTrieuChung
            // 
            btn_GhiTrieuChung.Dock = DockStyle.Top;
            btn_GhiTrieuChung.FlatAppearance.BorderSize = 0;
            btn_GhiTrieuChung.FlatAppearance.MouseOverBackColor = Color.FromArgb(186, 210, 240);
            btn_GhiTrieuChung.FlatStyle = FlatStyle.Flat;
            btn_GhiTrieuChung.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_GhiTrieuChung.ForeColor = Color.FromArgb(30, 41, 59);
            btn_GhiTrieuChung.Location = new Point(0, 38);
            btn_GhiTrieuChung.Name = "btn_GhiTrieuChung";
            btn_GhiTrieuChung.Padding = new Padding(28, 0, 0, 0);
            btn_GhiTrieuChung.Size = new Size(264, 38);
            btn_GhiTrieuChung.TabIndex = 1;
            btn_GhiTrieuChung.Text = "🌡️  Ghi nhận triệu chứng";
            btn_GhiTrieuChung.TextAlign = ContentAlignment.MiddleLeft;
            btn_GhiTrieuChung.UseVisualStyleBackColor = true;
            btn_GhiTrieuChung.Click += btn_GhiTrieuChung_Click;
            // 
            // btn_TaoLuotKham
            // 
            btn_TaoLuotKham.Dock = DockStyle.Top;
            btn_TaoLuotKham.FlatAppearance.BorderSize = 0;
            btn_TaoLuotKham.FlatAppearance.MouseOverBackColor = Color.FromArgb(186, 210, 240);
            btn_TaoLuotKham.FlatStyle = FlatStyle.Flat;
            btn_TaoLuotKham.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_TaoLuotKham.ForeColor = Color.FromArgb(30, 41, 59);
            btn_TaoLuotKham.Location = new Point(0, 0);
            btn_TaoLuotKham.Name = "btn_TaoLuotKham";
            btn_TaoLuotKham.Padding = new Padding(28, 0, 0, 0);
            btn_TaoLuotKham.Size = new Size(264, 38);
            btn_TaoLuotKham.TabIndex = 0;
            btn_TaoLuotKham.Text = "➕  Tạo lượt khám";
            btn_TaoLuotKham.TextAlign = ContentAlignment.MiddleLeft;
            btn_TaoLuotKham.UseVisualStyleBackColor = true;
            btn_TaoLuotKham.Click += btn_TaoLuotKham_Click;
            // 
            // btn_MenuBaoCao
            // 
            btn_MenuBaoCao.BackColor = UiTheme.PrimaryBlue;
            btn_MenuBaoCao.Dock = DockStyle.None;
            btn_MenuBaoCao.FlatAppearance.BorderSize = 0;
            btn_MenuBaoCao.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 185);
            btn_MenuBaoCao.FlatStyle = FlatStyle.Flat;
            btn_MenuBaoCao.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_MenuBaoCao.ForeColor = Color.White;
            btn_MenuBaoCao.Location = new Point(3, 443);
            btn_MenuBaoCao.Name = "btn_MenuBaoCao";
            btn_MenuBaoCao.Padding = new Padding(10, 0, 0, 0);
            btn_MenuBaoCao.Size = new Size(264, 48);
            btn_MenuBaoCao.TabIndex = 5;
            btn_MenuBaoCao.Text = "📊  Tra cứu và Báo cáo";
            btn_MenuBaoCao.TextAlign = ContentAlignment.MiddleLeft;
            btn_MenuBaoCao.UseVisualStyleBackColor = false;
            btn_MenuBaoCao.Click += btn_MenuBaoCao_Click;
            // 
            // pnlSubBaoCao
            // 
            pnlSubBaoCao.Controls.Add(btn_ThongKeKB);
            pnlSubBaoCao.Controls.Add(btn_LinhSuKB);
            pnlSubBaoCao.Dock = DockStyle.None;
            pnlSubBaoCao.Location = new Point(3, 494);
            pnlSubBaoCao.Name = "pnlSubBaoCao";
            pnlSubBaoCao.Size = new Size(264, 80);
            pnlSubBaoCao.TabIndex = 6;
            pnlSubBaoCao.Paint += pnlSubNav_Paint;
            // 
            // btn_ThongKeKB
            // 
            btn_ThongKeKB.Dock = DockStyle.Top;
            btn_ThongKeKB.FlatAppearance.BorderSize = 0;
            btn_ThongKeKB.FlatAppearance.MouseOverBackColor = Color.FromArgb(186, 210, 240);
            btn_ThongKeKB.FlatStyle = FlatStyle.Flat;
            btn_ThongKeKB.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ThongKeKB.ForeColor = Color.FromArgb(30, 41, 59);
            btn_ThongKeKB.Location = new Point(0, 38);
            btn_ThongKeKB.Name = "btn_ThongKeKB";
            btn_ThongKeKB.Padding = new Padding(28, 0, 0, 0);
            btn_ThongKeKB.Size = new Size(264, 38);
            btn_ThongKeKB.TabIndex = 1;
            btn_ThongKeKB.Text = "📅  Thống kê lượt khám theo ngày";
            btn_ThongKeKB.TextAlign = ContentAlignment.MiddleLeft;
            btn_ThongKeKB.UseVisualStyleBackColor = true;
            btn_ThongKeKB.Click += btn_ThongKeKB_Click;
            // 
            // btn_LinhSuKB
            // 
            btn_LinhSuKB.Dock = DockStyle.Top;
            btn_LinhSuKB.FlatAppearance.BorderSize = 0;
            btn_LinhSuKB.FlatAppearance.MouseOverBackColor = Color.FromArgb(186, 210, 240);
            btn_LinhSuKB.FlatStyle = FlatStyle.Flat;
            btn_LinhSuKB.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_LinhSuKB.ForeColor = Color.FromArgb(30, 41, 59);
            btn_LinhSuKB.Location = new Point(0, 0);
            btn_LinhSuKB.Name = "btn_LinhSuKB";
            btn_LinhSuKB.Padding = new Padding(28, 0, 0, 0);
            btn_LinhSuKB.Size = new Size(264, 38);
            btn_LinhSuKB.TabIndex = 0;
            btn_LinhSuKB.Text = "📁  Lịch sử khám bệnh";
            btn_LinhSuKB.TextAlign = ContentAlignment.MiddleLeft;
            btn_LinhSuKB.UseVisualStyleBackColor = true;
            btn_LinhSuKB.Click += btn_LinhSuKB_Click;
            // 
            // pnl_Content
            // 
            pnl_Content.Dock = DockStyle.Fill;
            pnl_Content.Location = new Point(288, 0);
            pnl_Content.Name = "pnl_Content";
            pnl_Content.Size = new Size(712, 700);
            pnl_Content.TabIndex = 1;
            pnl_Content.Paint += pnl_Content_Paint;
            // 
            // FHospitalManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 700);
            Controls.Add(pnl_Content);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(860, 600);
            Name = "FHospitalManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phòng khám điện tử MINI";
            panel1.ResumeLayout(false);
            pnlSidebarHeader.ResumeLayout(false);
            FLPnl_MenuMain.ResumeLayout(false);
            pnlSubTiepNhan.ResumeLayout(false);
            pnlSubKhamBenh.ResumeLayout(false);
            pnlSubBaoCao.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlSidebarHeader;
        private Button btnToggleSidebar;
        private FlowLayoutPanel FLPnl_MenuMain;
        private Panel pnl_Content;
        private Button btn_MenuTNvaQL;
        private Panel pnlSubTiepNhan;
        private Button btn_TimKiemBN;
        private Button btn_QLBenhNhan;
        private Button btn_MenuDVKhamBenh;
        private Panel pnlSubKhamBenh;
        private Button btn_GhiDonThuoc;
        private Button btn_GhiChuanDoan;
        private Button btn_GhiTrieuChung;
        private Button btn_TaoLuotKham;
        private Button btn_MenuBaoCao;
        private Panel pnlSubBaoCao;
        private Button btn_ThongKeKB;
        private Button btn_LinhSuKB;
    }
}