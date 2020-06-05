using QuanLyKhoNhaHang.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoNhaHang.QLHoaDonNhapNguyenLieu
{
    public partial class FormTimKiemHoaDon : Form
    {
        MyDBcontext db = new MyDBcontext();
        public FormTimKiemHoaDon()
        {
            InitializeComponent();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            FormQLHoaDonNhapNguyenLieu f = new FormQLHoaDonNhapNguyenLieu();
            f.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMaHDN_MouseClick(object sender, MouseEventArgs e)
        {
            listHoaDon.Items.Clear();
            FormTimKiemHoaDon_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlParameter idparam = new SqlParameter { ParameterName = "MaHDN", Value = int.Parse(txtMaHDN.Text) };
                db.Database.ExecuteSqlCommand("timhdn @mahdn", idparam);
                db.SaveChanges();
                MessageBox.Show("Kết quả tìm");
                listHoaDon.Items.Clear();
                FormTimKiemHoaDon_Load(sender, e);
            }
            catch
            {
                //MessageBox.Show("" + ex.Message);
            }

        }
        private void show(List<HoaDonNhapNL> mahd)
        {
            List<HoaDonNhapNL> DSHoaDon = db.HoaDonNhapNLs.ToList();
            foreach (HoaDonNhapNL hd in DSHoaDon)
            {
                ListViewItem list = new ListViewItem(hd.MaHDN.ToString());
                list.SubItems.Add(hd.MaPDNL.ToString());
                list.SubItems.Add(hd.NgayLap.ToString());
                list.SubItems.Add(hd.MaNV.ToString());

                listHoaDon.Items.Add(list);
            }
        }

        private void FormTimKiemHoaDon_Load(object sender, EventArgs e)
        {
            List<HoaDonNhapNL> mahdn = db.HoaDonNhapNLs.ToList();
            show(mahdn);
        }

    }
}
