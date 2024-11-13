using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
