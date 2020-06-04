using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu
{
  public  class ThanNhan
    {
        public ThanNhan(string ten,string cmnd,string quanHe,string namSinh,string queQuan,string ngayVao,string gt)
        {
            this.Ten = ten;
            this.CMND = cmnd;
            QuanHe = quanHe;
            this.NgayVao = ngayVao;
            this.GT = gt;
            this.NamSinh = namSinh;
            this.QueQuan = queQuan;

        }

        public string CMND { get; private set; }
        public string CNNDChuHo { get; private set; }
        public string GT { get; private set; }
        public string NamSinh { get; private set; }
        public string NgayVao { get; private set; }
        public string QuanHe { get; private set; }
        public string QueQuan { get; private set; }
        public string Ten { get; private set; }
    }
}
