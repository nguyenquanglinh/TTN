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
    public partial class DangNhap : Form
    {
        private DbAccess dbAccess;
        public DangNhap()
        {
            InitializeComponent();
        }

        public DangNhap(DbAccess dbAccess) : this()
        {
            this.dbAccess = dbAccess;
        }

        public User GetUser { get; private set; }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            
            var userName = txtUserName.Text;
            var password = txtPass.Text;
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Không thể để trống user name hoặc password");
                return;
            }
                string query = "select * from UserTable where userName='" +
                userName + "' and passWord = '" +
                password + "'";
            var dtUsers = dbAccess.readDatathroughtAdapter(query);
            if (dtUsers.Rows.Count != 0)
            {
                var property = dtUsers.Rows[0]["properties"].ToString();
                this.GetUser = new User( userName, password, property);
                MessageBox.Show("Chúc mừng bạn đã đăng nhập thành công ","Thông báo",MessageBoxButtons.OK);
                //dbAccess.sdr.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công","Thông báo",MessageBoxButtons.OK);
            }
        }
    }
}
