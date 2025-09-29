namespace lab2thuchanh3
{
    partial class FormXuLySo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lsbDaySo;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnInput, btnTang2, btnChanDau, btnLeCuoi;
        private System.Windows.Forms.Button btnXoaChon, btnXoaDau, btnXoaCuoi, btnXoaDaySo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lsbDaySo = new System.Windows.Forms.ListBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnChanDau = new System.Windows.Forms.Button();
            this.btnLeCuoi = new System.Windows.Forms.Button();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnXoaDau = new System.Windows.Forms.Button();
            this.btnXoaCuoi = new System.Windows.Forms.Button();
            this.btnXoaDaySo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbDaySo
            // 
            this.lsbDaySo.Location = new System.Drawing.Point(20, 20);
            this.lsbDaySo.Size = new System.Drawing.Size(150, 200);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(200, 20);
            this.txtInput.Width = 100;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(320, 20);
            this.btnInput.Text = "Nhập số";
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // Các nút khác
            this.btnTang2.Location = new System.Drawing.Point(200, 60); this.btnTang2.Text = "Tăng 2"; this.btnTang2.Click += btnTang2_Click;
            this.btnChanDau.Location = new System.Drawing.Point(200, 100); this.btnChanDau.Text = "Chọn chẵn đầu"; this.btnChanDau.Click += btnChanDau_Click;
            this.btnLeCuoi.Location = new System.Drawing.Point(200, 140); this.btnLeCuoi.Text = "Chọn lẻ cuối"; this.btnLeCuoi.Click += btnLeCuoi_Click;
            this.btnXoaChon.Location = new System.Drawing.Point(320, 60); this.btnXoaChon.Text = "Xóa chọn"; this.btnXoaChon.Click += btnXoaChon_Click;
            this.btnXoaDau.Location = new System.Drawing.Point(320, 100); this.btnXoaDau.Text = "Xóa đầu"; this.btnXoaDau.Click += btnXoaDau_Click;
            this.btnXoaCuoi.Location = new System.Drawing.Point(320, 140); this.btnXoaCuoi.Text = "Xóa cuối"; this.btnXoaCuoi.Click += btnXoaCuoi_Click;
            this.btnXoaDaySo.Location = new System.Drawing.Point(320, 180); this.btnXoaDaySo.Text = "Xóa toàn bộ"; this.btnXoaDaySo.Click += btnXoaDaySo_Click;
            // 
            // FormXuLySo
            // 
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.lsbDaySo);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnTang2); this.Controls.Add(this.btnChanDau); this.Controls.Add(this.btnLeCuoi);
            this.Controls.Add(this.btnXoaChon); this.Controls.Add(this.btnXoaDau); this.Controls.Add(this.btnXoaCuoi); this.Controls.Add(this.btnXoaDaySo);
            this.Text = "Xử lý dãy số";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
