namespace lab2thuchanh2
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtUser, txtPass;
        private Button btnLogin, btnThoat;
        private ErrorProvider err;
        private Label lblUser, lblPass;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtUser = new TextBox();
            this.txtPass = new TextBox();
            this.btnLogin = new Button();
            this.btnThoat = new Button();
            this.err = new ErrorProvider();
            this.lblUser = new Label();
            this.lblPass = new Label();

            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();

            // lblUser
            this.lblUser.Text = "Username:";
            this.lblUser.Location = new System.Drawing.Point(30, 30);

            // txtUser
            this.txtUser.Location = new System.Drawing.Point(120, 30);
            this.txtUser.Validating += new System.ComponentModel.CancelEventHandler(this.txtUser_Validating);

            // lblPass
            this.lblPass.Text = "Password:";
            this.lblPass.Location = new System.Drawing.Point(30, 70);

            // txtPass
            this.txtPass.Location = new System.Drawing.Point(120, 70);
            this.txtPass.PasswordChar = '*';
            this.txtPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtPass_Validating);

            // btnLogin
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Location = new System.Drawing.Point(70, 120);
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);

            // btnThoat
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new System.Drawing.Point(180, 120);
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);

            // FormLogin
            this.ClientSize = new System.Drawing.Size(320, 180);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnThoat);
            this.Text = "Đăng nhập";

            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
