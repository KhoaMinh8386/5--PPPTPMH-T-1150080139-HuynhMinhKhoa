using System;
using System.Windows.Forms;

namespace lab2thuchanh3
{
    public partial class FormChonMatHang : Form
    {
        public FormChonMatHang()
        {
            InitializeComponent();
            lsbDanhSach.Items.AddRange(new string[] {"SP1","SP2","SP3","SP4","SP5"});
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            while(lsbDanhSach.SelectedItems.Count>0)
            {
                lsbDaChon.Items.Add(lsbDanhSach.SelectedItem);
                lsbDanhSach.Items.Remove(lsbDanhSach.SelectedItem);
            }
        }

        private void btnChonTatCa_Click(object sender, EventArgs e)
        {
            lsbDaChon.Items.AddRange(lsbDanhSach.Items.Cast<object>().ToArray());
            lsbDanhSach.Items.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            while(lsbDaChon.SelectedItems.Count>0)
            {
                lsbDanhSach.Items.Add(lsbDaChon.SelectedItem);
                lsbDaChon.Items.Remove(lsbDaChon.SelectedItem);
            }
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            lsbDanhSach.Items.AddRange(lsbDaChon.Items.Cast<object>().ToArray());
            lsbDaChon.Items.Clear();
        }
    }
}
