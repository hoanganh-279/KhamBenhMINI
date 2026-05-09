using System.Drawing;
using System.Windows.Forms;

namespace KhamBenhMINI.Features.DichVuKhamBenh
{
    internal static class UiTheme
    {
        public static readonly Color PrimaryBlue = Color.FromArgb(30, 136, 229);
        public static readonly Color SoftBlue = Color.FromArgb(227, 242, 253);
        public static readonly Color BorderColor = Color.FromArgb(187, 222, 251);
        public static readonly Font HeaderFont = new Font("Segoe UI", 11F, FontStyle.Bold);
        public static readonly Font NormalFont = new Font("Segoe UI", 10F, FontStyle.Regular);
        public static readonly Font ButtonFont = new Font("Segoe UI", 10F, FontStyle.Bold);

        public static void StyleButton(Button button, bool primary = true)
        {
            button.Font = ButtonFont;
            button.Height = 40;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Cursor = Cursors.Hand;
            button.BackColor = primary ? PrimaryBlue : Color.Gainsboro;
            button.ForeColor = primary ? Color.White : Color.Black;
        }

        public static GroupBox CreateGroup(string text, int height, DockStyle dock = DockStyle.Top)
        {
            return new GroupBox
            {
                Text = text,
                Font = HeaderFont,
                ForeColor = PrimaryBlue,
                Dock = dock,
                Height = height,
                Padding = new Padding(12, 10, 12, 10),
                BackColor = Color.White
            };
        }

        public static void StyleGrid(DataGridView grid)
        {
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.FixedSingle;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ReadOnly = true;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.RowHeadersVisible = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ColumnHeadersDefaultCellStyle.BackColor = SoftBlue;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            grid.ColumnHeadersDefaultCellStyle.Font = ButtonFont;
            grid.ColumnHeadersHeight = 36;
            grid.EnableHeadersVisualStyles = false;
            grid.DefaultCellStyle.Font = NormalFont;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(66, 165, 245);
            grid.DefaultCellStyle.SelectionForeColor = Color.White;
            grid.RowTemplate.Height = 34;
        }
    }
}
