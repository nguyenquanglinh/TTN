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
    public partial class FormThemNV : Form
    {
        NhanVien nv = new NhanVien();

        public FormThemNV()
        {
            InitializeComponent();
        }
        private void KetNoi()
        {
            string cs = "data source =DESKTOP-VLM31NH\\SQLEXPRESS; database=QuanLyBanHangTapHoa;integrated security= SSPI;";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from NhanVien", conn);
            SqlDataAdapter com = new SqlDataAdapter(cmd);
            DataTable datatable = new DataTable();
            com.Fill(datatable);
            
        }
        public void ThemNV()
        {
            nv.TenNV = txtTenNV.Text;
            nv.MaNV = txtMaNV.Text;
            nv.Chucvu = txtChucVu.Text;
            nv.Luongthang = txtLuongThang.Text;
            nv.Gioitinh = txtGioiTinh.Text;
            nv.Namsinh = txtNamSinh.Text;
            nv.Quequan = txtQueQuan.Text;

        }

        string them;
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ThemNV();
                string cs = "data source =DESKTOP-VLM31NH\\SQLEXPRESS; database=QuanLyBanHangTapHoa;integrated security= SSPI;";
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                them="INSERT INTO NhanVien (MaNV,TenNV,QueQuan,NamSinh,ChucVu,LuongThang,GioiTinh) VALUES('"+nv.MaNV+ "','" + nv.TenNV + "','" + nv.Quequan + "','" + nv.Namsinh + "','" + nv.Chucvu + "','" + nv.Luongthang + "','" + nv.Gioitinh + "')";
                 
                SqlCommand cmdthem = new SqlCommand(them, conn);
                cmdthem.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Lỗi ! không thêm được");

            }
            finally
            {
                string cs = "data source =DESKTOP-VLM31NH\\SQLEXPRESS; database=QuanLyBanHangTapHoa;integrated security= SSPI;";
                SqlConnection conn = new SqlConnection(cs);
                MessageBox.Show("thêm thành công");
                conn.Close();
            }
           
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormQLNV f = new FormQLNV();
            f.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
