using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using KhamBenhMINI.Features.DichVuKhamBenh;

namespace KhamBenhMINI
{
    internal static class UnderlineFieldHelper
    {
        private static readonly Color IdleLine = Color.FromArgb(203, 213, 225);

        public static void AttachUnderline(Panel host, TextBox box)
        {
            host.BackColor = Color.White;
            box.BorderStyle = BorderStyle.None;
            box.BackColor = Color.White;

            void PaintLine(object? _, PaintEventArgs e)
            {
                bool focus = box.Focused || host.ContainsFocus;
                float thickness = focus ? 2f : 1f;
                using var pen = new Pen(focus ? UiTheme.PrimaryBlue : IdleLine, thickness)
                {
                    StartCap = LineCap.Flat,
                    EndCap = LineCap.Flat
                };
                float y = host.Height - 1.5f * thickness;
                e.Graphics.DrawLine(pen, 0f, y, host.Width - 1f, y);
            }

            host.Paint += PaintLine;
            box.GotFocus += (_, _) => host.Invalidate();
            box.LostFocus += (_, _) => host.Invalidate();
            box.TextChanged += (_, _) => host.Invalidate();
            host.Resize += (_, _) => host.Invalidate();
        }

        public static void AttachUnderlineRow(Panel rowHost, params Control[] focusSources)
        {
            rowHost.BackColor = Color.White;

            void PaintLine(object? _, PaintEventArgs e)
            {
                bool focus = false;
                foreach (var c in focusSources)
                {
                    if (c is TextBox tb && tb.Focused)
                        focus = true;
                    if (c.Focused)
                        focus = true;
                }

                float thickness = focus ? 2f : 1f;
                using var pen = new Pen(focus ? UiTheme.PrimaryBlue : IdleLine, thickness)
                {
                    StartCap = LineCap.Flat,
                    EndCap = LineCap.Flat
                };
                float y = rowHost.Height - 1.5f * thickness;
                e.Graphics.DrawLine(pen, 0f, y, rowHost.Width - 1f, y);
            }

            rowHost.Paint += PaintLine;
            foreach (var c in focusSources)
            {
                c.GotFocus += (_, _) => rowHost.Invalidate();
                c.LostFocus += (_, _) => rowHost.Invalidate();
            }

            rowHost.Resize += (_, _) => rowHost.Invalidate();
        }
    }
}
