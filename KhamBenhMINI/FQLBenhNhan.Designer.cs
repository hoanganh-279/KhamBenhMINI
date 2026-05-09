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
            gbox_QLBenhNhan_DanhSach.Dock = DockStyle.Fill;
            gbox_QLBenhNhan_DanhSach.Font = UiTheme.HeaderFont;
            gbox_QLBenhNhan_DanhSach.ForeColor = UiTheme.PrimaryBlue;
            gbox_QLBenhNhan_DanhSach.BackColor = Color.White;
            gbox_QLBenhNhan_DanhSach.Margin = new Padding(0);
            gbox_QLBenhNhan_DanhSach.Name = "gbox_QLBenhNhan_DanhSach";
            gbox_QLBenhNhan_DanhSach.TabStop = false;
            gbox_QLBenhNhan_DanhSach.Text = "Danh sách";
            // 
            // dgv_DanhSach
            // 
            dgv_DanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DanhSach.Dock = DockStyle.Fill;
            dgv_DanhSach.Margin = new Padding(6);
            dgv_DanhSach.Name = "dgv_DanhSach";
            dgv_DanhSach.RowHeadersWidth = 51;
            dgv_DanhSach.TabIndex = 0;
            dgv_DanhSach.CellContentClick += dgv_DanhSach_CellContentClick;
            // 
            // FQLBenhNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = UiTheme.PageBackground;
            ClientSize = new Size(980, 720);
            Controls.Add(pnl_Content);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(820, 560);
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
