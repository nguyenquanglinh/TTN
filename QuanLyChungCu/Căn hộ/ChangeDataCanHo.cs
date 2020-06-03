using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChungCu
{
    public partial class ChangeDataCanHo : Form
    {
        private DbAccess dbAccess;

        public ChangeDataCanHo()
        {
            InitializeComponent();
            this.Text = "Chỉnh sửa dữ liệu căn hộ";
        }
        void Create(string tableName)
        {

        }
        public ChangeDataCanHo(DbAccess dbAccess) : this()
        {
            this.dbAccess = dbAccess;
            this.dbAccess.GetDataTableCanHo(dataGridView1);
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
                var them = new ThemCanHo(dbAccess);
                them.ShowDialog();
            }
            else if (item.Text == "Sửa căn hộ")
            {
                if (s != null)
                {
                    var sua = new SuaCanHo(s,dbAccess);
                    sua.ShowDialog();
                    
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
            this.dbAccess.GetDataTableCanHo(dataGridView1);
        }
        CanHo s = null;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                s = new CanHo(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString(),
                    dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(),
                    dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(),
                    dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
            }
            catch
            {

            }

        }
    }
}
