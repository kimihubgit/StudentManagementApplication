namespace manager.Views.Teacher.QuanLyDiem
{
    partial class usQuanLyDiem
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            comboBox3 = new ComboBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(21, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(184, 23);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Học kì";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 21);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Lớp Học";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(222, 48);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(192, 23);
            comboBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(439, 21);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Môn Học";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(439, 48);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(215, 23);
            comboBox3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1039, 533);
            dataGridView1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(919, 651);
            button2.Name = "button2";
            button2.Size = new Size(140, 37);
            button2.TabIndex = 10;
            button2.Text = "Export";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(763, 651);
            button1.Name = "button1";
            button1.Size = new Size(140, 37);
            button1.TabIndex = 9;
            button1.Text = "Import";
            button1.UseVisualStyleBackColor = true;
            // 
            // usQuanLyDiem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(comboBox3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "usQuanLyDiem";
            Size = new Size(1073, 702);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label3;
        private ComboBox comboBox3;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
    }
}
