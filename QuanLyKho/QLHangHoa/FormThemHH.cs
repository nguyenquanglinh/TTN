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
    public partial class FormThemHH : Form
    {
        public FormThemHH()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                conn.Open();
                string them = "insert into HangHoa(MaKK,TenHH,NhaCC,soluong)  VALUES('" + txtMaHH.Text + "','" + txtTenHH.Text + "','" + txtMaNCC.Text + "','" + txtSoLuong.Text + "')";

                SqlCommand cmdthem = new SqlCommand(them, conn);
                cmdthem.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Lỗi ! không thêm được");

            }
            finally
            {

                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                MessageBox.Show("thêm thành công !");
                conn.Close();

            }
        }

        private void btTroLai_Click(object sender, EventArgs e)
        {
            FormQLHH f = new FormQLHH();
            f.Show();
            this.Hide();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
