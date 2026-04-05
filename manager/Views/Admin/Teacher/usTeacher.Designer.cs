namespace manager.Views.Admin.Teacher
{
    partial class usTeacher
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
            label1 = new Label();
            txtFullName = new TextBox();
            dgvTeachers = new DataGridView();
            txtEmail = new TextBox();
            label2 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtTeacherCode = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cboDegree = new ComboBox();
            cboFaculty = new ComboBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 56);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(56, 72);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(278, 23);
            txtFullName.TabIndex = 1;
            // 
            // dgvTeachers
            // 
            dgvTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeachers.Location = new Point(30, 203);
            dgvTeachers.Name = "dgvTeachers";
            dgvTeachers.Size = new Size(1011, 360);
            dgvTeachers.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(467, 72);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 23);
            txtEmail.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(464, 56);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(855, 72);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(183, 23);
            txtPhone.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(852, 56);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 5;
            label3.Text = "SĐT";
            // 
            // txtTeacherCode
            // 
            txtTeacherCode.Location = new Point(467, 140);
            txtTeacherCode.Name = "txtTeacherCode";
            txtTeacherCode.Size = new Size(250, 23);
            txtTeacherCode.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 124);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 7;
            label4.Text = "Mã GV";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 124);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 9;
            label5.Text = "Bằng cấp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(855, 124);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 10;
            label6.Text = "Khoa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 587);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 11;
            label7.Text = "Tìm thông tin";
            // 
            // cboDegree
            // 
            cboDegree.FormattingEnabled = true;
            cboDegree.Items.AddRange(new object[] { "Cử nhân", "Thạc sĩ", "Tiến sĩ", "PGS.TS" });
            cboDegree.Location = new Point(57, 140);
            cboDegree.Name = "cboDegree";
            cboDegree.Size = new Size(277, 23);
            cboDegree.TabIndex = 12;
            // 
            // cboFaculty
            // 
            cboFaculty.FormattingEnabled = true;
            cboFaculty.Location = new Point(855, 142);
            cboFaculty.Name = "cboFaculty";
            cboFaculty.Size = new Size(174, 23);
            cboFaculty.TabIndex = 13;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(113, 584);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(404, 23);
            txtSearch.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(569, 578);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(83, 29);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(678, 578);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(87, 29);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(787, 578);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(81, 29);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(976, 653);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 18;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // usTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(cboFaculty);
            Controls.Add(cboDegree);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtTeacherCode);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(dgvTeachers);
            Controls.Add(txtFullName);
            Controls.Add(label1);
            Name = "usTeacher";
            Size = new Size(1073, 705);
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFullName;
        private DataGridView dgvTeachers;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtTeacherCode;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cboDegree;
        private ComboBox cboFaculty;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnBack;
    }
}
