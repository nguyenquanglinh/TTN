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
        public HangHoaMng(DbAccess db)
        {
            this.Db = db;
            this.db.GetDataTableCanHo(dataGridView1);
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

                contexMenuCanHo.Items.Add("Thêm căn hộ");
                contexMenuCanHo.Items.Add("Sửa căn hộ");
                contexMenuCanHo.Items.Add("Xóa căn hộ");
                contexMenuCanHo.Show(dataGridView1, new Point(e.X, e.Y));
                contexMenuCanHo.ItemClicked += new ToolStripItemClickedEventHandler(
                    contexMenuCanHo_ItemClicked);

            }
            else
            {
                if (s != null)
                    new ChangeDataThanNhan(dbAccess, s.CMND).ShowDialog();
            }
        }
        void contexMenuCanHo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            if (item.Text == "Thêm căn hộ")
            {
                var them = new Them();
                them.ShowDialog();
                if (dbAccess.ThemCanHo(them.GetCanHo)) MessageBox.Show("Thêm thành công");
                else MessageBox.Show("Không thể thêm thông tin vui lòng kiểm tra lại dữ liệu");

            }
            else if (item.Text == "Sửa căn hộ")
            {
                if (s != null)
                {
                    var sua = new SuaCanHo(s);
                    sua.ShowDialog();
                    if (dbAccess.SuaCanHo(sua.CanHo, s.CMND)) MessageBox.Show("Thêm thành công");
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
                    if (dbAccess.XoaCanHo(s.CMND)) MessageBox.Show("Xóa thành công");
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
                s = new HangHoa(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                    //dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    //dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString(),
                    //dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(),
                    //dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(),
                    //dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
            }
            catch
            {

            }

        }
    }
}
