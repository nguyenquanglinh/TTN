using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangTapHoa
{
    public class User
    {
        public User( string name, string pass, string thuocTinh)
        {
            this.Name = name;
            this.Pass = pass;
            this.ThuocTinh = thuocTinh;
        }

        public string Name { get; private set; }
        public string Pass { get; private set; }
        public string ThuocTinh { get; private set; }

        public override string ToString()
        {
            return "Thông tin:\n" + "Tên: " + Name + "\nThuộc tính: " + ThuocTinh;
        }
    }
}
