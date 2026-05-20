using System;
using System.Data;
using DAL_PhoneStore;

namespace BUS_PhoneStore
{
    public class BUS_BaoCao
    {
        private DAL_BaoCao dal = new DAL_BaoCao();

        public DataTable DoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            return dal.DoanhThu(tuNgay.ToString("yyyy-MM-dd"), denNgay.ToString("yyyy-MM-dd"));
        }

        public DataTable SanPhamBanChay(DateTime tuNgay, DateTime denNgay)
        {
            return dal.SanPhamBanChay(tuNgay.ToString("yyyy-MM-dd"), denNgay.ToString("yyyy-MM-dd"));
        }

        public DataTable KhachHangTiemNang()
        {
            return dal.KhachHangTiemNang();
        }
    }
}
