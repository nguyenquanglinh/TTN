using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu
{
  public  class User
    {
        public User(string id,string name,string pass,string thuocTinh)
        {
            this.Name = name;
            this.ID = id;
            this.Pass = pass;
            this.ThuocTinh = thuocTinh;
        }

        public string ID { get; private set; }
        public string Name { get; private set; }
        public string Pass { get; private set; }
        public string ThuocTinh { get; private set; }

        public override string ToString()
        {
            return "Thông tin:\n" + "ID: " + ID + "\nTên: " + Name+"\nThuộc tính: "+ThuocTinh;
        }
    }
}
