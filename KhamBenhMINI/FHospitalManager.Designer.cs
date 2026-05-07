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
            FLPnl_MenuMain = new FlowLayoutPanel();
            pictureBox_Logo = new PictureBox();
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
            FLPnl_MenuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Logo).BeginInit();
            pnlSubTiepNhan.SuspendLayout();
            pnlSubKhamBenh.SuspendLayout();
            pnlSubBaoCao.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(FLPnl_MenuMain);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 653);
            panel1.TabIndex = 0;
            // 
            // FLPnl_MenuMain
            // 
            FLPnl_MenuMain.Controls.Add(pictureBox_Logo);
            FLPnl_MenuMain.Controls.Add(btn_MenuTNvaQL);
            FLPnl_MenuMain.Controls.Add(pnlSubTiepNhan);
            FLPnl_MenuMain.Controls.Add(btn_MenuDVKhamBenh);
            FLPnl_MenuMain.Controls.Add(pnlSubKhamBenh);
            FLPnl_MenuMain.Controls.Add(btn_MenuBaoCao);
            FLPnl_MenuMain.Controls.Add(pnlSubBaoCao);
            FLPnl_MenuMain.Dock = DockStyle.Fill;
            FLPnl_MenuMain.Location = new Point(0, 0);
            FLPnl_MenuMain.Name = "FLPnl_MenuMain";
            FLPnl_MenuMain.Size = new Size(281, 653);
            FLPnl_MenuMain.TabIndex = 0;
            FLPnl_MenuMain.Paint += this.FLPnl_MenuMain_Paint;
            // 
            // pictureBox_Logo
            // 
            pictureBox_Logo.Location = new Point(3, 3);
            pictureBox_Logo.Name = "pictureBox_Logo";
            pictureBox_Logo.Size = new Size(278, 131);
            pictureBox_Logo.TabIndex = 0;
            pictureBox_Logo.TabStop = false;
            pictureBox_Logo.Click += this.pictureBox_Logo_Click;
            // 
            // btn_MenuTNvaQL
            // 
            btn_MenuTNvaQL.BackColor = Color.DodgerBlue;
            btn_MenuTNvaQL.FlatAppearance.BorderSize = 0;
            btn_MenuTNvaQL.FlatStyle = FlatStyle.Flat;
            btn_MenuTNvaQL.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_MenuTNvaQL.ForeColor = SystemColors.ControlLightLight;
            btn_MenuTNvaQL.Location = new Point(3, 140);
            btn_MenuTNvaQL.Name = "btn_MenuTNvaQL";
            btn_MenuTNvaQL.Size = new Size(272, 45);
            btn_MenuTNvaQL.TabIndex = 1;
            btn_MenuTNvaQL.Text = "Tiếp nhận và Quản lý ";
            btn_MenuTNvaQL.TextAlign = ContentAlignment.MiddleLeft;
            btn_MenuTNvaQL.UseVisualStyleBackColor = false;
            btn_MenuTNvaQL.Click += this.btn_MenuTNvaQL_Click;
            // 
            // pnlSubTiepNhan
            // 
            pnlSubTiepNhan.Controls.Add(btn_TimKiemBN);
            pnlSubTiepNhan.Controls.Add(btn_QLBenhNhan);
            pnlSubTiepNhan.Location = new Point(3, 191);
            pnlSubTiepNhan.Name = "pnlSubTiepNhan";
            pnlSubTiepNhan.Size = new Size(272, 62);
            pnlSubTiepNhan.TabIndex = 2;
            pnlSubTiepNhan.Paint += this.pnlSubTiepNhan_Paint;
            // 
            // btn_TimKiemBN
            // 
            btn_TimKiemBN.Dock = DockStyle.Top;
            btn_TimKiemBN.FlatAppearance.BorderSize = 0;
            btn_TimKiemBN.FlatStyle = FlatStyle.Flat;
            btn_TimKiemBN.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TimKiemBN.Location = new Point(0, 29);
            btn_TimKiemBN.Name = "btn_TimKiemBN";
            btn_TimKiemBN.Padding = new Padding(30, 0, 0, 0);
            btn_TimKiemBN.Size = new Size(272, 29);
            btn_TimKiemBN.TabIndex = 1;
            btn_TimKiemBN.Text = "Tìm kiếm bệnh nhân";
            btn_TimKiemBN.TextAlign = ContentAlignment.MiddleLeft;
            btn_TimKiemBN.UseVisualStyleBackColor = true;
            btn_TimKiemBN.Click += this.btn_TimKiemBN_Click;
            // 
            // btn_QLBenhNhan
            // 
            btn_QLBenhNhan.Dock = DockStyle.Top;
            btn_QLBenhNhan.FlatAppearance.BorderSize = 0;
            btn_QLBenhNhan.FlatStyle = FlatStyle.Flat;
            btn_QLBenhNhan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_QLBenhNhan.Location = new Point(0, 0);
            btn_QLBenhNhan.Name = "btn_QLBenhNhan";
            btn_QLBenhNhan.Padding = new Padding(30, 0, 0, 0);
            btn_QLBenhNhan.Size = new Size(272, 29);
            btn_QLBenhNhan.TabIndex = 0;
            btn_QLBenhNhan.Text = "Quản lý bệnh nhân";
            btn_QLBenhNhan.TextAlign = ContentAlignment.MiddleLeft;
            btn_QLBenhNhan.UseVisualStyleBackColor = true;
            btn_QLBenhNhan.Click += this.btn_QLBenhNhan_Click;
            // 
            // btn_MenuDVKhamBenh
            // 
            btn_MenuDVKhamBenh.BackColor = Color.DodgerBlue;
            btn_MenuDVKhamBenh.FlatAppearance.BorderSize = 0;
            btn_MenuDVKhamBenh.FlatStyle = FlatStyle.Flat;
            btn_MenuDVKhamBenh.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_MenuDVKhamBenh.ForeColor = SystemColors.ControlLightLight;
            btn_MenuDVKhamBenh.Location = new Point(3, 259);
            btn_MenuDVKhamBenh.Name = "btn_MenuDVKhamBenh";
            btn_MenuDVKhamBenh.Size = new Size(272, 45);
            btn_MenuDVKhamBenh.TabIndex = 3;
            btn_MenuDVKhamBenh.Text = "Dịch vụ khám bệnh";
            btn_MenuDVKhamBenh.TextAlign = ContentAlignment.MiddleLeft;
            btn_MenuDVKhamBenh.UseVisualStyleBackColor = false;
            // 
            // pnlSubKhamBenh
            // 
            pnlSubKhamBenh.Controls.Add(btn_GhiDonThuoc);
            pnlSubKhamBenh.Controls.Add(btn_GhiChuanDoan);
            pnlSubKhamBenh.Controls.Add(btn_GhiTrieuChung);
            pnlSubKhamBenh.Controls.Add(btn_TaoLuotKham);
            pnlSubKhamBenh.Location = new Point(3, 310);
            pnlSubKhamBenh.Name = "pnlSubKhamBenh";
            pnlSubKhamBenh.Size = new Size(272, 127);
            pnlSubKhamBenh.TabIndex = 4;
            // 
            // btn_GhiDonThuoc
            // 
            btn_GhiDonThuoc.Dock = DockStyle.Top;
            btn_GhiDonThuoc.FlatAppearance.BorderSize = 0;
            btn_GhiDonThuoc.FlatStyle = FlatStyle.Flat;
            btn_GhiDonThuoc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_GhiDonThuoc.Location = new Point(0, 87);
            btn_GhiDonThuoc.Name = "btn_GhiDonThuoc";
            btn_GhiDonThuoc.Padding = new Padding(30, 0, 0, 0);
            btn_GhiDonThuoc.Size = new Size(272, 29);
            btn_GhiDonThuoc.TabIndex = 3;
            btn_GhiDonThuoc.Text = "Ghi nhận xử lý / thuốc";
            btn_GhiDonThuoc.TextAlign = ContentAlignment.MiddleLeft;
            btn_GhiDonThuoc.UseVisualStyleBackColor = true;
            // 
            // btn_GhiChuanDoan
            // 
            btn_GhiChuanDoan.Dock = DockStyle.Top;
            btn_GhiChuanDoan.FlatAppearance.BorderSize = 0;
            btn_GhiChuanDoan.FlatStyle = FlatStyle.Flat;
            btn_GhiChuanDoan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_GhiChuanDoan.Location = new Point(0, 58);
            btn_GhiChuanDoan.Name = "btn_GhiChuanDoan";
            btn_GhiChuanDoan.Padding = new Padding(30, 0, 0, 0);
            btn_GhiChuanDoan.Size = new Size(272, 29);
            btn_GhiChuanDoan.TabIndex = 2;
            btn_GhiChuanDoan.Text = "Ghi nhận chuẩn đoán";
            btn_GhiChuanDoan.TextAlign = ContentAlignment.MiddleLeft;
            btn_GhiChuanDoan.UseVisualStyleBackColor = true;
            // 
            // btn_GhiTrieuChung
            // 
            btn_GhiTrieuChung.Dock = DockStyle.Top;
            btn_GhiTrieuChung.FlatAppearance.BorderSize = 0;
            btn_GhiTrieuChung.FlatStyle = FlatStyle.Flat;
            btn_GhiTrieuChung.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_GhiTrieuChung.Location = new Point(0, 29);
            btn_GhiTrieuChung.Name = "btn_GhiTrieuChung";
            btn_GhiTrieuChung.Padding = new Padding(30, 0, 0, 0);
            btn_GhiTrieuChung.Size = new Size(272, 29);
            btn_GhiTrieuChung.TabIndex = 1;
            btn_GhiTrieuChung.Text = "Ghi nhận triệu chứng";
            btn_GhiTrieuChung.TextAlign = ContentAlignment.MiddleLeft;
            btn_GhiTrieuChung.UseVisualStyleBackColor = true;
            // 
            // btn_TaoLuotKham
            // 
            btn_TaoLuotKham.Dock = DockStyle.Top;
            btn_TaoLuotKham.FlatAppearance.BorderSize = 0;
            btn_TaoLuotKham.FlatStyle = FlatStyle.Flat;
            btn_TaoLuotKham.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TaoLuotKham.ForeColor = SystemColors.ActiveCaptionText;
            btn_TaoLuotKham.Location = new Point(0, 0);
            btn_TaoLuotKham.Name = "btn_TaoLuotKham";
            btn_TaoLuotKham.Padding = new Padding(30, 0, 0, 0);
            btn_TaoLuotKham.Size = new Size(272, 29);
            btn_TaoLuotKham.TabIndex = 0;
            btn_TaoLuotKham.Text = "Tạo lượt khám";
            btn_TaoLuotKham.TextAlign = ContentAlignment.MiddleLeft;
            btn_TaoLuotKham.UseVisualStyleBackColor = true;
            // 
            // btn_MenuBaoCao
            // 
            btn_MenuBaoCao.BackColor = Color.DodgerBlue;
            btn_MenuBaoCao.FlatAppearance.BorderSize = 0;
            btn_MenuBaoCao.FlatStyle = FlatStyle.Flat;
            btn_MenuBaoCao.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_MenuBaoCao.ForeColor = SystemColors.ButtonHighlight;
            btn_MenuBaoCao.Location = new Point(3, 443);
            btn_MenuBaoCao.Name = "btn_MenuBaoCao";
            btn_MenuBaoCao.Size = new Size(272, 45);
            btn_MenuBaoCao.TabIndex = 5;
            btn_MenuBaoCao.Text = "Tra cứu và Báo cáo";
            btn_MenuBaoCao.TextAlign = ContentAlignment.MiddleLeft;
            btn_MenuBaoCao.UseVisualStyleBackColor = false;
            // 
            // pnlSubBaoCao
            // 
            pnlSubBaoCao.Controls.Add(btn_ThongKeKB);
            pnlSubBaoCao.Controls.Add(btn_LinhSuKB);
            pnlSubBaoCao.Location = new Point(3, 494);
            pnlSubBaoCao.Name = "pnlSubBaoCao";
            pnlSubBaoCao.Size = new Size(272, 74);
            pnlSubBaoCao.TabIndex = 6;
            // 
            // btn_ThongKeKB
            // 
            btn_ThongKeKB.FlatAppearance.BorderSize = 0;
            btn_ThongKeKB.FlatStyle = FlatStyle.Flat;
            btn_ThongKeKB.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ThongKeKB.Location = new Point(3, 38);
            btn_ThongKeKB.Name = "btn_ThongKeKB";
            btn_ThongKeKB.Padding = new Padding(30, 0, 0, 0);
            btn_ThongKeKB.Size = new Size(266, 29);
            btn_ThongKeKB.TabIndex = 1;
            btn_ThongKeKB.Text = "Thống kê lượt khám theo ngày";
            btn_ThongKeKB.TextAlign = ContentAlignment.MiddleLeft;
            btn_ThongKeKB.UseVisualStyleBackColor = true;
            // 
            // btn_LinhSuKB
            // 
            btn_LinhSuKB.FlatAppearance.BorderSize = 0;
            btn_LinhSuKB.FlatStyle = FlatStyle.Flat;
            btn_LinhSuKB.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_LinhSuKB.Location = new Point(3, 3);
            btn_LinhSuKB.Name = "btn_LinhSuKB";
            btn_LinhSuKB.Padding = new Padding(30, 0, 0, 0);
            btn_LinhSuKB.Size = new Size(266, 29);
            btn_LinhSuKB.TabIndex = 0;
            btn_LinhSuKB.Text = "Lịch sử khám bệnh";
            btn_LinhSuKB.TextAlign = ContentAlignment.MiddleLeft;
            btn_LinhSuKB.UseVisualStyleBackColor = true;
            // 
            // pnl_Content
            // 
            pnl_Content.Dock = DockStyle.Fill;
            pnl_Content.Location = new Point(281, 0);
            pnl_Content.Name = "pnl_Content";
            pnl_Content.Size = new Size(601, 653);
            pnl_Content.TabIndex = 1;
            // 
            // FHospitalManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 653);
            Controls.Add(pnl_Content);
            Controls.Add(panel1);
            Name = "FHospitalManager";
            Text = "Form2";
            panel1.ResumeLayout(false);
            FLPnl_MenuMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Logo).EndInit();
            pnlSubTiepNhan.ResumeLayout(false);
            pnlSubKhamBenh.ResumeLayout(false);
            pnlSubBaoCao.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel FLPnl_MenuMain;
        private Panel pnl_Content;
        private PictureBox pictureBox_Logo;
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