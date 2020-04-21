using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKho
{
   public class ConnectionString
    {
        public static string connectionString = "Data Source =" + "DGIANG\\SQLEXPRESS2014 ;Database = Quan_Ly_Kho; Integrated Security=true;";
        private static SqlConnection con = new SqlConnection(connectionString);

        public ConnectionString()
        {
            while (con.State != ConnectionState.Open)
            {
                try
                {
                    con.ConnectionString = connectionString;
                    con.Open();
                }
                catch
                {

                }
                
            }
        }
        void GetDataFromTable(string query, DataGridView grv)
        {
            SqlDataAdapter dataadapter = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "data");
            grv.DataSource = ds;
            grv.DataMember = "data";
        }

        internal bool RunQuery(string queryThem)
        {
            throw new NotImplementedException();
        }

        internal bool GetDataFromTableChiTietPhieuNhap(DataGridView dataGridView2)
        {
            try
            {
                string query = " select maCTN as'Mã chi tiết phiếu nhập',maPN as 'Mã phiếu nhập',maHH as 'Mã hàng hóa',soLuong as 'Số lượng',donGia as 'Đơn giá' from Chitietnhap";
                GetDataFromTable(query, dataGridView2);
                return true;
            }
            catch
            {
            }
            return false;
        }

        internal bool GetDataFromTablePhieuNhap(DataGridView dataGridView1)
        {
            try
            {
                string query = "select maPN as 'Mã phiếu nhập',ngayNhap as'Ngày tháng',tongTien as 'Tổng tiền' from phieuNhap ";
                GetDataFromTable(query, dataGridView1);
                return true;
            }
            catch
            {
            }
            return false;
        }

        public bool GetUsersFromDataBase(string userName, string passWord)
        {
            string s = "select count(*) from TaiKhoan where acc='" + userName + "'and pass='" + passWord + "'";
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                    return true;
            }
            catch
            {
            }
            return false;
        }

    }
}

