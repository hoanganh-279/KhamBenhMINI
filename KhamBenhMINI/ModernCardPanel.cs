using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace KhamBenhMINI
{
    /// <summary>Panel trắng bo góc, viền nhẹ — dùng cho khối đăng nhập.</summary>
    internal sealed class ModernCardPanel : Panel
    {
        private const int CornerRadius = 20;
        private static readonly Color BorderTint = Color.FromArgb(210, 224, 238);

        public ModernCardPanel()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true);
            UpdateStyles();
            BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using var path = CreateRoundRect(rect, CornerRadius);
            using var pen = new Pen(BorderTint, 1f);
            g.DrawPath(pen, path);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (Width <= 0 || Height <= 0) return;
            using var path = CreateRoundRect(new Rectangle(0, 0, Width - 1, Height - 1), CornerRadius);
            Region = new Region(path);
        }

        private static GraphicsPath CreateRoundRect(Rectangle r, int radius)
        {
            int d = Math.Min(radius * 2, Math.Min(r.Width, r.Height));
            var path = new GraphicsPath();
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
