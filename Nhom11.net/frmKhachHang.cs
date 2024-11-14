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
    public partial class frmKhachHang : Form
    {
        KhachHang kh;

        public frmKhachHang()
        {
            InitializeComponent();
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
        }

        public void LoadKH()
        {
            kh = new KhachHang();
            dataGridView1.DataSource = kh.GetAllKhachHang();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            txtMa.Focus();
            LoadKH();
        }

        bool KtRong()
        {
            if (txtMa.Text.Trim() == "") return false;
            if (txtTen.Text.Trim() == "") return false;
            if (cb_gtkh.Text.Trim() == "") return false;
            if (txtDc.Text.Trim() == "") return false;
            if (txtSdt.Text.Trim() == "") return false;
            return true;
        }
        void ClearText()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtDc.Clear();
            txtSdt.Clear();
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            TKKhachHang tk = new TKKhachHang();
            tk.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMa.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
                cb_gtkh.Text = row.Cells[2].Value.ToString();
                txtDc.Text = row.Cells[3].Value.ToString();
                txtSdt.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KtRong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            string makh = txtMa.Text;
            string tenkh = txtTen.Text;
            string gioitinh = cb_gtkh.Text;
            string diachi = txtDc.Text;
            string sdt = txtSdt.Text;

            if (kh.ExistMa(makh))
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!");
                return;
            }
            else
            {
                kh.CreateKH(makh, tenkh, gioitinh, diachi, sdt);
                LoadKH();
                ClearText();
                txtMa.Focus();
                frmKhachHang_Load(sender, e);
                MessageBox.Show("Đã thêm khách hàng có mã " + makh + " thành công!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn mã khách hàng cần sửa!");
                return;
            }
            if (!kh.ExistMa(txtMa.Text.Trim()))
            {
                MessageBox.Show("Mã khách hàng không tồn tại!");
                return;
            }

            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtMa.Enabled = false;
            btnTk.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KtRong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            string ma = txtMa.Text.Trim();
            string ten = txtTen.Text;
            string gt = cb_gtkh.Text;
            string diachi = txtDc.Text;
            string sdt = txtSdt.Text;

            kh.UpdateKH(ma, ten, gt, diachi, sdt);
            LoadKH();
            ClearText();

            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtMa.Enabled = true;
            btnTk.Enabled = true;

            txtMa.Focus();
            frmKhachHang_Load(sender, e);
            MessageBox.Show("Đã sửa thông tin khách hàng có mã " + ma + " thành công!");
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtMa.Enabled = true;
            btnTk.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim() != "")
            {
                if (MessageBox.Show("Có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    kh.DeleteKH(txtMa.Text);
                    LoadKH();
                    ClearText();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
