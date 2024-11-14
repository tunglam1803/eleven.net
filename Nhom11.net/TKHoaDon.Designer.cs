namespace Nhom11.net
{
    partial class TKHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTk = new System.Windows.Forms.Button();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.rbTacGia = new System.Windows.Forms.RadioButton();
            this.rbTenSach = new System.Windows.Forms.RadioButton();
            this.rbMaSach = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(850, 67);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 33);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnTk);
            this.panel1.Controls.Add(this.txtTk);
            this.panel1.Controls.Add(this.rbTacGia);
            this.panel1.Controls.Add(this.rbTenSach);
            this.panel1.Controls.Add(this.rbMaSach);
            this.panel1.Location = new System.Drawing.Point(13, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 175);
            this.panel1.TabIndex = 75;
            // 
            // btnTk
            // 
            this.btnTk.Location = new System.Drawing.Point(729, 67);
            this.btnTk.Name = "btnTk";
            this.btnTk.Size = new System.Drawing.Size(101, 33);
            this.btnTk.TabIndex = 8;
            this.btnTk.Text = "Tìm kiếm";
            this.btnTk.UseVisualStyleBackColor = true;
            this.btnTk.Click += new System.EventHandler(this.btnTk_Click);
            // 
            // txtTk
            // 
            this.txtTk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTk.Location = new System.Drawing.Point(380, 68);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(290, 30);
            this.txtTk.TabIndex = 2;
            // 
            // rbTacGia
            // 
            this.rbTacGia.AutoSize = true;
            this.rbTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTacGia.Location = new System.Drawing.Point(54, 112);
            this.rbTacGia.Name = "rbTacGia";
            this.rbTacGia.Size = new System.Drawing.Size(248, 29);
            this.rbTacGia.TabIndex = 1;
            this.rbTacGia.TabStop = true;
            this.rbTacGia.Text = "Tìm kiếm theo mã thiết bị";
            this.rbTacGia.UseVisualStyleBackColor = true;
            // 
            // rbTenSach
            // 
            this.rbTenSach.AutoSize = true;
            this.rbTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTenSach.Location = new System.Drawing.Point(54, 71);
            this.rbTenSach.Name = "rbTenSach";
            this.rbTenSach.Size = new System.Drawing.Size(294, 29);
            this.rbTenSach.TabIndex = 0;
            this.rbTenSach.TabStop = true;
            this.rbTenSach.Text = "Tìm kiếm theo mã khách hàng";
            this.rbTenSach.UseVisualStyleBackColor = true;
            // 
            // rbMaSach
            // 
            this.rbMaSach.AutoSize = true;
            this.rbMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaSach.Location = new System.Drawing.Point(54, 27);
            this.rbMaSach.Name = "rbMaSach";
            this.rbMaSach.Size = new System.Drawing.Size(263, 29);
            this.rbMaSach.TabIndex = 0;
            this.rbMaSach.TabStop = true;
            this.rbMaSach.Text = "Tìm kiếm theo mã hóa đơn";
            this.rbMaSach.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(389, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 25);
            this.label6.TabIndex = 76;
            this.label6.Text = "TÌM KIẾM HÓA ĐƠN";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mhd,
            this.mkh,
            this.nb,
            this.mtb,
            this.sl,
            this.gb,
            this.tt,
            this.gc});
            this.dataGridView1.Location = new System.Drawing.Point(13, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1001, 280);
            this.dataGridView1.TabIndex = 20;
            // 
            // mhd
            // 
            this.mhd.DataPropertyName = "MaHD";
            this.mhd.HeaderText = "Mã hóa đơn";
            this.mhd.MinimumWidth = 6;
            this.mhd.Name = "mhd";
            this.mhd.Width = 125;
            // 
            // mkh
            // 
            this.mkh.DataPropertyName = "MaKH";
            this.mkh.HeaderText = "Mã khách hàng";
            this.mkh.MinimumWidth = 6;
            this.mkh.Name = "mkh";
            this.mkh.Width = 125;
            // 
            // nb
            // 
            this.nb.DataPropertyName = "NgayBan";
            this.nb.HeaderText = "Ngày bán";
            this.nb.MinimumWidth = 6;
            this.nb.Name = "nb";
            this.nb.Width = 125;
            // 
            // mtb
            // 
            this.mtb.DataPropertyName = "MaTB";
            this.mtb.HeaderText = "Mã thiết bị";
            this.mtb.MinimumWidth = 6;
            this.mtb.Name = "mtb";
            this.mtb.Width = 125;
            // 
            // sl
            // 
            this.sl.DataPropertyName = "SoLuong";
            this.sl.HeaderText = "Số lượng";
            this.sl.MinimumWidth = 6;
            this.sl.Name = "sl";
            this.sl.Width = 125;
            // 
            // gb
            // 
            this.gb.DataPropertyName = "GiaBan";
            this.gb.HeaderText = "Giá bán";
            this.gb.MinimumWidth = 6;
            this.gb.Name = "gb";
            this.gb.Width = 125;
            // 
            // tt
            // 
            this.tt.HeaderText = "Tổng tiền";
            this.tt.MinimumWidth = 6;
            this.tt.Name = "tt";
            this.tt.Width = 125;
            // 
            // gc
            // 
            this.gc.DataPropertyName = "GhiChu";
            this.gc.HeaderText = "Ghi chú";
            this.gc.MinimumWidth = 6;
            this.gc.Name = "gc";
            this.gc.Width = 125;
            // 
            // TKHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 568);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TKHoaDon";
            this.Text = "TKHoaDon";
            this.Load += new System.EventHandler(this.TKHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTk;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.RadioButton rbTacGia;
        private System.Windows.Forms.RadioButton rbTenSach;
        private System.Windows.Forms.RadioButton rbMaSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn mkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn nb;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtb;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn gb;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn gc;
    }
}