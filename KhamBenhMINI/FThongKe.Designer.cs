namespace KhamBenhMINI
{
    partial class FThongKe
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
            pnl_Content = new Panel();
            groupBox1 = new GroupBox();
            btn_Dong = new Button();
            btn_XuatBaoCao = new Button();
            groupBox4 = new GroupBox();
            groupBox6 = new GroupBox();
            dgv_TKTongHop_ChuanDoan = new DataGridView();
            groupBox5 = new GroupBox();
            dgv_TKTongHop_BacSi = new DataGridView();
            groupBox3 = new GroupBox();
            dgv_ThongKe = new DataGridView();
            btn_ThongKeTongQuan = new Button();
            txt_TongSoLuot = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            btn_ThongKeTheoBacSi = new Button();
            btn_ThongKeTheoThang = new Button();
            btn_ThongKeTheoNgay = new Button();
            cbo_BacSi = new ComboBox();
            label3 = new Label();
            dtp_ToDate = new DateTimePicker();
            dtp_FromDate = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            pnl_Content.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_TKTongHop_ChuanDoan).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_TKTongHop_BacSi).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ThongKe).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Content
            // 
            pnl_Content.Controls.Add(groupBox1);
            pnl_Content.Dock = DockStyle.Fill;
            pnl_Content.Location = new Point(0, 0);
            pnl_Content.Name = "pnl_Content";
            pnl_Content.Size = new Size(882, 653);
            pnl_Content.TabIndex = 4;
            pnl_Content.Paint += pnl_Content_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Dong);
            groupBox1.Controls.Add(btn_XuatBaoCao);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(580, 650);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "THỐNG KÊ LƯỢT KHÁM";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btn_Dong
            // 
            btn_Dong.BackColor = Color.Red;
            btn_Dong.FlatAppearance.BorderSize = 0;
            btn_Dong.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Dong.ForeColor = SystemColors.ButtonHighlight;
            btn_Dong.Location = new Point(468, 601);
            btn_Dong.Name = "btn_Dong";
            btn_Dong.Size = new Size(94, 37);
            btn_Dong.TabIndex = 4;
            btn_Dong.Text = "Đóng";
            btn_Dong.UseVisualStyleBackColor = false;
            btn_Dong.Click += btn_Dong_Click;
            // 
            // btn_XuatBaoCao
            // 
            btn_XuatBaoCao.BackColor = Color.LimeGreen;
            btn_XuatBaoCao.FlatAppearance.BorderSize = 0;
            btn_XuatBaoCao.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_XuatBaoCao.ForeColor = SystemColors.ButtonHighlight;
            btn_XuatBaoCao.Location = new Point(43, 601);
            btn_XuatBaoCao.Name = "btn_XuatBaoCao";
            btn_XuatBaoCao.Size = new Size(160, 37);
            btn_XuatBaoCao.TabIndex = 3;
            btn_XuatBaoCao.Text = "Xuất báo cáo";
            btn_XuatBaoCao.UseVisualStyleBackColor = false;
            btn_XuatBaoCao.Click += btn_XuatBaoCao_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(9, 368);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(559, 212);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thống kê tổng hợp";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dgv_TKTongHop_ChuanDoan);
            groupBox6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox6.Location = new Point(291, 26);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(262, 180);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Theo chuẩn đoán";
            // 
            // dgv_TKTongHop_ChuanDoan
            // 
            dgv_TKTongHop_ChuanDoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_TKTongHop_ChuanDoan.Location = new Point(9, 26);
            dgv_TKTongHop_ChuanDoan.Name = "dgv_TKTongHop_ChuanDoan";
            dgv_TKTongHop_ChuanDoan.RowHeadersWidth = 51;
            dgv_TKTongHop_ChuanDoan.Size = new Size(247, 148);
            dgv_TKTongHop_ChuanDoan.TabIndex = 1;
            dgv_TKTongHop_ChuanDoan.CellContentClick += dgv_TKTongHop_ChuanDoan_CellContentClick;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dgv_TKTongHop_BacSi);
            groupBox5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(6, 26);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(261, 180);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Theo bác sĩ";
            // 
            // dgv_TKTongHop_BacSi
            // 
            dgv_TKTongHop_BacSi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_TKTongHop_BacSi.Location = new Point(6, 26);
            dgv_TKTongHop_BacSi.Name = "dgv_TKTongHop_BacSi";
            dgv_TKTongHop_BacSi.RowHeadersWidth = 51;
            dgv_TKTongHop_BacSi.Size = new Size(247, 148);
            dgv_TKTongHop_BacSi.TabIndex = 0;
            dgv_TKTongHop_BacSi.CellContentClick += dgv_TKTongHop_BacSi_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgv_ThongKe);
            groupBox3.Controls.Add(btn_ThongKeTongQuan);
            groupBox3.Controls.Add(txt_TongSoLuot);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(9, 157);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(565, 205);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kết quả chi tiết";
            // 
            // dgv_ThongKe
            // 
            dgv_ThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ThongKe.Location = new Point(6, 63);
            dgv_ThongKe.Name = "dgv_ThongKe";
            dgv_ThongKe.RowHeadersWidth = 51;
            dgv_ThongKe.Size = new Size(553, 136);
            dgv_ThongKe.TabIndex = 3;
            dgv_ThongKe.CellContentClick += dgv_ThongKe_CellContentClick;
            // 
            // btn_ThongKeTongQuan
            // 
            btn_ThongKeTongQuan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ThongKeTongQuan.ForeColor = SystemColors.ActiveCaptionText;
            btn_ThongKeTongQuan.Location = new Point(310, 28);
            btn_ThongKeTongQuan.Name = "btn_ThongKeTongQuan";
            btn_ThongKeTongQuan.Size = new Size(184, 29);
            btn_ThongKeTongQuan.TabIndex = 2;
            btn_ThongKeTongQuan.Text = "Thống kê tổng quan";
            btn_ThongKeTongQuan.UseVisualStyleBackColor = true;
            btn_ThongKeTongQuan.Click += btn_ThongKeTongQuan_Click;
            // 
            // txt_TongSoLuot
            // 
            txt_TongSoLuot.Location = new Point(100, 29);
            txt_TongSoLuot.Name = "txt_TongSoLuot";
            txt_TongSoLuot.Size = new Size(125, 30);
            txt_TongSoLuot.TabIndex = 1;
            txt_TongSoLuot.TextChanged += txt_TongSoLuot_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(20, 32);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 0;
            label4.Text = "Tổng lượt";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_ThongKeTheoBacSi);
            groupBox2.Controls.Add(btn_ThongKeTheoThang);
            groupBox2.Controls.Add(btn_ThongKeTheoNgay);
            groupBox2.Controls.Add(cbo_BacSi);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dtp_ToDate);
            groupBox2.Controls.Add(dtp_FromDate);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(9, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(565, 125);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bộ lọc";
            // 
            // btn_ThongKeTheoBacSi
            // 
            btn_ThongKeTheoBacSi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ThongKeTheoBacSi.ForeColor = SystemColors.ActiveCaptionText;
            btn_ThongKeTheoBacSi.Location = new Point(401, 90);
            btn_ThongKeTheoBacSi.Name = "btn_ThongKeTheoBacSi";
            btn_ThongKeTheoBacSi.Size = new Size(158, 29);
            btn_ThongKeTheoBacSi.TabIndex = 8;
            btn_ThongKeTheoBacSi.Text = "Thống kê theo bác sĩ";
            btn_ThongKeTheoBacSi.UseVisualStyleBackColor = true;
            btn_ThongKeTheoBacSi.Click += btn_ThongKeTheoBacSi_Click;
            // 
            // btn_ThongKeTheoThang
            // 
            btn_ThongKeTheoThang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ThongKeTheoThang.ForeColor = SystemColors.ActiveCaptionText;
            btn_ThongKeTheoThang.Location = new Point(401, 55);
            btn_ThongKeTheoThang.Name = "btn_ThongKeTheoThang";
            btn_ThongKeTheoThang.Size = new Size(158, 29);
            btn_ThongKeTheoThang.TabIndex = 7;
            btn_ThongKeTheoThang.Text = "Thống kê theo tháng";
            btn_ThongKeTheoThang.UseVisualStyleBackColor = true;
            btn_ThongKeTheoThang.Click += btn_ThongKeTheoThang_Click;
            // 
            // btn_ThongKeTheoNgay
            // 
            btn_ThongKeTheoNgay.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ThongKeTheoNgay.ForeColor = SystemColors.ActiveCaptionText;
            btn_ThongKeTheoNgay.Location = new Point(401, 22);
            btn_ThongKeTheoNgay.Name = "btn_ThongKeTheoNgay";
            btn_ThongKeTheoNgay.Size = new Size(158, 29);
            btn_ThongKeTheoNgay.TabIndex = 6;
            btn_ThongKeTheoNgay.Text = "Thống kê theo ngày";
            btn_ThongKeTheoNgay.UseVisualStyleBackColor = true;
            btn_ThongKeTheoNgay.Click += btn_ThongKeTheoNgay_Click;
            // 
            // cbo_BacSi
            // 
            cbo_BacSi.FormattingEnabled = true;
            cbo_BacSi.Location = new Point(88, 64);
            cbo_BacSi.Name = "cbo_BacSi";
            cbo_BacSi.Size = new Size(151, 31);
            cbo_BacSi.TabIndex = 5;
            cbo_BacSi.SelectedIndexChanged += cbo_BacSi_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(20, 67);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 4;
            label3.Text = "Bác sĩ";
            // 
            // dtp_ToDate
            // 
            dtp_ToDate.CustomFormat = "dd/MM/yy";
            dtp_ToDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_ToDate.Format = DateTimePickerFormat.Custom;
            dtp_ToDate.Location = new Point(265, 26);
            dtp_ToDate.Name = "dtp_ToDate";
            dtp_ToDate.ShowUpDown = true;
            dtp_ToDate.Size = new Size(93, 27);
            dtp_ToDate.TabIndex = 3;
            dtp_ToDate.ValueChanged += dtp_ToDate_ValueChanged;
            // 
            // dtp_FromDate
            // 
            dtp_FromDate.CustomFormat = "dd/MM/yy";
            dtp_FromDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_FromDate.Format = DateTimePickerFormat.Custom;
            dtp_FromDate.Location = new Point(88, 26);
            dtp_FromDate.Name = "dtp_FromDate";
            dtp_FromDate.ShowUpDown = true;
            dtp_FromDate.Size = new Size(93, 27);
            dtp_FromDate.TabIndex = 2;
            dtp_FromDate.ValueChanged += dtp_FromDate_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(187, 31);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Đến ngày";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(20, 31);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Từ ngày";
            // 
            // FThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 653);
            Controls.Add(pnl_Content);
            Name = "FThongKe";
            Text = "Hospital Manage";
            pnl_Content.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_TKTongHop_ChuanDoan).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_TKTongHop_BacSi).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ThongKe).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Content;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_ThongKeTheoBacSi;
        private Button btn_ThongKeTheoThang;
        private Button btn_ThongKeTheoNgay;
        private ComboBox cbo_BacSi;
        private Label label3;
        private DateTimePicker dtp_ToDate;
        private DateTimePicker dtp_FromDate;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Button btn_ThongKeTongQuan;
        private TextBox txt_TongSoLuot;
        private Label label4;
        private GroupBox groupBox4;
        private DataGridView dgv_ThongKe;
        private Button btn_Dong;
        private Button btn_XuatBaoCao;
        private GroupBox groupBox6;
        private DataGridView dgv_TKTongHop_ChuanDoan;
        private GroupBox groupBox5;
        private DataGridView dgv_TKTongHop_BacSi;
    }
}