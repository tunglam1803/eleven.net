using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class DocGia
    {
        ConnectionDB ketnoi;

        public DocGia()
        {
            ketnoi = new ConnectionDB();
        }

        public DataTable GetAllDocGia()
        {
            string sql = "SELECT * FROM tblDocGia";
            return ketnoi.ReadData(sql);
        }

        public void CreateDocGia(string ma, string ten, string coquan, string diachi, string sdt)
        {
            string sql = "INSERT INTO tblDocGia(MaDocGia, TenDocGia, CoQuan, DiaChi, Tel) VALUES (@ma, @ten, @cq, @diachi, @sdt)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ma", ma),
                new SqlParameter("@ten", ten),
                new SqlParameter("@cq", coquan),
                new SqlParameter("@diachi", diachi),
                new SqlParameter("@sdt", sdt)
            };
            ketnoi.CreateUpdateDelete(sql, sp);
        }

        public void UpdateDocGia(string ma, string ten, string coquan, string diachi, string sdt)
        {
            string sql = "UPDATE tblDocGia SET TenDocGia = @ten, CoQuan = @cq, DiaChi = @diachi, Tel = @sdt WHERE MaDocGia = @ma";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ma", ma),
                new SqlParameter("@ten", ten),
                new SqlParameter("@cq", coquan),
                new SqlParameter("@diachi", diachi),
                new SqlParameter("@sdt", sdt)
            };
            ketnoi.CreateUpdateDelete(sql, sp);
        }

        public void DeleteDocGia(string ma)
        {
            string sql = "DELETE FROM tblDocGia WHERE MaDocGia = @ma";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ma", ma)
            };
            ketnoi.CreateUpdateDelete(sql, sp);
        }

        public DataTable GetDocGiaWithMa(string ma)
        {
            string sql = "SELECT * FROM tblDocGia WHERE MaDocGia LIKE @ma";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ma", ma)
            };
            return ketnoi.ReadDataWithPmt(sql, sp);
        }

        public DataTable GetDocGiaWithTen(string ten)
        {
            string sql = "SELECT * FROM tblDocGia WHERE TenDocGia LIKE @ten";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ten", ten)
            };
            return ketnoi.ReadDataWithPmt(sql, sp);
        }

        public DataTable GetDocGIaWithSDT(string sdt)
        {
            string sql = "SELECT * FROM tblDocGia WHERE Tel LIKE @sdt";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@sdt", sdt)
            };
            return ketnoi.ReadDataWithPmt(sql, sp);
        }

        public bool ExistMa(string ma)
        {
            bool kt = false;
            string sql = "SELECT * FROM tblDocGia where MaDocGia = @ma";
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
