using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangTapHoa
{
    public class LoaiHH
    {
        public LoaiHH() { }
        public LoaiHH(string maLoai,string tenLoai)
        {
            this.MaLoai = maLoai;this.TenLoai = tenLoai;
        }

        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public bool CheckLoaiHHIsNotNull()
        {
            if (string.IsNullOrEmpty(MaLoai))
            {
                if (string.IsNullOrEmpty(TenLoai))
                    return true;
                else
                MessageBox.Show("Tên loại k được để trống ", "Nhắc nhở", MessageBoxButtons.OK);

            }
            else
                MessageBox.Show("Mã loại k được để trống ", "Nhắc nhở", MessageBoxButtons.OK);
            return false;
        }
        public override string ToString()
        {
            return "Thông tin loại hàng hóa:\n" + "Mã loại: " + MaLoai + "\nTên loai: " + TenLoai;
        }
    }
}
