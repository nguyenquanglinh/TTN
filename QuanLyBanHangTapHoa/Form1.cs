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
    public partial class Form1 : Form
    {
        DbAccess dbAccess = new DbAccess();
        public Form1()
        {
            InitializeComponent();
            try
            {
                var x = new DangNhap(dbAccess);
                x.ShowDialog();
                this.User = x.GetUser;
                ThongTin.Text = User.ToString();
            }
            catch
            {
            }
        }

        public User User { get; }
    }
}
