namespace Calculator
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            clear = new Button();
            btn0 = new Button();
            answer = new Button();
            plus = new Button();
            minus = new Button();
            divid = new Button();
            multiply = new Button();
            txtproc = new TextBox();
            del = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(39, 208);
            btn1.Name = "btn1";
            btn1.Size = new Size(50, 50);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn7_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(125, 208);
            btn2.Name = "btn2";
            btn2.Size = new Size(50, 50);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn7_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(211, 208);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 50);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(39, 142);
            btn4.Name = "btn4";
            btn4.Size = new Size(50, 50);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn7_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(125, 142);
            btn5.Name = "btn5";
            btn5.Size = new Size(50, 50);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(211, 142);
            btn6.Name = "btn6";
            btn6.Size = new Size(50, 50);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn7_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(39, 76);
            btn7.Name = "btn7";
            btn7.Size = new Size(50, 50);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(125, 76);
            btn8.Name = "btn8";
            btn8.Size = new Size(50, 50);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn7_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(211, 76);
            btn9.Name = "btn9";
            btn9.Size = new Size(50, 50);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn7_Click;
            // 
            // clear
            // 
            clear.Location = new Point(39, 270);
            clear.Name = "clear";
            clear.Size = new Size(50, 50);
            clear.TabIndex = 9;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(125, 270);
            btn0.Name = "btn0";
            btn0.Size = new Size(50, 50);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn7_Click;
            // 
            // answer
            // 
            answer.Location = new Point(211, 270);
            answer.Name = "answer";
            answer.Size = new Size(50, 50);
            answer.TabIndex = 11;
            answer.Text = "=";
            answer.UseVisualStyleBackColor = true;
            answer.Click += answer_Click;
            // 
            // plus
            // 
            plus.Location = new Point(283, 76);
            plus.Name = "plus";
            plus.Size = new Size(50, 50);
            plus.TabIndex = 12;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += btn7_Click;
            // 
            // minus
            // 
            minus.Location = new Point(283, 142);
            minus.Name = "minus";
            minus.Size = new Size(50, 50);
            minus.TabIndex = 13;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += btn7_Click;
            // 
            // divid
            // 
            divid.Location = new Point(283, 208);
            divid.Name = "divid";
            divid.Size = new Size(50, 50);
            divid.TabIndex = 14;
            divid.Text = "/";
            divid.UseVisualStyleBackColor = true;
            divid.Click += btn7_Click;
            // 
            // multiply
            // 
            multiply.Location = new Point(283, 270);
            multiply.Name = "multiply";
            multiply.Size = new Size(50, 50);
            multiply.TabIndex = 15;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += btn7_Click;
            // 
            // txtproc
            // 
            txtproc.Location = new Point(125, 23);
            txtproc.Name = "txtproc";
            txtproc.ReadOnly = true;
            txtproc.Size = new Size(208, 27);
            txtproc.TabIndex = 16;
            // 
            // del
            // 
            del.Location = new Point(39, 23);
            del.Name = "del";
            del.Size = new Size(50, 27);
            del.TabIndex = 17;
            del.Text = "del";
            del.UseVisualStyleBackColor = true;
            del.Click += del_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 420);
            Controls.Add(del);
            Controls.Add(txtproc);
            Controls.Add(multiply);
            Controls.Add(divid);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(answer);
            Controls.Add(btn0);
            Controls.Add(clear);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button clear;
        private Button btn0;
        private Button answer;
        private Button plus;
        private Button minus;
        private Button divid;
        private Button multiply;
        private TextBox txtproc;
        private Button del;
    }
}
