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
    public partial class FormNhaCC : Form
    {
        public FormNhaCC()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormNhaCC_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        private void HienThi()
        {

            //throw new NotImplementedException();
            OpenConnection();
            string sql = "Select* from NhaCC";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "NhaCC");
            dgvNhaCC.DataSource = dataSet.Tables["NhaCC"];

            txtMaNCC.DataBindings.Clear();
            txtMaNCC.DataBindings.Add("Text", dataSet.Tables["NhaCC"], "MaNCC");
            txtTenNCC.DataBindings.Clear();
            txtTenNCC.DataBindings.Add("Text", dataSet.Tables["NhaCC"], "TenNCC");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dataSet.Tables["NhaCC"], "DiaChi");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dataSet.Tables["NhaCC"], "SDT");
            dgvNhaCC.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgvNhaCC.Columns[1].HeaderText = "Tên nhà cung cáp";
            dgvNhaCC.Columns[2].HeaderText = "Địa chỉ";
            dgvNhaCC.Columns[3].HeaderText = "Số điện thoại";


        }

        string strConnection = "Server = DGIANG\\SQLEXPRESS2014; Database = QuanLyBanHangTapHoa; Integrated Security = true";
        SqlConnection connection = null;
        private void OpenConnection()
        {
            //throw new NotImplementedException();
            if (connection == null) connection = new SqlConnection(strConnection);
            if (connection.State == ConnectionState.Closed) connection.Open();

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            OpenConnection();
            string sql = "insert into NhaCC values (@MaNCC, @TenNCC, @DiaChi, @SDT)";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@MaNCC", txtMaNCC.Text);
            command.Parameters.AddWithValue("@TenNCC", txtTenNCC.Text);
            command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            command.Parameters.AddWithValue("@SDT", txtSDT.Text);
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
            string sql = "update HoaDonNhap set SDT = @SDT,TenNCC= @TenNCC, DiaChi= @DiaChi where MaNCC = @MaNCC ";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@MaNCC", txtMaNCC.Text);
            command.Parameters.AddWithValue("@SDT", txtSDT.Text);
            command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            command.Parameters.AddWithValue("@TenNCC", txtTenNCC.Text);

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
            string sql = "delete from NhaCC where MaNCC = @MaNCC";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@MaNCC", txtMaNCC.Text);


            int kq = command.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Xóa thành công !!!");
                HienThi();
            }
            else MessageBox.Show("Xóa thất bại !!!");
        }
    }
}
