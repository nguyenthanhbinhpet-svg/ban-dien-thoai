namespace GUI_PhoneStore
{
    partial class GUI_KhachHang
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.GroupBox grpInfo;

        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtLoaiKhach;

        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblLoaiKhach;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblLoaiKhach = new System.Windows.Forms.Label();
            this.txtLoaiKhach = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(420, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.White;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Location = new System.Drawing.Point(27, 62);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(360, 27);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(397, 59);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 32);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(507, 59);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 32);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhachHang.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachHang.EnableHeadersVisualStyles = false;
            this.dgvKhachHang.Location = new System.Drawing.Point(27, 105);
            this.dgvKhachHang.MultiSelect = false;
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(705, 405);
            this.dgvKhachHang.TabIndex = 4;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // grpInfo
            // 
            this.grpInfo.BackColor = System.Drawing.Color.White;
            this.grpInfo.Controls.Add(this.lblMaKH);
            this.grpInfo.Controls.Add(this.txtMaKH);
            this.grpInfo.Controls.Add(this.lblTenKH);
            this.grpInfo.Controls.Add(this.txtTenKH);
            this.grpInfo.Controls.Add(this.lblSDT);
            this.grpInfo.Controls.Add(this.txtSDT);
            this.grpInfo.Controls.Add(this.lblEmail);
            this.grpInfo.Controls.Add(this.txtEmail);
            this.grpInfo.Controls.Add(this.lblDiaChi);
            this.grpInfo.Controls.Add(this.txtDiaChi);
            this.grpInfo.Controls.Add(this.lblLoaiKhach);
            this.grpInfo.Controls.Add(this.txtLoaiKhach);
            this.grpInfo.Controls.Add(this.btnThem);
            this.grpInfo.Controls.Add(this.btnSua);
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.grpInfo.Location = new System.Drawing.Point(755, 62);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(350, 448);
            this.grpInfo.TabIndex = 5;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông tin khách hàng";
            // 
            // lblMaKH
            // 
            this.lblMaKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaKH.Location = new System.Drawing.Point(20, 35);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(110, 22);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã KH";
            // 
            // txtMaKH
            // 
            this.txtMaKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtMaKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKH.Location = new System.Drawing.Point(135, 32);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(185, 30);
            this.txtMaKH.TabIndex = 1;
            // 
            // lblTenKH
            // 
            this.lblTenKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenKH.Location = new System.Drawing.Point(20, 78);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(110, 22);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "Tên khách";
            // 
            // txtTenKH
            // 
            this.txtTenKH.BackColor = System.Drawing.Color.White;
            this.txtTenKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenKH.Location = new System.Drawing.Point(135, 75);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(185, 30);
            this.txtTenKH.TabIndex = 3;
            // 
            // lblSDT
            // 
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSDT.Location = new System.Drawing.Point(20, 121);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(110, 22);
            this.lblSDT.TabIndex = 4;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.White;
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT.Location = new System.Drawing.Point(135, 118);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(185, 30);
            this.txtSDT.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.Location = new System.Drawing.Point(20, 164);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(110, 22);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(135, 161);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 30);
            this.txtEmail.TabIndex = 7;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiaChi.Location = new System.Drawing.Point(20, 207);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(110, 22);
            this.lblDiaChi.TabIndex = 8;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.White;
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Location = new System.Drawing.Point(135, 204);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(185, 70);
            this.txtDiaChi.TabIndex = 9;
            // 
            // lblLoaiKhach
            // 
            this.lblLoaiKhach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoaiKhach.Location = new System.Drawing.Point(20, 292);
            this.lblLoaiKhach.Name = "lblLoaiKhach";
            this.lblLoaiKhach.Size = new System.Drawing.Size(110, 22);
            this.lblLoaiKhach.TabIndex = 10;
            this.lblLoaiKhach.Text = "Loại khách";
            // 
            // txtLoaiKhach
            // 
            this.txtLoaiKhach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtLoaiKhach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoaiKhach.Location = new System.Drawing.Point(135, 289);
            this.txtLoaiKhach.Name = "txtLoaiKhach";
            this.txtLoaiKhach.ReadOnly = true;
            this.txtLoaiKhach.Size = new System.Drawing.Size(185, 30);
            this.txtLoaiKhach.TabIndex = 11;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(25, 350);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(135, 38);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(180, 350);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(135, 38);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // GUI_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1130, 535);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.grpInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "GUI_KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.GUI_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
