using System.Drawing;
using System.Windows.Forms;
using KhamBenhMINI.Features.DichVuKhamBenh;

namespace KhamBenhMINI
{
    partial class FThongKe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnl_Content = new Panel();
            groupBox1 = new GroupBox();
            tblMain = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            tblFilter = new TableLayoutPanel();
            label1 = new Label();
            dtp_FromDate = new DateTimePicker();
            label2 = new Label();
            dtp_ToDate = new DateTimePicker();
            btn_ThongKeTheoNgay = new Button();
            label3 = new Label();
            cbo_BacSi = new ComboBox();
            btn_ThongKeTheoBacSi = new Button();
            btn_ThongKeTheoThang = new Button();
            groupBox3 = new GroupBox();
            tblDetail = new TableLayoutPanel();
            label4 = new Label();
            txt_TongSoLuot = new TextBox();
            btn_ThongKeTongQuan = new Button();
            dgv_ThongKe = new DataGridView();
            groupBox4 = new GroupBox();
            tblAgg = new TableLayoutPanel();
            groupBox5 = new GroupBox();
            dgv_TKTongHop_BacSi = new DataGridView();
            groupBox6 = new GroupBox();
            dgv_TKTongHop_ChuanDoan = new DataGridView();
            pnlFooter = new FlowLayoutPanel();
            btn_Dong = new Button();
            btn_XuatBaoCao = new Button();
            pnl_Content.SuspendLayout();
            groupBox1.SuspendLayout();
            tblMain.SuspendLayout();
            groupBox2.SuspendLayout();
            tblFilter.SuspendLayout();
            groupBox3.SuspendLayout();
            tblDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ThongKe).BeginInit();
            groupBox4.SuspendLayout();
            tblAgg.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_TKTongHop_BacSi).BeginInit();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_TKTongHop_ChuanDoan).BeginInit();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Content
            // 
            pnl_Content.BackColor = Color.FromArgb(248, 250, 252);
            pnl_Content.Controls.Add(groupBox1);
            pnl_Content.Dock = DockStyle.Fill;
            pnl_Content.Location = new Point(0, 0);
            pnl_Content.Name = "pnl_Content";
            pnl_Content.Padding = new Padding(20, 18, 20, 20);
            pnl_Content.Size = new Size(980, 720);
            pnl_Content.TabIndex = 0;
            pnl_Content.Paint += pnl_Content_Paint;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(tblMain);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(37, 99, 235);
            groupBox1.Location = new Point(20, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(940, 682);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thống kê lượt khám";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(groupBox2, 0, 0);
            tblMain.Controls.Add(groupBox3, 0, 1);
            tblMain.Controls.Add(groupBox4, 0, 2);
            tblMain.Controls.Add(pnlFooter, 0, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(3, 28);
            tblMain.Name = "tblMain";
            tblMain.Padding = new Padding(4, 2, 4, 6);
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 148F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 52F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 48F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tblMain.Size = new Size(934, 651);
            tblMain.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(tblFilter);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(37, 99, 235);
            groupBox2.Location = new Point(4, 2);
            groupBox2.Margin = new Padding(0, 0, 0, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(926, 138);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bộ lọc";
            // 
            // tblFilter
            // 
            tblFilter.ColumnCount = 6;
            tblFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            tblFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
            tblFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            tblFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
            tblFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 178F));
            tblFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 188F));
            tblFilter.Controls.Add(label1, 0, 0);
            tblFilter.Controls.Add(dtp_FromDate, 1, 0);
            tblFilter.Controls.Add(label2, 2, 0);
            tblFilter.Controls.Add(dtp_ToDate, 3, 0);
            tblFilter.Controls.Add(btn_ThongKeTheoNgay, 5, 0);
            tblFilter.Controls.Add(label3, 0, 1);
            tblFilter.Controls.Add(cbo_BacSi, 1, 1);
            tblFilter.Controls.Add(btn_ThongKeTheoBacSi, 4, 1);
            tblFilter.Controls.Add(btn_ThongKeTheoThang, 5, 1);
            tblFilter.Dock = DockStyle.Fill;
            tblFilter.Location = new Point(3, 28);
            tblFilter.Name = "tblFilter";
            tblFilter.Padding = new Padding(6, 4, 6, 4);
            tblFilter.RowCount = 2;
            tblFilter.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tblFilter.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tblFilter.Size = new Size(920, 107);
            tblFilter.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(9, 15);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 0;
            label1.Text = "Từ ngày";
            // 
            // dtp_FromDate
            // 
            dtp_FromDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtp_FromDate.CustomFormat = "dd/MM/yyyy";
            dtp_FromDate.Format = DateTimePickerFormat.Custom;
            dtp_FromDate.Location = new Point(94, 11);
            dtp_FromDate.Margin = new Padding(0, 4, 10, 4);
            dtp_FromDate.Name = "dtp_FromDate";
            dtp_FromDate.Size = new Size(171, 32);
            dtp_FromDate.TabIndex = 0;
            dtp_FromDate.ValueChanged += dtp_FromDate_ValueChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(30, 41, 59);
            label2.Location = new Point(278, 15);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 1;
            label2.Text = "Đến ngày";
            // 
            // dtp_ToDate
            // 
            dtp_ToDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtp_ToDate.CustomFormat = "dd/MM/yyyy";
            dtp_ToDate.Format = DateTimePickerFormat.Custom;
            dtp_ToDate.Location = new Point(367, 11);
            dtp_ToDate.Margin = new Padding(0, 4, 10, 4);
            dtp_ToDate.Name = "dtp_ToDate";
            dtp_ToDate.Size = new Size(171, 32);
            dtp_ToDate.TabIndex = 1;
            dtp_ToDate.ValueChanged += dtp_ToDate_ValueChanged;
            // 
            // btn_ThongKeTheoNgay
            // 
            btn_ThongKeTheoNgay.Anchor = AnchorStyles.Right;
            btn_ThongKeTheoNgay.Location = new Point(734, 9);
            btn_ThongKeTheoNgay.Margin = new Padding(8, 4, 0, 4);
            btn_ThongKeTheoNgay.Name = "btn_ThongKeTheoNgay";
            btn_ThongKeTheoNgay.Size = new Size(180, 36);
            btn_ThongKeTheoNgay.TabIndex = 2;
            btn_ThongKeTheoNgay.Text = "Theo khoảng ngày";
            btn_ThongKeTheoNgay.UseVisualStyleBackColor = false;
            btn_ThongKeTheoNgay.Click += btn_ThongKeTheoNgay_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(30, 41, 59);
            label3.Location = new Point(9, 65);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 3;
            label3.Text = "Bác sĩ";
            // 
            // cbo_BacSi
            // 
            cbo_BacSi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tblFilter.SetColumnSpan(cbo_BacSi, 3);
            cbo_BacSi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_BacSi.Location = new Point(94, 62);
            cbo_BacSi.Margin = new Padding(0, 4, 10, 4);
            cbo_BacSi.Name = "cbo_BacSi";
            cbo_BacSi.Size = new Size(444, 33);
            cbo_BacSi.TabIndex = 3;
            cbo_BacSi.SelectedIndexChanged += cbo_BacSi_SelectedIndexChanged;
            // 
            // btn_ThongKeTheoBacSi
            // 
            btn_ThongKeTheoBacSi.Anchor = AnchorStyles.Right;
            btn_ThongKeTheoBacSi.Location = new Point(548, 58);
            btn_ThongKeTheoBacSi.Margin = new Padding(0, 4, 8, 4);
            btn_ThongKeTheoBacSi.Name = "btn_ThongKeTheoBacSi";
            btn_ThongKeTheoBacSi.Size = new Size(170, 36);
            btn_ThongKeTheoBacSi.TabIndex = 4;
            btn_ThongKeTheoBacSi.Text = "Theo bác sĩ";
            btn_ThongKeTheoBacSi.UseVisualStyleBackColor = false;
            btn_ThongKeTheoBacSi.Click += btn_ThongKeTheoBacSi_Click;
            // 
            // btn_ThongKeTheoThang
            // 
            btn_ThongKeTheoThang.Anchor = AnchorStyles.Right;
            btn_ThongKeTheoThang.Location = new Point(734, 58);
            btn_ThongKeTheoThang.Margin = new Padding(8, 4, 0, 4);
            btn_ThongKeTheoThang.Name = "btn_ThongKeTheoThang";
            btn_ThongKeTheoThang.Size = new Size(180, 36);
            btn_ThongKeTheoThang.TabIndex = 5;
            btn_ThongKeTheoThang.Text = "Theo tháng (từ ngày)";
            btn_ThongKeTheoThang.UseVisualStyleBackColor = false;
            btn_ThongKeTheoThang.Click += btn_ThongKeTheoThang_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(tblDetail);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox3.ForeColor = Color.FromArgb(37, 99, 235);
            groupBox3.Location = new Point(4, 150);
            groupBox3.Margin = new Padding(0, 0, 0, 10);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(926, 217);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kết quả chi tiết";
            // 
            // tblDetail
            // 
            tblDetail.ColumnCount = 3;
            tblDetail.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            tblDetail.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tblDetail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblDetail.Controls.Add(label4, 0, 0);
            tblDetail.Controls.Add(txt_TongSoLuot, 1, 0);
            tblDetail.Controls.Add(btn_ThongKeTongQuan, 2, 0);
            tblDetail.Controls.Add(dgv_ThongKe, 0, 1);
            tblDetail.Dock = DockStyle.Fill;
            tblDetail.Location = new Point(3, 28);
            tblDetail.Name = "tblDetail";
            tblDetail.Padding = new Padding(6, 4, 6, 6);
            tblDetail.RowCount = 2;
            tblDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tblDetail.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblDetail.Size = new Size(920, 186);
            tblDetail.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(30, 41, 59);
            label4.Location = new Point(9, 15);
            label4.Name = "label4";
            label4.Size = new Size(90, 23);
            label4.TabIndex = 0;
            label4.Text = "Tổng lượt";
            // 
            // txt_TongSoLuot
            // 
            txt_TongSoLuot.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_TongSoLuot.Location = new Point(102, 11);
            txt_TongSoLuot.Margin = new Padding(0, 4, 12, 4);
            txt_TongSoLuot.Name = "txt_TongSoLuot";
            txt_TongSoLuot.ReadOnly = true;
            txt_TongSoLuot.Size = new Size(108, 32);
            txt_TongSoLuot.TabIndex = 0;
            txt_TongSoLuot.TextAlign = HorizontalAlignment.Center;
            txt_TongSoLuot.TextChanged += txt_TongSoLuot_TextChanged;
            // 
            // btn_ThongKeTongQuan
            // 
            btn_ThongKeTongQuan.Anchor = AnchorStyles.Right;
            btn_ThongKeTongQuan.Location = new Point(694, 9);
            btn_ThongKeTongQuan.Margin = new Padding(8, 4, 0, 4);
            btn_ThongKeTongQuan.Name = "btn_ThongKeTongQuan";
            btn_ThongKeTongQuan.Size = new Size(220, 36);
            btn_ThongKeTongQuan.TabIndex = 1;
            btn_ThongKeTongQuan.Text = "Thống kê tổng quan";
            btn_ThongKeTongQuan.UseVisualStyleBackColor = false;
            btn_ThongKeTongQuan.Click += btn_ThongKeTongQuan_Click;
            // 
            // dgv_ThongKe
            // 
            dgv_ThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblDetail.SetColumnSpan(dgv_ThongKe, 3);
            dgv_ThongKe.Dock = DockStyle.Fill;
            dgv_ThongKe.Location = new Point(6, 58);
            dgv_ThongKe.Margin = new Padding(0, 8, 0, 0);
            dgv_ThongKe.Name = "dgv_ThongKe";
            dgv_ThongKe.RowHeadersWidth = 51;
            dgv_ThongKe.Size = new Size(908, 122);
            dgv_ThongKe.TabIndex = 2;
            dgv_ThongKe.CellContentClick += dgv_ThongKe_CellContentClick;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(tblAgg);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox4.ForeColor = Color.FromArgb(37, 99, 235);
            groupBox4.Location = new Point(4, 377);
            groupBox4.Margin = new Padding(0, 0, 0, 10);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(926, 199);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tổng hợp nhanh";
            // 
            // tblAgg
            // 
            tblAgg.ColumnCount = 2;
            tblAgg.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblAgg.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblAgg.Controls.Add(groupBox5, 0, 0);
            tblAgg.Controls.Add(groupBox6, 1, 0);
            tblAgg.Dock = DockStyle.Fill;
            tblAgg.Location = new Point(3, 28);
            tblAgg.Name = "tblAgg";
            tblAgg.Padding = new Padding(4, 2, 4, 4);
            tblAgg.RowCount = 1;
            tblAgg.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblAgg.Size = new Size(920, 168);
            tblAgg.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.White;
            groupBox5.Controls.Add(dgv_TKTongHop_BacSi);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Font = new Font("Segoe UI", 10F);
            groupBox5.ForeColor = Color.FromArgb(30, 41, 59);
            groupBox5.Location = new Point(4, 2);
            groupBox5.Margin = new Padding(0, 0, 8, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(448, 162);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Theo bác sĩ";
            // 
            // dgv_TKTongHop_BacSi
            // 
            dgv_TKTongHop_BacSi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_TKTongHop_BacSi.Dock = DockStyle.Fill;
            dgv_TKTongHop_BacSi.Location = new Point(3, 26);
            dgv_TKTongHop_BacSi.Margin = new Padding(6);
            dgv_TKTongHop_BacSi.Name = "dgv_TKTongHop_BacSi";
            dgv_TKTongHop_BacSi.RowHeadersWidth = 51;
            dgv_TKTongHop_BacSi.Size = new Size(442, 133);
            dgv_TKTongHop_BacSi.TabIndex = 0;
            dgv_TKTongHop_BacSi.CellContentClick += dgv_TKTongHop_BacSi_CellContentClick;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.White;
            groupBox6.Controls.Add(dgv_TKTongHop_ChuanDoan);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Font = new Font("Segoe UI", 10F);
            groupBox6.ForeColor = Color.FromArgb(30, 41, 59);
            groupBox6.Location = new Point(468, 2);
            groupBox6.Margin = new Padding(8, 0, 0, 0);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(448, 162);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Theo chẩn đoán";
            // 
            // dgv_TKTongHop_ChuanDoan
            // 
            dgv_TKTongHop_ChuanDoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_TKTongHop_ChuanDoan.Dock = DockStyle.Fill;
            dgv_TKTongHop_ChuanDoan.Location = new Point(3, 26);
            dgv_TKTongHop_ChuanDoan.Margin = new Padding(6);
            dgv_TKTongHop_ChuanDoan.Name = "dgv_TKTongHop_ChuanDoan";
            dgv_TKTongHop_ChuanDoan.RowHeadersWidth = 51;
            dgv_TKTongHop_ChuanDoan.Size = new Size(442, 133);
            dgv_TKTongHop_ChuanDoan.TabIndex = 0;
            dgv_TKTongHop_ChuanDoan.CellContentClick += dgv_TKTongHop_ChuanDoan_CellContentClick;
            // 
            // pnlFooter
            // 
            pnlFooter.AutoSize = true;
            pnlFooter.Controls.Add(btn_Dong);
            pnlFooter.Controls.Add(btn_XuatBaoCao);
            pnlFooter.Dock = DockStyle.Fill;
            pnlFooter.FlowDirection = FlowDirection.RightToLeft;
            pnlFooter.Location = new Point(7, 589);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Padding = new Padding(0, 6, 0, 0);
            pnlFooter.Size = new Size(920, 53);
            pnlFooter.TabIndex = 3;
            // 
            // btn_Dong
            // 
            btn_Dong.Location = new Point(800, 6);
            btn_Dong.Margin = new Padding(12, 0, 0, 0);
            btn_Dong.Name = "btn_Dong";
            btn_Dong.Size = new Size(120, 40);
            btn_Dong.TabIndex = 1;
            btn_Dong.Text = "Đóng";
            btn_Dong.UseVisualStyleBackColor = false;
            btn_Dong.Click += btn_Dong_Click;
            // 
            // btn_XuatBaoCao
            // 
            btn_XuatBaoCao.Location = new Point(620, 6);
            btn_XuatBaoCao.Margin = new Padding(0);
            btn_XuatBaoCao.Name = "btn_XuatBaoCao";
            btn_XuatBaoCao.Size = new Size(168, 40);
            btn_XuatBaoCao.TabIndex = 0;
            btn_XuatBaoCao.Text = "Xuất báo cáo (.txt)";
            btn_XuatBaoCao.UseVisualStyleBackColor = false;
            btn_XuatBaoCao.Click += btn_XuatBaoCao_Click;
            // 
            // FThongKe
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(980, 720);
            Controls.Add(pnl_Content);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(860, 620);
            Name = "FThongKe";
            Text = "Thống kê lượt khám — Phòng khám MINI";
            pnl_Content.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            groupBox2.ResumeLayout(false);
            tblFilter.ResumeLayout(false);
            tblFilter.PerformLayout();
            groupBox3.ResumeLayout(false);
            tblDetail.ResumeLayout(false);
            tblDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ThongKe).EndInit();
            groupBox4.ResumeLayout(false);
            tblAgg.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_TKTongHop_BacSi).EndInit();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_TKTongHop_ChuanDoan).EndInit();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Content;
        private GroupBox groupBox1;
        private TableLayoutPanel tblMain;
        private GroupBox groupBox2;
        private TableLayoutPanel tblFilter;
        private GroupBox groupBox3;
        private TableLayoutPanel tblDetail;
        private GroupBox groupBox4;
        private TableLayoutPanel tblAgg;
        private FlowLayoutPanel pnlFooter;
        private Button btn_Dong;
        private Button btn_XuatBaoCao;
        private GroupBox groupBox6;
        private DataGridView dgv_TKTongHop_ChuanDoan;
        private GroupBox groupBox5;
        private DataGridView dgv_TKTongHop_BacSi;
        private DataGridView dgv_ThongKe;
        private Button btn_ThongKeTongQuan;
        private TextBox txt_TongSoLuot;
        private Label label4;
        private Button btn_ThongKeTheoBacSi;
        private Button btn_ThongKeTheoThang;
        private Button btn_ThongKeTheoNgay;
        private ComboBox cbo_BacSi;
        private Label label3;
        private DateTimePicker dtp_ToDate;
        private DateTimePicker dtp_FromDate;
        private Label label2;
        private Label label1;
    }
}
