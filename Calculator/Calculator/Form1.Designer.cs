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
            textDisplay = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            dot = new Button();
            clear = new Button();
            button_add = new Button();
            button_subtract = new Button();
            button_multi = new Button();
            button_divide = new Button();
            button_equal = new Button();
            SuspendLayout();
            // 
            // textDisplay
            // 
            textDisplay.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            textDisplay.Location = new Point(31, 12);
            textDisplay.Multiline = true;
            textDisplay.Name = "textDisplay";
            textDisplay.Size = new Size(412, 67);
            textDisplay.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(31, 95);
            button1.Name = "button1";
            button1.Size = new Size(71, 72);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(108, 95);
            button2.Name = "button2";
            button2.Size = new Size(71, 72);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(185, 95);
            button3.Name = "button3";
            button3.Size = new Size(71, 72);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(31, 173);
            button4.Name = "button4";
            button4.Size = new Size(71, 72);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(108, 173);
            button5.Name = "button5";
            button5.Size = new Size(71, 72);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(185, 173);
            button6.Name = "button6";
            button6.Size = new Size(71, 72);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(31, 251);
            button7.Name = "button7";
            button7.Size = new Size(71, 72);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(108, 251);
            button8.Name = "button8";
            button8.Size = new Size(71, 72);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(185, 251);
            button9.Name = "button9";
            button9.Size = new Size(71, 72);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button0.Location = new Point(31, 331);
            button0.Name = "button0";
            button0.Size = new Size(71, 72);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // dot
            // 
            dot.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            dot.Location = new Point(108, 331);
            dot.Name = "dot";
            dot.Size = new Size(71, 72);
            dot.TabIndex = 10;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = true;
            dot.Click += dot_Click;
            // 
            // clear
            // 
            clear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            clear.Location = new Point(185, 331);
            clear.Name = "clear";
            clear.Size = new Size(71, 72);
            clear.TabIndex = 11;
            clear.Text = "CLR";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // button_add
            // 
            button_add.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_add.Location = new Point(287, 136);
            button_add.Name = "button_add";
            button_add.Size = new Size(75, 72);
            button_add.TabIndex = 13;
            button_add.Text = "+";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_subtract
            // 
            button_subtract.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_subtract.Location = new Point(380, 136);
            button_subtract.Name = "button_subtract";
            button_subtract.Size = new Size(75, 72);
            button_subtract.TabIndex = 14;
            button_subtract.Text = "-";
            button_subtract.UseVisualStyleBackColor = true;
            button_subtract.Click += button_subtract_Click;
            // 
            // button_multi
            // 
            button_multi.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_multi.Location = new Point(287, 228);
            button_multi.Name = "button_multi";
            button_multi.Size = new Size(75, 72);
            button_multi.TabIndex = 15;
            button_multi.Text = "*";
            button_multi.UseVisualStyleBackColor = true;
            button_multi.Click += button_multi_Click;
            // 
            // button_divide
            // 
            button_divide.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_divide.Location = new Point(380, 228);
            button_divide.Name = "button_divide";
            button_divide.Size = new Size(75, 72);
            button_divide.TabIndex = 16;
            button_divide.Text = "/";
            button_divide.UseVisualStyleBackColor = true;
            button_divide.Click += button_divide_Click;
            // 
            // button_equal
            // 
            button_equal.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_equal.Location = new Point(287, 322);
            button_equal.Name = "button_equal";
            button_equal.Size = new Size(168, 72);
            button_equal.TabIndex = 17;
            button_equal.Text = "=";
            button_equal.UseVisualStyleBackColor = true;
            button_equal.Click += button_equal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 415);
            Controls.Add(button_equal);
            Controls.Add(button_divide);
            Controls.Add(button_multi);
            Controls.Add(button_subtract);
            Controls.Add(button_add);
            Controls.Add(clear);
            Controls.Add(dot);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textDisplay);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textDisplay;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button dot;
        private Button clear;
        private Button add;
        private Button subtract;
        private Button multiply;
        private Button divide;
        private Button equal;
        private Button button_add;
        private Button button_subtract;
        private Button button_multi;
        private Button button_divide;
        private Button button_equal;
    }
}