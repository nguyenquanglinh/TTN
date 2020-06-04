using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho.XuatHang_QLphieuxuat_;
using QuanLyKho.XuatHang;
using System.Data.SqlClient;

namespace QuanLyKho.XuatHang_QLphieuxuat_
{
    public partial class FormXoaphieuxuat : Form
    {
        public FormXoaphieuxuat()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            FormXuatHang f = new FormXuatHang();
            f.Show();
            this.Hide();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
              
                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                conn.Open();
                string chitietphieunhap = "delete Chitietxuat where maPX='" + txtMaPhieuXuat.Text + "'";
                string xoaphieunhap = "delete PhieuXuat where maPX='" + txtMaPhieuXuat.Text + "'";
               
              
                SqlCommand cmdxoaphieunhap = new SqlCommand(xoaphieunhap, conn);
                SqlCommand cmdxoachitietphieuxuat = new SqlCommand(chitietphieunhap, conn);

                cmdxoachitietphieuxuat.ExecuteNonQuery();
                cmdxoaphieunhap.ExecuteNonQuery();    
                conn.Close();
            }
            catch
            {
                MessageBox.Show("lỗi , mã phiếu nhập không đúng !");

            }
            finally
            {
                
                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                conn.Close();
                MessageBox.Show("xóa thành công");

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMaPhieuXuat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
