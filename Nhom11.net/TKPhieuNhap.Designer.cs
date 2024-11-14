namespace Nhom11.net
{
    partial class TKPhieuNhap
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTk = new System.Windows.Forms.Button();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.rbThietBi = new System.Windows.Forms.RadioButton();
            this.rbMaNV = new System.Windows.Forms.RadioButton();
            this.rbMaPN = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mpn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mpn,
            this.mnv,
            this.nn,
            this.mtb,
            this.sl,
            this.gn,
            this.tt,
            this.gc});
            this.dataGridView1.Location = new System.Drawing.Point(14, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1001, 312);
            this.dataGridView1.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(371, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 84;
            this.label1.Text = "TÌM KIẾM PHIẾU NHẬP";
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
            // rbThietBi
            // 
            this.rbThietBi.AutoSize = true;
            this.rbThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThietBi.Location = new System.Drawing.Point(54, 112);
            this.rbThietBi.Name = "rbThietBi";
            this.rbThietBi.Size = new System.Drawing.Size(248, 29);
            this.rbThietBi.TabIndex = 1;
            this.rbThietBi.TabStop = true;
            this.rbThietBi.Text = "Tìm kiếm theo mã thiết bị";
            this.rbThietBi.UseVisualStyleBackColor = true;
            // 
            // rbMaNV
            // 
            this.rbMaNV.AutoSize = true;
            this.rbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaNV.Location = new System.Drawing.Point(54, 71);
            this.rbMaNV.Name = "rbMaNV";
            this.rbMaNV.Size = new System.Drawing.Size(277, 29);
            this.rbMaNV.TabIndex = 0;
            this.rbMaNV.TabStop = true;
            this.rbMaNV.Text = "Tìm kiếm theo mã nhân viên";
            this.rbMaNV.UseVisualStyleBackColor = true;
            // 
            // rbMaPN
            // 
            this.rbMaPN.AutoSize = true;
            this.rbMaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaPN.Location = new System.Drawing.Point(54, 27);
            this.rbMaPN.Name = "rbMaPN";
            this.rbMaPN.Size = new System.Drawing.Size(289, 29);
            this.rbMaPN.TabIndex = 0;
            this.rbMaPN.TabStop = true;
            this.rbMaPN.Text = "Tìm kiếm theo mã phiếu nhập";
            this.rbMaPN.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnTk);
            this.panel1.Controls.Add(this.txtTk);
            this.panel1.Controls.Add(this.rbThietBi);
            this.panel1.Controls.Add(this.rbMaNV);
            this.panel1.Controls.Add(this.rbMaPN);
            this.panel1.Location = new System.Drawing.Point(13, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 174);
            this.panel1.TabIndex = 82;
            // 
            // mpn
            // 
            this.mpn.DataPropertyName = "MaPN";
            this.mpn.HeaderText = "Mã phiếu nhập";
            this.mpn.MinimumWidth = 6;
            this.mpn.Name = "mpn";
            this.mpn.Width = 140;
            // 
            // mnv
            // 
            this.mnv.DataPropertyName = "MaNV";
            this.mnv.HeaderText = "Mã nhân viên";
            this.mnv.MinimumWidth = 6;
            this.mnv.Name = "mnv";
            this.mnv.Width = 140;
            // 
            // nn
            // 
            this.nn.DataPropertyName = "NgayNhap";
            this.nn.HeaderText = "Ngày nhập";
            this.nn.MinimumWidth = 6;
            this.nn.Name = "nn";
            this.nn.Width = 140;
            // 
            // mtb
            // 
            this.mtb.DataPropertyName = "MaTB";
            this.mtb.HeaderText = "Mã thiết bị";
            this.mtb.MinimumWidth = 6;
            this.mtb.Name = "mtb";
            this.mtb.Width = 140;
            // 
            // sl
            // 
            this.sl.DataPropertyName = "SoLuong";
            this.sl.HeaderText = "Số lượng";
            this.sl.MinimumWidth = 6;
            this.sl.Name = "sl";
            this.sl.Width = 140;
            // 
            // gn
            // 
            this.gn.DataPropertyName = "GiaNhap";
            this.gn.HeaderText = "Giá nhập";
            this.gn.MinimumWidth = 6;
            this.gn.Name = "gn";
            this.gn.Width = 140;
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
            this.gc.Width = 140;
            // 
            // TKPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 568);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TKPhieuNhap";
            this.Text = "TKPhieuNhap";
            this.Load += new System.EventHandler(this.TKPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTk;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.RadioButton rbThietBi;
        private System.Windows.Forms.RadioButton rbMaNV;
        private System.Windows.Forms.RadioButton rbMaPN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtb;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn gn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn gc;
    }
}