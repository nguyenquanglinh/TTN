using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class ThemPhieuNhap : Form
    {
        public ConnectionString Cs { get; private set; }

        public ThemPhieuNhap()
        {
            InitializeComponent();
        }
        public ThemPhieuNhap(ConnectionString cs) : this()
        {
            this.Cs = cs;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string queryThem = "INSERT INTO PhieuNhap (maPN,ngayNhap ,tongTien) VALUES('" + txtMaPX.Text + "','" + txtNgayXuat.Text + "','" + txtTongTien.Text + "')";
            if (Cs.RunQuery(queryThem))
            {
                MessageBox.Show("Thêm phiếu nhập thành công");
            }
            else MessageBox.Show("Thêm phiếu nhập không thành công");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if ((txtMaPhieuXuat2.Text == "") || (txtMaChiTietPhieuXuat.Text == ""))
            //{
            //    MessageBox.Show("Xin hãy Điền Đủ Thông Tin", "Thông Báo");
            //    return;
            //}
            //else
            //{
            //    string them = "INSERT INTO Chitietxuat (maCTX,MaPX ,maHH,soLuong,donGia) VALUES('" + txtMaChiTietPhieuXuat.Text + "','" + txtMaPhieuXuat2.Text + "','" + txtMaHH.Text + "','" + txtSoLuong.Text + "','" + txtDonGia.Text + "')";
            //    if (Cs.RunQuery(them))
            //    {
            //        MessageBox.Show("thêm thành công !");
            //    }
            //    else MessageBox.Show("Lỗi ! không thêm được");

            //}
        }

        private void ThemPhieuNhap_Load(object sender, EventArgs e)
        {

        }
    }
}