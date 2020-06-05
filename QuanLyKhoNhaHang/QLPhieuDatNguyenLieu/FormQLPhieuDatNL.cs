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
using QuanLyKhoNhaHang.QLNguyenLieu;

namespace QuanLyKhoNhaHang.QLPhieuDatNguyenLieu
{
    public partial class FormQLPhieuDatNL : Form
    {
        MyDBcontext db = new MyDBcontext();
        public FormQLPhieuDatNL()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemPhieuDatNL f = new FormThemPhieuDatNL();
            f.Show();
            this.Hide();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain();
            f.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FormSuaPhieuDatNL f = new FormSuaPhieuDatNL();
            f.Show();
            this.Hide();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            FormXoaPhieuDatNL f = new FormXoaPhieuDatNL();
            f.Show();
            this.Hide();
        }

        private void FormQLPhieuDatNL_Load(object sender, EventArgs e)
        {
            List<PhieuDatNL> DS = db.PhieuDatNLs.ToList();
            foreach (PhieuDatNL nl in DS)
            {
                ListViewItem list = new ListViewItem(nl.MaPDNL.ToString());
            
                list.SubItems.Add(nl.NgayLap.ToString());
                list.SubItems.Add(nl.MaNCC.ToString());
                list.SubItems.Add(nl.MaNV.ToString());

                listView1.Items.Add(list);
            }
        }
    }
}
