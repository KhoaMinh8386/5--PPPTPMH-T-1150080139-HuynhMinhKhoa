using System;
using System.Windows.Forms;

namespace lab2thuchanh3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new FormLogin().ShowDialog();
        }

        private void btnXuLySo_Click(object sender, EventArgs e)
        {
            new FormXuLySo().ShowDialog();
        }

        private void btnChonHang_Click(object sender, EventArgs e)
        {
            new FormChonMatHang().ShowDialog();
        }
    }
}
