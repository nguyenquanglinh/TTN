using System;
using System.Windows.Forms;
using QuanLyKho.XuatHang;

namespace QuanLyKho
{
    public partial class FormMain : Form
    {
        private ConnectionString connet;

        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(ConnectionString connet):this()
        {
            this.connet = connet;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            FormXuatHang f = new FormXuatHang();
            f.Show();
            this.Hide();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            new QuanLyPhieuNhap(connet).ShowDialog();
        }
    }
}
