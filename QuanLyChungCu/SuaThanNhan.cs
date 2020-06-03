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
        public ThanNhan ThanNhan { get; private set; }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
