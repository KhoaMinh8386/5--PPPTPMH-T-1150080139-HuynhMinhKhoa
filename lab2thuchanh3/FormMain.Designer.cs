namespace lab2thuchanh3
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnXuLySo;
        private System.Windows.Forms.Button btnChonHang;

        /// <summary>
        /// Dọn dẹp tài nguyên đang sử dụng.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnXuLySo = new System.Windows.Forms.Button();
            this.btnChonHang = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(50, 40);
            this.btnLogin.Size = new System.Drawing.Size(200, 40);
            this.btnLogin.Text = "Form Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // 
            // btnXuLySo
            // 
            this.btnXuLySo.Location = new System.Drawing.Point(50, 100);
            this.btnXuLySo.Size = new System.Drawing.Size(200, 40);
            this.btnXuLySo.Text = "Form Xử lý số";
            this.btnXuLySo.UseVisualStyleBackColor = true;
            this.btnXuLySo.Click += new System.EventHandler(this.btnXuLySo_Click);

            // 
            // btnChonHang
            // 
            this.btnChonHang.Location = new System.Drawing.Point(50, 160);
            this.btnChonHang.Size = new System.Drawing.Size(200, 40);
            this.btnChonHang.Text = "Form Chọn mặt hàng";
            this.btnChonHang.UseVisualStyleBackColor = true;
            this.btnChonHang.Click += new System.EventHandler(this.btnChonHang_Click);

            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnXuLySo);
            this.Controls.Add(this.btnChonHang);
            this.Name = "FormMain";
            this.Text = "Lab2 Thực hành 3 - Menu chính";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
