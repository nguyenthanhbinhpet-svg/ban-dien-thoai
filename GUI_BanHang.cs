using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using BUS_PhoneStore;
using DTO_PhoneStore;

namespace GUI_PhoneStore
{
    public partial class GUI_BanHang : Form
    {
        private readonly BUS_SanPham busSanPham = new BUS_SanPham();
        private readonly BUS_KhachHang busKhachHang = new BUS_KhachHang();
        private readonly BUS_DonHang busDonHang = new BUS_DonHang();

        private readonly List<DTO_GioHangItem> gioHang = new List<DTO_GioHangItem>();

        private DTO_KhachHang khachHangHienTai;

        public GUI_BanHang()
        {
            InitializeComponent();
        }

        private void GUI_BanHang_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = busSanPham.GetDanhSachSanPham();

            cboPTTT.DataSource = busDonHang.GetPhuongThucThanhToan();
            cboPTTT.DisplayMember = "TenPhuongThuc";
            cboPTTT.ValueMember = "MaPTTT";

            // Mặc định dùng khách vãng lai có MaKH = 1
            khachHangHienTai = busKhachHang.GetById(1);

            HienThiKhach();
            RefreshGioHang();
        }

        private void btnTimSP_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimSP.Text.Trim();

            dgvSanPham.DataSource = busSanPham.TimKiemSanPham(tuKhoa);
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            string sdt = txtSDTKhach.Text.Trim();

            if (string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng.");
                txtSDTKhach.Focus();
                return;
            }

            DTO_KhachHang kh = busKhachHang.GetByPhone(sdt);

            if (kh == null)
            {
                MessageBox.Show(
                    "Không tìm thấy khách hàng.\nBạn có thể thêm khách ở màn hình Quản lý khách hàng hoặc dùng Khách vãng lai.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            khachHangHienTai = kh;

            HienThiKhach();

            // Loại khách thay đổi thì phải tính lại giảm giá
            RefreshGioHang();

            MessageBox.Show(
                "Đã tìm thấy khách hàng:\n" +
                khachHangHienTai.TenKH +
                "\nLoại khách: " +
                khachHangHienTai.LoaiKhach,
                "Thông tin khách hàng",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnKhachVangLai_Click(object sender, EventArgs e)
        {
            // Khách vãng lai mặc định trong DB là MaKH = 1
            khachHangHienTai = busKhachHang.GetById(1);

            HienThiKhach();
            RefreshGioHang();
        }

        private void HienThiKhach()
        {
            if (khachHangHienTai == null)
            {
                lblKhach.Text = "Khách: Chưa chọn\r\nLoại: --";
                return;
            }

            // Hiển thị rõ tên khách và loại khách hàng
            lblKhach.Text = "Khách: " + khachHangHienTai.TenKH
                          + "\r\nLoại: " + khachHangHienTai.LoaiKhach;
        }

        private void btnThemGio_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.");
                return;
            }

            int soLuong;

            if (!int.TryParse(txtSoLuong.Text.Trim(), out soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.");
                txtSoLuong.Focus();
                return;
            }

            DataGridViewRow r = dgvSanPham.CurrentRow;

            int tonKho = Convert.ToInt32(r.Cells["TonKho"].Value);
            bool trangThai = Convert.ToBoolean(r.Cells["TrangThaiChiTiet"].Value);

            if (!trangThai)
            {
                MessageBox.Show("Sản phẩm chi tiết này đang ngừng bán.");
                return;
            }

            if (soLuong > tonKho)
            {
                MessageBox.Show("Số lượng mua vượt tồn kho.");
                return;
            }

            int maChiTietSP = Convert.ToInt32(r.Cells["MaChiTietSP"].Value);

            DTO_GioHangItem item = gioHang.Find(x => x.MaChiTietSP == maChiTietSP);

            if (item == null)
            {
                item = new DTO_GioHangItem
                {
                    MaChiTietSP = maChiTietSP,
                    MaSP = Convert.ToInt32(r.Cells["MaSP"].Value),
                    SKU = r.Cells["SKU"].Value.ToString(),
                    TenSanPham = r.Cells["TenSanPham"].Value.ToString(),
                    MauSac = r.Cells["MauSac"].Value.ToString(),
                    DungLuong = r.Cells["DungLuong"].Value.ToString(),
                    SoLuong = soLuong,
                    DonGia = Convert.ToDecimal(r.Cells["GiaBan"].Value)
                };

                gioHang.Add(item);
            }
            else
            {
                if (item.SoLuong + soLuong > tonKho)
                {
                    MessageBox.Show("Tổng số lượng trong giỏ vượt tồn kho.");
                    return;
                }

                item.SoLuong += soLuong;
            }

            RefreshGioHang();
        }

        private void btnXoaGio_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trong giỏ cần xóa.");
                return;
            }

            int maChiTietSP = Convert.ToInt32(dgvGioHang.CurrentRow.Cells["MaChiTietSP"].Value);

            gioHang.RemoveAll(x => x.MaChiTietSP == maChiTietSP);

            RefreshGioHang();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            gioHang.Clear();

            txtTimSP.Clear();
            txtSoLuong.Text = "1";
            txtSDTKhach.Clear();
            txtGhiChu.Clear();

            dgvSanPham.DataSource = busSanPham.GetDanhSachSanPham();

            khachHangHienTai = busKhachHang.GetById(1);

            HienThiKhach();
            RefreshGioHang();
        }

        private void RefreshGioHang()
        {
            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = gioHang;

            decimal tong = busDonHang.TinhTongTien(gioHang);

            string loaiKhach = khachHangHienTai == null
                ? "Mới"
                : khachHangHienTai.LoaiKhach;

            decimal giam = busDonHang.TinhGiamGia(tong, loaiKhach);
            decimal thanhTien = tong - giam;

            lblTongTien.Text = "Tổng tiền: " + tong.ToString("N0") + " đ";
            lblGiamGia.Text = "Giảm giá: " + giam.ToString("N0") + " đ";
            lblThanhTien.Text = "Thành tiền: " + thanhTien.ToString("N0") + " đ";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (gioHang.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống.");
                return;
            }

            if (Session.CurrentUser == null)
            {
                MessageBox.Show("Chưa có nhân viên đăng nhập.");
                return;
            }

            if (khachHangHienTai == null)
                khachHangHienTai = busKhachHang.GetById(1);

            decimal tong = busDonHang.TinhTongTien(gioHang);
            decimal giam = busDonHang.TinhGiamGia(tong, khachHangHienTai.LoaiKhach);

            DTO_DonHang dh = new DTO_DonHang
            {
                MaKH = khachHangHienTai.MaKH,
                MaNV = Session.CurrentUser.MaNV,
                MaPTTT = Convert.ToInt32(cboPTTT.SelectedValue),
                TongTien = tong,
                GiamGia = giam,
                GhiChu = txtGhiChu.Text.Trim()
            };

            string tb;
            int maDonHang = busDonHang.ThanhToan(dh, gioHang, out tb);

            MessageBox.Show(tb);

            if (maDonHang > 0)
            {
                InHoaDon(maDonHang);
                btnLamMoi_Click(null, null);
            }
        }

        private void InHoaDon(int maDonHang)
        {
            DataTable dt = busDonHang.GetHoaDonChiTiet(maDonHang);

            if (dt.Rows.Count == 0)
                return;

            DataRow first = dt.Rows[0];

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("HÓA ĐƠN BÁN HÀNG");
            sb.AppendLine("Mã hóa đơn: " + first["MaHoaDon"]);
            sb.AppendLine("Ngày: " + first["NgayDatHang"]);
            sb.AppendLine("Khách: " + first["TenKH"]);
            sb.AppendLine("Nhân viên: " + first["NhanVien"]);
            sb.AppendLine("Thanh toán: " + first["TenPhuongThuc"]);
            sb.AppendLine("----------------------------------------");

            foreach (DataRow r in dt.Rows)
            {
                sb.AppendLine(r["TenSanPham"] + " - " + r["SKU"]);
                sb.AppendLine(
                    "SL: " + r["SoLuong"]
                    + " x " + Convert.ToDecimal(r["DonGia"]).ToString("N0")
                    + " = " + Convert.ToDecimal(r["ThanhTien"]).ToString("N0") + " đ"
                );
            }

            sb.AppendLine("----------------------------------------");
            sb.AppendLine("Tổng tiền: " + Convert.ToDecimal(first["TongTien"]).ToString("N0") + " đ");
            sb.AppendLine("Giảm giá: " + Convert.ToDecimal(first["GiamGia"]).ToString("N0") + " đ");
            sb.AppendLine("Thành tiền: " + Convert.ToDecimal(first["ThanhTienDon"]).ToString("N0") + " đ");

            MessageBox.Show(sb.ToString(), "Hóa đơn");
        }

        private void txtSDTKhach_TextChanged(object sender, EventArgs e)
        {
            // Để trống: chỉ tìm khách khi bấm nút "Tìm KH"
        }
    }
}