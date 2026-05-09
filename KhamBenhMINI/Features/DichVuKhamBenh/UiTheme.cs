using System.Drawing;
using System.Windows.Forms;

namespace KhamBenhMINI.Features.DichVuKhamBenh
{
    /// <summary>Bảng màu, font và helper giao diện dùng chung toàn ứng dụng.</summary>
    public static class UiTheme
    {
        public static readonly Color PrimaryBlue = Color.FromArgb(37, 99, 235);
        public static readonly Color PrimaryDark = Color.FromArgb(29, 78, 216);
        public static readonly Color SoftBlue = Color.FromArgb(239, 246, 255);
        public static readonly Color BorderColor = Color.FromArgb(191, 219, 254);
        public static readonly Color PageBackground = Color.FromArgb(248, 250, 252);
        public static readonly Color TextPrimary = Color.FromArgb(30, 41, 59);
        public static readonly Color TextSecondary = Color.FromArgb(100, 116, 139);
        public static readonly Color Danger = Color.FromArgb(220, 38, 38);
        public static readonly Color DangerSoft = Color.FromArgb(254, 226, 226);
        public static readonly Color Success = Color.FromArgb(22, 163, 74);
        public static readonly Color SuccessSoft = Color.FromArgb(220, 252, 231);

        public static readonly Font TitleFont = new Font("Segoe UI", 13F, FontStyle.Bold);
        public static readonly Font HeaderFont = new Font("Segoe UI", 11F, FontStyle.Bold);
        public static readonly Font NormalFont = new Font("Segoe UI", 10F, FontStyle.Regular);
        public static readonly Font ButtonFont = new Font("Segoe UI", 10F, FontStyle.Bold);
        public static readonly Font SmallFont = new Font("Segoe UI", 9F, FontStyle.Regular);

        public static void ApplyWorkspaceChrome(Form form)
        {
            form.Font = NormalFont;
            form.BackColor = PageBackground;
            form.AutoScaleMode = AutoScaleMode.Font;
        }

        public static void StyleButton(Button button, bool primary = true)
        {
            button.Font = ButtonFont;
            button.Height = Math.Max(button.Height, 38);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Cursor = Cursors.Hand;
            button.UseVisualStyleBackColor = false;
            if (primary)
            {
                button.BackColor = PrimaryBlue;
                button.ForeColor = Color.White;
                button.FlatAppearance.MouseOverBackColor = PrimaryDark;
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 64, 175);
            }
            else
            {
                button.BackColor = Color.White;
                button.ForeColor = TextPrimary;
                button.FlatAppearance.BorderColor = BorderColor;
                button.FlatAppearance.BorderSize = 1;
                button.FlatAppearance.MouseOverBackColor = SoftBlue;
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(219, 234, 254);
            }
        }

        public static void StyleDangerButton(Button button)
        {
            button.Font = ButtonFont;
            button.Height = Math.Max(button.Height, 38);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Cursor = Cursors.Hand;
            button.UseVisualStyleBackColor = false;
            button.BackColor = Danger;
            button.ForeColor = Color.White;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(185, 28, 28);
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(153, 27, 27);
        }

        public static void StyleSuccessButton(Button button)
        {
            button.Font = ButtonFont;
            button.Height = Math.Max(button.Height, 38);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Cursor = Cursors.Hand;
            button.UseVisualStyleBackColor = false;
            button.BackColor = Success;
            button.ForeColor = Color.White;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 128, 61);
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 83, 45);
        }

        public static void StyleGroupBox(GroupBox box)
        {
            box.Font = HeaderFont;
            box.ForeColor = PrimaryBlue;
            box.BackColor = Color.White;
            box.Padding = new Padding(14, 8, 14, 12);
        }

        public static void StyleLabelCaption(Label label)
        {
            label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label.ForeColor = TextPrimary;
            label.BackColor = Color.Transparent;
        }

        public static void StyleLabelBody(Label label)
        {
            label.Font = NormalFont;
            label.ForeColor = TextSecondary;
            label.BackColor = Color.Transparent;
        }

        public static void StyleTextBox(TextBox box)
        {
            box.Font = NormalFont;
            box.BorderStyle = BorderStyle.FixedSingle;
            box.BackColor = Color.White;
            box.ForeColor = TextPrimary;
        }

        public static void StyleCombo(ComboBox combo)
        {
            combo.Font = NormalFont;
            combo.FlatStyle = FlatStyle.Flat;
            combo.BackColor = Color.White;
            combo.ForeColor = TextPrimary;
        }

        public static void StyleDatePicker(DateTimePicker dtp)
        {
            dtp.Font = NormalFont;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CalendarForeColor = TextPrimary;
            dtp.CalendarTitleBackColor = SoftBlue;
            dtp.CalendarTitleForeColor = TextPrimary;
        }

        public static void StyleRadio(RadioButton r)
        {
            r.Font = NormalFont;
            r.ForeColor = TextPrimary;
            r.BackColor = Color.Transparent;
        }

        public static GroupBox CreateGroup(string text, int height, DockStyle dock = DockStyle.Top)
        {
            var g = new GroupBox
            {
                Text = text,
                Font = HeaderFont,
                ForeColor = PrimaryBlue,
                Dock = dock,
                Height = height,
                Padding = new Padding(14, 10, 14, 12),
                BackColor = Color.White
            };
            return g;
        }

        public static void StyleGrid(DataGridView grid)
        {
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = Color.FromArgb(226, 232, 240);
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ReadOnly = true;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.RowHeadersVisible = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = SoftBlue;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = TextPrimary;
            grid.ColumnHeadersDefaultCellStyle.Font = ButtonFont;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = SoftBlue;
            grid.ColumnHeadersHeight = 38;
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.Font = NormalFont;
            grid.DefaultCellStyle.ForeColor = TextPrimary;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 219, 254);
            grid.DefaultCellStyle.SelectionForeColor = TextPrimary;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            grid.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 219, 254);
            grid.AlternatingRowsDefaultCellStyle.SelectionForeColor = TextPrimary;
            grid.RowTemplate.Height = 36;
        }
    }
}
