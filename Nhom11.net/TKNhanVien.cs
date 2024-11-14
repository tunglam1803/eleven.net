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
    public partial class TKNhanVien : Form
    {
        NhanVien nv;
        public TKNhanVien()
        {
            InitializeComponent();
        }

        public void dataload()
        {
            nv = new NhanVien();
            dataGridView1.DataSource = nv.GetAllNhanVien();
        }

        private void TKNhanVien_Load(object sender, EventArgs e)
        {
            dataload();
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            string tk = txtTk.Text.Trim();
            if (rbMaNV.Checked)
            {
                dataGridView1.DataSource = nv.GetNhanVienWithMa(tk);
            }
            else if (rbTenNV.Checked)
            {
                dataGridView1.DataSource = nv.GetNhanVienWithTenNV(tk);
            }
            else if (rbSDTNV.Checked)
            {
                dataGridView1.DataSource = nv.GetNhanVienWithSDT(tk);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
