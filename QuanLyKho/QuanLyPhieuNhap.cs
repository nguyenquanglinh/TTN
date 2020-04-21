using System;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class QuanLyPhieuNhap : Form
    {
        public QuanLyPhieuNhap()
        {
            InitializeComponent();
        }
        public QuanLyPhieuNhap(ConnectionString cs) : this()
        {
            this.Cs = cs;
        }
        internal ConnectionString Cs { get;  set; }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void QuanLyPhieuNhap_Load(object sender, EventArgs e)
        {
            if (Cs.GetDataFromTablePhieuNhap(dataGridView1))
            {
                if (Cs.GetDataFromTableChiTietPhieuNhap(dataGridView2))
                {

                }
                else
                    MessageBox.Show("Không thể lấy được dữ liệu từ bảng chi tiết phiếu nhập", "Thông báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Không thể lấy dữ liệu từ bảng phiếu nhập", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
