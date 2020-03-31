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
                con.Open();
                string s = "select count(*) from TaiKhoan where acc='" + txtacc.Text + "'and pass='" + txtpass.Text + "'";

                SqlDataAdapter da = new SqlDataAdapter(s, con);
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    FormMain a = new FormMain();
                    a.Show();
                    con.Close();

                }
                else
                {

                    MessageBox.Show("Kiểm Tra Lại Mật Khẩu Hoặc Tài Khoản");
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

