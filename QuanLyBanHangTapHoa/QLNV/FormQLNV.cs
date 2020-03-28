using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanHangTapHoa.QLNV
{
    public partial class FormQLNV : Form
    {
        public FormQLNV()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThemNV themnv = new FormThemNV();
            themnv.Show();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSuaNV  suanv = new FormSuaNV();
            suanv.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormXoaNV xoanv = new FormXoaNV();
            xoanv.Show();
        }

        private void FormQLNV_Load(object sender, EventArgs e)
        {
            string cs = "data source =DESKTOP-VLM31NH\\SQLEXPRESS; database=QuanLyBanHangTapHoa;integrated security= SSPI;"; 
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select * from NhanVien", conn);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
