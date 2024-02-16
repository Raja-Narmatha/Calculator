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
            txtTotal = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            clear = new Button();
            div = new Button();
            mul = new Button();
            sub = new Button();
            add = new Button();
            res = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.Location = new Point(19, 35);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(456, 69);
            txtTotal.TabIndex = 0;
            txtTotal.TextChanged += textBox1_TextChanged;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(19, 134);
            btn1.Name = "btn1";
            btn1.Size = new Size(85, 50);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(110, 134);
            btn2.Name = "btn2";
            btn2.Size = new Size(85, 50);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(201, 134);
            btn3.Name = "btn3";
            btn3.Size = new Size(85, 50);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(292, 134);
            btn4.Name = "btn4";
            btn4.Size = new Size(85, 50);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(383, 134);
            btn5.Name = "btn5";
            btn5.Size = new Size(85, 50);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(19, 201);
            btn6.Name = "btn6";
            btn6.Size = new Size(85, 50);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(110, 201);
            btn7.Name = "btn7";
            btn7.Size = new Size(85, 50);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(201, 201);
            btn8.Name = "btn8";
            btn8.Size = new Size(85, 50);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(292, 201);
            btn9.Name = "btn9";
            btn9.Size = new Size(85, 50);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(383, 201);
            btn0.Name = "btn0";
            btn0.Size = new Size(85, 50);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // clear
            // 
            clear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            clear.Location = new Point(383, 257);
            clear.Name = "clear";
            clear.Size = new Size(85, 50);
            clear.TabIndex = 15;
            clear.Text = "clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // div
            // 
            div.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            div.Location = new Point(292, 257);
            div.Name = "div";
            div.Size = new Size(85, 50);
            div.TabIndex = 14;
            div.Text = "/";
            div.UseVisualStyleBackColor = true;
            div.Click += div_Click;
            // 
            // mul
            // 
            mul.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            mul.Location = new Point(201, 257);
            mul.Name = "mul";
            mul.Size = new Size(85, 50);
            mul.TabIndex = 13;
            mul.Text = "*";
            mul.UseVisualStyleBackColor = true;
            mul.Click += mul_Click;
            // 
            // sub
            // 
            sub.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            sub.Location = new Point(110, 257);
            sub.Name = "sub";
            sub.Size = new Size(85, 50);
            sub.TabIndex = 12;
            sub.Text = "-";
            sub.UseVisualStyleBackColor = true;
            sub.Click += sub_Click;
            // 
            // add
            // 
            add.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            add.Location = new Point(19, 257);
            add.Name = "add";
            add.Size = new Size(85, 50);
            add.TabIndex = 11;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // res
            // 
            res.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            res.Location = new Point(19, 313);
            res.Name = "res";
            res.Size = new Size(449, 50);
            res.TabIndex = 16;
            res.Text = "=";
            res.UseVisualStyleBackColor = true;
            res.Click += res_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 383);
            Controls.Add(res);
            Controls.Add(clear);
            Controls.Add(div);
            Controls.Add(mul);
            Controls.Add(sub);
            Controls.Add(add);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtTotal);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button clear;
        private Button div;
        private Button mul;
        private Button sub;
        private Button add;
        private Button res;
    }
}
