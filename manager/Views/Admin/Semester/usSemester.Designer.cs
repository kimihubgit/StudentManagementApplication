namespace manager.Views.Admin.Semester
{
    partial class usSemester
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvSemester;
        private System.Windows.Forms.TextBox txtSemesterName;
        private System.Windows.Forms.Label lblSemesterName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSchoolYear;
        private System.Windows.Forms.Label lblSchoolYear;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvSemester = new DataGridView();
            txtSemesterName = new TextBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            txtSchoolYear = new TextBox();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            btnClear = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSemester).BeginInit();
            SuspendLayout();
            // 
            // dgvSemester
            // 
            dgvSemester.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSemester.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSemester.Location = new Point(20, 120);
            dgvSemester.Name = "dgvSemester";
            dgvSemester.Size = new Size(1033, 560);
            dgvSemester.TabIndex = 0;
            dgvSemester.CellClick += dgvSemester_CellClick;
            // 
            // txtSemesterName
            // 
            txtSemesterName.Location = new Point(120, 20);
            txtSemesterName.Name = "txtSemesterName";
            txtSemesterName.Size = new Size(240, 23);
            txtSemesterName.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(20, 86);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(240, 23);
            txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(270, 86);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 25);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSchoolYear
            // 
            txtSchoolYear.Location = new Point(120, 55);
            txtSchoolYear.Name = "txtSchoolYear";
            txtSchoolYear.Size = new Size(240, 23);
            txtSchoolYear.TabIndex = 4;
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(520, 20);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(240, 23);
            dtpStart.TabIndex = 6;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(520, 55);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(240, 23);
            dtpEnd.TabIndex = 8;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(780, 20);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 25);
            btnClear.TabIndex = 5;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(780, 50);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 25);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(870, 50);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 25);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(960, 50);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 25);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 23);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 9;
            label1.Text = "Tên học kỳ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 60);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 10;
            label2.Text = "Năm học";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(427, 23);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 11;
            label3.Text = "Ngày bắt đầu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(427, 58);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 12;
            label4.Text = "Ngày kết thúc";
            // 
            // usSemester
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnClear);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(txtSchoolYear);
            Controls.Add(txtSemesterName);
            Controls.Add(dgvSemester);
            Name = "usSemester";
            Size = new Size(1073, 705);
            Load += usSemester_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSemester).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
