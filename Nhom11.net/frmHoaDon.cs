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
    public partial class frmHoaDon : Form
    {
        HoaDon hd;

        public frmHoaDon()
        {
            InitializeComponent();
            txtTenKH.Enabled = false;
            txtTenTB.Enabled = false;
            txtGiaBan.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMaHD.Focus();
            LoadData();
            ThanhTien();
        }

        public void LoadData()
        {
            hd = new HoaDon();
            dataGridView1.DataSource = hd.GetAllHoaDon();
            LoadcboMaKH();
            LoadCBOMaTB();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            txtMaHD.Focus();
            LoadData();
            ThanhTien();
        }

        bool KtRong()
        {
            if (txtMaHD.Text.Trim() == "") return false;
            if (cboMaKH.Text.Trim() == "") return false;
            if (cboMaTB.Text.Trim() == "") return false;
            if (txtSoLuong.Text.Trim() == "") return false;
            if (txtGiaBan.Text.Trim() == "") return false;
            if (txtGhiChu.Text.Trim() == "") return false;
            return true;
        }

        void ClearText()
        {
            txtMaHD.Clear();
            txtSoLuong.Clear();
            txtGiaBan.Clear();
            txtGhiChu.Clear();
            txtTenKH.Clear();
            txtTenTB.Clear();
        }

        void LoadcboMaKH()
        {
            cboMaKH.Items.Clear();
            foreach (DataRow row in hd.GetTenKH().Rows)
            {
                cboMaKH.Items.Add(row[0]);
            }
        }

        void LoadCBOMaTB()
        {
            cboMaTB.Items.Clear();
            foreach (DataRow row in hd.GetTenTB().Rows)
            {
                cboMaTB.Items.Add(row[0]);
            }
        }

        private void cboMaKH_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaKH.Text == "")
                txtTenKH.Text = "";
            str = "SELECT TenKH FROM KhachHang where MaKH = N'" + cboMaKH.Text + "'";
            txtTenKH.Text = hd.GetFieldVaLue(str);
        }

        private void cboMaTB_TextChanged(object sender, EventArgs e)
        {
            string str, str1;
            if (cboMaKH.Text == "")
            {
                txtTenKH.Text = "";
                txtGiaBan.Text = "";
            } 
            str = "SELECT TenTB FROM ThietBi where MaTB = N'" + cboMaTB.Text + "'";
            str1 = "SELECT GiaBan FROM ThietBi where MaTB = N'" + cboMaTB.Text + "'";
            txtTenTB.Text = hd.GetFieldVaLue(str);
            txtGiaBan.Text = hd.GetFieldVaLue(str1);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[i];
                txtMaHD.Text = row.Cells["mhd"].Value.ToString();
                cboMaKH.Text = row.Cells["mkh"].Value.ToString();
                dtpNgayBan.Text = row.Cells["nb"].Value.ToString();
                cboMaTB.Text = row.Cells["mtb"].Value.ToString();
                txtSoLuong.Text = row.Cells["sl"].Value.ToString();
                txtGiaBan.Text = row.Cells["gb"].Value.ToString();
                txtGhiChu.Text = row.Cells["gc"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KtRong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            string mahd = txtMaHD.Text.Trim();
            string makh = cboMaKH.Text.Trim();
            string ngayban = dtpNgayBan.Value.ToString();
            string matb = cboMaTB.Text.Trim();
            int soluong = Convert.ToInt32(txtSoLuong.Text);
            double giaban = Convert.ToDouble(txtGiaBan.Text);
            string ghichu = txtGhiChu.Text;

            if (hd.ExistMa(mahd))
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại!");
                return;
            }
            else
            {
                hd.CreateHoaDon(mahd, makh, ngayban, matb, soluong, giaban, ghichu);
                LoadData();
                ClearText();
                txtMaHD.Focus();
                frmHoaDon_Load(sender, e);
                MessageBox.Show("Thêm hóa đơn có mã " + mahd + " thành công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim() != "" && cboMaTB.Text.Trim() != "")
            {
                if (MessageBox.Show("Có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    hd.DeleteHoaDon(txtMaHD.Text, cboMaTB.Text);
                    LoadData();
                    frmHoaDon_Load(sender, e);
                    ClearText();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn mã hóa đơn cần sửa!");
                return;
            }
            if (!hd.ExistMa(txtMaHD.Text.Trim()))
            {
                MessageBox.Show("Mã hóa đơn không tồn tại!");
                return;
            }

            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtMaHD.Enabled = false;
            btnTk.Enabled = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtMaHD.Enabled = true;
            btnTk.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KtRong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            string mahd = txtMaHD.Text.Trim();
            string makh = cboMaKH.Text.Trim();
            string ngayban = dtpNgayBan.Value.ToString();
            string matb = cboMaTB.Text.Trim();
            int soluong = Convert.ToInt32(txtSoLuong.Text);
            double giaban = Convert.ToDouble(txtGiaBan.Text);
            string ghichu = txtGhiChu.Text;

            hd.UpdateHoaDon(mahd, makh, ngayban);
            hd.UpdateHoaDonTB(mahd, matb, soluong, giaban, ghichu);
            LoadData();
            ClearText();

            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtMaHD.Enabled = true;
            btnTk.Enabled = true;

            txtMaHD.Focus();
            frmHoaDon_Load(sender, e);
            MessageBox.Show("Đã sửa thông tin hóa đơn có mã " + mahd + " thành công!");
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            TKHoaDon frm = new TKHoaDon();
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
