using System;
using System.Windows.Forms;

namespace lab2thuchanh1
{
    public partial class FormUSCLN : Form
    {
        public FormUSCLN()
        {
            InitializeComponent();
        }

        private int USCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private int BSCNN(int a, int b)
        {
            return (a * b) / USCLN(a, b);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtA.Text.Trim());
                int b = int.Parse(txtB.Text.Trim());

                if (rbUSCLN.Checked)
                    txtKetQua.Text = "USCLN = " + USCLN(a, b);
                else if (rbBSCNN.Checked)
                    txtKetQua.Text = "BSCNN = " + BSCNN(a, b);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OKCancel);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
