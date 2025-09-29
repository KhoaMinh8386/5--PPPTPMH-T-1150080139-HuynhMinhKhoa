namespace lab2thuchanh1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuBaiTap;
        private ToolStripMenuItem menuItemMath;
        private ToolStripMenuItem menuItemUSCLN;
        private ToolStripMenuItem menuItemSecurity;

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
            this.menuStrip1 = new MenuStrip();
            this.menuBaiTap = new ToolStripMenuItem();
            this.menuItemMath = new ToolStripMenuItem();
            this.menuItemUSCLN = new ToolStripMenuItem();
            this.menuItemSecurity = new ToolStripMenuItem();

            // MenuStrip
            this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.menuBaiTap });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);

            // Menu chính
            this.menuBaiTap.Text = "Bài Tập";
            this.menuBaiTap.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.menuItemMath,
                this.menuItemUSCLN,
                this.menuItemSecurity
            });

            // Menu con
            this.menuItemMath.Text = "Phép tính số học";
            this.menuItemMath.Click += new System.EventHandler(this.menuItemMath_Click);

            this.menuItemUSCLN.Text = "USCLN & BSCNN";
            this.menuItemUSCLN.Click += new System.EventHandler(this.menuItemUSCLN_Click);

            this.menuItemSecurity.Text = "Security Panel";
            this.menuItemSecurity.Click += new System.EventHandler(this.menuItemSecurity_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu Chính";
        }
    }
}
