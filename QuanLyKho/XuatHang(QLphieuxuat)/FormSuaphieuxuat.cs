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
using QuanLyKho.XuatHang;
using QuanLyKho.XuatHang_QLphieuxuat_;

namespace QuanLyKho.XuatHang_QLphieuxuat_
{
    public partial class FormSuaphieuxuat : Form
    {
        public FormSuaphieuxuat()
        {
            InitializeComponent();
        }

        private void FormSuaphieuxuat_Load(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
               
                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                conn.Open();
                string sua = "update PhieuXuat set maPX ='" + txtMaPXcansua.Text + "', ngayXuat='" + txtNgayXuat.Text + "',tongTien='" + txtTongTien.Text + "'";
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
                string sua = "update Chitietxuat  set maCTX ='" + txtMaChiTietPhieuXuatcansua.Text + "', soLuong='" + txtSoLuong.Text + "',donGia='" + txtDonGia.Text + "'";
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

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormXuatHang f = new FormXuatHang();
            f.Show();
            this.Hide();  
                }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMaChiTietPhieuXuatcansua_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgayXuat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaPXcansua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
