using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KhamBenhMINI.Features.DichVuKhamBenh
{
    public class FGhiNhanChuanDoan : Form
    {
        private readonly KhamBenhServiceDAL _dal = new KhamBenhServiceDAL();
        private readonly DataGridView dgvLuotKham = new DataGridView();
        private readonly TextBox txtSearchICD = new TextBox();
        private readonly ListBox lstGoiYICD = new ListBox();
        private readonly TextBox txtTenBenh = new TextBox();
        private readonly CheckBox chkBenhChinh = new CheckBox();
        private readonly TextBox txtGhiChu = new TextBox();
        private readonly Button btnThemChanDoan = new Button();
        private readonly Button btnXoaChanDoan = new Button();
        private readonly TextBox txtKetLuanTongQuat = new TextBox();
        private readonly Button btnLuu = new Button();
        private readonly DataGridView dgvChanDoan = new DataGridView();
        private readonly DataTable dtChanDoan = new DataTable();
        private int _maLuotKham;

        public FGhiNhanChuanDoan()
        {
            InitializeUI();
            LoadLuotKham();
        }

        private void InitializeUI()
        {
            Text = "Ghi nhận chuẩn đoán";
            BackColor = UiTheme.SoftBlue;
            KeyPreview = true;
            KeyDown += FGhiNhanChuanDoan_KeyDown;
            Padding = new Padding(10);

            GroupBox gbList = UiTheme.CreateGroup("Chọn lượt khám", 280);
            dgvLuotKham.Dock = DockStyle.Fill;
            UiTheme.StyleGrid(dgvLuotKham);
            dgvLuotKham.CellClick += DgvLuotKham_CellClick;
            gbList.Controls.Add(dgvLuotKham);

            GroupBox gbInput = UiTheme.CreateGroup("Chẩn đoán ICD-10", 100, DockStyle.Fill);
            TableLayoutPanel root = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4,
                Padding = new Padding(8)
            };
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 92));
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 52));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 92));

            TableLayoutPanel rowIcd = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 4 };
            rowIcd.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70));
            rowIcd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38));
            rowIcd.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70));
            rowIcd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62));
            rowIcd.RowStyles.Add(new RowStyle(SizeType.Absolute, 44));
            rowIcd.RowStyles.Add(new RowStyle(SizeType.Absolute, 44));

            Label lblSearch = new Label { Text = "ICD-10", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Font = UiTheme.NormalFont };
            Label lblBenh = new Label { Text = "Tên bệnh", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Font = UiTheme.NormalFont };

            txtSearchICD.Dock = DockStyle.Fill; txtSearchICD.Font = UiTheme.NormalFont;
            txtSearchICD.TextChanged += TxtSearchICD_TextChanged;
            lstGoiYICD.Dock = DockStyle.Fill; lstGoiYICD.Font = UiTheme.NormalFont;
            lstGoiYICD.DoubleClick += LstGoiYICD_DoubleClick;
            txtTenBenh.Dock = DockStyle.Fill; txtTenBenh.Font = UiTheme.NormalFont;
            chkBenhChinh.Font = UiTheme.NormalFont;
            chkBenhChinh.Text = "Bệnh chính";

            rowIcd.Controls.Add(lblSearch, 0, 0);
            rowIcd.Controls.Add(txtSearchICD, 1, 0);
            rowIcd.Controls.Add(lblBenh, 0, 1);
            rowIcd.Controls.Add(txtTenBenh, 1, 1);
            rowIcd.Controls.Add(lstGoiYICD, 3, 0);
            rowIcd.SetRowSpan(lstGoiYICD, 2);

            TableLayoutPanel rowNote = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 4 };
            rowNote.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70));
            rowNote.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            rowNote.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130));
            rowNote.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130));
            Label lblGhiChu = new Label { Text = "Ghi chú", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Font = UiTheme.NormalFont };
            txtGhiChu.Dock = DockStyle.Fill; txtGhiChu.Font = UiTheme.NormalFont;
            chkBenhChinh.Dock = DockStyle.Fill;

            btnThemChanDoan.Text = "Thêm CĐ";
            UiTheme.StyleButton(btnThemChanDoan);
            btnThemChanDoan.Click += BtnThemChanDoan_Click;

            btnXoaChanDoan.Text = "Xóa dòng";
            UiTheme.StyleButton(btnXoaChanDoan, false);
            btnXoaChanDoan.Click += BtnXoaChanDoan_Click;

            rowNote.Controls.Add(lblGhiChu, 0, 0);
            rowNote.Controls.Add(txtGhiChu, 1, 0);
            rowNote.Controls.Add(btnThemChanDoan, 2, 0);
            rowNote.Controls.Add(btnXoaChanDoan, 3, 0);

            dgvChanDoan.Dock = DockStyle.Fill;
            UiTheme.StyleGrid(dgvChanDoan);
            dgvChanDoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            TableLayoutPanel rowSummary = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 3 };
            rowSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80));
            rowSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            rowSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
            Label lblKetLuan = new Label { Text = "Kết luận", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Font = UiTheme.NormalFont };
            txtKetLuanTongQuat.Multiline = true;
            txtKetLuanTongQuat.Dock = DockStyle.Fill;
            txtKetLuanTongQuat.Font = UiTheme.NormalFont;
            btnLuu.Text = "Lưu chuẩn đoán";
            UiTheme.StyleButton(btnLuu);
            btnLuu.Click += BtnLuu_Click;

            rowSummary.Controls.Add(lblKetLuan, 0, 0);
            rowSummary.Controls.Add(txtKetLuanTongQuat, 1, 0);
            rowSummary.Controls.Add(btnLuu, 2, 0);

            root.Controls.Add(rowIcd, 0, 0);
            root.Controls.Add(rowNote, 0, 1);
            root.Controls.Add(dgvChanDoan, 0, 2);
            root.Controls.Add(rowSummary, 0, 3);
            gbInput.Controls.Add(root);

            Controls.Add(gbInput);
            Controls.Add(gbList);

            dtChanDoan.Columns.Add("MaICD10", typeof(string));
            dtChanDoan.Columns.Add("TenBenh", typeof(string));
            dtChanDoan.Columns.Add("LaBenhChinh", typeof(bool));
            dtChanDoan.Columns.Add("GhiChu", typeof(string));
            dgvChanDoan.DataSource = dtChanDoan;
        }

        private void LoadLuotKham()
        {
            dgvLuotKham.DataSource = _dal.GetDanhSachLuotKhamKemChuanDoan();
            dgvLuotKham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            if (dgvLuotKham.Columns.Contains("MaLuotKham")) dgvLuotKham.Columns["MaLuotKham"].HeaderText = "Mã lượt";
            if (dgvLuotKham.Columns.Contains("TenBenhNhan")) dgvLuotKham.Columns["TenBenhNhan"].HeaderText = "Bệnh nhân";
            if (dgvLuotKham.Columns.Contains("TenBacSi")) dgvLuotKham.Columns["TenBacSi"].HeaderText = "Bác sĩ";
            if (dgvLuotKham.Columns.Contains("NgayKham")) dgvLuotKham.Columns["NgayKham"].HeaderText = "Ngày khám";
            if (dgvLuotKham.Columns.Contains("ChanDoan")) dgvLuotKham.Columns["ChanDoan"].HeaderText = "Chuẩn đoán";
            if (dgvLuotKham.Columns.Contains("TrieuChung")) dgvLuotKham.Columns["TrieuChung"].HeaderText = "Triệu chứng";
            if (dgvLuotKham.Columns.Contains("HuyetAp")) dgvLuotKham.Columns["HuyetAp"].HeaderText = "Huyết áp";
            if (dgvLuotKham.Columns.Contains("NhipTim")) dgvLuotKham.Columns["NhipTim"].HeaderText = "Nhịp tim";
            if (dgvLuotKham.Columns.Contains("CanNang")) dgvLuotKham.Columns["CanNang"].HeaderText = "Cân nặng";
            if (dgvLuotKham.Columns.Contains("NhietDo")) dgvLuotKham.Columns["NhietDo"].HeaderText = "Nhiệt độ";

            if (dgvLuotKham.Columns.Contains("MaLuotKham")) dgvLuotKham.Columns["MaLuotKham"].Width = 80;
            if (dgvLuotKham.Columns.Contains("NgayKham")) dgvLuotKham.Columns["NgayKham"].Width = 130;
            if (dgvLuotKham.Columns.Contains("TenBenhNhan")) dgvLuotKham.Columns["TenBenhNhan"].Width = 150;
            if (dgvLuotKham.Columns.Contains("TenBacSi")) dgvLuotKham.Columns["TenBacSi"].Width = 140;
            if (dgvLuotKham.Columns.Contains("TrieuChung")) dgvLuotKham.Columns["TrieuChung"].Width = 180;
            if (dgvLuotKham.Columns.Contains("ChanDoan")) dgvLuotKham.Columns["ChanDoan"].Width = 180;
            if (dgvLuotKham.Columns.Contains("HuyetAp")) dgvLuotKham.Columns["HuyetAp"].Width = 90;
            if (dgvLuotKham.Columns.Contains("NhipTim")) dgvLuotKham.Columns["NhipTim"].Width = 80;
            if (dgvLuotKham.Columns.Contains("CanNang")) dgvLuotKham.Columns["CanNang"].Width = 80;
            if (dgvLuotKham.Columns.Contains("NhietDo")) dgvLuotKham.Columns["NhietDo"].Width = 80;
        }

        private void DgvLuotKham_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            object? value = dgvLuotKham.Rows[e.RowIndex].Cells["MaLuotKham"].Value;
            if (value == null) return;

            _maLuotKham = Convert.ToInt32(value);
            DataTable dt = _dal.GetThongTinLuotKham(_maLuotKham);
            // Chẩn đoán để bác sĩ chủ động nhập, không tự điền từ lý do khám.
            txtKetLuanTongQuat.Text = dt.Rows.Count > 0 && dt.Rows[0]["ChanDoan"] != DBNull.Value
                ? dt.Rows[0]["ChanDoan"].ToString()
                : string.Empty;

            dtChanDoan.Rows.Clear();
            DataTable dtList = _dal.GetChanDoanByLuotKham(_maLuotKham);
            foreach (DataRow row in dtList.Rows)
            {
                dtChanDoan.Rows.Add(
                    row["MaICD10"] == DBNull.Value ? string.Empty : row["MaICD10"].ToString(),
                    row["TenBenh"].ToString(),
                    Convert.ToBoolean(row["LaBenhChinh"]),
                    row["GhiChu"] == DBNull.Value ? string.Empty : row["GhiChu"].ToString());
            }
        }

        private void BtnLuu_Click(object? sender, EventArgs e)
        {
            if (_maLuotKham <= 0)
            {
                MessageBox.Show("Vui lòng chọn lượt khám.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _dal.LuuDanhSachChanDoan(_maLuotKham, dtChanDoan, txtKetLuanTongQuat.Text);
            MessageBox.Show("Đã lưu chuẩn đoán.", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TxtSearchICD_TextChanged(object? sender, EventArgs e)
        {
            string keyword = txtSearchICD.Text.Trim();
            lstGoiYICD.Items.Clear();
            if (keyword.Length < 2) return;

            DataTable dt = _dal.TimICD10(keyword);
            foreach (DataRow row in dt.Rows)
            {
                lstGoiYICD.Items.Add($"{row["MaICD10"]} - {row["TenBenh"]}");
            }
        }

        private void LstGoiYICD_DoubleClick(object? sender, EventArgs e)
        {
            if (lstGoiYICD.SelectedItem == null) return;
            string text = lstGoiYICD.SelectedItem.ToString() ?? string.Empty;
            string[] parts = text.Split(new[] { " - " }, 2, StringSplitOptions.None);
            txtSearchICD.Text = parts.Length > 0 ? parts[0] : string.Empty;
            txtTenBenh.Text = parts.Length > 1 ? parts[1] : string.Empty;
        }

        private void BtnThemChanDoan_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenBenh.Text))
            {
                MessageBox.Show("Cần nhập tên bệnh hoặc chọn ICD.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (chkBenhChinh.Checked)
            {
                foreach (DataRow row in dtChanDoan.Rows)
                {
                    row["LaBenhChinh"] = false;
                }
            }

            dtChanDoan.Rows.Add(txtSearchICD.Text.Trim(), txtTenBenh.Text.Trim(), chkBenhChinh.Checked, txtGhiChu.Text.Trim());
            txtSearchICD.Clear();
            txtTenBenh.Clear();
            txtGhiChu.Clear();
            chkBenhChinh.Checked = false;
            lstGoiYICD.Items.Clear();
        }

        private void BtnXoaChanDoan_Click(object? sender, EventArgs e)
        {
            if (dgvChanDoan.CurrentRow == null || dgvChanDoan.CurrentRow.Index < 0) return;
            dtChanDoan.Rows.RemoveAt(dgvChanDoan.CurrentRow.Index);
        }

        private void FGhiNhanChuanDoan_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                BtnLuu_Click(this, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
        }
    }
}
