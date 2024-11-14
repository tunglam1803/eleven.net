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
    public partial class TKKhachHang : Form
    {
        KhachHang kh;

        public TKKhachHang()
        {
            InitializeComponent();
        }

        public void LoadKH()
        {
            kh = new KhachHang();
            dataGridView1.DataSource = kh.GetAllKhachHang();
        }

        private void TKKhachHang_Load(object sender, EventArgs e)
        {
            LoadKH();
        }

        private void btnTk_Click_1(object sender, EventArgs e)
        {
            string tk = txtTk.Text.Trim();
            if (rbMaKH.Checked)
            {
                dataGridView1.DataSource = kh.GetKhachHangWithMaKH(tk);
            }
            else if (rbTenKH.Checked)
            {
                dataGridView1.DataSource = kh.GetKhachHangWithTenKH(tk);
            }
            else if (rbSDTKH.Checked)
            {
                dataGridView1.DataSource = kh.GetKhachHangWithSDT(tk);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
