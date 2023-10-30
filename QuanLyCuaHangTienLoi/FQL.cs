using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangTienLoi
{
    public partial class FQL : Form
    {
        BoGocForm bgform = new BoGocForm();
        public FQL()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(1)
            {
                Top = 0,
                Left = 0,
                Bottom = 0,
            };
            this.StartPosition = FormStartPosition.CenterScreen;
            SidePanel.Height = btnTrangChu.Height;
            SidePanel.Top = btnTrangChu.Top;
            ucTrangChuql1.BringToFront();

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                bgform.FormHelper(form, radius, graph, borderColor, borderSize);
            }
        }
        private void FQL_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, 20, e.Graphics, Color.FromArgb(241, 242, 246), 2);
        }

        private void FQL_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Flogin flogin = new Flogin();
            flogin.Show();
            this.Dispose();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTrangChu.Height;
            SidePanel.Top = btnTrangChu.Top;
            ucTrangChuql1.BringToFront();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTaiKhoan.Height;
            SidePanel.Top = btnTaiKhoan.Top;
        }

        private void btnChuyenKhoan_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnChuyenKhoan.Height;
            SidePanel.Top = btnChuyenKhoan.Top;
        }

        private void btnTKTK_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTKTK.Height;
            SidePanel.Top = btnTKTK.Top;
        }

        private void btnThongTinVay_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnThongTinVay.Height;
            SidePanel.Top = btnThongTinVay.Top;
        }

        private void btnTinDung_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTinDung.Height;
            SidePanel.Top = btnTinDung.Top;
        }

        private void btnLSGiaoDich_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnLSGiaoDich.Height;
            SidePanel.Top = btnLSGiaoDich.Top;
        }
    }
}
