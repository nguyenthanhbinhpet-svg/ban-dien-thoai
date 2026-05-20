namespace GUI_PhoneStore
{
    partial class GUI_SanPham
    {

        private System.ComponentModel.IContainer components = null;

        // ── Top bar ──
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnKhoaMo;

        // ── Filter bar ──
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboLocDanhMuc;
        private System.Windows.Forms.ComboBox cboLocThuongHieu;
        private System.Windows.Forms.Label lblKetQua;

        // ── Vùng hiển thị cards ──
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.FlowLayoutPanel flpCards;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnKhoaMo = new System.Windows.Forms.Button();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cboLocDanhMuc = new System.Windows.Forms.ComboBox();
            this.cboLocThuongHieu = new System.Windows.Forms.ComboBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.flpCards = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTopBar.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Controls.Add(this.btnThem);
            this.pnlTopBar.Controls.Add(this.btnKhoaMo);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.pnlTopBar.Size = new System.Drawing.Size(1240, 60);
            this.pnlTopBar.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ SẢN PHẨM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(877, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(210, 36);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "+ Thêm/ Sửa SP";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnKhoaMo
            // 
            this.btnKhoaMo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnKhoaMo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhoaMo.Enabled = false;
            this.btnKhoaMo.FlatAppearance.BorderSize = 0;
            this.btnKhoaMo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoaMo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnKhoaMo.ForeColor = System.Drawing.Color.White;
            this.btnKhoaMo.Location = new System.Drawing.Point(1106, 12);
            this.btnKhoaMo.Name = "btnKhoaMo";
            this.btnKhoaMo.Size = new System.Drawing.Size(105, 36);
            this.btnKhoaMo.TabIndex = 3;
            this.btnKhoaMo.Text = "🔒 Khóa/Mở";
            this.btnKhoaMo.UseVisualStyleBackColor = false;
            this.btnKhoaMo.Click += new System.EventHandler(this.btnKhoaMo_Click);
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlFilter.Controls.Add(this.btnTim);
            this.pnlFilter.Controls.Add(this.txtTimKiem);
            this.pnlFilter.Controls.Add(this.cboLocDanhMuc);
            this.pnlFilter.Controls.Add(this.cboLocThuongHieu);
            this.pnlFilter.Controls.Add(this.lblKetQua);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 60);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.pnlFilter.Size = new System.Drawing.Size(1240, 56);
            this.pnlFilter.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Location = new System.Drawing.Point(354, 12);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(110, 36);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm ";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiem.Location = new System.Drawing.Point(16, 14);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(320, 30);
            this.txtTimKiem.TabIndex = 0;
            // 
            // cboLocDanhMuc
            // 
            this.cboLocDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboLocDanhMuc.Location = new System.Drawing.Point(534, 17);
            this.cboLocDanhMuc.Name = "cboLocDanhMuc";
            this.cboLocDanhMuc.Size = new System.Drawing.Size(180, 29);
            this.cboLocDanhMuc.TabIndex = 1;
            this.cboLocDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cboLocDanhMuc_SelectedIndexChanged);
            // 
            // cboLocThuongHieu
            // 
            this.cboLocThuongHieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocThuongHieu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboLocThuongHieu.Location = new System.Drawing.Point(720, 17);
            this.cboLocThuongHieu.Name = "cboLocThuongHieu";
            this.cboLocThuongHieu.Size = new System.Drawing.Size(160, 29);
            this.cboLocThuongHieu.TabIndex = 2;
            this.cboLocThuongHieu.SelectedIndexChanged += new System.EventHandler(this.cboLocThuongHieu_SelectedIndexChanged);
            // 
            // lblKetQua
            // 
            this.lblKetQua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKetQua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKetQua.Location = new System.Drawing.Point(898, 19);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(300, 22);
            this.lblKetQua.TabIndex = 3;
            this.lblKetQua.Text = "Hiển thị: 0 sản phẩm";
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlContent.Controls.Add(this.flpCards);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 116);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(12);
            this.pnlContent.Size = new System.Drawing.Size(1240, 604);
            this.pnlContent.TabIndex = 0;
            // 
            // flpCards
            // 
            this.flpCards.AutoScroll = true;
            this.flpCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCards.Location = new System.Drawing.Point(12, 12);
            this.flpCards.Name = "flpCards";
            this.flpCards.Padding = new System.Windows.Forms.Padding(8);
            this.flpCards.Size = new System.Drawing.Size(1216, 580);
            this.flpCards.TabIndex = 0;
            // 
            // GUI_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1240, 720);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "GUI_SanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý Sản phẩm";
            this.Load += new System.EventHandler(this.GUI_SanPham_Load);
            this.Resize += new System.EventHandler(this.GUI_SanPham_Resize);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnTim;
    }
}