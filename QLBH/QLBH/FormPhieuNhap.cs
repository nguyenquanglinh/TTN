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
    public partial class FormPhieuNhap : Form
    {
        public FormPhieuNhap()
        {
            InitializeComponent();
        }

       

       // private void FormPhieuNhap_Load(object sender, EventArgs e)
       // {
       //     HienThi();
       //}
       
        private void HienThi()
        {
            //throw new NotImplementedException();
            OpenConnection();
            string sql = "Select* from PhieuNhap";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "PhieuNhap");
            dgvPhieuNhap.DataSource = dataSet.Tables["PhieuNhap"];

            txtMaPN.DataBindings.Clear();
            txtMaPN.DataBindings.Add("Text", dataSet.Tables["PhieuNhap"], "MaPN");
            txtNgayThang.DataBindings.Clear();
            txtNgayThang.DataBindings.Add("Text", dataSet.Tables["PhieuNhap"], "NgayThang");
            txtTongTien.DataBindings.Clear();
            txtTongTien.DataBindings.Add("Text", dataSet.Tables["PhieuNhap"], "TongTien");
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dataSet.Tables["PhieuNhap"], "MaNV");
            txtMaNCC.DataBindings.Clear();
            txtMaNCC.DataBindings.Add("Text", dataSet.Tables["PhieuNhap"], "MaNCC");
            dgvPhieuNhap.Columns[0].HeaderText = "Mã phiếu nhập";
            dgvPhieuNhap.Columns[1].HeaderText = "Ngày tháng";
            dgvPhieuNhap.Columns[2].HeaderText = "Tổng tiền";
            dgvPhieuNhap.Columns[3].HeaderText = "Mã nhân viên";
            dgvPhieuNhap.Columns[4].HeaderText = "Mã nhà cũng cấp";


        }

        string strConnection = "Server = DGIANG\\SQLEXPRESS2014; Database = QuanLyBanHangTapHoa; Integrated Security = true";
        SqlConnection connection = null;
        private void OpenConnection()
        {
            //throw new NotImplementedException();
            if (connection == null) connection = new SqlConnection(strConnection);
            if (connection.State == ConnectionState.Closed) connection.Open();

        }

        private void buttThem_Click(object sender, EventArgs e)
        {
            OpenConnection();
            string sql = "insert into PhieuNhap values (@MaPN, @NgayThang, @TongTien, @MaNV, @MaNCC)";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@MaPN", txtMaPN.Text);
            command.Parameters.AddWithValue("@NgayThang", txtNgayThang.Text);
            command.Parameters.AddWithValue("@TongTien", txtTongTien.Text);
            command.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
            command.Parameters.AddWithValue("@MaNCC", txtMaNCC.Text);
            int kq = command.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công !!!");
                HienThi();
            }
            else MessageBox.Show("Thêm thất bại !!!");



        }

        private void buttSua_Click(object sender, EventArgs e)
        {
            OpenConnection();
            string sql = "update PhieuNhap set NgayThang = @NgayThang,TongTien= @TongTien, MaNV= @MaNV, MaNCC= @MaNCC where MaPN = @MaPN";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@MaPN", txtMaPN.Text);
            command.Parameters.AddWithValue("@NgayThang", txtNgayThang.Text);
            command.Parameters.AddWithValue("@TongTien", txtTongTien.Text);
            command.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
            command.Parameters.AddWithValue("@MaNCC", txtMaNCC.Text);
            int kq = command.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Sửa thành công !!!");
                HienThi();
            }
            else MessageBox.Show("Sửa thất bại !!!");
        }

        private void buttXoa_Click(object sender, EventArgs e)
        {
            OpenConnection();
            string sql = "delete from PhieuNhap where MaPN = @MaPN ";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@MaPN", txtMaPN.Text);


            int kq = command.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Xóa thành công !!!");
                HienThi();
            }
            else MessageBox.Show("Xóa thất bại !!!");
        }

        private void buttTroVe_Click(object sender, EventArgs e)
        {

        }

        private void FormPhieuNhap_Load_1(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
