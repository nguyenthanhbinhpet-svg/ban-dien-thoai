using System;
using System.Windows.Forms;
using BUS_PhoneStore;
using DTO_PhoneStore;

namespace GUI_PhoneStore
{
    public partial class GUI_DangNhap : Form
    {
        private readonly BUS_NhanVien busNhanVien = new BUS_NhanVien();

        public GUI_DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string thongBao;
            DTO_NhanVien nv = busNhanVien.DangNhap(txtTenDangNhap.Text.Trim(), txtMatKhau.Text.Trim(), out thongBao);

            if (nv == null)
            {
                MessageBox.Show(thongBao, "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!nv.TrangThai)
            {
                MessageBox.Show("Tài khoản đã ngừng hoạt động.", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Session.CurrentUser = nv;
            AppSession.CurrentUser = nv;

            Hide();
            GUI_Main main = new GUI_Main();
            main.FormClosed += (s, args) => Close();
            main.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSub_Click(object sender, EventArgs e)
        {

        }
    }
}
