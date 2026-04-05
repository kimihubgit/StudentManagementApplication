namespace manager.Views.Admin.Student
{
    partial class usStudent
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
            txtMSSV = new TextBox();
            txtFullName = new TextBox();
            cboGender = new ComboBox();
            dtpBirth = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cboClass = new ComboBox();
            numGPA = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            cboStatus = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numGPA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(66, 28);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(121, 23);
            txtMSSV.TabIndex = 0;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(212, 28);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(120, 23);
            txtFullName.TabIndex = 1;
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(351, 28);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(121, 23);
            cboGender.TabIndex = 2;
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(521, 28);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(194, 23);
            dtpBirth.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 10);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 4;
            label1.Text = "MSSV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 10);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 5;
            label2.Text = "Họ Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 10);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "Giới Tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(521, 10);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 7;
            label4.Text = "Ngày, tháng, năm sinh";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(780, 28);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(129, 23);
            txtAddress.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(780, 10);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 9;
            label5.Text = "Địa Chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 77);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 10;
            label6.Text = "Lớp Học";
            // 
            // cboClass
            // 
            cboClass.FormattingEnabled = true;
            cboClass.Location = new Point(66, 95);
            cboClass.Name = "cboClass";
            cboClass.Size = new Size(121, 23);
            cboClass.TabIndex = 11;
            // 
            // numGPA
            // 
            numGPA.DecimalPlaces = 2;
            numGPA.Location = new Point(212, 96);
            numGPA.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numGPA.Name = "numGPA";
            numGPA.Size = new Size(120, 23);
            numGPA.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(212, 78);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 13;
            label7.Text = "Điểm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(351, 77);
            label8.Name = "label8";
            label8.Size = new Size(115, 15);
            label8.TabIndex = 14;
            label8.Text = "Trạng Thái Sinh Viên";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(351, 96);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(121, 23);
            cboStatus.TabIndex = 15;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(185, 134);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 47);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(334, 134);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(105, 47);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(493, 134);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 47);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(661, 134);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 47);
            btnClear.TabIndex = 19;
            btnClear.Text = "Làm Mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(15, 207);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(1044, 460);
            dgvStudents.TabIndex = 20;
            // 
            // usStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvStudents);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cboStatus);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(numGPA);
            Controls.Add(cboClass);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpBirth);
            Controls.Add(cboGender);
            Controls.Add(txtFullName);
            Controls.Add(txtMSSV);
            Name = "usStudent";
            Size = new Size(1073, 705);
            ((System.ComponentModel.ISupportInitialize)numGPA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMSSV;
        private TextBox txtFullName;
        private ComboBox cboGender;
        private DateTimePicker dtpBirth;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAddress;
        private Label label5;
        private Label label6;
        private ComboBox cboClass;
        private NumericUpDown numGPA;
        private Label label7;
        private Label label8;
        private ComboBox cboStatus;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvStudents;
    }
}
