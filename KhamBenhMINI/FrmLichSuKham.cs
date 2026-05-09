using KhamBenhMINI.DAL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KhamBenhMINI
{
    public partial class FQLLichSuKham : Form
    {
        private DataGridView dgv;
        private TextBox txtTimKiem;
        private ComboBox cboLoc;
        private Button btnTim;
        private Button btnLamMoi;

        private readonly LuotKhamDAL dal = new LuotKhamDAL();

        public FQLLichSuKham()
        {
            InitializeUI();
            LoadData();
        }

        private void InitializeUI()
        {
            // FORM
            this.Text = "Lịch Sử Khám Bệnh";
            this.Size = new Size(1250, 720);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(240, 244, 250);
            this.Font = new Font("Segoe UI", 10F);

            // HEADER
            Panel pnlHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 85,
                BackColor = Color.FromArgb(25, 118, 210)
            };

            Label lblTitle = new Label
            {
                Text = "📋 LỊCH SỬ KHÁM BỆNH",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 24F, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter
            };

            pnlHeader.Controls.Add(lblTitle);

            // FILTER PANEL
            Panel pnlFilter = new Panel
            {
                Dock = DockStyle.Top,
                Height = 80,
                BackColor = Color.White,
                Padding = new Padding(20, 18, 20, 10)
            };

            FlowLayoutPanel flow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                WrapContents = false
            };

            Label lblTK = new Label
            {
                Text = "Tìm kiếm:",
                AutoSize = true,
                Margin = new Padding(0, 8, 5, 0)
            };

            txtTimKiem = new TextBox
            {
                Width = 250,
                Height = 35
            };

            cboLoc = new ComboBox
            {
                Width = 180,
                Height = 35,
                Margin = new Padding(15, 0, 0, 0),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            cboLoc.Items.AddRange(new string[]
            {
                "Tất cả",
                "Viêm họng cấp",
                "Viêm phế quản",
                "Viêm tai giữa",
                "Viêm dạ dày",
                "Cảm cúm"
            });

            cboLoc.SelectedIndex = 0;

            btnTim = new Button
            {
                Text = "🔍 Tìm kiếm",
                Width = 130,
                Height = 38,
                BackColor = Color.DodgerBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Margin = new Padding(20, 0, 0, 0)
            };

            btnTim.FlatAppearance.BorderSize = 0;
            btnTim.Click += BtnTim_Click;

            btnLamMoi = new Button
            {
                Text = "🔄 Làm mới",
                Width = 120,
                Height = 38,
                BackColor = Color.Gray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Margin = new Padding(10, 0, 0, 0)
            };

            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.Click += BtnLamMoi_Click;

            flow.Controls.Add(lblTK);
            flow.Controls.Add(txtTimKiem);
            flow.Controls.Add(cboLoc);
            flow.Controls.Add(btnTim);
            flow.Controls.Add(btnLamMoi);

            pnlFilter.Controls.Add(flow);

            // BODY
            Panel pnlBody = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20)
            };

            dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                ReadOnly = true,
                AllowUserToAddRows = false,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                EnableHeadersVisualStyles = false
            };

            dgv.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(33, 150, 243);

            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgv.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);

            dgv.ColumnHeadersHeight = 45;

            dgv.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(187, 222, 251);

            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv.DefaultCellStyle.Padding = new Padding(5);

            dgv.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 250, 252);

            dgv.RowTemplate.Height = 40;

            pnlBody.Controls.Add(dgv);

            // ADD FORM
            this.Controls.Add(pnlBody);
            this.Controls.Add(pnlFilter);
            this.Controls.Add(pnlHeader);
        }

        // LOAD DATA
        private void LoadData()
        {
            try
            {
                dgv.DataSource = dal.GetAll();

                if (dgv.Columns.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu!");
                    return;
                }

                // HEADER
                if (dgv.Columns.Contains("MaLuotKham"))
                {
                    dgv.Columns["MaLuotKham"].HeaderText = "Mã khám";
                    dgv.Columns["MaLuotKham"].FillWeight = 60;
                }

                if (dgv.Columns.Contains("TenBenhNhan"))
                {
                    dgv.Columns["TenBenhNhan"].HeaderText = "TenBenhNhan";
                    dgv.Columns["TenBenhNhan"].FillWeight = 130;
                }

                if (dgv.Columns.Contains("NgayKham"))
                {
                    dgv.Columns["NgayKham"].HeaderText = "Ngày khám";
                    dgv.Columns["NgayKham"].FillWeight = 90;

                    dgv.Columns["NgayKham"].DefaultCellStyle.Format =
                        "dd/MM/yyyy";
                }

                if (dgv.Columns.Contains("TrieuChung"))
                {
                    dgv.Columns["TrieuChung"].HeaderText = "Triệu chứng";
                    dgv.Columns["TrieuChung"].FillWeight = 180;
                }

                if (dgv.Columns.Contains("ChanDoan"))
                {
                    dgv.Columns["ChanDoan"].HeaderText = "Chẩn đoán";
                    dgv.Columns["ChanDoan"].FillWeight = 180;
                }

                if (dgv.Columns.Contains("HuongXuTri"))
                {
                    dgv.Columns["HuongXuTri"].HeaderText = "Hướng xử trí";
                    dgv.Columns["HuongXuTri"].FillWeight = 180;
                }

                if (dgv.Columns.Contains("GhiChu"))
                {
                    dgv.Columns["GhiChu"].HeaderText = "Ghi chú";
                    dgv.Columns["GhiChu"].FillWeight = 150;
                }

                if (dgv.Columns.Contains("TenBacSi"))
                {
                    dgv.Columns["TenBacSi"].HeaderText = "TenBacSi";
                    dgv.Columns["TenBacSi"].FillWeight = 120;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải dữ liệu!\n" + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // TÌM KIẾM
        private void BtnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string tuKhoa = txtTimKiem.Text.Trim().ToLower();

                DataTable dt = dal.GetAll();

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu!");
                    return;
                }

                DataTable ketQua = dt.Clone();

                foreach (DataRow row in dt.Rows)
                {
                    string tenBN = row["TenBenhNhan"] == DBNull.Value
                        ? ""
                        : row["TenBenhNhan"].ToString().ToLower();

                    string trieuChung = row["TrieuChung"] == DBNull.Value
                        ? ""
                        : row["TrieuChung"].ToString().ToLower();

                    string chanDoan = row["ChanDoan"] == DBNull.Value
                        ? ""
                        : row["ChanDoan"].ToString().ToLower();

                    bool matchTuKhoa =
                        tenBN.Contains(tuKhoa) ||
                        trieuChung.Contains(tuKhoa) ||
                        chanDoan.Contains(tuKhoa);

                    bool matchCombo = true;

                    // Lọc theo combobox
                    if (cboLoc.SelectedIndex > 0)
                    {
                        matchCombo =
                            chanDoan ==
                            cboLoc.Text.Trim().ToLower();
                    }

                    if (matchTuKhoa && matchCombo)
                    {
                        ketQua.ImportRow(row);
                    }
                }

                // Không nhập gì
                if (string.IsNullOrWhiteSpace(tuKhoa)
                    && cboLoc.SelectedIndex == 0)
                {
                    dgv.DataSource = dt;
                }
                else
                {
                    dgv.DataSource = ketQua;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tìm kiếm!\n" + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {

        }

        // LÀM MỚI
        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cboLoc.SelectedIndex = 0;

            LoadData();
        }
    }
}