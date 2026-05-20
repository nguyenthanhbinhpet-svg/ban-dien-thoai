using System;
using System.Windows.Forms;
using BUS_PhoneStore;

namespace GUI_PhoneStore
{
    public partial class GUI_BaoCao : Form
    {
        private readonly BUS_BaoCao bus = new BUS_BaoCao();

        public GUI_BaoCao()
        {
            InitializeComponent();
        }

        private void GUI_BaoCao_Load(object sender, EventArgs e)
        {
            ThemeHelper.StyleGrid(dgvBaoCao);
            dtpTuNgay.Value = DateTime.Today.AddMonths(-1);
            dtpDenNgay.Value = DateTime.Today;
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            dgvBaoCao.DataSource = bus.DoanhThu(dtpTuNgay.Value.Date, dtpDenNgay.Value.Date);
        }

        private void btnSanPhamBanChay_Click(object sender, EventArgs e)
        {
            dgvBaoCao.DataSource = bus.SanPhamBanChay(dtpTuNgay.Value.Date, dtpDenNgay.Value.Date);
        }

        private void btnKhachHangTiemNang_Click(object sender, EventArgs e)
        {
            dgvBaoCao.DataSource = bus.KhachHangTiemNang();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvBaoCao.DataSource = null;
        }
    }
}
