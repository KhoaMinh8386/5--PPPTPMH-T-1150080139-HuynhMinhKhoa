namespace lab2thuchanh3
{
    partial class FormChonMatHang
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lsbDanhSach, lsbDaChon;
        private System.Windows.Forms.Button btnChon, btnChonTatCa, btnXoa, btnXoaTatCa;
        private System.Windows.Forms.Label lblDanhSach, lblDaChon;

        protected override void Dispose(bool disposing)
        {
            if(disposing && components!=null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lsbDanhSach = new System.Windows.Forms.ListBox();
            this.lsbDaChon = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnChonTatCa = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.lblDaChon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Labels
            this.lblDanhSach.Text = "Danh sách các mặt hàng"; this.lblDanhSach.Location = new System.Drawing.Point(20,10);
            this.lblDaChon.Text = "Các mặt hàng lựa chọn"; this.lblDaChon.Location = new System.Drawing.Point(250,10);
            // 
            // ListBox
            this.lsbDanhSach.Location = new System.Drawing.Point(20,30); this.lsbDanhSach.Size = new System.Drawing.Size(200,200);
            this.lsbDaChon.Location = new System.Drawing.Point(250,30); this.lsbDaChon.Size = new System.Drawing.Size(200,200);
            // 
            // Buttons
            this.btnChon.Text=">"; this.btnChon.Location=new System.Drawing.Point(180,240); this.btnChon.Click+=btnChon_Click;
            this.btnChonTatCa.Text=">>"; this.btnChonTatCa.Location=new System.Drawing.Point(250,240); this.btnChonTatCa.Click+=btnChonTatCa_Click;
            this.btnXoa.Text="<"; this.btnXoa.Location=new System.Drawing.Point(320,240); this.btnXoa.Click+=btnXoa_Click;
            this.btnXoaTatCa.Text="<<"; this.btnXoaTatCa.Location=new System.Drawing.Point(390,240); this.btnXoaTatCa.Click+=btnXoaTatCa_Click;
            // 
            // FormChonMatHang
            this.ClientSize=new System.Drawing.Size(480,300);
            this.Controls.Add(this.lsbDanhSach); this.Controls.Add(this.lsbDaChon);
            this.Controls.Add(this.lblDanhSach); this.Controls.Add(this.lblDaChon);
            this.Controls.Add(this.btnChon); this.Controls.Add(this.btnChonTatCa);
            this.Controls.Add(this.btnXoa); this.Controls.Add(this.btnXoaTatCa);
            this.Text="Chọn mặt hàng";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
