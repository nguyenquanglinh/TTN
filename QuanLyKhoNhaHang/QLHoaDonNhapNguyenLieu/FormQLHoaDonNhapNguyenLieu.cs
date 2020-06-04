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
using QuanLyKhoNhaHang.model;

namespace QuanLyKhoNhaHang.QLHoaDonNhapNguyenLieu
{
    public partial class FormQLHoaDonNhapNguyenLieu : Form
    {
        MyDBcontext db = new MyDBcontext();
        public FormQLHoaDonNhapNguyenLieu()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter[] idparam =
                {
                    new SqlParameter { ParameterName = "MaHDN", Value = int.Parse(txtMaHDN.Text) },
                    new SqlParameter { ParameterName = "MaPDNL", Value = int.Parse(txtMaPhieuDatNL.Text)},
                    new SqlParameter { ParameterName = "NgayLap", Value = dateTimePicker1.Value },
                    new SqlParameter { ParameterName = "MaNV", Value = int.Parse(comboBoxMaNV.Text)}

                };
                db.Database.ExecuteSqlCommand("themhdn @mahdn ,@mapdnl , @ngaylap , @manv ", idparam);
                db.SaveChanges();
                MessageBox.Show("them thanh cong");
                listHoaDon.Items.Clear();
                show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Them That bai. Chi tiet loi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDonNhapNL hd = db.HoaDonNhapNLs.Find(int.Parse(txtMaHDN.Text));
                hd.MaPDNL = int.Parse(txtMaPhieuDatNL.Text);
                hd.NgayLap = dateTimePicker1.Value;
                hd.MaNV = int.Parse(comboBoxMaNV.Text);

                SqlParameter[] idparam =
                {
                    new SqlParameter { ParameterName = "MaHDN", Value = int.Parse(txtMaHDN.Text) },
                    new SqlParameter { ParameterName = "MaPDNL", Value = int.Parse(txtMaPhieuDatNL.Text)},
                    new SqlParameter { ParameterName = "NgayLap", Value = dateTimePicker1.Value},
                    new SqlParameter { ParameterName = "MaNV", Value = int.Parse(comboBoxMaNV.Text)},

                };
                db.Database.ExecuteSqlCommand("suahdn @mahdn ,@mapdnl , @ngaylap , @manv ", idparam);
                db.SaveChanges();
                MessageBox.Show("Sua thanh cong");
                listHoaDon.Items.Clear();
                show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sua that bai. Chi tiet loi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter idparam = new SqlParameter { ParameterName = "MaHDN", Value = int.Parse(txtMaHDN.Text) };
                db.Database.ExecuteSqlCommand("xoahdn @mahdn", idparam);
                db.SaveChanges();
                MessageBox.Show("Xóa thanh cong");
                listHoaDon.Items.Clear();
                show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
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

        private void FormQLHoaDonNhapNguyenLieu_Load(object sender, EventArgs e)
        {
            show();
        }
        private void show()
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

        private void listHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listHoaDon.SelectedItems.Count > 0)
            {
                ListViewItem itemSelected = listHoaDon.SelectedItems[0];
                txtMaHDN.Text = itemSelected.SubItems[0].Text;
                txtMaPhieuDatNL.Text = itemSelected.SubItems[1].Text;
                dateTimePicker1.Text = itemSelected.SubItems[2].Text;
                comboBoxMaNV.Text = itemSelected.SubItems[3].Text;
                
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            //FormTimKiemHoaDon f = new FormTimKiemHoaDon();
            //f.Show();
            //this.Hide();
        }
    }
}
