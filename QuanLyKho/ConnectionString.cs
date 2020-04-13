using System.Data;
using System.Data.SqlClient;

namespace QuanLyKho
{
    class ConnectionString
    {
        public static string connectionString = "Data Source =" + "DESKTOP-1DLVE1Q\\SQLEXPRESS ;Database = Quan_Ly_Kho; Integrated Security=SSPI;";
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

