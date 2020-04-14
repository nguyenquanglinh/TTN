using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho.XuatHang_QLphieuxuat_;
using QuanLyKho.XuatHang;
using System.Data.SqlClient;

namespace QuanLyKho.XuatHang_QLphieuxuat_
{
    public partial class FormThemphieuxuat : Form
    {
        public FormThemphieuxuat()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormThemphieuxuat_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormXuatHang f = new FormXuatHang();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                conn.Open();
                string them = "INSERT INTO PhieuXuat (maPX,ngayXuat ,tongTien) VALUES('" + txtMaPX.Text + "','" + txtNgayXuat.Text +"','" + txtTongTien.Text + "')";

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
            if ((txtMaPhieuXuat2.Text == "") || (txtMaChiTietPhieuXuat.Text == ""))
            {
                MessageBox.Show("Xin hãy Điền Đủ Thông Tin", "Thông Báo");
                return;
            }
            else
            {
                SqlConnection con = new SqlConnection(ConnectionString.connectionString);
                con.Open();
                string hh = "select count(*) from HangHoa where maHH='" + txtMaHH.Text + "'";
                string px = "select count(*) from PhieuXuat where maPX='" + txtMaPhieuXuat2.Text + "'";

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
                        string them = "INSERT INTO Chitietxuat (maCTX,MaPX ,maHH,soLuong,donGia) VALUES('" + txtMaChiTietPhieuXuat.Text + "','" + txtMaPhieuXuat2.Text + "','" + txtMaHH.Text + "','" + txtSoLuong.Text + "','" + txtDonGia.Text + "')";
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
    }
}
