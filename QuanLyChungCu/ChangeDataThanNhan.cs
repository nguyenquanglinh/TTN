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
    public partial class ChangeDataThanNhan : Form
    {
        private DbAccess dbAccess;
        private string cMND;

        public ChangeDataThanNhan()
        {
            InitializeComponent();

        }

        public ChangeDataThanNhan(DbAccess dbAccess, string cMND) : this()
        {
            this.dbAccess = dbAccess;
            this.cMND = cMND;
            this.dbAccess.GetDataTableThanNhan(dataGridView1, cMND);
            this.Text = "Sửa đổi dữ liệu thân nhân của chủ hộ có CMND: " + cMND;
        }



        private void contexMenuCanHo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            if (item.Text == "Thêm thân nhân")
            {
                var them = new ThemThanNhan();
                them.ShowDialog();
                if (dbAccess.ThemThanNhan(them.ThanNhan, cMND)) MessageBox.Show("Thêm thành công");
                else MessageBox.Show("Không thể thêm thông tin vui lòng kiểm tra lại dữ liệu");
            }
            else if (item.Text == "Sửa thân nhân")
            {
                if (th != null)
                {
                    var sua = new SuaThanNhan();
                    sua.ShowDialog();
                    if (dbAccess.SuaThanNhan(sua.ThanNhan, th.CMND)) MessageBox.Show("Thêm thành công");
                    else MessageBox.Show("Không thể thêm thông tin vui lòng kiểm tra lại dữ liệu");
                }
                else MessageBox.Show("chọn sai đối tượng");
            }
            else
            {
                if (th != null)
                {
                    if (dbAccess.XoaCanHo(cMND)) MessageBox.Show("Xóa thành công");
                    else MessageBox.Show("Không thể xóa thông tin vui lòng kiểm tra lại");
                }
                else MessageBox.Show("chọn sai đối tượng");
            }
            this.dbAccess.GetDataTableThanNhan(dataGridView1, cMND);
        }

        private void dataGridView1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contexMenuThanNhan = new ContextMenuStrip();
                contexMenuThanNhan.Items.Add("Thêm thân nhân");
                contexMenuThanNhan.Items.Add("Sửa thân nhân");
                contexMenuThanNhan.Items.Add("Xóa thân nhân");
                contexMenuThanNhan.Show(dataGridView1, new Point(e.X, e.Y));
                contexMenuThanNhan.ItemClicked += new ToolStripItemClickedEventHandler(
                    contexMenuCanHo_ItemClicked);

            }
            else
            {
                MessageBox.Show("Chọn lại đối tượng");

            }
        }

        ThanNhan th;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                //(string ten, string cmnd, string quanHe, string namSinh, string queQuan, string ngayVao, string gt)

                th = new ThanNhan(
                dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),
                dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(),
                dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(),
                dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(),
                dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(),
                dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString(),
                dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
            }
            catch
            {

            }
        }
    }
}
