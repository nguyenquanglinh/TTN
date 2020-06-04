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
    public partial class SuaThanNhan : Form
    {
        private string cMND;
        private DbAccess dbAccess;

        public SuaThanNhan()
        {
            InitializeComponent();
        }
        public SuaThanNhan(ThanNhan th)
        {
            txtCMND.Text = th.CMND;
            txtNamSinh.Text = th.NamSinh;
            txtNgayvao.Text = th.NgayVao;
            txtQuanHe.Text = th.QuanHe;
            txtTen.Text = th.Ten;
        }

        public SuaThanNhan(DbAccess dbAccess, string cMND):this()
        {
            this.dbAccess = dbAccess;
            this.cMND = cMND;
        }

        public ThanNhan ThanNhan { get; private set; }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTen.Text) && txtTen.Text.Length < 51)
            {
                if (!string.IsNullOrWhiteSpace(txtCMND.Text) && txtCMND.Text.Length < 16)
                {
                    if (!string.IsNullOrWhiteSpace(txtNgayvao.Text) && txtNgayvao.Text.Length < 50)
                    {
                        if (!string.IsNullOrWhiteSpace(txtQuanHe.Text) && txtQuanHe.Text.Length < 50)
                        {
                            string gt = cbNam.Checked == true ? "nam" : "nữ";
                            this.ThanNhan = new ThanNhan(txtTen.Text, txtCMND.Text, txtQuanHe.Text, txtNamSinh.Text, txtQueQuan.Text, txtNgayvao.Text, gt);
                            if (dbAccess.SuaThanNhan(ThanNhan,cMND)) MessageBox.Show("Thêm thành công");
                            else MessageBox.Show("Không thể thêm thông tin vui lòng kiểm tra lại dữ liệu");
                            this.Close();
                            return;
                        }
                    }
                }
            }
            MessageBox.Show("Không được để trống tên thân nhân,CMND,ngày vào và quan hệ với chủ hộ");
        }
    }
}
