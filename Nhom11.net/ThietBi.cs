using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
