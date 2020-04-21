using System;
using System.Windows.Forms;
using QuanLyKho.XuatHang;
using QuanLyKho.QLHangHoa;
using QuanLyKho.ThongKe;

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

        private void btnQLHanghoa_Click(object sender, EventArgs e)
        {
            FormQLHH f = new FormQLHH();
            f.Show();
            this.Hide();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FormThongKe f = new FormThongKe();
            f.Show();
            this.Hide();
        }
    }
}
