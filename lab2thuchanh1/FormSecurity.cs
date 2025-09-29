using System;
using System.Windows.Forms;

namespace lab2thuchanh1
{
    public partial class FormSecurity : Form
    {
        public FormSecurity()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string pwd = txtPassword.Text.Trim();
            string group = "";
            bool accepted = false;

            if (pwd == "1496" || pwd == "2673") { group = "Phát triển công nghệ"; accepted = true; }
            else if (pwd == "7462") { group = "Nghiên cứu viên"; accepted = true; }
            else if (pwd == "8884" || pwd == "3842" || pwd == "3383") { group = "Thiết kế mô hình"; accepted = true; }

            // Hiển thị thông tin vào GroupBox
            txtGroup.Text = group == "" ? "Không xác định" : group;
            txtPassEntered.Text = pwd;
            txtStatus.Text = accepted ? "Chấp nhận" : "Từ chối";

            // Ghi log vào ListBox
            if (accepted)
                lstLog.Items.Add($"{DateTime.Now} - {group} - {pwd} - Chấp nhận");
            else
                lstLog.Items.Add($"{DateTime.Now} - {pwd} - Từ chối");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
