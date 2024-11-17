namespace example_of_dynamic_memory_usage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtStudentName = new TextBox();
            label1 = new Label();
            btnAddStudent = new Button();
            btnRemoveStudent = new Button();
            lstStudents = new ListBox();
            SuspendLayout();
            // 
            // txtStudentName
            // 
            txtStudentName.Font = new Font("Segoe UI", 15F);
            txtStudentName.Location = new Point(141, 60);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(447, 34);
            txtStudentName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(141, 29);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 1;
            label1.Text = "Student Name";
            // 
            // btnAddStudent
            // 
            btnAddStudent.Font = new Font("Segoe UI", 14F);
            btnAddStudent.Location = new Point(210, 114);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(152, 38);
            btnAddStudent.TabIndex = 2;
            btnAddStudent.Text = "Add";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnRemoveStudent
            // 
            btnRemoveStudent.Font = new Font("Segoe UI", 14F);
            btnRemoveStudent.Location = new Point(387, 114);
            btnRemoveStudent.Name = "btnRemoveStudent";
            btnRemoveStudent.Size = new Size(152, 38);
            btnRemoveStudent.TabIndex = 3;
            btnRemoveStudent.Text = "Remove";
            btnRemoveStudent.UseVisualStyleBackColor = true;
            btnRemoveStudent.Click += btnRemoveStudent_Click;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 15;
            lstStudents.Location = new Point(141, 202);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(438, 184);
            lstStudents.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstStudents);
            Controls.Add(btnRemoveStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(label1);
            Controls.Add(txtStudentName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentName;
        private Label label1;
        private Button btnAddStudent;
        private Button btnRemoveStudent;
        private ListBox lstStudents;
    }
}
