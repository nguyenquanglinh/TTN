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
    public partial class HangHoaMng : Form
    {
        public HangHoaMng()
        {
            InitializeComponent();
        }
        public HangHoaMng(DbAccess db):this()
        {
            this.Db = db;
            this.Db.GetDataTableHangHoa(dataGridView1);
        }

        public DbAccess Db { get; set; }

        private void HangHoaMng_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contexMenuCanHo = new ContextMenuStrip();
                contexMenuCanHo.Items.Add("Thêm hàng hóa");
                contexMenuCanHo.Items.Add("Sửa thông tin hàng hóa");
                contexMenuCanHo.Items.Add("Xóa hàng hóa");
                contexMenuCanHo.Show(dataGridView1, new Point(e.X, e.Y));
                contexMenuCanHo.ItemClicked += new ToolStripItemClickedEventHandler(
                    contexMenuCanHo_ItemClicked);

            }
        }
        void contexMenuCanHo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            if (item.Text == "Thêm hàng hóa")
            {
                var them = new ThemHangHoa();
                them.ShowDialog();
                if (Db.ThemHH(them.hh)) MessageBox.Show("Thêm thành công");
                else MessageBox.Show("Không thể thêm thông tin vui lòng kiểm tra lại dữ liệu");
            }
            else if (item.Text == "Sửa thông tin hàng hóa")
            {
                if (s != null)
                {
                    var sua = new SuaHangHoa(s);
                    sua.ShowDialog();
                    if (Db.SuaHH(sua.hh, s.MaHH)) MessageBox.Show("Sửa thành công");
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
                    if (Db.XoaHH(s.MaHH)) MessageBox.Show("Xóa thành công");
                    else MessageBox.Show("Không thể xóa thông tin vui lòng kiểm tra lại");
                }
                else
                {
                    MessageBox.Show("dữ liệu rỗng");
                }
            }
            this.Db.GetDataTableHangHoa(dataGridView1);
        }
        HangHoa s = null;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                s = new HangHoa(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
            catch
            {

            }

        }
    }
}
