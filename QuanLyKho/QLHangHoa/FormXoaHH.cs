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


namespace QuanLyKho.QLHangHoa
{
    public partial class FormXoaHH : Form
    {
        public FormXoaHH()
        {
            InitializeComponent();
        }

        private void FormXoaHH_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                conn.Open();
                string xoa = "delete HangHoa where maHH='" + txtMaHH.Text + "'";


                SqlCommand cmdxoa = new SqlCommand(xoa, conn);

                cmdxoa.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("lỗi , mã phiếu nhập không đúng !");

            }
            finally
            {

                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                conn.Close();
                MessageBox.Show("xóa thành công");

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            FormQLHH f = new FormQLHH();
            f.Show();
            this.Hide();
        }
    }
}
