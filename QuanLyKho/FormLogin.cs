using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if ((txtacc.Text == "") || (txtpass.Text == ""))
            {
                MessageBox.Show("Xin hãy Điền Đủ Thông Tin", "Thông Báo");
                return;
            }
            else
            {
                SqlConnection con = new SqlConnection(ConnectionString.connectionString);
                var connet = new ConnectionString();
                if (connet.GetUsersFromDataBase(txtacc.Text, txtpass.Text))
                {
                    MessageBox.Show("Đăng nhập thành công","Thông báo",MessageBoxButtons.OK);
                    this.Hide();
                    FormMain a = new FormMain(connet);
                    a.Show();
                }
                else
                {
                    MessageBox.Show("Kiểm Tra Lại Mật Khẩu Hoặc Tài Khoản", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void ckcHienPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckcHienPass.Checked == true)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

 }

