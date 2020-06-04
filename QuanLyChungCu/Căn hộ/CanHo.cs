using System.Windows.Forms;

namespace QuanLyChungCu
{
    public class CanHo
    {
        public CanHo(string ten,string cmnd, string tang, string phong, string ngayVao, string gt, string txtQueQuan, string txtNamSinh)
        {
            this.Ten = ten;
            this.CMND = cmnd;
            this.Tang = tang;
            this.Phong = phong;
            this.NgayVao = ngayVao;
            this.QueQuan = txtQueQuan;
            this.GT = gt;
            NamSinh = txtNamSinh;
        }

        public string CMND { get; private set; }
        public string GT { get; private set; }
        public string NamSinh { get; private set; }
        public string NgayVao { get; private set; }
        public string Phong { get; private set; }
        public string QueQuan { get; private set; }
        public string Tang { get; private set; }
        public string Ten { get; private set; }
    }
}