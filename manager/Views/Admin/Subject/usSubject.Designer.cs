namespace manager.Views.Admin.Subject
{
    partial class usSubject
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
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnUpdate = new Button();
            label3 = new Label();
            btnDelete = new Button();
            btnAdd = new Button();
            txtSubjectCode = new TextBox();
            nmrCredits = new NumericUpDown();
            label1 = new Label();
            txtSubjectName = new TextBox();
            label2 = new Label();
            dgvSubjects = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrCredits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtSubjectCode);
            groupBox1.Controls.Add(nmrCredits);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSubjectName);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(17, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(459, 421);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Môn Học";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(344, 260);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 32);
            btnClear.TabIndex = 11;
            btnClear.Text = "Làm Mới";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(123, 260);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(96, 32);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 155);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 6;
            label3.Text = "Số Tín Chỉ";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(233, 260);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 32);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(13, 260);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 32);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtSubjectCode
            // 
            txtSubjectCode.Location = new Point(6, 58);
            txtSubjectCode.Name = "txtSubjectCode";
            txtSubjectCode.Size = new Size(226, 23);
            txtSubjectCode.TabIndex = 1;
            // 
            // nmrCredits
            // 
            nmrCredits.Location = new Point(6, 173);
            nmrCredits.Name = "nmrCredits";
            nmrCredits.Size = new Size(226, 23);
            nmrCredits.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 40);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 2;
            label1.Text = "Mã Môn Học";
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(6, 117);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(226, 23);
            txtSubjectName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 99);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 3;
            label2.Text = "Tên Môn Học";
            // 
            // dgvSubjects
            // 
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.Location = new Point(530, 49);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.Size = new Size(489, 421);
            dgvSubjects.TabIndex = 1;
            // 
            // usSubject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvSubjects);
            Controls.Add(groupBox1);
            Name = "usSubject";
            Size = new Size(1073, 705);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrCredits).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSubjectCode;
        private Label label1;
        private Label label2;
        private TextBox txtSubjectName;
        private NumericUpDown nmrCredits;
        private Label label3;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private DataGridView dgvSubjects;
    }
}
