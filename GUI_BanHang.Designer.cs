using System.Drawing;
using System.Windows.Forms;

namespace GUI_PhoneStore
{
    partial class GUI_BanHang
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblSanPham;
        private Label lblGio;
        private Label lblSoLuong;
        private Label lblKhach;
        private Label lblTongTien;
        private Label lblGiamGia;
        private Label lblThanhTien;
        private Label lblPTTT;
        private Label lblGhiChu;

        private TextBox txtTimSP;
        private TextBox txtSoLuong;
        private TextBox txtSDTKhach;
        private TextBox txtGhiChu;

        private Button btnTimSP;
        private Button btnThemGio;
        private Button btnXoaGio;
        private Button btnTimKH;
        private Button btnKhachVangLai;
        private Button btnThanhToan;
        private Button btnLamMoi;

        private DataGridView dgvSanPham;
        private DataGridView dgvGioHang;

        private ComboBox cboPTTT;

        private GroupBox grpKhach;
        private GroupBox grpThanhToan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.lblGio = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblKhach = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblPTTT = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtTimSP = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtSDTKhach = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnTimSP = new System.Windows.Forms.Button();
            this.btnThemGio = new System.Windows.Forms.Button();
            this.btnXoaGio = new System.Windows.Forms.Button();
            this.btnTimKH = new System.Windows.Forms.Button();
            this.btnKhachVangLai = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.cboPTTT = new System.Windows.Forms.ComboBox();
            this.grpKhach = new System.Windows.Forms.GroupBox();
            this.grpThanhToan = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.grpKhach.SuspendLayout();
            this.grpThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.lblTitle.Location = new System.Drawing.Point(25, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(420, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🛒 QUẢN LÝ BÁN HÀNG";
            // 
            // lblSanPham
            // 
            this.lblSanPham.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.lblSanPham.Location = new System.Drawing.Point(30, 68);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(220, 25);
            this.lblSanPham.TabIndex = 1;
            this.lblSanPham.Text = "Danh sách sản phẩm";
            // 
            // lblGio
            // 
            this.lblGio.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblGio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.lblGio.Location = new System.Drawing.Point(30, 465);
            this.lblGio.Name = "lblGio";
            this.lblGio.Size = new System.Drawing.Size(180, 25);
            this.lblGio.TabIndex = 8;
            this.lblGio.Text = "Giỏ hàng";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.lblSoLuong.Location = new System.Drawing.Point(465, 73);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(60, 22);
            this.lblSoLuong.TabIndex = 4;
            this.lblSoLuong.Text = "SL";
            // 
            // lblKhach
            // 
            this.lblKhach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblKhach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblKhach.Location = new System.Drawing.Point(20, 75);
            this.lblKhach.Name = "lblKhach";
            this.lblKhach.Size = new System.Drawing.Size(315, 42);
            this.lblKhach.TabIndex = 2;
            this.lblKhach.Text = "Khách: Chưa chọn\r\nLoại: --";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTongTien.Location = new System.Drawing.Point(20, 215);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(310, 28);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "Tổng tiền: 0 đ";
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGiamGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.lblGiamGia.Location = new System.Drawing.Point(20, 248);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(310, 28);
            this.lblGiamGia.TabIndex = 5;
            this.lblGiamGia.Text = "Giảm giá: 0 đ";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblThanhTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblThanhTien.Location = new System.Drawing.Point(20, 282);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(310, 38);
            this.lblThanhTien.TabIndex = 6;
            this.lblThanhTien.Text = "Thành tiền: 0 đ";
            // 
            // lblPTTT
            // 
            this.lblPTTT.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPTTT.Location = new System.Drawing.Point(20, 32);
            this.lblPTTT.Name = "lblPTTT";
            this.lblPTTT.Size = new System.Drawing.Size(230, 22);
            this.lblPTTT.TabIndex = 0;
            this.lblPTTT.Text = "Phương thức thanh toán";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblGhiChu.Location = new System.Drawing.Point(20, 98);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(120, 22);
            this.lblGhiChu.TabIndex = 2;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // txtTimSP
            // 
            this.txtTimSP.Location = new System.Drawing.Point(30, 98);
            this.txtTimSP.Name = "txtTimSP";
            this.txtTimSP.Size = new System.Drawing.Size(320, 29);
            this.txtTimSP.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(465, 98);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(65, 29);
            this.txtSoLuong.TabIndex = 5;
            this.txtSoLuong.Text = "1";
            // 
            // txtSDTKhach
            // 
            this.txtSDTKhach.Location = new System.Drawing.Point(20, 32);
            this.txtSDTKhach.Name = "txtSDTKhach";
            this.txtSDTKhach.Size = new System.Drawing.Size(200, 30);
            this.txtSDTKhach.TabIndex = 0;
            this.txtSDTKhach.TextChanged += new System.EventHandler(this.txtSDTKhach_TextChanged);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(20, 122);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGhiChu.Size = new System.Drawing.Size(310, 80);
            this.txtGhiChu.TabIndex = 3;
            // 
            // btnTimSP
            // 
            this.btnTimSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnTimSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimSP.FlatAppearance.BorderSize = 0;
            this.btnTimSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimSP.ForeColor = System.Drawing.Color.White;
            this.btnTimSP.Location = new System.Drawing.Point(355, 96);
            this.btnTimSP.Name = "btnTimSP";
            this.btnTimSP.Size = new System.Drawing.Size(95, 33);
            this.btnTimSP.TabIndex = 3;
            this.btnTimSP.Text = "Tìm";
            this.btnTimSP.UseVisualStyleBackColor = false;
            this.btnTimSP.Click += new System.EventHandler(this.btnTimSP_Click);
            // 
            // btnThemGio
            // 
            this.btnThemGio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnThemGio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemGio.FlatAppearance.BorderSize = 0;
            this.btnThemGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemGio.ForeColor = System.Drawing.Color.White;
            this.btnThemGio.Location = new System.Drawing.Point(540, 96);
            this.btnThemGio.Name = "btnThemGio";
            this.btnThemGio.Size = new System.Drawing.Size(125, 33);
            this.btnThemGio.TabIndex = 6;
            this.btnThemGio.Text = "Thêm vào giỏ";
            this.btnThemGio.UseVisualStyleBackColor = false;
            this.btnThemGio.Click += new System.EventHandler(this.btnThemGio_Click);
            // 
            // btnXoaGio
            // 
            this.btnXoaGio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnXoaGio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaGio.FlatAppearance.BorderSize = 0;
            this.btnXoaGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaGio.ForeColor = System.Drawing.Color.White;
            this.btnXoaGio.Location = new System.Drawing.Point(610, 460);
            this.btnXoaGio.Name = "btnXoaGio";
            this.btnXoaGio.Size = new System.Drawing.Size(140, 33);
            this.btnXoaGio.TabIndex = 9;
            this.btnXoaGio.Text = "Xóa khỏi giỏ";
            this.btnXoaGio.UseVisualStyleBackColor = false;
            this.btnXoaGio.Click += new System.EventHandler(this.btnXoaGio_Click);
            // 
            // btnTimKH
            // 
            this.btnTimKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnTimKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKH.FlatAppearance.BorderSize = 0;
            this.btnTimKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKH.ForeColor = System.Drawing.Color.White;
            this.btnTimKH.Location = new System.Drawing.Point(230, 30);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(105, 33);
            this.btnTimKH.TabIndex = 1;
            this.btnTimKH.Text = "Tìm KH";
            this.btnTimKH.UseVisualStyleBackColor = false;
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKH_Click);
            // 
            // btnKhachVangLai
            // 
            this.btnKhachVangLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnKhachVangLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhachVangLai.FlatAppearance.BorderSize = 0;
            this.btnKhachVangLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachVangLai.ForeColor = System.Drawing.Color.White;
            this.btnKhachVangLai.Location = new System.Drawing.Point(190, 120);
            this.btnKhachVangLai.Name = "btnKhachVangLai";
            this.btnKhachVangLai.Size = new System.Drawing.Size(145, 33);
            this.btnKhachVangLai.TabIndex = 3;
            this.btnKhachVangLai.Text = "Khách vãng lai";
            this.btnKhachVangLai.UseVisualStyleBackColor = false;
            this.btnKhachVangLai.Click += new System.EventHandler(this.btnKhachVangLai_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(25, 335);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(145, 48);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "💰 Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(185, 335);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(145, 48);
            this.btnLamMoi.TabIndex = 8;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSanPham.ColumnHeadersHeight = 29;
            this.dgvSanPham.EnableHeadersVisualStyles = false;
            this.dgvSanPham.Location = new System.Drawing.Point(30, 140);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(720, 310);
            this.dgvSanPham.TabIndex = 7;
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.AllowUserToDeleteRows = false;
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGioHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGioHang.ColumnHeadersHeight = 29;
            this.dgvGioHang.EnableHeadersVisualStyles = false;
            this.dgvGioHang.Location = new System.Drawing.Point(30, 500);
            this.dgvGioHang.MultiSelect = false;
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.RowHeadersVisible = false;
            this.dgvGioHang.RowHeadersWidth = 51;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(720, 170);
            this.dgvGioHang.TabIndex = 10;
            // 
            // cboPTTT
            // 
            this.cboPTTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPTTT.Location = new System.Drawing.Point(20, 60);
            this.cboPTTT.Name = "cboPTTT";
            this.cboPTTT.Size = new System.Drawing.Size(310, 31);
            this.cboPTTT.TabIndex = 1;
            // 
            // grpKhach
            // 
            this.grpKhach.BackColor = System.Drawing.Color.White;
            this.grpKhach.Controls.Add(this.txtSDTKhach);
            this.grpKhach.Controls.Add(this.btnTimKH);
            this.grpKhach.Controls.Add(this.lblKhach);
            this.grpKhach.Controls.Add(this.btnKhachVangLai);
            this.grpKhach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpKhach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.grpKhach.Location = new System.Drawing.Point(770, 80);
            this.grpKhach.Name = "grpKhach";
            this.grpKhach.Size = new System.Drawing.Size(355, 170);
            this.grpKhach.TabIndex = 11;
            this.grpKhach.TabStop = false;
            this.grpKhach.Text = "Khách hàng";
            // 
            // grpThanhToan
            // 
            this.grpThanhToan.BackColor = System.Drawing.Color.White;
            this.grpThanhToan.Controls.Add(this.lblPTTT);
            this.grpThanhToan.Controls.Add(this.cboPTTT);
            this.grpThanhToan.Controls.Add(this.lblGhiChu);
            this.grpThanhToan.Controls.Add(this.txtGhiChu);
            this.grpThanhToan.Controls.Add(this.lblTongTien);
            this.grpThanhToan.Controls.Add(this.lblGiamGia);
            this.grpThanhToan.Controls.Add(this.lblThanhTien);
            this.grpThanhToan.Controls.Add(this.btnThanhToan);
            this.grpThanhToan.Controls.Add(this.btnLamMoi);
            this.grpThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.grpThanhToan.Location = new System.Drawing.Point(770, 265);
            this.grpThanhToan.Name = "grpThanhToan";
            this.grpThanhToan.Size = new System.Drawing.Size(355, 405);
            this.grpThanhToan.TabIndex = 12;
            this.grpThanhToan.TabStop = false;
            this.grpThanhToan.Text = "Thanh toán";
            // 
            // GUI_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1150, 720);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSanPham);
            this.Controls.Add(this.txtTimSP);
            this.Controls.Add(this.btnTimSP);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.btnThemGio);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.lblGio);
            this.Controls.Add(this.btnXoaGio);
            this.Controls.Add(this.dgvGioHang);
            this.Controls.Add(this.grpKhach);
            this.Controls.Add(this.grpThanhToan);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "GUI_BanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bán hàng - Phone Store";
            this.Load += new System.EventHandler(this.GUI_BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.grpKhach.ResumeLayout(false);
            this.grpKhach.PerformLayout();
            this.grpThanhToan.ResumeLayout(false);
            this.grpThanhToan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}