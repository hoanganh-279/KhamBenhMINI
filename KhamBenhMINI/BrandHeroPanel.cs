using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace KhamBenhMINI
{
    /// <summary>Nền xanh gradient, mép phải dạng “giấy xé” (zigzag), clip Region bo theo mép.</summary>
    internal sealed class BrandHeroPanel : Panel
    {
        private static readonly Color BlueTop = Color.FromArgb(37, 99, 235);
        private static readonly Color BlueBottom = Color.FromArgb(30, 64, 175);

        public BrandHeroPanel()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true);
            UpdateStyles();
            ForeColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var r = ClientRectangle;
            using var brush = new LinearGradientBrush(r, BlueTop, BlueBottom, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(brush, r);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            ApplyZigZagRegion();
        }

        private void ApplyZigZagRegion()
        {
            if (Width <= 1 || Height <= 1)
                return;
            using GraphicsPath path = CreateZigZagOutline(ClientRectangle, tooth: 14, step: 11);
            Region = new Region(path);
        }

        private static GraphicsPath CreateZigZagOutline(Rectangle bounds, int tooth, int step)
        {
            var path = new GraphicsPath();
            int L = bounds.Left, R = bounds.Right, T = bounds.Top, B = bounds.Bottom;
            int innerR = R - tooth;

            path.StartFigure();
            path.AddLine(L, T, innerR, T);

            float y = T;
            bool tipRight = true;
            while (y < B - 0.5f)
            {
                float yNext = Math.Min(y + step, B);
                float xFrom = tipRight ? innerR : R;
                float xTo = tipRight ? R : innerR;
                path.AddLine(xFrom, y, xTo, yNext);
                y = yNext;
                tipRight = !tipRight;
            }

            path.AddLine(innerR, B, L, B);
            path.AddLine(L, B, L, T);
            path.CloseFigure();
            return path;
        }
    }
}
