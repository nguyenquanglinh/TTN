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

namespace QuanLyKho
{
    public partial class QuanLyPhieuNhap : Form
    {
        public QuanLyPhieuNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanLyPhieuNhap_Load(object sender, EventArgs e)
        {
            //phiếu nhập
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            SqlCommand cmd = new SqlCommand("select * from phieunhap ", conn);
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
            //chi tiết phiếu nhập
            SqlCommand cm = new SqlCommand("select * from Chitietnhap ", conn);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            new SuaPhieuNhap().ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            new XoaPhieuNhap().ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new ThemPhieuNhap().ShowDialog();
        }
    }
}
