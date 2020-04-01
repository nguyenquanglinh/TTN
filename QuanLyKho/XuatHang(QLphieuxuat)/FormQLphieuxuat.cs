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
using QuanLyKho.XuatHang_QLphieuxuat_;

namespace QuanLyKho.XuatHang
{
    public partial class FormXuatHang : Form
    {
        public FormXuatHang()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormXuatHang_Load(object sender, EventArgs e)
        {
         
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            SqlCommand cmd = new SqlCommand("select * from phieuXuat ", conn);
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = sdr;
                dataGridView1.DataSource = source;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }



            SqlCommand cm = new SqlCommand("select * from Chitietxuat ", conn);
            try
            {
                conn.Open();
                SqlDataReader sd = cm.ExecuteReader();
                BindingSource sour = new BindingSource();
                sour.DataSource = sd;
                dataGridView2.DataSource = sour;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemphieuxuat f = new FormThemphieuxuat();
            f.Show();
            this.Hide();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain();
            f.Show();
            this.Hide();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            FormXoaphieuxuat f = new FormXoaphieuxuat();
            this.Hide();
            f.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FormSuaphieuxuat f = new FormSuaphieuxuat();
            f.Show();
            this.Hide();
        }
    }
}
