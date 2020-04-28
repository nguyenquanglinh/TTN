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
    public partial class ThemHangHoa : Form
    {
        public HangHoa hh = new HangHoa();
        public ThemHangHoa()
        {
            InitializeComponent();
        }
        void NhapHH()
        {
            hh.TenHH = txtTenHangHoa.Text;
            hh.MaLoai = txtMaLoai.Text;
            hh.MaHH = txtMaHH.Text;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            NhapHH();
            if (hh.CheckHHNotNull())
            {
                MessageBox.Show("Đang tiến hành lưu.", "thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
