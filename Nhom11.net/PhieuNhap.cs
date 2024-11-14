using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11.net
{
    internal class PhieuNhap
    {
        ConnectionDB ketnoi;
        NhanVien nv;
        ThietBi tb;

        public PhieuNhap()
        {
            ketnoi = new ConnectionDB();
            nv = new NhanVien();
            tb = new ThietBi();
        }

        public DataTable GetAllPhieuNhap()
        {
            string sql = "SELECT PhieuNhap.MaPN, PhieuNhap.MaNV, PhieuNhap.NgayNhap, ChiTietPhieuNhap.MaTB, ChiTietPhieuNhap.SoLuong, ChiTietPhieuNhap.GiaNhap, ChiTietPhieuNhap.GhiChu FROM PhieuNhap, ChiTietPhieuNhap WHERE PhieuNhap.MaPN = ChiTietPhieuNhap.MaPN";
            return ketnoi.ReadData(sql);
        }

        public DataTable GetTenTB()
        {
            return tb.GetAllThietBi();
        }

        public DataTable GetTenNV()
        {
            return nv.GetAllNhanVien();
        }

        public string GetFieldVaLue(string sql)
        {
            return ketnoi.getFieldValue(sql);
        }

        public void CreateHoaDon(string mapn, string manv, string ngaynhap, string matb, int soluong, double gianhap, string GhiChuPN)
        {
            string sql = "INSERT INTO PhieuNhap(MaPN, MaNV, NgayNhap) VALUES (@mapn, @manv, @ngaynhap)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@mapn", mapn),
                new SqlParameter("@manv", manv),
                new SqlParameter("@ngaynhap", ngaynhap)
            };
            ketnoi.CreateUpdateDelete(sql, sp);
            string sql2 = "INSERT INTO ChiTietPhieuNhap(MaPN, MaTB, SoLuong, GiaNhap, GhiChu) VALUES (@mapn, @matb, @soluong, @gianhap, @GhiChuPN)";
            SqlParameter[] sp1 = new SqlParameter[]
            {
                new SqlParameter("@mapn", mapn),
                new SqlParameter("@matb", matb),
                new SqlParameter("@soluong", soluong),
                new SqlParameter("@gianhap", gianhap),
                new SqlParameter("@GhiChuPN", GhiChuPN)
            };
            ketnoi.CreateUpdateDelete(sql2, sp1);
        }

        public void UpdatePhieuNhap(string mapn, string manv, string ngaynhap)
        {
            string sql = "UPDATE PhieuNhap SET MaNV = @manv, NgayNhap = @ngaynhap WHERE MaPN = @mapn";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@mapn", mapn),
                new SqlParameter("@manv", manv),
                new SqlParameter("@ngaynhap", ngaynhap)
            };
            ketnoi.CreateUpdateDelete(sql, sp);
        }

        public void UpdatePhieuNhapTB(string mapn, string matb, int soluong, double gianhap, string GhiChuPN)
        {
            string sql = "UPDATE ChiTietPhieuNhap SET SoLuong = @soluong, GiaNhap = @gianhap, GhiChu = @GhiChuPN WHERE MaPN = @mapn AND MaTB = MaTB";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@mapn", mapn),
                new SqlParameter("@matb", matb),
                new SqlParameter("@soluong", soluong),
                new SqlParameter("@gianhap", gianhap),
                new SqlParameter("@GhiChuPN", GhiChuPN)
            };
            ketnoi.CreateUpdateDelete(sql, sp);
        }

        public void DeletePhieuNhap(string mapn, string matb)
        {
            string sql = "DELETE FROM PhieuNhap WHERE MaPN = @mapn; DELETE FROM ChiTietPhieuNhap WHERE MaPN = @mapn AND ChiTietPhieuNhap.MaTB = @matb";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@mapn", mapn),
                new SqlParameter("@matb", matb)
            };
            ketnoi.CreateUpdateDelete(sql, sp);
        }

        public DataTable GetPhieuNhapWithMa(string ma)
        {
            string sql = "SELECT PhieuNhap.MaPN, PhieuNhap.MaNV, PhieuNhap.NgayNhap, ChiTietPhieuNhap.MaTB, ChiTietPhieuNhap.SoLuong, ChiTietPhieuNhap.GiaNhap, ChiTietPhieuNhap.GhiChu FROM PhieuNhap, ChiTietPhieuNhap WHERE PhieuNhap.MaPN = ChiTietPhieuNhap.MaPN AND PhieuNhap.MaPN = @ma";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ma", ma)
            };
            return ketnoi.ReadDataWithPmt(sql, sp);
        }

        public DataTable GetHoaDonWithMaNV(string manv)
        {
            string sql = "SELECT PhieuNhap.MaPN, PhieuNhap.MaNV, PhieuNhap.NgayNhap, ChiTietPhieuNhap.MaTB, ChiTietPhieuNhap.SoLuong, ChiTietPhieuNhap.GiaNhap, ChiTietPhieuNhap.GhiChu FROM PhieuNhap, ChiTietPhieuNhap WHERE PhieuNhap.MaPN = ChiTietPhieuNhap.MaPN AND PhieuNhap.MaNV = @manv";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@manv", manv)
            };
            return ketnoi.ReadDataWithPmt(sql, sp);
        }

        public DataTable GetPhieuNhapWithMaTB(string matb)
        {
            string sql = "SELECT PhieuNhap.MaPN, PhieuNhap.MaNV, PhieuNhap.NgayNhap, ChiTietPhieuNhap.MaTB, ChiTietPhieuNhap.SoLuong, ChiTietPhieuNhap.GiaNhap, ChiTietPhieuNhap.GhiChu FROM PhieuNhap, ChiTietPhieuNhap WHERE PhieuNhap.MaPN = ChiTietPhieuNhap.MaPN AND ChiTietPhieuNhap.MaTB = @matb";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@matb", matb)
            };
            return ketnoi.ReadDataWithPmt(sql, sp);
        }

        public bool ExistMa(string ma)
        {
            bool kt = false;
            string sql = "SELECT PhieuNhap.MaPN, PhieuNhap.MaNV, PhieuNhap.NgayNhap" +
                ", ChiTietPhieuNhap.MaTB, ChiTietPhieuNhap.SoLuong" +
                ", ChiTietPhieuNhap.GiaNhap, ChiTietPhieuNhap.GhiChu FROM PhieuNhap" +
                ", ChiTietPhieuNhap WHERE PhieuNhap.MaPN = @ma";
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
    }
}
