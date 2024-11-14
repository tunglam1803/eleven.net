using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11.net
{
    internal class KhachHang
    {
        ConnectionDB ketnoi;

        public KhachHang()
        {
            ketnoi = new ConnectionDB();
        }

        public DataTable GetAllKhachHang()
        {
            string sql = "SELECT * FROM KhachHang";
            return ketnoi.ReadData(sql);
        }

        public void CreateKH(string makh, string tenkh, string gioitinhkh, string diachi, string sdt)
        {
            string sqlthem = "INSERT INTO KhachHang(MaKH, TenKH, GioiTinhKH, DiaChi, SDTKH) VALUES (@makh, @tenkh, @gioitinhkh, @diachi, @sdt)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@makh", makh),
                new SqlParameter("@tenkh", tenkh),
                new SqlParameter("@gioitinhkh", gioitinhkh),
                new SqlParameter("@diachi", diachi),
                new SqlParameter("@sdt", sdt)
            };
            ketnoi.CreateUpdateDelete(sqlthem, sp);
        }

        public void UpdateKH(string makh, string tenkh, string gioitinhkh, string diachi, string sdt)
        {
            string sqlsua = "UPDATE KhachHang SET TenKH = @tenkh, GioiTinhKH = @gioitinhkh, DiaChi = @diachi, SDTKH = @sdt WHERE MaKH = @makh";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@makh", makh),
                new SqlParameter("@tenkh", tenkh),
                new SqlParameter("@gioitinhkh", gioitinhkh),
                new SqlParameter("@diachi", diachi),
                new SqlParameter("@sdt", sdt)
            };
            ketnoi.CreateUpdateDelete(sqlsua, sp);
        }

        public void DeleteKH(string makh)
        {
            string sqlxoa = "DELETE FROM KhachHang WHERE MaKH = @makh";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@makh", makh)
            };
            ketnoi.CreateUpdateDelete(sqlxoa, sp);
        }

        public DataTable GetKhachHangWithMaKH(string makh)
        {
            string sqlma = "SELECT * FROM KhachHang WHERE MaKH LIKE @makh";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@makh", makh)
            };
            return ketnoi.ReadDataWithPmt(sqlma, sp);
        }

        public DataTable GetKhachHangWithTenKH(string tenkh)
        {
            string sqlten = "SELECT * FROM KhachHang WHERE TenKH LIKE @tenkh";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@tenkh", tenkh)
            };
            return ketnoi.ReadDataWithPmt(sqlten, sp);
        }

        public DataTable GetKhachHangWithSDT(string sdt)
        {
            string sqlsdt = "SELECT * FROM KhachHang WHERE SDTKH LIKE @sdt";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@sdt", sdt)
            };
            return ketnoi.ReadDataWithPmt(sqlsdt, sp);
        }

        public bool ExistMa(string makh)
        {
            bool kt = false;
            string sql = "SELECT * FROM KhachHang where MaKH = @ma";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ma", makh)
            };
            if (ketnoi.ExistingMa(sql, sp))
            {
                kt = true;
            }
            return kt;
        }
    }
}
