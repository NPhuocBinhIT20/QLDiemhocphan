namespace QLDiem
{
    partial class FrmQLDiem
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.DTGSinhVien = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnNhap = new System.Windows.Forms.ToolStripButton();
            this.sinhVienVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemKTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemThiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDHocPhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnXoa,
            this.btnSua,
            this.btnNhap});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(828, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(115, 22);
            this.toolStripLabel1.Text = "Danh Sach Sinh Vien";
            // 
            // DTGSinhVien
            // 
            this.DTGSinhVien.AllowUserToAddRows = false;
            this.DTGSinhVien.AllowUserToDeleteRows = false;
            this.DTGSinhVien.AutoGenerateColumns = false;
            this.DTGSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDStudentDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.diemCCDataGridViewTextBoxColumn,
            this.diemKTDataGridViewTextBoxColumn,
            this.diemThiDataGridViewTextBoxColumn,
            this.iDHocPhanDataGridViewTextBoxColumn,
            this.classNameDataGridViewTextBoxColumn});
            this.DTGSinhVien.DataSource = this.sinhVienVMBindingSource;
            this.DTGSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTGSinhVien.Location = new System.Drawing.Point(0, 25);
            this.DTGSinhVien.Name = "DTGSinhVien";
            this.DTGSinhVien.ReadOnly = true;
            this.DTGSinhVien.Size = new System.Drawing.Size(828, 425);
            this.DTGSinhVien.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoa.Image = global::QLDiem.Properties.Resources._3669361_delete_ic_icon;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(78, 22);
            this.btnXoa.Text = "Xoa Diem";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSua.Image = global::QLDiem.Properties.Resources._3325116_edit_icon;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 22);
            this.btnSua.Text = "Sua Diem";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnNhap.Image = global::QLDiem.Properties.Resources._326501_add_circle_icon;
            this.btnNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(87, 22);
            this.btnNhap.Text = "Nhap Diem";
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // sinhVienVMBindingSource
            // 
            this.sinhVienVMBindingSource.DataSource = typeof(QLDiem.ViewModel.SinhVienVM);
            // 
            // iDStudentDataGridViewTextBoxColumn
            // 
            this.iDStudentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDStudentDataGridViewTextBoxColumn.DataPropertyName = "IDStudent";
            this.iDStudentDataGridViewTextBoxColumn.HeaderText = "Mã Sinh Viên";
            this.iDStudentDataGridViewTextBoxColumn.Name = "iDStudentDataGridViewTextBoxColumn";
            this.iDStudentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Họ Tên";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diemCCDataGridViewTextBoxColumn
            // 
            this.diemCCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diemCCDataGridViewTextBoxColumn.DataPropertyName = "DiemCC";
            this.diemCCDataGridViewTextBoxColumn.HeaderText = "Điểm Chuyên Cần";
            this.diemCCDataGridViewTextBoxColumn.Name = "diemCCDataGridViewTextBoxColumn";
            this.diemCCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diemKTDataGridViewTextBoxColumn
            // 
            this.diemKTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.diemKTDataGridViewTextBoxColumn.DataPropertyName = "DiemKT";
            this.diemKTDataGridViewTextBoxColumn.HeaderText = "Điểm Kiểm Tra ";
            this.diemKTDataGridViewTextBoxColumn.Name = "diemKTDataGridViewTextBoxColumn";
            this.diemKTDataGridViewTextBoxColumn.ReadOnly = true;
            this.diemKTDataGridViewTextBoxColumn.Width = 104;
            // 
            // diemThiDataGridViewTextBoxColumn
            // 
            this.diemThiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diemThiDataGridViewTextBoxColumn.DataPropertyName = "DiemThi";
            this.diemThiDataGridViewTextBoxColumn.HeaderText = "Điểm Thi";
            this.diemThiDataGridViewTextBoxColumn.Name = "diemThiDataGridViewTextBoxColumn";
            this.diemThiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDHocPhanDataGridViewTextBoxColumn
            // 
            this.iDHocPhanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDHocPhanDataGridViewTextBoxColumn.DataPropertyName = "IDHocPhan";
            this.iDHocPhanDataGridViewTextBoxColumn.HeaderText = "Mã Học Phần";
            this.iDHocPhanDataGridViewTextBoxColumn.Name = "iDHocPhanDataGridViewTextBoxColumn";
            this.iDHocPhanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classNameDataGridViewTextBoxColumn
            // 
            this.classNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.classNameDataGridViewTextBoxColumn.DataPropertyName = "ClassName";
            this.classNameDataGridViewTextBoxColumn.HeaderText = "Tên Hoc Phần";
            this.classNameDataGridViewTextBoxColumn.Name = "classNameDataGridViewTextBoxColumn";
            this.classNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmQLDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.DTGSinhVien);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmQLDiem";
            this.Text = "0000";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienVMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnNhap;
        private System.Windows.Forms.DataGridView DTGSinhVien;
        private System.Windows.Forms.BindingSource sinhVienVMBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemKTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemThiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHocPhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNameDataGridViewTextBoxColumn;
    }
}