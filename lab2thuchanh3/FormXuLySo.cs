using System;
using System.Windows.Forms;

namespace lab2thuchanh3
{
    public partial class FormXuLySo : Form
    {
        public FormXuLySo()
        {
            InitializeComponent();
        }

        private void FormXuLySo_Load(object sender, EventArgs e)
        {
            lsbDaySo.Items.Clear();
        }

        // Chỉ cho nhập số vào textbox và nhấn Enter sẽ tự động thêm
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                btnInput.PerformClick();
            }
        }

        // Nhập số vào ListBox
        private void btnInput_Click(object sender, EventArgs e)
        {
            int a;
            string num = txtInput.Text.Trim();
            if (int.TryParse(num, out a))
            {
                lsbDaySo.Items.Add(a);
                txtInput.Clear();
                txtInput.Focus();
            }
            else
            {
                MessageBox.Show("Không phải số nguyên! Hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInput.Clear();
                txtInput.Focus();
            }
        }

        // Tăng tất cả số lên 2
        private void btnTang2_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
                return;
            }

            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                lsbDaySo.Items[i] = (int)lsbDaySo.Items[i] + 2;
            }
        }

        // Chọn số chẵn đầu tiên
        private void btnChanDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
                return;
            }

            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                if ((int)lsbDaySo.Items[i] % 2 == 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    break;
                }
            }
        }

        // Chọn số lẻ cuối cùng
        private void btnLeCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
                return;
            }

            for (int i = lsbDaySo.Items.Count - 1; i >= 0; i--)
            {
                if ((int)lsbDaySo.Items[i] % 2 != 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    break;
                }
            }
        }

        // Xóa số được chọn
        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
                return;
            }

            if (lsbDaySo.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn số cần xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            while (lsbDaySo.SelectedIndex != -1)
            {
                lsbDaySo.Items.RemoveAt(lsbDaySo.SelectedIndex);
            }
        }

        // Xóa số đầu tiên
        private void btnXoaDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
                return;
            }

            lsbDaySo.Items.RemoveAt(0);
        }

        // Xóa số cuối cùng
        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
                return;
            }

            lsbDaySo.Items.RemoveAt(lsbDaySo.Items.Count - 1);
        }

        // Xóa toàn bộ ListBox
        private void btnXoaDaySo_Click(object sender, EventArgs e)
        {
            lsbDaySo.Items.Clear();
        }
    }
}
