namespace Nhom11.net
{
    partial class TKThietBi
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbhangsx = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTk = new System.Windows.Forms.Button();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.rbLoaiTB = new System.Windows.Forms.RadioButton();
            this.rbTenTB = new System.Windows.Forms.RadioButton();
            this.rbMaTB = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaitb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nsx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(388, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 81;
            this.label1.Text = "TÌM KIẾM THIẾT BỊ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbhangsx);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnTk);
            this.panel1.Controls.Add(this.txtTk);
            this.panel1.Controls.Add(this.rbLoaiTB);
            this.panel1.Controls.Add(this.rbTenTB);
            this.panel1.Controls.Add(this.rbMaTB);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 192);
            this.panel1.TabIndex = 82;
            // 
            // rbhangsx
            // 
            this.rbhangsx.AutoSize = true;
            this.rbhangsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbhangsx.Location = new System.Drawing.Point(45, 140);
            this.rbhangsx.Name = "rbhangsx";
            this.rbhangsx.Size = new System.Drawing.Size(283, 29);
            this.rbhangsx.TabIndex = 9;
            this.rbhangsx.TabStop = true;
            this.rbhangsx.Text = "Tìm kiếm theo hãng sản xuất";
            this.rbhangsx.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(846, 65);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 33);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTk
            // 
            this.btnTk.Location = new System.Drawing.Point(715, 65);
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
            this.txtTk.Location = new System.Drawing.Point(365, 66);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(290, 30);
            this.txtTk.TabIndex = 2;
            // 
            // rbLoaiTB
            // 
            this.rbLoaiTB.AutoSize = true;
            this.rbLoaiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLoaiTB.Location = new System.Drawing.Point(45, 100);
            this.rbLoaiTB.Name = "rbLoaiTB";
            this.rbLoaiTB.Size = new System.Drawing.Size(251, 29);
            this.rbLoaiTB.TabIndex = 1;
            this.rbLoaiTB.TabStop = true;
            this.rbLoaiTB.Text = "Tìm kiếm theo loại thiết bị";
            this.rbLoaiTB.UseVisualStyleBackColor = true;
            // 
            // rbTenTB
            // 
            this.rbTenTB.AutoSize = true;
            this.rbTenTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTenTB.Location = new System.Drawing.Point(44, 58);
            this.rbTenTB.Name = "rbTenTB";
            this.rbTenTB.Size = new System.Drawing.Size(248, 29);
            this.rbTenTB.TabIndex = 0;
            this.rbTenTB.TabStop = true;
            this.rbTenTB.Text = "Tìm kiếm theo tên thiết bị";
            this.rbTenTB.UseVisualStyleBackColor = true;
            // 
            // rbMaTB
            // 
            this.rbMaTB.AutoSize = true;
            this.rbMaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaTB.Location = new System.Drawing.Point(45, 15);
            this.rbMaTB.Name = "rbMaTB";
            this.rbMaTB.Size = new System.Drawing.Size(248, 29);
            this.rbMaTB.TabIndex = 0;
            this.rbMaTB.TabStop = true;
            this.rbMaTB.Text = "Tìm kiếm theo mã thiết bị";
            this.rbMaTB.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matb,
            this.tentb,
            this.loaitb,
            this.hsx,
            this.nsx,
            this.gb,
            this.gn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1001, 292);
            this.dataGridView1.TabIndex = 83;
            // 
            // matb
            // 
            this.matb.DataPropertyName = "MaTB";
            this.matb.HeaderText = "Mã thiết bị";
            this.matb.MinimumWidth = 6;
            this.matb.Name = "matb";
            this.matb.Width = 125;
            // 
            // tentb
            // 
            this.tentb.DataPropertyName = "TenTB";
            this.tentb.HeaderText = "Tên thiết bị";
            this.tentb.MinimumWidth = 6;
            this.tentb.Name = "tentb";
            this.tentb.Width = 175;
            // 
            // loaitb
            // 
            this.loaitb.DataPropertyName = "LoaiTB";
            this.loaitb.HeaderText = "Loại thiết bị";
            this.loaitb.MinimumWidth = 6;
            this.loaitb.Name = "loaitb";
            this.loaitb.Width = 150;
            // 
            // hsx
            // 
            this.hsx.DataPropertyName = "HangSX";
            this.hsx.HeaderText = "Hãng sản xuất";
            this.hsx.MinimumWidth = 6;
            this.hsx.Name = "hsx";
            this.hsx.Width = 140;
            // 
            // nsx
            // 
            this.nsx.DataPropertyName = "NamSX";
            this.nsx.HeaderText = "Năm sản xuất";
            this.nsx.MinimumWidth = 6;
            this.nsx.Name = "nsx";
            this.nsx.Width = 130;
            // 
            // gb
            // 
            this.gb.DataPropertyName = "GiaBan";
            this.gb.HeaderText = "Giá bán";
            this.gb.MinimumWidth = 6;
            this.gb.Name = "gb";
            this.gb.Width = 125;
            // 
            // gn
            // 
            this.gn.DataPropertyName = "GiaNhap";
            this.gn.HeaderText = "Giá nhập";
            this.gn.MinimumWidth = 6;
            this.gn.Name = "gn";
            this.gn.Width = 130;
            // 
            // TKThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 568);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TKThietBi";
            this.Text = "TKThietBi";
            this.Load += new System.EventHandler(this.TKThietBi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbhangsx;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTk;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.RadioButton rbLoaiTB;
        private System.Windows.Forms.RadioButton rbTenTB;
        private System.Windows.Forms.RadioButton rbMaTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matb;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentb;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaitb;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsx;
        private System.Windows.Forms.DataGridViewTextBoxColumn nsx;
        private System.Windows.Forms.DataGridViewTextBoxColumn gb;
        private System.Windows.Forms.DataGridViewTextBoxColumn gn;
    }
}