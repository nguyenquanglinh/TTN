using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKho.QLHangHoa
{
    public partial class FormSuaHH : Form
    {
        public FormSuaHH()
        {
            InitializeComponent();
        }

        private void FormSuaHH_Load(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                conn.Open();
                string sua = "update HangHoa set maHH ='" + txtMaHH.Text + "', tenHH='" + txtTenHH.Text + "', soluong='" + txtSoLuong.Text + "',maNCC='" + txtMaNCC.Text + "'";
                SqlCommand cmd = new SqlCommand(sua, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("lỗi , k sửa được !");
            }
            finally
            {
                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                conn.Close();

            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btTroLai_Click(object sender, EventArgs e)
        {

            FormQLHH f = new FormQLHH();
            f.Show();
            this.Hide();
        }
    }
}
