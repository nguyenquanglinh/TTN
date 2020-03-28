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

namespace QLBH
{
    public partial class FormHoaDonNhap : Form
    {
        public FormHoaDonNhap()
        {
            InitializeComponent();
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void FormHoaDonNhap_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void HienThi()
        {
            
            //throw new NotImplementedException();
            OpenConnection();
            string sql = "Select* from HoaDonNhap";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "HoaDonNhap");
            dgvHoaDonNhap.DataSource = dataSet.Tables["HoaDonNhap"];

            txtMaPN.DataBindings.Clear();
            txtMaPN.DataBindings.Add("Text", dataSet.Tables["HoaDonNhap"], "MaPN");
            txtMaHH.DataBindings.Clear();
            txtMaHH.DataBindings.Add("Text", dataSet.Tables["HoaDonNhap"], "MaHH");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dataSet.Tables["HoaDonNhap"], "SoLuong");
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dataSet.Tables["HoaDonNhap"], "DonGia");
            dgvHoaDonNhap.Columns[0].HeaderText = "Số Lượng";
            dgvHoaDonNhap.Columns[1].HeaderText = "Mã hàng hóa";
            dgvHoaDonNhap.Columns[2].HeaderText = "Mã phiếu nhập";
            dgvHoaDonNhap.Columns[3].HeaderText = "Đơn giá";


        }

        string strConnection = "Server = DGIANG\\SQLEXPRESS2014; Database = QuanLyBanHangTapHoa; Integrated Security = true";
        SqlConnection connection = null;
        private void OpenConnection()
        {
            //throw new NotImplementedException();
            if (connection == null) connection = new SqlConnection(strConnection);
            if (connection.State == ConnectionState.Closed) connection.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenConnection();
            string sql = "insert into HoaDonNhap values (@MaPN, @MaHH, @SoLuong, @MaNV)";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@MaPN", txtMaPN.Text);
            command.Parameters.AddWithValue("@MaHH", txtMaHH.Text);
            command.Parameters.AddWithValue("@Soluong", txtSoLuong.Text);
            command.Parameters.AddWithValue("@DonGia", txtDonGia.Text);            
            int kq = command.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công !!!");
                HienThi();
            }
            else MessageBox.Show("Thêm thất bại !!!");

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            OpenConnection();
            string sql = "update HoaDonNhap set SoLuong = @SoLuong,Dongia= @DonGia, MaNV= @MaNV where MaPN = @MaPN and MaHH = @MaHH";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@MaPN", txtMaPN.Text);
            command.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
            command.Parameters.AddWithValue("@DonGia", txtDonGia.Text);
            command.Parameters.AddWithValue("@MaHH", txtMaHH.Text);
           
            int kq = command.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Sửa thành công !!!");
                HienThi();
            }
            else MessageBox.Show("Sửa thất bại !!!");
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            OpenConnection();
            string sql = "delete from HoaDonNhap where MaPN = @MaPN and MaHH = @MaHH";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@MaPN", txtMaPN.Text);
            command.Parameters.AddWithValue("@maHH", txtMaHH.Text);


            int kq = command.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Xóa thành công !!!");
                HienThi();
            }
            else MessageBox.Show("Xóa thất bại !!!");
        }

        

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            //FormPhieuNhap_Load(sender, e);
        }
    }
    
}
