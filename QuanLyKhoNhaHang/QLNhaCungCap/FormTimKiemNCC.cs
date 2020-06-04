using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhoNhaHang.model;


namespace QuanLyKhoNhaHang.QLNhaCungCap
{
    
    public partial class FormTimKiemNCC : Form
    {
        MyDBcontext db = new MyDBcontext();
        public FormTimKiemNCC()
        {
            InitializeComponent();
        }

        void HienThi(List<NhaCungCap> dsNCC)
        {
            listDsNCC.Items.Clear();
            foreach (NhaCungCap ncc in dsNCC)
            {
                ListViewItem item = new ListViewItem(ncc.MaNCC.ToString());
               
                item.SubItems.Add(ncc.TenNCC);
                item.SubItems.Add(ncc.DiaChi.ToString());
                item.SubItems.Add(ncc.SDT.ToString());

                listDsNCC.Items.Add(item);
            }
        }

        private void FormTimKiemNCC_Load(object sender, EventArgs e)
        {
            List<NhaCungCap> DsNCC = db.NhaCungCaps.ToList();
            HienThi(DsNCC);
        }
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
            FormTimKiemNCC_Load(sender, e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string tenNCC = textBox1.Text;
            if (tenNCC == "")
            {
                HienThi(db.NhaCungCaps.ToList());
            }
            else
            {
                List<NhaCungCap> KetQua = db.NhaCungCaps.Where(x => x.TenNCC.ToUpper().Contains(tenNCC.ToUpper())).ToList();
                HienThi(KetQua);
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            FormQLNCC f = new FormQLNCC();
            f.Show();
            this.Hide();
        }
    }
}
