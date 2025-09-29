namespace lab2thuchanh2
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuDental;
        private ToolStripMenuItem mnuLogin;
        private ToolStripMenuItem mnuThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new MenuStrip();
            this.mnuDental = new ToolStripMenuItem();
            this.mnuLogin = new ToolStripMenuItem();
            this.mnuThoat = new ToolStripMenuItem();

            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
                this.mnuDental,
                this.mnuLogin,
                this.mnuThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(600, 28);

            // mnuDental
            this.mnuDental.Text = "Tính tiền nha khoa";
            this.mnuDental.Click += new EventHandler(this.mnuDental_Click);

            // mnuLogin
            this.mnuLogin.Text = "Đăng nhập";
            this.mnuLogin.Click += new EventHandler(this.mnuLogin_Click);

            // mnuThoat
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new EventHandler(this.mnuThoat_Click);

            // FormMain
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Text = "Lab2 Thực hành 2 & Áp dụng 3";

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
