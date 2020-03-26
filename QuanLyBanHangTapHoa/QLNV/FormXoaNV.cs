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

namespace QuanLyBanHangTapHoa.QLNV
{
    public partial class FormXoaNV : Form
    {
        public FormXoaNV()
        {
            InitializeComponent();
        }

        private void FormXoaNV_Load(object sender, EventArgs e)
        {

        }
        string xoakho;
        string xoaphieunhap;
        string xoaphieuxuat;
        string xoanhanvien;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = "data source =DESKTOP-VLM31NH\\SQLEXPRESS; database=QuanLyBanHangTapHoa;integrated security= SSPI;";
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                xoakho = "delete Kho where MaNV='" + txtMaNVXoa.Text + "'";
                xoaphieunhap = "delete PhieuNhap where MaNV='" + txtMaNVXoa.Text + "'";
                xoaphieuxuat = "delete Phieuxuat where MaNV='" + txtMaNVXoa.Text + "'";
                xoanhanvien = "delete NhanVien where MaNV='" + txtMaNVXoa.Text + "'";
                SqlCommand cmdxoakho = new SqlCommand(xoakho, conn);
                SqlCommand cmdxoaphieunhap = new SqlCommand(xoaphieunhap, conn);
                SqlCommand cmdxoaphieuxuat = new SqlCommand(xoaphieuxuat, conn);
                SqlCommand cmdxoanhanvien = new SqlCommand(xoanhanvien, conn);
                cmdxoakho.ExecuteNonQuery();
                cmdxoaphieunhap.ExecuteNonQuery();
                cmdxoaphieuxuat.ExecuteNonQuery();
                cmdxoanhanvien.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("lỗi , mã nhân viên không đúng !");

            }
            finally
            {
                string cs = "data source =DESKTOP-VLM31NH\\SQLEXPRESS; database=QuanLyBanHangTapHoa;integrated security= SSPI;";
                SqlConnection conn = new SqlConnection(cs);
                conn.Close();
                MessageBox.Show("xóa thành công");

            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormQLNV f = new FormQLNV();
            f.Show();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
