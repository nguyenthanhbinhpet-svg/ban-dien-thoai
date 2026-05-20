using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_PhoneStore
{
    public partial class GUI_Main : Form
    {
        // Lưu các card panel để quản lý quyền
        private Panel cardSanPham, cardKhachHang, cardBanHang, cardBaoCao;

        public GUI_Main()
        {
            InitializeComponent();
            GanSuKienSidebar();
            CreateMenuCards(); // Tạo các card và thêm vào TableLayoutPanel
        }

        private bool IsDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime;
        }
        private void GanSuKienSidebar()
        {
            // Gỡ trước để tránh bị gắn trùng sự kiện
            btnSanPham.Click -= btnSanPham_Click;
            btnKhachHang.Click -= btnKhachHang_Click;
            btnBanHang.Click -= btnBanHang_Click;
            btnBaoCao.Click -= btnBaoCao_Click;

            // Gắn lại sự kiện cho 4 nút cột đen
            btnSanPham.Click += btnSanPham_Click;
            btnKhachHang.Click += btnKhachHang_Click;
            btnBanHang.Click += btnBanHang_Click;
            btnBaoCao.Click += btnBaoCao_Click;
        }
        private void CreateMenuCards()
        {
            // Xóa các control cũ (nếu có)
            tlpMenuCards.Controls.Clear();

            // Tạo 4 card
            cardSanPham = CreateMenuCard("📦", "Quản lý sản phẩm",
                "Thêm, sửa, tìm kiếm sản phẩm và quản lý tồn kho biến thể",
                Color.FromArgb(59, 130, 246), btnSanPham_Click);
            cardKhachHang = CreateMenuCard("👥", "Quản lý khách hàng",
                "Thêm, sửa, phân loại khách và theo dõi lịch sử mua hàng",
                Color.FromArgb(16, 185, 129), btnKhachHang_Click);
            cardBanHang = CreateMenuCard("🛒", "Quản lý bán hàng",
                "Lập đơn hàng, xử lý thanh toán và xuất hóa đơn",
                Color.FromArgb(245, 158, 11), btnBanHang_Click);
            cardBaoCao = CreateMenuCard("📊", "Báo cáo & thống kê",
                "Doanh thu ngày / tháng / năm và sản phẩm bán chạy",
                Color.FromArgb(168, 85, 247), btnBaoCao_Click);

            // Thêm vào TableLayoutPanel với margin đẹp
            tlpMenuCards.Controls.Add(cardSanPham, 0, 0);
            tlpMenuCards.Controls.Add(cardKhachHang, 1, 0);
            tlpMenuCards.Controls.Add(cardBanHang, 0, 1);
            tlpMenuCards.Controls.Add(cardBaoCao, 1, 1);

            // Đặt margin cho từng card (khoảng cách giữa các card)
            foreach (Control ctrl in tlpMenuCards.Controls)
            {
                ctrl.Margin = new Padding(12);
            }
        }

        private Panel CreateMenuCard(string icon, string title, string desc, Color accent, EventHandler clickHandler)
        {
            Panel card = new Panel();
            card.BackColor = Color.White;
            card.Cursor = Cursors.Hand;
            card.Size = new Size(350, 180);
            card.MinimumSize = new Size(280, 160);
            card.Padding = new Padding(0);

            // Vẽ viền và đường kẻ màu accent phía trên
            card.Paint += (s, e) =>
            {
                e.Graphics.DrawRectangle(new Pen(Color.FromArgb(226, 232, 240)), 0, 0, card.Width - 1, card.Height - 1);
                e.Graphics.FillRectangle(new SolidBrush(accent), 0, 0, card.Width, 6);
            };

            // Icon
            Label lblIcon = new Label();
            lblIcon.Text = icon;
            lblIcon.Font = new Font("Segoe UI Emoji", 28F);
            lblIcon.ForeColor = accent;
            lblIcon.Location = new Point(20, 24);
            lblIcon.Size = new Size(60, 60);
            lblIcon.TextAlign = ContentAlignment.MiddleCenter;

            // Title
            Label lblTitleCard = new Label();
            lblTitleCard.Text = title;
            lblTitleCard.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitleCard.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitleCard.Location = new Point(90, 24);
            lblTitleCard.Size = new Size(240, 28);

            // Description
            Label lblDesc = new Label();
            lblDesc.Text = desc;
            lblDesc.Font = new Font("Segoe UI", 9F);
            lblDesc.ForeColor = Color.FromArgb(71, 85, 105);
            lblDesc.Location = new Point(90, 56);
            lblDesc.Size = new Size(240, 48);
            lblDesc.TextAlign = ContentAlignment.TopLeft;

            // Lock label
            Label lblLock = new Label();
            lblLock.Name = "lblLock";
            lblLock.Text = "🔒  Bạn không có quyền truy cập chức năng này";
            lblLock.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblLock.ForeColor = Color.FromArgb(220, 38, 38);
            lblLock.Location = new Point(20, 120);
            lblLock.Size = new Size(310, 40);
            lblLock.Visible = false;

            // Button overlay
            Button btnOverlay = new Button();
            btnOverlay.FlatStyle = FlatStyle.Flat;
            btnOverlay.FlatAppearance.BorderSize = 0;
            btnOverlay.BackColor = Color.Transparent;
            btnOverlay.Dock = DockStyle.Fill;
            btnOverlay.Cursor = Cursors.Hand;
            btnOverlay.Click += clickHandler;

            // Khi card bị vô hiệu, overlay cũng không click được và lock hiện lên
            card.EnabledChanged += (s, e) =>
            {
                bool enabled = card.Enabled;
                btnOverlay.Enabled = enabled;
                lblLock.Visible = !enabled;
                lblIcon.ForeColor = enabled ? accent : Color.FromArgb(156, 163, 175);
                lblTitleCard.ForeColor = enabled ? Color.FromArgb(15, 23, 42) : Color.FromArgb(156, 163, 175);
                lblDesc.ForeColor = enabled ? Color.FromArgb(71, 85, 105) : Color.FromArgb(156, 163, 175);
            };

            card.Controls.Add(lblLock);
            card.Controls.Add(lblDesc);
            card.Controls.Add(lblTitleCard);
            card.Controls.Add(lblIcon);
            card.Controls.Add(btnOverlay);
            return card;
        }

        private void GUI_Main_Load(object sender, EventArgs e)
        {
            if (IsDesignMode()) return;

            // Đồng bộ session
            if (Session.CurrentUser == null && AppSession.CurrentUser != null)
                Session.CurrentUser = AppSession.CurrentUser;
            if (AppSession.CurrentUser == null && Session.CurrentUser != null)
                AppSession.CurrentUser = Session.CurrentUser;

            if (Session.CurrentUser == null)
            {
                MessageBox.Show("Phiên đăng nhập không hợp lệ. Vui lòng đăng nhập lại.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Hide();
                GUI_DangNhap login = new GUI_DangNhap();
                login.FormClosed += (s, args) => Close();
                login.Show();
                return;
            }

            lblUser.Text = "Xin chào: " + Session.CurrentUser.HoTen
                         + " (" + Session.CurrentUser.TenVaiTro + ")";
            lblTitle.Text = "Trang chủ";
            PhanQuyen();
        }

        private void PhanQuyen()
        {
            if (Session.CurrentUser == null) return;

            int vaiTro = Session.CurrentUser.MaVaiTro;
            bool admin = (vaiTro == 1);
            bool cashier = (vaiTro == 2);
            bool sales = (vaiTro == 3);


            // Sidebar buttons
            btnSanPham.Enabled = admin;
            btnKhachHang.Enabled = admin || cashier;
            btnBanHang.Enabled = admin || cashier || sales;
            btnBaoCao.Enabled = admin || cashier;

            btnSanPham.Text = btnSanPham.Enabled ? "📦   Sản phẩm" : "📦   Sản phẩm\n      (Không quyền)";
            btnKhachHang.Text = btnKhachHang.Enabled ? "👥   Khách hàng" : "👥   Khách hàng\n      (Không quyền)";
            btnBanHang.Text = btnBanHang.Enabled ? "🛒   Bán hàng" : "🛒   Bán hàng\n      (Không quyền)";
            btnBaoCao.Text = btnBaoCao.Enabled ? "📊   Báo cáo" : "📊   Báo cáo\n      (Không quyền)";

            // Cards
            if (cardSanPham != null) cardSanPham.Enabled = btnSanPham.Enabled;
            if (cardKhachHang != null) cardKhachHang.Enabled = btnKhachHang.Enabled;
            if (cardBanHang != null) cardBanHang.Enabled = btnBanHang.Enabled;
            if (cardBaoCao != null) cardBaoCao.Enabled = btnBaoCao.Enabled;
        }

        // Các hàm kiểm tra quyền và sự kiện click
        private bool CoQuyenSanPham() => Session.CurrentUser != null && Session.CurrentUser.MaVaiTro == 1;
        private bool CoQuyenKhachHang() => Session.CurrentUser != null && (Session.CurrentUser.MaVaiTro == 1 || Session.CurrentUser.MaVaiTro == 2);
        private bool CoQuyenBanHang() => Session.CurrentUser != null && (Session.CurrentUser.MaVaiTro == 1 || Session.CurrentUser.MaVaiTro == 2 || Session.CurrentUser.MaVaiTro == 3);
        private bool CoQuyenBaoCao() => Session.CurrentUser != null && (Session.CurrentUser.MaVaiTro == 1 || Session.CurrentUser.MaVaiTro == 2);
        private void BaoKhongCoQuyen() => MessageBox.Show("Bạn không có quyền truy cập chức năng này.", "Không đủ quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        private void OpenChild(Form frm) { if (frm != null) frm.ShowDialog(this); }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            if (!CoQuyenSanPham()) { BaoKhongCoQuyen(); return; }
            OpenChild(new GUI_SanPham());
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            if (!CoQuyenKhachHang()) { BaoKhongCoQuyen(); return; }
            OpenChild(new GUI_KhachHang());
        }
        private void btnBanHang_Click(object sender, EventArgs e)
        {
            if (!CoQuyenBanHang()) { BaoKhongCoQuyen(); return; }
            OpenChild(new GUI_BanHang());
        }
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (!CoQuyenBaoCao()) { BaoKhongCoQuyen(); return; }
            OpenChild(new GUI_BaoCao());
        }

        private void lblBannerText_Click(object sender, EventArgs e)
        {

        }

       

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Session.CurrentUser = null;
                AppSession.CurrentUser = null;
                Hide();
                GUI_DangNhap login = new GUI_DangNhap();
                login.FormClosed += (s, args) => Close();
                login.Show();
            }
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(226, 232, 240)))
                e.Graphics.DrawLine(pen, 0, pnlTop.Height - 1, pnlTop.Width, pnlTop.Height - 1);
        }

        private void pnlBanner_Paint(object sender, PaintEventArgs e)
        {
            if (pnlBanner.ClientRectangle.Width <= 0 || pnlBanner.ClientRectangle.Height <= 0) return;
            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(pnlBanner.ClientRectangle,
                Color.FromArgb(29, 78, 216), Color.FromArgb(109, 40, 217),
                System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, pnlBanner.ClientRectangle);
            }
        }
    }
}