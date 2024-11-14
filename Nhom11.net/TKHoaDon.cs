using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11.net
{
    public partial class TKHoaDon : Form
    {
        HoaDon hd;
        public TKHoaDon()
        {
            InitializeComponent();
            ThanhTien();
        }

        public void LoadData()
        {
            hd = new HoaDon();
            dataGridView1.DataSource = hd.GetAllHoaDon();
        }

        void ThanhTien()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int soLuong = Convert.ToInt32(row.Cells["sl"].Value);
                    decimal giaban = Convert.ToDecimal(row.Cells["gb"].Value);
                    decimal s = soLuong * giaban;
                    row.Cells["tt"].Value = s;
                }
            }
        }

        private void TKHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
            ThanhTien();
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            string tk = txtTk.Text.Trim();
            if (rbMaSach.Checked)
            {
                dataGridView1.DataSource = hd.GetHoaDonWithMa(tk);
            }
            else if (rbTenSach.Checked)
            {
                dataGridView1.DataSource = hd.GetHoaDonWithMaKH(tk);
            }
            else
            {
                dataGridView1.DataSource = hd.GetHoaDonWithMaTB(tk);
            }
            TKHoaDon_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
