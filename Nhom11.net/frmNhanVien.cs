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
    public partial class frmNhanVien : Form
    {
        NhanVien nv;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        public void dataload()
        {
            nv = new NhanVien();
            dataGridView1.DataSource= nv.GetAllNhanVien();

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KtRong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            string ma = txtMaNV.Text.Trim();
            string ten = txtTenNV.Text;
            string coquan = cb_gioitinh.Text;
            string diachi = txtDc.Text;
            string sdt = txtSdt.Text;
            if (nv.ExistMa(ma))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }
            else
            {
                nv.Createnhanvien(ma, ten, coquan, diachi, sdt);
                dataload();
                ClearText();
                MessageBox.Show("Thêm dữ liệu thành công!");
                txtMaNV.Focus();
                frmNhanVien_Load(sender, e);
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Focus();
            dataload();
        }
        bool KtRong()
        {
            if (txtMaNV.Text.Trim() == "") return false;
            if (txtTenNV.Text.Trim() == "") return false;
            if (cb_gioitinh.Text.Trim() == "") return false;
            if (txtDc.Text.Trim() == "") return false;
            if (txtSdt.Text.Trim() == "") return false;
            return true;
        }

        void ClearText()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtDc.Clear();
            txtSdt.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[i];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenNV.Text = row.Cells[1].Value.ToString();
                cb_gioitinh.Text = row.Cells[2].Value.ToString();
                txtDc.Text = row.Cells[3].Value.ToString();
                txtSdt.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Trim() != "")
            {
                if (MessageBox.Show("Có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    nv.delete(txtMaNV.Text);
                    dataload();
                    ClearText();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KtRong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            string ma = txtMaNV.Text.Trim();
            string ten = txtTenNV.Text;
            string coquan = cb_gioitinh.Text;
            string diachi = txtDc.Text;
            string sdt = txtSdt.Text;
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn mã nhân viên cần sửa!");
                return;
            }
            if (!nv.ExistMa(ma))
            {
                MessageBox.Show("Mã nhân viên không tồn tại!");
                return;
            }
            else
            {
                nv.upDateNV(ma, ten, coquan, diachi, sdt);
                dataload();
                ClearText();
                MessageBox.Show("Đã sửa thông tin nhân viên có mã " + ma + " thành công!");
                txtMaNV.Focus();
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            TKNhanVien n = new TKNhanVien();    
            n.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
