using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11.net
{
    internal class ThietBi
    {
        ConnectionDB ketnoi;

        public ThietBi()
        {
            ketnoi = new ConnectionDB();
        }

        public DataTable GetAllThietBi()
        {
            string sql = "SELECT * FROM ThietBi";
            return ketnoi.ReadData(sql);
        }

        public bool ExistMa(string ma)
        {
            bool kt = false;
            string sql = "SELECT * FROM ThietBi WHERE MaTB = @ma";
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

        public void CreateThietBi(string matb, string tentb, string loaitb, string hangsx, int namsx, double giaban, double gianhap)
        {
            string sql = "INSERT INTO ThietBi(MaTB, TenTB, LoaiTB, HangSX, NamSX, GiaBan, GiaNhap) VALUES (@matb, @tentb, @loaitb, @hangsx, @namsx, @giaban, @gianhap)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@matb", matb),
                new SqlParameter("@tentb", tentb),
                new SqlParameter("@loaitb", loaitb),
                new SqlParameter("@hangsx", hangsx),
                new SqlParameter("@namsx", namsx),
                new SqlParameter("@giaban", giaban),
                new SqlParameter("@gianhap", gianhap)
            };
            ketnoi.CreateUpdateDelete(sql, sp);
        }

        public void DeleteThietBi(string tb)
        {
            string sql = "DELETE FROM ThietBi WHERE MaTB = @mtb";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@mtb", tb)
            };
            ketnoi.CreateUpdateDelete(sql, sqlParameters);
        }

        public void UpdateThietBi(string matb, string tentb, string loaitb, string hsx, int nsx, double giaban, double gianhap)
        {
            string sql = "UPDATE ThietBi SET TenTB = @tentb, LoaiTB = @loaitb, HangSX = @hsx, NamSX = @nsx, GiaBan = @giaban, GiaNhap = @gianhap WHERE MaTB = @mtb";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@mtb", matb),
                new SqlParameter("@tentb", tentb),
                new SqlParameter("@loaitb", loaitb),
                new SqlParameter("@hsx", hsx),
                new SqlParameter("@nsx", nsx),
                new SqlParameter("@giaban", giaban),
                new SqlParameter("@gianhap", gianhap)
            };
            ketnoi.CreateUpdateDelete(sql, sqlParameters);
        }

        public DataTable GetThietBiWithMa(string ma)
        {
            string sql = "SELECT * FROM ThietBi WHERE MaTB = @ma";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ma", ma)
            };
            return ketnoi.ReadDataWithPmt(sql, sp);
        }

        public DataTable GetThietBiWithTenTB(string tentb)
        {
            string sql = "SELECT * FROM ThietBi WHERE TenTB = @tentb";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@tentb", tentb)
            };
            return ketnoi.ReadDataWithPmt(sql, sp);
        }

        public DataTable GetThietBiGetLoaiTB(string loaiTB)
        {
            string sql = "SELECT * FROM ThietBi WHERE LoaiTB = @loaiTb";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@loaiTb", loaiTB)
            };
            return ketnoi.ReadDataWithPmt(sql, sp);
        }

        public DataTable GetThietBiLoaiHangSX(string hsx)
        {
            string sql = "SELECT * FROM ThietBi WHERE HangSX = @hsx";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@hsx", hsx)
            };
            return ketnoi.ReadDataWithPmt(sql, sp);
        }
    }
}
