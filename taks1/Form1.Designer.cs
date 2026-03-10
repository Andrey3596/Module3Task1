namespace taks1
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
            label1 = new Label();
            label2 = new Label();
            textVector1x = new TextBox();
            textVector2x = new TextBox();
            textVector1y = new TextBox();
            textVector1z = new TextBox();
            textVector2y = new TextBox();
            textVector2z = new TextBox();
            textVectorlength1 = new TextBox();
            textVectorlength2 = new TextBox();
            label5 = new Label();
            textResult = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbOperation = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 30);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Вектор 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 57);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Вектор 2";
            // 
            // textVector1x
            // 
            textVector1x.Location = new Point(101, 22);
            textVector1x.Name = "textVector1x";
            textVector1x.Size = new Size(31, 23);
            textVector1x.TabIndex = 2;
            textVector1x.TextChanged += textVector1x_TextChanged;
            // 
            // textVector2x
            // 
            textVector2x.Location = new Point(101, 49);
            textVector2x.Name = "textVector2x";
            textVector2x.Size = new Size(31, 23);
            textVector2x.TabIndex = 3;
            textVector2x.TextChanged += textVector2x_TextChanged;
            // 
            // textVector1y
            // 
            textVector1y.Location = new Point(138, 22);
            textVector1y.Name = "textVector1y";
            textVector1y.Size = new Size(31, 23);
            textVector1y.TabIndex = 4;
            textVector1y.TextChanged += textVector1y_TextChanged;
            // 
            // textVector1z
            // 
            textVector1z.Location = new Point(175, 22);
            textVector1z.Name = "textVector1z";
            textVector1z.Size = new Size(31, 23);
            textVector1z.TabIndex = 5;
            textVector1z.TextChanged += textVector1z_TextChanged;
            // 
            // textVector2y
            // 
            textVector2y.Location = new Point(138, 49);
            textVector2y.Name = "textVector2y";
            textVector2y.Size = new Size(31, 23);
            textVector2y.TabIndex = 6;
            textVector2y.TextChanged += textVector2y_TextChanged;
            // 
            // textVector2z
            // 
            textVector2z.Location = new Point(175, 49);
            textVector2z.Name = "textVector2z";
            textVector2z.Size = new Size(31, 23);
            textVector2z.TabIndex = 7;
            textVector2z.TextChanged += textVector2z_TextChanged;
            // 
            // textVectorlength1
            // 
            textVectorlength1.Location = new Point(341, 22);
            textVectorlength1.Name = "textVectorlength1";
            textVectorlength1.Size = new Size(41, 23);
            textVectorlength1.TabIndex = 10;
            // 
            // textVectorlength2
            // 
            textVectorlength2.Location = new Point(341, 49);
            textVectorlength2.Name = "textVectorlength2";
            textVectorlength2.Size = new Size(41, 23);
            textVectorlength2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 110);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 12;
            label5.Text = "Результат операций";
            // 
            // textResult
            // 
            textResult.Location = new Point(138, 107);
            textResult.Name = "textResult";
            textResult.Size = new Size(226, 23);
            textResult.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 4);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 20;
            label6.Text = "X";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(138, 4);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 21;
            label7.Text = "Y";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(175, 4);
            label8.Name = "label8";
            label8.Size = new Size(14, 15);
            label8.TabIndex = 22;
            label8.Text = "Z";
            // 
            // cmbOperation
            // 
            cmbOperation.FormattingEnabled = true;
            cmbOperation.Location = new Point(18, 78);
            cmbOperation.Name = "cmbOperation";
            cmbOperation.Size = new Size(121, 23);
            cmbOperation.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 24);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 24;
            label3.Text = "Длинна вектора 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(225, 52);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 25;
            label4.Text = "Длинна вектора 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 146);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbOperation);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textResult);
            Controls.Add(label5);
            Controls.Add(textVectorlength2);
            Controls.Add(textVectorlength1);
            Controls.Add(textVector2z);
            Controls.Add(textVector2y);
            Controls.Add(textVector1z);
            Controls.Add(textVector1y);
            Controls.Add(textVector2x);
            Controls.Add(textVector1x);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textVector1x;
        private TextBox textVector2x;
        private TextBox textVector1y;
        private TextBox textVector1z;
        private TextBox textVector2y;
        private TextBox textVector2z;
        private TextBox textVectorlength1;
        private TextBox textVectorlength2;
        private Label label5;
        private TextBox textResult;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cmbOperation;
        private Label label3;
        private Label label4;
    }
}
