using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhoNhaHang.model;

namespace QuanLyKhoNhaHang.QLNhanVien
{
    public partial class FormTimKiemNV : Form
    {
        MyDBcontext db = new MyDBcontext();
        public FormTimKiemNV()
        {
            InitializeComponent();
        }
        void HienThi(List<NhanVien> dsNV)
        {
            listDsNV.Items.Clear();
            foreach (NhanVien nv in dsNV)
            {
                ListViewItem item = new ListViewItem(nv.MaNV.ToString());

                item.SubItems.Add(nv.HoTen);
                item.SubItems.Add(nv.NgaySinh.ToString());
                item.SubItems.Add(nv.DiaChi.ToString());
                item.SubItems.Add(nv.SDT.ToString());

                listDsNV.Items.Add(item);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            FormQLNhanVien f = new FormQLNhanVien();
            f.Show();
            this.Hide();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
            FormTimKiemNV_Load(sender, e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string hoten = textBox1.Text;
            if (hoten == "")
            {
                HienThi(db.NhanViens.ToList());
            }
            else
            {
                List<NhanVien> KetQua = db.NhanViens.Where(x => x.HoTen.ToUpper().Contains(hoten.ToUpper())).ToList();
                HienThi(KetQua);
            }
        }

        private void FormTimKiemNV_Load(object sender, EventArgs e)
        {
            List<NhanVien> DsNV = db.NhanViens.ToList();
            HienThi(DsNV);
        }
    }
}
