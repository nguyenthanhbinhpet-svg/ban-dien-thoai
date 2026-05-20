namespace GUI_PhoneStore
{
    partial class GUI_BaoCao
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblDenNgay;

        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;

        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Button btnSanPhamBanChay;
        private System.Windows.Forms.Button btnKhachHangTiemNang;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.DataGridView dgvBaoCao;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblDenNgay = new System.Windows.Forms.Label();

            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();

            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.btnSanPhamBanChay = new System.Windows.Forms.Button();
            this.btnKhachHangTiemNang = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();

            this.dgvBaoCao = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();

            // =========================
            // FORM
            // =========================
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.ClientSize = new System.Drawing.Size(1095, 575);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "GUI_BaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo cáo & thống kê";
            this.Load += new System.EventHandler(this.GUI_BaoCao_Load);

            // =========================
            // TITLE
            // =========================
            this.lblTitle.Text = "📊 BÁO CÁO & THỐNG KÊ";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 46);
            this.lblTitle.Location = new System.Drawing.Point(22, 16);
            this.lblTitle.Size = new System.Drawing.Size(420, 38);

            // =========================
            // LABEL TỪ NGÀY
            // =========================
            this.lblTuNgay.Text = "Từ ngày";
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTuNgay.ForeColor = System.Drawing.Color.FromArgb(30, 30, 46);
            this.lblTuNgay.Location = new System.Drawing.Point(27, 72);
            this.lblTuNgay.Size = new System.Drawing.Size(70, 22);

            // =========================
            // DATE TỪ NGÀY
            // =========================
            this.dtpTuNgay.Location = new System.Drawing.Point(95, 68);
            this.dtpTuNgay.Size = new System.Drawing.Size(150, 29);
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";

            // =========================
            // LABEL ĐẾN NGÀY
            // =========================
            this.lblDenNgay.Text = "Đến ngày";
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDenNgay.ForeColor = System.Drawing.Color.FromArgb(30, 30, 46);
            this.lblDenNgay.Location = new System.Drawing.Point(265, 72);
            this.lblDenNgay.Size = new System.Drawing.Size(75, 22);

            // =========================
            // DATE ĐẾN NGÀY
            // =========================
            this.dtpDenNgay.Location = new System.Drawing.Point(340, 68);
            this.dtpDenNgay.Size = new System.Drawing.Size(150, 29);
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";

            // =========================
            // BUTTON DOANH THU
            // =========================
            this.btnDoanhThu.Text = "Doanh thu";
            this.btnDoanhThu.Location = new System.Drawing.Point(515, 66);
            this.btnDoanhThu.Size = new System.Drawing.Size(125, 34);
            this.btnDoanhThu.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoanhThu.FlatAppearance.BorderSize = 0;
            this.btnDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoanhThu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);

            // =========================
            // BUTTON SẢN PHẨM BÁN CHẠY
            // =========================
            this.btnSanPhamBanChay.Text = "SP bán chạy";
            this.btnSanPhamBanChay.Location = new System.Drawing.Point(650, 66);
            this.btnSanPhamBanChay.Size = new System.Drawing.Size(145, 34);
            this.btnSanPhamBanChay.BackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.btnSanPhamBanChay.ForeColor = System.Drawing.Color.White;
            this.btnSanPhamBanChay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPhamBanChay.FlatAppearance.BorderSize = 0;
            this.btnSanPhamBanChay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanPhamBanChay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSanPhamBanChay.Click += new System.EventHandler(this.btnSanPhamBanChay_Click);

            // =========================
            // BUTTON KHÁCH HÀNG TIỀM NĂNG
            // =========================
            this.btnKhachHangTiemNang.Text = "KH tiềm năng";
            this.btnKhachHangTiemNang.Location = new System.Drawing.Point(805, 66);
            this.btnKhachHangTiemNang.Size = new System.Drawing.Size(160, 34);
            this.btnKhachHangTiemNang.BackColor = System.Drawing.Color.FromArgb(124, 58, 237);
            this.btnKhachHangTiemNang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHangTiemNang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHangTiemNang.FlatAppearance.BorderSize = 0;
            this.btnKhachHangTiemNang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhachHangTiemNang.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnKhachHangTiemNang.Click += new System.EventHandler(this.btnKhachHangTiemNang_Click);

            // =========================
            // BUTTON LÀM MỚI
            // =========================
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Location = new System.Drawing.Point(975, 66);
            this.btnLamMoi.Size = new System.Drawing.Size(90, 34);
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // =========================
            // DATAGRIDVIEW
            // =========================
            this.dgvBaoCao.Location = new System.Drawing.Point(27, 115);
            this.dgvBaoCao.Size = new System.Drawing.Size(1038, 430);
            this.dgvBaoCao.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvBaoCao.RowHeadersVisible = false;
            this.dgvBaoCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoCao.MultiSelect = false;
            this.dgvBaoCao.ReadOnly = true;
            this.dgvBaoCao.AllowUserToAddRows = false;
            this.dgvBaoCao.AllowUserToDeleteRows = false;
            this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvBaoCao.EnableHeadersVisualStyles = false;
            this.dgvBaoCao.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            this.dgvBaoCao.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBaoCao.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.dgvBaoCao.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvBaoCao.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.dgvBaoCao.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            // =========================
            // ADD CONTROLS
            // =========================
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTuNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.lblDenNgay);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.btnDoanhThu);
            this.Controls.Add(this.btnSanPhamBanChay);
            this.Controls.Add(this.btnKhachHangTiemNang);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvBaoCao);

            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}