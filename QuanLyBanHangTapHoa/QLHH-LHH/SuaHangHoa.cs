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
    public partial class SuaHangHoa : Form
    {
        public SuaHangHoa()
        {
            InitializeComponent();
        }
        public HangHoa hh { get; }

        void NhapHH()
        {
            hh.TenHH = txtTenHangHoa.Text;
            hh.MaLoai = txtMaLoai.Text;
            hh.MaHH = txtMaHH.Text;
        }

        public SuaHangHoa(HangHoa hh):this()
        {
            this.txtTenHangHoa.Text = hh.TenHH;
            this.txtMaHH.Text = hh.MaHH;
            this.txtMaLoai.Text = hh.MaLoai;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhapHH();
            if (hh.CheckHHNotNull())
                MessageBox.Show("Sửa xong thông tin hàng hóa. Lưu lại", "thông báo", MessageBoxButtons.OK);

        }
    }
}
