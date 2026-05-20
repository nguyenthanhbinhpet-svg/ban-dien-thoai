namespace GUI_PhoneStore
{
    partial class GUI_Main
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnDangXuat;

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogoIcon;
        private System.Windows.Forms.Label lblLogoText;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Panel pnlSidebarFooter;
        private System.Windows.Forms.Label lblVersion;

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Label lblBannerIcon;
        private System.Windows.Forms.Label lblBannerText;
        private System.Windows.Forms.Label lblBannerSub;
        private System.Windows.Forms.TableLayoutPanel tlpMenuCards;  // thay pnlMenuGrid

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogoIcon = new System.Windows.Forms.Label();
            this.lblLogoText = new System.Windows.Forms.Label();
            this.pnlSidebarFooter = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.tlpMenuCards = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.lblBannerIcon = new System.Windows.Forms.Label();
            this.lblBannerText = new System.Windows.Forms.Label();
            this.lblBannerSub = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlSidebarFooter.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlBanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.lblUser);
            this.pnlTop.Controls.Add(this.btnDangXuat);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(300, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.pnlTop.Size = new System.Drawing.Size(1075, 81);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Location = new System.Drawing.Point(25, 10);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Trang chủ";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblUser.Location = new System.Drawing.Point(25, 48);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(625, 28);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Xin chào: ...";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangXuat.BackColor = System.Drawing.Color.White;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDangXuat.Location = new System.Drawing.Point(825, 0);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(162, 45);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "⏻  Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlSidebar.Controls.Add(this.btnBaoCao);
            this.pnlSidebar.Controls.Add(this.btnBanHang);
            this.pnlSidebar.Controls.Add(this.btnKhachHang);
            this.pnlSidebar.Controls.Add(this.btnSanPham);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Controls.Add(this.pnlSidebarFooter);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(300, 875);
            this.pnlSidebar.TabIndex = 2;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.btnBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnBaoCao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBaoCao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnBaoCao.Location = new System.Drawing.Point(0, 319);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBaoCao.Size = new System.Drawing.Size(250, 65);
            this.btnBaoCao.TabIndex = 0;
            this.btnBaoCao.Text = "📊   Báo cáo & thống kê";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.UseVisualStyleBackColor = false;
            // 
            // btnBanHang
            // 
            this.btnBanHang.BackColor = System.Drawing.Color.Transparent;
            this.btnBanHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBanHang.FlatAppearance.BorderSize = 0;
            this.btnBanHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnBanHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBanHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnBanHang.Location = new System.Drawing.Point(0, 250);
            this.btnBanHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBanHang.Size = new System.Drawing.Size(250, 65);
            this.btnBanHang.TabIndex = 1;
            this.btnBanHang.Text = "🛒   Quản lý bán hàng";
            this.btnBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanHang.UseVisualStyleBackColor = false;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btnKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnKhachHang.Location = new System.Drawing.Point(0, 181);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(250, 65);
            this.btnKhachHang.TabIndex = 2;
            this.btnKhachHang.Text = "👥   Quản lý khách hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.UseVisualStyleBackColor = false;
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.Transparent;
            this.btnSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnSanPham.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnSanPham.Location = new System.Drawing.Point(0, 112);
            this.btnSanPham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSanPham.Size = new System.Drawing.Size(250, 65);
            this.btnSanPham.TabIndex = 3;
            this.btnSanPham.Text = "📦   Quản lý sản phẩm";
            this.btnSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.UseVisualStyleBackColor = false;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.pnlLogo.Controls.Add(this.lblLogoIcon);
            this.pnlLogo.Controls.Add(this.lblLogoText);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(300, 100);
            this.pnlLogo.TabIndex = 4;
            // 
            // lblLogoIcon
            // 
            this.lblLogoIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 22F);
            this.lblLogoIcon.ForeColor = System.Drawing.Color.White;
            this.lblLogoIcon.Location = new System.Drawing.Point(22, 22);
            this.lblLogoIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogoIcon.Name = "lblLogoIcon";
            this.lblLogoIcon.Size = new System.Drawing.Size(60, 60);
            this.lblLogoIcon.TabIndex = 0;
            this.lblLogoIcon.Text = "📱";
            this.lblLogoIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogoText
            // 
            this.lblLogoText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLogoText.ForeColor = System.Drawing.Color.White;
            this.lblLogoText.Location = new System.Drawing.Point(88, 32);
            this.lblLogoText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogoText.Name = "lblLogoText";
            this.lblLogoText.Size = new System.Drawing.Size(188, 40);
            this.lblLogoText.TabIndex = 1;
            this.lblLogoText.Text = "Phone Store";
            this.lblLogoText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSidebarFooter
            // 
            this.pnlSidebarFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.pnlSidebarFooter.Controls.Add(this.lblVersion);
            this.pnlSidebarFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSidebarFooter.Location = new System.Drawing.Point(0, 819);
            this.pnlSidebarFooter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSidebarFooter.Name = "pnlSidebarFooter";
            this.pnlSidebarFooter.Size = new System.Drawing.Size(300, 56);
            this.pnlSidebarFooter.TabIndex = 5;
            // 
            // lblVersion
            // 
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblVersion.Location = new System.Drawing.Point(0, 0);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(300, 56);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "v2.0  ·  Phone Store 2025";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlContent.Controls.Add(this.tlpMenuCards);
            this.pnlContent.Controls.Add(this.pnlBanner);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(300, 81);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(35, 25, 35, 25);
            this.pnlContent.Size = new System.Drawing.Size(1075, 794);
            this.pnlContent.TabIndex = 0;
            // 
            // tlpMenuCards
            // 
            this.tlpMenuCards.BackColor = System.Drawing.Color.Transparent;
            this.tlpMenuCards.ColumnCount = 2;
            this.tlpMenuCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMenuCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMenuCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenuCards.Location = new System.Drawing.Point(35, 150);
            this.tlpMenuCards.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMenuCards.Name = "tlpMenuCards";
            this.tlpMenuCards.RowCount = 2;
            this.tlpMenuCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMenuCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMenuCards.Size = new System.Drawing.Size(1005, 619);
            this.tlpMenuCards.TabIndex = 0;
            // 
            // pnlBanner
            // 
            this.pnlBanner.Controls.Add(this.lblBannerIcon);
            this.pnlBanner.Controls.Add(this.lblBannerText);
            this.pnlBanner.Controls.Add(this.lblBannerSub);
            this.pnlBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBanner.Location = new System.Drawing.Point(35, 25);
            this.pnlBanner.Margin = new System.Windows.Forms.Padding(0, 0, 0, 35);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(1005, 125);
            this.pnlBanner.TabIndex = 1;
            this.pnlBanner.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBanner_Paint);
            // 
            // lblBannerIcon
            // 
            this.lblBannerIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 28F);
            this.lblBannerIcon.Location = new System.Drawing.Point(25, 22);
            this.lblBannerIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBannerIcon.Name = "lblBannerIcon";
            this.lblBannerIcon.Size = new System.Drawing.Size(75, 75);
            this.lblBannerIcon.TabIndex = 0;
            this.lblBannerIcon.Text = "*";
            this.lblBannerIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBannerText
            // 
            this.lblBannerText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBannerText.ForeColor = System.Drawing.Color.Gray;
            this.lblBannerText.Location = new System.Drawing.Point(112, 22);
            this.lblBannerText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBannerText.Name = "lblBannerText";
            this.lblBannerText.Size = new System.Drawing.Size(875, 40);
            this.lblBannerText.TabIndex = 1;
            this.lblBannerText.Text = "Chào mừng đến với Phone Store!";
            this.lblBannerText.Click += new System.EventHandler(this.lblBannerText_Click);
            // 
            // lblBannerSub
            // 
            this.lblBannerSub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBannerSub.ForeColor = System.Drawing.Color.Blue;
            this.lblBannerSub.Location = new System.Drawing.Point(112, 68);
            this.lblBannerSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBannerSub.Name = "lblBannerSub";
            this.lblBannerSub.Size = new System.Drawing.Size(875, 32);
            this.lblBannerSub.TabIndex = 2;
            this.lblBannerSub.Text = "Chọn một chức năng bên dưới hoặc từ menu bên trái để bắt đầu.";
            // 
            // GUI_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1375, 875);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1370, 863);
            this.Name = "GUI_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phone Store – Quản lý bán điện thoại";
            this.Load += new System.EventHandler(this.GUI_Main_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlSidebarFooter.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlBanner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        // Hàm cấu hình nút sidebar (style)
        private void ConfigureNavButton(System.Windows.Forms.Button btn, string icon, string caption, int top)
        {
            btn.Text = icon + "   " + caption;
            btn.Font = new System.Drawing.Font("Segoe UI", 10F);
            btn.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            btn.BackColor = System.Drawing.Color.Transparent;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            btn.Location = new System.Drawing.Point(0, top);
            btn.Size = new System.Drawing.Size(240, 52);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.UseVisualStyleBackColor = false;
            btn.MouseEnter += (s, e) => btn.ForeColor = System.Drawing.Color.White;
            btn.MouseLeave += (s, e) => btn.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
        }
    }
}