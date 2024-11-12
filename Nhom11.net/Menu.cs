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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void CloseAllChildForms()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ShowChildForm(Form childForm)
        {
            CloseAllChildForms();

            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.Manual;

            childForm.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            ShowChildForm(frm);
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            ShowChildForm(frm);
        }

        private void quảnLýThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThietBi frm = new frmThietBi();
            ShowChildForm(frm);
        }

        private void phiêuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuNhap frm = new frmPhieuNhap();
            ShowChildForm(frm);
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = new frmHoaDon();
            ShowChildForm(frm);
        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoThongKe frm = new frmBaoCaoThongKe();
            ShowChildForm(frm);
        }

        private void thồngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKNhanVien frm = new TKNhanVien();
            ShowChildForm(frm);
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKKhachHang frm = new TKKhachHang();
            ShowChildForm(frm);
        }

        private void thôngTinThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKThietBi frm = new TKThietBi();
            ShowChildForm(frm);
        }

        private void thôngTinPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKPhieuNhap frm = new TKPhieuNhap();
            ShowChildForm(frm);
        }

        private void thôngTinHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKHoaDon frm = new TKHoaDon();
            ShowChildForm(frm);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
