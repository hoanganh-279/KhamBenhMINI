using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KhamBenhMINI.Features.DichVuKhamBenh
{
    public class FGhiNhanTrieuChung : Form
    {
        private readonly KhamBenhServiceDAL _dal = new KhamBenhServiceDAL();
        private readonly DataGridView dgvLuotKham = new DataGridView();
        private readonly TextBox txtTrieuChung = new TextBox();
        private readonly TextBox txtHuyetAp = new TextBox();
        private readonly NumericUpDown numNhipTim = new NumericUpDown();
        private readonly NumericUpDown numCanNang = new NumericUpDown();
        private readonly NumericUpDown numNhietDo = new NumericUpDown();
        private readonly Button btnLuu = new Button();
        private int _maLuotKham;

        public FGhiNhanTrieuChung()
        {
            InitializeUI();
            LoadLuotKham();
        }

        private void InitializeUI()
        {
            Text = "Ghi nhận triệu chứng";
            BackColor = UiTheme.SoftBlue;
            KeyPreview = true;
            KeyDown += FGhiNhanTrieuChung_KeyDown;
            Padding = new Padding(10);

            GroupBox gbList = UiTheme.CreateGroup("Chọn lượt khám", 290);
            dgvLuotKham.Dock = DockStyle.Fill;
            UiTheme.StyleGrid(dgvLuotKham);
            dgvLuotKham.CellClick += DgvLuotKham_CellClick;
            gbList.Controls.Add(dgvLuotKham);

            GroupBox gbInput = UiTheme.CreateGroup("Khám lâm sàng", 100, DockStyle.Fill);
            TableLayoutPanel tbl = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 8,
                RowCount = 2,
                Padding = new Padding(8)
            };
            for (int i = 0; i < 8; i++) tbl.ColumnStyles.Add(new ColumnStyle(i % 2 == 0 ? SizeType.Absolute : SizeType.Percent, i % 2 == 0 ? 85 : 25));
            tbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 52));
            tbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            Label lblHuyetAp = new Label { Text = "Huyết áp", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Font = UiTheme.NormalFont };
            Label lblNhipTim = new Label { Text = "Nhịp tim", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Font = UiTheme.NormalFont };
            Label lblCanNang = new Label { Text = "Cân nặng", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Font = UiTheme.NormalFont };
            Label lblNhietDo = new Label { Text = "Nhiệt độ", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Font = UiTheme.NormalFont };

            txtHuyetAp.Dock = DockStyle.Fill;
            txtHuyetAp.Font = UiTheme.NormalFont;
            txtHuyetAp.PlaceholderText = "120/80";
            numNhipTim.Dock = DockStyle.Fill; numNhipTim.Font = UiTheme.NormalFont; numNhipTim.Minimum = 0; numNhipTim.Maximum = 300;
            numCanNang.Dock = DockStyle.Fill; numCanNang.Font = UiTheme.NormalFont; numCanNang.Minimum = 0; numCanNang.Maximum = 500; numCanNang.DecimalPlaces = 1;
            numNhietDo.Dock = DockStyle.Fill; numNhietDo.Font = UiTheme.NormalFont; numNhietDo.Minimum = 0; numNhietDo.Maximum = 50; numNhietDo.DecimalPlaces = 1; numNhietDo.Increment = 0.1M;

            txtTrieuChung.Multiline = true;
            txtTrieuChung.Dock = DockStyle.Fill;
            txtTrieuChung.Font = UiTheme.NormalFont;
            txtTrieuChung.ReadOnly = false;
            txtTrieuChung.Enabled = true;
            txtTrieuChung.PlaceholderText = "Bac si nhap trieu chung co nang tai day...";
            btnLuu.Text = "Lưu triệu chứng";
            btnLuu.Width = 170;
            UiTheme.StyleButton(btnLuu);
            btnLuu.Click += BtnLuu_Click;

            Panel rightPanel = new Panel { Dock = DockStyle.Right, Width = 200 };
            btnLuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLuu.Location = new Point(14, 14);
            rightPanel.Controls.Add(btnLuu);

            tbl.Controls.Add(lblHuyetAp, 0, 0);
            tbl.Controls.Add(txtHuyetAp, 1, 0);
            tbl.Controls.Add(lblNhipTim, 2, 0);
            tbl.Controls.Add(numNhipTim, 3, 0);
            tbl.Controls.Add(lblCanNang, 4, 0);
            tbl.Controls.Add(numCanNang, 5, 0);
            tbl.Controls.Add(lblNhietDo, 6, 0);
            tbl.Controls.Add(numNhietDo, 7, 0);
            tbl.Controls.Add(txtTrieuChung, 0, 1);
            tbl.SetColumnSpan(txtTrieuChung, 8);

            gbInput.Controls.Add(tbl);
            gbInput.Controls.Add(rightPanel);
            Controls.Add(gbInput);
            Controls.Add(gbList);
        }

        private void LoadLuotKham()
        {
            dgvLuotKham.DataSource = _dal.GetDanhSachLuotKhamKemTrieuChung();
            if (dgvLuotKham.Columns.Contains("MaLuotKham")) dgvLuotKham.Columns["MaLuotKham"].HeaderText = "Mã lượt";
            if (dgvLuotKham.Columns.Contains("TenBenhNhan")) dgvLuotKham.Columns["TenBenhNhan"].HeaderText = "Bệnh nhân";
            if (dgvLuotKham.Columns.Contains("TenBacSi")) dgvLuotKham.Columns["TenBacSi"].HeaderText = "Bác sĩ";
            if (dgvLuotKham.Columns.Contains("NgayKham")) dgvLuotKham.Columns["NgayKham"].HeaderText = "Ngày khám";
            if (dgvLuotKham.Columns.Contains("TrieuChung")) dgvLuotKham.Columns["TrieuChung"].HeaderText = "Triệu chứng";
        }

        private void DgvLuotKham_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            object? value = dgvLuotKham.Rows[e.RowIndex].Cells["MaLuotKham"].Value;
            if (value == null) return;

            _maLuotKham = Convert.ToInt32(value);
            DataTable dt = _dal.GetThongTinLuotKham(_maLuotKham);
            if (dt.Rows.Count > 0)
            {
                string trieuChung = dt.Rows[0]["TrieuChung"] == DBNull.Value ? string.Empty : dt.Rows[0]["TrieuChung"].ToString();
                string lyDoKham = dt.Rows[0]["LyDoKham"] == DBNull.Value ? string.Empty : dt.Rows[0]["LyDoKham"].ToString();

                // Nếu chưa có triệu chứng đã lưu thì lấy mặc định từ lý do khám ban đầu.
                txtTrieuChung.Text = string.IsNullOrWhiteSpace(trieuChung) ? lyDoKham : trieuChung;
            }
            else
            {
                txtTrieuChung.Text = string.Empty;
            }

            txtTrieuChung.Focus();
            txtTrieuChung.SelectionStart = txtTrieuChung.TextLength;

            txtHuyetAp.Text = dt.Rows.Count > 0 && dt.Rows[0]["HuyetAp"] != DBNull.Value ? dt.Rows[0]["HuyetAp"].ToString() : string.Empty;
            numNhipTim.Value = dt.Rows.Count > 0 && dt.Rows[0]["NhipTim"] != DBNull.Value ? Convert.ToDecimal(dt.Rows[0]["NhipTim"]) : 0;
            numCanNang.Value = dt.Rows.Count > 0 && dt.Rows[0]["CanNang"] != DBNull.Value ? Convert.ToDecimal(dt.Rows[0]["CanNang"]) : 0;
            numNhietDo.Value = dt.Rows.Count > 0 && dt.Rows[0]["NhietDo"] != DBNull.Value ? Convert.ToDecimal(dt.Rows[0]["NhietDo"]) : 0;
        }

        private void BtnLuu_Click(object? sender, EventArgs e)
        {
            if (_maLuotKham <= 0)
            {
                MessageBox.Show("Vui lòng chọn lượt khám.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _dal.LuuTrieuChung(
                _maLuotKham,
                txtTrieuChung.Text,
                txtHuyetAp.Text,
                numNhipTim.Value > 0 ? Convert.ToInt32(numNhipTim.Value) : null,
                numCanNang.Value > 0 ? numCanNang.Value : null,
                numNhietDo.Value > 0 ? numNhietDo.Value : null);
            MessageBox.Show("Đã lưu triệu chứng.", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FGhiNhanTrieuChung_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                BtnLuu_Click(this, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
        }
    }
}
