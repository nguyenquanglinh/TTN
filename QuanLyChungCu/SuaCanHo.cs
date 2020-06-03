using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChungCu
{
    public partial class SuaCanHo : Form
    {
        public CanHo CanHo { get; private set; }

        public SuaCanHo()
        {
            InitializeComponent();
        }
        void SetCanHo(CanHo s)
        {
            txtTen.Text = s.Ten;
            txtCMND.Text = s.CMND;
            txtTang.Text = s.Tang;
            txtPhong.Text = s.Phong;
            txtNgayvao.Text = s.NgayVao;
            cbNam.Checked = s.GT == "nam" ? true : false;
            txtQueQuan.Text = s.QueQuan;
            txtNamSinh.Text = s.NamSinh;

        }
        public SuaCanHo(CanHo s) : this()
        {
            SetCanHo(s);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTen.Text) && txtTen.Text.Length < 50)
            {
                if (!string.IsNullOrWhiteSpace(txtCMND.Text) && txtCMND.Text.Length <= 15)
                {
                    if (!string.IsNullOrWhiteSpace(txtTang.Text) && txtTang.Text.Length < 50)
                    {
                        if (!string.IsNullOrWhiteSpace(txtPhong.Text) && txtPhong.Text.Length < 50)
                        {
                            if (!string.IsNullOrWhiteSpace(txtNgayvao.Text) && txtNgayvao.Text.Length < 50)
                            {
                                string gt = cbNam.Checked == true ? "nam" : "nữ";
                                this.CanHo = new CanHo(txtTen.Text, txtCMND.Text, txtTang.Text, txtPhong.Text, txtNgayvao.Text, gt, txtQueQuan.Text, txtNamSinh.Text);
                                MessageBox.Show("đã lưu tạm thời thông tin người dùng căn hộ");
                                this.Close();
                            }
                        }
                    }
                }
            }
        }
    }
}
