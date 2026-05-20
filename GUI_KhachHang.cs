using System;
using System.Windows.Forms;
using BUS_PhoneStore;
using DTO_PhoneStore;

namespace GUI_PhoneStore
{
    public partial class GUI_KhachHang : Form
    {
        private readonly BUS_KhachHang bus = new BUS_KhachHang();

        public GUI_KhachHang()
        {
            InitializeComponent();
        }

        private void GUI_KhachHang_Load(object sender, EventArgs e)
        {
            ThemeHelper.StyleGrid(dgvKhachHang);

            ThemeHelper.StyleButton(this.btnTimKiem);
            ThemeHelper.StyleButton(this.btnLamMoi, ThemeHelper.Secondary);
            ThemeHelper.StyleButton(this.btnThem, ThemeHelper.Success);
            ThemeHelper.StyleButton(this.btnSua);

            LoadData();
        }

        private void LoadData()
        {
            dgvKhachHang.DataSource = bus.GetKhachHang();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = bus.TimKiemKhachHang(txtTimKiem.Text.Trim());
        }

        private DTO_KhachHang LayDuLieuForm()
        {
            int maKH = 0;
            int.TryParse(txtMaKH.Text, out maKH);
            return new DTO_KhachHang
            {
                MaKH = maKH,
                TenKH = txtTenKH.Text.Trim(),
                SoDienThoai = txtSDT.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim()
            };
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tb;
            int id = bus.ThemKhachHang(LayDuLieuForm(), out tb);
            MessageBox.Show(tb);
            if (id > 0) { LamMoiForm(); LoadData(); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa.");
                return;
            }
            string tb;
            bool ok = bus.SuaKhachHang(LayDuLieuForm(), out tb);
            MessageBox.Show(tb);
            if (ok) { LamMoiForm(); LoadData(); }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
            LoadData();
        }

        private void LamMoiForm()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtLoaiKhach.Clear();
            txtTimKiem.Clear();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dgvKhachHang.Rows[e.RowIndex];
            txtMaKH.Text = GetCell(r, "MaKH");
            txtTenKH.Text = GetCell(r, "TenKH");
            txtSDT.Text = GetCell(r, "SoDienThoai");
            txtEmail.Text = GetCell(r, "Email");
            txtDiaChi.Text = GetCell(r, "DiaChi");
            txtLoaiKhach.Text = GetCell(r, "LoaiKhach");
        }

        private string GetCell(DataGridViewRow r, string name)
        {
            if (!r.DataGridView.Columns.Contains(name)) return "";
            object v = r.Cells[name].Value;
            return v == null ? "" : v.ToString();
        }

        private void txtLoaiKhach_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
