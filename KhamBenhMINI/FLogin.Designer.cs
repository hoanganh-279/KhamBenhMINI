using System.Drawing;
using System.Windows.Forms;
using KhamBenhMINI.Features.DichVuKhamBenh;

namespace KhamBenhMINI
{
    partial class FLogin
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

        private void InitializeComponent()
        {
            panelBg = new Panel();
            splitRoot = new TableLayoutPanel();
            pnlBrand = new BrandHeroPanel();
            tblBrand = new TableLayoutPanel();
            lblBrandKicker = new Label();
            lblBrandTitle = new Label();
            lblBrandLogo = new Label();
            tblSidebarFeatures = new TableLayoutPanel();
            pnlFeat1 = new Panel();
            lblFeat1 = new Label();
            pnlFeat2 = new Panel();
            lblFeat2 = new Label();
            pnlFeat3 = new Panel();
            lblFeat3 = new Label();
            pnlFeat4 = new Panel();
            lblFeat4 = new Label();
            pnlFeatureFiller = new Panel();
            lblBrandFooter = new Label();
            pnlSidebarHeader = new Panel();
            lblSidebarHeaderTitle = new Label();
            pnlLoginArea = new Panel();
            tblLoginCenter = new TableLayoutPanel();
            cardLogin = new ModernCardPanel();
            layoutCard = new TableLayoutPanel();
            label_Login = new Label();
            label_Subtitle = new Label();
            label_Error = new Label();
            tblUserField = new TableLayoutPanel();
            label_Name = new Label();
            pnlUnderlineName = new Panel();
            textBox_Name = new TextBox();
            tblPassField = new TableLayoutPanel();
            label_Password = new Label();
            panelPassRow = new Panel();
            textBox_Password = new TextBox();
            showpassword = new Button();
            pnlForgotRow = new Panel();
            lblForgot = new LinkLabel();
            tblLoginActions = new TableLayoutPanel();
            button_Login = new Button();
            linkExit = new LinkLabel();
            panelBg.SuspendLayout();
            splitRoot.SuspendLayout();
            pnlBrand.SuspendLayout();
            tblBrand.SuspendLayout();
            tblSidebarFeatures.SuspendLayout();
            pnlFeat1.SuspendLayout();
            pnlFeat2.SuspendLayout();
            pnlFeat3.SuspendLayout();
            pnlFeat4.SuspendLayout();
            pnlSidebarHeader.SuspendLayout();
            pnlLoginArea.SuspendLayout();
            tblLoginCenter.SuspendLayout();
            cardLogin.SuspendLayout();
            layoutCard.SuspendLayout();
            tblUserField.SuspendLayout();
            pnlUnderlineName.SuspendLayout();
            tblPassField.SuspendLayout();
            panelPassRow.SuspendLayout();
            pnlForgotRow.SuspendLayout();
            tblLoginActions.SuspendLayout();
            SuspendLayout();
            // 
            // panelBg
            // 
            panelBg.BackColor = Color.FromArgb(248, 250, 252);
            panelBg.Controls.Add(splitRoot);
            panelBg.Dock = DockStyle.Fill;
            panelBg.Location = new Point(0, 0);
            panelBg.Name = "panelBg";
            panelBg.Size = new Size(1020, 660);
            panelBg.TabIndex = 0;
            // 
            // splitRoot
            // 
            splitRoot.ColumnCount = 2;
            splitRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            splitRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62F));
            splitRoot.Controls.Add(pnlBrand, 0, 0);
            splitRoot.Controls.Add(pnlLoginArea, 1, 0);
            splitRoot.Dock = DockStyle.Fill;
            splitRoot.Location = new Point(0, 0);
            splitRoot.Margin = new Padding(0);
            splitRoot.Name = "splitRoot";
            splitRoot.RowCount = 1;
            splitRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            splitRoot.Size = new Size(1020, 660);
            splitRoot.TabIndex = 0;
            // 
            // pnlBrand
            // 
            pnlBrand.Controls.Add(tblBrand);
            pnlBrand.Controls.Add(pnlSidebarHeader);
            pnlBrand.Dock = DockStyle.Fill;
            pnlBrand.Location = new Point(0, 0);
            pnlBrand.Margin = new Padding(0);
            pnlBrand.Name = "pnlBrand";
            pnlBrand.Size = new Size(387, 660);
            pnlBrand.TabIndex = 0;
            // 
            // tblBrand
            // 
            tblBrand.BackColor = Color.Transparent;
            tblBrand.ColumnCount = 1;
            tblBrand.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblBrand.Controls.Add(lblBrandKicker, 0, 0);
            tblBrand.Controls.Add(lblBrandTitle, 0, 1);
            tblBrand.Controls.Add(lblBrandLogo, 0, 2);
            tblBrand.Controls.Add(tblSidebarFeatures, 0, 3);
            tblBrand.Controls.Add(lblBrandFooter, 0, 4);
            tblBrand.Dock = DockStyle.Fill;
            tblBrand.Location = new Point(0, 60);
            tblBrand.Margin = new Padding(0);
            tblBrand.Name = "tblBrand";
            tblBrand.Padding = new Padding(22, 28, 22, 22);
            tblBrand.RowCount = 5;
            tblBrand.RowStyles.Add(new RowStyle());
            tblBrand.RowStyles.Add(new RowStyle());
            tblBrand.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tblBrand.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBrand.RowStyles.Add(new RowStyle());
            tblBrand.Size = new Size(387, 600);
            tblBrand.TabIndex = 0;
            // 
            // lblBrandKicker
            // 
            lblBrandKicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBrandKicker.AutoSize = true;
            lblBrandKicker.BackColor = Color.Transparent;
            lblBrandKicker.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblBrandKicker.ForeColor = Color.FromArgb(226, 232, 240);
            lblBrandKicker.Location = new Point(22, 28);
            lblBrandKicker.Margin = new Padding(0, 0, 0, 10);
            lblBrandKicker.Name = "lblBrandKicker";
            lblBrandKicker.Size = new Size(343, 21);
            lblBrandKicker.TabIndex = 0;
            lblBrandKicker.Text = "CHÀO MỪNG ĐẾN VỚI";
            // 
            // lblBrandTitle
            // 
            lblBrandTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBrandTitle.AutoSize = true;
            lblBrandTitle.BackColor = Color.Transparent;
            lblBrandTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblBrandTitle.ForeColor = Color.White;
            lblBrandTitle.Location = new Point(22, 59);
            lblBrandTitle.Margin = new Padding(0, 0, 0, 20);
            lblBrandTitle.Name = "lblBrandTitle";
            lblBrandTitle.Size = new Size(343, 100);
            lblBrandTitle.TabIndex = 1;
            lblBrandTitle.Text = "Phòng khám\r\nđiện tử MINI";
            // 
            // lblBrandLogo
            // 
            lblBrandLogo.BackColor = Color.Transparent;
            lblBrandLogo.Dock = DockStyle.Fill;
            lblBrandLogo.Font = new Font("Segoe UI", 72F);
            lblBrandLogo.ForeColor = Color.FromArgb(191, 219, 254);
            lblBrandLogo.Location = new Point(22, 179);
            lblBrandLogo.Margin = new Padding(0, 0, 0, 16);
            lblBrandLogo.Name = "lblBrandLogo";
            lblBrandLogo.Size = new Size(343, 104);
            lblBrandLogo.TabIndex = 2;
            lblBrandLogo.Text = "⚕";
            lblBrandLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblSidebarFeatures
            // 
            tblSidebarFeatures.ColumnCount = 1;
            tblSidebarFeatures.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSidebarFeatures.Controls.Add(pnlFeat1, 0, 0);
            tblSidebarFeatures.Controls.Add(pnlFeat2, 0, 1);
            tblSidebarFeatures.Controls.Add(pnlFeat3, 0, 2);
            tblSidebarFeatures.Controls.Add(pnlFeat4, 0, 3);
            tblSidebarFeatures.Controls.Add(pnlFeatureFiller, 0, 4);
            tblSidebarFeatures.Dock = DockStyle.Fill;
            tblSidebarFeatures.Location = new Point(22, 311);
            tblSidebarFeatures.Margin = new Padding(0, 12, 0, 0);
            tblSidebarFeatures.Name = "tblSidebarFeatures";
            tblSidebarFeatures.RowCount = 5;
            tblSidebarFeatures.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblSidebarFeatures.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblSidebarFeatures.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblSidebarFeatures.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblSidebarFeatures.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblSidebarFeatures.Size = new Size(343, 199);
            tblSidebarFeatures.TabIndex = 3;
            // 
            // pnlFeat1
            // 
            pnlFeat1.BackColor = Color.White;
            pnlFeat1.Controls.Add(lblFeat1);
            pnlFeat1.Dock = DockStyle.Fill;
            pnlFeat1.Location = new Point(0, 0);
            pnlFeat1.Margin = new Padding(0, 0, 0, 10);
            pnlFeat1.Name = "pnlFeat1";
            pnlFeat1.Size = new Size(343, 46);
            pnlFeat1.TabIndex = 0;
            // 
            // lblFeat1
            // 
            lblFeat1.BackColor = Color.White;
            lblFeat1.Dock = DockStyle.Fill;
            lblFeat1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFeat1.ForeColor = Color.FromArgb(30, 41, 59);
            lblFeat1.Location = new Point(0, 0);
            lblFeat1.Margin = new Padding(0);
            lblFeat1.Name = "lblFeat1";
            lblFeat1.Padding = new Padding(14, 0, 8, 0);
            lblFeat1.Size = new Size(343, 46);
            lblFeat1.TabIndex = 0;
            lblFeat1.Text = "🏥  Tiếp nhận · triệu chứng · hàng đợi";
            lblFeat1.TextAlign = ContentAlignment.MiddleLeft;
            lblFeat1.UseMnemonic = false;
            // 
            // pnlFeat2
            // 
            pnlFeat2.BackColor = Color.White;
            pnlFeat2.Controls.Add(lblFeat2);
            pnlFeat2.Dock = DockStyle.Fill;
            pnlFeat2.Location = new Point(0, 56);
            pnlFeat2.Margin = new Padding(0, 0, 0, 10);
            pnlFeat2.Name = "pnlFeat2";
            pnlFeat2.Size = new Size(343, 46);
            pnlFeat2.TabIndex = 1;
            // 
            // lblFeat2
            // 
            lblFeat2.BackColor = Color.White;
            lblFeat2.Dock = DockStyle.Fill;
            lblFeat2.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold);
            lblFeat2.ForeColor = Color.FromArgb(30, 41, 59);
            lblFeat2.Location = new Point(0, 0);
            lblFeat2.Margin = new Padding(0);
            lblFeat2.Name = "lblFeat2";
            lblFeat2.Padding = new Padding(14, 0, 8, 0);
            lblFeat2.Size = new Size(343, 46);
            lblFeat2.TabIndex = 0;
            lblFeat2.Text = "\U0001fa7a  Chuẩn đoán ICD · ghi nhận";
            lblFeat2.TextAlign = ContentAlignment.MiddleLeft;
            lblFeat2.UseMnemonic = false;
            // 
            // pnlFeat3
            // 
            pnlFeat3.BackColor = Color.White;
            pnlFeat3.Controls.Add(lblFeat3);
            pnlFeat3.Dock = DockStyle.Fill;
            pnlFeat3.Location = new Point(0, 112);
            pnlFeat3.Margin = new Padding(0, 0, 0, 10);
            pnlFeat3.Name = "pnlFeat3";
            pnlFeat3.Size = new Size(343, 46);
            pnlFeat3.TabIndex = 2;
            // 
            // lblFeat3
            // 
            lblFeat3.BackColor = Color.White;
            lblFeat3.Dock = DockStyle.Fill;
            lblFeat3.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold);
            lblFeat3.ForeColor = Color.FromArgb(30, 41, 59);
            lblFeat3.Location = new Point(0, 0);
            lblFeat3.Margin = new Padding(0);
            lblFeat3.Name = "lblFeat3";
            lblFeat3.Padding = new Padding(14, 0, 8, 0);
            lblFeat3.Size = new Size(343, 46);
            lblFeat3.TabIndex = 0;
            lblFeat3.Text = "💊  Kê đơn · xử lý thuốc";
            lblFeat3.TextAlign = ContentAlignment.MiddleLeft;
            lblFeat3.UseMnemonic = false;
            // 
            // pnlFeat4
            // 
            pnlFeat4.BackColor = Color.White;
            pnlFeat4.Controls.Add(lblFeat4);
            pnlFeat4.Dock = DockStyle.Fill;
            pnlFeat4.Location = new Point(0, 168);
            pnlFeat4.Margin = new Padding(0, 0, 0, 8);
            pnlFeat4.Name = "pnlFeat4";
            pnlFeat4.Size = new Size(343, 48);
            pnlFeat4.TabIndex = 3;
            // 
            // lblFeat4
            // 
            lblFeat4.BackColor = Color.White;
            lblFeat4.Dock = DockStyle.Fill;
            lblFeat4.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold);
            lblFeat4.ForeColor = Color.FromArgb(30, 41, 59);
            lblFeat4.Location = new Point(0, 0);
            lblFeat4.Margin = new Padding(0);
            lblFeat4.Name = "lblFeat4";
            lblFeat4.Padding = new Padding(14, 0, 8, 0);
            lblFeat4.Size = new Size(343, 48);
            lblFeat4.TabIndex = 0;
            lblFeat4.Text = "📊  Thống kê · báo cáo nhanh";
            lblFeat4.TextAlign = ContentAlignment.MiddleLeft;
            lblFeat4.UseMnemonic = false;
            // 
            // pnlFeatureFiller
            // 
            pnlFeatureFiller.BackColor = Color.Transparent;
            pnlFeatureFiller.Dock = DockStyle.Fill;
            pnlFeatureFiller.Location = new Point(0, 224);
            pnlFeatureFiller.Margin = new Padding(0);
            pnlFeatureFiller.Name = "pnlFeatureFiller";
            pnlFeatureFiller.Size = new Size(343, 1);
            pnlFeatureFiller.TabIndex = 4;
            // 
            // lblBrandFooter
            // 
            lblBrandFooter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBrandFooter.AutoSize = true;
            lblBrandFooter.BackColor = Color.Transparent;
            lblBrandFooter.Font = new Font("Segoe UI", 9F);
            lblBrandFooter.ForeColor = Color.FromArgb(191, 219, 254);
            lblBrandFooter.Location = new Point(22, 538);
            lblBrandFooter.Margin = new Padding(0, 28, 0, 0);
            lblBrandFooter.Name = "lblBrandFooter";
            lblBrandFooter.Size = new Size(343, 40);
            lblBrandFooter.TabIndex = 4;
            lblBrandFooter.Text = "Đề tài Lập trình Windows — Quản lý khám bệnh & đơn thuốc";
            // 
            // pnlSidebarHeader
            // 
            pnlSidebarHeader.BackColor = Color.Transparent;
            pnlSidebarHeader.Controls.Add(lblSidebarHeaderTitle);
            pnlSidebarHeader.Dock = DockStyle.Top;
            pnlSidebarHeader.Location = new Point(0, 0);
            pnlSidebarHeader.Margin = new Padding(0);
            pnlSidebarHeader.Name = "pnlSidebarHeader";
            pnlSidebarHeader.Size = new Size(387, 60);
            pnlSidebarHeader.TabIndex = 1;
            // 
            // lblSidebarHeaderTitle
            // 
            lblSidebarHeaderTitle.BackColor = Color.Transparent;
            lblSidebarHeaderTitle.Dock = DockStyle.Fill;
            lblSidebarHeaderTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSidebarHeaderTitle.ForeColor = Color.White;
            lblSidebarHeaderTitle.Location = new Point(0, 0);
            lblSidebarHeaderTitle.Margin = new Padding(0);
            lblSidebarHeaderTitle.Name = "lblSidebarHeaderTitle";
            lblSidebarHeaderTitle.Size = new Size(387, 60);
            lblSidebarHeaderTitle.TabIndex = 0;
            lblSidebarHeaderTitle.Text = "Phòng khám điện tử MINI";
            lblSidebarHeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLoginArea
            // 
            pnlLoginArea.BackColor = Color.FromArgb(241, 245, 249);
            pnlLoginArea.Controls.Add(tblLoginCenter);
            pnlLoginArea.Dock = DockStyle.Fill;
            pnlLoginArea.Location = new Point(387, 0);
            pnlLoginArea.Margin = new Padding(0);
            pnlLoginArea.Name = "pnlLoginArea";
            pnlLoginArea.Padding = new Padding(48, 40, 52, 40);
            pnlLoginArea.Size = new Size(633, 660);
            pnlLoginArea.TabIndex = 1;
            // 
            // tblLoginCenter
            // 
            tblLoginCenter.ColumnCount = 3;
            tblLoginCenter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblLoginCenter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tblLoginCenter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblLoginCenter.Controls.Add(cardLogin, 1, 0);
            tblLoginCenter.Dock = DockStyle.Fill;
            tblLoginCenter.Location = new Point(48, 40);
            tblLoginCenter.Margin = new Padding(0);
            tblLoginCenter.Name = "tblLoginCenter";
            tblLoginCenter.RowCount = 1;
            tblLoginCenter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLoginCenter.Size = new Size(533, 580);
            tblLoginCenter.TabIndex = 0;
            // 
            // cardLogin
            // 
            cardLogin.BackColor = Color.White;
            cardLogin.Controls.Add(layoutCard);
            cardLogin.Dock = DockStyle.Fill;
            cardLogin.Location = new Point(106, 0);
            cardLogin.Margin = new Padding(0);
            cardLogin.Name = "cardLogin";
            cardLogin.Size = new Size(319, 580);
            cardLogin.TabIndex = 0;
            // 
            // layoutCard
            // 
            layoutCard.ColumnCount = 1;
            layoutCard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutCard.Controls.Add(label_Login, 0, 0);
            layoutCard.Controls.Add(label_Subtitle, 0, 1);
            layoutCard.Controls.Add(label_Error, 0, 2);
            layoutCard.Controls.Add(tblUserField, 0, 3);
            layoutCard.Controls.Add(tblPassField, 0, 4);
            layoutCard.Controls.Add(pnlForgotRow, 0, 5);
            layoutCard.Controls.Add(tblLoginActions, 0, 6);
            layoutCard.Dock = DockStyle.Fill;
            layoutCard.Location = new Point(0, 0);
            layoutCard.Margin = new Padding(0);
            layoutCard.Name = "layoutCard";
            layoutCard.Padding = new Padding(40, 44, 40, 32);
            layoutCard.RowCount = 7;
            layoutCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            layoutCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            layoutCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            layoutCard.RowStyles.Add(new RowStyle());
            layoutCard.RowStyles.Add(new RowStyle());
            layoutCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            layoutCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 126F));
            layoutCard.Size = new Size(319, 580);
            layoutCard.TabIndex = 0;
            // 
            // label_Login
            // 
            label_Login.Dock = DockStyle.Fill;
            label_Login.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label_Login.ForeColor = Color.FromArgb(30, 41, 59);
            label_Login.Location = new Point(40, 44);
            label_Login.Margin = new Padding(0, 0, 0, 4);
            label_Login.Name = "label_Login";
            label_Login.Size = new Size(239, 52);
            label_Login.TabIndex = 0;
            label_Login.Text = "Đăng nhập tài khoản";
            label_Login.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label_Subtitle
            // 
            label_Subtitle.Dock = DockStyle.Fill;
            label_Subtitle.Font = new Font("Segoe UI", 10.25F);
            label_Subtitle.ForeColor = Color.FromArgb(94, 113, 140);
            label_Subtitle.Location = new Point(40, 100);
            label_Subtitle.Margin = new Padding(0, 0, 0, 10);
            label_Subtitle.Name = "label_Subtitle";
            label_Subtitle.Size = new Size(239, 34);
            label_Subtitle.TabIndex = 1;
            label_Subtitle.Text = "Quản lý lượt khám · Chuẩn đoán ICD · Kê đơn và xử lý thuốc";
            // 
            // label_Error
            // 
            label_Error.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_Error.AutoSize = true;
            label_Error.Font = new Font("Segoe UI", 9.25F);
            label_Error.ForeColor = Color.FromArgb(220, 38, 38);
            label_Error.Location = new Point(40, 144);
            label_Error.Margin = new Padding(0, 0, 0, 8);
            label_Error.MinimumSize = new Size(0, 22);
            label_Error.Name = "label_Error";
            label_Error.Size = new Size(239, 22);
            label_Error.TabIndex = 2;
            label_Error.TextAlign = ContentAlignment.MiddleLeft;
            label_Error.Visible = false;
            // 
            // tblUserField
            // 
            tblUserField.AutoSize = true;
            tblUserField.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblUserField.ColumnCount = 1;
            tblUserField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblUserField.Controls.Add(label_Name, 0, 0);
            tblUserField.Controls.Add(pnlUnderlineName, 0, 1);
            tblUserField.Dock = DockStyle.Fill;
            tblUserField.Location = new Point(40, 182);
            tblUserField.Margin = new Padding(0, 6, 0, 16);
            tblUserField.Name = "tblUserField";
            tblUserField.RowCount = 2;
            tblUserField.RowStyles.Add(new RowStyle());
            tblUserField.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tblUserField.Size = new Size(239, 77);
            tblUserField.TabIndex = 3;
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label_Name.ForeColor = Color.FromArgb(51, 65, 85);
            label_Name.Location = new Point(0, 0);
            label_Name.Margin = new Padding(0, 0, 0, 8);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(128, 23);
            label_Name.TabIndex = 0;
            label_Name.Text = "Tên đăng nhập";
            // 
            // pnlUnderlineName
            // 
            pnlUnderlineName.Controls.Add(textBox_Name);
            pnlUnderlineName.Dock = DockStyle.Fill;
            pnlUnderlineName.Location = new Point(0, 31);
            pnlUnderlineName.Margin = new Padding(0);
            pnlUnderlineName.Name = "pnlUnderlineName";
            pnlUnderlineName.Size = new Size(239, 46);
            pnlUnderlineName.TabIndex = 1;
            // 
            // textBox_Name
            // 
            textBox_Name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Name.BorderStyle = BorderStyle.None;
            textBox_Name.Font = new Font("Segoe UI", 10.5F);
            textBox_Name.Location = new Point(0, 6);
            textBox_Name.Margin = new Padding(0);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(239, 24);
            textBox_Name.TabIndex = 1;
            textBox_Name.TextChanged += textBox_Name_TextChanged;
            // 
            // tblPassField
            // 
            tblPassField.AutoSize = true;
            tblPassField.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblPassField.ColumnCount = 1;
            tblPassField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPassField.Controls.Add(label_Password, 0, 0);
            tblPassField.Controls.Add(panelPassRow, 0, 1);
            tblPassField.Dock = DockStyle.Fill;
            tblPassField.Location = new Point(40, 275);
            tblPassField.Margin = new Padding(0, 0, 0, 6);
            tblPassField.Name = "tblPassField";
            tblPassField.RowCount = 2;
            tblPassField.RowStyles.Add(new RowStyle());
            tblPassField.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tblPassField.Size = new Size(239, 77);
            tblPassField.TabIndex = 4;
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label_Password.ForeColor = Color.FromArgb(51, 65, 85);
            label_Password.Location = new Point(0, 0);
            label_Password.Margin = new Padding(0, 0, 0, 8);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(86, 23);
            label_Password.TabIndex = 0;
            label_Password.Text = "Mật khẩu";
            // 
            // panelPassRow
            // 
            panelPassRow.BackColor = Color.White;
            panelPassRow.Controls.Add(textBox_Password);
            panelPassRow.Controls.Add(showpassword);
            panelPassRow.Dock = DockStyle.Fill;
            panelPassRow.Location = new Point(0, 31);
            panelPassRow.Margin = new Padding(0);
            panelPassRow.Name = "panelPassRow";
            panelPassRow.Size = new Size(239, 46);
            panelPassRow.TabIndex = 1;
            // 
            // textBox_Password
            // 
            textBox_Password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Password.BorderStyle = BorderStyle.None;
            textBox_Password.Font = new Font("Segoe UI", 10.5F);
            textBox_Password.Location = new Point(0, 6);
            textBox_Password.Margin = new Padding(0);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(187, 24);
            textBox_Password.TabIndex = 2;
            textBox_Password.UseSystemPasswordChar = true;
            textBox_Password.TextChanged += textBox_Password_TextChanged;
            // 
            // showpassword
            // 
            showpassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            showpassword.BackColor = Color.White;
            showpassword.Cursor = Cursors.Hand;
            showpassword.FlatAppearance.BorderSize = 0;
            showpassword.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            showpassword.FlatStyle = FlatStyle.Flat;
            showpassword.Font = new Font("Segoe UI Emoji", 9F);
            showpassword.Location = new Point(193, 2);
            showpassword.Name = "showpassword";
            showpassword.Size = new Size(46, 34);
            showpassword.TabIndex = 3;
            showpassword.UseVisualStyleBackColor = false;
            showpassword.Click += button3_Click;
            // 
            // pnlForgotRow
            // 
            pnlForgotRow.Controls.Add(lblForgot);
            pnlForgotRow.Dock = DockStyle.Fill;
            pnlForgotRow.Location = new Point(40, 358);
            pnlForgotRow.Margin = new Padding(0);
            pnlForgotRow.Name = "pnlForgotRow";
            pnlForgotRow.Size = new Size(239, 34);
            pnlForgotRow.TabIndex = 5;
            // 
            // lblForgot
            // 
            lblForgot.ActiveLinkColor = Color.FromArgb(30, 136, 229);
            lblForgot.AutoSize = true;
            lblForgot.Cursor = Cursors.Hand;
            lblForgot.Dock = DockStyle.Right;
            lblForgot.Font = new Font("Segoe UI", 9F);
            lblForgot.LinkBehavior = LinkBehavior.HoverUnderline;
            lblForgot.LinkColor = Color.FromArgb(30, 136, 229);
            lblForgot.Location = new Point(123, 0);
            lblForgot.Margin = new Padding(0);
            lblForgot.Name = "lblForgot";
            lblForgot.Size = new Size(116, 20);
            lblForgot.TabIndex = 0;
            lblForgot.TabStop = true;
            lblForgot.Text = "Quên mật khẩu?";
            lblForgot.TextAlign = ContentAlignment.MiddleRight;
            lblForgot.LinkClicked += lblForgot_LinkClicked;
            // 
            // tblLoginActions
            // 
            tblLoginActions.ColumnCount = 1;
            tblLoginActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLoginActions.Controls.Add(button_Login, 0, 0);
            tblLoginActions.Controls.Add(linkExit, 0, 1);
            tblLoginActions.Dock = DockStyle.Fill;
            tblLoginActions.Location = new Point(40, 402);
            tblLoginActions.Margin = new Padding(0, 10, 0, 0);
            tblLoginActions.Name = "tblLoginActions";
            tblLoginActions.RowCount = 2;
            tblLoginActions.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblLoginActions.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tblLoginActions.Size = new Size(239, 146);
            tblLoginActions.TabIndex = 6;
            // 
            // button_Login
            // 
            button_Login.Dock = DockStyle.Fill;
            button_Login.Location = new Point(0, 0);
            button_Login.Margin = new Padding(0, 0, 0, 10);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(239, 46);
            button_Login.TabIndex = 4;
            button_Login.Text = "ĐĂNG NHẬP";
            button_Login.Click += button_Login_Click;
            // 
            // linkExit
            // 
            linkExit.ActiveLinkColor = Color.FromArgb(71, 85, 105);
            linkExit.AutoSize = true;
            linkExit.Cursor = Cursors.Hand;
            linkExit.Dock = DockStyle.Fill;
            linkExit.Font = new Font("Segoe UI", 9.25F);
            linkExit.LinkBehavior = LinkBehavior.HoverUnderline;
            linkExit.LinkColor = Color.FromArgb(100, 116, 139);
            linkExit.Location = new Point(0, 56);
            linkExit.Margin = new Padding(0);
            linkExit.Name = "linkExit";
            linkExit.Size = new Size(239, 90);
            linkExit.TabIndex = 5;
            linkExit.TabStop = true;
            linkExit.Text = "Thoát ứng dụng";
            linkExit.TextAlign = ContentAlignment.MiddleCenter;
            linkExit.LinkClicked += linkExit_LinkClicked;
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1020, 660);
            Controls.Add(panelBg);
            Font = new Font("Segoe UI", 10F);
            KeyPreview = true;
            MinimumSize = new Size(860, 580);
            Name = "FLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập — Quản lý khám bệnh & thuốc";
            panelBg.ResumeLayout(false);
            splitRoot.ResumeLayout(false);
            pnlBrand.ResumeLayout(false);
            tblBrand.ResumeLayout(false);
            tblBrand.PerformLayout();
            tblSidebarFeatures.ResumeLayout(false);
            pnlFeat1.ResumeLayout(false);
            pnlFeat2.ResumeLayout(false);
            pnlFeat3.ResumeLayout(false);
            pnlFeat4.ResumeLayout(false);
            pnlSidebarHeader.ResumeLayout(false);
            pnlLoginArea.ResumeLayout(false);
            tblLoginCenter.ResumeLayout(false);
            cardLogin.ResumeLayout(false);
            layoutCard.ResumeLayout(false);
            layoutCard.PerformLayout();
            tblUserField.ResumeLayout(false);
            tblUserField.PerformLayout();
            pnlUnderlineName.ResumeLayout(false);
            pnlUnderlineName.PerformLayout();
            tblPassField.ResumeLayout(false);
            tblPassField.PerformLayout();
            panelPassRow.ResumeLayout(false);
            panelPassRow.PerformLayout();
            pnlForgotRow.ResumeLayout(false);
            pnlForgotRow.PerformLayout();
            tblLoginActions.ResumeLayout(false);
            tblLoginActions.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panelBg;
        private TableLayoutPanel splitRoot;
        private BrandHeroPanel pnlBrand;
        private Panel pnlSidebarHeader;
        private Label lblSidebarHeaderTitle;
        private TableLayoutPanel tblBrand;
        private Label lblBrandKicker;
        private Label lblBrandTitle;
        private Label lblBrandLogo;
        private TableLayoutPanel tblSidebarFeatures;
        private Panel pnlFeat1;
        private Label lblFeat1;
        private Panel pnlFeat2;
        private Label lblFeat2;
        private Panel pnlFeat3;
        private Label lblFeat3;
        private Panel pnlFeat4;
        private Label lblFeat4;
        private Panel pnlFeatureFiller;
        private Label lblBrandFooter;
        private Panel pnlLoginArea;
        private TableLayoutPanel tblLoginCenter;
        private ModernCardPanel cardLogin;
        private TableLayoutPanel layoutCard;
        private TableLayoutPanel tblUserField;
        private TableLayoutPanel tblPassField;
        private Panel panelPassRow;
        private Panel pnlForgotRow;
        private LinkLabel lblForgot;
        private TableLayoutPanel tblLoginActions;
        private Button button_Login;
        private LinkLabel linkExit;
        private TextBox textBox_Password;
        private TextBox textBox_Name;
        private Label label_Password;
        private Panel pnlUnderlineName;
        private Label label_Name;
        private Label label_Login;
        private Label label_Subtitle;
        private Label label_Error;
        public Button showpassword;
    }
}