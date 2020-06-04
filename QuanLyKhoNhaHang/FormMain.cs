using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhoNhaHang.model;
using QuanLyKhoNhaHang.QLHoaDonNhapNguyenLieu;
using QuanLyKhoNhaHang.QLNguyenLieu;
using QuanLyKhoNhaHang.QLPhieuDatNguyenLieu;
using QuanLyKhoNhaHang.QLPhieuThongKe;
using QuanLyKhoNhaHang.QLNhaCungCap;
using QuanLyKhoNhaHang.QLNhanVien;

namespace QuanLyKhoNhaHang
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQLNguyenLieu_Click(object sender, EventArgs e)
        {
            FormQLNguyenLieu f = new FormQLNguyenLieu();
            f.Show();
            this.Hide();
        }

        private void btnQLPhieuDatNL_Click(object sender, EventArgs e)
        {
            FormQLPhieuDatNL f = new FormQLPhieuDatNL();
            f.Show();
            this.Hide();
        }

        private void btnQLHoaDonNhap_Click(object sender, EventArgs e)
        {
            FormQLHoaDonNhapNguyenLieu f = new FormQLHoaDonNhapNguyenLieu();
            f.Show();
            this.Hide();
        }

        private void btnQLphieuThongKe_Click(object sender, EventArgs e)
        {
            FormQLPhieuThongKe f = new FormQLPhieuThongKe();
            f.Show();
            this.Hide();
        }

        private void btnQLNCC_Click(object sender, EventArgs e)
        {
            FormQLNCC f = new FormQLNCC();
            f.Show();
            this.Hide();
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            FormQLNhanVien f = new FormQLNhanVien();
            f.Show();
            this.Hide();
        }
    }
}
