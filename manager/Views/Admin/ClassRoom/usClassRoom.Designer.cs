namespace manager.Views.Admin.ClassRoom
{
    partial class usClassRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtClassCode = new TextBox();
            txtClassName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            nmrAcademicYear = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvClassRooms = new DataGridView();
            txtMajorId = new ComboBox();
            txtTeacherId = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nmrAcademicYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClassRooms).BeginInit();
            SuspendLayout();
            // 
            // txtClassCode
            // 
            txtClassCode.Location = new Point(25, 42);
            txtClassCode.Name = "txtClassCode";
            txtClassCode.Size = new Size(160, 23);
            txtClassCode.TabIndex = 0;
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(205, 41);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(174, 23);
            txtClassName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Mã lớp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 23);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 3;
            label2.Text = "Chuyên ngành";
            // 
            // nmrAcademicYear
            // 
            nmrAcademicYear.Location = new Point(826, 41);
            nmrAcademicYear.Maximum = new decimal(new int[] { 2050, 0, 0, 0 });
            nmrAcademicYear.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            nmrAcademicYear.Name = "nmrAcademicYear";
            nmrAcademicYear.Size = new Size(164, 23);
            nmrAcademicYear.TabIndex = 4;
            nmrAcademicYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            nmrAcademicYear.ValueChanged += nmrAcademicYear_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 23);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 7;
            label3.Text = "Tên lớp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(617, 24);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 8;
            label4.Text = "Giảng viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(826, 23);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 9;
            label5.Text = "Năm học";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(28, 89);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 42);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(162, 89);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 42);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(299, 89);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 42);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Xoá";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(436, 89);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 42);
            btnClear.TabIndex = 13;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvClassRooms
            // 
            dgvClassRooms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClassRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClassRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClassRooms.Location = new Point(25, 163);
            dgvClassRooms.MultiSelect = false;
            dgvClassRooms.Name = "dgvClassRooms";
            dgvClassRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClassRooms.Size = new Size(1029, 526);
            dgvClassRooms.TabIndex = 14;
            // 
            // txtMajorId
            // 
            txtMajorId.FormattingEnabled = true;
            txtMajorId.Location = new Point(401, 41);
            txtMajorId.Name = "txtMajorId";
            txtMajorId.Size = new Size(191, 23);
            txtMajorId.TabIndex = 17;
            // 
            // txtTeacherId
            // 
            txtTeacherId.FormattingEnabled = true;
            txtTeacherId.Location = new Point(617, 42);
            txtTeacherId.Name = "txtTeacherId";
            txtTeacherId.Size = new Size(191, 23);
            txtTeacherId.TabIndex = 18;
            // 
            // usClassRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtTeacherId);
            Controls.Add(txtMajorId);
            Controls.Add(dgvClassRooms);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(nmrAcademicYear);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtClassName);
            Controls.Add(txtClassCode);
            Name = "usClassRoom";
            Size = new Size(1073, 705);
            ((System.ComponentModel.ISupportInitialize)nmrAcademicYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClassRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtClassCode;
        private TextBox txtClassName;
        private Label label1;
        private Label label2;
        private NumericUpDown nmrAcademicYear;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvClassRooms;
        private ComboBox txtMajorId;
        private ComboBox txtTeacherId;
    }
}
