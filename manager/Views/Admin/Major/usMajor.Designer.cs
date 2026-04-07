namespace manager.Views.Admin.Major
{
    partial class usMajor
    {
        private System.Windows.Forms.DataGridView dgvChuyenNganh;
        private System.Windows.Forms.TextBox txtMaChuyenNganh;
        private System.Windows.Forms.TextBox txtTenChuyenNganh;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblKhoa;
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvChuyenNganh = new DataGridView();
            txtMaChuyenNganh = new TextBox();
            txtTenChuyenNganh = new TextBox();
            cbKhoa = new ComboBox();
            btnLamMoi = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            lblMa = new Label();
            lblTen = new Label();
            lblKhoa = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvChuyenNganh).BeginInit();
            SuspendLayout();
            // 
            // dgvChuyenNganh
            // 
            dgvChuyenNganh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvChuyenNganh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChuyenNganh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChuyenNganh.Location = new Point(20, 120);
            dgvChuyenNganh.Name = "dgvChuyenNganh";
            dgvChuyenNganh.Size = new Size(1033, 560);
            dgvChuyenNganh.TabIndex = 0;
            dgvChuyenNganh.CellClick += dgvChuyenNganh_CellClick;
            // 
            // txtMaChuyenNganh
            // 
            txtMaChuyenNganh.Location = new Point(129, 20);
            txtMaChuyenNganh.Name = "txtMaChuyenNganh";
            txtMaChuyenNganh.Size = new Size(240, 23);
            txtMaChuyenNganh.TabIndex = 1;
            // 
            // txtTenChuyenNganh
            // 
            txtTenChuyenNganh.Location = new Point(131, 55);
            txtTenChuyenNganh.Name = "txtTenChuyenNganh";
            txtTenChuyenNganh.Size = new Size(240, 23);
            txtTenChuyenNganh.TabIndex = 2;
            // 
            // cbKhoa
            // 
            cbKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKhoa.FormattingEnabled = true;
            cbKhoa.Location = new Point(520, 20);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new Size(240, 23);
            cbKhoa.TabIndex = 3;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(520, 55);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 36);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(620, 55);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 36);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(720, 55);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 36);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(820, 55);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 36);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // lblMa
            // 
            lblMa.AutoSize = true;
            lblMa.Location = new Point(20, 23);
            lblMa.Name = "lblMa";
            lblMa.Size = new Size(103, 15);
            lblMa.TabIndex = 8;
            lblMa.Text = "Mã chuyên ngành";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(20, 58);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(105, 15);
            lblTen.TabIndex = 9;
            lblTen.Text = "Tên chuyên ngành";
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Location = new Point(480, 20);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(34, 15);
            lblKhoa.TabIndex = 10;
            lblKhoa.Text = "Khoa";
            // 
            // usMajor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblKhoa);
            Controls.Add(lblTen);
            Controls.Add(lblMa);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnLamMoi);
            Controls.Add(cbKhoa);
            Controls.Add(txtTenChuyenNganh);
            Controls.Add(txtMaChuyenNganh);
            Controls.Add(dgvChuyenNganh);
            Name = "usMajor";
            Size = new Size(1073, 705);
            ((System.ComponentModel.ISupportInitialize)dgvChuyenNganh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
