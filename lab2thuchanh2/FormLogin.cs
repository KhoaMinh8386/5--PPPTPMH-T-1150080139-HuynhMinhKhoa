using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace lab2thuchanh2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                this.Close();
            }
        }

        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text.Trim()))
            {
                e.Cancel = true;
                err.SetError(txtUser, "Username không được để trống!");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtUser, null);
            }
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass.Text.Trim()))
            {
                e.Cancel = true;
                err.SetError(txtPass, "Password không được để trống!");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtPass, null);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
