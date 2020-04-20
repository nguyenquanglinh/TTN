using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace QuanLyKho.QLHangHoa
{
    public partial class FormQLHH : Form
    {
        public FormQLHH()
        {
            InitializeComponent();
        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormQLHH_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            SqlCommand cmd = new SqlCommand("select * from [dbo].[HangHoa] ", conn);
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
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {

            FormMain f = new FormMain();
            f.Show();
            this.Hide();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemHH f = new FormThemHH();
            f.Show();
            this.Hide();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FormSuaHH f = new FormSuaHH();
            f.Show();
            this.Hide();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            FormXoaHH f = new FormXoaHH();
            f.Show();
            this.Hide();
        }
    }
}
