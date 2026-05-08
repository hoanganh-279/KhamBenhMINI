namespace KhamBenhMINI
{
    partial class FQLBenhNhan
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
            gbox_QLBenhNhan = new GroupBox();
            gbox_QLBenhNhan_DanhSach = new GroupBox();
            dgv_DanhSach = new DataGridView();
            gbox_QLBenhNhan_Function = new GroupBox();
            rbtn_Function_ThongKe_LoaiThuoc = new RadioButton();
            rbtn_Function_ThongKe_BenhNhan = new RadioButton();
            rbtn_Function_ThongKe_CanBenh = new RadioButton();
            btn_Function_LamMoi = new Button();
            btn_Function_ThongKe = new Button();
            btn_Function_Xóa = new Button();
            btn_Function_Sua = new Button();
            btn_Function_Them = new Button();
            gbox_QLBenhNhan_TTBenhNhan = new GroupBox();
            tbox_Location = new TextBox();
            tbox_SDT = new TextBox();
            dtp_NamSinh = new DateTimePicker();
            rbtn_GioiTinh_Nu = new RadioButton();
            rbtn_GioiTinh_Nam = new RadioButton();
            tbox_Name = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pnl_Content.SuspendLayout();
            gbox_QLBenhNhan.SuspendLayout();
            gbox_QLBenhNhan_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSach).BeginInit();
            gbox_QLBenhNhan_Function.SuspendLayout();
            gbox_QLBenhNhan_TTBenhNhan.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Content
            // 
            pnl_Content.Controls.Add(gbox_QLBenhNhan);
            pnl_Content.Dock = DockStyle.Fill;
            pnl_Content.Location = new Point(0, 0);
            pnl_Content.Margin = new Padding(4);
            pnl_Content.Name = "pnl_Content";
            pnl_Content.Size = new Size(1102, 816);
            pnl_Content.TabIndex = 3;
            // 
            // gbox_QLBenhNhan
            // 
            gbox_QLBenhNhan.Controls.Add(gbox_QLBenhNhan_DanhSach);
            gbox_QLBenhNhan.Controls.Add(gbox_QLBenhNhan_Function);
            gbox_QLBenhNhan.Controls.Add(gbox_QLBenhNhan_TTBenhNhan);
            gbox_QLBenhNhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbox_QLBenhNhan.ForeColor = Color.Blue;
            gbox_QLBenhNhan.Location = new Point(8, 4);
            gbox_QLBenhNhan.Margin = new Padding(4);
            gbox_QLBenhNhan.Name = "gbox_QLBenhNhan";
            gbox_QLBenhNhan.Padding = new Padding(4);
            gbox_QLBenhNhan.Size = new Size(729, 809);
            gbox_QLBenhNhan.TabIndex = 0;
            gbox_QLBenhNhan.TabStop = false;
            gbox_QLBenhNhan.Text = "QUẢN LÝ BỆNH NHÂN";
            gbox_QLBenhNhan.Enter += gbox_QLBenhNhan_Enter;
            // 
            // gbox_QLBenhNhan_DanhSach
            // 
            gbox_QLBenhNhan_DanhSach.Controls.Add(dgv_DanhSach);
            gbox_QLBenhNhan_DanhSach.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbox_QLBenhNhan_DanhSach.ForeColor = SystemColors.ActiveCaptionText;
            gbox_QLBenhNhan_DanhSach.Location = new Point(19, 442);
            gbox_QLBenhNhan_DanhSach.Margin = new Padding(4);
            gbox_QLBenhNhan_DanhSach.Name = "gbox_QLBenhNhan_DanhSach";
            gbox_QLBenhNhan_DanhSach.Padding = new Padding(4);
            gbox_QLBenhNhan_DanhSach.Size = new Size(702, 355);
            gbox_QLBenhNhan_DanhSach.TabIndex = 2;
            gbox_QLBenhNhan_DanhSach.TabStop = false;
            gbox_QLBenhNhan_DanhSach.Text = "Danh sách";
            // 
            // dgv_DanhSach
            // 
            dgv_DanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DanhSach.Location = new Point(8, 36);
            dgv_DanhSach.Margin = new Padding(4);
            dgv_DanhSach.Name = "dgv_DanhSach";
            dgv_DanhSach.RowHeadersWidth = 51;
            dgv_DanhSach.Size = new Size(694, 334);
            dgv_DanhSach.TabIndex = 0;
            // 
            // gbox_QLBenhNhan_Function
            // 
            gbox_QLBenhNhan_Function.Controls.Add(rbtn_Function_ThongKe_LoaiThuoc);
            gbox_QLBenhNhan_Function.Controls.Add(rbtn_Function_ThongKe_BenhNhan);
            gbox_QLBenhNhan_Function.Controls.Add(rbtn_Function_ThongKe_CanBenh);
            gbox_QLBenhNhan_Function.Controls.Add(btn_Function_LamMoi);
            gbox_QLBenhNhan_Function.Controls.Add(btn_Function_ThongKe);
            gbox_QLBenhNhan_Function.Controls.Add(btn_Function_Xóa);
            gbox_QLBenhNhan_Function.Controls.Add(btn_Function_Sua);
            gbox_QLBenhNhan_Function.Controls.Add(btn_Function_Them);
            gbox_QLBenhNhan_Function.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbox_QLBenhNhan_Function.Location = new Point(19, 279);
            gbox_QLBenhNhan_Function.Margin = new Padding(4);
            gbox_QLBenhNhan_Function.Name = "gbox_QLBenhNhan_Function";
            gbox_QLBenhNhan_Function.Padding = new Padding(4);
            gbox_QLBenhNhan_Function.Size = new Size(702, 156);
            gbox_QLBenhNhan_Function.TabIndex = 1;
            gbox_QLBenhNhan_Function.TabStop = false;
            gbox_QLBenhNhan_Function.Text = "Chức năng";
            // 
            // rbtn_Function_ThongKe_LoaiThuoc
            // 
            rbtn_Function_ThongKe_LoaiThuoc.AutoSize = true;
            rbtn_Function_ThongKe_LoaiThuoc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtn_Function_ThongKe_LoaiThuoc.ForeColor = SystemColors.ActiveCaptionText;
            rbtn_Function_ThongKe_LoaiThuoc.Location = new Point(366, 99);
            rbtn_Function_ThongKe_LoaiThuoc.Margin = new Padding(4);
            rbtn_Function_ThongKe_LoaiThuoc.Name = "rbtn_Function_ThongKe_LoaiThuoc";
            rbtn_Function_ThongKe_LoaiThuoc.Size = new Size(119, 29);
            rbtn_Function_ThongKe_LoaiThuoc.TabIndex = 7;
            rbtn_Function_ThongKe_LoaiThuoc.TabStop = true;
            rbtn_Function_ThongKe_LoaiThuoc.Text = "Loại thuốc";
            rbtn_Function_ThongKe_LoaiThuoc.UseVisualStyleBackColor = true;
            // 
            // rbtn_Function_ThongKe_BenhNhan
            // 
            rbtn_Function_ThongKe_BenhNhan.AutoSize = true;
            rbtn_Function_ThongKe_BenhNhan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtn_Function_ThongKe_BenhNhan.ForeColor = SystemColors.ActiveCaptionText;
            rbtn_Function_ThongKe_BenhNhan.Location = new Point(202, 99);
            rbtn_Function_ThongKe_BenhNhan.Margin = new Padding(4);
            rbtn_Function_ThongKe_BenhNhan.Name = "rbtn_Function_ThongKe_BenhNhan";
            rbtn_Function_ThongKe_BenhNhan.Size = new Size(120, 29);
            rbtn_Function_ThongKe_BenhNhan.TabIndex = 6;
            rbtn_Function_ThongKe_BenhNhan.TabStop = true;
            rbtn_Function_ThongKe_BenhNhan.Text = "Bệnh nhân";
            rbtn_Function_ThongKe_BenhNhan.UseVisualStyleBackColor = true;
            // 
            // rbtn_Function_ThongKe_CanBenh
            // 
            rbtn_Function_ThongKe_CanBenh.AutoSize = true;
            rbtn_Function_ThongKe_CanBenh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtn_Function_ThongKe_CanBenh.ForeColor = SystemColors.ActiveCaptionText;
            rbtn_Function_ThongKe_CanBenh.Location = new Point(39, 99);
            rbtn_Function_ThongKe_CanBenh.Margin = new Padding(4);
            rbtn_Function_ThongKe_CanBenh.Name = "rbtn_Function_ThongKe_CanBenh";
            rbtn_Function_ThongKe_CanBenh.Size = new Size(112, 29);
            rbtn_Function_ThongKe_CanBenh.TabIndex = 5;
            rbtn_Function_ThongKe_CanBenh.TabStop = true;
            rbtn_Function_ThongKe_CanBenh.Text = "Căn bệnh";
            rbtn_Function_ThongKe_CanBenh.UseVisualStyleBackColor = true;
            // 
            // btn_Function_LamMoi
            // 
            btn_Function_LamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Function_LamMoi.ForeColor = SystemColors.ActiveCaptionText;
            btn_Function_LamMoi.Location = new Point(559, 41);
            btn_Function_LamMoi.Margin = new Padding(4);
            btn_Function_LamMoi.Name = "btn_Function_LamMoi";
            btn_Function_LamMoi.Size = new Size(118, 36);
            btn_Function_LamMoi.TabIndex = 4;
            btn_Function_LamMoi.Text = "Làm mới";
            btn_Function_LamMoi.UseVisualStyleBackColor = true;
            btn_Function_LamMoi.Click += btn_Function_LamMoi_Click;
            // 
            // btn_Function_ThongKe
            // 
            btn_Function_ThongKe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Function_ThongKe.ForeColor = SystemColors.ActiveCaptionText;
            btn_Function_ThongKe.Location = new Point(422, 41);
            btn_Function_ThongKe.Margin = new Padding(4);
            btn_Function_ThongKe.Name = "btn_Function_ThongKe";
            btn_Function_ThongKe.Size = new Size(118, 36);
            btn_Function_ThongKe.TabIndex = 3;
            btn_Function_ThongKe.Text = "Thống kê";
            btn_Function_ThongKe.UseVisualStyleBackColor = true;
            // 
            // btn_Function_Xóa
            // 
            btn_Function_Xóa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Function_Xóa.ForeColor = SystemColors.ActiveCaptionText;
            btn_Function_Xóa.Location = new Point(285, 41);
            btn_Function_Xóa.Margin = new Padding(4);
            btn_Function_Xóa.Name = "btn_Function_Xóa";
            btn_Function_Xóa.Size = new Size(118, 36);
            btn_Function_Xóa.TabIndex = 2;
            btn_Function_Xóa.Text = "Xoá";
            btn_Function_Xóa.UseVisualStyleBackColor = true;
            btn_Function_Xóa.Click += btn_Function_Xóa_Click;
            // 
            // btn_Function_Sua
            // 
            btn_Function_Sua.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Function_Sua.ForeColor = SystemColors.ActiveCaptionText;
            btn_Function_Sua.Location = new Point(160, 41);
            btn_Function_Sua.Margin = new Padding(4);
            btn_Function_Sua.Name = "btn_Function_Sua";
            btn_Function_Sua.Size = new Size(118, 36);
            btn_Function_Sua.TabIndex = 1;
            btn_Function_Sua.Text = "Sửa";
            btn_Function_Sua.UseVisualStyleBackColor = true;
            btn_Function_Sua.Click += btn_Function_Sua_Click;
            // 
            // btn_Function_Them
            // 
            btn_Function_Them.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Function_Them.ForeColor = SystemColors.ActiveCaptionText;
            btn_Function_Them.Location = new Point(26, 41);
            btn_Function_Them.Margin = new Padding(4);
            btn_Function_Them.Name = "btn_Function_Them";
            btn_Function_Them.Size = new Size(118, 36);
            btn_Function_Them.TabIndex = 0;
            btn_Function_Them.Text = "Thêm";
            btn_Function_Them.UseVisualStyleBackColor = true;
            btn_Function_Them.Click += btn_Function_Them_Click;
            // 
            // gbox_QLBenhNhan_TTBenhNhan
            // 
            gbox_QLBenhNhan_TTBenhNhan.Controls.Add(tbox_Location);
            gbox_QLBenhNhan_TTBenhNhan.Controls.Add(tbox_SDT);
            gbox_QLBenhNhan_TTBenhNhan.Controls.Add(dtp_NamSinh);
            gbox_QLBenhNhan_TTBenhNhan.Controls.Add(rbtn_GioiTinh_Nu);
            gbox_QLBenhNhan_TTBenhNhan.Controls.Add(rbtn_GioiTinh_Nam);
            gbox_QLBenhNhan_TTBenhNhan.Controls.Add(tbox_Name);
            gbox_QLBenhNhan_TTBenhNhan.Controls.Add(label5);
            gbox_QLBenhNhan_TTBenhNhan.Controls.Add(label4);
            gbox_QLBenhNhan_TTBenhNhan.Controls.Add(label3);
            gbox_QLBenhNhan_TTBenhNhan.Controls.Add(label2);
            gbox_QLBenhNhan_TTBenhNhan.Controls.Add(label1);
            gbox_QLBenhNhan_TTBenhNhan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbox_QLBenhNhan_TTBenhNhan.Location = new Point(19, 41);
            gbox_QLBenhNhan_TTBenhNhan.Margin = new Padding(4);
            gbox_QLBenhNhan_TTBenhNhan.Name = "gbox_QLBenhNhan_TTBenhNhan";
            gbox_QLBenhNhan_TTBenhNhan.Padding = new Padding(4);
            gbox_QLBenhNhan_TTBenhNhan.Size = new Size(702, 230);
            gbox_QLBenhNhan_TTBenhNhan.TabIndex = 0;
            gbox_QLBenhNhan_TTBenhNhan.TabStop = false;
            gbox_QLBenhNhan_TTBenhNhan.Text = "Thông tin bệnh nhân";
            // 
            // tbox_Location
            // 
            tbox_Location.Location = new Point(130, 166);
            tbox_Location.Margin = new Padding(4);
            tbox_Location.Name = "tbox_Location";
            tbox_Location.Size = new Size(506, 35);
            tbox_Location.TabIndex = 11;
            // 
            // tbox_SDT
            // 
            tbox_SDT.Location = new Point(481, 102);
            tbox_SDT.Margin = new Padding(4);
            tbox_SDT.Name = "tbox_SDT";
            tbox_SDT.Size = new Size(155, 35);
            tbox_SDT.TabIndex = 10;
            // 
            // dtp_NamSinh
            // 
            dtp_NamSinh.CustomFormat = "dd/MM/yy";
            dtp_NamSinh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_NamSinh.Format = DateTimePickerFormat.Custom;
            dtp_NamSinh.Location = new Point(481, 36);
            dtp_NamSinh.Margin = new Padding(4);
            dtp_NamSinh.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dtp_NamSinh.Name = "dtp_NamSinh";
            dtp_NamSinh.ShowUpDown = true;
            dtp_NamSinh.Size = new Size(155, 31);
            dtp_NamSinh.TabIndex = 9;
            // 
            // rbtn_GioiTinh_Nu
            // 
            rbtn_GioiTinh_Nu.AutoSize = true;
            rbtn_GioiTinh_Nu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtn_GioiTinh_Nu.ForeColor = SystemColors.ActiveCaptionText;
            rbtn_GioiTinh_Nu.Location = new Point(215, 106);
            rbtn_GioiTinh_Nu.Margin = new Padding(4);
            rbtn_GioiTinh_Nu.Name = "rbtn_GioiTinh_Nu";
            rbtn_GioiTinh_Nu.Size = new Size(61, 29);
            rbtn_GioiTinh_Nu.TabIndex = 8;
            rbtn_GioiTinh_Nu.TabStop = true;
            rbtn_GioiTinh_Nu.Text = "Nữ";
            rbtn_GioiTinh_Nu.UseVisualStyleBackColor = true;
            // 
            // rbtn_GioiTinh_Nam
            // 
            rbtn_GioiTinh_Nam.AutoSize = true;
            rbtn_GioiTinh_Nam.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtn_GioiTinh_Nam.ForeColor = SystemColors.ActiveCaptionText;
            rbtn_GioiTinh_Nam.Location = new Point(130, 106);
            rbtn_GioiTinh_Nam.Margin = new Padding(4);
            rbtn_GioiTinh_Nam.Name = "rbtn_GioiTinh_Nam";
            rbtn_GioiTinh_Nam.Size = new Size(75, 29);
            rbtn_GioiTinh_Nam.TabIndex = 7;
            rbtn_GioiTinh_Nam.TabStop = true;
            rbtn_GioiTinh_Nam.Text = "Nam";
            rbtn_GioiTinh_Nam.UseVisualStyleBackColor = true;
            // 
            // tbox_Name
            // 
            tbox_Name.Location = new Point(130, 40);
            tbox_Name.Margin = new Padding(4);
            tbox_Name.Name = "tbox_Name";
            tbox_Name.Size = new Size(155, 35);
            tbox_Name.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(349, 109);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 4;
            label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(349, 44);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 3;
            label4.Text = "Năm sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(22, 172);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(22, 109);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 1;
            label2.Text = "Giới tính:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(22, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên:";
            label1.Click += label1_Click;
            // 
            // FQLBenhNhan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 816);
            Controls.Add(pnl_Content);
            Margin = new Padding(4);
            Name = "FQLBenhNhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Manage";
            pnl_Content.ResumeLayout(false);
            gbox_QLBenhNhan.ResumeLayout(false);
            gbox_QLBenhNhan_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSach).EndInit();
            gbox_QLBenhNhan_Function.ResumeLayout(false);
            gbox_QLBenhNhan_Function.PerformLayout();
            gbox_QLBenhNhan_TTBenhNhan.ResumeLayout(false);
            gbox_QLBenhNhan_TTBenhNhan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Content;
        private GroupBox gbox_QLBenhNhan;
        private GroupBox gbox_QLBenhNhan_TTBenhNhan;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton rbtn_GioiTinh_Nam;
        private TextBox tbox_Name;
        private RadioButton rbtn_GioiTinh_Nu;
        private TextBox tbox_SDT;
        private DateTimePicker dtp_NamSinh;
        private GroupBox gbox_QLBenhNhan_Function;
        private RadioButton rbtn_Function_ThongKe_CanBenh;
        private Button btn_Function_LamMoi;
        private Button btn_Function_ThongKe;
        private Button btn_Function_Xóa;
        private Button btn_Function_Sua;
        private Button btn_Function_Them;
        private TextBox tbox_Location;
        private GroupBox gbox_QLBenhNhan_DanhSach;
        private DataGridView dgv_DanhSach;
        private RadioButton rbtn_Function_ThongKe_LoaiThuoc;
        private RadioButton rbtn_Function_ThongKe_BenhNhan;
    }
}