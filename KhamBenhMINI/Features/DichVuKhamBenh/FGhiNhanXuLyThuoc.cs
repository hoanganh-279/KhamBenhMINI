using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KhamBenhMINI.Features.DichVuKhamBenh
{
    public class FGhiNhanXuLyThuoc : Form
    {
        private readonly KhamBenhServiceDAL _dal = new KhamBenhServiceDAL();
        private readonly DataGridView dgvLuotKham = new DataGridView();
        private readonly TextBox txtHuongXuLy = new TextBox();
        private readonly TextBox txtTimThuoc = new TextBox();
        private readonly ComboBox cboThuoc = new ComboBox();
        private readonly NumericUpDown numSoNgay = new NumericUpDown();
        private readonly NumericUpDown numSang = new NumericUpDown();
        private readonly NumericUpDown numTrua = new NumericUpDown();
        private readonly NumericUpDown numChieu = new NumericUpDown();
        private readonly NumericUpDown numToi = new NumericUpDown();
        private readonly NumericUpDown numSoLuong = new NumericUpDown();
        private readonly ComboBox cboDungBuaAn = new ComboBox();
        private readonly TextBox txtCachDungKhac = new TextBox();
        private readonly Button btnThem = new Button();
        private readonly Button btnThemThuocMoi = new Button();
        private readonly Button btnXoa = new Button();
        private readonly Button btnLuu = new Button();
        private readonly DataGridView dgvThuoc = new DataGridView();
        private readonly DataTable dtThuoc = new DataTable();
        private int _maLuotKham;

        public FGhiNhanXuLyThuoc()
        {
            InitializeUI();
            InitializeThuocTable();
            LoadMasterData();
            LoadLuotKham();
        }

        private void InitializeUI()
        {
            Text = "Ghi nhận xử lý / thuốc";
            BackColor = UiTheme.SoftBlue;
            KeyPreview = true;
            KeyDown += FGhiNhanXuLyThuoc_KeyDown;
            Padding = new Padding(10);
            AutoScaleMode = AutoScaleMode.Font;

            GroupBox gbList = UiTheme.CreateGroup("Chọn lượt khám", 260);
            dgvLuotKham.Dock = DockStyle.Fill;
            UiTheme.StyleGrid(dgvLuotKham);
            dgvLuotKham.CellClick += DgvLuotKham_CellClick;
            gbList.Controls.Add(dgvLuotKham);

            GroupBox gbInput = UiTheme.CreateGroup("Kê đơn thuốc và dặn dò", 100, DockStyle.Fill);
            TableLayoutPanel root = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4,
                Padding = new Padding(8)
            };
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 78));
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 64));
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 54));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            TableLayoutPanel pnlHuong = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1
            };
            pnlHuong.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140));
            pnlHuong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            Label lblHuong = new Label
            {
                Text = "Hướng xử lý",
                AutoSize = true,
                Anchor = AnchorStyles.Left,
                TextAlign = ContentAlignment.MiddleLeft
            };
            txtHuongXuLy.Multiline = true;
            txtHuongXuLy.Dock = DockStyle.Fill;
            txtHuongXuLy.Font = UiTheme.NormalFont;
            pnlHuong.Controls.Add(lblHuong, 0, 0);
            pnlHuong.Controls.Add(txtHuongXuLy, 1, 0);

            TableLayoutPanel pnlThuoc = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 10,
                RowCount = 2
            };
            pnlThuoc.RowStyles.Add(new RowStyle(SizeType.Absolute, 24));
            pnlThuoc.RowStyles.Add(new RowStyle(SizeType.Absolute, 36));
            pnlThuoc.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66));   // label tim
            pnlThuoc.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135));  // txt tim
            pnlThuoc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));   // cbo thuoc
            pnlThuoc.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 58));   // so ngay
            pnlThuoc.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 54));   // sang
            pnlThuoc.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 54));   // trua
            pnlThuoc.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60));   // chieu
            pnlThuoc.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 54));   // toi
            pnlThuoc.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 62));   // so luong
            pnlThuoc.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 0));

            Label lblTimThuoc = new Label { Text = "Tìm thuốc", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
            Label lblNgay = new Label { Text = "Ngày", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = new Font(UiTheme.NormalFont.FontFamily, 9F, FontStyle.Bold) };
            Label lblSang = new Label { Text = "Sáng", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = new Font(UiTheme.NormalFont.FontFamily, 9F, FontStyle.Bold) };
            Label lblTrua = new Label { Text = "Trưa", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = new Font(UiTheme.NormalFont.FontFamily, 9F, FontStyle.Bold) };
            Label lblChieu = new Label { Text = "Chiều", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = new Font(UiTheme.NormalFont.FontFamily, 9F, FontStyle.Bold) };
            Label lblToi = new Label { Text = "Tối", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = new Font(UiTheme.NormalFont.FontFamily, 9F, FontStyle.Bold) };
            Label lblSoLuong = new Label { Text = "SL", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = new Font(UiTheme.NormalFont.FontFamily, 9F, FontStyle.Bold) };
            txtTimThuoc.Dock = DockStyle.Fill;
            txtTimThuoc.Font = UiTheme.NormalFont;
            txtTimThuoc.MinimumSize = new Size(0, 30);
            txtTimThuoc.TextChanged += TxtTimThuoc_TextChanged;
            cboThuoc.Dock = DockStyle.Fill;
            cboThuoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboThuoc.Font = UiTheme.NormalFont;
            cboThuoc.MinimumSize = new Size(0, 30);

            numSoNgay.Dock = DockStyle.Fill; numSoNgay.Minimum = 1; numSoNgay.Maximum = 60; numSoNgay.Value = 1; numSoNgay.Font = UiTheme.NormalFont;
            numSang.Dock = DockStyle.Fill; numSang.Minimum = 0; numSang.Maximum = 10; numSang.Value = 1; numSang.Font = UiTheme.NormalFont;
            numTrua.Dock = DockStyle.Fill; numTrua.Minimum = 0; numTrua.Maximum = 10; numTrua.Font = UiTheme.NormalFont;
            numChieu.Dock = DockStyle.Fill; numChieu.Minimum = 0; numChieu.Maximum = 10; numChieu.Value = 1; numChieu.Font = UiTheme.NormalFont;
            numToi.Dock = DockStyle.Fill; numToi.Minimum = 0; numToi.Maximum = 10; numToi.Font = UiTheme.NormalFont;
            numSoNgay.MinimumSize = new Size(0, 30);
            numSang.MinimumSize = new Size(0, 30);
            numTrua.MinimumSize = new Size(0, 30);
            numChieu.MinimumSize = new Size(0, 30);
            numToi.MinimumSize = new Size(0, 30);

            numSoLuong.Dock = DockStyle.Fill; numSoLuong.Minimum = 1; numSoLuong.Maximum = 2000; numSoLuong.ReadOnly = true; numSoLuong.Font = UiTheme.NormalFont;
            numSoLuong.Value = 2;
            numSoLuong.MinimumSize = new Size(0, 30);
            pnlThuoc.Controls.Add(lblNgay, 3, 0);
            pnlThuoc.Controls.Add(lblSang, 4, 0);
            pnlThuoc.Controls.Add(lblTrua, 5, 0);
            pnlThuoc.Controls.Add(lblChieu, 6, 0);
            pnlThuoc.Controls.Add(lblToi, 7, 0);
            pnlThuoc.Controls.Add(lblSoLuong, 8, 0);

            pnlThuoc.Controls.Add(lblTimThuoc, 0, 1);
            pnlThuoc.Controls.Add(txtTimThuoc, 1, 1);
            pnlThuoc.Controls.Add(cboThuoc, 2, 1);
            pnlThuoc.Controls.Add(numSoNgay, 3, 1);
            pnlThuoc.Controls.Add(numSang, 4, 1);
            pnlThuoc.Controls.Add(numTrua, 5, 1);
            pnlThuoc.Controls.Add(numChieu, 6, 1);
            pnlThuoc.Controls.Add(numToi, 7, 1);
            pnlThuoc.Controls.Add(numSoLuong, 8, 1);

            TableLayoutPanel pnlActions = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 6,
                RowCount = 1
            };
            pnlActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
            pnlActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            pnlActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130));
            pnlActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130));
            pnlActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130));
            pnlActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140));

            cboDungBuaAn.Dock = DockStyle.Fill; cboDungBuaAn.DropDownStyle = ComboBoxStyle.DropDownList; cboDungBuaAn.Font = UiTheme.NormalFont;
            cboDungBuaAn.Items.AddRange(new object[] { "Trước ăn", "Sau ăn", "Trong ăn" });
            cboDungBuaAn.SelectedIndex = 1;
            cboDungBuaAn.MinimumSize = new Size(0, 32);
            txtCachDungKhac.Dock = DockStyle.Fill; txtCachDungKhac.Font = UiTheme.NormalFont;
            txtCachDungKhac.MinimumSize = new Size(0, 32);

            numSoNgay.ValueChanged += (_, __) => TinhSoLuong();
            numSang.ValueChanged += (_, __) => TinhSoLuong();
            numTrua.ValueChanged += (_, __) => TinhSoLuong();
            numChieu.ValueChanged += (_, __) => TinhSoLuong();
            numToi.ValueChanged += (_, __) => TinhSoLuong();

            btnThem.Text = "Thêm thuốc";
            btnThem.Dock = DockStyle.Fill;
            UiTheme.StyleButton(btnThem);
            btnThem.Click += BtnThem_Click;

            btnThemThuocMoi.Text = "Thêm mới";
            btnThemThuocMoi.Dock = DockStyle.Fill;
            UiTheme.StyleButton(btnThemThuocMoi, false);
            btnThemThuocMoi.Click += BtnThemThuocMoi_Click;

            btnXoa.Text = "Xóa dòng";
            btnXoa.Dock = DockStyle.Fill;
            UiTheme.StyleButton(btnXoa, false);
            btnXoa.Click += BtnXoa_Click;

            btnLuu.Text = "Lưu xử lý / thuốc";
            btnLuu.Dock = DockStyle.Fill;
            UiTheme.StyleButton(btnLuu);
            btnLuu.Click += BtnLuu_Click;

            pnlActions.Controls.Add(cboDungBuaAn, 0, 0);
            pnlActions.Controls.Add(txtCachDungKhac, 1, 0);
            pnlActions.Controls.Add(btnThemThuocMoi, 2, 0);
            pnlActions.Controls.Add(btnThem, 3, 0);
            pnlActions.Controls.Add(btnXoa, 4, 0);
            pnlActions.Controls.Add(btnLuu, 5, 0);

            dgvThuoc.Dock = DockStyle.Fill;
            UiTheme.StyleGrid(dgvThuoc);

            root.Controls.Add(pnlHuong, 0, 0);
            root.Controls.Add(pnlThuoc, 0, 1);
            root.Controls.Add(pnlActions, 0, 2);
            root.Controls.Add(dgvThuoc, 0, 3);
            gbInput.Controls.Add(root);
            // Add DockStyle.Fill control first, then DockStyle.Top to avoid overlap.
            Controls.Add(gbInput);
            Controls.Add(gbList);
        }

        private void InitializeThuocTable()
        {
            dtThuoc.Columns.Add("MaThuoc", typeof(int));
            dtThuoc.Columns.Add("TenThuoc", typeof(string));
            dtThuoc.Columns.Add("SoLuong", typeof(int));
            dtThuoc.Columns.Add("CachDung", typeof(string));
            dtThuoc.Columns.Add("SoNgay", typeof(int));
            dtThuoc.Columns.Add("Sang", typeof(int));
            dtThuoc.Columns.Add("Trua", typeof(int));
            dtThuoc.Columns.Add("Chieu", typeof(int));
            dtThuoc.Columns.Add("Toi", typeof(int));
            dgvThuoc.DataSource = dtThuoc;
            if (dgvThuoc.Columns.Contains("MaThuoc")) dgvThuoc.Columns["MaThuoc"].Visible = false;
            if (dgvThuoc.Columns.Contains("TenThuoc")) dgvThuoc.Columns["TenThuoc"].HeaderText = "Thuốc";
            if (dgvThuoc.Columns.Contains("SoLuong")) dgvThuoc.Columns["SoLuong"].HeaderText = "Số lượng";
            if (dgvThuoc.Columns.Contains("CachDung")) dgvThuoc.Columns["CachDung"].HeaderText = "Cách dùng";
            if (dgvThuoc.Columns.Contains("SoNgay")) dgvThuoc.Columns["SoNgay"].HeaderText = "Ngày";
            if (dgvThuoc.Columns.Contains("Sang")) dgvThuoc.Columns["Sang"].HeaderText = "Sáng";
            if (dgvThuoc.Columns.Contains("Trua")) dgvThuoc.Columns["Trua"].HeaderText = "Trưa";
            if (dgvThuoc.Columns.Contains("Chieu")) dgvThuoc.Columns["Chieu"].HeaderText = "Chiều";
            if (dgvThuoc.Columns.Contains("Toi")) dgvThuoc.Columns["Toi"].HeaderText = "Tối";
        }

        private void LoadMasterData()
        {
            cboThuoc.DataSource = _dal.GetThuocList();
            cboThuoc.DisplayMember = "TenThuoc";
            cboThuoc.ValueMember = "MaThuoc";
        }

        private void LoadLuotKham()
        {
            dgvLuotKham.DataSource = _dal.GetDanhSachLuotKham();
            if (dgvLuotKham.Columns.Contains("MaLuotKham")) dgvLuotKham.Columns["MaLuotKham"].HeaderText = "Mã lượt";
            if (dgvLuotKham.Columns.Contains("TenBenhNhan")) dgvLuotKham.Columns["TenBenhNhan"].HeaderText = "Bệnh nhân";
            if (dgvLuotKham.Columns.Contains("TenBacSi")) dgvLuotKham.Columns["TenBacSi"].HeaderText = "Bác sĩ";
            if (dgvLuotKham.Columns.Contains("NgayKham")) dgvLuotKham.Columns["NgayKham"].HeaderText = "Ngày khám";
        }

        private void DgvLuotKham_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            object? value = dgvLuotKham.Rows[e.RowIndex].Cells["MaLuotKham"].Value;
            if (value == null) return;

            _maLuotKham = Convert.ToInt32(value);
            DataTable dtInfo = _dal.GetThongTinLuotKham(_maLuotKham);
            txtHuongXuLy.Text = dtInfo.Rows.Count > 0 && dtInfo.Rows[0]["HuongXuLy"] != DBNull.Value
                ? dtInfo.Rows[0]["HuongXuLy"].ToString()
                : string.Empty;

            DataTable dtDonThuoc = _dal.GetDonThuocByLuotKham(_maLuotKham);
            dtThuoc.Rows.Clear();
            foreach (DataRow row in dtDonThuoc.Rows)
            {
                dtThuoc.Rows.Add(
                    Convert.ToInt32(row["MaThuoc"]),
                    row["TenThuoc"].ToString(),
                    Convert.ToInt32(row["SoLuong"]),
                    row["CachDung"] == DBNull.Value ? string.Empty : row["CachDung"].ToString(),
                    1, 1, 0, 1, 0);
            }
        }

        private void BtnThem_Click(object? sender, EventArgs e)
        {
            if (cboThuoc.SelectedValue == null) return;

            int maThuoc = Convert.ToInt32(cboThuoc.SelectedValue);
            foreach (DataRow row in dtThuoc.Rows)
            {
                if (Convert.ToInt32(row["MaThuoc"]) == maThuoc)
                {
                    row["SoLuong"] = Convert.ToInt32(row["SoLuong"]) + Convert.ToInt32(numSoLuong.Value);
                    row["CachDung"] = BuildCachDung();
                    row["SoNgay"] = Convert.ToInt32(numSoNgay.Value);
                    row["Sang"] = Convert.ToInt32(numSang.Value);
                    row["Trua"] = Convert.ToInt32(numTrua.Value);
                    row["Chieu"] = Convert.ToInt32(numChieu.Value);
                    row["Toi"] = Convert.ToInt32(numToi.Value);
                    ResetLieuDungInputs();
                    return;
                }
            }

            dtThuoc.Rows.Add(
                maThuoc,
                cboThuoc.Text,
                Convert.ToInt32(numSoLuong.Value),
                BuildCachDung(),
                Convert.ToInt32(numSoNgay.Value),
                Convert.ToInt32(numSang.Value),
                Convert.ToInt32(numTrua.Value),
                Convert.ToInt32(numChieu.Value),
                Convert.ToInt32(numToi.Value));

            ResetLieuDungInputs();
        }

        private void BtnXoa_Click(object? sender, EventArgs e)
        {
            if (dgvThuoc.CurrentRow == null || dgvThuoc.CurrentRow.Index < 0) return;
            dtThuoc.Rows.RemoveAt(dgvThuoc.CurrentRow.Index);
        }

        private void BtnLuu_Click(object? sender, EventArgs e)
        {
            if (_maLuotKham <= 0)
            {
                MessageBox.Show("Vui lòng chọn lượt khám.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHuongXuLy.Text) && dtThuoc.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập hướng xử lý hoặc thêm ít nhất 1 thuốc.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _dal.LuuXuLyThuoc(_maLuotKham, txtHuongXuLy.Text, dtThuoc);
            MessageBox.Show("Đã lưu xử lý / thuốc.", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnThemThuocMoi_Click(object? sender, EventArgs e)
        {
            using Form frm = new Form();
            frm.Text = "Thêm thuốc mới";
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.FormBorderStyle = FormBorderStyle.FixedDialog;
            frm.MinimizeBox = false;
            frm.MaximizeBox = false;
            frm.ClientSize = new Size(380, 190);

            Label lblTen = new Label { Text = "Tên thuốc", Left = 20, Top = 20, Width = 80 };
            TextBox txtTen = new TextBox { Left = 105, Top = 17, Width = 250, Font = UiTheme.NormalFont };
            Label lblDonVi = new Label { Text = "Đơn vị", Left = 20, Top = 56, Width = 80 };
            TextBox txtDonVi = new TextBox { Left = 105, Top = 53, Width = 140, Text = "Viên", Font = UiTheme.NormalFont };
            Label lblGhiChu = new Label { Text = "Ghi chú", Left = 20, Top = 92, Width = 80 };
            TextBox txtGhiChu = new TextBox { Left = 105, Top = 89, Width = 250, Font = UiTheme.NormalFont };

            Button btnOk = new Button { Text = "Thêm", Left = 190, Top = 132, Width = 80, DialogResult = DialogResult.OK };
            Button btnCancel = new Button { Text = "Hủy", Left = 275, Top = 132, Width = 80, DialogResult = DialogResult.Cancel };
            frm.AcceptButton = btnOk;
            frm.CancelButton = btnCancel;

            frm.Controls.AddRange(new Control[] { lblTen, txtTen, lblDonVi, txtDonVi, lblGhiChu, txtGhiChu, btnOk, btnCancel });

            if (frm.ShowDialog(this) != DialogResult.OK) return;
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Tên thuốc không được để trống.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int maThuoc = _dal.ThemThuoc(txtTen.Text, txtDonVi.Text, txtGhiChu.Text);
                LoadMasterData();
                cboThuoc.SelectedValue = maThuoc;
                txtTimThuoc.Clear();
                MessageBox.Show("Đã thêm thuốc vào danh mục.", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể thêm thuốc mới: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtTimThuoc_TextChanged(object? sender, EventArgs e)
        {
            if (cboThuoc.DataSource is not DataTable dt) return;
            string keyword = txtTimThuoc.Text.Trim().Replace("'", "''");
            dt.DefaultView.RowFilter = string.IsNullOrWhiteSpace(keyword) ? string.Empty : $"TenThuoc LIKE '%{keyword}%'";
        }

        private void TinhSoLuong()
        {
            int tongMoiNgay = Convert.ToInt32(numSang.Value + numTrua.Value + numChieu.Value + numToi.Value);
            if (tongMoiNgay <= 0) tongMoiNgay = 1;
            numSoLuong.Value = Math.Min(numSoLuong.Maximum, numSoNgay.Value * tongMoiNgay);
        }

        private string BuildCachDung()
        {
            string note = cboDungBuaAn.SelectedItem?.ToString() ?? "Sau ăn";
            string extra = string.IsNullOrWhiteSpace(txtCachDungKhac.Text) ? string.Empty : $" - {txtCachDungKhac.Text.Trim()}";
            return $"{note}; {numSang.Value}-{numTrua.Value}-{numChieu.Value}-{numToi.Value}/ngay x {numSoNgay.Value} ngay{extra}";
        }

        private void ResetLieuDungInputs()
        {
            txtCachDungKhac.Clear();
            numSoNgay.Value = 1;
            numSang.Value = 1;
            numTrua.Value = 0;
            numChieu.Value = 1;
            numToi.Value = 0;
            TinhSoLuong();
        }

        private void FGhiNhanXuLyThuoc_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                BtnThem_Click(this, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                BtnLuu_Click(this, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
        }
    }
}
