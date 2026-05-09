using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KhamBenhMINI.Features.DichVuKhamBenh
{
    public class FTaoLuotKham : Form
    {
        private readonly KhamBenhServiceDAL _dal = new KhamBenhServiceDAL();
        private readonly ComboBox cboBenhNhan = new ComboBox();
        private readonly ComboBox cboBacSi = new ComboBox();
        private readonly DateTimePicker dtpNgayKham = new DateTimePicker();
        private readonly TextBox txtLyDoKham = new TextBox();
        private readonly TextBox txtTimBenhNhan = new TextBox();
        private readonly Button btnTao = new Button();
        private readonly DataGridView dgvDanhSach = new DataGridView();

        public FTaoLuotKham()
        {
            InitializeUI();
            LoadMasterData();
            LoadDanhSach();
        }

        private void InitializeUI()
        {
            Text = "Tạo lượt khám";
            BackColor = UiTheme.SoftBlue;
            KeyPreview = true;
            KeyDown += FTaoLuotKham_KeyDown;
            Padding = new Padding(10);

            GroupBox gbInput = UiTheme.CreateGroup("Tạo lượt khám", 170);
            TableLayoutPanel tbl = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 6,
                RowCount = 2,
                Padding = new Padding(8)
            };
            tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90));
            tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
            tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70));
            tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90));
            tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45));
            tbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 52));
            tbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 52));

            Label lblTim = new Label { Text = "Tìm BN", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Font = UiTheme.NormalFont };
            Label lblBN = new Label { Text = "Bệnh nhân", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Font = UiTheme.NormalFont };
            Label lblBS = new Label { Text = "Bác sĩ", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Font = UiTheme.NormalFont };
            Label lblNgay = new Label { Text = "Ngày khám", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Font = UiTheme.NormalFont };
            Label lblLyDo = new Label { Text = "Lý do khám", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Font = UiTheme.NormalFont };

            txtTimBenhNhan.Dock = DockStyle.Fill;
            txtTimBenhNhan.Font = UiTheme.NormalFont;
            txtTimBenhNhan.PlaceholderText = "Nhập tên bệnh nhân...";
            txtTimBenhNhan.TextChanged += TxtTimBenhNhan_TextChanged;

            cboBenhNhan.Dock = DockStyle.Fill;
            cboBenhNhan.Font = UiTheme.NormalFont;
            cboBenhNhan.DropDownStyle = ComboBoxStyle.DropDownList;

            cboBacSi.Dock = DockStyle.Fill;
            cboBacSi.Font = UiTheme.NormalFont;
            cboBacSi.DropDownStyle = ComboBoxStyle.DropDownList;

            dtpNgayKham.Dock = DockStyle.Fill;
            dtpNgayKham.Font = UiTheme.NormalFont;
            dtpNgayKham.Format = DateTimePickerFormat.Custom;
            dtpNgayKham.CustomFormat = "dd/MM/yyyy HH:mm";

            txtLyDoKham.Dock = DockStyle.Fill;
            txtLyDoKham.Font = UiTheme.NormalFont;
            txtLyDoKham.PlaceholderText = "Lý do khám/triệu chứng ban đầu...";

            btnTao.Text = "Tạo lượt";
            btnTao.Width = 140;
            UiTheme.StyleButton(btnTao);
            btnTao.Click += BtnTao_Click;

            Panel actionPanel = new Panel { Dock = DockStyle.Right, Width = 160 };
            btnTao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTao.Location = new Point(10, 6);
            actionPanel.Controls.Add(btnTao);

            tbl.Controls.Add(lblTim, 0, 0);
            tbl.Controls.Add(txtTimBenhNhan, 1, 0);
            tbl.Controls.Add(lblBN, 2, 0);
            tbl.Controls.Add(cboBenhNhan, 3, 0);
            tbl.Controls.Add(lblBS, 4, 0);
            tbl.Controls.Add(cboBacSi, 5, 0);
            tbl.Controls.Add(lblLyDo, 0, 1);
            tbl.Controls.Add(txtLyDoKham, 1, 1);
            tbl.SetColumnSpan(txtLyDoKham, 3);
            tbl.Controls.Add(lblNgay, 4, 1);
            tbl.Controls.Add(dtpNgayKham, 5, 1);

            GroupBox gbList = UiTheme.CreateGroup("Danh sách lượt khám", 100, DockStyle.Fill);
            dgvDanhSach.Dock = DockStyle.Fill;
            UiTheme.StyleGrid(dgvDanhSach);
            gbList.Controls.Add(dgvDanhSach);
            Controls.Add(gbList);

            gbInput.Controls.Add(tbl);
            gbInput.Controls.Add(actionPanel);
            Controls.Add(gbInput);
        }

        private void LoadMasterData()
        {
            cboBenhNhan.DataSource = _dal.GetBenhNhanList();
            cboBenhNhan.DisplayMember = "HoTen";
            cboBenhNhan.ValueMember = "MaBenhNhan";

            cboBacSi.DataSource = _dal.GetBacSiList();
            cboBacSi.DisplayMember = "HoTen";
            cboBacSi.ValueMember = "MaBacSi";
        }

        private void LoadDanhSach()
        {
            dgvDanhSach.DataSource = _dal.GetDanhSachLuotKham();
            if (dgvDanhSach.Columns.Contains("MaLuotKham")) dgvDanhSach.Columns["MaLuotKham"].HeaderText = "Mã lượt";
            if (dgvDanhSach.Columns.Contains("TenBenhNhan")) dgvDanhSach.Columns["TenBenhNhan"].HeaderText = "Bệnh nhân";
            if (dgvDanhSach.Columns.Contains("TenBacSi")) dgvDanhSach.Columns["TenBacSi"].HeaderText = "Bác sĩ";
            if (dgvDanhSach.Columns.Contains("NgayKham")) dgvDanhSach.Columns["NgayKham"].HeaderText = "Ngày khám";
            if (dgvDanhSach.Columns.Contains("SoThuTu")) dgvDanhSach.Columns["SoThuTu"].HeaderText = "Số thứ tự";
            if (dgvDanhSach.Columns.Contains("LyDoKham")) dgvDanhSach.Columns["LyDoKham"].HeaderText = "Lý do khám";
        }

        private void BtnTao_Click(object? sender, EventArgs e)
        {
            if (cboBenhNhan.SelectedValue == null || cboBacSi.SelectedValue == null)
            {
                MessageBox.Show("Thiếu bệnh nhân hoặc bác sĩ.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _dal.TaoLuotKham(
                Convert.ToInt32(cboBenhNhan.SelectedValue),
                Convert.ToInt32(cboBacSi.SelectedValue),
                dtpNgayKham.Value,
                txtLyDoKham.Text);

            LoadDanhSach();
            txtLyDoKham.Clear();
            MessageBox.Show("Đã tạo lượt khám.", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TxtTimBenhNhan_TextChanged(object? sender, EventArgs e)
        {
            if (cboBenhNhan.DataSource is not DataTable dt) return;
            string keyword = txtTimBenhNhan.Text.Trim().Replace("'", "''");
            dt.DefaultView.RowFilter = string.IsNullOrWhiteSpace(keyword) ? string.Empty : $"HoTen LIKE '%{keyword}%'";
        }

        private void FTaoLuotKham_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                BtnTao_Click(this, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
        }
    }
}
