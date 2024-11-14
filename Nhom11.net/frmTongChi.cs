using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Nhom11.net
{
    public partial class frmTongChi : Form
    {
        BaoCaoChiTieu bctk;

        public frmTongChi()
        {
            InitializeComponent();
            bctk = new BaoCaoChiTieu();
            ThanhTien();
        }

        void ThanhTien()
        {
            decimal tt = 0;
            if (dataGridViewThongKe.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewThongKe.Rows)
                {
                    int soLuong = Convert.ToInt32(row.Cells["sl"].Value);
                    decimal giaban = Convert.ToDecimal(row.Cells["gb"].Value);
                    decimal s = soLuong * giaban;
                    row.Cells["tt"].Value = s;
                    tt += s;
                }
            }
            txtTien.Text = tt.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string start, end, nam1, thang1, nam, thang;
            nam = cbYear.SelectedItem.ToString();
            thang = cbMonth.SelectedItem.ToString();
            nam1 = cboDenNam.SelectedItem.ToString();
            thang1 = cboDenThang.SelectedItem.ToString();
            start = nam + "-" + thang + "-01";
            end = nam1 + "-" + thang1 + "-30";
            dataGridViewThongKe.DataSource = bctk.GetThongKe(start, end);
            frmTongChi_Load(sender, e);
        }

        private void frmTongChi_Load(object sender, EventArgs e)
        {
            ThanhTien();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Tạo ứng dụng Excel và workbook
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = workbook.Sheets[1];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "BaoCaoChiTIeu";

            try
            {
                // Thiết lập tiêu đề cột
                for (int i = 1; i < dataGridViewThongKe.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridViewThongKe.Columns[i - 1].HeaderText;
                }

                // Thiết lập dữ liệu cho các hàng
                for (int i = 0; i < dataGridViewThongKe.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewThongKe.Columns.Count; j++)
                    {
                        var cellValue = dataGridViewThongKe.Rows[i].Cells[j].Value;
                        worksheet.Cells[i + 2, j + 1] = cellValue != null ? cellValue.ToString() : ""; // kiểm tra null
                    }
                }

                // Hộp thoại lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                saveFileDialog.Title = "Lưu File Excel";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Giải phóng bộ nhớ
                workbook.Close(false, Type.Missing, Type.Missing);
                excelApp.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
