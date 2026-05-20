using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using BUS_PhoneStore;
using DTO_PhoneStore;

namespace GUI_PhoneStore
{
    public partial class GUI_SuaThemSP : Form
    {
        private BUS_SanPham bus;

        // Lưu khóa chính của dòng đang chọn để sửa
        private int maSPDangChon = -1;
        private int maChiTietSPDdangChon = -1;

        public GUI_SuaThemSP()
        {
            InitializeComponent();
        }

        // Chạy khi form mở thật, không chạy khi đang mở Designer
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            bus = new BUS_SanPham();

            LoadCombo();
            LoadData();
            LamMoi();
        }

        private void LoadCombo()
        {
            DataTable dtThuongHieu = bus.GetThuongHieu();
            cboThuongHieu.DisplayMember = "TenThuongHieu";
            cboThuongHieu.ValueMember = "MaThuongHieu";
            cboThuongHieu.DataSource = dtThuongHieu;

            DataTable dtDanhMuc = bus.GetDanhMuc();
            cboDanhMuc.DisplayMember = "TenDanhMuc";
            cboDanhMuc.ValueMember = "MaDanhMuc";
            cboDanhMuc.DataSource = dtDanhMuc;
        }

        private void LoadData()
        {
            dgvSanPham.DataSource = bus.GetDanhSachSanPham();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

            // Lấy ID để sửa
            maSPDangChon = GetInt(row, "MaSP");
            maChiTietSPDdangChon = GetInt(row, "MaChiTietSP");

            txtMaSP.Text = GetString(row, "MaSanPham");
            txtTenSP.Text = GetString(row, "TenSanPham");
            txtGiaGoc.Text = GetString(row, "GiaGoc");
            txtSKU.Text = GetString(row, "SKU");
            txtMauSac.Text = GetString(row, "MauSac");
            txtDungLuong.Text = GetString(row, "DungLuong");
            txtRam.Text = GetString(row, "Ram");
            txtPhienBan.Text = GetString(row, "PhienBan");
            txtGiaBan.Text = GetString(row, "GiaBan");
            txtTonKho.Text = GetString(row, "TonKho");

            if (dgvSanPham.Columns.Contains("MaThuongHieu"))
                cboThuongHieu.SelectedValue = GetInt(row, "MaThuongHieu");

            if (dgvSanPham.Columns.Contains("MaDanhMuc"))
                cboDanhMuc.SelectedValue = GetInt(row, "MaDanhMuc");

            // Khi sửa thì không cho sửa giá gốc
            txtGiaGoc.ReadOnly = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            decimal giaGoc;
            decimal giaBan;
            int tonKho;

            // Thêm mới thì bắt buộc nhập Giá gốc + Giá bán
            if (!KiemTraNhapThem(out giaGoc, out giaBan, out tonKho))
                return;

            DTO_SanPham sp = TaoSanPham(giaGoc);
            DTO_ChiTietSanPham ct = TaoChiTiet(giaBan, tonKho);

            string thongBao;
            bool ok = bus.ThemSanPham(sp, ct, out thongBao);

            MessageBox.Show(thongBao);

            if (ok)
            {
                LoadData();
                LamMoi();
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemSanPham();
        }

        private void TimKiemSanPham()
        {
            if (bus == null)
                bus = new BUS_SanPham();

            string tuKhoa = txtTimKiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                dgvSanPham.DataSource = bus.GetDanhSachSanPham();
            }
            else
            {
                dgvSanPham.DataSource = bus.TimKiemSanPham(tuKhoa);
            }

            // Sau khi tìm thì bỏ trạng thái đang chọn cũ
            maSPDangChon = -1;
            maChiTietSPDdangChon = -1;
        }
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemSanPham();
                e.SuppressKeyPress = true;
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maSPDangChon <= 0 || maChiTietSPDdangChon <= 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa trong bảng.");
                return;
            }

            decimal giaBan;
            int tonKho;

            // Sửa thì KHÔNG kiểm tra Giá gốc
            if (!KiemTraNhapSua(out giaBan, out tonKho))
                return;

            DTO_SanPham sp = TaoSanPhamKhiSua();
            DTO_ChiTietSanPham ct = TaoChiTiet(giaBan, tonKho);

            string thongBao;
            bool ok = bus.SuaSanPham(maSPDangChon, maChiTietSPDdangChon, sp, ct, out thongBao);

            MessageBox.Show(thongBao);

            if (ok)
            {
                LoadData();
                LamMoi();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            txtTimKiem.Clear();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool KiemTraChung()
        {
            if (cboThuongHieu.SelectedValue == null || cboDanhMuc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn thương hiệu và danh mục.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Mã sản phẩm không được trống.");
                txtMaSP.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Tên sản phẩm không được trống.");
                txtTenSP.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSKU.Text))
            {
                MessageBox.Show("SKU không được trống.");
                txtSKU.Focus();
                return false;
            }

            return true;
        }

        private bool KiemTraNhapThem(out decimal giaGoc, out decimal giaBan, out int tonKho)
        {
            giaGoc = 0;
            giaBan = 0;
            tonKho = 0;

            if (!KiemTraChung())
                return false;

            if (!ParseTien(txtGiaGoc.Text, out giaGoc) || giaGoc <= 0)
            {
                MessageBox.Show("Giá gốc phải là số hợp lệ và lớn hơn 0.");
                txtGiaGoc.Focus();
                return false;
            }

            if (!ParseTien(txtGiaBan.Text, out giaBan) || giaBan <= 0)
            {
                MessageBox.Show("Giá bán phải là số hợp lệ và lớn hơn 0.");
                txtGiaBan.Focus();
                return false;
            }

            if (!int.TryParse(txtTonKho.Text.Trim(), out tonKho) || tonKho < 0)
            {
                MessageBox.Show("Tồn kho phải là số nguyên và không được âm.");
                txtTonKho.Focus();
                return false;
            }

            return true;
        }

        private bool KiemTraNhapSua(out decimal giaBan, out int tonKho)
        {
            giaBan = 0;
            tonKho = 0;

            if (!KiemTraChung())
                return false;

            // Sửa chỉ kiểm tra Giá bán, không kiểm tra Giá gốc
            if (!ParseTien(txtGiaBan.Text, out giaBan) || giaBan <= 0)
            {
                MessageBox.Show("Giá bán phải là số hợp lệ và lớn hơn 0.");
                txtGiaBan.Focus();
                return false;
            }

            if (!int.TryParse(txtTonKho.Text.Trim(), out tonKho) || tonKho < 0)
            {
                MessageBox.Show("Tồn kho phải là số nguyên và không được âm.");
                txtTonKho.Focus();
                return false;
            }

            return true;
        }

        private bool ParseTien(string text, out decimal value)
        {
            value = 0;

            if (string.IsNullOrWhiteSpace(text))
                return false;

            text = text.Trim()
                       .Replace("đ", "")
                       .Replace("Đ", "")
                       .Replace(".", "")
                       .Replace(",", "");

            return decimal.TryParse(text, out value);
        }

        private DTO_SanPham TaoSanPham(decimal giaGoc)
        {
            return new DTO_SanPham
            {
                MaSanPham = txtMaSP.Text.Trim(),
                TenSanPham = txtTenSP.Text.Trim(),
                MaThuongHieu = Convert.ToInt32(cboThuongHieu.SelectedValue),
                MaDanhMuc = Convert.ToInt32(cboDanhMuc.SelectedValue),
                GiaGoc = giaGoc,
                MoTa = "",
                DuongDanAnh = ""
            };
        }

        private DTO_SanPham TaoSanPhamKhiSua()
        {
            return new DTO_SanPham
            {
                MaSanPham = txtMaSP.Text.Trim(),
                TenSanPham = txtTenSP.Text.Trim(),
                MaThuongHieu = Convert.ToInt32(cboThuongHieu.SelectedValue),
                MaDanhMuc = Convert.ToInt32(cboDanhMuc.SelectedValue),

                // Khi sửa không cập nhật giá gốc nữa
                GiaGoc = 0,

                MoTa = "",
                DuongDanAnh = ""
            };
        }

        private DTO_ChiTietSanPham TaoChiTiet(decimal giaBan, int tonKho)
        {
            return new DTO_ChiTietSanPham
            {
                SKU = txtSKU.Text.Trim(),
                MauSac = txtMauSac.Text.Trim(),
                DungLuong = txtDungLuong.Text.Trim(),
                Ram = txtRam.Text.Trim(),
                PhienBan = txtPhienBan.Text.Trim(),
                GiaBan = giaBan,
                TonKho = tonKho
            };
        }

        private void LamMoi()
        {
            maSPDangChon = -1;
            maChiTietSPDdangChon = -1;

            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGiaGoc.Clear();
            txtSKU.Clear();
            txtMauSac.Clear();
            txtDungLuong.Clear();
            txtRam.Clear();
            txtPhienBan.Clear();
            txtGiaBan.Clear();
            txtTonKho.Clear();

            // Khi thêm mới thì cho nhập Giá gốc
            txtGiaGoc.ReadOnly = false;
        }

        private string GetString(DataGridViewRow row, string columnName)
        {
            if (!dgvSanPham.Columns.Contains(columnName))
                return "";

            object value = row.Cells[columnName].Value;
            return value == null || value == DBNull.Value ? "" : value.ToString();
        }

        private int GetInt(DataGridViewRow row, string columnName)
        {
            int result;
            int.TryParse(GetString(row, columnName), out result);
            return result;
        }
    }
}
