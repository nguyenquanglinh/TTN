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
        private DbAccess dbAccess;
        private CanHo s;

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
            this.s = s;
            SetCanHo(s);
        }

        public SuaCanHo(CanHo s, DbAccess dbAccess) : this(s)
        {
            this.dbAccess = dbAccess;
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
                                if (dbAccess.SuaCanHo(CanHo, s.CMND)) MessageBox.Show("Thêm thành công");
                                else MessageBox.Show("Không thể thêm thông tin vui lòng kiểm tra lại dữ liệu");
                                this.Close();
                            }
                        }
                    }
                }
            }
        }
    }
}
