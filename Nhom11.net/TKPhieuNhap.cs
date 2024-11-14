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
    public partial class TKPhieuNhap : Form
    {
        PhieuNhap pn;

        public TKPhieuNhap()
        {
            InitializeComponent();
            ThanhTien();
        }

        public void LoadData()
        {
            pn = new PhieuNhap();
            dataGridView1.DataSource = pn.GetAllPhieuNhap();
        }

        void ThanhTien()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int soLuong = Convert.ToInt32(row.Cells["sl"].Value);
                    decimal giaban = Convert.ToDecimal(row.Cells["gn"].Value);
                    decimal s = soLuong * giaban;
                    row.Cells["tt"].Value = s;
                }
            }
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            string tk = txtTk.Text.Trim();
            if (rbMaPN.Checked)
            {
                dataGridView1.DataSource = pn.GetPhieuNhapWithMa(tk);
            }
            else if (rbMaNV.Checked)
            {
                dataGridView1.DataSource = pn.GetHoaDonWithMaNV(tk);
            }
            else
            {
                dataGridView1.DataSource = pn.GetPhieuNhapWithMaTB(tk);
            }
            TKPhieuNhap_Load(sender, e);
        }

        private void TKPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadData();
            ThanhTien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
