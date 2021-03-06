﻿using System.Windows.Forms;

namespace QuanLyBanHangTapHoa
{
    public partial class Form1 : Form
    {
        DbAccess dbAccess = new DbAccess();
        public Form1()
        {
            InitializeComponent();
            try
            {
                var x = new DangNhap(dbAccess);
                x.ShowDialog();
                this.User = x.GetUser;
                if (this.User == null)
                {
                    MessageBox.Show("Bạn cần phải đăng nhập", "Cảnh báo", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    ThongTin.Text = User.ToString();
                }
            }
            catch
            {
            }
        }
        public User User { get; }

        private void btnHH_Click(object sender, System.EventArgs e)
        {
            new HangHoaMng(dbAccess).ShowDialog();
        }

        private void btnHDX_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Thành viên chưa hoàn thành");

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            new LoaiHangHoaMng(dbAccess).ShowDialog();
        }

        private void btnNV_Click(object sender, System.EventArgs e)
        {
            new QLNV.FormQLNV().ShowDialog();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Thành viên chưa hoàn thành");
        }

        private void btnHDN_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Thành viên chưa hoàn thành");

        }
    }
}
