using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using BUS_PhoneStore;

namespace GUI_PhoneStore
{
    public partial class GUI_SanPham : Form
    {
        private readonly BUS_SanPham _bus = new BUS_SanPham();

        private DataTable _dtSanPham;
        private DataView _viewSanPham;
        private DataRowView _spDangChon = null;
        private Panel _cardDangChon = null;

        private const int CARD_W = 210;
        private const int CARD_H = 290;

        public GUI_SanPham()
        {
            InitializeComponent();
        }

        private void GUI_SanPham_Load(object sender, EventArgs e)
        {
            NapComboFilter();
            TaiDuLieu();
        }

        // =========================================================
        // NẠP COMBOBOX DANH MỤC VÀ THƯƠNG HIỆU
        // =========================================================

        private void NapComboFilter()
        {
            DataTable dtDM = _bus.GetDanhMuc();
            DataRow rowDM = dtDM.NewRow();
            rowDM["MaDanhMuc"] = 0;
            rowDM["TenDanhMuc"] = "-- Tất cả danh mục --";
            dtDM.Rows.InsertAt(rowDM, 0);

            cboLocDanhMuc.DataSource = dtDM;
            cboLocDanhMuc.DisplayMember = "TenDanhMuc";
            cboLocDanhMuc.ValueMember = "MaDanhMuc";

            DataTable dtTH = _bus.GetThuongHieu();
            DataRow rowTH = dtTH.NewRow();
            rowTH["MaThuongHieu"] = 0;
            rowTH["TenThuongHieu"] = "-- Tất cả hãng --";
            dtTH.Rows.InsertAt(rowTH, 0);

            cboLocThuongHieu.DataSource = dtTH;
            cboLocThuongHieu.DisplayMember = "TenThuongHieu";
            cboLocThuongHieu.ValueMember = "MaThuongHieu";
        }
        // =========================================================
        // TẢI DỮ LIỆU SẢN PHẨM TỪ DATABASE
        // =========================================================
        private void TaiDuLieu()
        {
            _dtSanPham = _bus.GetDanhSachSanPham();
            _viewSanPham = new DataView(_dtSanPham);
            LocVaRender();
        }
        // =========================================================
        // XỬ LÝ CHUỖI TRƯỚC KHI ĐƯA VÀO RowFilter
        // Tránh lỗi khi người dùng nhập ký tự đặc biệt
        // =========================================================
        private void LocVaRender()
        {
            if (_viewSanPham == null)
                return;

            string keyword = txtTimKiem.Text.Trim();

            string danhMuc = cboLocDanhMuc.Text;
            string thuongHieu = cboLocThuongHieu.Text;

            DataTable dtKetQua = _dtSanPham.Clone();

            foreach (DataRow row in _dtSanPham.Rows)
            {
                bool hopLe = true;

                // Lọc theo danh mục
                if (!string.IsNullOrWhiteSpace(danhMuc) &&
                    danhMuc != "-- Tất cả danh mục --")
                {
                    string tenDanhMuc = GetString(row, "TenDanhMuc");

                    if (!tenDanhMuc.Equals(danhMuc, StringComparison.OrdinalIgnoreCase))
                        hopLe = false;
                }

                // Lọc theo thương hiệu
                if (!string.IsNullOrWhiteSpace(thuongHieu) &&
                    thuongHieu != "-- Tất cả hãng --")
                {
                    string tenThuongHieu = GetString(row, "TenThuongHieu");

                    if (!tenThuongHieu.Equals(thuongHieu, StringComparison.OrdinalIgnoreCase))
                        hopLe = false;
                }

                // Lọc theo từ khóa khi bấm nút tìm
                if (hopLe && !string.IsNullOrWhiteSpace(keyword))
                {
                    if (!KhopTuKhoa(row, keyword))
                        hopLe = false;
                }

                if (hopLe)
                    dtKetQua.ImportRow(row);
            }

            DataView viewKetQua = new DataView(dtKetQua);
            RenderCards(viewKetQua);
        }

        private string EscapeFilter(string value)
        {
            return value.Replace("'", "''")
                        .Replace("[", "[[]")
                        .Replace("%", "[%]")
                        .Replace("*", "[*]");
        }
        // =========================================================
        // RENDER DANH SÁCH SẢN PHẨM THÀNH CÁC CARD
        // =========================================================
        private void RenderCards(DataView view)
        {
            flpCards.SuspendLayout();
            flpCards.Controls.Clear();

            _spDangChon = null;
            _cardDangChon = null;
            BatTatNut(false);

            foreach (DataRowView row in view)
            {
                flpCards.Controls.Add(TaoCard(row));
            }

            lblKetQua.Text = "Hiển thị: " + view.Count + " sản phẩm";
            flpCards.ResumeLayout();
        }

        private Panel TaoCard(DataRowView row)
        {
            int tonKho = GetInt(row, "TonKho");

            bool hetHang = tonKho <= 0;
            bool dangMoBan = GetBool(row, "TrangThaiChiTiet");
            bool biKhoa = !dangMoBan;

            // Nếu hết hàng hoặc bị khóa thì làm mờ card
            bool canLamMo = hetHang || biKhoa;

            Panel card = new Panel();
            card.Size = new Size(CARD_W, CARD_H);
            card.Margin = new Padding(8);
            card.BackColor = canLamMo ? Color.FromArgb(245, 245, 245) : Color.White;
            card.Cursor = Cursors.Hand;
            card.Tag = row;

            card.Paint += Card_Paint;

            PictureBox pic = new PictureBox();
            pic.Size = new Size(CARD_W, 160);
            pic.Location = new Point(0, 0);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.BackColor = canLamMo
                ? Color.FromArgb(230, 230, 230)
                : Color.FromArgb(248, 250, 252);
            pic.Image = TaoAnhPlaceholder(CARD_W, 160);

            // Badge trạng thái
            if (biKhoa)
            {
                Label badge = new Label();
                badge.Text = "ĐÃ KHÓA";
                badge.BackColor = Color.FromArgb(120, 120, 120);
                badge.ForeColor = Color.White;
                badge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                badge.TextAlign = ContentAlignment.MiddleCenter;
                badge.Size = new Size(CARD_W, 28);
                badge.Location = new Point(0, 66);
                pic.Controls.Add(badge);
            }
            else if (hetHang)
            {
                Label badge = new Label();
                badge.Text = "HẾT HÀNG";
                badge.BackColor = Color.FromArgb(220, 38, 38);
                badge.ForeColor = Color.White;
                badge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                badge.TextAlign = ContentAlignment.MiddleCenter;
                badge.Size = new Size(CARD_W, 28);
                badge.Location = new Point(0, 66);
                pic.Controls.Add(badge);
            }

            Label lblTen = new Label();
            lblTen.Text = GetString(row, "TenSanPham");
            lblTen.Location = new Point(10, 166);
            lblTen.Size = new Size(CARD_W - 20, 36);
            lblTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTen.ForeColor = canLamMo
                ? Color.FromArgb(150, 150, 150)
                : Color.FromArgb(30, 30, 46);

            Label lblMeta = new Label();
            lblMeta.Text = GetString(row, "TenThuongHieu") + " • " +
                           GetString(row, "MauSac") + " • " +
                           GetString(row, "DungLuong");
            lblMeta.Location = new Point(10, 202);
            lblMeta.Size = new Size(CARD_W - 20, 20);
            lblMeta.Font = new Font("Segoe UI", 8F);
            lblMeta.ForeColor = canLamMo
                ? Color.FromArgb(170, 170, 170)
                : Color.FromArgb(100, 116, 139);

            Label lblGia = new Label();
            lblGia.Text = GetDecimal(row, "GiaBan").ToString("N0") + "đ";
            lblGia.Location = new Point(10, 224);
            lblGia.Size = new Size(CARD_W - 20, 24);
            lblGia.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblGia.ForeColor = canLamMo
                ? Color.FromArgb(160, 160, 160)
                : Color.FromArgb(239, 68, 68);

            Label lblTon = new Label();

            if (biKhoa)
                lblTon.Text = "Đã khóa";
            else if (hetHang)
                lblTon.Text = "Hết hàng";
            else
                lblTon.Text = "Còn: " + tonKho;

            lblTon.Location = new Point(10, 252);
            lblTon.Size = new Size(CARD_W - 20, 20);
            lblTon.Font = new Font("Segoe UI", 8F);
            lblTon.ForeColor = canLamMo
                ? Color.FromArgb(150, 150, 150)
                : Color.FromArgb(34, 197, 94);

            EventHandler clickHandler = (s, e) => ChonCard(card, row);

            card.Click += clickHandler;
            pic.Click += clickHandler;
            lblTen.Click += clickHandler;
            lblMeta.Click += clickHandler;
            lblGia.Click += clickHandler;
            lblTon.Click += clickHandler;

            card.Controls.Add(pic);
            card.Controls.Add(lblTen);
            card.Controls.Add(lblMeta);
            card.Controls.Add(lblGia);
            card.Controls.Add(lblTon);

            return card;
        }

        private void Card_Paint(object sender, PaintEventArgs e)
        {
            Panel card = sender as Panel;
            if (card == null) return;

            Color borderColor = (_cardDangChon == card)
                ? Color.FromArgb(99, 102, 241)
                : Color.FromArgb(226, 232, 240);

            int borderSize = (_cardDangChon == card) ? 2 : 1;

            using (Pen pen = new Pen(borderColor, borderSize))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
            }
        }

        private void ChonCard(Panel card, DataRowView row)
        {
            if (_cardDangChon != null)
                _cardDangChon.Invalidate();

            _cardDangChon = card;
            _spDangChon = row;

            card.Invalidate();
            BatTatNut(true);
        }

        private void BatTatNut(bool coChon)
        {
            btnKhoaMo.Enabled = coChon;

            if (coChon && _spDangChon != null)
            {
                bool trangThai = GetBool(_spDangChon, "TrangThaiChiTiet");
                btnKhoaMo.Text = trangThai ? "🔒 Khóa SP" : "🔓 Mở SP";
            }
            else
            {
                btnKhoaMo.Text = "🔒 Khóa/Mở";
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
        }

        private void cboLocDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocVaRender();
        }

        private void cboLocThuongHieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocVaRender();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (GUI_SuaThemSP frm = new GUI_SuaThemSP())
            {
                frm.ShowDialog(this);
            }

            TaiDuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_spDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa.");
                return;
            }

            MessageBox.Show(
                "Chức năng sửa sản phẩm cần tạo form GUI_ThemSuaSanPham riêng.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnKhoaMo_Click(object sender, EventArgs e)
        {
            if (_spDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần khóa/mở.");
                return;
            }

            int maChiTietSP = GetInt(_spDangChon, "MaChiTietSP");
            bool trangThai = GetBool(_spDangChon, "TrangThaiChiTiet");

            string hanhDong = trangThai ? "khóa" : "mở";

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn " + hanhDong + " sản phẩm này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
                return;

            bool ok = _bus.CapNhatTrangThaiChiTiet(maChiTietSP, !trangThai);

            MessageBox.Show(ok ? "Cập nhật thành công." : "Cập nhật thất bại.");

            if (ok)
                TaiDuLieu();
        }

        private void GUI_SanPham_Resize(object sender, EventArgs e)
        {
            flpCards.Invalidate();
        }

        private Image TaoAnhPlaceholder(int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.FromArgb(241, 245, 249));

                using (Pen pen = new Pen(Color.FromArgb(203, 213, 225), 2))
                {
                    g.DrawRectangle(pen, 1, 1, w - 3, h - 3);
                }

                using (Font font = new Font("Segoe UI", 28F))
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;

                    g.DrawString(
                        "📱",
                        font,
                        Brushes.LightGray,
                        new RectangleF(0, 0, w, h),
                        sf
                    );
                }
            }

            return bmp;
        }

        private string GetString(DataRowView row, string columnName)
        {
            if (row == null || row.Row.Table.Columns.Contains(columnName) == false)
                return "";

            object value = row[columnName];
            return value == null || value == DBNull.Value ? "" : value.ToString();
        }

        private int GetInt(DataRowView row, string columnName)
        {
            int result;
            int.TryParse(GetString(row, columnName), out result);
            return result;
        }

        private decimal GetDecimal(DataRowView row, string columnName)
        {
            decimal result;
            decimal.TryParse(GetString(row, columnName), out result);
            return result;
        }

        private bool GetBool(DataRowView row, string columnName)
        {
            if (row == null || row.Row.Table.Columns.Contains(columnName) == false)
                return false;

            object value = row[columnName];

            if (value == null || value == DBNull.Value)
                return false;

            if (value is bool)
                return (bool)value;

            string text = value.ToString().Trim();

            if (text == "1")
                return true;

            if (text == "0")
                return false;

            bool result;
            bool.TryParse(text, out result);
            return result;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LocVaRender();
        }
        private bool KhopTuKhoa(DataRow row, string keyword)
        {
            string maSanPham = GetString(row, "MaSanPham");
            string tenSanPham = GetString(row, "TenSanPham");
            string sku = GetString(row, "SKU");
            string tenThuongHieu = GetString(row, "TenThuongHieu");
            string mauSac = GetString(row, "MauSac");
            string dungLuong = GetString(row, "DungLuong");
            string ram = GetString(row, "Ram");
            string phienBan = GetString(row, "PhienBan");

            string noiDung =
                maSanPham + " " +
                tenSanPham + " " +
                sku + " " +
                tenThuongHieu + " " +
                mauSac + " " +
                dungLuong + " " +
                ram + " " +
                phienBan;

            string noiDungChuan = ChuanHoa(noiDung);
            string keywordChuan = ChuanHoa(keyword);

            string noiDungLien = BoKhoangTrang(noiDungChuan);
            string keywordLien = BoKhoangTrang(keywordChuan);

            string vietTatTenSP = TaoTenVietTat(tenSanPham);
            string vietTatThuongHieu = TaoTenVietTat(tenThuongHieu);

            // 1. Tìm trực tiếp: "anker", "iphone", "usb", "ip15"
            if (noiDungChuan.Contains(keywordChuan))
                return true;

            // 2. Tìm không cần khoảng trắng / dấu gạch: "ankerusbc", "ip15pm256blk"
            if (noiDungLien.Contains(keywordLien))
                return true;

            // 3. Tìm theo tên viết tắt: "causbc", "clip15", "sanii65w"
            if (vietTatTenSP.Contains(keywordLien))
                return true;

            if (vietTatThuongHieu.Contains(keywordLien))
                return true;

            // 4. Tìm nhiều từ rời nhau: "anker 60w", "ip15 blk", "sony wh"
            string[] arr = keywordChuan.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            bool tatCaTuDeuKhop = true;

            foreach (string tu in arr)
            {
                string tuLien = BoKhoangTrang(tu);

                if (!noiDungChuan.Contains(tu) &&
                    !noiDungLien.Contains(tuLien) &&
                    !vietTatTenSP.Contains(tuLien))
                {
                    tatCaTuDeuKhop = false;
                    break;
                }
            }

            return tatCaTuDeuKhop;
        }

        private string GetString(DataRow row, string columnName)
        {
            if (row == null || row.Table.Columns.Contains(columnName) == false)
                return "";

            object value = row[columnName];

            return value == null || value == DBNull.Value ? "" : value.ToString();
        }

        private string ChuanHoa(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return "";

            text = text.ToLower().Trim();

            text = text.Replace("đ", "d");

            string normalized = text.Normalize(System.Text.NormalizationForm.FormD);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            foreach (char c in normalized)
            {
                System.Globalization.UnicodeCategory uc =
                    System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c);

                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    if (char.IsLetterOrDigit(c))
                        sb.Append(c);
                    else
                        sb.Append(' ');
                }
            }

            return System.Text.RegularExpressions.Regex
                .Replace(sb.ToString(), @"\s+", " ")
                .Trim();
        }

        private string BoKhoangTrang(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return "";

            return text.Replace(" ", "");
        }

        private string TaoTenVietTat(string text)
        {
            text = ChuanHoa(text);

            if (string.IsNullOrWhiteSpace(text))
                return "";

            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            foreach (string word in words)
            {
                if (word.Length > 0)
                    sb.Append(word[0]);

                // Giữ lại số trong tên, ví dụ iPhone 15 Pro -> i15p
                foreach (char c in word)
                {
                    if (char.IsDigit(c))
                        sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}