using System;
using System.Windows.Forms;

namespace lab2thuchanh1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuItemMath_Click(object sender, EventArgs e)
        {
            FormMath f = new FormMath();
            f.ShowDialog();
        }

        private void menuItemUSCLN_Click(object sender, EventArgs e)
        {
            FormUSCLN f = new FormUSCLN();
            f.ShowDialog();
        }

        private void menuItemSecurity_Click(object sender, EventArgs e)
        {
            FormSecurity f = new FormSecurity();
            f.ShowDialog();
        }
    }
}
