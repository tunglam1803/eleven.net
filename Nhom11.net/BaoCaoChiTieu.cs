using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11.net
{
    internal class BaoCaoChiTieu
    {
        ConnectionDB ketnoi;

        public BaoCaoChiTieu()
        {
            ketnoi = new ConnectionDB();
        }

        public DataTable GetThongKe(string start, string end)
        {
            string sql = "SELECT ChiTietPhieuNhap.MaTB, ThietBi.TenTB, PhieuNhap.NgayNhap, SUM(ChiTietPhieuNhap.SoLuong) AS SoLuong, ChiTietPhieuNhap.GiaNhap FROM ChiTietPhieuNhap JOIN ThietBi ON ChiTietPhieuNhap.MaTB = ThietBi.MaTB JOIN PhieuNhap ON ChiTietPhieuNhap.MaPN = PhieuNhap.MaPN WHERE PhieuNhap.NgayNhap BETWEEN @start AND @end GROUP BY ChiTietPhieuNhap.MaTB, ThietBi.TenTB, PhieuNhap.NgayNhap, ChiTietPhieuNhap.GiaNhap";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@start", start),
                new SqlParameter("@end", end)
            };
            return ketnoi.ReadDataWithPmt(sql, sp);
        }
    }
}
