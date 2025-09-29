namespace lab2thuchanh1
{
    partial class FormSecurity
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnCheck;
        private Button btnThoat;
        private ListBox lstLog;
        private GroupBox groupBoxInfo;
        private Label lblGroup;
        private Label lblPass;
        private Label lblStatus;
        private TextBox txtGroup;
        private TextBox txtPassEntered;
        private TextBox txtStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.btnCheck = new Button();
            this.btnThoat = new Button();
            this.lstLog = new ListBox();
            this.groupBoxInfo = new GroupBox();
            this.lblGroup = new Label();
            this.lblPass = new Label();
            this.lblStatus = new Label();
            this.txtGroup = new TextBox();
            this.txtPassEntered = new TextBox();
            this.txtStatus = new TextBox();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new Point(30, 30);
            this.lblPassword.Text = "Nhập mã PIN:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new Point(140, 27);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new Size(150, 27);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new Point(310, 25);
            this.btnCheck.Size = new Size(94, 29);
            this.btnCheck.Text = "Check";
            this.btnCheck.Click += new EventHandler(this.btnCheck_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new Point(410, 25);
            this.btnThoat.Size = new Size(94, 29);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.txtStatus);
            this.groupBoxInfo.Controls.Add(this.txtPassEntered);
            this.groupBoxInfo.Controls.Add(this.txtGroup);
            this.groupBoxInfo.Controls.Add(this.lblStatus);
            this.groupBoxInfo.Controls.Add(this.lblPass);
            this.groupBoxInfo.Controls.Add(this.lblGroup);
            this.groupBoxInfo.Location = new Point(30, 70);
            this.groupBoxInfo.Size = new Size(474, 120);
            this.groupBoxInfo.Text = "Thông tin kiểm tra";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new Point(15, 30);
            this.lblGroup.Text = "Nhóm:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new Point(15, 60);
            this.lblPass.Text = "Password:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new Point(15, 90);
            this.lblStatus.Text = "Trạng thái:";
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new Point(100, 27);
            this.txtGroup.Size = new Size(350, 27);
            this.txtGroup.ReadOnly = true;
            // 
            // txtPassEntered
            // 
            this.txtPassEntered.Location = new Point(100, 57);
            this.txtPassEntered.Size = new Size(350, 27);
            this.txtPassEntered.ReadOnly = true;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new Point(100, 87);
            this.txtStatus.Size = new Size(350, 27);
            this.txtStatus.ReadOnly = true;
            // 
            // lstLog
            // 
            this.lstLog.Location = new Point(30, 210);
            this.lstLog.Size = new Size(474, 180);
            // 
            // FormSecurity
            // 
            this.ClientSize = new Size(540, 420);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Text = "Security Panel";
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
