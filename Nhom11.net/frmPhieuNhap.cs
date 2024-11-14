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
    public partial class frmPhieuNhap : Form
    {
        PhieuNhap pn;

        public frmPhieuNhap()
        {
            InitializeComponent();
            txtTenNV.Enabled = false;
            txtTenTB.Enabled = false;
            txtGiaNhap.Enabled = false;
            txtMaPN.Focus();
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadData();
            ThanhTien();
        }

        public void LoadData()
        {
            pn = new PhieuNhap();
            dataGridView1.DataSource = pn.GetAllPhieuNhap();
            LoadcboMaNV();
            LoadCBOMaTB();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KtRong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            string mapn = txtMaPN.Text.Trim();
            string manv = cboMaNV.Text.Trim();
            string ngaynhap = dtpNgayNhap.Value.ToString();
            string matb = cboMaTB.Text.Trim();
            int soluong = Convert.ToInt32(txtSoLuong.Text);
            double gianhap = Convert.ToDouble(txtGiaNhap.Text);
            string ghichu = txtGhiChu.Text;

            if (pn.ExistMa(mapn))
            {
                MessageBox.Show("Mã phiếu nhập đã tồn tại!");
                return;
            }
            else
            {
                pn.CreateHoaDon(mapn, manv, ngaynhap, matb, soluong, gianhap, ghichu);
                LoadData();
                ClearText();
                txtMaPN.Focus();
                frmPhieuNhap_Load(sender, e);
                MessageBox.Show("Thêm thông tin phiếu nhập có mã " + mapn + " thành công!");
            }
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            txtMaPN.Focus();
            LoadData();
            ThanhTien();
        }

        bool KtRong()
        {
            if (txtMaPN.Text.Trim() == "") return false;
            if (cboMaNV.Text.Trim() == "") return false;
            if (cboMaTB.Text.Trim() == "") return false;
            if (txtSoLuong.Text.Trim() == "") return false;
            if (txtGiaNhap.Text.Trim() == "") return false;
            if (txtGhiChu.Text.Trim() == "") return false;
            return true;
        }

        void ClearText()
        {
            txtMaPN.Clear();
            txtSoLuong.Clear();
            txtGiaNhap.Clear();
            txtGhiChu.Clear();
            txtTenNV.Clear();
            txtTenTB.Clear();
        }

        void LoadcboMaNV()
        {
            cboMaNV.Items.Clear();
            foreach (DataRow row in pn.GetTenNV().Rows)
            {
                cboMaNV.Items.Add(row[0]);
            }
        }

        void LoadCBOMaTB()
        {
            cboMaTB.Items.Clear();
            foreach (DataRow row in pn.GetTenTB().Rows)
            {
                cboMaTB.Items.Add(row[0]);
            }
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaNV.Text == "")
                txtTenNV.Text = "";
            str = "SELECT TenNV FROM NhanVien where MaNV = N'" + cboMaNV.Text + "'";
            txtTenNV.Text = pn.GetFieldVaLue(str);
        }

        private void cboMaTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str, str1;
            if (cboMaTB.Text == "")
            {
                txtTenTB.Text = "";
                txtGiaNhap.Text = "";
            }
            str = "SELECT TenTB FROM ThietBi where MaTB = N'" + cboMaTB.Text + "'";
            str1 = "SELECT GiaNhap FROM ThietBi where MaTB = N'" + cboMaTB.Text + "'";
            txtTenTB.Text = pn.GetFieldVaLue(str);
            txtGiaNhap.Text = pn.GetFieldVaLue(str1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[i];
                txtMaPN.Text = row.Cells["mpn"].Value.ToString();
                cboMaNV.Text = row.Cells["mnv"].Value.ToString();
                dtpNgayNhap.Text = row.Cells["nn"].Value.ToString();
                cboMaTB.Text = row.Cells["mtb"].Value.ToString();
                txtSoLuong.Text = row.Cells["sl"].Value.ToString();
                txtGiaNhap.Text = row.Cells["gn"].Value.ToString();
                txtGhiChu.Text = row.Cells["gc"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPN.Text.Trim() != "" && cboMaTB.Text.Trim() != "")
            {
                if (MessageBox.Show("Có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    pn.DeletePhieuNhap(txtMaPN.Text, cboMaTB.Text);
                    LoadData();
                    ClearText();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPN.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn mã phiếu nhập cần sửa!");
                return;
            }
            if (!pn.ExistMa(txtMaPN.Text.Trim()))
            {
                MessageBox.Show("Mã phiếu nhập không tồn tại!");
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KtRong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            string mapn = txtMaPN.Text.Trim();
            string manv = cboMaNV.Text.Trim();
            string ngaynhap = dtpNgayNhap.Value.ToString();
            string matb = cboMaTB.Text.Trim();
            int soluong = Convert.ToInt32(txtSoLuong.Text);
            double gianhap = Convert.ToDouble(txtGiaNhap.Text);
            string ghichu = txtGhiChu.Text;

            pn.UpdatePhieuNhap(mapn, manv, ngaynhap);
            pn.UpdatePhieuNhapTB(mapn, matb, soluong, gianhap, ghichu);
            LoadData();
            ClearText();

            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtMaPN.Enabled = true;
            btnTk.Enabled = true;

            txtMaPN.Focus();
            frmPhieuNhap_Load(sender, e);
            MessageBox.Show("Đã sửa thông tin phiếu nhập có mã " + mapn + " thành công!");
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtMaPN.Enabled = true;
            btnTk.Enabled = true;
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            TKPhieuNhap frm = new TKPhieuNhap();
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
