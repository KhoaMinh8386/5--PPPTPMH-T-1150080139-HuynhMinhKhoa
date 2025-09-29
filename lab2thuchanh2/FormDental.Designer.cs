namespace lab2thuchanh2
{
    partial class FormDental
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.CheckBox chkLayCaoRang;
        private System.Windows.Forms.CheckBox chkTayTrangRang;
        private System.Windows.Forms.CheckBox chkHanRang;
        private System.Windows.Forms.NumericUpDown nupHanRang;
        private System.Windows.Forms.CheckBox chkBeRang;
        private System.Windows.Forms.NumericUpDown nupBeRang;
        private System.Windows.Forms.CheckBox chkBocRang;
        private System.Windows.Forms.NumericUpDown nupBocRang;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.ErrorProvider err;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.chkLayCaoRang = new System.Windows.Forms.CheckBox();
            this.chkTayTrangRang = new System.Windows.Forms.CheckBox();
            this.chkHanRang = new System.Windows.Forms.CheckBox();
            this.nupHanRang = new System.Windows.Forms.NumericUpDown();
            this.chkBeRang = new System.Windows.Forms.CheckBox();
            this.nupBeRang = new System.Windows.Forms.NumericUpDown();
            this.chkBocRang = new System.Windows.Forms.CheckBox();
            this.nupBocRang = new System.Windows.Forms.NumericUpDown();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nupHanRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBeRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBocRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            
            // Title
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(120, 20);
            this.lblTitle.Text = "TÍNH TIỀN DỊCH VỤ NHA KHOA";

            // TenKH
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(30, 70);
            this.lblTenKH.Text = "Tên khách hàng:";
            this.txtTenKH.Location = new System.Drawing.Point(150, 70);
            this.txtTenKH.Width = 200;

            // Lấy cao răng
            this.chkLayCaoRang.AutoSize = true;
            this.chkLayCaoRang.Location = new System.Drawing.Point(30, 110);
            this.chkLayCaoRang.Text = "Lấy cao răng (50,000đ)";

            // Tẩy trắng răng
            this.chkTayTrangRang.AutoSize = true;
            this.chkTayTrangRang.Location = new System.Drawing.Point(30, 140);
            this.chkTayTrangRang.Text = "Tẩy trắng răng (100,000đ)";

            // Hàn răng
            this.chkHanRang.AutoSize = true;
            this.chkHanRang.Location = new System.Drawing.Point(30, 170);
            this.chkHanRang.Text = "Hàn răng (100,000đ/chiếc)";
            this.nupHanRang.Location = new System.Drawing.Point(250, 170);
            this.nupHanRang.Minimum = 0;
            this.nupHanRang.Maximum = 32;

            // Bẻ răng
            this.chkBeRang.AutoSize = true;
            this.chkBeRang.Location = new System.Drawing.Point(30, 200);
            this.chkBeRang.Text = "Bẻ răng (10,000đ/chiếc)";
            this.nupBeRang.Location = new System.Drawing.Point(250, 200);
            this.nupBeRang.Minimum = 0;
            this.nupBeRang.Maximum = 32;

            // Bọc răng
            this.chkBocRang.AutoSize = true;
            this.chkBocRang.Location = new System.Drawing.Point(30, 230);
            this.chkBocRang.Text = "Bọc răng (1,000,000đ/chiếc)";
            this.nupBocRang.Location = new System.Drawing.Point(250, 230);
            this.nupBocRang.Minimum = 0;
            this.nupBocRang.Maximum = 32;

            // Button tính tiền
            this.btnTinhTien.Location = new System.Drawing.Point(150, 280);
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);

            // Thành tiền
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(30, 330);
            this.lblThanhTien.Text = "Thành tiền:";
            this.txtThanhTien.Location = new System.Drawing.Point(150, 330);
            this.txtThanhTien.Width = 200;
            this.txtThanhTien.ReadOnly = true;

            // FormDentalClinic
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.chkLayCaoRang);
            this.Controls.Add(this.chkTayTrangRang);
            this.Controls.Add(this.chkHanRang);
            this.Controls.Add(this.nupHanRang);
            this.Controls.Add(this.chkBeRang);
            this.Controls.Add(this.nupBeRang);
            this.Controls.Add(this.chkBocRang);
            this.Controls.Add(this.nupBocRang);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.txtThanhTien);
            this.Text = "Dental Clinic Service";
            ((System.ComponentModel.ISupportInitialize)(this.nupHanRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBeRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBocRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
