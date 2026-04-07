namespace manager.Views.Admin.TongQuan
{
    partial class usTongQuan
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            countTeacher = new Label();
            label3 = new Label();
            panel1 = new Panel();
            countStudent = new Label();
            svtotal = new Label();
            countClass = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1192, 608);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.Controls.Add(countClass);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(797, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(349, 100);
            panel3.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 14);
            label5.Name = "label5";
            label5.Size = new Size(176, 24);
            label5.TabIndex = 2;
            label5.Text = "Số Lớp Học Phần";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(countTeacher);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(400, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 100);
            panel2.TabIndex = 4;
            // 
            // countTeacher
            // 
            countTeacher.AutoSize = true;
            countTeacher.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            countTeacher.ForeColor = SystemColors.HotTrack;
            countTeacher.Location = new Point(21, 52);
            countTeacher.Name = "countTeacher";
            countTeacher.Size = new Size(29, 32);
            countTeacher.TabIndex = 3;
            countTeacher.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 14);
            label3.Name = "label3";
            label3.Size = new Size(144, 24);
            label3.TabIndex = 2;
            label3.Text = "Số Giảng Viên";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(countStudent);
            panel1.Controls.Add(svtotal);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 100);
            panel1.TabIndex = 0;
            // 
            // countStudent
            // 
            countStudent.AutoSize = true;
            countStudent.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            countStudent.ForeColor = SystemColors.HotTrack;
            countStudent.Location = new Point(21, 52);
            countStudent.Name = "countStudent";
            countStudent.Size = new Size(29, 32);
            countStudent.TabIndex = 3;
            countStudent.Text = "0";
            // 
            // svtotal
            // 
            svtotal.AutoSize = true;
            svtotal.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            svtotal.Location = new Point(21, 14);
            svtotal.Name = "svtotal";
            svtotal.Size = new Size(130, 24);
            svtotal.TabIndex = 2;
            svtotal.Text = "Số Sinh Viên";
            // 
            // countClass
            // 
            countClass.AutoSize = true;
            countClass.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            countClass.ForeColor = SystemColors.HotTrack;
            countClass.Location = new Point(21, 52);
            countClass.Name = "countClass";
            countClass.Size = new Size(29, 32);
            countClass.TabIndex = 4;
            countClass.Text = "0";
            // 
            // usTongQuan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "usTongQuan";
            Size = new Size(1192, 608);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Label label4;
        private Label label5;
        private Panel panel2;
        private Label countTeacher;
        private Label label3;
        private Panel panel1;
        private Label countStudent;
        private Label svtotal;
        private Label countClass;
    }
}
