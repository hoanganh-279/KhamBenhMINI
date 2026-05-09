using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KhamBenhMINI
{
    public partial class FrmTimKiemBenhNhan : Form
    {
        private readonly BenhNhanDAL dal = new BenhNhanDAL();
        public BenhNhan BenhNhanDuocChon { get; private set; } = null;

        public FrmTimKiemBenhNhan()
        {
            InitializeComponentCustom();
            LoadAll();
        }
        private void InitializeComponentCustom()
        {
            this.Text = "Tìm Kiếm Bệnh Nhân";
            this.Size = new Size(1200, 760);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(245, 245, 250);
            this.Font = new Font("Segoe UI", 10F);
            this.MinimumSize = new Size(1000, 600);

            // Tiêu đề
            Label lblTitle = new Label
            {
                Text = "TÌM KIẾM BỆNH NHÂN",
                Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 51, 102),
                Location = new Point(30, 15),
                AutoSize = true
            };

            // Panel Filter
            Panel pnlFilter = new Panel
            {
                Dock = DockStyle.Top,
                Height = 85,
                BackColor = Color.White,
                Padding = new Padding(25, 18, 25, 10)
            };

            FlowLayoutPanel flow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                AutoScroll = false
            };

            // Các control lọc
            Label lblTen = new Label { Text = "Họ tên:", AutoSize = true, Margin = new Padding(0, 6, 5, 0) };
            TextBox txtTen = new TextBox { Name = "txtTen", Width = 240, Height = 30 };

            Label lblSDT = new Label { Text = "SĐT:", AutoSize = true, Margin = new Padding(20, 6, 5, 0) };
            TextBox txtSDT = new TextBox { Name = "txtSDT", Width = 150, Height = 30 };

            Label lblGT = new Label { Text = "Giới tính:", AutoSize = true, Margin = new Padding(20, 6, 5, 0) };
            ComboBox cboGT = new ComboBox { Name = "cboGT", Width = 110, Height = 30 };
            cboGT.Items.AddRange(new[] { "Tất cả", "Nam", "Nữ" });
            cboGT.SelectedIndex = 0;

            Label lblNS = new Label { Text = "Năm sinh:", AutoSize = true, Margin = new Padding(20, 6, 5, 0) };
            NumericUpDown numNS = new NumericUpDown
            {
                Name = "numNS",
                Width = 90,
                Minimum = 1900,
                Maximum = DateTime.Now.Year + 1,
                Value = 1900
            };

            Button btnTim = new Button
            {
                Text = "🔍 Tìm kiếm",
                Width = 120,
                Height = 35,
                BackColor = Color.DodgerBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold)
            };
            btnTim.Click += BtnTim_Click;

            Button btnLamMoi = new Button
            {
                Text = "🔄 Làm mới",
                Width = 110,
                Height = 35,
                FlatStyle = FlatStyle.Flat
            };
            btnLamMoi.Click += BtnLamMoi_Click;

            flow.Controls.AddRange(new Control[] { lblTen, txtTen, lblSDT, txtSDT, lblGT, cboGT, lblNS, numNS, btnTim, btnLamMoi });
            pnlFilter.Controls.Add(flow);

            // DataGridView - Full màn hình
            DataGridView dgv = new DataGridView
            {
                Name = "dgvBenhNhan",
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                ReadOnly = true,
                AllowUserToAddRows = false,
                BackgroundColor = Color.White,
                RowHeadersVisible = false,
                BorderStyle = BorderStyle.None,
                AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.FromArgb(248, 250, 252) }
            };

            // Nút Chọn
            Button btnChon = new Button
            {
                Text = "✅ Chọn bệnh nhân",
                Dock = DockStyle.Bottom,
                Height = 60,
                BackColor = Color.ForestGreen,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };
            btnChon.Click += (s, e) => SelectPatient();
            // Thêm vào Form
            this.Controls.Add(dgv);
            this.Controls.Add(pnlFilter);
            this.Controls.Add(lblTitle);
            this.Controls.Add(btnChon);

            dgv.CellDoubleClick += (s, e) => SelectPatient();
        }

        private void LoadAll()
        {
            var dgv = (DataGridView)this.Controls["dgvBenhNhan"];
            dgv.DataSource = dal.GetAll();
            FormatGrid(dgv);
        }

        private void FormatGrid(DataGridView dgv)
        {
            if (dgv == null || dgv.Columns.Count == 0) return;

            // Đổi tên cột
            if (dgv.Columns.Contains("MaBenhNhan")) dgv.Columns["MaBenhNhan"].HeaderText = "Mã BN";
            if (dgv.Columns.Contains("HoTen")) dgv.Columns["HoTen"].HeaderText = "Họ và tên";
            if (dgv.Columns.Contains("GioiTinh")) dgv.Columns["GioiTinh"].HeaderText = "Giới tính";
            if (dgv.Columns.Contains("NamSinh")) dgv.Columns["NamSinh"].HeaderText = "Năm sinh";
            if (dgv.Columns.Contains("SoDienThoai")) dgv.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            if (dgv.Columns.Contains("DiaChi")) dgv.Columns["DiaChi"].HeaderText = "Địa chỉ";

            // Chỉnh độ rộng cột an toàn
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                switch (col.Name)
                {
                    case "MaBenhNhan":
                        col.FillWeight = 50;
                        break;

                    case "HoTen":
                        col.FillWeight = 180;
                        break;

                    case "GioiTinh":
                        col.FillWeight = 70;
                        break;

                    case "NamSinh":
                        col.FillWeight = 80;
                        break;

                    case "SoDienThoai":
                        col.FillWeight = 120;
                        break;

                    case "DiaChi":
                        col.FillWeight = 250;
                        break;
                }
            }
        }
            
            
                

        private void BtnTim_Click(object sender, EventArgs e)
        {
            var txtTen = (TextBox)this.Controls.Find("txtTen", true)[0];
            var txtSDT = (TextBox)this.Controls.Find("txtSDT", true)[0];
            var cboGT = (ComboBox)this.Controls.Find("cboGT", true)[0];
            var numNS = (NumericUpDown)this.Controls.Find("numNS", true)[0];

            string ten = txtTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string gt = cboGT.SelectedIndex == 0 ? "" : cboGT.Text;
            int namSinh = numNS.Value > 1900 ? (int)numNS.Value : 0;

            var dgv = (DataGridView)this.Controls["dgvBenhNhan"];
            dgv.DataSource = dal.SearchMulti(ten, sdt, gt, namSinh);
            FormatGrid(dgv);
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            var txtTen = (TextBox)this.Controls.Find("txtTen", true)[0];
            var txtSDT = (TextBox)this.Controls.Find("txtSDT", true)[0];
            var cboGT = (ComboBox)this.Controls.Find("cboGT", true)[0];
            var numNS = (NumericUpDown)this.Controls.Find("numNS", true)[0];

            txtTen.Clear();
            txtSDT.Clear();
            cboGT.SelectedIndex = 0;
            numNS.Value = 1900;

            LoadAll();
        }

        private void SelectPatient()
        {
            var dgv = (DataGridView)this.Controls["dgvBenhNhan"];
            if (dgv.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một bệnh nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int maBN = Convert.ToInt32(dgv.CurrentRow.Cells["MaBenhNhan"].Value);
            DataTable dt = dal.GetById(maBN);

            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                BenhNhanDuocChon = new BenhNhan
                {
                    MaBenhNhan = maBN,
                    HoTen = r["HoTen"].ToString(),
                    GioiTinh = r["GioiTinh"].ToString(),
                    NamSinh = Convert.ToInt32(r["NamSinh"]),
                    SoDienThoai = r["SoDienThoai"]?.ToString(),
                    DiaChi = r["DiaChi"]?.ToString()
                };


                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}