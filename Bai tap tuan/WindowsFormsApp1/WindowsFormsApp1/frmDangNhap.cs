using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxXemMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if(txtMatKhau.PasswordChar!=0)
            txtMatKhau.PasswordChar = (char)0;
            else
                txtMatKhau.PasswordChar = '*';
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "admin" && txtMatKhau.Text == "123")
            {
                MainForm f = new MainForm();
                //this.Hide();
                f.Show(this);
                //Application.Run(f);
                //this.Close();

            }
            else
                MessageBox.Show("Bạn đã nhập sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
        }
    }
}
