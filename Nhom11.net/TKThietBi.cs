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
    public partial class TKThietBi : Form
    {
        ThietBi tb;

        public TKThietBi()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            tb = new ThietBi();
            dataGridView1.DataSource = tb.GetAllThietBi();
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            string tk = txtTk.Text.Trim();
            if (rbMaTB.Checked)
            {
                dataGridView1.DataSource = tb.GetThietBiWithMa(tk);
            }
            else if (rbTenTB.Checked)
            {
                dataGridView1.DataSource = tb.GetThietBiWithTenTB(tk);
            }
            else if (rbLoaiTB.Checked)
            {
                dataGridView1.DataSource = tb.GetThietBiGetLoaiTB(tk);
            }
            else if (rbhangsx.Checked)
            {
                dataGridView1.DataSource = tb.GetThietBiLoaiHangSX(tk);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TKThietBi_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
