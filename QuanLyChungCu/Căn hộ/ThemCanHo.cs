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
    public partial class ThemCanHo : Form
    {
        private DbAccess dbAccess;

        public ThemCanHo()
        {
            InitializeComponent();
        }

        public ThemCanHo(DbAccess dbAccess):this()
        {
            this.dbAccess = dbAccess;
        }

        public CanHo GetCanHo { get; set; }        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtTen.Text) && txtTen.Text.Length < 50)
            {
                if(!string.IsNullOrWhiteSpace(txtCMND.Text) && txtCMND.Text.Length <= 15)
                {
                    if (!string.IsNullOrWhiteSpace(txtTang.Text) && txtTang.Text.Length < 50)
                    {
                        if (!string.IsNullOrWhiteSpace(txtPhong.Text) && txtPhong.Text.Length < 50)
                        {
                            if (!string.IsNullOrWhiteSpace(txtNgayvao.Text) && txtNgayvao.Text.Length < 50)
                            {
                                string gt = cbNam.Checked == true ? "nam" : "nữ";
                               this.GetCanHo= new CanHo(txtTen.Text, txtCMND.Text, txtTang.Text, txtPhong.Text, txtNgayvao.Text, gt, txtQueQuan.Text, txtNamSinh.Text);
                                if (dbAccess.ThemCanHo(GetCanHo)) MessageBox.Show("Thêm thành công");
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
