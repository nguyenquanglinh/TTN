using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangTapHoa.QLNV
{
    class NhanVien
    {
        private string maNV;
        private string tenNV;
        private string quequan;
        private string namsinh;
        private string chucvu;
        private string luongthang;
        private string gioitinh;

        public string MaNV
        {
            get
            {
                return maNV;
            }

            set
            {
                maNV = value;
            }
        }

        public string TenNV
        {
            get
            {
                return tenNV;
            }

            set
            {
                tenNV = value;
            }
        }

        public string Quequan
        {
            get
            {
                return quequan;
            }

            set
            {
                quequan = value;
            }
        }

        public string Namsinh
        {
            get
            {
                return namsinh;
            }

            set
            {
                namsinh = value;
            }
        }

        public string Chucvu
        {
            get
            {
                return chucvu;
            }

            set
            {
                chucvu = value;
            }
        }

        public string Luongthang
        {
            get
            {
                return luongthang;
            }

            set
            {
                luongthang = value;
            }
        }

        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

        public NhanVien()
        {

        }

        public NhanVien(string maNV, string tenNV, string quequan, string namsinh, string chucvu, string luongthang, string gioitinh)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.quequan = quequan;
            this.namsinh = namsinh;
            this.chucvu = chucvu;
            this.luongthang = luongthang;
            this.gioitinh = gioitinh;
        }
        public bool CheckNVNotNull()
        {
            if (string.IsNullOrEmpty(this.TenNV) || string.IsNullOrEmpty(this.MaNV) || string.IsNullOrEmpty(this.Chucvu) || string.IsNullOrEmpty(this.Luongthang) || string.IsNullOrEmpty(this.Quequan) || string.IsNullOrEmpty(this.Namsinh) || string.IsNullOrEmpty(this.Gioitinh))
            {
                return true;
            }
            else
                return false;
        }
    }
}
