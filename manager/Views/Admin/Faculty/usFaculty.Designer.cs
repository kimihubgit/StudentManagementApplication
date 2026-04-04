namespace manager.Views.Admin.Faculty
{
    partial class usFaculty
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtMaKhoa = new TextBox();
            txtTenKhoa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dtpNgayThanhLap = new DateTimePicker();
            label3 = new Label();
            dgvKhoa = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(34, 39);
            button1.Name = "button1";
            button1.Size = new Size(130, 50);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(180, 39);
            button2.Name = "button2";
            button2.Size = new Size(130, 50);
            button2.TabIndex = 1;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(325, 39);
            button3.Name = "button3";
            button3.Size = new Size(130, 50);
            button3.TabIndex = 2;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(481, 39);
            button4.Name = "button4";
            button4.Size = new Size(130, 50);
            button4.TabIndex = 3;
            button4.Text = "Làm Mới";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(762, 39);
            button5.Name = "button5";
            button5.Size = new Size(130, 50);
            button5.TabIndex = 4;
            button5.Text = "Import";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(920, 39);
            button6.Name = "button6";
            button6.Size = new Size(130, 50);
            button6.TabIndex = 5;
            button6.Text = "Export";
            button6.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new Point(34, 137);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(252, 27);
            txtMaKhoa.TabIndex = 7;
            txtMaKhoa.TextChanged += textBox1_TextChanged;
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Location = new Point(325, 137);
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(252, 27);
            txtTenKhoa.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 114);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 9;
            label1.Text = "Mã Khoa ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 114);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 10;
            label2.Text = "Tên Khoa";
            // 
            // dtpNgayThanhLap
            // 
            dtpNgayThanhLap.Location = new Point(662, 137);
            dtpNgayThanhLap.Name = "dtpNgayThanhLap";
            dtpNgayThanhLap.Size = new Size(308, 27);
            dtpNgayThanhLap.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(662, 114);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 12;
            label3.Text = "Ngày Thành Lập ";
            // 
            // dgvKhoa
            // 
            dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoa.Location = new Point(34, 202);
            dgvKhoa.Name = "dgvKhoa";
            dgvKhoa.RowHeadersWidth = 51;
            dgvKhoa.Size = new Size(1016, 465);
            dgvKhoa.TabIndex = 13;
            // 
            // usFaculty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvKhoa);
            Controls.Add(label3);
            Controls.Add(dtpNgayThanhLap);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTenKhoa);
            Controls.Add(txtMaKhoa);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "usFaculty";
            Size = new Size(1073, 705);
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtMaKhoa;
        private TextBox txtTenKhoa;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpNgayThanhLap;
        private Label label3;
        private DataGridView dgvKhoa;
    }
}
