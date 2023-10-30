using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangTienLoi
{
    public partial class UCSanPhamNVHH : UserControl
    {
        DBConnection dbconn = new DBConnection();
        public UCSanPhamNVHH()
        {
            InitializeComponent();
            gvDSSanPham.RowTemplate.Height = 60 + 15 * gvDSSanPham.RowTemplate.Index;
            HienThiDanhSachSanPham();
            HienThiDanhSachSanPhamTrungBay();
        }
        public void HienThiDanhSachSanPham()
        {

            try
            {
                dbconn.openConnection();

                SqlCommand cmd = new SqlCommand("SELECT * FROM view_DanhSachSanPham", dbconn.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                gvDSSanPham.DataSource = dataTable;

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
        public void HienThiDanhSachSanPhamTrungBay()
        {
            try
            {
                dbconn.openConnection();

                SqlCommand cmd = new SqlCommand("SELECT * FROM view_ThongTinSanPhamTrungBay", dbconn.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                gvSPTrungBay.DataSource = dataTable;

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

        private void btnTimKiemKho_Click(object sender, EventArgs e)
        {
            try
            {
                dbconn.openConnection();
                SqlCommand cmd = new SqlCommand("GetDanhSachSanPhamTrongKho", dbconn.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenKho", SqlDbType.NVarChar, 255)).Value = txtTimKiemKho.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                gvSPKho.DataSource = dataTable;
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

        private void gvDSSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = gvDSSanPham.Rows[e.RowIndex];
                txtMaSP2.Text = row.Cells[0].Value.ToString();
                txtMaSP.Text = row.Cells[0].Value.ToString();
                txtTenSP.Text = row.Cells[1].Value.ToString();
                txtDonGia.Text = row.Cells[2].Value.ToString();
                txtMucGiamGIa.Text = row.Cells[3].Value.ToString();
                txtMaLoaiSP.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnTraCuu2_Click(object sender, EventArgs e)
        {
            try
            {
                dbconn.openConnection();
                SqlCommand cmd = new SqlCommand("GetTinhTrangSanPham", dbconn.getConnection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaSP", SqlDbType.VarChar, 10)).Value = txtMaSP2.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    gvTinhTrang.DataSource = dataTable;
                }
                else
                {
                    gvTinhTrang.DataSource = null;
                    MessageBox.Show("Không tìm thấy thông tin");
                }
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

        private void btnThaoTacTTSP_Click(object sender, EventArgs e)
        {
            FTTSP themTTSP = new FTTSP();
            themTTSP.Show();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            try
            {
                dbconn.openConnection();
                SqlCommand cmd = new SqlCommand("InsertSanPham", dbconn.getConnection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text);
                cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text);
                cmd.Parameters.AddWithValue("@DonGia", txtDonGia.Text);
                cmd.Parameters.AddWithValue("@MucGiamGia", txtMucGiamGIa.Text);
                cmd.Parameters.AddWithValue("@MaLoaiSP", txtMaLoaiSP.Text);

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
            HienThiDanhSachSanPham();
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            try
            {
                dbconn.openConnection();
                SqlCommand cmd = new SqlCommand("UpdateSanPham", dbconn.getConnection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text);
                cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text);
                cmd.Parameters.AddWithValue("@DonGia", txtDonGia.Text);
                cmd.Parameters.AddWithValue("@MucGiamGia", txtMucGiamGIa.Text);
                cmd.Parameters.AddWithValue("@MaLoaiSP", txtMaLoaiSP.Text);

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
            HienThiDanhSachSanPham();
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                dbconn.openConnection();
                SqlCommand cmd = new SqlCommand("DeleteSanPham", dbconn.getConnection);

                cmd.CommandType = CommandType.StoredProcedure;

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
            HienThiDanhSachSanPham();
        }

        private void gvSPTrungBay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = gvSPTrungBay.Rows[e.RowIndex];
                txtTenViTri.Text = row.Cells[5].Value.ToString();
                txtSoThuTuNganKe.Text = row.Cells[6].Value.ToString();
                txtSoLuongToiDa.Text = row.Cells[7].Value.ToString();
                txtMaSP3.Text = row.Cells[0].Value.ToString();
                txtSLTrungBay.Text = row.Cells[8].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                dbconn.openConnection();
                SqlCommand cmd = new SqlCommand("ThemViTriTrungBay", dbconn.getConnection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaViTri", txtMaViTri.Text);
                cmd.Parameters.AddWithValue("@TenViTri", txtTenViTri.Text);
                cmd.Parameters.AddWithValue("@SoThuTuNganKe", txtSoThuTuNganKe.Text);
                cmd.Parameters.AddWithValue("@SoLuongToiDa", int.Parse(txtSoLuongToiDa.Text));
                cmd.Parameters.AddWithValue("@MaSP", txtMaSP3.Text);
                cmd.Parameters.AddWithValue("@SoLuongTrungBay", int.Parse(txtSLTrungBay.Text));

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
            HienThiDanhSachSanPhamTrungBay();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                dbconn.openConnection();
                SqlCommand cmd = new SqlCommand("XoaViTriTrungBay", dbconn.getConnection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaViTri", txtMaViTri.Text);

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
            HienThiDanhSachSanPhamTrungBay();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                dbconn.openConnection();
                SqlCommand cmd = new SqlCommand("SuaViTriTrungBay", dbconn.getConnection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaViTri", txtMaViTri.Text);
                cmd.Parameters.AddWithValue("@TenViTri", txtTenViTri.Text);
                cmd.Parameters.AddWithValue("@SoThuTuNganKe", txtSoThuTuNganKe.Text);
                cmd.Parameters.AddWithValue("@SoLuongToiDa", int.Parse(txtSoLuongToiDa.Text));
                cmd.Parameters.AddWithValue("@MaSP", txtMaSP3.Text);
                cmd.Parameters.AddWithValue("@SoLuongTrungBay", int.Parse(txtSLTrungBay.Text));

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
            HienThiDanhSachSanPhamTrungBay();
        }
    }
}
