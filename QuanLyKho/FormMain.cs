using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho.XuatHang_QLphieuxuat_;
using QuanLyKho.XuatHang;

namespace QuanLyKho
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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
    }
}
