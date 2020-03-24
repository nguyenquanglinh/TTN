using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemNV();
            if (nv.CheckNVNotNull())
            {
                //thao tác thêm dữ liệu vào database

            }
            else
            {
                MessageBox.Show("vui lòng điền đầy đủ thông tin !");
            }
        }
    }
}
