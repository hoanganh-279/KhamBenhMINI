using System.Drawing;
using System.Windows.Forms;
using KhamBenhMINI.Features.DichVuKhamBenh;

namespace KhamBenhMINI
{
    partial class FQLBenhNhan
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
            gbox_QLBenhNhan = new GroupBox();
            tblRoot = new TableLayoutPanel();
            gbox_QLBenhNhan_TTBenhNhan = new GroupBox();
            tblPatient = new TableLayoutPanel();
            pnlGender = new FlowLayoutPanel();
            gbox_QLBenhNhan_Function = new GroupBox();
            tblFunc = new TableLayoutPanel();
            pnlFuncButtons = new FlowLayoutPanel();
            gbox_QLBenhNhan_DanhSach = new GroupBox();
            dgv_DanhSach = new DataGridView();
            btn_Function_LamMoi = new Button();
            btn_Function_ThongKe = new Button();
            btn_Function_Xóa = new Button();
            btn_Function_Sua = new Button();
            btn_Function_Them = new Button();
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
            tblRoot.SuspendLayout();
            gbox_QLBenhNhan_TTBenhNhan.SuspendLayout();
            tblPatient.SuspendLayout();
            pnlGender.SuspendLayout();
            gbox_QLBenhNhan_Function.SuspendLayout();
            tblFunc.SuspendLayout();
            pnlFuncButtons.SuspendLayout();
            gbox_QLBenhNhan_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSach).BeginInit();
            SuspendLayout();
            // 
            // pnl_Content
            // 
            pnl_Content.BackColor = UiTheme.PageBackground;
            pnl_Content.Controls.Add(gbox_QLBenhNhan);
            pnl_Content.Dock = DockStyle.Fill;
<<<<<<< HEAD
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
=======
            pnl_Content.Padding = new Padding(20, 18, 20, 20);
            pnl_Content.Name = "pnl_Content";
            // 
            // gbox_QLBenhNhan
            // 
            gbox_QLBenhNhan.Controls.Add(tblRoot);
            gbox_QLBenhNhan.Dock = DockStyle.Fill;
            gbox_QLBenhNhan.Font = UiTheme.HeaderFont;
            gbox_QLBenhNhan.ForeColor = UiTheme.PrimaryBlue;
            gbox_QLBenhNhan.BackColor = Color.White;
            gbox_QLBenhNhan.Name = "gbox_QLBenhNhan";
>>>>>>> 629bd7c35dfca16a2af7e7a412b4307371b75b69
            gbox_QLBenhNhan.TabStop = false;
            gbox_QLBenhNhan.Text = "Quản lý bệnh nhân";
            gbox_QLBenhNhan.Enter += gbox_QLBenhNhan_Enter;
            // 
            // tblRoot
            // 
            tblRoot.ColumnCount = 1;
            tblRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRoot.Controls.Add(gbox_QLBenhNhan_TTBenhNhan, 0, 0);
            tblRoot.Controls.Add(gbox_QLBenhNhan_Function, 0, 1);
            tblRoot.Controls.Add(gbox_QLBenhNhan_DanhSach, 0, 2);
            tblRoot.Dock = DockStyle.Fill;
            tblRoot.RowCount = 3;
            tblRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 212F));
            tblRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tblRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblRoot.Padding = new Padding(4, 2, 4, 8);
            tblRoot.Name = "tblRoot";
            // 
            // gbox_QLBenhNhan_TTBenhNhan
            // 
            gbox_QLBenhNhan_TTBenhNhan.Controls.Add(tblPatient);
            gbox_QLBenhNhan_TTBenhNhan.Dock = DockStyle.Fill;
            gbox_QLBenhNhan_TTBenhNhan.Font = UiTheme.HeaderFont;
            gbox_QLBenhNhan_TTBenhNhan.ForeColor = UiTheme.PrimaryBlue;
            gbox_QLBenhNhan_TTBenhNhan.BackColor = Color.White;
            gbox_QLBenhNhan_TTBenhNhan.Margin = new Padding(0, 0, 0, 10);
            gbox_QLBenhNhan_TTBenhNhan.Name = "gbox_QLBenhNhan_TTBenhNhan";
            gbox_QLBenhNhan_TTBenhNhan.TabStop = false;
            gbox_QLBenhNhan_TTBenhNhan.Text = "Thông tin bệnh nhân";
            gbox_QLBenhNhan_TTBenhNhan.Enter += gbox_QLBenhNhan_TTBenhNhan_Enter;
            // 
            // tblPatient
            // 
            tblPatient.ColumnCount = 4;
            tblPatient.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tblPatient.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPatient.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tblPatient.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPatient.Controls.Add(label1, 0, 0);
            tblPatient.Controls.Add(tbox_Name, 1, 0);
            tblPatient.Controls.Add(label4, 2, 0);
            tblPatient.Controls.Add(dtp_NamSinh, 3, 0);
            tblPatient.Controls.Add(label2, 0, 1);
            tblPatient.Controls.Add(pnlGender, 1, 1);
            tblPatient.Controls.Add(label5, 2, 1);
            tblPatient.Controls.Add(tbox_SDT, 3, 1);
            tblPatient.Controls.Add(label3, 0, 2);
            tblPatient.Controls.Add(tbox_Location, 1, 2);
            tblPatient.Dock = DockStyle.Fill;
            tblPatient.Padding = new Padding(6, 6, 6, 4);
            tblPatient.RowCount = 3;
            tblPatient.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tblPatient.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tblPatient.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tblPatient.SetColumnSpan(tbox_Location, 3);
            tblPatient.Name = "tblPatient";
            // 
            // pnlGender
            // 
            pnlGender.AutoSize = true;
            pnlGender.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlGender.Controls.Add(rbtn_GioiTinh_Nam);
            pnlGender.Controls.Add(rbtn_GioiTinh_Nu);
            pnlGender.Dock = DockStyle.Fill;
            pnlGender.FlowDirection = FlowDirection.LeftToRight;
            pnlGender.Margin = new Padding(0);
            pnlGender.Padding = new Padding(0, 6, 0, 0);
            pnlGender.WrapContents = false;
            pnlGender.Name = "pnlGender";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = UiTheme.TextPrimary;
            label1.Text = "Họ và tên";
            label1.Name = "label1";
            // 
            // tbox_Name
            // 
            tbox_Name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbox_Name.Margin = new Padding(0, 4, 12, 4);
            tbox_Name.Name = "tbox_Name";
            tbox_Name.TabIndex = 0;
            tbox_Name.TextChanged += tbox_Name_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.ForeColor = UiTheme.TextPrimary;
            label4.Text = "Năm sinh";
            label4.Name = "label4";
            // 
            // dtp_NamSinh
            // 
            dtp_NamSinh.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtp_NamSinh.CustomFormat = "yyyy";
            dtp_NamSinh.Format = DateTimePickerFormat.Custom;
            dtp_NamSinh.Margin = new Padding(0, 4, 0, 4);
            dtp_NamSinh.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dtp_NamSinh.ShowUpDown = true;
            dtp_NamSinh.Name = "dtp_NamSinh";
            dtp_NamSinh.TabIndex = 1;
            dtp_NamSinh.ValueChanged += dtp_NamSinh_ValueChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = UiTheme.TextPrimary;
            label2.Text = "Giới tính";
            label2.Name = "label2";
            // 
            // rbtn_GioiTinh_Nam
            // 
            rbtn_GioiTinh_Nam.AutoSize = true;
            rbtn_GioiTinh_Nam.Margin = new Padding(0, 0, 16, 0);
            rbtn_GioiTinh_Nam.Name = "rbtn_GioiTinh_Nam";
            rbtn_GioiTinh_Nam.TabStop = true;
            rbtn_GioiTinh_Nam.Text = "Nam";
            rbtn_GioiTinh_Nam.UseVisualStyleBackColor = true;
            rbtn_GioiTinh_Nam.CheckedChanged += rbtn_GioiTinh_Nam_CheckedChanged;
            // 
            // rbtn_GioiTinh_Nu
            // 
            rbtn_GioiTinh_Nu.AutoSize = true;
            rbtn_GioiTinh_Nu.Name = "rbtn_GioiTinh_Nu";
            rbtn_GioiTinh_Nu.TabStop = true;
            rbtn_GioiTinh_Nu.Text = "Nữ";
            rbtn_GioiTinh_Nu.UseVisualStyleBackColor = true;
            rbtn_GioiTinh_Nu.CheckedChanged += rbtn_GioiTinh_Nu_CheckedChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.ForeColor = UiTheme.TextPrimary;
            label5.Text = "Số điện thoại";
            label5.Name = "label5";
            // 
            // tbox_SDT
            // 
            tbox_SDT.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbox_SDT.Margin = new Padding(0, 4, 0, 4);
            tbox_SDT.Name = "tbox_SDT";
            tbox_SDT.TabIndex = 2;
            tbox_SDT.TextChanged += tbox_SDT_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = UiTheme.TextPrimary;
            label3.Text = "Địa chỉ";
            label3.Name = "label3";
            // 
            // tbox_Location
            // 
            tbox_Location.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbox_Location.Margin = new Padding(0, 4, 0, 4);
            tbox_Location.Name = "tbox_Location";
            tbox_Location.TabIndex = 3;
            tbox_Location.TextChanged += tbox_Location_TextChanged;
            // 
            // gbox_QLBenhNhan_Function
            // 
            gbox_QLBenhNhan_Function.Controls.Add(tblFunc);
            gbox_QLBenhNhan_Function.Dock = DockStyle.Fill;
            gbox_QLBenhNhan_Function.Font = UiTheme.HeaderFont;
            gbox_QLBenhNhan_Function.ForeColor = UiTheme.PrimaryBlue;
            gbox_QLBenhNhan_Function.BackColor = Color.White;
            gbox_QLBenhNhan_Function.Margin = new Padding(0, 0, 0, 10);
            gbox_QLBenhNhan_Function.Name = "gbox_QLBenhNhan_Function";
            gbox_QLBenhNhan_Function.TabStop = false;
            gbox_QLBenhNhan_Function.Text = "Thao tác";
            gbox_QLBenhNhan_Function.Enter += gbox_QLBenhNhan_Function_Enter;
            // 
            // tblFunc
            // 
            tblFunc.ColumnCount = 1;
            tblFunc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblFunc.Controls.Add(pnlFuncButtons, 0, 0);
            tblFunc.Dock = DockStyle.Fill;
            tblFunc.RowCount = 1;
            tblFunc.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tblFunc.Padding = new Padding(4, 4, 4, 4);
            tblFunc.Name = "tblFunc";
            // 
            // pnlFuncButtons
            // 
            pnlFuncButtons.AutoSize = true;
            pnlFuncButtons.Dock = DockStyle.Fill;
            pnlFuncButtons.FlowDirection = FlowDirection.LeftToRight;
            pnlFuncButtons.WrapContents = false;
            pnlFuncButtons.Padding = new Padding(0, 4, 0, 0);
            pnlFuncButtons.Controls.Add(btn_Function_Them);
            pnlFuncButtons.Controls.Add(btn_Function_Sua);
            pnlFuncButtons.Controls.Add(btn_Function_Xóa);
            pnlFuncButtons.Controls.Add(btn_Function_ThongKe);
            pnlFuncButtons.Controls.Add(btn_Function_LamMoi);
            pnlFuncButtons.Name = "pnlFuncButtons";
            // 
            // btn_Function_Them
            // 
            btn_Function_Them.Margin = new Padding(0, 0, 10, 0);
            btn_Function_Them.Name = "btn_Function_Them";
            btn_Function_Them.Size = new Size(118, 38);
            btn_Function_Them.TabIndex = 0;
            btn_Function_Them.Text = "Thêm";
            btn_Function_Them.UseVisualStyleBackColor = false;
            btn_Function_Them.Click += btn_Function_Them_Click;
            // 
            // btn_Function_Sua
            // 
            btn_Function_Sua.Margin = new Padding(0, 0, 10, 0);
            btn_Function_Sua.Name = "btn_Function_Sua";
            btn_Function_Sua.Size = new Size(118, 38);
            btn_Function_Sua.TabIndex = 1;
            btn_Function_Sua.Text = "Sửa";
            btn_Function_Sua.UseVisualStyleBackColor = false;
            btn_Function_Sua.Click += btn_Function_Sua_Click;
            // 
            // btn_Function_Xóa
            // 
            btn_Function_Xóa.Margin = new Padding(0, 0, 10, 0);
            btn_Function_Xóa.Name = "btn_Function_Xóa";
            btn_Function_Xóa.Size = new Size(118, 38);
            btn_Function_Xóa.TabIndex = 2;
            btn_Function_Xóa.Text = "Xóa";
            btn_Function_Xóa.UseVisualStyleBackColor = false;
            btn_Function_Xóa.Click += btn_Function_Xóa_Click;
            // 
            // btn_Function_ThongKe
            // 
            btn_Function_ThongKe.Margin = new Padding(0, 0, 10, 0);
            btn_Function_ThongKe.Name = "btn_Function_ThongKe";
            btn_Function_ThongKe.Size = new Size(132, 38);
            btn_Function_ThongKe.TabIndex = 3;
            btn_Function_ThongKe.Text = "Thống kê";
            btn_Function_ThongKe.UseVisualStyleBackColor = false;
            btn_Function_ThongKe.Click += btn_Function_ThongKe_Click;
            // 
            // btn_Function_LamMoi
            // 
            btn_Function_LamMoi.Margin = new Padding(0, 0, 10, 0);
            btn_Function_LamMoi.Name = "btn_Function_LamMoi";
            btn_Function_LamMoi.Size = new Size(132, 38);
            btn_Function_LamMoi.TabIndex = 4;
            btn_Function_LamMoi.Text = "Làm mới";
            btn_Function_LamMoi.UseVisualStyleBackColor = false;
            btn_Function_LamMoi.Click += btn_Function_LamMoi_Click;
            // 
            // gbox_QLBenhNhan_DanhSach
            // 
            gbox_QLBenhNhan_DanhSach.Controls.Add(dgv_DanhSach);
<<<<<<< HEAD
            gbox_QLBenhNhan_DanhSach.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbox_QLBenhNhan_DanhSach.ForeColor = SystemColors.ActiveCaptionText;
            gbox_QLBenhNhan_DanhSach.Location = new Point(19, 442);
            gbox_QLBenhNhan_DanhSach.Margin = new Padding(4);
            gbox_QLBenhNhan_DanhSach.Name = "gbox_QLBenhNhan_DanhSach";
            gbox_QLBenhNhan_DanhSach.Padding = new Padding(4);
            gbox_QLBenhNhan_DanhSach.Size = new Size(702, 355);
            gbox_QLBenhNhan_DanhSach.TabIndex = 2;
=======
            gbox_QLBenhNhan_DanhSach.Dock = DockStyle.Fill;
            gbox_QLBenhNhan_DanhSach.Font = UiTheme.HeaderFont;
            gbox_QLBenhNhan_DanhSach.ForeColor = UiTheme.PrimaryBlue;
            gbox_QLBenhNhan_DanhSach.BackColor = Color.White;
            gbox_QLBenhNhan_DanhSach.Margin = new Padding(0);
            gbox_QLBenhNhan_DanhSach.Name = "gbox_QLBenhNhan_DanhSach";
>>>>>>> 629bd7c35dfca16a2af7e7a412b4307371b75b69
            gbox_QLBenhNhan_DanhSach.TabStop = false;
            gbox_QLBenhNhan_DanhSach.Text = "Danh sách";
            // 
            // dgv_DanhSach
            // 
            dgv_DanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            dgv_DanhSach.Location = new Point(8, 36);
            dgv_DanhSach.Margin = new Padding(4);
            dgv_DanhSach.Name = "dgv_DanhSach";
            dgv_DanhSach.RowHeadersWidth = 51;
            dgv_DanhSach.Size = new Size(694, 334);
=======
            dgv_DanhSach.Dock = DockStyle.Fill;
            dgv_DanhSach.Margin = new Padding(6);
            dgv_DanhSach.Name = "dgv_DanhSach";
            dgv_DanhSach.RowHeadersWidth = 51;
>>>>>>> 629bd7c35dfca16a2af7e7a412b4307371b75b69
            dgv_DanhSach.TabIndex = 0;
            // 
<<<<<<< HEAD
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
=======
>>>>>>> 629bd7c35dfca16a2af7e7a412b4307371b75b69
            // FQLBenhNhan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            ClientSize = new Size(1102, 816);
            Controls.Add(pnl_Content);
            Margin = new Padding(4);
=======
            BackColor = UiTheme.PageBackground;
            ClientSize = new Size(980, 720);
            Controls.Add(pnl_Content);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(820, 560);
>>>>>>> 629bd7c35dfca16a2af7e7a412b4307371b75b69
            Name = "FQLBenhNhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý bệnh nhân — Phòng khám MINI";
            pnl_Content.ResumeLayout(false);
            gbox_QLBenhNhan.ResumeLayout(false);
            tblRoot.ResumeLayout(false);
            gbox_QLBenhNhan_TTBenhNhan.ResumeLayout(false);
            tblPatient.ResumeLayout(false);
            tblPatient.PerformLayout();
            pnlGender.ResumeLayout(false);
            pnlGender.PerformLayout();
            gbox_QLBenhNhan_Function.ResumeLayout(false);
            tblFunc.ResumeLayout(false);
            tblFunc.PerformLayout();
            pnlFuncButtons.ResumeLayout(false);
            gbox_QLBenhNhan_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Content;
        private GroupBox gbox_QLBenhNhan;
        private TableLayoutPanel tblRoot;
        private GroupBox gbox_QLBenhNhan_TTBenhNhan;
        private TableLayoutPanel tblPatient;
        private FlowLayoutPanel pnlGender;
        private GroupBox gbox_QLBenhNhan_Function;
        private TableLayoutPanel tblFunc;
        private FlowLayoutPanel pnlFuncButtons;
        private GroupBox gbox_QLBenhNhan_DanhSach;
        private DataGridView dgv_DanhSach;
        private Button btn_Function_LamMoi;
        private Button btn_Function_ThongKe;
        private Button btn_Function_Xóa;
        private Button btn_Function_Sua;
        private Button btn_Function_Them;
        private TextBox tbox_Location;
        private TextBox tbox_SDT;
        private DateTimePicker dtp_NamSinh;
        private RadioButton rbtn_GioiTinh_Nu;
        private RadioButton rbtn_GioiTinh_Nam;
        private TextBox tbox_Name;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
