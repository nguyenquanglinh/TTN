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
    public partial class SuaLoaiHH : Form
    {
        public SuaLoaiHH()
        {
            InitializeComponent();
        }
        public LoaiHH lhh = new LoaiHH();
        public SuaLoaiHH(LoaiHH lhh) : this()
        {
            txtMaLoai.Text = lhh.MaLoai;
            txtTenLoai.Text = lhh.TenLoai;
        }
        void NhapLHH()
        {
            lhh.TenLoai = txtTenLoai.Text;
            lhh.MaLoai = txtMaLoai.Text;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            NhapLHH();
            if (lhh.CheckLoaiHHIsNotNull())
                MessageBox.Show("Sửa xong thông tin loại hàng hóa. Lưu lại", "thông báo", MessageBoxButtons.OK);

        }
    }
}
