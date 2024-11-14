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
    public partial class frmThietBi : Form
    {
        ThietBi tb;

        public frmThietBi()
        {
            InitializeComponent();
            txtMaTB.Focus();
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
        }

        public void LoadData()
        {
            tb = new ThietBi();
            dataGridView1.DataSource = tb.GetAllThietBi();
        }

        void ClearText()
        {
            txtMaTB.Clear();
            txtTenTB.Clear();
            txtLoaiTB.Clear();
            txtHangSX.Clear();
            txtNamSX.Clear();
            txtGiaBan.Clear();
            txtGiaNhap.Clear();
        }

        private void frmThietBi_Load(object sender, EventArgs e)
        {
            LoadData();
            txtMaTB.Focus();
        }

        bool KtRong()
        {
            if (txtMaTB.Text.Trim() == "") return false;
            if (txtTenTB.Text.Trim() == "") return false;
            if (txtLoaiTB.Text.Trim() == "") return false;
            if (txtHangSX.Text.Trim() == "") return false;
            if (txtNamSX.Text.Trim() == "") return false;
            if (txtGiaBan.Text.Trim() == "") return false;
            if (txtGiaNhap.Text.Trim() == "") return false;
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KtRong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            string matb = txtMaTB.Text.Trim();
            string tentb = txtTenTB.Text.Trim();
            string loaitb = txtLoaiTB.Text.Trim();
            string hangsx = txtHangSX.Text.Trim();
            int namsx = Convert.ToInt32(txtNamSX.Text);
            double giaban = Convert.ToDouble(txtGiaBan.Text);
            double gianhap = Convert.ToDouble(txtGiaNhap.Text);

            if (tb.ExistMa(matb))
            {
                MessageBox.Show("Mã thiết bị đã tồn tại!");
                return;
            }
            else
            {
                tb.CreateThietBi(matb, tentb, loaitb, hangsx, namsx, giaban, gianhap);
                LoadData();
                ClearText();
                txtMaTB.Focus();
                frmThietBi_Load(sender, e);
                MessageBox.Show("Thêm thiết bị có mã " + matb + " thành công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaTB.Text.Trim() != "")
            {
                if (MessageBox.Show("Có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tb.DeleteThietBi(txtMaTB.Text);
                    LoadData();
                    ClearText();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[i];
                txtMaTB.Text = row.Cells["matb"].Value.ToString();
                txtTenTB.Text = row.Cells["tentb"].Value.ToString();
                txtLoaiTB.Text = row.Cells["loaitb"].Value.ToString();
                txtHangSX.Text = row.Cells["hsx"].Value.ToString();
                txtNamSX.Text = row.Cells["nsx"].Value.ToString();
                txtGiaBan.Text = row.Cells["gb"].Value.ToString();
                txtGiaNhap.Text = row.Cells["gn"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaTB.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn mã thiết bị cần sửa!");
                return;
            }
            if (!tb.ExistMa(txtMaTB.Text.Trim()))
            {
                MessageBox.Show("Mã thiết bị không tồn tại!");
                return;
            }

            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtMaTB.Enabled = false;
            btnTk.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KtRong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            string matb = txtMaTB.Text;
            string tentb = txtTenTB.Text;
            string loaitb = txtLoaiTB.Text;
            string hangsx = txtHangSX.Text;
            int namsx = int.Parse(txtNamSX.Text);
            double giaban = double.Parse(txtGiaBan.Text);
            double gianhap = Convert.ToDouble(txtGiaNhap.Text);

            tb.UpdateThietBi(matb, tentb, loaitb, hangsx, namsx, giaban, gianhap);
            LoadData();
            ClearText();

            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtMaTB.Enabled = true;
            btnTk.Enabled = true;

            txtMaTB.Focus();
            frmThietBi_Load(sender, e);
            MessageBox.Show("Cập nhật thông tin thiết bị có mã " + matb + " thành công!");
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtMaTB.Enabled = true;
            btnTk.Enabled = true;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            TKThietBi frm = new TKThietBi();
            frm.ShowDialog();
        }
    }
}
