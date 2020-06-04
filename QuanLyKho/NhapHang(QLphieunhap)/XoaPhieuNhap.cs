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
    public partial class XoaPhieuNhap : Form
    {
        public XoaPhieuNhap()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                conn.Open();
                string chitietphieunhap = "delete Chitietnhap where maPN='" + txtMaPhieuXuat.Text + "'";
                string xoaphieunhap = "delete PhieuNhap where maPN='" + txtMaPhieuXuat.Text + "'";


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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
