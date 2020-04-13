using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangTapHoa
{
    public partial class ThemLoaiHH : Form
    {
        public ThemLoaiHH()
        {
            InitializeComponent();
        }
        public LoaiHH lhh = new LoaiHH();
        void NhapHH()
        {
            lhh.TenLoai = txtTenLoai.Text;
            lhh.MaLoai = txtMaLoai.Text;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            NhapHH();
            if (lhh.CheckLoaiHHIsNotNull())
                MessageBox.Show("Nhập xong thông tin hàng hóa. Lưu lại", "thông báo", MessageBoxButtons.OK);
        }
    }
}
