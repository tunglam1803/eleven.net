using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11.net
{
    internal class HoaDon
    {
        ConnectionDB ketnoi;
        KhachHang kh;
        ThietBi tb;

        public HoaDon()
        {
            ketnoi = new ConnectionDB();
            kh = new KhachHang();
            tb = new ThietBi();
        }

        public DataTable GetAllHoaDon()
        {
            string sql = "SELECT HoaDonBH.MaHD, HoaDonBH.MaKH, HoaDonBH.NgayBan, ChiTietHoaDon.MaTB, ChiTietHoaDon.SoLuong, ChiTietHoaDon.GiaBan, ChiTietHoaDon.GhiChu FROM HoaDonBH, ChiTietHoaDon WHERE HoaDonBH.MaHD = ChiTietHoaDon.MaHD";
            return ketnoi.ReadData(sql);
        }

        public void CreateHoaDon(string mahd, string makh, string ngayban, string matb, int soluong, double giaban, string ghichu)
        {
            string sql = "INSERT INTO HoaDonBH(MaHD, MaKH, NgayBan) VALUES (@mahd, @makh, @ngayban)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@mahd", mahd),
                new SqlParameter("@makh", makh),
                new SqlParameter("@ngayban", ngayban)
            };
            ketnoi.CreateUpdateDelete(sql, sp);
            string sql2 = "INSERT INTO ChiTietHoaDon(MaHD, MaTB, SoLuong, GiaBan, GhiChu) VALUES (@mahd, @matb, @soluong, @giaban, @ghichu)";
            SqlParameter[] sp1 = new SqlParameter[]
            {
                new SqlParameter("@mahd", mahd),
                new SqlParameter("@matb", matb),
                new SqlParameter("@soluong", soluong),
                new SqlParameter("@giaban", giaban),
                new SqlParameter("@ghichu", ghichu)
            };
            ketnoi.CreateUpdateDelete(sql2, sp1);
        }

        public void UpdateHoaDon(string mahd, string makh, string ngayban)
        {
            string sql = "UPDATE HoaDonBH SET MaKH = @makh, NgayBan = @ngayban WHERE MaHD = @mahd";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@mahd", mahd),
                new SqlParameter("@makh", makh),
                new SqlParameter("@ngayban", ngayban)
            };
            ketnoi.CreateUpdateDelete(sql, sp);
        }

        public void UpdateHoaDonTB(string mahd, string matb, int soluong, double giaban, string ghichu)
        {
            string sql = "UPDATE ChiTietHoaDon SET SoLuong = @soluong, GiaBan = @giaban, GhiChu = @ghichu WHERE MaHD = @mahd AND MaTB = MaTB";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@mahd", mahd),
                new SqlParameter("@matb", matb),
                new SqlParameter("@soluong", soluong),
                new SqlParameter("@giaban", giaban),
                new SqlParameter("@ghichu", ghichu)
            };
            ketnoi.CreateUpdateDelete(sql, sp);
        }

        public void DeleteHoaDon(string mahd, string matb)
        {
            string sql = "DELETE FROM HoaDonBH WHERE MaHD = @mahd; DELETE FROM ChiTietHoaDon WHERE MaHD = @mahd AND ChiTietHoaDon.MaTB = @matb";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@mahd", mahd),
                new SqlParameter("@matb", matb)
            };
            ketnoi.CreateUpdateDelete(sql, sp);
        }

        public DataTable GetHoaDonWithMa(string ma)
        {
            string sql = "SELECT HoaDonBH.MaHD, HoaDonBH.MaKH, HoaDonBH.NgayBan, ChiTietHoaDon.MaTB, ChiTietHoaDon.SoLuong, ChiTietHoaDon.GiaBan, ChiTietHoaDon.GhiChu FROM HoaDonBH, ChiTietHoaDon WHERE HoaDonBH.MaHD = ChiTietHoaDon.MaHD AND HoaDonBH.MaHD = @ma";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ma", ma)
            };
            return ketnoi.ReadDataWithPmt(sql, sp);
        }

        public DataTable GetHoaDonWithMaKH(string makh)
        {
            string sql = "SELECT HoaDonBH.MaHD, HoaDonBH.MaKH, HoaDonBH.NgayBan, ChiTietHoaDon.MaTB, ChiTietHoaDon.SoLuong, ChiTietHoaDon.GiaBan, ChiTietHoaDon.GhiChu FROM HoaDonBH, ChiTietHoaDon WHERE HoaDonBH.MaHD = ChiTietHoaDon.MaHD AND HoaDonBH.MaKH = @makh";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@makh", makh)
            };
            return ketnoi.ReadDataWithPmt(sql, sp);
        }

        public DataTable GetHoaDonWithMaTB(string matb)
        {
            string sql = "SELECT HoaDonBH.MaHD, HoaDonBH.MaKH, HoaDonBH.NgayBan, ChiTietHoaDon.MaTB, ChiTietHoaDon.SoLuong, ChiTietHoaDon.GiaBan, ChiTietHoaDon.GhiChu FROM HoaDonBH, ChiTietHoaDon WHERE HoaDonBH.MaHD = ChiTietHoaDon.MaHD AND ChiTietHoaDon.MaTB = @matb";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@matb", matb)
            };
            return ketnoi.ReadDataWithPmt(sql, sp);
        }

        public bool ExistMa(string ma)
        {
            bool kt = false;
            string sql = "SELECT HoaDonBH.MaHD, HoaDonBH.MaKH, HoaDonBH.NgayBan, ChiTietHoaDon.MaTB, ChiTietHoaDon.SoLuong, ChiTietHoaDon.GiaBan, ChiTietHoaDon.GhiChu FROM HoaDonBH, ChiTietHoaDon WHERE HoaDonBH.MaHD = @ma";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ma", ma)
            };
            if (ketnoi.ExistingMa(sql, sp))
            {
                kt = true;
            }
            return kt;
        }

        public DataTable GetTenTB()
        {
            return tb.GetAllThietBi();
        }

        public DataTable GetTenKH()
        {
            return kh.GetAllKhachHang();
        }

        public string GetFieldVaLue(string sql)
        {
            return ketnoi.getFieldValue(sql);
        }
    }
}
