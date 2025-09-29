namespace lab2thuchanh1
{
    partial class FormMath
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtKetQua;
        private Button btnCong, btnTru, btnNhan, btnChia, btnXoa, btnThoat;

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
            this.btnCong = new Button();
            this.btnTru = new Button();
            this.btnNhan = new Button();
            this.btnChia = new Button();
            this.btnXoa = new Button();
            this.btnThoat = new Button();

            // txtA
            this.txtA.Location = new System.Drawing.Point(30, 30);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);

            // txtB
            this.txtB.Location = new System.Drawing.Point(30, 70);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);

            // txtKetQua
            this.txtKetQua.Location = new System.Drawing.Point(30, 110);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(200, 20);
            this.txtKetQua.ReadOnly = true;

            // Buttons
            this.btnCong.Text = "Cộng";
            this.btnCong.Location = new System.Drawing.Point(160, 30);
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);

            this.btnTru.Text = "Trừ";
            this.btnTru.Location = new System.Drawing.Point(160, 70);
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);

            this.btnNhan.Text = "Nhân";
            this.btnNhan.Location = new System.Drawing.Point(160, 110);
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);

            this.btnChia.Text = "Chia";
            this.btnChia.Location = new System.Drawing.Point(160, 150);
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);

            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(30, 150);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new System.Drawing.Point(100, 150);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // FormMath
            this.ClientSize = new System.Drawing.Size(300, 220);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Text = "Phép tính số học";
        }
    }
}
