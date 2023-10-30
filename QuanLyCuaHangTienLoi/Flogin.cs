using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QuanLyCuaHangTienLoi
{
    public partial class Flogin : Form
    {
        BoGocForm bgForm = new BoGocForm();
        DBConnection dbconn = new DBConnection();

        public Flogin()
        {
            InitializeComponent();
            BoderRadius.SetButtonBorderRadius(btnLogin, 40);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(1)
            {
                Top = 0,
                Left = 0,
                Bottom = 0,
            };
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public bool IsEmailValid(string email)
        {
            int isValid = 0;
            try
            {
                dbconn.openConnection();
                using (SqlCommand cmd = new SqlCommand("SELECT [dbo].[func_IsEmailValid](@Email) AS IsValid", dbconn.getConnection))
                {
                    cmd.Parameters.Add(new SqlParameter("@Email", email));
                    isValid = (int)cmd.ExecuteScalar();
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
            return isValid == 1;

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền cả email và mật khẩu.");
                return;
            }

            if (IsEmailValid(email))
            {

                try
                {
                    dbconn.openConnection();
                    SqlCommand cmd = new SqlCommand("pd_CheckLogin", dbconn.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Email", email));
                    cmd.Parameters.Add(new SqlParameter("@Password", password));

                    var loginresult = cmd.ExecuteScalar();

                    if (loginresult != null && loginresult.ToString() == "Success")
                    {
                        if (rbNVHH.Checked)
                        {
                            FNVHH fnvhh = new FNVHH();
                            fnvhh.Show();
                            this.Hide();
                        }
                        else if (rbNVTN.Checked)
                        {
                            FNVTN fnvn = new FNVTN();
                            fnvn.Show();
                            this.Hide();
                        }
                        else if (rbQuanLy.Checked)
                        {
                            FQL fql = new FQL();
                            fql.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email hoặc mật khẩu không đúng.");
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
            else
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng kiểm tra lại.");
            }
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

        private void Flogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Flogin_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, 20, e.Graphics, Color.FromArgb(241, 242, 246), 2);
        }

        private void btnThoatFlogin_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void nhanVienHH()
        {

        }
    }
}