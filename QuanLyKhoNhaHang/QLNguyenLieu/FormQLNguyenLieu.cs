using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhoNhaHang.QLNguyenLieu;
using QuanLyKhoNhaHang.model;
using System.Data.SqlClient;

namespace QuanLyKhoNhaHang.QLNguyenLieu
{
    public partial class FormQLNguyenLieu : Form
    {
        MyDBcontext db = new MyDBcontext();
        public FormQLNguyenLieu()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter[] idparam =
                {
                    new SqlParameter { ParameterName = "MaNL", Value = int.Parse(txtMaNL.Text) },
                    new SqlParameter { ParameterName = "TenNL", Value = txtTenNL.Text},
                    new SqlParameter { ParameterName = "GiaTien", Value = int.Parse(txtGiaTien.Text)},
                    new SqlParameter { ParameterName = "SoLuong", Value = float.Parse(txtSoLuong.Text)},
                   
                };
                db.Database.ExecuteSqlCommand("Themnl @manl ,@tennl ,@giatien,@soluong", idparam);
                db.SaveChanges();
                MessageBox.Show("them thanh cong");
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
                NguyenLieu nv = db.NguyenLieux.Find(int.Parse(txtMaNL.Text));
                nv.TenNL = txtTenNL.Text;
                nv.GiaTien = int.Parse(txtGiaTien.Text);
                nv.SoLuong = float.Parse(txtSoLuong.Text);

                SqlParameter[] idparam =
                {
                    new SqlParameter { ParameterName = "MaNL", Value = int.Parse(txtMaNL.Text) },
                    new SqlParameter { ParameterName = "TenNL", Value = txtTenNL.Text},
                    new SqlParameter { ParameterName = "GiaTien", Value = int.Parse(txtGiaTien.Text)},
                    new SqlParameter { ParameterName = "SoLuong", Value = float.Parse(txtSoLuong.Text)},

                };
                db.Database.ExecuteSqlCommand("suanl @manl , @tennl , @giatien , @soluong ", idparam);
                db.SaveChanges();
                MessageBox.Show("Sua thanh cong");
                show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter idparam = new SqlParameter { ParameterName = "MaNL", Value = int.Parse(txtMaNL.Text) };
                db.Database.ExecuteSqlCommand("xoanl @manl", idparam);
                db.SaveChanges();
                MessageBox.Show("Xóa thanh cong");
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

        private void FormQLNguyenLieu_Load(object sender, EventArgs e)
        {
            show();


        }
        private void show()
        {

            listViewDsNL.Items.Clear();
            List<NguyenLieu> DS = db.NguyenLieux.ToList();
            foreach (NguyenLieu nl in DS)
            {
                ListViewItem list = new ListViewItem(nl.MaNL.ToString());
                list.SubItems.Add(nl.TenNL.ToString());
                list.SubItems.Add(nl.GiaTien.ToString());
                list.SubItems.Add(nl.SoLuong.ToString());
             


                listViewDsNL.Items.Add(list);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDsNL.SelectedItems.Count > 0)
            {
                ListViewItem itemSelected = listViewDsNL.SelectedItems[0];
                txtMaNL.Text = itemSelected.SubItems[0].Text;
                txtTenNL.Text = itemSelected.SubItems[1].Text;
                txtGiaTien.Text = itemSelected.SubItems[2].Text;
                txtSoLuong.Text = itemSelected.SubItems[3].Text;
         
            }
        }

        private void txtTenDV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtLoaiTuoiKho_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
