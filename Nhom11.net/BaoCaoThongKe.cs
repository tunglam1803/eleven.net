using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11.net
{
    internal class BaoCaoThongKe
    {
        ConnectionDB ketnoi;

        public BaoCaoThongKe()
        {
            ketnoi = new ConnectionDB();
        }

        public DataTable GetThongKe(string start, string end)
        {
            string sql = "SELECT ChiTietHoaDon.MaTB, ThietBi.TenTB, HoaDonBH.NgayBan, SUM(ChiTietHoaDon.SoLuong) AS SoLuong, ChiTietHoaDon.GiaBan FROM ChiTietHoaDon JOIN ThietBi ON ChiTietHoaDon.MaTB = ThietBi.MaTB JOIN HoaDonBH ON ChiTietHoaDon.MaHD = HoaDonBH.MaHD WHERE HoaDonBH.NgayBan BETWEEN @start AND @end GROUP BY ChiTietHoaDon.MaTB, ThietBi.TenTB, HoaDonBH.NgayBan, ChiTietHoaDon.GiaBan";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@start", start),
                new SqlParameter("@end", end)
            };
            return ketnoi.ReadDataWithPmt(sql, sp);
        }
    }
}
