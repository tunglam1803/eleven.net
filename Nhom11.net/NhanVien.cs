using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11.net
{
    internal class NhanVien
    {
        ConnectionDB ketnoi;
        public NhanVien()
        {
            ketnoi = new ConnectionDB();
        }
        public DataTable GetAllNhanVien()
        {
            string sql = "SELECT * FROM NhanVien";
            return ketnoi.ReadData(sql);
        }
        public void Createnhanvien(string ma, string ten, string gioitinh, string diachi, string sdt)
        {
            string sql = "INSERT INTO NhanVien(MaNV, TenNV, GioiTinhNV , DiaChiNV , SDTNV) VALUES (@ma, @tennv, @gioitinh, @diachi, @sdt)";
            SqlParameter[] nv = new SqlParameter[]
            {
                new SqlParameter("@ma", ma),
                new SqlParameter("@tennv", ten),
                new SqlParameter("@gioitinh",gioitinh),
                new SqlParameter("@diachi", diachi),
                new SqlParameter("@sdt", sdt),

            };
            ketnoi.CreateUpdateDelete(sql, nv);
        }
        public void upDateNV(string ma, string ten, string gioitinh, string diachi, string sdt)
        {
            string sql = " UPDATE NhanVien SET  TenNV = @tennv , GioiTinhNV = @gioitinh , DiaChiNV = @diachi , SDTNV = @sdt WHERE MaNV = @ma ";
            SqlParameter[] nv = new SqlParameter[]
            {
                new SqlParameter("@ma", ma),
                new SqlParameter("@tennv", ten),
                new SqlParameter("@gioitinh",gioitinh),
                new SqlParameter("@diachi", diachi),
                new SqlParameter("@sdt", sdt),

            };
            ketnoi.CreateUpdateDelete(sql, nv);
        }
        public void delete(string ma)
        {
            string sql = "DELETE FROM NhanVien  WHERE MaNV = @ma";
            SqlParameter[] nv = new SqlParameter[]
            {
                new SqlParameter ("@ma",ma)
            };
            ketnoi.CreateUpdateDelete(sql, nv);
        }
        public DataTable GetNhanVienWithMa(string ma)
        {
            string sql = "SELECT * FROM NhanVien WHERE MaNV LIKE @ma";
            SqlParameter[] nv = new SqlParameter[]
            {
                new SqlParameter("@ma", ma)
            };
            return ketnoi.ReadDataWithPmt(sql, nv);
        }
        public DataTable GetNhanVienWithTenNV(string ten)
        {
            string sql = "SELECT * FROM NhanVien WHERE TenNV LIKE @tennv";
            SqlParameter[] nv = new SqlParameter[]
            {
                new SqlParameter("@tennv", ten)
            };
            return ketnoi.ReadDataWithPmt(sql, nv);
        }
        public DataTable GetNhanVienWithSDT(string sdt)
        {
            string sql = "SELECT * FROM NhanVien WHERE SDTNV LIKE @sdt";
            SqlParameter[] nv = new SqlParameter[]
            {
                new SqlParameter("@sdt", sdt)
            };
            return ketnoi.ReadDataWithPmt(sql, nv);
        }
        public bool ExistMa(string ma)
        {
            bool kt = false;
            string sql = "SELECT * FROM NhanVien where MaNV = @ma";
            SqlParameter[] nv = new SqlParameter[]
            {
                new SqlParameter("@ma", ma)
            };
            if (ketnoi.ExistingMa(sql, nv))
            {
                kt = true;
            }
            return kt;
        }
    }
}
