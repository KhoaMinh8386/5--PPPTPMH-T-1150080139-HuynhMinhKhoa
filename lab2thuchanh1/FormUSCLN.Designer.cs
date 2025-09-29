namespace lab2thuchanh1
{
    partial class FormUSCLN
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtA, txtB, txtKetQua;
        private RadioButton rbUSCLN, rbBSCNN;
        private Button btnTim, btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtA = new TextBox();
            this.txtB = new TextBox();
            this.txtKetQua = new TextBox();
            this.rbUSCLN = new RadioButton();
            this.rbBSCNN = new RadioButton();
            this.btnTim = new Button();
            this.btnThoat = new Button();

            // txtA
            this.txtA.Location = new System.Drawing.Point(30, 30);
            this.txtA.Size = new System.Drawing.Size(100, 20);

            // txtB
            this.txtB.Location = new System.Drawing.Point(30, 70);
            this.txtB.Size = new System.Drawing.Size(100, 20);

            // txtKetQua
            this.txtKetQua.Location = new System.Drawing.Point(30, 110);
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(200, 20);

            // rbUSCLN
            this.rbUSCLN.Text = "USCLN";
            this.rbUSCLN.Location = new System.Drawing.Point(160, 30);

            // rbBSCNN
            this.rbBSCNN.Text = "BSCNN";
            this.rbBSCNN.Location = new System.Drawing.Point(160, 70);

            // btnTim
            this.btnTim.Text = "Tìm";
            this.btnTim.Location = new System.Drawing.Point(30, 150);
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);

            // btnThoat
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new System.Drawing.Point(120, 150);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // FormUSCLN
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.rbUSCLN);
            this.Controls.Add(this.rbBSCNN);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThoat);
            this.Text = "USCLN & BSCNN";
        }
    }
}
