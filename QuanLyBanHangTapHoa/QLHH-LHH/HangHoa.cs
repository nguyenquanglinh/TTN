using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangTapHoa
{
    public class HangHoa
    {
        public HangHoa() { }
        public HangHoa(string tenHH, string maHH, string maLoai) : this()
        {
            this.TenHH = tenHH;
            this.MaHH = maHH;
            this.MaLoai = maLoai;
        }

        public string TenHH { get; set; }
        public string MaHH { get; set; }
        public string MaLoai { get; set; }
        public bool CheckHHNotNull()
        {
            if (string.IsNullOrEmpty(this.TenHH))
            {
                if (string.IsNullOrEmpty(MaHH))
                {
                    if (string.IsNullOrEmpty(MaLoai))
                        return true;
                    else
                        MessageBox.Show("Mã loại hàng hóa khác rỗng", "Nhắc nhở", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Mã hàng hóa khác rỗng", "Nhắc nhở", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Tên hàng hóa khác rỗng", "Nhắc nhở", MessageBoxButtons.OK);
            return false;
        }

        public override string ToString()
        {
            return "Thông tin hàng hóa\n " +
                "Tên hàng hóa: " + TenHH +
                "\n Mã hàng hóa: " + MaHH.ToString() +
                "\nMã loại: " + MaLoai.ToString();
        }
    }
}
