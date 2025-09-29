using System;
using System.Windows.Forms;

namespace lab2thuchanh2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void mnuDental_Click(object sender, EventArgs e)
        {
            FormDental f = new FormDental();
            f.ShowDialog();
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.ShowDialog();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
