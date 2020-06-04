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
using System.Data.SqlClient;


namespace QuanLyKhoNhaHang.QLNhaCungCap
{
    public partial class FormQLNCC : Form
    {
        MyDBcontext db = new MyDBcontext();
        public FormQLNCC()
        {
            InitializeComponent();
        }

        private void FormQLNCC_Load(object sender, EventArgs e)
        {
            List<NhaCungCap> DsNCC = db.NhaCungCaps.ToList();
            foreach (NhaCungCap ncc in DsNCC)
            {
                ListViewItem item = new ListViewItem(ncc.MaNCC.ToString());
                item.SubItems.Add(ncc.TenNCC.ToString());
                item.SubItems.Add(ncc.DiaChi.ToString());
                item.SubItems.Add(ncc.SDT.ToString());

                listDsNCC.Items.Add(item);
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            /*try
            {
                NhaCungCap ncc = new NhaCungCap()
                {
                    MaNCC = int.Parse(txtMaNCC.Text),
                    TenNCC = txtTenNCC.Text,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSDT.Text,
                };
                db.NhaCungCaps.Add(ncc);
                db.SaveChanges();
                MessageBox.Show("them thanh cong");
                FormQLNCC_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Them That bai. Chi tiet loi: " + ex.Message);
            }*/

            try
            {
                SqlParameter[] idparam =
                {
                    new SqlParameter { ParameterName = "MaNCC", Value = int.Parse(txtMaNCC.Text) },
                    new SqlParameter { ParameterName = "TenNCC", Value = txtTenNCC.Text},
                    new SqlParameter { ParameterName = "DiaChi", Value = txtDiaChi.Text},
                    new SqlParameter { ParameterName = "SDT", Value =txtSDT.Text}
                };
                db.Database.ExecuteSqlCommand("ThemNCC @mancc,@tenncc, @diachi,@sdt ", idparam);
                db.SaveChanges();
                MessageBox.Show("them thanh cong");
                listDsNCC.Items.Clear();
                FormQLNCC_Load(sender, e);
;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Them That bai. Chi tiet loi: " + ex.Message);
            }
        }

        private void listDsNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDsNCC.SelectedItems.Count > 0)
            {
                ListViewItem itemSelected = listDsNCC.SelectedItems[0];
                txtMaNCC.Text = itemSelected.SubItems[0].Text;
                txtTenNCC.Text = itemSelected.SubItems[1].Text;
                txtDiaChi.Text = itemSelected.SubItems[2].Text;
                txtSDT.Text = itemSelected.SubItems[3].Text;
               

            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                NhaCungCap ncc = db.NhaCungCaps.Find(int.Parse(txtMaNCC.Text));
                ncc.TenNCC = txtTenNCC.Text;
                ncc.DiaChi = txtDiaChi.Text;
                ncc.SDT = txtSDT.Text;
                SqlParameter[] idparam =
                {
                    new SqlParameter { ParameterName = "MaNCC", Value = ncc.MaNCC },
                    new SqlParameter { ParameterName = "TenNCC", Value = ncc.TenNCC },
                    new SqlParameter { ParameterName = "DiaChi", Value = ncc.DiaChi},
                    new SqlParameter { ParameterName = "SDT", Value =  ncc.SDT}
                };
                db.Database.ExecuteSqlCommand("suancc @mancc,@tenncc, @diachi,@sdt ", idparam);

                db.SaveChanges();
                MessageBox.Show("Sua thanh cong");
                listDsNCC.Items.Clear();
                FormQLNCC_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            /* try
             {
                 NhaCungCap gv = db.NhaCungCaps.Find(int.Parse(txtMaNCC.Text));
                 db.NhaCungCaps.Remove(gv);
                 db.SaveChanges();
                 MessageBox.Show("Xóa Thành Công");
                 FormQLNCC_Load(sender, e);
             }
             catch (Exception ex)
             { MessageBox.Show("" + ex.Message); }*/
            try
            {
                NhaCungCap ncc = db.NhaCungCaps.Find(int.Parse(txtMaNCC.Text));
                SqlParameter idparam = new SqlParameter { ParameterName = "MaNCC", Value = ncc.MaNCC };
                db.Database.ExecuteSqlCommand("xoancc @mancc ", idparam);
                db.SaveChanges();
                MessageBox.Show("Xóa Thành Công");
                listDsNCC.Items.Clear();
                FormQLNCC_Load(sender, e);


            }
            catch (Exception ex)
            { MessageBox.Show("" + ex.Message); }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain();
            f.Show();
            this.Hide();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            FormTimKiemNCC f = new FormTimKiemNCC();
            f.Show();
            this.Hide();
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenNCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
