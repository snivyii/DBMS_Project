using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    public static class BoderRadius
    {
        public static void SetPanelBorderRadius(Panel panel, int borderRadius)
        {
            panel.BorderStyle = BorderStyle.None;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(panel.ClientRectangle.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(panel.ClientRectangle.Width - borderRadius, panel.ClientRectangle.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, panel.ClientRectangle.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            panel.Region = new Region(path);
        }
        public static void SetButtonBorderRadius(Button button, int borderRadius)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(button.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(button.Width - borderRadius, button.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, button.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            button.Region = new Region(path);
        }
        public static void SetTextBoxBorderRadius(TextBox textBox, int borderRadius)
        {
            textBox.BorderStyle = BorderStyle.None;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(textBox.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(textBox.Width - borderRadius, textBox.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, textBox.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            textBox.Region = new Region(path);
        }
    }
}
