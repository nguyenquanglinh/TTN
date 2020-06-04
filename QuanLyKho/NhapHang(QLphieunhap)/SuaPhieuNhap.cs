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

namespace QuanLyKho
{
    public partial class SuaPhieuNhap : Form
    {
        public SuaPhieuNhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                conn.Open();
                string sua = "update PhieuNhap set maPN ='" + txtMaPXcansua.Text + "', ngayNhap='" + txtNgayXuat.Text + "',tongTien='" + txtTongTien.Text + "'";
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
                MessageBox.Show("sửa thành công");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                conn.Open();
                string sua = "update Chitietnhap  set maCTN ='" + txtMaChiTietPhieuXuatcansua.Text + "', soLuong='" + txtSoLuong.Text + "',donGia='" + txtDonGia.Text + "'";
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
                MessageBox.Show("sửa thành công");
            }
        }
    }
}
