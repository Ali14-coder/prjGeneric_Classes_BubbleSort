namespace prjGeneric_Classes_BubbleSort
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
            lblStudentName = new Label();
            lblRes2 = new Label();
            lblRes3 = new Label();
            lblRes1 = new Label();
            lblAverage = new Label();
            lblRes5 = new Label();
            lblRes4 = new Label();
            txtRes1 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtRes5 = new TextBox();
            txtRes3 = new TextBox();
            txtRes4 = new TextBox();
            txtRes2 = new TextBox();
            txtAverage = new TextBox();
            btnOrderResults = new Button();
            SuspendLayout();
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new Point(40, 31);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(91, 15);
            lblStudentName.TabIndex = 0;
            lblStudentName.Text = "Student Names:";
            // 
            // lblRes2
            // 
            lblRes2.AutoSize = true;
            lblRes2.Location = new Point(40, 117);
            lblRes2.Name = "lblRes2";
            lblRes2.Size = new Size(51, 15);
            lblRes2.TabIndex = 1;
            lblRes2.Text = "Result 2:";
            // 
            // lblRes3
            // 
            lblRes3.AutoSize = true;
            lblRes3.Location = new Point(40, 159);
            lblRes3.Name = "lblRes3";
            lblRes3.Size = new Size(51, 15);
            lblRes3.TabIndex = 2;
            lblRes3.Text = "Result 3:";
            // 
            // lblRes1
            // 
            lblRes1.AutoSize = true;
            lblRes1.Location = new Point(40, 70);
            lblRes1.Name = "lblRes1";
            lblRes1.Size = new Size(51, 15);
            lblRes1.TabIndex = 3;
            lblRes1.Text = "Result 1:";
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(40, 283);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(53, 15);
            lblAverage.TabIndex = 4;
            lblAverage.Text = "Average:";
            // 
            // lblRes5
            // 
            lblRes5.AutoSize = true;
            lblRes5.Location = new Point(40, 241);
            lblRes5.Name = "lblRes5";
            lblRes5.Size = new Size(51, 15);
            lblRes5.TabIndex = 5;
            lblRes5.Text = "Result 5:";
            // 
            // lblRes4
            // 
            lblRes4.AutoSize = true;
            lblRes4.Location = new Point(40, 201);
            lblRes4.Name = "lblRes4";
            lblRes4.Size = new Size(51, 15);
            lblRes4.TabIndex = 6;
            lblRes4.Text = "Result 4:";
            // 
            // txtRes1
            // 
            txtRes1.Location = new Point(123, 67);
            txtRes1.Name = "txtRes1";
            txtRes1.Size = new Size(152, 23);
            txtRes1.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(147, 187);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(155, 195);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(163, 203);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 10;
            // 
            // txtRes5
            // 
            txtRes5.Location = new Point(123, 241);
            txtRes5.Name = "txtRes5";
            txtRes5.Size = new Size(152, 23);
            txtRes5.TabIndex = 12;
            // 
            // txtRes3
            // 
            txtRes3.Location = new Point(123, 161);
            txtRes3.Name = "txtRes3";
            txtRes3.Size = new Size(152, 23);
            txtRes3.TabIndex = 13;
            // 
            // txtRes4
            // 
            txtRes4.Location = new Point(123, 201);
            txtRes4.Name = "txtRes4";
            txtRes4.Size = new Size(152, 23);
            txtRes4.TabIndex = 14;
            // 
            // txtRes2
            // 
            txtRes2.Location = new Point(123, 117);
            txtRes2.Name = "txtRes2";
            txtRes2.Size = new Size(152, 23);
            txtRes2.TabIndex = 15;
            // 
            // txtAverage
            // 
            txtAverage.Location = new Point(123, 283);
            txtAverage.Name = "txtAverage";
            txtAverage.Size = new Size(152, 23);
            txtAverage.TabIndex = 16;
            // 
            // btnOrderResults
            // 
            btnOrderResults.Location = new Point(94, 324);
            btnOrderResults.Name = "btnOrderResults";
            btnOrderResults.Size = new Size(134, 23);
            btnOrderResults.TabIndex = 17;
            btnOrderResults.Text = "ORDER RESULTS";
            btnOrderResults.UseVisualStyleBackColor = true;
            btnOrderResults.Click += btnOrderResults_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 397);
            Controls.Add(btnOrderResults);
            Controls.Add(txtAverage);
            Controls.Add(txtRes2);
            Controls.Add(txtRes4);
            Controls.Add(txtRes3);
            Controls.Add(txtRes5);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtRes1);
            Controls.Add(lblRes4);
            Controls.Add(lblRes5);
            Controls.Add(lblAverage);
            Controls.Add(lblRes1);
            Controls.Add(lblRes3);
            Controls.Add(lblRes2);
            Controls.Add(lblStudentName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentName;
        private Label lblRes2;
        private Label lblRes3;
        private Label lblRes1;
        private Label lblAverage;
        private Label lblRes5;
        private Label lblRes4;
        private TextBox txtRes1;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtRes5;
        private TextBox txtRes3;
        private TextBox txtRes4;
        private TextBox txtRes2;
        private TextBox txtAverage;
        private Button btnOrderResults;
    }
}
