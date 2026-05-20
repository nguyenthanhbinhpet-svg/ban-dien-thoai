namespace GUI_PhoneStore
{
    partial class GUI_SuaThemSP
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;

        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.GroupBox grpInfo;

        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblThuongHieu;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.Label lblGiaGoc;
        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.Label lblMauSac;
        private System.Windows.Forms.Label lblDungLuong;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Label lblPhienBan;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblTonKho;

        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtGiaGoc;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.TextBox txtMauSac;
        private System.Windows.Forms.TextBox txtDungLuong;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.TextBox txtPhienBan;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtTonKho;

        private System.Windows.Forms.ComboBox cboThuongHieu;
        private System.Windows.Forms.ComboBox cboDanhMuc;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lblThuongHieu = new System.Windows.Forms.Label();
            this.cboThuongHieu = new System.Windows.Forms.ComboBox();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.lblGiaGoc = new System.Windows.Forms.Label();
            this.txtGiaGoc = new System.Windows.Forms.TextBox();
            this.lblSKU = new System.Windows.Forms.Label();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.lblMauSac = new System.Windows.Forms.Label();
            this.txtMauSac = new System.Windows.Forms.TextBox();
            this.lblDungLuong = new System.Windows.Forms.Label();
            this.txtDungLuong = new System.Windows.Forms.TextBox();
            this.lblRam = new System.Windows.Forms.Label();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.lblPhienBan = new System.Windows.Forms.Label();
            this.txtPhienBan = new System.Windows.Forms.TextBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.lblTonKho = new System.Windows.Forms.Label();
            this.txtTonKho = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1120, 56);
            this.pnlTop.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÊM / SỬA SẢN PHẨM";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTimKiem.Location = new System.Drawing.Point(20, 80);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(500, 29);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(530, 78);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(120, 32);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.ColumnHeadersHeight = 29;
            this.dgvSanPham.Location = new System.Drawing.Point(26, 138);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(660, 480);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // grpInfo
            // 
            this.grpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfo.BackColor = System.Drawing.Color.White;
            this.grpInfo.Controls.Add(this.lblMaSP);
            this.grpInfo.Controls.Add(this.txtMaSP);
            this.grpInfo.Controls.Add(this.lblTenSP);
            this.grpInfo.Controls.Add(this.txtTenSP);
            this.grpInfo.Controls.Add(this.lblThuongHieu);
            this.grpInfo.Controls.Add(this.cboThuongHieu);
            this.grpInfo.Controls.Add(this.lblDanhMuc);
            this.grpInfo.Controls.Add(this.cboDanhMuc);
            this.grpInfo.Controls.Add(this.lblGiaGoc);
            this.grpInfo.Controls.Add(this.txtGiaGoc);
            this.grpInfo.Controls.Add(this.lblSKU);
            this.grpInfo.Controls.Add(this.txtSKU);
            this.grpInfo.Controls.Add(this.lblMauSac);
            this.grpInfo.Controls.Add(this.txtMauSac);
            this.grpInfo.Controls.Add(this.lblDungLuong);
            this.grpInfo.Controls.Add(this.txtDungLuong);
            this.grpInfo.Controls.Add(this.lblRam);
            this.grpInfo.Controls.Add(this.txtRam);
            this.grpInfo.Controls.Add(this.lblPhienBan);
            this.grpInfo.Controls.Add(this.txtPhienBan);
            this.grpInfo.Controls.Add(this.lblGiaBan);
            this.grpInfo.Controls.Add(this.txtGiaBan);
            this.grpInfo.Controls.Add(this.lblTonKho);
            this.grpInfo.Controls.Add(this.txtTonKho);
            this.grpInfo.Controls.Add(this.btnThem);
            this.grpInfo.Controls.Add(this.btnSua);
            this.grpInfo.Controls.Add(this.btnLamMoi);
            this.grpInfo.Controls.Add(this.btnDong);
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpInfo.Location = new System.Drawing.Point(700, 80);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(390, 520);
            this.grpInfo.TabIndex = 1;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông tin sản phẩm";
            // 
            // lblMaSP
            // 
            this.lblMaSP.Location = new System.Drawing.Point(20, 35);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(100, 22);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã SP";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(135, 32);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(220, 30);
            this.txtMaSP.TabIndex = 1;
            // 
            // lblTenSP
            // 
            this.lblTenSP.Location = new System.Drawing.Point(20, 71);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(100, 22);
            this.lblTenSP.TabIndex = 2;
            this.lblTenSP.Text = "Tên SP";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(135, 68);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(220, 30);
            this.txtTenSP.TabIndex = 3;
            // 
            // lblThuongHieu
            // 
            this.lblThuongHieu.Location = new System.Drawing.Point(20, 107);
            this.lblThuongHieu.Name = "lblThuongHieu";
            this.lblThuongHieu.Size = new System.Drawing.Size(100, 22);
            this.lblThuongHieu.TabIndex = 4;
            this.lblThuongHieu.Text = "Thương hiệu";
            // 
            // cboThuongHieu
            // 
            this.cboThuongHieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThuongHieu.Location = new System.Drawing.Point(135, 104);
            this.cboThuongHieu.Name = "cboThuongHieu";
            this.cboThuongHieu.Size = new System.Drawing.Size(220, 31);
            this.cboThuongHieu.TabIndex = 5;
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.Location = new System.Drawing.Point(20, 143);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(100, 22);
            this.lblDanhMuc.TabIndex = 6;
            this.lblDanhMuc.Text = "Danh mục";
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanhMuc.Location = new System.Drawing.Point(135, 140);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(220, 31);
            this.cboDanhMuc.TabIndex = 7;
            // 
            // lblGiaGoc
            // 
            this.lblGiaGoc.Location = new System.Drawing.Point(20, 179);
            this.lblGiaGoc.Name = "lblGiaGoc";
            this.lblGiaGoc.Size = new System.Drawing.Size(100, 22);
            this.lblGiaGoc.TabIndex = 8;
            this.lblGiaGoc.Text = "Giá gốc";
            // 
            // txtGiaGoc
            // 
            this.txtGiaGoc.Location = new System.Drawing.Point(135, 176);
            this.txtGiaGoc.Name = "txtGiaGoc";
            this.txtGiaGoc.Size = new System.Drawing.Size(220, 30);
            this.txtGiaGoc.TabIndex = 9;
            // 
            // lblSKU
            // 
            this.lblSKU.Location = new System.Drawing.Point(20, 215);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(100, 22);
            this.lblSKU.TabIndex = 10;
            this.lblSKU.Text = "SKU";
            // 
            // txtSKU
            // 
            this.txtSKU.Location = new System.Drawing.Point(135, 212);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(220, 30);
            this.txtSKU.TabIndex = 11;
            // 
            // lblMauSac
            // 
            this.lblMauSac.Location = new System.Drawing.Point(20, 251);
            this.lblMauSac.Name = "lblMauSac";
            this.lblMauSac.Size = new System.Drawing.Size(100, 22);
            this.lblMauSac.TabIndex = 12;
            this.lblMauSac.Text = "Màu sắc";
            // 
            // txtMauSac
            // 
            this.txtMauSac.Location = new System.Drawing.Point(135, 248);
            this.txtMauSac.Name = "txtMauSac";
            this.txtMauSac.Size = new System.Drawing.Size(220, 30);
            this.txtMauSac.TabIndex = 13;
            // 
            // lblDungLuong
            // 
            this.lblDungLuong.Location = new System.Drawing.Point(20, 287);
            this.lblDungLuong.Name = "lblDungLuong";
            this.lblDungLuong.Size = new System.Drawing.Size(100, 22);
            this.lblDungLuong.TabIndex = 14;
            this.lblDungLuong.Text = "Dung lượng";
            // 
            // txtDungLuong
            // 
            this.txtDungLuong.Location = new System.Drawing.Point(135, 284);
            this.txtDungLuong.Name = "txtDungLuong";
            this.txtDungLuong.Size = new System.Drawing.Size(220, 30);
            this.txtDungLuong.TabIndex = 15;
            // 
            // lblRam
            // 
            this.lblRam.Location = new System.Drawing.Point(20, 323);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(100, 22);
            this.lblRam.TabIndex = 16;
            this.lblRam.Text = "RAM";
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(135, 320);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(220, 30);
            this.txtRam.TabIndex = 17;
            // 
            // lblPhienBan
            // 
            this.lblPhienBan.Location = new System.Drawing.Point(20, 359);
            this.lblPhienBan.Name = "lblPhienBan";
            this.lblPhienBan.Size = new System.Drawing.Size(100, 22);
            this.lblPhienBan.TabIndex = 18;
            this.lblPhienBan.Text = "Phiên bản";
            // 
            // txtPhienBan
            // 
            this.txtPhienBan.Location = new System.Drawing.Point(135, 356);
            this.txtPhienBan.Name = "txtPhienBan";
            this.txtPhienBan.Size = new System.Drawing.Size(220, 30);
            this.txtPhienBan.TabIndex = 19;
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.Location = new System.Drawing.Point(20, 395);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(100, 22);
            this.lblGiaBan.TabIndex = 20;
            this.lblGiaBan.Text = "Giá bán";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(135, 392);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(220, 30);
            this.txtGiaBan.TabIndex = 21;
            // 
            // lblTonKho
            // 
            this.lblTonKho.Location = new System.Drawing.Point(20, 431);
            this.lblTonKho.Name = "lblTonKho";
            this.lblTonKho.Size = new System.Drawing.Size(100, 22);
            this.lblTonKho.TabIndex = 22;
            this.lblTonKho.Text = "Tồn kho";
            // 
            // txtTonKho
            // 
            this.txtTonKho.Location = new System.Drawing.Point(135, 428);
            this.txtTonKho.Name = "txtTonKho";
            this.txtTonKho.Size = new System.Drawing.Size(220, 30);
            this.txtTonKho.TabIndex = 23;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(20, 475);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 36);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(179)))), ((int)(((byte)(8)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(110, 475);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 36);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(200, 475);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 36);
            this.btnLamMoi.TabIndex = 26;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnDong.FlatAppearance.BorderSize = 0;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(300, 475);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(70, 36);
            this.btnDong.TabIndex = 27;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // GUI_SuaThemSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1120, 650);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "GUI_SuaThemSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm / Sửa sản phẩm";
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
