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


namespace QuanLyKho.ThongKe
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
        }



        private void FormThongKe_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            SqlCommand cmd = new SqlCommand("select * from PhieuNhap ", conn);
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = sdr;
                dataGridViewNhap.DataSource = source;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }


            SqlCommand cm = new SqlCommand("select * from [dbo].[HangHoa] ", conn);
            try
            {
                conn.Open();
                SqlDataReader sdr = cm.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = sdr;
                dataGridViewXuat.DataSource = source;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }

            txtNhap.Text = (dataGridViewNhap.RowCount).ToString() ;
            txtXuat.Text = (dataGridViewXuat.RowCount).ToString();



        }
    }
}
