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
    public partial class ThemThanNhan : Form
    {
        private DbAccess dbAccess;
        private string cMND;

        public ThemThanNhan()
        {
            InitializeComponent();
        }

        public ThemThanNhan(DbAccess dbAccess):this()
        {
            this.dbAccess = dbAccess;
        }

        public ThemThanNhan(DbAccess dbAccess, string cMND) : this(dbAccess)
        {
            this.cMND = cMND;
        }

        public ThanNhan ThanNhan { get; private set; }

        private void btnThem_Click(object sender, EventArgs e)
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
                            if (dbAccess.ThemThanNhan(ThanNhan, cMND)) MessageBox.Show("Thêm thành công");
                            else MessageBox.Show("Không thể thêm thông tin vui lòng kiểm tra lại dữ liệu");
                            this.Close();
                            return;
                        }
                    }
                }
            }
            MessageBox.Show("Không được để trống tên thân nhân,CMND,ngày vào và quan hệ với chủ hộ");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNamSinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtQuanHe_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNgayvao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtQueQuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
