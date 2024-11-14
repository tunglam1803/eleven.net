namespace Nhom11.net
{
    partial class TKNhanVien
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
            this.rbSDTNV = new System.Windows.Forms.RadioButton();
            this.rbTenNV = new System.Windows.Forms.RadioButton();
            this.rbMaNV = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Controls.Add(this.rbSDTNV);
            this.panel1.Controls.Add(this.rbTenNV);
            this.panel1.Controls.Add(this.rbMaNV);
            this.panel1.Location = new System.Drawing.Point(13, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 175);
            this.panel1.TabIndex = 72;
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
            this.txtTk.Location = new System.Drawing.Point(359, 68);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(290, 30);
            this.txtTk.TabIndex = 2;
            // 
            // rbSDTNV
            // 
            this.rbSDTNV.AutoSize = true;
            this.rbSDTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSDTNV.Location = new System.Drawing.Point(54, 112);
            this.rbSDTNV.Name = "rbSDTNV";
            this.rbSDTNV.Size = new System.Drawing.Size(270, 29);
            this.rbSDTNV.TabIndex = 1;
            this.rbSDTNV.TabStop = true;
            this.rbSDTNV.Text = "Tìm kiếm theo số điện thoại";
            this.rbSDTNV.UseVisualStyleBackColor = true;
            // 
            // rbTenNV
            // 
            this.rbTenNV.AutoSize = true;
            this.rbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTenNV.Location = new System.Drawing.Point(54, 71);
            this.rbTenNV.Name = "rbTenNV";
            this.rbTenNV.Size = new System.Drawing.Size(277, 29);
            this.rbTenNV.TabIndex = 0;
            this.rbTenNV.TabStop = true;
            this.rbTenNV.Text = "Tìm kiếm theo tên nhân viên";
            this.rbTenNV.UseVisualStyleBackColor = true;
            // 
            // rbMaNV
            // 
            this.rbMaNV.AutoSize = true;
            this.rbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaNV.Location = new System.Drawing.Point(54, 27);
            this.rbMaNV.Name = "rbMaNV";
            this.rbMaNV.Size = new System.Drawing.Size(277, 29);
            this.rbMaNV.TabIndex = 0;
            this.rbMaNV.TabStop = true;
            this.rbMaNV.Text = "Tìm kiếm theo mã nhân viên";
            this.rbMaNV.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(389, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 25);
            this.label6.TabIndex = 73;
            this.label6.Text = "TÌM KIẾM NHÂN VIÊN";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(13, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1001, 186);
            this.dataGridView1.TabIndex = 74;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 175;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNV";
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GioiTinhNV";
            this.Column3.HeaderText = "Giới tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DiaChiNV";
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SDTNV";
            this.Column5.HeaderText = "Số điện thoại";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 175;
            // 
            // TKNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TKNhanVien";
            this.Text = "TKNhanVien";
            this.Load += new System.EventHandler(this.TKNhanVien_Load);
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
        private System.Windows.Forms.RadioButton rbSDTNV;
        private System.Windows.Forms.RadioButton rbTenNV;
        private System.Windows.Forms.RadioButton rbMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}