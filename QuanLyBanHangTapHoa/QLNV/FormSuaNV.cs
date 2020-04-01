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

namespace QuanLyBanHangTapHoa.QLNV
{
    public partial class FormSuaNV : Form
    {
        public FormSuaNV()
        {
            InitializeComponent();
        }
        string sua;
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DbAccess.strConnString);
                conn.Open();
                sua = "update NhanVien set MaNV= '" + txtMaNV.Text + "', TenNV='"+txtTenNV.Text+"',QueQuan='"+txtQueQuan.Text+"',NamSinh='"+txtNamSinh.Text+"',ChucVu='"+txtChucVu.Text+"',LuongThang='"+txtLuongThang.Text+"',GioiTinh='"+txtGioiTinh.Text+"' where MaNV='"+txtMaNV.Text+"'";
                SqlCommand cmd = new SqlCommand(sua, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("lỗi , k sửa được !");
            }
            finally
            {
                SqlConnection conn = new SqlConnection(DbAccess.strConnString);
                conn.Close();
                MessageBox.Show("sửa thành công");
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormQLNV f = new FormQLNV();
            f.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
