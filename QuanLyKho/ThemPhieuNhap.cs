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
    public partial class ThemPhieuNhap : Form
    {
        public ConnectionString Cs { get; private set; }

        public ThemPhieuNhap()
        {
            InitializeComponent();
        }
        public ThemPhieuNhap(ConnectionString cs) : this()
        {
            this.Cs = cs;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                conn.Open();
                string them = "INSERT INTO PhieuNhap (maPN,ngayNhap ,tongTien) VALUES('" + txtMaPX.Text + "','" + txtNgayXuat.Text + "','" + txtTongTien.Text + "')";

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

        private void button2_Click(object sender, EventArgs e)
        {
            if ((txtMaPN2.Text == "") || (txtMaChiTietPhieuXuat.Text == ""))
            {
                MessageBox.Show("Xin hãy Điền Đủ Thông Tin", "Thông Báo");
                return;
            }
            else
            {
                SqlConnection con = new SqlConnection(ConnectionString.connectionString);
                con.Open();
                string hh = "select count(*) from HangHoa where maHH='" + txtHoaDon.Text + "'";
                string px = "select count(*) from PhieuNhap where maPN='" + txtMaPN2.Text + "'";

                SqlDataAdapter dahh = new SqlDataAdapter(hh, con);
                SqlDataAdapter dapx = new SqlDataAdapter(px, con);


                DataTable dthh = new DataTable();
                DataTable dtpx = new DataTable();
                try
                {
                    dahh.Fill(dthh);
                    dapx.Fill(dtpx);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                if (dthh.Rows[0][0].ToString() == "1" && dtpx.Rows[0][0].ToString() == "1")
                {

                    try
                    {

                        SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                        conn.Open();
                        string them = "INSERT INTO Chitietnhap (maCTN,MaPN ,maHH,soLuong,donGia) VALUES('" + txtMaChiTietPhieuXuat.Text + "','" + txtMaPN2.Text + "','" + txtHoaDon.Text + "','" + txtSoLuong.Text + "','" + txtDonGia.Text + "')";
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
                else
                {

                    MessageBox.Show("Mã Hàng hóa Hoặc Mã Phiếu Xuất không hợp lệ !");
                }
            }
        }

        private void ThemPhieuNhap_Load(object sender, EventArgs e)
        {

        }
    }
}