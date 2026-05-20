namespace GUI_PhoneStore
{
    partial class GUI_DangNhap
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.pnlLeft.Controls.Add(this.lblBrand);
            this.pnlLeft.Controls.Add(this.lblSub);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(330, 430);
            this.pnlLeft.TabIndex = 1;
            // 
            // lblBrand
            // 
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(28, 95);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(270, 105);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "PHONE STORE\nOFFLINE";
            // 
            // lblSub
            // 
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.lblSub.Location = new System.Drawing.Point(12, 240);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(306, 122);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Nhóm 17: Nguyễn Thanh Bình\nQuản lý cửa hàng bán điện thoại";
            this.lblSub.Click += new System.EventHandler(this.lblSub_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Controls.Add(this.lblTitle);
            this.pnlLogin.Controls.Add(this.lblUser);
            this.pnlLogin.Controls.Add(this.txtTenDangNhap);
            this.pnlLogin.Controls.Add(this.lblPass);
            this.pnlLogin.Controls.Add(this.txtMatKhau);
            this.pnlLogin.Controls.Add(this.btnDangNhap);
            this.pnlLogin.Controls.Add(this.btnThoat);
            this.pnlLogin.Location = new System.Drawing.Point(380, 55);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(360, 320);
            this.pnlLogin.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Location = new System.Drawing.Point(25, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Đăng nhập";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUser.Location = new System.Drawing.Point(28, 85);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(130, 24);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Tên đăng nhập";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTenDangNhap.Location = new System.Drawing.Point(31, 112);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(300, 32);
            this.txtTenDangNhap.TabIndex = 2;
            // 
            // lblPass
            // 
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPass.Location = new System.Drawing.Point(28, 155);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(100, 24);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMatKhau.Location = new System.Drawing.Point(31, 182);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(300, 32);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(31, 235);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(145, 42);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(186, 235);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(145, 42);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // GUI_DangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GUI_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập - Phone Store";
            this.pnlLeft.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
