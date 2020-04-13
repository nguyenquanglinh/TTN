using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangTapHoa
{
    public partial class LoaiHangHoaMng : Form
    {
        public LoaiHangHoaMng()
        {
            InitializeComponent();
        }
        public LoaiHangHoaMng(DbAccess db) : this()
        {
            this.Db = db;
            this.Db.GetDataTableHangHoa(dataGridView1);
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contexMenuCanHo = new ContextMenuStrip();
                contexMenuCanHo.Items.Add("Thêm loại hàng hóa");
                contexMenuCanHo.Items.Add("Sửa thông tin loại hàng hóa");
                contexMenuCanHo.Items.Add("Xóa loại hàng hóa");
                contexMenuCanHo.Show(dataGridView1, new Point(e.X, e.Y));
                contexMenuCanHo.ItemClicked += new ToolStripItemClickedEventHandler(
                    contexMenuCanHo_ItemClicked);

            }
        }
        void contexMenuCanHo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            if (item.Text == "Thêm loại hàng hóa")
            {
                var them = new ThemLoaiHH();
                them.ShowDialog();
                if (Db.ThemLoaiHH(them.lhh)) MessageBox.Show("Thêm thành công");
                else MessageBox.Show("Không thể thêm thông tin vui lòng kiểm tra lại dữ liệu");
            }
            else if (item.Text == "Sửa thông tin hàng hóa")
            {
                if (s != null)
                {
                    var sua = new SuaLoaiHH(s);
                    sua.ShowDialog();
                    if (Db.SuaLoaiHH(sua.lhh, s.MaLoai)) MessageBox.Show("Sửa thành công");
                    else MessageBox.Show("Không thể thêm thông tin vui lòng kiểm tra lại dữ liệu");
                }
                else
                {
                    MessageBox.Show("dữ liệu rỗng");
                }
            }
            else
            {
                if (s != null)
                {
                    if (Db.XoaLoaiHH(s.MaLoai)) MessageBox.Show("Xóa thành công");
                    else MessageBox.Show("Không thể xóa thông tin vui lòng kiểm tra lại");
                }
                else
                {
                    MessageBox.Show("dữ liệu rỗng");
                }
            }
            this.Db.GetDataTableHangHoa(dataGridView1);
        }
        LoaiHH s = null;

        public DbAccess Db { get; }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                s = new LoaiHH(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
            catch
            {

            }

        }

        private void LoaiHangHoaMng_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
