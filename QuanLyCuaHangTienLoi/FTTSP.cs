using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangTienLoi
{
    public partial class FTTSP : Form
    {
        BoGocForm bgForm = new BoGocForm();
        DBConnection dbconn = new DBConnection();
        public FTTSP()
        {
            InitializeComponent();
            HienThiTinhTrangAnhHuong();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
                bgForm.FormHelper(form, radius, graph, borderColor, borderSize);
        }

        private void ThemTTSP_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ThemTTSP_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, 20, e.Graphics, Color.FromArgb(241, 242, 246), 2);
        }

        public void HienThiTinhTrangAnhHuong()
        {
            try
            {
                dbconn.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM view_AnhHuong", dbconn.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                gvTinhTrangAH.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbconn.closeConnection();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnThemTTSP_Click(object sender, EventArgs e)
        {
            try
            {
                dbconn.openConnection();
                SqlCommand cmd = new SqlCommand("InsertAnhHuong", dbconn.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaTinhTrang", txtMaTinhTrang.Text);
                cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text);
                cmd.Parameters.AddWithValue("@SoLuongAnhHuong", int.Parse(txtSoLuongAnhHuong.Text));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbconn.closeConnection();
            }
            HienThiTinhTrangAnhHuong();
        }

        private void gvTinhTrangAH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = gvTinhTrangAH.Rows[e.RowIndex];
                txtMaSP.Text = row.Cells[1].Value.ToString();
                txtMaTinhTrang.Text = row.Cells[0].Value.ToString();
                txtSoLuongAnhHuong.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnXoaTTSP_Click(object sender, EventArgs e)
        {
            try
            {
                dbconn.openConnection();
                SqlCommand cmd = new SqlCommand("DeleteAnhHuong", dbconn.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaTinhTrang", txtMaTinhTrang.Text);
                cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbconn.closeConnection();
            }
            HienThiTinhTrangAnhHuong();
        }

        private void btnSuaTTSP_Click(object sender, EventArgs e)
        {
            try
            {
                dbconn.openConnection();
                SqlCommand cmd = new SqlCommand("UpdateAnhHuong", dbconn.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaTinhTrang", txtMaTinhTrang.Text);
                cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text);
                cmd.Parameters.AddWithValue("@SoLuongAnhHuong", int.Parse(txtSoLuongAnhHuong.Text)); ;
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
            finally
            {
                dbconn.closeConnection();
            }
            HienThiTinhTrangAnhHuong();
        }
    }
}
