using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    public class BoGocForm
    {
        private int borderRadius = 20;
        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void DrawPath(Rectangle rect, Graphics graph, Color color)
        {
            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }
        public void FormHelper(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {

            using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, borderSize))
            using (Matrix transform = new Matrix())
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                form.Region = new Region(roundPath);
                if (borderSize >= 1)
                {
                    Rectangle rect = form.ClientRectangle;
                    float scaleX = 1.0F - (borderSize + 1) / rect.Width;
                    float scaleY = 1.0F - (borderSize + 1) / rect.Height;

                    transform.Scale(scaleX, scaleY);
                    transform.Translate(borderSize / 1.6F, borderSize / 1.6F);

                    graph.Transform = transform;
                    graph.DrawPath(penBorder, roundPath);
                }
            }

        }
        private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
        {
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }
    }
}
