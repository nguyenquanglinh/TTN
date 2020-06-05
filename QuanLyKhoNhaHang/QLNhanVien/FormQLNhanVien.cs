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

namespace QuanLyKhoNhaHang.QLNhanVien
{
    public partial class FormQLNhanVien : Form
    {
        MyDBcontext db = new MyDBcontext();
        public FormQLNhanVien()
        {
            InitializeComponent();
        }

        private void FormQLNhanVien_Load(object sender, EventArgs e)
        {
            show();
        }
        private void show()
        {
            listDsNV.Items.Clear();
            List<NhanVien> DsNV = db.NhanViens.SqlQuery("laydsnv").ToList();

            foreach (NhanVien nv in DsNV)
            {
                ListViewItem item = new ListViewItem(nv.MaNV.ToString());
                item.SubItems.Add(nv.HoTen.ToString());
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
            FormMain f = new FormMain();
            f.Show();
            this.Hide();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            //NhanVien nv = new NhanVien()
            //{
            //    MaNV = int.Parse(txtMaNV.Text),
            //    HoTen = txtHoTen.Text,
            //    NgaySinh = dateTimePicker1.Value,
            //    DiaChi = txtDiaChi.Text,
            //    SDT = txtSDT.Text,
            //};
            //   db.NhanViens.SqlQuery("Them", int.Parse(txtMaNV.Text), txtHoTen.Text, dateTimePicker1.Value, txtDiaChi.Text, txtSDT.Text);
            try
            {
                SqlParameter[] idparam =
                {
                    new SqlParameter { ParameterName = "MaNV", Value = int.Parse(txtMaNV.Text) },
                    new SqlParameter { ParameterName = "HoTen", Value = txtHoTen.Text},
                    new SqlParameter { ParameterName = "NgaySinh ", Value = dateTimePicker1.Value },
                    new SqlParameter { ParameterName = "DiaChi", Value = txtDiaChi.Text},
                    new SqlParameter { ParameterName = "SDT", Value = txtSDT.Text}
                };
                db.Database.ExecuteSqlCommand("Them @manv,@hoten, @ngaysinh, @diachi,@sdt ", idparam);
                db.SaveChanges();
                MessageBox.Show("them thanh cong");
                
                show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Them That bai. Chi tiet loi: " + ex.Message);
            }
        }

        private void listDsNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDsNV.SelectedItems.Count > 0)
            {
                ListViewItem itemSelected = listDsNV.SelectedItems[0];
                txtMaNV.Text = itemSelected.SubItems[0].Text;
                txtHoTen.Text = itemSelected.SubItems[1].Text;
                dateTimePicker1.Text = itemSelected.SubItems[2].Text;
                txtDiaChi.Text = itemSelected.SubItems[3].Text;
                txtSDT.Text = itemSelected.SubItems[4].Text;


            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nv = db.NhanViens.Find(int.Parse(txtMaNV.Text));
                nv.HoTen = txtHoTen.Text;
                nv.NgaySinh = dateTimePicker1.Value;
                nv.DiaChi = txtDiaChi.Text;
                nv.SDT = txtSDT.Text;
                SqlParameter[] idparam =
                {
                    new SqlParameter { ParameterName = "MaNV", Value = nv.MaNV },
                    new SqlParameter { ParameterName = "HoTen", Value = nv.HoTen },
                    new SqlParameter { ParameterName = "NgaySinh ", Value = nv.NgaySinh },
                    new SqlParameter { ParameterName = "DiaChi", Value = nv.DiaChi},
                    new SqlParameter { ParameterName = "SDT", Value =  nv.SDT}
                };
                db.Database.ExecuteSqlCommand("suanv @manv,@hoten, @ngaysinh, @diachi,@sdt ", idparam);
                db.SaveChanges();
                MessageBox.Show("Sua thanh cong");
                show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nv = db.NhanViens.Find(int.Parse(txtMaNV.Text));
                SqlParameter idparam = new SqlParameter { ParameterName = "MaNV", Value = nv.MaNV };
                db.Database.ExecuteSqlCommand("xoanv @manv ", idparam);
                db.SaveChanges();
                MessageBox.Show("Xóa Thành Công");
                show();
            }
            catch (Exception ex)
            { MessageBox.Show("" + ex.Message); }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            FormTimKiemNV f = new FormTimKiemNV();
            f.Show();
            this.Hide();
        }
    }
}
