using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using KhamBenhMINI.Features.DichVuKhamBenh;

namespace KhamBenhMINI
{
    public partial class FHospitalManager : Form
    {
        private bool _sidebarExpanded = true;

        private const int SidebarExpandedWidth = 272;
        private const int SidebarCollapsedWidth = 56;
        private const int SubNavRowHeight = 34;
        private const int MainNavRowHeight = 44;

        private readonly ToolTip _toolTipSidebar = new ToolTip { ShowAlways = true };

        public FHospitalManager()
        {
            InitializeComponent();
            ApplySidebarTheme();
            SetSidebarExpanded(true);
            panel1.Resize += (_, _) => SyncSidebarMenuWidths();
            Load += (_, _) =>
            {
                SyncSidebarMenuWidths();
                ShowWelcomeHome();
            };
        }

        private void ShowWelcomeHome()
        {
            pnl_Content.Controls.Clear();
            pnl_Content.BackColor = UiTheme.PageBackground;
            pnl_Content.Padding = new Padding(0);

            var user = AppSession.CurrentUser;
            string title = user != null && !string.IsNullOrWhiteSpace(user.HoTen)
                ? $"Xin chào, {user.HoTen}"
                : "Chào mừng đến hệ thống";
            string role = user != null && !string.IsNullOrWhiteSpace(user.Quyen)
                ? user.Quyen
                : "Người dùng";

            var root = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 2,
                Padding = new Padding(28, 24, 28, 28),
                BackColor = UiTheme.PageBackground
            };
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 152f));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));

            var hero = new Panel { Dock = DockStyle.Fill };
            string line2 = role + " · Phòng khám điện tử MINI";
            const string line3 = "Chọn mục menu bên trái để mở tiếp nhận, khám bệnh hoặc báo cáo.";
            hero.Paint += (_, ev) =>
            {
                var g = ev.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                var r = hero.ClientRectangle;
                using var brush = new LinearGradientBrush(
                    r,
                    UiTheme.PrimaryBlue,
                    UiTheme.PrimaryDark,
                    LinearGradientMode.Vertical);
                g.FillRectangle(brush, r);
                float x = 26f;
                float y = 22f;
                using var titleFont = new Font("Segoe UI", 19f, FontStyle.Bold, GraphicsUnit.Point);
                using var metaFont = new Font("Segoe UI", 10.5f, FontStyle.Regular, GraphicsUnit.Point);
                using var hintFont = new Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Point);
                using var w = new SolidBrush(Color.White);
                using var soft = new SolidBrush(Color.FromArgb(225, 245, 255));
                using var hintBr = new SolidBrush(Color.FromArgb(200, 230, 255));
                g.DrawString(title, titleFont, w, x, y);
                y += titleFont.GetHeight(g) + 8f;
                g.DrawString(line2, metaFont, soft, x, y);
                y += metaFont.GetHeight(g) + 10f;
                g.DrawString(line3, hintFont, hintBr, x, y);
            };

            var flow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                AutoScroll = true,
                BackColor = UiTheme.PageBackground,
                Padding = new Padding(0, 4, 0, 0)
            };

            flow.Controls.AddRange(new Control[]
            {
                CreateWelcomeCard("Tiếp nhận", "Tìm BN, quản lý hồ sơ, tạo lượt khám mới.", "▣"),
                CreateWelcomeCard("Khám bệnh", "Triệu chứng, chẩn đoán ICD, kê đơn & thuốc.", "◆"),
                CreateWelcomeCard("Báo cáo", "Thống kê nhanh, lịch sử lượt khám.", "▤")
            });

            root.Controls.Add(hero, 0, 0);
            root.Controls.Add(flow, 0, 1);
            pnl_Content.Controls.Add(root);
        }

        private static Control CreateWelcomeCard(string heading, string body, string glyph)
        {
            var card = new ModernCardPanel
            {
                Margin = new Padding(0, 0, 18, 14),
                Padding = new Padding(16, 14, 16, 14),
                Width = 268,
                Height = 156,
                AutoSize = false
            };

            var lblG = new Label
            {
                Text = glyph,
                Font = new Font("Segoe UI", 20f, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = UiTheme.PrimaryBlue,
                AutoSize = true,
                Margin = new Padding(0, 0, 0, 4),
                BackColor = Color.Transparent
            };
            var lblH = new Label
            {
                Text = heading,
                Font = new Font("Segoe UI", 12.5f, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = Color.FromArgb(30, 41, 59),
                AutoSize = true,
                BackColor = Color.Transparent
            };
            var lblB = new Label
            {
                Text = body,
                Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = Color.FromArgb(100, 116, 139),
                MaximumSize = new Size(228, 0),
                AutoSize = true,
                Margin = new Padding(0, 4, 0, 0),
                BackColor = Color.Transparent
            };

            var col = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                AutoSize = true,
                Dock = DockStyle.Fill,
                WrapContents = false,
                BackColor = Color.White,
                Padding = new Padding(0)
            };
            col.Controls.Add(lblG);
            col.Controls.Add(lblH);
            col.Controls.Add(lblB);
            card.Controls.Add(col);
            return card;
        }

        /// <summary>
        /// FlowLayoutPanel không hỗ trợ Dock cho con; đồng bộ chiều ngang để tránh nút bị co thành vệt dọc.
        /// </summary>
        private void SyncSidebarMenuWidths()
        {
            if (!IsHandleCreated || FLPnl_MenuMain.IsDisposed)
                return;

            int pad = FLPnl_MenuMain.Padding.Horizontal;
            int avail = FLPnl_MenuMain.ClientSize.Width - pad;
            if (avail < 24)
                avail = 24;

            foreach (Control c in FLPnl_MenuMain.Controls)
            {
                int w = avail - c.Margin.Horizontal;
                if (w < 24)
                    w = 24;
                if (c.Width != w)
                    c.Width = w;

                if (c is Panel subPanel)
                {
                    foreach (Control inner in subPanel.Controls)
                    {
                        int iw = subPanel.ClientSize.Width;
                        if (inner.Width != iw)
                            inner.Width = iw;
                    }
                }
            }
        }

        private void FLPnl_MenuMain_SizeChanged(object sender, EventArgs e)
        {
            SyncSidebarMenuWidths();
        }

        private void ApplySidebarTheme()
        {
            Color hoverMain = Color.FromArgb(25, 118, 210);
            Color hoverSub = Color.FromArgb(236, 248, 255);

            pnlSidebarHeader.BackColor = UiTheme.PrimaryBlue;

            btnToggleSidebar.BackColor = UiTheme.PrimaryBlue;
            btnToggleSidebar.ForeColor = Color.White;
            btnToggleSidebar.FlatAppearance.BorderSize = 0;
            btnToggleSidebar.FlatAppearance.MouseOverBackColor = hoverMain;
            btnToggleSidebar.UseVisualStyleBackColor = false;

            void StyleMainNav(Button b)
            {
                b.BackColor = UiTheme.PrimaryBlue;
                b.ForeColor = Color.White;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.FlatAppearance.MouseOverBackColor = hoverMain;
                b.Cursor = Cursors.Hand;
                b.UseVisualStyleBackColor = false;
                b.Padding = new Padding(12, 0, 8, 0);
                b.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                b.Height = MainNavRowHeight;
            }

            StyleMainNav(btn_MenuTNvaQL);
            StyleMainNav(btn_MenuDVKhamBenh);
            StyleMainNav(btn_MenuBaoCao);

            void StyleSubNav(Button b)
            {
                b.BackColor = Color.White;
                b.ForeColor = Color.FromArgb(51, 65, 85);
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.FlatAppearance.MouseOverBackColor = hoverSub;
                b.Cursor = Cursors.Hand;
                b.UseVisualStyleBackColor = false;
                b.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                b.Height = SubNavRowHeight;
                b.Padding = new Padding(22, 0, 8, 0);
            }

            foreach (var b in new[]
                     {
                         btn_TimKiemBN, btn_QLBenhNhan, btn_TaoLuotKham, btn_GhiTrieuChung,
                         btn_GhiChuanDoan, btn_GhiDonThuoc, btn_LinhSuKB, btn_ThongKeKB
                     })
                StyleSubNav(b);

            void StyleSubPanel(Panel p)
            {
                p.BackColor = Color.White;
                p.Margin = new Padding(0, 0, 0, 6);
                p.Padding = new Padding(0);
            }

            StyleSubPanel(pnlSubTiepNhan);
            StyleSubPanel(pnlSubKhamBenh);
            StyleSubPanel(pnlSubBaoCao);

            pnl_Content.BackColor = UiTheme.PageBackground;

            SetSectionNavTooltipsExpanded();
        }

        private void SetSectionNavTooltipsExpanded()
        {
            _toolTipSidebar.SetToolTip(btn_MenuTNvaQL, "Tiếp nhận và quản lý bệnh nhân");
            _toolTipSidebar.SetToolTip(btn_MenuDVKhamBenh, "Lượt khám, triệu chứng, chẩn đoán, thuốc");
            _toolTipSidebar.SetToolTip(btn_MenuBaoCao, "Tra cứu và báo cáo thống kê");
        }

        private void SetSectionNavTooltipsCollapsed()
        {
            _toolTipSidebar.SetToolTip(btn_MenuTNvaQL, "Tiếp nhận và Quản lý bệnh nhân");
            _toolTipSidebar.SetToolTip(btn_MenuDVKhamBenh, "Dịch vụ khám bệnh");
            _toolTipSidebar.SetToolTip(btn_MenuBaoCao, "Tra cứu và Báo cáo");
        }

        private void SetSidebarExpanded(bool expanded)
        {
            _sidebarExpanded = expanded;
            panel1.Width = expanded ? SidebarExpandedWidth : SidebarCollapsedWidth;

            btnToggleSidebar.Text = expanded ? "☰  Thu gọn menu" : "☰";
            _toolTipSidebar.SetToolTip(btnToggleSidebar, expanded ? "Thu gọn thanh menu" : "Mở rộng menu");

            FLPnl_MenuMain.Padding = expanded
                ? new Padding(12, 10, 12, 16)
                : new Padding(6, 8, 6, 10);

            var mainMargin = expanded ? new Padding(0, 0, 0, 4) : new Padding(0, 4, 0, 4);

            btn_MenuTNvaQL.Margin = mainMargin;
            btn_MenuDVKhamBenh.Margin = mainMargin;
            btn_MenuBaoCao.Margin = mainMargin;

            btn_MenuTNvaQL.Height = expanded ? MainNavRowHeight : 40;
            btn_MenuDVKhamBenh.Height = expanded ? MainNavRowHeight : 40;
            btn_MenuBaoCao.Height = expanded ? MainNavRowHeight : 40;

            if (expanded)
            {
                btn_MenuTNvaQL.TextAlign = ContentAlignment.MiddleLeft;
                btn_MenuDVKhamBenh.TextAlign = ContentAlignment.MiddleLeft;
                btn_MenuBaoCao.TextAlign = ContentAlignment.MiddleLeft;

                SetSectionNavTooltipsExpanded();
                ExpandAllSubPanels();
            }
            else
            {
                CollapseAllSubPanels();
                btn_MenuTNvaQL.Text = "🏥";
                btn_MenuDVKhamBenh.Text = "🩺";
                btn_MenuBaoCao.Text = "📊";
                btn_MenuTNvaQL.TextAlign = ContentAlignment.MiddleCenter;
                btn_MenuDVKhamBenh.TextAlign = ContentAlignment.MiddleCenter;
                btn_MenuBaoCao.TextAlign = ContentAlignment.MiddleCenter;
                SetSectionNavTooltipsCollapsed();
            }

            SyncSidebarMenuWidths();
        }

        private static int SubPanelHeight(int rowCount) =>
            rowCount <= 0 ? 0 : rowCount * SubNavRowHeight;

        private void RefreshSubPanelHeights()
        {
            pnlSubTiepNhan.Height = SubPanelHeight(2);
            pnlSubKhamBenh.Height = SubPanelHeight(4);
            pnlSubBaoCao.Height = SubPanelHeight(2);
        }

        private void UpdateSectionHeaders()
        {
            if (!_sidebarExpanded)
                return;

            static string Chev(bool open) => open ? "  ▼" : "  ▶";

            btn_MenuTNvaQL.Text = "🏥  Tiếp nhận và Quản lý" + Chev(pnlSubTiepNhan.Visible);
            btn_MenuDVKhamBenh.Text = "🩺  Dịch vụ khám bệnh";
            btn_MenuBaoCao.Text = "📊  Tra cứu và Báo cáo";
        }

        private void btnToggleSidebar_Click(object sender, EventArgs e)
        {
            SetSidebarExpanded(!_sidebarExpanded);
        }

        private void CollapseAllSubPanels()
        {
            pnlSubTiepNhan.Visible = false;
            pnlSubKhamBenh.Visible = false;
            pnlSubBaoCao.Visible = false;
            UpdateSectionHeaders();
        }

        private void ExpandAllSubPanels()
        {
            pnlSubTiepNhan.Visible = true;
            pnlSubKhamBenh.Visible = true;
            pnlSubBaoCao.Visible = true;
            RefreshSubPanelHeights();
            UpdateSectionHeaders();
            FLPnl_MenuMain.PerformLayout();
            SyncSidebarMenuWidths();
        }

        private void ToggleSubPanel(Panel targetPanel)
        {
            targetPanel.Visible = !targetPanel.Visible;
            UpdateSectionHeaders();
            FLPnl_MenuMain.PerformLayout();
            SyncSidebarMenuWidths();
        }

        private void OpenChildForm(Form childForm)
        {
            foreach (Control ctrl in pnl_Content.Controls)
            {
                if (ctrl is Form oldForm)
                    oldForm.Close();
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnl_Content.Padding = new Padding(0);
            pnl_Content.Controls.Clear();
            pnl_Content.Controls.Add(childForm);
            childForm.Show();
        }

        private void btn_MenuTNvaQL_Click(object sender, EventArgs e)
        {
            if (!_sidebarExpanded)
                SetSidebarExpanded(true);
            ToggleSubPanel(pnlSubTiepNhan);
        }

        private void btn_QLBenhNhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FQLBenhNhan());
        }

        private void btn_TimKiemBN_Click(object sender, EventArgs e)
        {
            // TODO: Mở form Tìm kiếm bệnh nhân
        }

        private void btn_MenuDVKhamBenh_Click(object sender, EventArgs e)
        {
            if (!_sidebarExpanded)
                SetSidebarExpanded(true);
            ToggleSubPanel(pnlSubKhamBenh);
        }

        private void btn_TaoLuotKham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FTaoLuotKham());
        }

        private void btn_GhiTrieuChung_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FGhiNhanTrieuChung());
        }

        private void btn_GhiChuanDoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FGhiNhanChuanDoan());
        }

        private void btn_GhiDonThuoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FGhiNhanXuLyThuoc());
        }

        private void btn_MenuBaoCao_Click(object sender, EventArgs e)
        {
            if (!_sidebarExpanded)
                SetSidebarExpanded(true);
            ToggleSubPanel(pnlSubBaoCao);
        }

        private void btn_LinhSuKB_Click(object sender, EventArgs e)
        {
            // TODO: Mở form Lịch sử khám bệnh
        }

        private void btn_ThongKeKB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FThongKe());
        }

        private void pnlSubNav_Paint(object sender, PaintEventArgs e)
        {
            var p = (Panel)sender;
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (var border = new Pen(UiTheme.BorderColor))
                g.DrawRectangle(border, 0, 0, p.Width - 1, p.Height - 1);

            using var rail = new SolidBrush(UiTheme.PrimaryBlue);
            g.FillRectangle(rail, 0, 0, 3, p.Height);
        }

        private void FLPnl_MenuMain_Paint(object sender, PaintEventArgs e) { }
        private void pnl_Content_Paint(object sender, PaintEventArgs e) { }
    }
}
