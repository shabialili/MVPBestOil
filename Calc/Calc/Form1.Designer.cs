
namespace Calc
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
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_three = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_one = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_nine = new System.Windows.Forms.Button();
            this.btn_eight = new System.Windows.Forms.Button();
            this.btn_seven = new System.Windows.Forms.Button();
            this.btn_six = new System.Windows.Forms.Button();
            this.btn_five = new System.Windows.Forms.Button();
            this.btn_four = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_div
            // 
            this.btn_div.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_div.Location = new System.Drawing.Point(269, 179);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(70, 70);
            this.btn_div.TabIndex = 3;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sub.Location = new System.Drawing.Point(268, 331);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(70, 70);
            this.btn_sub.TabIndex = 7;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_three
            // 
            this.btn_three.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_three.Location = new System.Drawing.Point(192, 331);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(70, 70);
            this.btn_three.TabIndex = 6;
            this.btn_three.Text = "3";
            this.btn_three.UseVisualStyleBackColor = true;
            this.btn_three.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_two
            // 
            this.btn_two.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_two.Location = new System.Drawing.Point(116, 331);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(70, 70);
            this.btn_two.TabIndex = 5;
            this.btn_two.Text = "2";
            this.btn_two.UseVisualStyleBackColor = true;
            this.btn_two.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_one
            // 
            this.btn_one.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_one.Location = new System.Drawing.Point(41, 331);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(70, 70);
            this.btn_one.TabIndex = 4;
            this.btn_one.Text = "1";
            this.btn_one.UseVisualStyleBackColor = true;
            this.btn_one.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_mult.Location = new System.Drawing.Point(268, 255);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(70, 70);
            this.btn_mult.TabIndex = 11;
            this.btn_mult.Text = "*";
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_point
            // 
            this.btn_point.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_point.Location = new System.Drawing.Point(192, 407);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(70, 70);
            this.btn_point.TabIndex = 15;
            this.btn_point.Text = ".";
            this.btn_point.UseVisualStyleBackColor = true;
            this.btn_point.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_sum
            // 
            this.btn_sum.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sum.Location = new System.Drawing.Point(268, 407);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(70, 70);
            this.btn_sum.TabIndex = 14;
            this.btn_sum.Text = "+";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_equal.Location = new System.Drawing.Point(345, 179);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(70, 298);
            this.btn_equal.TabIndex = 13;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_zero
            // 
            this.btn_zero.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_zero.Location = new System.Drawing.Point(42, 407);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(145, 70);
            this.btn_zero.TabIndex = 12;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = true;
            this.btn_zero.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_nine
            // 
            this.btn_nine.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_nine.Location = new System.Drawing.Point(193, 179);
            this.btn_nine.Name = "btn_nine";
            this.btn_nine.Size = new System.Drawing.Size(70, 70);
            this.btn_nine.TabIndex = 16;
            this.btn_nine.Text = "9";
            this.btn_nine.UseVisualStyleBackColor = true;
            this.btn_nine.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_eight
            // 
            this.btn_eight.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_eight.Location = new System.Drawing.Point(117, 179);
            this.btn_eight.Name = "btn_eight";
            this.btn_eight.Size = new System.Drawing.Size(70, 70);
            this.btn_eight.TabIndex = 17;
            this.btn_eight.Text = "8";
            this.btn_eight.UseVisualStyleBackColor = true;
            this.btn_eight.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_seven
            // 
            this.btn_seven.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_seven.Location = new System.Drawing.Point(41, 179);
            this.btn_seven.Name = "btn_seven";
            this.btn_seven.Size = new System.Drawing.Size(70, 70);
            this.btn_seven.TabIndex = 18;
            this.btn_seven.Text = "7";
            this.btn_seven.UseVisualStyleBackColor = true;
            this.btn_seven.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_six
            // 
            this.btn_six.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_six.Location = new System.Drawing.Point(192, 255);
            this.btn_six.Name = "btn_six";
            this.btn_six.Size = new System.Drawing.Size(70, 70);
            this.btn_six.TabIndex = 19;
            this.btn_six.Text = "6";
            this.btn_six.UseVisualStyleBackColor = true;
            this.btn_six.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_five
            // 
            this.btn_five.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_five.Location = new System.Drawing.Point(117, 255);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(70, 70);
            this.btn_five.TabIndex = 20;
            this.btn_five.Text = "5";
            this.btn_five.UseVisualStyleBackColor = true;
            this.btn_five.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_four
            // 
            this.btn_four.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_four.Location = new System.Drawing.Point(41, 255);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(70, 70);
            this.btn_four.TabIndex = 21;
            this.btn_four.Text = "4";
            this.btn_four.UseVisualStyleBackColor = true;
            this.btn_four.Click += new System.EventHandler(this.Button_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Result.Location = new System.Drawing.Point(42, 112);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(373, 44);
            this.Result.TabIndex = 22;
            this.Result.Text = "0";
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Result.Click += new System.EventHandler(this.Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 498);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.btn_four);
            this.Controls.Add(this.btn_five);
            this.Controls.Add(this.btn_six);
            this.Controls.Add(this.btn_seven);
            this.Controls.Add(this.btn_eight);
            this.Controls.Add(this.btn_nine);
            this.Controls.Add(this.btn_point);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_mult);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_three);
            this.Controls.Add(this.btn_two);
            this.Controls.Add(this.btn_one);
            this.Controls.Add(this.btn_div);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_three;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Button btn_nine;
        private System.Windows.Forms.Button btn_eight;
        private System.Windows.Forms.Button btn_seven;
        private System.Windows.Forms.Button btn_six;
        private System.Windows.Forms.Button btn_five;
        private System.Windows.Forms.Button btn_four;
        private System.Windows.Forms.TextBox Result;
    }
}

